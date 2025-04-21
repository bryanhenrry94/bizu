using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.General
{
    public partial class FrmGe_MotivoAnulacion : DevExpress.XtraEditors.XtraForm
    {

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public FrmGe_MotivoAnulacion()
        {
            try
            {
                 InitializeComponent();
                 this.Text ="Motivo de Anulacion ..."+ param.Nombre_sistema ;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        public string motivoAnulacion { get; set; }
        public string cerrado { get; set; }
        public DateTime fechaAnul { get; set; }

        private void Ge_MotivoAnulacion_Load(object sender, EventArgs e)
        {
            try
            {
               btn_anular.Enabled = false;
               ControlBox = false;

               lblFechaAnulacion.Text = DateTime.Now.ToShortDateString();
               lblPc.Text = param.nom_pc;
               lblUsuarioAnulacion.Text = param.IdUsuario;
               lblIp.Text = param.ip;

               cerrado = "S";

               lblFechaAnu.Visible = true;
               dteFechaAnulacion.Visible = true;
               dteFechaAnulacion.Text = DateTime.Now.ToShortDateString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_anular_Click(object sender, EventArgs e)
        {
            try
            {
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.EDEHSA:
                        if (dteFechaAnulacion.Text == "")
                        {
                            MessageBox.Show("Ingrese una fecha de anulación", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            motivoAnulacion = txt_motivoAnulacion.Text;
                            fechaAnul = Convert.ToDateTime(lblFechaAnulacion.Text);
                            fechaAnul = fechaAnul.AddHours(DateTime.Now.Hour);
                            fechaAnul = fechaAnul.AddMinutes(DateTime.Now.Minute);
                            fechaAnul = fechaAnul.AddSeconds(DateTime.Now.Second);
                            this.Close();
                            cerrado = "N";
                        }
                        break;

                    default:
                            motivoAnulacion = txt_motivoAnulacion.Text;
                            this.Close();
                            cerrado = "N";
                        break;
                }           
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void Ge_MotivoAnulacion_Leave(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cerrado = "S";
                  Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void txt_motivoAnulacion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_motivoAnulacion.Text == "")
                    btn_anular.Enabled = false;
                else 
                    btn_anular.Enabled = true;
             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void dteFechaAnulacion_EditValueChanged(object sender, EventArgs e)
        {
            if (dteFechaAnulacion.Text == "")
            {
                MessageBox.Show("Ingrese una fecha de anulación","Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                lblFechaAnulacion.Text = dteFechaAnulacion.Text;
            }
            
        }    
    }
}
