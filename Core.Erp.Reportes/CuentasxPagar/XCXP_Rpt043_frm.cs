using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using DevExpress.XtraReports.UI;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt043_frm : DevExpress.XtraEditors.XtraForm
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XCXP_Rpt043_frm()
        {
            InitializeComponent();

            ucCxp_MenuReportes.event_tnConsultar_ItemClick += UcCxp_MenuReportes_event_tnConsultar_ItemClick;
            ucCxp_MenuReportes.event_btnSalir_ItemClick += UcCxp_MenuReportes_event_btnSalir_ItemClick;
        }

        private void UcCxp_MenuReportes_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void UcCxp_MenuReportes_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if(ucCxp_MenuReportes.cmbProveedor.EditValue == null)
                {
                    MessageBox.Show("Seleccione un proveedor!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (ucCxp_MenuReportes.dtpDesde.EditValue == null)
                {
                    MessageBox.Show("Ingrese la fecha desde!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (ucCxp_MenuReportes.dtpHasta.EditValue == null)
                {
                    MessageBox.Show("Ingrese la fecha hasta!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                XCXP_Rpt043_Rpt Reporte = new XCXP_Rpt043_Rpt();
                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.pIdEmpresa.Value = param.IdEmpresa;
                Reporte.pIdProveedor.Value = Convert.ToDecimal(ucCxp_MenuReportes.cmbProveedor.EditValue);
                Reporte.pFechaIni.Value = Convert.ToDateTime(ucCxp_MenuReportes.dtpDesde.EditValue);
                Reporte.pFechaFin.Value = Convert.ToDateTime(ucCxp_MenuReportes.dtpHasta.EditValue);
                
                printControl.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XCXP_Rpt042_frm_Load(object sender, EventArgs e)
        {

        }

        private void printPreviewBarItem53_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}