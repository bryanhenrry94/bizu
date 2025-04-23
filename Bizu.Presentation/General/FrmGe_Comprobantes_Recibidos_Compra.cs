using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bizu.Domain.General;
using Bizu.Application.General;
using System.Xml;
using System.Xml.Serialization;
using Bizu.Presentation.CuentasxPagar;
using Bizu.Application.CuentasxPagar;
using Bizu.Domain.CuentasxPagar;

namespace Bizu.Presentation.General
{
    public partial class FrmGe_Comprobantes_Recibidos_Compra : DevExpress.XtraEditors.XtraForm
    {
        public delegate void delegate_FrmGe_Comprobantes_Recibidos_Cons_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmGe_Comprobantes_Recibidos_Cons_FormClosing event_FrmGe_Comprobantes_Recibidos_Cons_FormClosing;

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        //tb_Comprobantes_Recibidos_Bus Bus_Comprobantes_Recibidos = new tb_Comprobantes_Recibidos_Bus();
        //List<tb_Comprobantes_Recibidos_Info> List_Comprobantes_Recibidos = new List<tb_Comprobantes_Recibidos_Info>();
        //BindingList<tb_Comprobantes_Recibidos_Info> BindingList_Comprobantes_Recibidos = new BindingList<tb_Comprobantes_Recibidos_Info>();
        //BindingList<tb_Comprobantes_Recibidos_Info> BindingList_Comprobantes_Recibidos_Error = new BindingList<tb_Comprobantes_Recibidos_Info>();
        //public tb_Comprobantes_Recibidos_Info Row_Selected;

        tb_persona_bus BusPersona = new tb_persona_bus();
        cp_proveedor_Bus BusProveedor = new cp_proveedor_Bus();
        cp_orden_giro_Bus BusOrdenGiro = new cp_orden_giro_Bus();

        private tb_ComprobantesRecibidos_Bus Bus_Comprobantes_Recibidos = new tb_ComprobantesRecibidos_Bus();
        private List<tb_ComprobantesRecibidos_Info> List_Comprobantes_Recibidos = new List<tb_ComprobantesRecibidos_Info>();
        private BindingList<tb_ComprobantesRecibidos_Info> BindingList_Comprobantes_Recibidos = new BindingList<tb_ComprobantesRecibidos_Info>();
        public tb_ComprobantesRecibidos_Info Row_Selected = new tb_ComprobantesRecibidos_Info();


        public bool bAcepto = false;

        public FrmGe_Comprobantes_Recibidos_Compra()
        {
            InitializeComponent();

            ucGe_Menu.event_beiBuscar_ItemClick += ucGe_Menu_event_beiBuscar_ItemClick;
            ucGe_Menu.event_btnProvisionarFactura_ItemClick += ucGe_Menu_event_btnProvisionarFactura_ItemClick;
            ucGe_Menu.event_btnAceptar_ItemClick += ucGe_Menu_event_btnAceptar_ItemClick;
            ucGe_Menu.event_btnEliminar_ItemClick += ucGe_Menu_event_btnEliminar_ItemClick;
            ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_event_btnSalir_ItemClick;
            ucGe_Menu.event_btnImprimir_ItemClick += ucGe_Menu_event_btnImprimir_ItemClick;

            event_FrmGe_Comprobantes_Recibidos_Cons_FormClosing += FrmGe_Comprobantes_Recibidos_Cons_event_FrmGe_Comprobantes_Recibidos_Cons_FormClosing;
        }

        void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl_ComprobantesRecibidos.ShowPrintPreview();
        }

        void ucGe_Menu_event_btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                cp_orden_giro_Bus Bus_OrdenGiro = new cp_orden_giro_Bus();

                if (MessageBox.Show("Se procedera a eliminar los archivos seleccionados. ¿Desea continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                    return;

                foreach (var item in BindingList_Comprobantes_Recibidos.Where(q => q.Checked))
                {
                    bool bEliminar = false;

                    if (item.TipoComprobante == "Factura")
                    {
                        // Dividir la cadena en partes utilizando el carácter "-"
                        string[] partes = item.SerieComprobante.Split('-');

                        // Asignar cada parte a las variables correspondientes
                        string Establecimiento = partes[0];
                        string PuntoEmision = partes[1];
                        string NumeroDocumento = partes[2];

                        string Serie = $"{Establecimiento}-{PuntoEmision}";
                        
                        if (!Bus_OrdenGiro.ExisteFacturaPorProveedor(param.IdEmpresa, item.RucEmisor, Serie, NumeroDocumento))
                        {
                            if (MessageBox.Show("Comprobante de proveedor " + item.RazonSocialEmisor + " " + item.SerieComprobante + " no esta registrada en el sistema, ¿seguro desea eliminar el documento?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                bEliminar = true;
                        }
                        else
                            bEliminar = true;
                    }
                    else
                        bEliminar = true;


                    if (bEliminar)
                    {
                        if (Bus_Comprobantes_Recibidos.EliminarBD(item.Id))
                        {
                            MessageBox.Show("Mensaje ID" + item.Id + " eliminado con éxito!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                cargar_grid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void FrmGe_Comprobantes_Recibidos_Cons_event_FrmGe_Comprobantes_Recibidos_Cons_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        void ucGe_Menu_event_btnAceptar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Aceptar();
        }

        void ucGe_Menu_event_btnProvisionarFactura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCP_Aprobacion_Ing_Bod_x_OC_Mant frm = new frmCP_Aprobacion_Ing_Bod_x_OC_Mant();
            frm.ShowDialog();

            MessageBox.Show("Provisionando Factura!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void ucGe_Menu_event_beiBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cargar_grid();
        }

        private void FrmGe_Comprobantes_Recibidos_Cons_Load(object sender, EventArgs e)
        {
            ucGe_Menu.Validar_Permisos_Usuario(Cl_Enumeradores.eNombre_Carpeta.General + "." + this.Name);
            cargar_grid();
        }

        private void cargar_grid()
        {
            try
            {
                string TipoComproabnte = "";
                string Estado = Convert.ToString(ucGe_Menu.beiEstado.EditValue);

                switch (Convert.ToString(ucGe_Menu.beiTipoComprobante.EditValue))
                {
                    case "01":
                        TipoComproabnte = "Factura";
                        break;
                    case "03":
                        TipoComproabnte = "Liquidación de compra de bienes y prestación de servicios";
                        break;
                    case "04":
                        TipoComproabnte = "Nota de Crédito";
                        break;
                    case "05":
                        TipoComproabnte = "Nota de Débito";
                        break;
                    case "07":
                        TipoComproabnte = "Comprobantes de Retención";
                        break;
                }
                
                List_Comprobantes_Recibidos = Bus_Comprobantes_Recibidos.GetList(param.InfoEmpresa.em_ruc, Convert.ToDateTime(ucGe_Menu.beiFechaIni.EditValue), Convert.ToDateTime(ucGe_Menu.beiFechaFin.EditValue), TipoComproabnte, Estado);


                if (List_Comprobantes_Recibidos.Count > 0)
                {
                    //foreach (var item in List_Comprobantes_Recibidos)
                    //{
                    //    if (!string.IsNullOrEmpty(item.XML))
                    //    {
                    //        string sXml_a_descerializar = "";

                    //        try
                    //        {
                    //            sXml_a_descerializar = Quitar_a_xml_CDATA_y_Signature(item.XML);
                    //        }
                    //        catch (Exception ex)
                    //        {
                    //            item.Estado = "Error";
                    //            item.Motivo = "Error al deserializar el archivo xml: " + ex.Message;
                    //        }
                    //    }
                    //}
                }
                else
                {
                    MessageBox.Show("No registros que mostrar!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    BindingList_Comprobantes_Recibidos = new BindingList<tb_ComprobantesRecibidos_Info>();
                    gridControl_ComprobantesRecibidos.DataSource = BindingList_Comprobantes_Recibidos;
                }
               
                BindingList_Comprobantes_Recibidos = new BindingList<tb_ComprobantesRecibidos_Info>(List_Comprobantes_Recibidos);
                gridControl_ComprobantesRecibidos.DataSource = BindingList_Comprobantes_Recibidos;
                gridView_ComprobantesRecibidos.ExpandAllGroups();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string Quitar_a_xml_CDATA_y_Signature(string InnerXml_Cbte)
        {
            try
            {
                string sXml_a_descerializar = InnerXml_Cbte;
                string sValor_a_Reemplezar_cdata = "<![CDATA[";

                sXml_a_descerializar = sXml_a_descerializar.Replace(sValor_a_Reemplezar_cdata, "");
                sValor_a_Reemplezar_cdata = "]]>";
                sXml_a_descerializar = sXml_a_descerializar.Replace(sValor_a_Reemplezar_cdata, "");

                XmlDocument xml_valido = new System.Xml.XmlDocument();
                xml_valido.LoadXml(sXml_a_descerializar);

                // removiendo los datos de la firma 
                XmlNodeList nodeFirma = xml_valido.GetElementsByTagName("ds:Signature");
                nodeFirma.Item(0).RemoveAll();

                string valorareem = "<ds:Signature xmlns:ds=\"http://www.w3.org/2000/09/xmldsig#\"></ds:Signature>";

                sXml_a_descerializar = xml_valido.InnerXml;
                sXml_a_descerializar = sXml_a_descerializar.Replace(valorareem, "");

                return sXml_a_descerializar;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void gridView_ComprobantesRecibidos_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            FrmGe_Mensaje frmsg = null;

            try
            {
                tb_ComprobantesRecibidos_Info row = (tb_ComprobantesRecibidos_Info)gridView_ComprobantesRecibidos.GetFocusedRow();

                if (e.Column == colCheck)
                {
                    if ((bool)gridView_ComprobantesRecibidos.GetFocusedRowCellValue(colCheck))
                    {
                        gridView_ComprobantesRecibidos.SetFocusedRowCellValue(colCheck, false);
                    }
                    else
                    {
                        gridView_ComprobantesRecibidos.SetFocusedRowCellValue(colCheck, true);
                    }
                }
                
                if (e.Column == colXML)
                {
                    if (!string.IsNullOrEmpty(row.XML))
                    {
                        frmsg = new FrmGe_Mensaje();
                        frmsg.richTextBoxMensaje.Text = row.XML;
                        frmsg.WindowState = FormWindowState.Maximized;
                        frmsg.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

       
        private void Aceptar()
        {
            try
            {
                if (Row_Selected == null)
                {
                    MessageBox.Show("Seleccione un archivo extension xml", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                this.bAcepto = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_ComprobantesRecibidos_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Row_Selected = gridView_ComprobantesRecibidos.GetFocusedRow() as tb_ComprobantesRecibidos_Info;
        }

        private void FrmGe_Comprobantes_Recibidos_Cons_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_FrmGe_Comprobantes_Recibidos_Cons_FormClosing(sender, e);
        }

        private void gridView_ComprobantesRecibidos_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView_ComprobantesRecibidos.GetRow(e.RowHandle) as tb_ComprobantesRecibidos_Info;

                if (data == null)
                    return;

                if (data.Estado == "Pendiente")
                {
                    e.Appearance.ForeColor = Color.Black;
                    return;
                }
                
                if (data.Estado == "Valido")
                {
                    e.Appearance.ForeColor = Color.Blue;
                    return;
                }

                if (data.Estado == "Provisionada")
                {
                    e.Appearance.ForeColor = Color.Green;
                    return;
                }

                if (data.Estado == "Error")
                {
                    e.Appearance.ForeColor = Color.Red;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}