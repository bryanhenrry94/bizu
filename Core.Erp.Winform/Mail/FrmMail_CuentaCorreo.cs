using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Mail;
using Core.Erp.Info.Mail;

namespace Core.Erp.Winform.Mail
{
    public partial class FrmMail_CuentaCorreo : DevExpress.XtraEditors.XtraForm
    {
        public delegate void delegate_FrmMail_CuentaCorreo_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmMail_CuentaCorreo_FormClosing event_FrmMail_CuentaCorreo_FormClosing;

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action _Accion;

        mail_Cuenta_Correo_Bus Bus_Cuenta_Correo = new mail_Cuenta_Correo_Bus();
        tb_Empresa_Bus Bus_Empresas = new tb_Empresa_Bus();

        List<tb_Empresa_Info> List_Empresas = new List<tb_Empresa_Info>();
        List<tipo_conexion> List_tipo_conexion = new List<tipo_conexion>();

        mail_Cuenta_Correo_Info Info_Cuenta_Correo = new mail_Cuenta_Correo_Info();

        public FrmMail_CuentaCorreo()
        {
            InitializeComponent();

            event_FrmMail_CuentaCorreo_FormClosing += FrmMail_CuentaCorreo_event_FrmMail_CuentaCorreo_FormClosing;

            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            if (Guardar()) this.Close();
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        void FrmMail_CuentaCorreo_event_FrmMail_CuentaCorreo_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        public void Set_Accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            this._Accion = _Accion;
        }

        public void Set_Info(mail_Cuenta_Correo_Info Info_Cuenta_Correo)
        {
            this.Info_Cuenta_Correo = Info_Cuenta_Correo;
        }

        private void Get_Info()
        {
            try
            {
                this.Info_Cuenta_Correo.IdEmpresa = Convert.ToInt32(cmb_empresa.EditValue);
                this.Info_Cuenta_Correo.IdCuenta = Convert.ToString(txt_IdCuenta.EditValue);
                this.Info_Cuenta_Correo.Nombre = Convert.ToString(txt_nombre.EditValue);
                this.Info_Cuenta_Correo.Direccion_Correo = Convert.ToString(txt_direccion_correo_electronico.EditValue);
                this.Info_Cuenta_Correo.Enviar_copia_correo_oculta = Convert.ToBoolean(chk_enviar_copia_a_correo_oculto.EditValue);
                this.Info_Cuenta_Correo.Cuenta_Correo_Copia = Convert.ToString(txt_correo_electronico_copia_oculta.EditValue);
                this.Info_Cuenta_Correo.Servidor_Correo = Convert.ToString(txt_servidor_correo.EditValue);
                this.Info_Cuenta_Correo.Tipo_Conexion = Convert.ToString(cmb_tipo_conexion.EditValue);
                this.Info_Cuenta_Correo.Puerto = Convert.ToInt32(txt_puerto.EditValue);
                this.Info_Cuenta_Correo.Usuario = Convert.ToString(txt_usuario.EditValue);
                this.Info_Cuenta_Correo.Contrasena = Convert.ToString(txt_contrasena.EditValue);
                this.Info_Cuenta_Correo.Estado = (Convert.ToBoolean(chk_estado.EditValue) == true) ? "A" : "I";
                this.Info_Cuenta_Correo.Cuenta_Predeterminada = Convert.ToBoolean(chk_cuenta_predeterminada.EditValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMail_CuentaCorreo_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combo();

                Set_Accion_In_Control();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Set_Info_In_Control()
        {
            try
            {
                cmb_empresa.EditValue = this.Info_Cuenta_Correo.IdEmpresa;
                txt_IdCuenta.EditValue = this.Info_Cuenta_Correo.IdCuenta;
                txt_nombre.EditValue = this.Info_Cuenta_Correo.Nombre;
                txt_direccion_correo_electronico.EditValue = this.Info_Cuenta_Correo.Direccion_Correo;
                chk_enviar_copia_a_correo_oculto.EditValue = this.Info_Cuenta_Correo.Enviar_copia_correo_oculta;
                txt_correo_electronico_copia_oculta.EditValue = this.Info_Cuenta_Correo.Cuenta_Correo_Copia;
                txt_servidor_correo.EditValue = this.Info_Cuenta_Correo.Servidor_Correo;
                cmb_tipo_conexion.EditValue = this.Info_Cuenta_Correo.Tipo_Conexion;
                txt_puerto.EditValue = this.Info_Cuenta_Correo.Puerto;
                txt_usuario.EditValue = this.Info_Cuenta_Correo.Usuario;
                txt_contrasena.EditValue = this.Info_Cuenta_Correo.Contrasena;
                chk_estado.EditValue = (this.Info_Cuenta_Correo.Estado == "A") ? true : false;
                chk_cuenta_predeterminada.EditValue = this.Info_Cuenta_Correo.Cuenta_Predeterminada;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Set_Accion_In_Control()
        {
            try
            {
                switch (this._Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Always;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Always;
                        cmb_empresa.Properties.ReadOnly = false;
                        txt_IdCuenta.Properties.ReadOnly = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Always;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Always;
                        cmb_empresa.Properties.ReadOnly = true;
                        txt_IdCuenta.Properties.ReadOnly = true;

                        Set_Info_In_Control();
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Never;
                        cmb_empresa.Properties.ReadOnly = true;
                        txt_IdCuenta.Properties.ReadOnly = true;

                        Set_Info_In_Control();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean Validar()
        {
            try
            {
                if (cmb_empresa.EditValue == null)
                {
                    MessageBox.Show("El campo Empresa es obligatorio!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb_empresa.Focus();
                    return false;
                }

                if (txt_IdCuenta.EditValue == null)
                {
                    MessageBox.Show("El campo IdCuenta es obligatorio!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_IdCuenta.Focus();
                    return false;
                }

                if (txt_nombre.EditValue == null)
                {
                    MessageBox.Show("El campo Nombre es obligatorio!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_nombre.Focus();
                    return false;
                }

                if (txt_direccion_correo_electronico.EditValue == null)
                {
                    MessageBox.Show("El campo Dirección de Correo Electrónico es obligatorio!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_direccion_correo_electronico.Focus();
                    return false;
                }

                if (txt_servidor_correo.EditValue == null)
                {
                    MessageBox.Show("El campo Servidor de Correo es obligatorio!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_servidor_correo.Focus();
                    return false;
                }

                if (cmb_tipo_conexion.EditValue == null)
                {
                    MessageBox.Show("El campo Tipo de Conexion es obligatorio!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb_tipo_conexion.Focus();
                    return false;
                }

                if (txt_puerto.EditValue == null)
                {
                    MessageBox.Show("El campo Puerto es obligatorio!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_puerto.Focus();
                    return false;
                }

                if (txt_usuario.EditValue == null)
                {
                    MessageBox.Show("El campo Usuario es obligatorio!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_usuario.Focus();
                    return false;
                }

                if (txt_contrasena.EditValue == null)
                {
                    MessageBox.Show("El campo Contraseña es obligatorio!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_contrasena.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean Guardar()
        {
            try
            {
                if (!Validar()) return false;

                Get_Info();

                string mensaje = "";

                switch (this._Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        if (this.Bus_Cuenta_Correo.GrabarBD(this.Info_Cuenta_Correo, ref mensaje))
                        {
                            MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                            Set_Accion_In_Control();
                        }

                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:

                        if (this.Bus_Cuenta_Correo.ModificarBD(this.Info_Cuenta_Correo, ref mensaje))
                        {
                            MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void cargar_combo()
        {
            try
            {
                this.List_Empresas = Bus_Empresas.Get_List_Empresa();
                cmb_empresa.Properties.DataSource = this.List_Empresas;

                this.List_tipo_conexion.Add(new tipo_conexion("NA", "Ninguno", 25));
                this.List_tipo_conexion.Add(new tipo_conexion("SSL", "SSL", 465));
                this.List_tipo_conexion.Add(new tipo_conexion("TLS", "TLS", 587));

                cmb_tipo_conexion.Properties.DataSource = this.List_tipo_conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_tipo_conexion_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                tipo_conexion Info = List_tipo_conexion.Find(q => q.id == Convert.ToString(cmb_tipo_conexion.EditValue));

                if (Info != null)
                    txt_puerto.EditValue = Info.puerto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_enviar_copia_a_correo_oculto_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_enviar_copia_a_correo_oculto.Checked)
                txt_correo_electronico_copia_oculta.Properties.ReadOnly = false;
            else
                txt_correo_electronico_copia_oculta.Properties.ReadOnly = true;
        }

        private class tipo_conexion
        {
            public string id { get; set; }
            public string nombre { get; set; }
            public int puerto { get; set; }

            public tipo_conexion(string id, string nombre, int puerto)
            {
                this.id = id;
                this.nombre = nombre;
                this.puerto = puerto;
            }
        }

        private void FrmMail_CuentaCorreo_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_FrmMail_CuentaCorreo_FormClosing(sender, e);
        }
    }
}