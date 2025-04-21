using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Winform.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.SeguridadAcceso;


namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_CashManagement_Cons : DevExpress.XtraEditors.XtraForm
    {
        #region Declaración de Variables
        seg_Menu_bus Busseg = new seg_Menu_bus();
        List<seg_Menu_info> Infoseg = new List<seg_Menu_info>();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ba_Cbte_Ban_Bus CbteBan_B = new ba_Cbte_Ban_Bus();
        ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ba_Cbte_Ban_Info CbteBan_I = new ba_Cbte_Ban_Info();
        List<ba_Cbte_Ban_Info> LstCbteBan_I = new List<ba_Cbte_Ban_Info>();
        List<ba_Catalogo_Info> lista_cat = new List<ba_Catalogo_Info>();
        ba_Catalogo_Bus bus_catalogo = new ba_Catalogo_Bus();

        List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> listParaBan = new List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info>();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus paramBa_B = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info InfoParam_Banco = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();

        string motiAnulacion, msg2;
        int IdTipoCbteRev;
        decimal IdCbteCbleRev;
        int IdTipoCbteRev_Che;
        int IdTipoCbteRev_ND;
        int IdTipoCbteRev_NC;
        int IdTipoCbteRev_Dpo;
        string MensajeError = "";
        #endregion

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());		
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControlCbteBanDep.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());		
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (CbteBan_I == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (CbteBan_I.Estado == "I")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    PrepararFrm(Cl_Enumeradores.eTipo_action.Anular, CbteBan_I);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());		
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                if (CbteBan_I == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (CbteBan_I.Estado == "I")
                {
                    //El_registro_se_encuentra_anulado
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    PrepararFrm(Cl_Enumeradores.eTipo_action.actualizar, CbteBan_I);
                }
                
                
                            
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());		
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                PrepararFrm(Cl_Enumeradores.eTipo_action.consultar, CbteBan_I);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());		
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                load_data();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());		
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                PrepararFrm(Cl_Enumeradores.eTipo_action.grabar, CbteBan_I);
                load_data();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());		
            }
        }

        private void PrepararFrm(Cl_Enumeradores.eTipo_action Accion, ba_Cbte_Ban_Info Info)
        {
            try
            {
                FrmBA_CashManagement_Mant frm;
                frm = new FrmBA_CashManagement_Mant();
                frm.set_Accion(Accion);
                frm.MdiParent = this.MdiParent;
                frm.event_frmBA_ChequesMantenimiento_FormClosing += new FrmBA_CashManagement_Mant.delegate_frmBA_ChequesMantenimiento_FormClosing(frm_event_frmBA_ChequesMantenimiento_FormClosing);
                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {

                    frm.set_Info_CbteBan(Info);
                }
                frm.Show();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());		
            }

        }

        void frm_event_frmBA_ChequesMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                load_data();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());		
            }
        }

        private void frmBA_ChequesConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                //Control de Usuario
                Infoseg = Busseg.Get_List_Menu_x_Empresa_x_Usuario_Control(param.IdEmpresa, param.IdUsuario, "Bancos.FrmBA_CashManagement_Cons");
                foreach (var item in Infoseg)
                {
                    if (item.Eliminacion == false)
                    {
                        ucGe_Menu_Mantenimiento_x_usuario.btnAnular.Enabled = false;
                    }
                    if (item.Escritura == false)
                    {
                        ucGe_Menu_Mantenimiento_x_usuario.btnModificar.Enabled = false;
                    }
                }

                cmb_estado_cat.DisplayMember = "ca_descripcion";
                cmb_estado_cat.ValueMember = "IdCatalogo";
                lista_cat = bus_catalogo.Get_List_Catalogo("EST_CB_BA");
                cmb_estado_cat.DataSource = lista_cat;
                
                listParaBan = paramBa_B.Get_List_Banco_Parametros(param.IdEmpresa);
                
                InfoParam_Banco = listParaBan.Find(delegate(ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info P) { return P.CodTipoCbteBan == "TRANS"; });
                if (InfoParam_Banco == null)
                {
                    MessageBox.Show("No puede continuar porque no han ingresado los parámetros de banco.. \nIngréselos desde la pantalla de parámetros de banco, o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    if (InfoParam_Banco.IdTipoCbteCble <= 0 || InfoParam_Banco.IdTipoCbteCble_Anu <= 0)
                    {
                        MessageBox.Show("No puede continuar porque están incompletos los parámetros de banco.. \nIngréselos desde la pantalla de parámetros de banco, o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                        this.Close();
                    }
                }

                load_data();
              
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());		
            }
        }

        public FrmBA_CashManagement_Cons()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.btnNuevoChq.Caption="Entregar cheq.";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());		
            }
        }
       
        private void chequeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                PrepararFrm(Cl_Enumeradores.eTipo_action.grabar, CbteBan_I);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());		
            }
        }

        public void load_data()
        {
            try
            {
               
                this.gridControlCbteBanDep.DataSource = CbteBan_B.Get_List_Cbte_Ban(param.IdEmpresa
                    , InfoParam_Banco.IdTipoCbteCble, InfoParam_Banco.IdTipoCbteCble
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta, ref MensajeError);

                gridControlCbteBanDep.RefreshDataSource();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());		
            }
        }

        private void UltraGridCbteBan_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = UltraGridCbteBanDep.GetRow(e.RowHandle) as ba_Cbte_Ban_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());		
            }
        }

        private ba_Cbte_Ban_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (ba_Cbte_Ban_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());		
                return new ba_Cbte_Ban_Info();
            }
        }

        private void UltraGridCbteBan_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                CbteBan_I = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());		
            }
        }

        private void UltraGridCbteBan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                CbteBan_I = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());		
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevoChq_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                if (CbteBan_I == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (CbteBan_I.Estado == "I")
                {
                    //El_registro_se_encuentra_anulado
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
               
                    if (CbteBan_I.IdEstado_cheque_cat == eEstado_Cheque.ESTCBENT)
                    {
                        //El_registro_se_encuentra_anulado
                        MessageBox.Show("El chq. seleccionado fue entregado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }


                    if (CbteBan_I.IdEstado_cheque_cat == eEstado_Cheque.ESTCBCOB)
                    {
                        //El_registro_se_encuentra_anulado
                        MessageBox.Show("El chq. seleccionado fue entregado y cobrado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }         
    }
}
