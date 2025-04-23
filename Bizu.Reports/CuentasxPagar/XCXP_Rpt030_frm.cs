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
using DevExpress.XtraReports.UI;
using Bizu.Domain.General;
using Bizu.Application.CuentasxPagar;
using Bizu.Domain.CuentasxPagar;

namespace Bizu.Reports.CuentasxPagar
{
    public partial class XCXP_Rpt030_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<cp_codigo_SRI_Info> list_OrdenTipPago = new List<cp_codigo_SRI_Info>();
        cp_codigo_SRI_Bus Bus_OrdenTipPago = new cp_codigo_SRI_Bus();

        public XCXP_Rpt030_frm()
        {
            InitializeComponent();

            list_OrdenTipPago = Bus_OrdenTipPago.Get_List_codigo_SRI("COD_IDCREDITO");
            foreach (var item in list_OrdenTipPago)
            {
                if (item.co_estado == "A")
                {
                    item.co_estado = "ACTIVO";
                }
                else
                {
                    item.co_estado = "INACTIVO";
                }
            }
            cmbTipImp.Properties.DataSource = list_OrdenTipPago;
        }

        private void btnGenerarRpt_Click(object sender, EventArgs e)
        {

            try
            {
                
                 XCXP_Rpt030_Rpt Reporte = new XCXP_Rpt030_Rpt();

                 Reporte.RequestParameters = false;
                 ReportPrintTool pt = new ReportPrintTool(Reporte);
                 pt.AutoShowParametersPanel = false;

                 Reporte.PIdEmpresa.Value = param.IdEmpresa;
                 Reporte.p_FechaIni.Value = Convert.ToDateTime(dtpDesde.Value).ToShortDateString();
                 Reporte.p_FechaFin.Value = Convert.ToDateTime(dtpHasta.Value).ToShortDateString();
                 Reporte.P_X_Fecha_Emision.Value = rb_x_fecha_emision.Checked;
                             
                 int Codigo;

                 if (cmbTipImp.EditValue == null)
                 {
                     Codigo = 0;
                 }
                 else 
                 {
                     Codigo = Convert.ToInt32(cmbTipImp.EditValue);
                 }
                 Reporte.codigo = Codigo;
              
                 printControl.PrintingSystem = Reporte.PrintingSystem;
                 Reporte.CreateDocument();

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void printPreviewBarItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            string msg = "";
            XCXP_Rpt030_Bus Bus = new XCXP_Rpt030_Bus();
            List<XCXP_Rpt030_Info> lista = new List<XCXP_Rpt030_Info>();

            int IdEmpresa = 0;

            DateTime FechaIni;
            DateTime FechaFin;
            bool x_Fecha_Emision = true;

            IdEmpresa = param.IdEmpresa;
            FechaFin = Convert.ToDateTime(dtpHasta.Value).Date;
            FechaIni = Convert.ToDateTime(dtpDesde.Value).Date;
            x_Fecha_Emision = Convert.ToBoolean(rb_x_fecha_emision.Checked);

            lista = Bus.Get_List_Data(IdEmpresa, FechaIni, FechaFin, x_Fecha_Emision, ref msg);

            gridControlGuia.DataSource = lista.ToArray();
            gridControlGuia.ShowPrintPreview();
        }
    }
}
