using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bizu.Application.General;
using Bizu.Domain.General;

namespace Bizu.Presentation.Facturacion
{
    public partial class frmFa_Aprobacion_Motivo_Consulta : DevExpress.XtraEditors.XtraForm
    {

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public int IdPedido = 0;
        public string Cliente = "";
        public string motivo = "";
        public string estado = "";


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public frmFa_Aprobacion_Motivo_Consulta()
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

        private void frmFa_Aprobacion_Motivo_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                txt_pedido.Text = Convert.ToString(IdPedido);
                txt_cliente.Text = Cliente;
                txt_Motivo.Text = motivo;
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
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
