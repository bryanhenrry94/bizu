using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Winform.Controles
{
    public partial class UCIn_GuiaRemision_Recepcion : UserControl
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public UCIn_GuiaRemision_Recepcion()
        {
            InitializeComponent();
        }

        private void chk_NDEV_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                mostrar_campo_numero();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mostrar_campo_numero()
        {
            try
            {
                if (chk_NEDV.Checked)
                {
                    txt_numero_nedv.Visible = true;
                    txt_numGuia.Enabled = false;
                }
                else
                {
                    txt_numero_nedv.Visible = false;
                    txt_numGuia.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCIn_GuiaRemision_Recepcion_Load(object sender, EventArgs e)
        {
            try
            {
                mostrar_campo_numero();
            }  
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public Boolean validar_Guia()
        {
            try
            {
                if (!chk_NEDV.Checked)
                {
                    if (txt_numGuia.Text == "" || txt_numGuia.EditValue == null)
                    {
                        MessageBox.Show("Ingrese el número de la Guía de Remisión!!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void txt_numGuia_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_numGuia.EditValue == null) return;

                if (!chk_NEDV.Checked)
                {
                    in_Ing_Egr_Inven_Bus Bus_Inventario = new in_Ing_Egr_Inven_Bus();
                    string mensaje = "";

                    if (Bus_Inventario.Existe_NumGuia(param.IdEmpresa, Convert.ToString(txt_numGuia.EditValue), ref mensaje))
                    {
                        MessageBox.Show("El número de guía " + txt_numGuia.EditValue + " ya se encuentra registrado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}