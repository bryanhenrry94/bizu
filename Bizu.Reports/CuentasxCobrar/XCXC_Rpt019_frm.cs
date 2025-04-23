using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bizu.Application.General;

namespace Bizu.Reports.CuentasxCobrar
{
    public partial class XCXC_Rpt019_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        

        public XCXC_Rpt019_frm()
        {
            InitializeComponent();
            ucFa_Menu.btnGenerarReporte.Visibility = 0;
        }

        void cargarDatosGrid()
        {
            try
            {
                XCXC_Rpt019_Bus rptBus = new XCXC_Rpt019_Bus();
                List<XCXC_Rpt019_Info> Lista = new List<XCXC_Rpt019_Info>();
                DateTime fechaini = DateTime.Now;
                DateTime fechafin = DateTime.Now;

                fechaini = Convert.ToDateTime(ucFa_Menu.dtpDesde.EditValue);
                fechafin = Convert.ToDateTime(ucFa_Menu.dtpHasta.EditValue);

                
                Lista = rptBus.getDatosCobros(param.IdEmpresa, Convert.ToInt32(ucFa_Menu.cmbSucursal.EditValue), fechaini, fechafin);
                this.pivotGridControlCobros.DataSource = Lista;
                gridConsultaCot.DataSource = Lista;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucFa_Menu_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                cargarDatosGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucFa_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pivotGridControlCobros.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucFa_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void ucFa_Menu_event_btnGenerarReporte_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridConsultaCot.ShowPrintPreview();
        }

    }
}
