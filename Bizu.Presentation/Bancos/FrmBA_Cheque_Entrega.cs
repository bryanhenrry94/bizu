using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bizu.Domain.Bancos;
using Bizu.Domain.General;
using Bizu.Application.Bancos;
using Bizu.Application.General;
using DevExpress.XtraEditors.Camera;
using Bizu.Application.Mail;
using Bizu.Domain.Mail;

namespace Bizu.Presentation.Bancos
{
    public partial class FrmBA_Cheque_Entrega : DevExpress.XtraEditors.XtraForm
    {
        // Propiedades
        string msg = "";
        // delegate
        public delegate void delegate_FrnBA_entrega_cheque_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrnBA_entrega_cheque_FormClosing event_FrnBA_entrega_cheque_FormClosing;
        // Bus
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ba_Cbte_Ban_Datos_Entrega_cheq_Bus bus = new ba_Cbte_Ban_Datos_Entrega_cheq_Bus();
        ba_Catalogo_Bus bus_catalogo = new ba_Catalogo_Bus();
        ba_Cbte_Ban_Bus comprobante_bus = new ba_Cbte_Ban_Bus();
        ba_parametros_Bus BusParametroBan = new ba_parametros_Bus();
        // List
        List<ba_Cbte_Ban_Info> ListCbteBanChecked = new List<ba_Cbte_Ban_Info>();
        List<ba_Catalogo_Info> lista_catalogo = new List<ba_Catalogo_Info>();
        ba_parametros_Info InfoParametroBan = new ba_parametros_Info();

        // constructor
        public FrmBA_Cheque_Entrega()
        {
            InitializeComponent();

            event_FrnBA_entrega_cheque_FormClosing += FrnBA_entrega_cheque_event_FrnBA_entrega_cheque_FormClosing;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += UcGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += UcGe_Menu_event_btnSalir_Click;
        }

        private void UcGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UcGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar()) return;

                if (Grabar())
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrnBA_entrega_cheque_event_FrnBA_entrega_cheque_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
        
        
        public void Set(List<ba_Cbte_Ban_Info> _ListCbteBanChecked)
        {
            ListCbteBanChecked = _ListCbteBanChecked;

            gridControlCbteCble.DataSource = ListCbteBanChecked;
        }
        
        private bool Validar()
        {
            try
            {
                bool ba = true;

                if(dtpFechaEntrega.EditValue == null)
                {
                    MessageBox.Show("El campo fecha entrega es requerido!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (txtCedula.EditValue == null)
                {
                    MessageBox.Show("El campo cédula es requerido!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (txtNombres.EditValue == null)
                {
                    MessageBox.Show("El campo nombres es requerido!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (txtApellidos.EditValue == null)
                {
                    MessageBox.Show("El campo apellidos es requerido!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                return ba;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool Grabar()
        {
            bool bandera = false;

            try
            {
                // obtiene el parametros del modulo bancos
                InfoParametroBan = BusParametroBan.Get_Info_Banco_Otros_Parametros(param.IdEmpresa);

                // valida que el objeto no este vacio o null
                if (InfoParametroBan == null)
                {
                    MessageBox.Show("No se ha cargado la informacion de parametro de bancos!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
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

                // verificamos que este activado la opcion notificacion cheque
                if (Convert.ToBoolean(InfoParametroBan.pa_notificacion_cheque) == false)
                {
                    if (MessageBox.Show("Se actualizara el estado de los cheques # "+ mensaje + " a ENTREGADO. Deseas Continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return false;

                    // Recorre la lista de los cheques seleccionados
                    foreach (var item in ListCbteBanChecked)
                    {
                        ba_Cbte_Ban_Datos_Entrega_cheq_Info InfoCbteBanDatosEntrega = new ba_Cbte_Ban_Datos_Entrega_cheq_Info();
                        InfoCbteBanDatosEntrega.IdEmpresa = item.IdEmpresa;
                        InfoCbteBanDatosEntrega.IdCbteCble = item.IdCbteCble;
                        InfoCbteBanDatosEntrega.IdTipocbte = item.IdTipocbte;
                        InfoCbteBanDatosEntrega.Cedula = Convert.ToString(txtCedula.EditValue);
                        InfoCbteBanDatosEntrega.Nombres = Convert.ToString(txtNombres.EditValue);
                        InfoCbteBanDatosEntrega.Apellidos = Convert.ToString(txtApellidos.EditValue);
                        InfoCbteBanDatosEntrega.NotaEntrega = Convert.ToString(txtNotaAdicional.EditValue);
                        InfoCbteBanDatosEntrega.FechaEntrega = Convert.ToDateTime(dtpFechaEntrega.EditValue);
                        InfoCbteBanDatosEntrega.FechaTransac = DateTime.Now;
                        InfoCbteBanDatosEntrega.IdUsuario = param.IdUsuario;
                        InfoCbteBanDatosEntrega.Foto = !ReferenceEquals(this.pic_foto.Image, null) ? Funciones.ImageAArray(this.pic_foto.Image) : null;

                        // Registra en la BD
                        if (bus.GrabarDB(InfoCbteBanDatosEntrega, ref msg))
                        {
                            comprobante_bus.ActualizarEstadoCheque(item.IdEmpresa, item.IdTipocbte, item.IdCbteCble, eEstado_Cheque.ESTCBENT);
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("Se actualizara el estado de los cheques # " + mensaje + " a ENTREGADO. Deseas Continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return false;

                    // Recorre la lista de los cheques seleccionados
                    foreach (var item in ListCbteBanChecked)
                    {
                        ba_Cbte_Ban_Datos_Entrega_cheq_Info InfoCbteBanDatosEntrega = new ba_Cbte_Ban_Datos_Entrega_cheq_Info();
                        InfoCbteBanDatosEntrega.IdEmpresa = item.IdEmpresa;
                        InfoCbteBanDatosEntrega.IdCbteCble = item.IdCbteCble;
                        InfoCbteBanDatosEntrega.IdTipocbte = item.IdTipocbte;
                        InfoCbteBanDatosEntrega.Cedula = Convert.ToString(txtCedula.EditValue);
                        InfoCbteBanDatosEntrega.Nombres = Convert.ToString(txtNombres.EditValue);
                        InfoCbteBanDatosEntrega.Apellidos = Convert.ToString(txtApellidos.EditValue);
                        InfoCbteBanDatosEntrega.NotaEntrega = Convert.ToString(txtNotaAdicional.EditValue);
                        InfoCbteBanDatosEntrega.FechaEntrega = Convert.ToDateTime(dtpFechaEntrega.EditValue);
                        InfoCbteBanDatosEntrega.FechaTransac = DateTime.Now;
                        InfoCbteBanDatosEntrega.IdUsuario = param.IdUsuario;
                        InfoCbteBanDatosEntrega.Foto = !ReferenceEquals(this.pic_foto.Image, null) ? Funciones.ImageAArray(this.pic_foto.Image) : null;

                        // Registra en la BD
                        if (bus.GrabarDB(InfoCbteBanDatosEntrega, ref msg))
                        {
                            comprobante_bus.ActualizarEstadoCheque(item.IdEmpresa, item.IdTipocbte, item.IdCbteCble, eEstado_Cheque.ESTCBENT);
                        }

                        if (Convert.ToBoolean(InfoParametroBan.pa_notificacion_cheque_auto))
                        {
                            Notificar_EmisionCheque(item.IdEmpresa, item.IdTipocbte, item.IdCbteCble);
                        }
                        else
                        {
                            if (MessageBox.Show("Deseas generar la notificacion via mail de los cheques #" + mensaje + "?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                Notificar_EmisionCheque(item.IdEmpresa, item.IdTipocbte, item.IdCbteCble);
                        }
                    }
                }

                MessageBox.Show(param.Get_Mensaje_sys(Bizu.Domain.General.enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // notificar cheques
        private void Notificar_EmisionCheque(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
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

                //BusCbteBan.ActualizarEstadoCheque(InfoCbteBan.IdEmpresa, InfoCbteBan.IdTipocbte, InfoCbteBan.IdCbteCble, eEstado_Cheque.ESTCBNOTI);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrnBA_entrega_cheque_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnCamera_Click(object sender, EventArgs e)
        {
            try
            {
                TakePictureDialog dialog = new TakePictureDialog
                {
                    Caption = "Tomar Foto"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.pic_foto.Image = dialog.Image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFileDialog_Click(object sender, EventArgs e)
        {
            try
            {
                this.pu_Abrir_Imagen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pu_Abrir_Imagen()
        {

            try
            {
                OpenFileDialog EscojaFoto = new OpenFileDialog();
                EscojaFoto.InitialDirectory = "c:\\";
                EscojaFoto.Filter = "JPG FILES (*.JPG)|*.jpg|GIF FILES (*.GIF)|*.gif|JPEG FILES (*.JPEG)|*.jpeg";
                EscojaFoto.RestoreDirectory = true;
                EscojaFoto.ShowDialog();

                if (EscojaFoto.FileName != "")
                {
                    pic_foto.Image = Image.FromFile(EscojaFoto.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrnBA_entrega_cheque_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_FrnBA_entrega_cheque_FormClosing(sender, e);
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            // voy a enviar a consultar a la tabla tb_persona por el campo pe_cedulaRuc

            // Capturamos el numero de cedula ingresado desde el formulario, dame 1 minuto
            string CedulaRuc = Convert.ToString(txtCedula.EditValue);

            // aqui no escribimos consulta sql de manera directa, lo hacemos a traves de las clases BUS, en este caso es la clase tb_persona_Bus
            tb_persona_bus BusPersona = new tb_persona_bus();

            // la clase tb_persona_bus tiene un metodo para consultar la tabla por el campo cedulaRuc llamado Get_Info_Persona
            tb_persona_Info InfoPersona = BusPersona.Get_Info_Persona(CedulaRuc);

            // El metodo Get_Info_Persona recibe como parametro la cedula y devuelve un objeto de tipo tb_persona_Info.
            // Con los datos recuperados se procede a llenar la informacion en el formulario: txtNombres, txtApellidos
            txtNombres.EditValue = InfoPersona.pe_nombre;
            txtApellidos.EditValue = InfoPersona.pe_apellido;
        }
    }
}

