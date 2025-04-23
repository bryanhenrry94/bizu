using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Bizu.Application.General;

namespace Bizu.Reports.CuentasxPagar
{
    public partial class XCXP_Rpt016_frm : Form
    {
        #region Declaración de Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        #endregion

        public XCXP_Rpt016_frm()
        {
            InitializeComponent();
        }

        void cargar_datos_grid_pivot()
        {
            try
            {
                XCXP_Rpt016_Bus obus = new XCXP_Rpt016_Bus();
                DateTime fechaini = DateTime.Now;
                DateTime fechafin = DateTime.Now;

                fechaini = Convert.ToDateTime(ucGe_Menu.dtp_fechaIni.EditValue);
                fechafin = Convert.ToDateTime(ucGe_Menu.dtp_fechaFin.EditValue);

                decimal IdProveedorIni = ucGe_Menu.bei_proveedor.EditValue == null ? 0 : Convert.ToDecimal(ucGe_Menu.bei_proveedor.EditValue);
                decimal IdProveedorFin = ucGe_Menu.bei_proveedor.EditValue == null ? 9999 : Convert.ToDecimal(ucGe_Menu.bei_proveedor.EditValue);

                string IdCentroCosto = Convert.ToString(ucGe_Menu.bei_CentroCosto.EditValue);

                this.PVGrid_Factura_x_Pagar.DataSource = obus.Cargar_data(param.IdEmpresa, IdProveedorIni, IdProveedorFin, fechaini, fechafin);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                this.PVGrid_Factura_x_Pagar.ShowRibbonPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucGe_Menu_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                cargar_datos_grid_pivot();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucGe_Menu_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Imprimir_Grafico_Click(object sender, EventArgs e)
        {
        }

        private void XCXP_Rpt016_frm_Load(object sender, EventArgs e)
        {

        }
    }
}