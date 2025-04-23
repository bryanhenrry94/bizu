using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bizu.Application.General;
using Bizu.Presentation.Inventario;
using Bizu.Domain.General;
using Bizu.Domain.Inventario;
using Bizu.Application.Inventario;

namespace Bizu.Presentation.Controles
{
    public partial class UCIn_Motivo_GuiaRemision_cmb : UserControl
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;   
        in_GuiaRemision_Motivo_Bus Bus_Motivo = new in_GuiaRemision_Motivo_Bus();
        in_GuiaRemision_Motivo_Info Info = new in_GuiaRemision_Motivo_Info();
        List<in_GuiaRemision_Motivo_Info> List_Info = new List<in_GuiaRemision_Motivo_Info>();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        frmIn_motivo_guia_remision_Mant frm = new frmIn_motivo_guia_remision_Mant();

        public UCIn_Motivo_GuiaRemision_cmb()
        {
            InitializeComponent();
        }

        private void cmb_Acciones_Click(object sender, EventArgs e)
        {
            try
            {
                MenuAcciones.Show(cmb_Acciones, new Point(0, cmb_Acciones.Height));
            }
            catch (Exception ex)
            {

            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                llamar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {

            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Get_Info();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {

            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Get_Info();
                llamar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Get_Info()
        {
            try
            {
                Info = List_Info.FirstOrDefault(v => v.IdMotivo == Convert.ToDecimal(cmb_motivo.EditValue));                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());                
            }
        }

        private void llamar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new frmIn_motivo_guia_remision_Mant();

                frm.event_frmIn_motivo_guia_remision_Mant_FormClosing +=frm_event_frmIn_motivo_guia_remision_Mant_FormClosing;
                
                // sino es grabar puede ser modificar ,consultar,
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (Info != null)
                    {
                        frm.Set_Info(Info);
                        frm.Set_Accion(Accion);
                        frm.Show();
                    }
                    else
                        MessageBox.Show("Escoja un motivo para continuar", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frm.Set_Accion(Accion);
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        void frm_event_frmIn_motivo_guia_remision_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            cargar_combo();
        }

        private void UCIn_Motivo_GuiaRemision_cmb_Load(object sender, EventArgs e)
        {
            cargar_combo();
        }

        private void cargar_combo()
        {
            try
            {
                List_Info = Bus_Motivo.Get_List_motivo(param.IdEmpresa);
                cmb_motivo.Properties.DataSource = List_Info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}
