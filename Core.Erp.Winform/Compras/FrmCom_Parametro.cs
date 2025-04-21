using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using DevExpress.XtraBars;

namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_Parametro : DevExpress.XtraEditors.XtraForm
    {
        #region Declaración de Variables
        com_Catalogo_Bus Catalogo_bus = new com_Catalogo_Bus();
        in_movi_inven_tipo_Bus MoviTipoBus = new in_movi_inven_tipo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        com_parametro_Bus ParaBus = new com_parametro_Bus();
        com_parametro_Info Info_parametro = new com_parametro_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        bool B_siExiste = true;
        #endregion

        public FrmCom_Parametro()
        {
            InitializeComponent();

            ucGe_Menu_Superior_Mant.event_btnGuardar_Click += ucGe_Menu_Superior_Mant_event_btnGuardar_Click;
            ucGe_Menu_Superior_Mant.event_btnSalir_Click += ucGe_Menu_Superior_Mant_event_btnSalir_Click;

        }

        void ucGe_Menu_Superior_Mant_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                base.Close();
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        Boolean validar(com_parametro_Info Info_Param)
        {
            try
            {
                if (Info_Param.IdEmpresa == 0)
                {
                    MessageBox.Show("No tiene IdEmpresa el Info", this.param.nom_pc, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
                if ((Info_Param.IdEstadoAnulacion_OC == "") || ReferenceEquals(Info_Param.IdEstadoAnulacion_OC, null))
                {
                    MessageBox.Show("No tiene el estado de Anulacion de Orden de Compra", this.param.nom_pc, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
                if ((Info_Param.IdEstadoAprobacion_OC == "") || ReferenceEquals(Info_Param.IdEstadoAprobacion_OC, null))
                {
                    MessageBox.Show("No tiene el estado de Aprobacion de Orden de Compra", this.param.nom_pc, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
                if ((Info_Param.IdEstadoAprobacion_SolCompra == "") || ReferenceEquals(Info_Param.IdEstadoAprobacion_SolCompra, null))
                {
                    MessageBox.Show("No tiene el estado de Aprobacion de la Solicitud de Compra", this.param.nom_pc, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
                if (Info_Param.IdMovi_inven_tipo_dev_compra == 0)
                {
                    MessageBox.Show("No tiene el tipo de movimiento de devolucion de compra", this.param.nom_pc, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
                if (Info_Param.IdMovi_inven_tipo_OC == 0)
                {
                    MessageBox.Show("No tiene el tipo de movimiento de inventario por orden de compra", this.param.nom_pc, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
                return true;
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
        }

        void ucGe_Menu_Superior_Mant_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.get_info();
                if (this.validar(this.Info_parametro))
                {
                    if (!(this.B_siExiste ? this.ParaBus.ModificarDB(this.Info_parametro, ref this.mensaje) : this.ParaBus.GuardarDB(this.Info_parametro, ref this.mensaje)))
                    {
                        MessageBox.Show("Parametros de Compras no pueden ser Ingresados");
                    }                    
                }
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void cargar_parametros()
        {
            try
            {
                List<com_parametro_Info> source = new List<com_parametro_Info>();
                source = this.ParaBus.Get_List_parametro(this.param.IdEmpresa);
                this.B_siExiste = source.Count<com_parametro_Info>() != 0;
                foreach (com_parametro_Info info in source)
                {
                    this.cmb_estado_cierre_oc.EditValue = info.IdEstado_cierre;
                    this.cmb_estado_anulacion.EditValue = info.IdEstadoAnulacion_OC;
                    this.cmb_estado_aprobacion.EditValue = info.IdEstadoAprobacion_OC;
                    this.cmbestadoAprobacion_solCom.EditValue = info.IdEstadoAprobacion_SolCompra;
                    this.cmbTipoMovInven_x_devCom.EditValue = info.IdMovi_inven_tipo_dev_compra;
                    this.cmb_tipo_movi_inven_x_oc.EditValue = info.IdMovi_inven_tipo_OC;
                    this.cmb_sucursalxaprobacionsc.set_SucursalInfo(info.IdSucursal_x_Aprob_x_SolComp);
                    this.txt_default_dias_plazo.EditValue = info.default_dias_plazo;
                    this.txt_default_dias_vencidos.EditValue = info.default_dias_vencidos;
                    this.chkNotificaAprobacionOC.Checked = Convert.ToBoolean(info.NotificaAprobacionOC);
                    this.chkNotificaAprobacionOCAuto.Checked = Convert.ToBoolean(info.NotificaAprobacionOCAuto);
                }
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

        private void get_info()
        {
            try
            {
                this.Info_parametro = new com_parametro_Info();
                this.ucGe_Menu_Superior_Mant.Focus();
                this.Info_parametro.IdEmpresa = this.param.IdEmpresa;
                this.Info_parametro.IdEstadoAprobacion_OC = (this.cmb_estado_aprobacion.EditValue == null) ? null : Convert.ToString(this.cmb_estado_aprobacion.EditValue);
                this.Info_parametro.IdMovi_inven_tipo_OC = (this.cmb_tipo_movi_inven_x_oc.EditValue == null) ? 0 : Convert.ToInt32(this.cmb_tipo_movi_inven_x_oc.EditValue);
                this.Info_parametro.IdEstadoAnulacion_OC = (this.cmb_estado_anulacion.EditValue == null) ? null : Convert.ToString(this.cmb_estado_anulacion.EditValue);
                this.Info_parametro.IdMovi_inven_tipo_dev_compra = (this.cmbTipoMovInven_x_devCom.EditValue == null) ? 0 : Convert.ToInt32(this.cmbTipoMovInven_x_devCom.EditValue);
                this.Info_parametro.IdEstadoAprobacion_SolCompra = (this.cmbestadoAprobacion_solCom.EditValue == null) ? null : Convert.ToString(this.cmbestadoAprobacion_solCom.EditValue);
                int idSucursal = this.cmb_sucursalxaprobacionsc.get_SucursalInfo().IdSucursal;
                this.Info_parametro.IdSucursal_x_Aprob_x_SolComp = Convert.ToInt32(this.cmb_sucursalxaprobacionsc.get_SucursalInfo().IdSucursal);
                this.Info_parametro.IdEstado_cierre = (this.cmb_estado_cierre_oc.EditValue == null) ? null : Convert.ToString(this.cmb_estado_cierre_oc.EditValue);
                this.Info_parametro.default_dias_plazo = new int?(Convert.ToInt32(this.txt_default_dias_plazo.EditValue));
                this.Info_parametro.default_dias_vencidos = new int?(Convert.ToInt32(this.txt_default_dias_vencidos.EditValue));
                this.Info_parametro.NotificaAprobacionOC = Convert.ToBoolean(chkNotificaAprobacionOC.Checked);
                this.Info_parametro.NotificaAprobacionOCAuto = Convert.ToBoolean(chkNotificaAprobacionOCAuto.Checked);
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void FrmCom_Parametro_Load(object sender, EventArgs e)
        {
            try
            {
                this.cargar_combos();
                this.cargar_parametros();
            }
            catch (Exception exception)
            {
                this.Log_Error_bus.Log_Error(exception.ToString());
                MessageBox.Show(exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void cargar_combos()
        {

            try
            {
                List<com_Catalogo_Info> listEstaAprob = new List<com_Catalogo_Info>();
                listEstaAprob = Catalogo_bus.Get_ListEstadoAprobacion();
                cmb_estado_aprobacion.Properties.DataSource = listEstaAprob;


                List<in_movi_inven_tipo_Info> ListMoviInven_tipo = new List<in_movi_inven_tipo_Info>();
                ListMoviInven_tipo = MoviTipoBus.Get_list_movi_inven_tipo(param.IdEmpresa, "+", "", "");
                cmb_tipo_movi_inven_x_oc.Properties.DataSource = ListMoviInven_tipo;


                List<com_Catalogo_Info> listEstaAnulacion = new List<com_Catalogo_Info>();
                listEstaAnulacion = Catalogo_bus.Get_ListEstadoAnulacion();
                cmb_estado_anulacion.Properties.DataSource = listEstaAnulacion;


                List<in_movi_inven_tipo_Info> ListMoviInven_tipo_devCom = new List<in_movi_inven_tipo_Info>();
                ListMoviInven_tipo_devCom = MoviTipoBus.Get_list_movi_inven_tipo(param.IdEmpresa, "+", "", "");
                cmbTipoMovInven_x_devCom.Properties.DataSource = ListMoviInven_tipo_devCom;
                cmbTipoMovInven_x_devCom.Properties.DisplayMember = "tm_descripcion2";
                cmbTipoMovInven_x_devCom.Properties.ValueMember = "IdMovi_inven_tipo";


                List<com_Catalogo_Info> listEstaAprob_solicitud_compra = new List<com_Catalogo_Info>();
                listEstaAprob_solicitud_compra = Catalogo_bus.Get_ListEstadoAprobacion_solicitud_compra();
                cmbestadoAprobacion_solCom.Properties.DataSource = listEstaAprob_solicitud_compra;


                com_estado_cierre_Bus EstadoCierBus = new com_estado_cierre_Bus();

                List<com_estado_cierre_Info> listEstadoCierre = new List<com_estado_cierre_Info>();
                listEstadoCierre = EstadoCierBus.Get_List_estado_cierre();
                cmb_estado_cierre_oc.Properties.DataSource = listEstadoCierre;






            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkNotificaAprobacionOC_CheckedChanged(object sender, EventArgs e)
        {
            chkNotificaAprobacionOCAuto.Visible = chkNotificaAprobacionOC.Checked;
        }
    }
}
