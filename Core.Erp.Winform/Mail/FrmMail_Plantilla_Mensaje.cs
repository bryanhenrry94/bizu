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
    public partial class FrmMail_Plantilla_Mensaje : DevExpress.XtraEditors.XtraForm
    {
        public delegate void delegate_FrmMail_Plantilla_Mensaje_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmMail_Plantilla_Mensaje_FormClosing event_FrmMail_Plantilla_Mensaje_FormClosing;

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action _Accion;

        mail_Plantilla_Mensaje_Bus Bus_Plantilla_Mensaje = new mail_Plantilla_Mensaje_Bus();
        tb_Empresa_Bus Bus_Empresas = new tb_Empresa_Bus();

        List<tb_Empresa_Info> List_Empresas = new List<tb_Empresa_Info>();

        mail_Plantilla_Mensaje_Info Info_Plantilla_Mensaje = new mail_Plantilla_Mensaje_Info();

        public FrmMail_Plantilla_Mensaje()
        {
            InitializeComponent();

            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            event_FrmMail_Plantilla_Mensaje_FormClosing += FrmMail_Plantilla_Mensaje_event_FrmMail_Plantilla_Mensaje_FormClosing;
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            if (Guardar()) this.Close();
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void FrmMail_Plantilla_Mensaje_event_FrmMail_Plantilla_Mensaje_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        public void Set_Accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            this._Accion = _Accion;
        }

        public void Set_Info(mail_Plantilla_Mensaje_Info Info_Plantilla_Mensaje)
        {
            this.Info_Plantilla_Mensaje = Info_Plantilla_Mensaje;
        }

        private void Get_Info()
        {
            try
            {
                this.Info_Plantilla_Mensaje.IdEmpresa = Convert.ToInt32(cmb_empresa.EditValue);
                this.Info_Plantilla_Mensaje.IdMensaje = Convert.ToString(txt_IdMensaje.EditValue);
                this.Info_Plantilla_Mensaje.Mensaje = txt_Mensaje.Text;
                this.Info_Plantilla_Mensaje.Estado = (Convert.ToBoolean(chk_estado.EditValue) == true) ? "A" : "I";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMail_Plantilla_Mensaje_Load(object sender, EventArgs e)
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

        private void cargar_combo()
        {
            try
            {
                this.List_Empresas = Bus_Empresas.Get_List_Empresa();
                cmb_empresa.Properties.DataSource = this.List_Empresas;
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
                cmb_empresa.EditValue = this.Info_Plantilla_Mensaje.IdEmpresa;
                txt_IdMensaje.EditValue = this.Info_Plantilla_Mensaje.IdMensaje;
                txt_Mensaje.Text = this.Info_Plantilla_Mensaje.Mensaje;
                chk_estado.EditValue = (this.Info_Plantilla_Mensaje.Estado == "A") ? true : false;
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
                        txt_IdMensaje.Properties.ReadOnly = false;
                        chk_estado.Properties.ReadOnly = false;

                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Always;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Always;
                        cmb_empresa.Properties.ReadOnly = true;
                        txt_IdMensaje.Properties.ReadOnly = true;
                        chk_estado.Properties.ReadOnly = true;

                        Set_Info_In_Control();
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Never;
                        cmb_empresa.Properties.ReadOnly = true;
                        txt_IdMensaje.Properties.ReadOnly = true;
                        chk_estado.Properties.ReadOnly = true;

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

                if (txt_IdMensaje.EditValue == null)
                {
                    MessageBox.Show("El campo IdMensaje es obligatorio!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_IdMensaje.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txt_Mensaje.Text))
                {
                    MessageBox.Show("El campo Mensaje es obligatorio!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Mensaje.Focus();
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

                        if (this.Bus_Plantilla_Mensaje.GrabarBD(this.Info_Plantilla_Mensaje, ref mensaje))
                        {
                            MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                            Set_Accion_In_Control();
                        }

                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:

                        if (this.Bus_Plantilla_Mensaje.ModificarBD(this.Info_Plantilla_Mensaje, ref mensaje))
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

        private void FrmMail_Plantilla_Mensaje_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_FrmMail_Plantilla_Mensaje_FormClosing(sender, e);
        }
    }
}
