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
using Core.Erp.Info.Mail;
using Core.Erp.Winform.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Mail;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.SeguridadAcceso;


namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Cheques_Consul : DevExpress.XtraEditors.XtraForm
    {

        #region Declaración de Variables
        seg_Menu_bus Busseg = new seg_Menu_bus();
        List<seg_Menu_info> Infoseg = new List<seg_Menu_info>();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ba_Cbte_Ban_Bus CbteBan_B = new ba_Cbte_Ban_Bus();
        ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ba_Cbte_Ban_Info CbteBan_I = new ba_Cbte_Ban_Info();
        List<ba_Cbte_Ban_Info> ListCbteBanInfo = new List<ba_Cbte_Ban_Info>();
        List<ba_Catalogo_Info> lista_cat = new List<ba_Catalogo_Info>();
        ba_Catalogo_Bus bus_catalogo = new ba_Catalogo_Bus();
        ba_parametros_Bus BusParametroBan = new ba_parametros_Bus();
        ba_parametros_Info InfoParametroBan = new ba_parametros_Info();
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
                FrmBA_Cheques_Mant frm;
                frm = new FrmBA_Cheques_Mant();
                frm.set_Accion(Accion);
                frm.MdiParent = this.MdiParent;
                frm.event_frmBA_ChequesMantenimiento_FormClosing += new FrmBA_Cheques_Mant.delegate_frmBA_ChequesMantenimiento_FormClosing(frm_event_frmBA_ChequesMantenimiento_FormClosing);
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
                Infoseg = Busseg.Get_List_Menu_x_Empresa_x_Usuario_Control(param.IdEmpresa, param.IdUsuario, "Bancos.FrmBA_Cheques_Consul");
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

        public FrmBA_Cheques_Consul()
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
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNotificar_ItemClick += UcGe_Menu_Mantenimiento_x_usuario_event_btnNotificar_ItemClick;

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

        private void UcGe_Menu_Mantenimiento_x_usuario_event_btnNotificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // valida que la lista contenga registros
                if (ListCbteBanInfo.Count <= 0)
                {
                    MessageBox.Show("No existen registros", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // obtenemos una nueva lista solo con los registros seleccionados
                List<ba_Cbte_Ban_Info> ListCbteBanChecked = ListCbteBanInfo.Where(q => q.Cheked == true).ToList();

                // validamos que exista al menos un registro seleccionado en la nueva lista
                if (ListCbteBanChecked.Count <= 0)
                {
                    MessageBox.Show("No existen registros, seleccione al menos un cheque para notificar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // obtiene el parametros del modulo bancos
                InfoParametroBan = BusParametroBan.Get_Info_Banco_Otros_Parametros(param.IdEmpresa);

                // valida que el objeto no este vacio o null
                if (InfoParametroBan == null)
                {
                    MessageBox.Show("No se ha cargado la informacion de parametro de bancos!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // verificamos que este activado la opcion notificacion cheque
                if (Convert.ToBoolean(InfoParametroBan.pa_notificacion_cheque) == false)
                    return;

                foreach (var item in ListCbteBanChecked)
                {
                    if (item.IdEstado_cheque_cat == eEstado_Cheque.ESTCBNOTI)
                    {
                        MessageBox.Show("El cheque #" + item.cb_Cheque + " ya se encuenta NOTIFICADO!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (item.IdEstado_cheque_cat == eEstado_Cheque.ESTCBENT)
                    {
                        MessageBox.Show("El cheque #" + item.cb_Cheque + " ya se encuenta ENTREGADO!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (item.Estado == "I")
                    {
                        MessageBox.Show("El cheque #" + item.cb_Cheque + " ya se encuenta ANULADO!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string mensaje = "";

                foreach (var item in ListCbteBanChecked)
                {
                    if (string.IsNullOrEmpty(mensaje))
                        mensaje = mensaje + item.cb_Cheque;
                    else
                        mensaje = mensaje + ", " + item.cb_Cheque;
                }

                // Notifica Automaticamente
                if (Convert.ToBoolean(InfoParametroBan.pa_notificacion_cheque_auto) == true)
                {
                    if (MessageBox.Show("Se procedera a notificar los cheques #" + mensaje + " via mail. Deseas continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        return;

                    // recorre la lista de cheques seleccionado y graba en la tabla mail_Mail para luego enviar los correos de notificacion
                    foreach (var item in ListCbteBanChecked)
                    {
                        Notificar_EmisionCheque(item.IdEmpresa, item.IdTipocbte, item.IdCbteCble, eEstado_Cheque.ESTCBNOTI);
                    }

                    MessageBox.Show("Proceso finalizado!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    // Si notificacion automatica es Falso, muestra modal
                    FrmBA_Cheque_Notificacion frmChequeNotificacion = new FrmBA_Cheque_Notificacion();
                    frmChequeNotificacion.ShowDialog();

                    if (frmChequeNotificacion.MetodoEnvio == Cl_Enumeradores.eMetodoEnvio.Correo)
                    {
                        if (MessageBox.Show("Se enviara una notificacion via correo electronico a los cheques #" + mensaje + ". Deseas continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                            return;

                        // recorre la lista de cheques seleccionado y graba en la tabla mail_Mail para luego enviar los correos de notificacion
                        foreach (var item in ListCbteBanChecked)
                        {
                            Notificar_EmisionCheque(item.IdEmpresa, item.IdTipocbte, item.IdCbteCble, eEstado_Cheque.ESTCBNOTI);
                        }

                        MessageBox.Show("Proceso finalizado!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (frmChequeNotificacion.MetodoEnvio == Cl_Enumeradores.eMetodoEnvio.Manual)
                    {
                        if (MessageBox.Show("Se actualizara el estado de los cheques #" + mensaje + " a NOTIFICADO. Deseas continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                            return;

                        // actualiza manual
                        ba_Cbte_Ban_Bus BusCbteBan = new ba_Cbte_Ban_Bus();

                        foreach (var item in ListCbteBanChecked)
                        {
                            BusCbteBan.ActualizarEstadoCheque(item.IdEmpresa, item.IdTipocbte, item.IdCbteCble, eEstado_Cheque.ESTCBNOTI);
                        }

                        load_data();
                        MessageBox.Show("Proceso finalizado!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Notificar_EmisionCheque(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble, eEstado_Cheque EstadoCheque)
        {
            try
            {
                string mensaje = "";
                mail_Mail_Bus Bus_Mail = new mail_Mail_Bus();

                ba_Cbte_Ban_Bus BusCbteBan = new ba_Cbte_Ban_Bus();
                ba_Cbte_Ban_Info InfoCbteBan = BusCbteBan.Get_Info_Cbte_Ban(IdEmpresa, IdTipoCbte, IdCbteCble, ref mensaje);

                int iCorreos_Enviados = 0;

                string correo = "";
                string sMensaje = "";

                tb_persona_bus Bus_Persona = new tb_persona_bus();
                tb_persona_Info Info_Persona = new tb_persona_Info();

                mail_Plantilla_Mensaje_Info Info_Plantilla_Mensaje = new mail_Plantilla_Mensaje_Info();
                mail_Plantilla_Mensaje_Bus Bus_Plantilla_Mensaje = new mail_Plantilla_Mensaje_Bus();

                Info_Persona = Bus_Persona.Get_Info_Persona(Convert.ToDecimal(InfoCbteBan.IdPersona_Girado_a));

                if (Info_Persona != null)
                    if (!string.IsNullOrEmpty(Info_Persona.pe_correo))
                        correo = Info_Persona.pe_correo;

                Info_Plantilla_Mensaje = Bus_Plantilla_Mensaje.Get_Info(param.IdEmpresa, "NOTIF_CHEQUE");

                if (Info_Plantilla_Mensaje != null)
                    sMensaje = Info_Plantilla_Mensaje.Mensaje;

                // Si el campo correo y el campo sMensaje es vacio o null finaliza la funcion
                if (string.IsNullOrEmpty(correo) && string.IsNullOrEmpty(sMensaje))
                    return;

                sMensaje = sMensaje.Replace("{idempresa}", param.InfoEmpresa.RazonSocial);
                sMensaje = sMensaje.Replace("{paguesea}", InfoCbteBan.cb_giradoA);
                sMensaje = sMensaje.Replace("{nrocheque}", InfoCbteBan.cb_Cheque);
                sMensaje = sMensaje.Replace("{fechacheque}", Convert.ToDateTime(InfoCbteBan.cb_FechaCheque).ToString("dd/MM/yyyy"));

                // Obtengo de mi lista de banco filtrando por IdBanco y solo recupero el campo ba_descripcion
                string nombreBanco = "";

                try
                {
                    tb_banco_Bus BusBancos = new tb_banco_Bus();
                    List<tb_banco_Info> ListBanco = BusBancos.Get_List_Banco();

                    nombreBanco = ListBanco.Where(q => q.IdBanco == InfoCbteBan.IdBanco).Select(q => q.ba_descripcion).FirstOrDefault();
                }
                catch (Exception)
                {

                }

                sMensaje = sMensaje.Replace("{nombredebanco}", nombreBanco);
                sMensaje = sMensaje.Replace("{observacion}", InfoCbteBan.cb_Observacion);
                sMensaje = sMensaje.Replace("{valorcheque}", Math.Round(InfoCbteBan.cb_Valor, 2).ToString());

                mail_Mail_Info Info_Mail = new mail_Mail_Info();
                Info_Mail.IdEmpresa = param.IdEmpresa;
                Info_Mail.IdSucursal = param.IdSucursal;
                Info_Mail.IdMail = 0;
                Info_Mail.IdUsuario = param.IdUsuario;
                Info_Mail.Origen = "Banco";
                Info_Mail.Asunto = "Notificación de Cheque";
                Info_Mail.Mensaje = sMensaje;
                Info_Mail.To.Add(correo);

                string correo_secundario1 = Info_Persona.pe_correo_secundario1;
                string correo_secundario2 = Info_Persona.pe_correo_secundario2;
               
                if (!string.IsNullOrEmpty(correo_secundario1))
                    Info_Mail.CC.Add(correo_secundario1);

                if (!string.IsNullOrEmpty(correo_secundario2))
                    Info_Mail.CC.Add(correo_secundario2);

                if (Bus_Mail.GrabarBD(Info_Mail, ref mensaje))
                    iCorreos_Enviados += 1;

                BusCbteBan.ActualizarEstadoCheque(InfoCbteBan.IdEmpresa, InfoCbteBan.IdTipocbte, InfoCbteBan.IdCbteCble, EstadoCheque);
                load_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Consulta en la base de datos la lista de ba_cbte_ban
                 ListCbteBanInfo = CbteBan_B.Get_List_Cbte_Ban(param.IdEmpresa, 2, 2, ucGe_Menu_Mantenimiento_x_usuario.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta, ref MensajeError);

                this.gridControlCbteBanDep.DataSource = ListCbteBanInfo;
                this.gridControlCbteBanDep.RefreshDataSource();
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

                if(data.IdEstado_cheque_cat == eEstado_Cheque.ESTCBNOTI)
                    e.Appearance.ForeColor = Color.Blue;

                if (data.IdEstado_cheque_cat == eEstado_Cheque.ESTCBENT)
                    e.Appearance.ForeColor = Color.Green;

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

        private void UltraGridCbteBanDep_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            ba_Cbte_Ban_Info RowSelected = (ba_Cbte_Ban_Info) UltraGridCbteBanDep.GetFocusedRow();

            if (RowSelected == null) return;

            if(e.Column == colCheck)
            {
                if (RowSelected.Cheked)
                    UltraGridCbteBanDep.SetFocusedRowCellValue(colCheck, false);
                else
                    UltraGridCbteBanDep.SetFocusedRowCellValue(colCheck, true);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevoChq_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // valida que la lista contenga registros
                if (ListCbteBanInfo.Count <= 0)
                {
                    MessageBox.Show("No existen registros", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // obtenemos una nueva lista solo con los registros seleccionados
                List<ba_Cbte_Ban_Info> ListCbteBanChecked = ListCbteBanInfo.Where(q => q.Cheked == true).ToList();
            
                // validamos que exista al menos un registro seleccionado en la nueva lista
                if (ListCbteBanChecked != null && ListCbteBanChecked.Count <= 0)
                {
                    MessageBox.Show("No existen registros, seleccione al menos un cheque para notificar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                // validar los estado del cheque antes de hacer la entrega
                foreach (var item in ListCbteBanChecked)
                {
                    if (item.Estado == "I")
                    {
                        MessageBox.Show("El cheque #" + item.cb_Cheque + " ya se encuenta ANULADO!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (item.IdEstado_cheque_cat == eEstado_Cheque.ESTCBEMI)
                    {
                        MessageBox.Show("El cheque #" + item.cb_Cheque + " no ha sido notificado!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (item.IdEstado_cheque_cat == eEstado_Cheque.ESTCBENT)
                    {
                        MessageBox.Show("El cheque #" + item.cb_Cheque + " ya se encuenta ENTREGADO!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // armar el mensaje de los cheques seleccionados
                string mensaje = "";
                foreach (var item in ListCbteBanChecked)
                {
                    if (string.IsNullOrEmpty(mensaje))
                        mensaje = mensaje + item.cb_Cheque;
                    else
                        mensaje = mensaje + ", " + item.cb_Cheque;
                }

                // Si es SI solo cambia el estado del cheque, caso contrario abre el modal
                if (MessageBox.Show("¿Desea pasar los cheques seleccionados [" + mensaje + "] al estado entregado sin información de los receptores?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // cambiar el estado de cheque a entregado
                    foreach (var item in ListCbteBanChecked)
                    {
                        Notificar_EmisionCheque(item.IdEmpresa, item.IdTipocbte, item.IdCbteCble, eEstado_Cheque.ESTCBENT);
                    }
                }
                else
                {
                    //EJEMPLO DE AGRUPAR
                    var select_ = from T in ListCbteBanChecked
                                  group T by new
                                  {
                                      T.IdEmpresa,
                                      T.IdSucursal,
                                      T.IdProveedor
                                  }
                        into grouping
                                  let count = grouping.Count()
                                  select new { grouping.Key, valorTotal = grouping.Sum(p => p.cb_Valor) };

                    if (select_.Count() > 1)
                    {
                        MessageBox.Show("No es posible entregar cheques de diferentes beneficiarios!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // abrir el modal para ingresar la informacion del receptor
                    FrmBA_Cheque_Entrega frm = new FrmBA_Cheque_Entrega();
                    frm.Set(ListCbteBanChecked);
                    //frm.MdiParent = this.MdiParent;
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.event_FrnBA_entrega_cheque_FormClosing += Frm_event_FrnBA_entrega_cheque_FormClosing;
                    frm.ShowDialog();
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

        private void Frm_event_FrnBA_entrega_cheque_FormClosing(object sender, FormClosingEventArgs e)
        {
            load_data();
        }
    }
}
