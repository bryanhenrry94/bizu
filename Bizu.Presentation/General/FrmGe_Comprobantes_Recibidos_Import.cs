using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using Bizu.Domain.General;
using Bizu.Domain.CuentasxPagar;
using Bizu.Application.General;
using Bizu.Application.CuentasxPagar;
using Bizu.Application.SRI;
using System.Xml;

namespace Bizu.Presentation.General
{
    public partial class FrmGe_Comprobantes_Recibidos_Import : DevExpress.XtraEditors.XtraForm
    {
        // Bus
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_ComprobantesRecibidos_Bus BusComprobantesRecibidos = new tb_ComprobantesRecibidos_Bus();
        tb_persona_bus BusPersona = new tb_persona_bus();
        cp_proveedor_Bus BusProveedor = new cp_proveedor_Bus();
        cp_orden_giro_Bus BusOrdenGiro = new cp_orden_giro_Bus();        
        // List
        List<tb_ComprobantesRecibidos_Info> ListComprobantesPendientes;
        List<tb_ComprobantesRecibidos_Info> ListComprobantesExitosas;
        BindingList<tb_ComprobantesRecibidos_Info> BindingComprobantesPendientes;
        BindingList<tb_ComprobantesRecibidos_Info> BindingComprobantesExitosas;
        // Info
        
        enum eEstadoComprobanteRecibido
        {
            Pendiente,
            Error,
            Valido,
            Provisionada
        }

        public FrmGe_Comprobantes_Recibidos_Import()
        {
            InitializeComponent();

            ucGe_Menu.event_btnSalir_Click += UcGe_Menu_event_btnSalir_Click;
        }

        private void UcGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnImportar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                string filePath = openFileDialog.FileName;

                if (string.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("Por favor seleccione un archivo primero!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                try
                {
                    if (MessageBox.Show("Se procedera a importar los registos. Desea continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                    // Mostrar el cursor de espera
                    Cursor.Current = Cursors.WaitCursor;

                    string[] lines = File.ReadAllLines(filePath, Encoding.GetEncoding("Windows-1252"));
                    string header = "RUC_EMISOR\tRAZON_SOCIAL_EMISOR\tTIPO_COMPROBANTE\tSERIE_COMPROBANTE\tCLAVE_ACCESO\tFECHA_AUTORIZACION\tFECHA_EMISION\tIDENTIFICACION_RECEPTOR\tVALOR_SIN_IMPUESTOS\tIVA\tIMPORTE_TOTAL\tNUMERO_DOCUMENTO_MODIFICADO";

                    if (lines.Length > 0 && lines[0] == header)
                    {
                        // Process each line excluding the header
                        for (int i = 1; i < lines.Length; i++)
                        {
                            string[] columns = lines[i].Split('\t');

                            if (columns.Length == 12) // Ensure there are exactly 12 columns
                            {
                                string rucEmisor = columns[0];
                                string razonSocialEmisor = columns[1];
                                string tipoComprobante = columns[2];
                                string serieComprobante = columns[3];
                                string claveAcceso = columns[4];
                                DateTime fechaAutorizacion = Convert.ToDateTime(columns[5]);
                                DateTime fechaEmision = Convert.ToDateTime(columns[6]);
                                string identificacionReceptor = columns[7];
                                decimal valorSinImpuestos = columns[8] == "" ? 0 : Convert.ToDecimal(columns[8]);
                                decimal iva = columns[9] == "" ? 0 : Convert.ToDecimal(columns[9]);
                                decimal importeTotal = columns[10] == "" ? 0 : Convert.ToDecimal(columns[10]);
                                string numeroDocumentoModificado = columns[11];

                                tb_ComprobantesRecibidos_Info comprobante = new tb_ComprobantesRecibidos_Info();
                                comprobante.RucEmisor = rucEmisor;
                                comprobante.RazonSocialEmisor = razonSocialEmisor;
                                comprobante.TipoComprobante = tipoComprobante;
                                comprobante.SerieComprobante = serieComprobante;
                                comprobante.ClaveAcceso = claveAcceso;
                                comprobante.FechaAutorizacion = fechaAutorizacion;
                                comprobante.FechaEmision = fechaEmision;
                                comprobante.IdentificacionReceptor = identificacionReceptor;
                                comprobante.ValorSinImpuestos = valorSinImpuestos;
                                comprobante.Iva = iva;
                                comprobante.ImporteTotal = importeTotal;
                                comprobante.NumeroDocumentoModificado = numeroDocumentoModificado;
                                comprobante.Estado = eEstadoComprobanteRecibido.Pendiente.ToString();
                                comprobante.Motivo = "";
                                comprobante.XML = "";

                                // Sino existe registramos
                                if (!BusComprobantesRecibidos.Existe(comprobante.RucEmisor, comprobante.SerieComprobante))
                                {
                                    BusComprobantesRecibidos.GrabarBD(comprobante);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Alguna línea no tiene el formato correcto.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                            CargarGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Archivo incorrecto!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Restaurar el cursor predeterminado
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void FrmCP_FacturasProveedorRecibidas_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaActual = DateTime.Now;

                dtpDesde.EditValue = new DateTime(fechaActual.Year, fechaActual.Month, 1);
                dtpHasta.EditValue = fechaActual;

                BindingComprobantesPendientes = new BindingList<tb_ComprobantesRecibidos_Info>();
                gridControlPendientes.DataSource = BindingComprobantesPendientes;

                BindingComprobantesExitosas = new BindingList<tb_ComprobantesRecibidos_Info>();
                gridControlExitosas.DataSource = BindingComprobantesExitosas;

                CargarGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrid()
        {
            try
            {
                this.ListComprobantesPendientes = new List<tb_ComprobantesRecibidos_Info>();
                this.ListComprobantesExitosas = new List<tb_ComprobantesRecibidos_Info>();

                List<tb_ComprobantesRecibidos_Info> ListComprobantesRecibidos = this.BusComprobantesRecibidos.GetList(param.InfoEmpresa.em_ruc, Convert.ToDateTime(dtpDesde.EditValue), Convert.ToDateTime(dtpHasta.EditValue));
                
                foreach (var item in ListComprobantesRecibidos)
                {
                    switch (item.Estado)
                    {
                        case "Pendiente":
                            ListComprobantesPendientes.Add(item);
                            break;

                        case "Error":
                            ListComprobantesPendientes.Add(item);
                            break;

                        case "Valido":
                            ListComprobantesExitosas.Add(item);
                            break;

                        case "Provisionada":
                            ListComprobantesExitosas.Add(item);
                            break;
                    }
                }

                BindingComprobantesPendientes = new BindingList<tb_ComprobantesRecibidos_Info>(ListComprobantesPendientes);
                gridControlPendientes.DataSource = BindingComprobantesPendientes;

                BindingComprobantesExitosas = new BindingList<tb_ComprobantesRecibidos_Info>(ListComprobantesExitosas);
                gridControlExitosas.DataSource = BindingComprobantesExitosas;                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcesarPendientes_Click(object sender, EventArgs e)
        {
            try
            {
                if (BindingComprobantesPendientes.Where(q => q.Checked == true).ToList().Count <= 0)
                {
                    MessageBox.Show("No existen registros a procesar!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (MessageBox.Show("Se procesaran los comprobantes recibidos. Desea continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                // Mostrar el cursor de espera
                Cursor.Current = Cursors.WaitCursor;

                foreach (var item in BindingComprobantesPendientes.Where(q => q.Checked == true).ToList())
                {
                    item.Estado = eEstadoComprobanteRecibido.Pendiente.ToString();
                    item.Motivo = "";
                    
                    if (string.IsNullOrEmpty(item.RucEmisor))
                    {
                        item.Estado = eEstadoComprobanteRecibido.Error.ToString();
                        item.Motivo = $"El campo Ruc Emisor esta vacio";
                    }

                    if (string.IsNullOrEmpty(item.RazonSocialEmisor))
                    {
                        item.Estado = eEstadoComprobanteRecibido.Error.ToString();
                        item.Motivo = $"El campo Razon Social Emisor esta vacio";                        
                    }

                    if (string.IsNullOrEmpty(item.TipoComprobante))
                    {
                        item.Estado = eEstadoComprobanteRecibido.Error.ToString();
                        item.Motivo = $"El campo Tipo Comprobante esta vacio";                        
                    }

                    if (string.IsNullOrEmpty(item.SerieComprobante))
                    {
                        item.Estado = eEstadoComprobanteRecibido.Error.ToString();
                        item.Motivo = $"El campo Serie Comprobante esta vacio";                        
                    }

                    if (string.IsNullOrEmpty(item.ClaveAcceso))
                    {
                        item.Estado = eEstadoComprobanteRecibido.Error.ToString();
                        item.Motivo = $"El campo Clave Acceso esta vacio";                        
                    }

                    if (item.FechaAutorizacion == null)
                    {
                        item.Estado = eEstadoComprobanteRecibido.Error.ToString();
                        item.Motivo = $"El campo Fecha Autorizacion esta vacio";                        
                    }

                    if (item.FechaEmision == null)
                    {
                        item.Estado = eEstadoComprobanteRecibido.Error.ToString();
                        item.Motivo = $"El campo Fecha Emision esta vacio";                        
                    }

                    if (string.IsNullOrEmpty(item.IdentificacionReceptor))
                    {
                        item.Estado = eEstadoComprobanteRecibido.Error.ToString();
                        item.Motivo = $"El campo Identificacion Receptor esta vacio";                        
                    }

                    if (string.IsNullOrEmpty(item.IdentificacionReceptor))
                    {
                        item.Estado = eEstadoComprobanteRecibido.Error.ToString();
                        item.Motivo = $"El campo Valor Sin Impuestos esta vacio";                        
                    }

                    if (item.IdentificacionReceptor != param.InfoEmpresa.em_ruc)
                    {
                        item.Estado = eEstadoComprobanteRecibido.Error.ToString();
                        item.Motivo = $"El numero de identificacion del receptor no coincide con el ruc de la empresa {param.InfoEmpresa.RazonSocial}";
                    }
                    
                    // Si el comprobante no tiene Error
                    if (item.Estado == eEstadoComprobanteRecibido.Pendiente.ToString())
                    {
                        // PASO 1
                        // VALIDA SI EL COMPROBANTE ESTA PROVISIONADA EN EL SISTEMA
                        tb_persona_Info InfoPersona = BusPersona.Get_Info_Persona(item.RucEmisor);

                        if (InfoPersona != null && InfoPersona.IdPersona != 0)
                        {
                            string msg = "";

                            // Obtiene InfoProveedor con el IdPersona
                            cp_proveedor_Info InfoProveedor = BusProveedor.Get_Info_Proveedor_x_Persona(param.IdEmpresa, InfoPersona.IdPersona, ref msg);

                            if (InfoProveedor != null && InfoProveedor.IdProveedor != 0)
                            {
                                // Verifica si tiene provisionada factura de proveedor
                                cp_orden_giro_Info InfoOrdenGiro = BusOrdenGiro.Get_OrdenGiro_Por_SerieComprobante(param.IdEmpresa, InfoProveedor.IdProveedor, item.SerieComprobante);

                                if (InfoOrdenGiro != null)
                                {
                                    // Si tiene registros, procede a actualizar los campos de referencia y actualiza el estado a provisionada
                                    if (InfoOrdenGiro.IdEmpresa != 0 && InfoOrdenGiro.IdTipoCbte_Ogiro != 0 && InfoOrdenGiro.IdCbteCble_Ogiro != 0)
                                    {
                                        item.IdEmpresa_Ogiro = InfoOrdenGiro.IdEmpresa;
                                        item.IdTipoCbte_Ogiro = InfoOrdenGiro.IdTipoCbte_Ogiro;
                                        item.IdCbteCble_Ogiro = InfoOrdenGiro.IdCbteCble_Ogiro;

                                        // Actualizamos el estado del comprobante
                                        item.Estado = eEstadoComprobanteRecibido.Provisionada.ToString();
                                        item.Motivo = "";
                                    }
                                }
                            }
                        }
                        
                        // PASO 2
                        // SI NO SE ENCUENTRA INFORMACION EN LA BASE DE DATOS DEL EFIRM DEBE CONSULTAR EL WEBSERVICE DEL SRI
                        if (string.IsNullOrEmpty(item.XML))
                        {
                            sri_comprobantes sriComprobante = new sri_comprobantes();
                            sri_autorizacion autorizacion = sriComprobante.GetAutorizacion(item.ClaveAcceso);

                            if (autorizacion != null)
                            {
                                if (autorizacion.estado == "AUTORIZADO")
                                {
                                    //item.Estado = autorizacion.estado;
                                    //item.FechaAutorizacion = autorizacion.fechaAutorizacion;
                                    //autorizacion.numeroAutorizacion;
                                    //autorizacion.ambiente;
                                    //item.XML = Quitar_a_xml_CDATA_y_Signature(autorizacion.comprobante);
                                    item.XML = autorizacion.comprobante;
                                    item.NumeroAutorizacion = autorizacion.numeroAutorizacion;
                                    item.FechaAutorizacion = autorizacion.fechaAutorizacion;

                                    if(item.Estado == eEstadoComprobanteRecibido.Pendiente.ToString())
                                    {
                                        // Actualizamos el estado del comprobante
                                        item.Estado = eEstadoComprobanteRecibido.Valido.ToString();
                                        item.Motivo = "";
                                    }
                                }
                                else
                                {
                                    // Actualizamos el estado del comprobante
                                    item.Estado = eEstadoComprobanteRecibido.Error.ToString();
                                    item.Motivo = "No se pudo validar comprobante";
                                }
                            }
                        }

                        // PASO 3
                        // CONSULTA EN LA BASE DE DATOS DEL EFIRM, CORREOS. SI EL COMPROBANTE YA SE ENCUENTRA REGISTRADO, SI ESTA ELIMINAR
                        if (string.IsNullOrEmpty(item.XML))
                        {
                            // Implemenar logica para consular los xml cargados manualmente
                        }
                    }
                    
                    // Solo sino existe registramos el comprobante recibido con la finalidad de evitar duplicados
                    BusComprobantesRecibidos.ModificarDB(item);
                }
                
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Restaurar el cursor predeterminado
                Cursor.Current = Cursors.Default;
            }
        }

        private void gridViewPendientes_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewPendientes.GetRow(e.RowHandle) as tb_ComprobantesRecibidos_Info;
                if (data == null)
                    return;

                if (data.Estado == eEstadoComprobanteRecibido.Pendiente.ToString())
                    e.Appearance.ForeColor = Color.Black;

                if (data.Estado == eEstadoComprobanteRecibido.Error.ToString())
                    e.Appearance.ForeColor = Color.Red;

                if (data.Estado == eEstadoComprobanteRecibido.Valido.ToString())
                    e.Appearance.ForeColor = Color.Blue;

                if (data.Estado == eEstadoComprobanteRecibido.Provisionada.ToString())
                    e.Appearance.ForeColor = Color.Green;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewPendientes_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    tb_ComprobantesRecibidos_Info InfoComprobanteRecibidos = (tb_ComprobantesRecibidos_Info) gridViewPendientes.GetFocusedRow();

                    if (InfoComprobanteRecibidos == null) return;
                    
                    this.EliminarBD(InfoComprobanteRecibidos.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewPendientes_RowCountChanged(object sender, EventArgs e)
        {
            tabCargasPendientes.Text = $"Cargas Pendientes ({BindingComprobantesPendientes.Count})";            
        }

        private void gridViewExitosas_RowCountChanged(object sender, EventArgs e)
        {
            tabCargasExitosas.Text = $"Cargas Exitosas ({BindingComprobantesExitosas.Count})";
        }

        private void gridViewExitosas_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    tb_ComprobantesRecibidos_Info InfoComprobanteRecibidos = (tb_ComprobantesRecibidos_Info)gridViewExitosas.GetFocusedRow();

                    if (InfoComprobanteRecibidos == null) return;

                    EliminarBD(InfoComprobanteRecibidos.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarBD(int Id)
        {
            try
            {
                if (MessageBox.Show($"Estas seguro de eliminar el registro con ID {Id}?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                BusComprobantesRecibidos.EliminarBD(Id);
                CargarGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewExitosas_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewExitosas.GetRow(e.RowHandle) as tb_ComprobantesRecibidos_Info;
                if (data == null)
                    return;

                if (data.Estado == eEstadoComprobanteRecibido.Pendiente.ToString())
                    e.Appearance.ForeColor = Color.Black;

                if (data.Estado == eEstadoComprobanteRecibido.Error.ToString())
                    e.Appearance.ForeColor = Color.Red;

                if (data.Estado == eEstadoComprobanteRecibido.Valido.ToString())
                    e.Appearance.ForeColor = Color.Blue;

                if (data.Estado == eEstadoComprobanteRecibido.Provisionada.ToString())
                    e.Appearance.ForeColor = Color.Green;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewPendientes_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                tb_ComprobantesRecibidos_Info RowSelected = (tb_ComprobantesRecibidos_Info) gridViewPendientes.GetFocusedRow();
                
                if(e.Column == colImportarXML)
                {
                    ImportarXML(RowSelected);
                }

                if(e.Column == colChecked)
                {
                    gridViewPendientes.SetFocusedRowCellValue(colChecked, !RowSelected.Checked);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewExitosas_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                tb_ComprobantesRecibidos_Info RowSelected = (tb_ComprobantesRecibidos_Info)gridViewExitosas.GetFocusedRow();
                
                if (e.Column == colImportarXML2)
                {
                    ImportarXML(RowSelected);
                }

                if (e.Column == colChecked2)
                {
                    gridViewExitosas.SetFocusedRowCellValue(colChecked2, !RowSelected.Checked);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImportarXML(tb_ComprobantesRecibidos_Info RowSelected)
        {
            try
            {
                if (RowSelected == null) return;

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*"; // Modificado el filtro para solo XML
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Obtener la ruta del archivo seleccionado
                        string Path_XML = openFileDialog.FileName;

                        // Verificar si se seleccionó un archivo
                        if (!string.IsNullOrEmpty(Path_XML))
                        {
                            // Leer el contenido del archivo XML
                            string xml_autorizado = File.ReadAllText(Path_XML); ;

                            //RowSelected.XML = Quitar_a_xml_CDATA_y_Signature(xml_autorizado);
                            RowSelected.XML = xml_autorizado;
                            
                            if (RowSelected.Estado != eEstadoComprobanteRecibido.Provisionada.ToString())
                                RowSelected.Estado = eEstadoComprobanteRecibido.Valido.ToString();
                           
                            RowSelected.Motivo = "";

                            BusComprobantesRecibidos.ModificarDB(RowSelected);
                            CargarGrid();
                        }
                    }
                }
            }
            catch(Exception ex)
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

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnProcesarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if (BindingComprobantesExitosas.Where(q => q.Checked == true).ToList().Count <= 0)
                {
                    MessageBox.Show("No existen registros a procesar!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (MessageBox.Show("Se procesaran los estados de los comprobantes. Desea continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                // Mostrar el cursor de espera
                Cursor.Current = Cursors.WaitCursor;

                foreach (var item in BindingComprobantesExitosas.Where(q => q.Checked == true).ToList())
                {
                    // Si el comprobante es Valido
                    if (item.Estado == eEstadoComprobanteRecibido.Valido.ToString())
                    {
                        string msg = "";

                        // Obtiene el IdPersona por el RucEmisor del comprobante
                        tb_persona_Info InfoPersona = BusPersona.Get_Info_Persona(item.RucEmisor);

                        // Si el IdPersona es vacio o igual a 0 continuo con el siguiente comprobante
                        if (InfoPersona == null && InfoPersona.IdPersona == 0) continue;

                        // Obtiene InfoProveedor con el IdPersona
                        cp_proveedor_Info InfoProveedor = BusProveedor.Get_Info_Proveedor_x_Persona(param.IdEmpresa, InfoPersona.IdPersona, ref msg);

                        // Si el InfoProveedor es vacio o IdProveedor igual a 0 continuo con el siguiente comprobante
                        if (InfoProveedor == null && InfoProveedor.IdProveedor == 0) continue;

                        // Actualza a provisionada por tipo documento Factura
                        if (item.TipoComprobante == "Factura")
                        {
                            // Verifica si tiene provisionada factura de proveedor
                            cp_orden_giro_Info InfoOrdenGiro = BusOrdenGiro.Get_OrdenGiro_Por_SerieComprobante(param.IdEmpresa, InfoProveedor.IdProveedor, item.SerieComprobante);

                            if (InfoOrdenGiro != null)
                            {
                                // Si tiene registros, procede a actualizar los campos de referencia y actualiza el estado a provisionada
                                if (InfoOrdenGiro.IdEmpresa != 0 && InfoOrdenGiro.IdTipoCbte_Ogiro != 0 && InfoOrdenGiro.IdCbteCble_Ogiro != 0)
                                {
                                    item.IdEmpresa_Ogiro = InfoOrdenGiro.IdEmpresa;
                                    item.IdTipoCbte_Ogiro = InfoOrdenGiro.IdTipoCbte_Ogiro;
                                    item.IdCbteCble_Ogiro = InfoOrdenGiro.IdCbteCble_Ogiro;

                                    // Actualizamos el estado del comprobante
                                    item.Estado = eEstadoComprobanteRecibido.Provisionada.ToString();
                                    item.Motivo = "";
                                }
                            }
                        }

                        if (item.TipoComprobante == "Nota de Crédito")
                        {
                            // Verifica si tiene provisionada la nota de credito de proveedor
                            cp_nota_DebCre_Bus BusNotaDebCred = new cp_nota_DebCre_Bus();

                            string[] SerieComprobante = item.SerieComprobante.Split('-');
                            string Serie1 = SerieComprobante[0];
                            string Serie2 = SerieComprobante[1];
                            string Secuencia = SerieComprobante[2];

                            cp_nota_DebCre_Info InfoNotaDebCred = BusNotaDebCred.Get_Info_nota_DebCre(param.IdEmpresa, InfoProveedor.IdProveedor, Serie1, Serie2, Secuencia);

                            if (InfoNotaDebCred != null)
                            {
                                // Si tiene registros, procede a actualizar los campos de referencia y actualiza el estado a provisionada
                                if (InfoNotaDebCred.IdEmpresa != 0 && InfoNotaDebCred.IdTipoCbte_Nota != 0 && InfoNotaDebCred.IdCbteCble_Nota != 0)
                                {
                                    // Agregar campos de referencia con la Nota de Credito
                                    //item.IdEmpresa_Ogiro = InfoNotaDebCred.IdEmpresa;
                                    //item.IdTipoCbte_Ogiro = InfoNotaDebCred.IdTipoCbte_Nota;
                                    //item.IdCbteCble_Ogiro = InfoNotaDebCred.IdCbteCble_Nota;

                                    // Actualizamos el estado del comprobante
                                    item.Estado = eEstadoComprobanteRecibido.Provisionada.ToString();
                                    item.Motivo = "";
                                }
                            }
                        }
                    }

                    // Solo sino existe registramos el comprobante recibido con la finalidad de evitar duplicados
                    BusComprobantesRecibidos.ModificarDB(item);
                }

                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkSeleccionarPendientes_CheckedChanged(object sender, EventArgs e)
        {
            // Obtener el estado del CheckEdit independiente
            bool isChecked = chkSeleccionarPendientes.Checked;

            // Iterar sobre las filas visibles en el GridView
            for (int i = 0; i < gridViewPendientes.RowCount; i++)
            {
                // Asegurarse de que el índice de la fila sea válido
                int rowHandle = gridViewPendientes.GetVisibleRowHandle(i);
                if (gridViewPendientes.IsDataRow(rowHandle))
                {
                    // Actualizar el valor de la celda "colCheck"
                    gridViewPendientes.SetRowCellValue(rowHandle, colChecked, isChecked);
                }
            }
        }

        private void chkExitosas_CheckedChanged(object sender, EventArgs e)
        {
            // Obtener el estado del CheckEdit independiente
            bool isChecked = chkExitosas.Checked;

            // Iterar sobre las filas visibles en el GridView
            for (int i = 0; i < gridViewExitosas.RowCount; i++)
            {
                // Asegurarse de que el índice de la fila sea válido
                int rowHandle = gridViewExitosas.GetVisibleRowHandle(i);
                if (gridViewExitosas.IsDataRow(rowHandle))
                {
                    // Actualizar el valor de la celda "colCheck"
                    gridViewExitosas.SetRowCellValue(rowHandle, colChecked2, isChecked);
                }
            }
        }
    }    
}