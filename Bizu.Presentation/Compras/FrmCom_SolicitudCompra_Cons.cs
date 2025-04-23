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
using Bizu.Domain.Compras;
using Bizu.Application.Compras;
using Bizu.Application.SeguridadAcceso;
using Bizu.Domain.SeguridadAcceso;

namespace Bizu.Presentation.Compras
{
    public partial class FrmCom_SolicitudCompra_Cons : DevExpress.XtraEditors.XtraForm
    {
        #region Declración de Variables
        seg_Menu_bus Busseg = new seg_Menu_bus();
        List<seg_Menu_info> Infoseg = new List<seg_Menu_info>();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        com_solicitud_compra_Bus Bus_SoliciCompra = new com_solicitud_compra_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        com_solicitud_compra_Info Info = new com_solicitud_compra_Info();
        FrmCom_SolicitudCompra_Mant frm = new FrmCom_SolicitudCompra_Mant();
        com_ordencompra_local_det_x_com_solicitud_compra_det_Bus bus_Solicitud = new com_ordencompra_local_det_x_com_solicitud_compra_det_Bus();
        List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> listSolicitud = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();
        com_solicitud_compra_Bus Bus = new com_solicitud_compra_Bus();
        //Variables
        int idEmpresa = 0;
        int idSucursal = 0;
        decimal idSoliComp = 0;
        int IdSucursal = 0;
        string MensajeError = "";
        #endregion

        public FrmCom_SolicitudCompra_Cons()
        {
            try
            {
                InitializeComponent();

                ucGe_Menu_Mantenimiento_x_usuario1.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario1.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario1.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario1.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario1.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario1.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click;

                ucGe_Menu_Mantenimiento_x_usuario1.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargagrid()
        {
            try
            {
                List<com_solicitud_compra_Info> list = new List<com_solicitud_compra_Info>();
                list = this.Bus_SoliciCompra.Get_List_solicitud_compra(this.param.IdEmpresa, this.ucGe_Menu_Mantenimiento_x_usuario1.getIdSucursal, this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde, this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta, "");
                foreach (com_solicitud_compra_Info info in list)
                {
                    info.Ico = (Bitmap)this.imageListIconos.Images[1];
                }
                this.gridControlConsulta.DataSource = list;
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                IdSucursal = ucGe_Menu_Mantenimiento_x_usuario1.getIdSucursal;
                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewConsulta.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = (com_solicitud_compra_Info)gridViewConsulta.GetFocusedRow();
                if (Info != null)
                {
                    frm = new FrmCom_SolicitudCompra_Mant(Cl_Enumeradores.eTipo_action.consultar);
                    frm.MdiParent = this.MdiParent;
                    frm.Text = frm.Text + "***CONSULTAR REGISTRO***";
                    frm._SetInfo = Info;
                    frm.Show();
                    frm.event_FrmCom_SolicitudCompraMantenimiento_FormClosing += frm_event_FrmCom_SolicitudCompraMantenimiento_FormClosing;
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = (com_solicitud_compra_Info)gridViewConsulta.GetFocusedRow();
                if (Info != null)
                {

                    listSolicitud = bus_Solicitud.ConsultaDetalleSolicitud_x_Solicitud(Info.IdEmpresa, Info.IdSucursal, Info.IdSolicitudCompra);

                    if (listSolicitud.Count() != 0)
                    {
                        MessageBox.Show("La solicitud #: [" + Info.IdSolicitudCompra + "], tiene asociadas Ordenes de Compra ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                    }

                    idEmpresa = Info.IdEmpresa;
                    idSucursal = Info.IdSucursal;
                    idSoliComp = Info.IdSolicitudCompra;

                    if (Verifica_Estado())
                    {
                        llama_frm(Cl_Enumeradores.eTipo_action.actualizar);

                    }

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Info = (com_solicitud_compra_Info)this.gridViewConsulta.GetFocusedRow();
                if (this.Info == null)
                {
                    MessageBox.Show("Seleccione un Registro a Anular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (this.Info.Estado == "I")
                {
                    MessageBox.Show("El registro ya se encuentra Anulado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    this.listSolicitud = this.bus_Solicitud.ConsultaDetalleSolicitud_x_Solicitud(this.Info.IdEmpresa, this.Info.IdSucursal, this.Info.IdSolicitudCompra);
                    if (this.listSolicitud.Count<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>() != 0)
                    {
                        MessageBox.Show("La solicitud #: [" + this.Info.IdSolicitudCompra.ToString() + "], tiene asociada una Orden de Compra ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        this.idEmpresa = this.Info.IdEmpresa;
                        this.idSucursal = this.Info.IdSucursal;
                        this.idSoliComp = this.Info.IdSolicitudCompra;
                        this.Info = (com_solicitud_compra_Info)this.gridViewConsulta.GetFocusedRow();
                        if (this.Verifica_Estado())
                        {
                            this.frm = new FrmCom_SolicitudCompra_Mant(Cl_Enumeradores.eTipo_action.Anular);
                            this.frm.Text = this.frm.Text + "***ANULAR REGISTRO***";
                            this.frm.MdiParent = base.MdiParent;
                            this.frm._SetInfo = this.Info;
                            this.frm.Show();
                            this.frm.event_FrmCom_SolicitudCompraMantenimiento_FormClosing += new FrmCom_SolicitudCompra_Mant.delegate_FrmCom_SolicitudCompraMantenimiento_FormClosing(this.frm_event_FrmCom_SolicitudCompraMantenimiento_FormClosing);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                llama_frm(Cl_Enumeradores.eTipo_action.grabar);




            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_FrmCom_SolicitudCompraMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.IdSucursal = 0;
                this.cargagrid();
                this.ucGe_Menu_Mantenimiento_x_usuario1.carga_Sucursal_Todas();
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void gridViewConsulta_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                com_solicitud_compra_Info row = this.gridViewConsulta.GetRow(e.RowHandle) as com_solicitud_compra_Info;
                if (!ReferenceEquals(row, null))
                {
                    if (row.IdEstadoAprobacion == "APR_SOL")
                    {
                        e.Appearance.ForeColor = Color.Blue;
                    }
                    if (row.Estado == "I")
                    {
                        e.Appearance.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void gridViewConsulta_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void FrmCom_SolicitudCompraConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                this.Infoseg = this.Busseg.Get_List_Menu_x_Empresa_x_Usuario_Control(this.param.IdEmpresa, this.param.IdUsuario, "Compras.FrmCom_SolicitudCompra_Cons");
                foreach (seg_Menu_info _info in this.Infoseg)
                {
                    if (!_info.Eliminacion)
                    {
                        this.ucGe_Menu_Mantenimiento_x_usuario1.btnAnular.Enabled = false;
                    }
                    if (!_info.Escritura)
                    {
                        this.ucGe_Menu_Mantenimiento_x_usuario1.btnModificar.Enabled = false;
                    }
                }
                this.IdSucursal = this.param.IdSucursal;
                this.cargagrid();
                this.ucGe_Menu_Mantenimiento_x_usuario1.carga_Sucursal_Todas();
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_Load(object sender, EventArgs e)
        {

        }

        private bool Verifica_Estado()
        {
            return true;
        }

        private void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                this.frm = new FrmCom_SolicitudCompra_Mant(Accion);
                this.frm.MdiParent = base.MdiParent;
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        this.frm.Text = "***NUEVO REGISTRO**";
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        this.frm.Text = "***NUEVO MODIFICAR**";
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        this.frm.Text = "***ELIMINAR**";
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        this.frm.Text = "***CONSULTAR**";
                        break;

                    default:
                        break;
                }
                this.frm.event_FrmCom_SolicitudCompraMantenimiento_FormClosing += new FrmCom_SolicitudCompra_Mant.delegate_FrmCom_SolicitudCompraMantenimiento_FormClosing(this.frm_event_FrmCom_SolicitudCompraMantenimiento_FormClosing);
                this.frm._SetInfo = this.Info;
                if ((this.Info.IdEstadoAprobacion == "APR_SOL") && (Accion.ToString() == "actualizar"))
                {
                    MessageBox.Show("La Solicitud de compra ha sido aprobado y no se puede modificar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    this.frm.Show();
                }
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + exception.Message + " ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}