using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Bizu.Application.General;
using Bizu.Domain.General;

using Bizu.Domain.CuentasxPagar;
using Bizu.Application.CuentasxPagar;
using Bizu.Application.Inventario;
using Bizu.Domain.Inventario;
using Bizu.Application.SeguridadAcceso;
using Bizu.Domain.SeguridadAcceso;

namespace Bizu.Presentation.Inventario
{
    public partial class FrmIn_Ingreso_varios_Cons : DevExpress.XtraEditors.XtraForm
    {
        FrmIn_Ingreso_varios_Cons_Handler Handler = new FrmIn_Ingreso_varios_Cons_Handler();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        seg_Menu_bus Busseg = new seg_Menu_bus();
        List<seg_Menu_info> Infoseg = new List<seg_Menu_info>();
        #region Variables y atributos

        in_Ing_Egr_Inven_Bus bus_IngEgr;
        in_Ing_Egr_Inven_Info Info;
        FrmIn_Ingreso_varios_Mant frm;

        int IdSucursalIni = 0;
        int IdSucursalFin = 0;
        int IdBodegaIni = 0;
        int IdBodegaFin = 0;
        DateTime fecha_desde;
        DateTime fecha_hasta;
        #endregion

        public FrmIn_Ingreso_varios_Cons()
        {
            InitializeComponent();
        }

        private void FrmIn_Ingreso_varios_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                //Control de Usuario
                Infoseg = Busseg.Get_List_Menu_x_Empresa_x_Usuario_Control(param.IdEmpresa, param.IdUsuario, "Inventario.FrmIn_Ingreso_varios_Cons");
                foreach (var item in Infoseg)
                {
                    if (item.Eliminacion == false)
                    {
                        ucGe_Menu_Mantenimiento_x_usuario1.btnAnular.Enabled = false;
                    }
                    if (item.Escritura == false)
                    {
                        ucGe_Menu_Mantenimiento_x_usuario1.btnModificar.Enabled = false;
                    }
                }
                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargagrid()
        {
            try
            {
                IdSucursalIni = ucGe_Menu_Mantenimiento_x_usuario1.getIdSucursal;
                if (IdSucursalIni == 0)
                {
                    IdSucursalIni = 1;
                    IdSucursalFin = 9999;
                    IdBodegaIni = 1;
                    IdBodegaFin = 9999;
                }
                else
                {
                    IdSucursalIni = ucGe_Menu_Mantenimiento_x_usuario1.getIdSucursal;
                    IdSucursalFin = ucGe_Menu_Mantenimiento_x_usuario1.getIdSucursal;
                    IdBodegaIni = ucGe_Menu_Mantenimiento_x_usuario1.getIdBodega == 0 ? 1 : ucGe_Menu_Mantenimiento_x_usuario1.getIdBodega;
                    IdBodegaFin = ucGe_Menu_Mantenimiento_x_usuario1.getIdBodega == 0 ? 9999 : ucGe_Menu_Mantenimiento_x_usuario1.getIdBodega;
                }

                fecha_desde = ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde;
                fecha_hasta = ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta;

                List<in_Ing_Egr_Inven_Info> LstIngEgr = new List<in_Ing_Egr_Inven_Info>();
                bus_IngEgr = new in_Ing_Egr_Inven_Bus();
                LstIngEgr = bus_IngEgr.Get_List_Ing_Egr_Inven(param.IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, fecha_desde, fecha_hasta, "+");
                gridControlConsulta.DataSource = LstIngEgr.OrderByDescending(x => x.IdNumMovi);
                 
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Preparar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {

            try
            {
                Info = new in_Ing_Egr_Inven_Info();

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    Info = (in_Ing_Egr_Inven_Info)gridViewConsulta.GetFocusedRow();
                }


                if (Info == null)
                {
                    MessageBox.Show("Seleccione un Registro a Mostrar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
               
                if (Info.Estado == "APRO" && Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    MessageBox.Show("No se puede anular el registro porque se encuentra aprobado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                //if (Accion == Cl_Enumeradores.eTipo_action.actualizar && (Info.co_factura != null || Info.IdEstadoAproba == "APRO"))
                //{
                //    Accion = Cl_Enumeradores.eTipo_action.actualizar_proceso_cerrado;
                //}

                frm = new FrmIn_Ingreso_varios_Mant();
                frm.MdiParent = this.MdiParent;
                frm.event_FrmIn_Ingreso_varios_Mant_FormClosing += frm_event_FrmIn_Ingreso_varios_Mant_FormClosing;
                frm.set_Accion(Accion);
                frm.setInfo(Info);



                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        frm.Text = frm.Text + " ***NUEVO REGISTRO***";
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        frm.Text = frm.Text + " ***MODIFICAR REGISTRO***";
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        if (Info != null)
                        {
                            if (Info.Estado == "I")
                            { MessageBox.Show("El registro ya se encuentra Anulado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                            else
                            {
                                frm.Text = frm.Text + "***ANULAR REGISTRO***";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un Registro a Anular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                        }

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        frm.Text = frm.Text + "***CONSULTAR REGISTRO***";
                        break;
                    default:
                        break;
                }


                frm.Show();



            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void frm_event_FrmIn_Ingreso_varios_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        public void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = new in_Ing_Egr_Inven_Info();
                Info = (in_Ing_Egr_Inven_Info) gridViewConsulta.GetFocusedRow();

                if (Info != null)
                {
                    if (Info.Estado == "I")
                    { MessageBox.Show("El registro ya se encuentra Anulado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                    else
                        if (Info.IdEstadoAproba == "APRO")
                        {
                            MessageBox.Show("El registro no se puede anular ya se encuentra Aprobado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {

                            frm = new FrmIn_Ingreso_varios_Mant();
                            frm.Text = frm.Text + "***ANULAR REGISTRO***";
                            frm.setInfo(Info);
                            frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                            frm.Show();
                            frm.MdiParent = this.MdiParent;

                            frm.event_FrmIn_Ingreso_varios_Mant_FormClosing += frm_event_FrmIn_Ingreso_varios_Mant_FormClosing;

                            // personalizado porque se setea por defaul a la bodega 1 y no carga los productos                            
                            //frm.motivo();
                        }
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Anular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
                //Preparar_Formulario(Cl_Enumeradores.eTipo_action.Anular);
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewConsulta.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = (in_Ing_Egr_Inven_Info)gridViewConsulta.GetFocusedRow();
                if (Info == null) return;
                if (Info.Estado == "I") { MessageBox.Show("El registro se encuentra anulado y no se puede modificar"); return; }
                
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);

            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.grabar);

            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void gridViewConsulta_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Info = new in_Ing_Egr_Inven_Info();
                Info = (in_Ing_Egr_Inven_Info)gridViewConsulta.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void gridViewConsulta_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewConsulta.GetRow(e.RowHandle) as in_Ing_Egr_Inven_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
                else
                {
                    if (data.IdEstadoAproba == "APRO")
                        e.Appearance.ForeColor = Color.Blue;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControlConsulta_Click(object sender, EventArgs e)
        {

        }
    }
}
