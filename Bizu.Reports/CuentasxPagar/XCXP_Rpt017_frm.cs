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

using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Bizu.Domain.General;

namespace Bizu.Reports.CuentasxPagar
{
    public partial class XCXP_Rpt017_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        
        public XCXP_Rpt017_frm()
        {
            InitializeComponent();
            ucCp_Menu_Reportes.event_btnRefrescar_ItemClick += ucCp_Menu_Reportes_event_btnRefrescar_ItemClick;
        }

        void ucCp_Menu_Reportes_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                decimal IdProveedorIni = 0;
                decimal IdProveedorFin = 0;
                string nom_Proveedor = "";

                if (this.ucCp_Menu_Reportes.get_cmbProveedor() == 0)
                {
                    IdProveedorIni = 1;
                    IdProveedorFin = 99999999;
                    nom_Proveedor = "TODOS";
                }
                else
                {
                    IdProveedorIni = Convert.ToInt32(ucCp_Menu_Reportes.get_cmbProveedor());
                    IdProveedorFin = IdProveedorIni;
                    nom_Proveedor = ucCp_Menu_Reportes.get_cmbNomProveedor();
                }

                if (Convert.ToBoolean(this.ucCp_Menu_Reportes.beiCheck1.EditValue))
                {
                    XCXP_Rpt017_resumen_rpt report = new XCXP_Rpt017_resumen_rpt
                    {
                        RequestParameters = false
                    };

                    ReportPrintTool pt = new ReportPrintTool(report);
                    pt.AutoShowParametersPanel = false;

                    report.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                    report.Parameters["IdProveedorIni"].Value = IdProveedorIni;
                    report.Parameters["IdProveedorFin"].Value = IdProveedorFin;
                    report.Parameters["FechaCorte"].Value = this.ucCp_Menu_Reportes.get_FchFin();
                    report.Parameters["S_Proveedor"].Value = nom_Proveedor;
                    report.Parameters["S_FechaCorte"].Value = this.ucCp_Menu_Reportes.get_FchFin();
                    report.Parameters["IdCentroCosto"].Value = Convert.ToString(this.ucCp_Menu_Reportes.beiCentroCosto.EditValue);
                    report.claseProv = this.ucCp_Menu_Reportes.Get_info_clase_proveedor() == null ? 0 : this.ucCp_Menu_Reportes.Get_info_clase_proveedor().IdClaseProveedor;
                    this.printControl1.PrintingSystem = report.PrintingSystem;
                    report.CreateDocument();
                }
                else
                {
                    XCXP_Rpt017_rpt report = new XCXP_Rpt017_rpt
                    {
                        RequestParameters = false
                    };

                    ReportPrintTool pt = new ReportPrintTool(report);
                    pt.AutoShowParametersPanel = false;

                    report.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                    report.Parameters["IdProveedorIni"].Value = IdProveedorIni;
                    report.Parameters["IdProveedorFin"].Value = IdProveedorFin;
                    report.Parameters["FechaCorte"].Value = this.ucCp_Menu_Reportes.get_FchFin();
                    report.Parameters["S_Proveedor"].Value = nom_Proveedor;
                    report.Parameters["S_FechaCorte"].Value = this.ucCp_Menu_Reportes.get_FchFin();
                    report.Parameters["IdCentroCosto"].Value = Convert.ToString(this.ucCp_Menu_Reportes.beiCentroCosto.EditValue);
                    report.claseProv = this.ucCp_Menu_Reportes.Get_info_clase_proveedor() == null ? 0 : this.ucCp_Menu_Reportes.Get_info_clase_proveedor().IdClaseProveedor;
                    this.printControl1.PrintingSystem = report.PrintingSystem;
                    report.CreateDocument();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucCp_Menu_Reportes_Load(object sender, EventArgs e)
        {

        }
    }
}