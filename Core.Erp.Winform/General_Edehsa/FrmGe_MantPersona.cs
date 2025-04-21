using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.General;
using Core.Erp.Business.General;


namespace Core.Erp.Winform.General_Edehsa
{
    public partial class frmGe_MantPersona : DevExpress.XtraEditors.XtraForm
    {
        #region Declaración de Variables
        public delegate void delegate_frmGe_MantPersona_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmGe_MantPersona_FormClosing event_frmGe_MantPersona_FormClosing;
        private Cl_Enumeradores.eTipo_action _Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_persona_Info _PersonaInfo = new tb_persona_Info();
        tb_persona_bus _PersonaBus = new tb_persona_bus();
        string motiAnulacion = "";
        string MensajeError = "";
        #endregion

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            _Accion = iAccion;
            switch (_Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    ucGe_Menu.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Never;
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                    ucGe_Menu.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Never;
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                    ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Never;
                    ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Never;
                    ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
                    ucGe_Menu.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Never;
                    break;
                default:
                    break;
            }
        }

        public void set_Persona(tb_persona_Info _persona_info)
        {
            try
            {
                lb_Anulado.Visible = (_persona_info.pe_estado == "I") ? true : false;
                _PersonaInfo = _persona_info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public frmGe_MantPersona()
        {
            try
            {
                InitializeComponent();

                this.ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                this.ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                this.ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                this.ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                this.ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
                this.Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        private void FrmGe_MantPersona_Load(object sender, EventArgs e)
        {

            try
            {
                this.event_frmGe_MantPersona_FormClosing += new delegate_frmGe_MantPersona_FormClosing(frmGe_MantPersona_event_frmGe_MantPersona_FormClosing);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmGe_MantPersona_event_frmGe_MantPersona_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        void Guardar()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGe_MantPersona_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmGe_MantPersona_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucGe_Mant_Persona_Load(object sender, EventArgs e)
        {

        }

        void LimpiarDatos()
        {
        }
    }
}