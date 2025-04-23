using Bizu.Application.General;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bizu.Reports.Compras
{
    public partial class XCOMP_Rpt009_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCOMP_Rpt009_frm()
        {
            InitializeComponent();
        }

        private void ucCom_Menu_Reportes1_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

       
        private void ucCom_Menu_Reportes1_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCOMP_Rpt009_Rpt report = new XCOMP_Rpt009_Rpt
                {
                    RequestParameters = false
                };
                new ReportPrintTool(report).AutoShowParametersPanel = false;
                report.Parameters["IdEmpresa"].Value = this.param.IdEmpresa;
                report.Parameters["IdSucursal"].Value = (this.ucCom_Menu_Reportes1.bei_sucursal.EditValue == null) ? 0 : Convert.ToInt32(this.ucCom_Menu_Reportes1.bei_sucursal.EditValue);
                report.Parameters["IdProducto"].Value = (this.ucCom_Menu_Reportes1.bei_producto.EditValue == null) ? 0M : Convert.ToDecimal(this.ucCom_Menu_Reportes1.bei_producto.EditValue);
                report.Parameters["IdCentroCosto"].Value = (this.ucCom_Menu_Reportes1.bei_CentroCosto.EditValue == null) ? "" : Convert.ToString(this.ucCom_Menu_Reportes1.bei_CentroCosto.EditValue);
                report.Parameters["Fecha_Ini"].Value = (this.ucCom_Menu_Reportes1.dtp_fechaIni.EditValue == null) ? DateTime.Now.Date : Convert.ToDateTime(this.ucCom_Menu_Reportes1.dtp_fechaIni.EditValue);
                report.Parameters["Fecha_Fin"].Value = (this.ucCom_Menu_Reportes1.dtp_fechaFin.EditValue == null) ? DateTime.Now.Date : Convert.ToDateTime(this.ucCom_Menu_Reportes1.dtp_fechaFin.EditValue);
                report.Parameters["NomEmpresa"].Value = this.param.NombreEmpresa;
                report.Parameters["NomSucursal"].Value = (this.ucCom_Menu_Reportes1.bei_sucursal.EditValue == null) ? "" : Convert.ToString(this.ucCom_Menu_Reportes1.bei_sucursal.EditValue);
                this.printControl1.PrintingSystem = report.PrintingSystem;
                report.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XCOMP_Rpt008_frm_Load(object sender, EventArgs e)
        {
            try
            {
                ucCom_Menu_Reportes1.Cargar_combos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
