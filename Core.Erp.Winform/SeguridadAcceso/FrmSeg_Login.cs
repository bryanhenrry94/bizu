using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.SeguridadAcceso
{
    public partial class FrmSeg_Login : DevExpress.XtraEditors.XtraForm
    {
        #region " Variables y Propiedades "
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private seg_usuario_info InfoUsuario = new seg_usuario_info();
        seg_usuario_bus BusUsuario = new seg_usuario_bus();
        Boolean LogonOk = false;
        #endregion

        #region " Constructor "
        public FrmSeg_Login()
        {
            InitializeComponent();
        }
        #endregion

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Core.Erp.Business.General.cl_parametrosGenerales_Bus.Instance.IdUsuario = null;
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btn_cambiar_contra_Click(object sender, EventArgs e)
        {

        }

        private Boolean ValidarUsuario()
        {
            try
            {
                Boolean resultado = true;
                if (string.IsNullOrEmpty(Convert.ToString(txtUsuario.EditValue).Trim()))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Usuario para poder cambiar de contraseña..", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void FrmSeg_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (LogonOk == false)
            {
                Core.Erp.Business.General.cl_parametrosGenerales_Bus.Instance.IdUsuario = null;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Login();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Login();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login()
        {
            try
            {
                InfoUsuario = new seg_usuario_info();
                InfoUsuario.IdUsuario = Convert.ToString(txtUsuario.EditValue);
                InfoUsuario.Contrasena = Convert.ToString(txtPassword.EditValue);
                string mensajeError = "";
                bool consulta = BusUsuario.Existe_Usuario(InfoUsuario.IdUsuario, ref mensajeError);
                if (mensajeError.Equals(""))
                {
                    if (consulta)
                    {
                        if (BusUsuario.Validar_Credenciales(InfoUsuario, ref mensajeError))
                        {
                            if (InfoUsuario.CambiarContraseniaSgtSesion == true)
                            {
                                FrmSeg_Cambiar_Contrasenia frm = new FrmSeg_Cambiar_Contrasenia();
                                frm.MdiParent = this.MdiParent;
                                frm.set_Info(InfoUsuario);
                                frm.Show();
                            }
                            else
                            {
                                InfoUsuario = BusUsuario.Get_Info_Usuario(InfoUsuario.IdUsuario, ref mensajeError);
                                Core.Erp.Business.General.cl_parametrosGenerales_Bus.Instance.IdUsuario = InfoUsuario.IdUsuario;
                                Core.Erp.Business.General.cl_parametrosGenerales_Bus.Instance.InfoUsuario = InfoUsuario;
                                LogonOk = true;
                                this.Close();
                            }
                        }
                        else
                        {
                            Core.Erp.Business.General.cl_parametrosGenerales_Bus.Instance.IdUsuario = null;
                            MessageBox.Show("La contraseña ingresada no es la correcta", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        Core.Erp.Business.General.cl_parametrosGenerales_Bus.Instance.IdUsuario = null;
                        MessageBox.Show("El usuario no existe", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show(mensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarUsuario())
                {
                    FrmSeg_Cambiar_Contrasenia frm = new FrmSeg_Cambiar_Contrasenia();
                    frm.MdiParent = this.MdiParent;
                    frm.set_usuario(Convert.ToString(txtUsuario.EditValue));
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}