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

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Aprobacion_Motivo : DevExpress.XtraEditors.XtraForm
    {

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public int IdPedido = 0;
        public string Cliente = "";
        public string estado = "";


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public frmFa_Aprobacion_Motivo()
        {
            try
            {
                 InitializeComponent();
                 this.Text ="Motivo de Liberación de Pedido ..."+ param.Nombre_sistema ;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        public string motivoAnulacion { get; set; }


        private void btn_anular_Click(object sender, EventArgs e)
        {
            try
            {                
                 motivoAnulacion = txt_Motivo.Text;
                 this.Close();       
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
                  Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void frmFa_Aprobacion_Motivo_Load(object sender, EventArgs e)
        {
            try
            {
                txt_pedido.Text = Convert.ToString(IdPedido);
                txt_cliente.Text = Cliente;
                txt_estado.Text = estado;
                btn_anular.Enabled = false;
                ControlBox = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Motivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_Motivo.Text == "")
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
        
    }
}
