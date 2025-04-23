using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bizu.Domain.General;
using Bizu.Application.General;
using Bizu.Domain.CuentasxPagar;
using Bizu.Application.CuentasxPagar;

namespace Bizu.Presentation.CuentasxPagar
{
    public partial class frmCP_OrdenGiro_Pendiente_ING_x_OC_Cons : DevExpress.XtraEditors.XtraForm
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_orden_giro_Bus OrdenGiro_B = new cp_orden_giro_Bus();
        public cp_orden_giro_Info Info_Selected = new cp_orden_giro_Info();

        public frmCP_OrdenGiro_Pendiente_ING_x_OC_Cons()
        {
            InitializeComponent();
        }

        private void frmCP_OrdenGiro_Pendiente_ING_x_OC_Cons_Load(object sender, EventArgs e)
        {
            dtp_Desde.EditValue = DateTime.Now;
            dtp_Hasta.EditValue = DateTime.Now;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            consultar_grid();
        }

        private void consultar_grid()
        {
            try
            {
                gridControlOG.DataSource = OrdenGiro_B.Get_List_orden_giro_SinIngresos(param.IdEmpresa, Convert.ToDateTime(dtp_Desde.EditValue), Convert.ToDateTime(dtp_Hasta.EditValue));
                gridControlOG.RefreshDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                Info_Selected = UltraGrid_OrdenGiro.GetFocusedRow() as cp_orden_giro_Info;

                if (Info_Selected == null)
                {
                    MessageBox.Show("Seleccione un registro!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}