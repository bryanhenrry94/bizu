using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bizu.Application.General;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Bizu.Domain.CuentasxCobrar;

namespace Bizu.Reports.CuentasxCobrar
{
    public partial class XCXC_Rpt021_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<string> List_TipoCobro = new List<string>();

        public XCXC_Rpt021_frm()
        {
            InitializeComponent();
            uccxC_Menu.event_btnConsultar_ItemClick += uccxC_Menu_event_btnConsultar_ItemClick;
            uccxC_Menu.event_btnSalir_ItemClick += uccxC_Menu_event_btnSalir_ItemClick;
            uccxC_Menu.chkTipoCobro.EditValueChanged += chkTipoCobro_EditValueChanged;
        }

        void chkTipoCobro_EditValueChanged(object sender, EventArgs e)
        {
            //Lista_Tipo_Cobro= new List<cxc_cobro_tipo_Info>(uccxC_Menu.chkTipoCobro.GetCheckedItems(
        }

        void uccxC_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        void uccxC_Menu_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ConsultarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ConsultarDatos()
        {
            try
            {
                XCXC_Rpt021_rpt reporte = new XCXC_Rpt021_rpt();

                reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(reporte);

                pt.AutoShowParametersPanel = false;

                reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                reporte.Parameters["IdSucursal"].Value = (uccxC_Menu.beiSucursal.EditValue == null) ? param.IdSucursal : uccxC_Menu.beiSucursal.EditValue;
                reporte.Parameters["IdCliente"].Value = (uccxC_Menu.beiCliente.EditValue == null) ? 0 : uccxC_Menu.beiCliente.EditValue;
                reporte.Parameters["nomSucursal"].Value = uccxC_Menu.beiSucursal.Edit.GetDisplayText(uccxC_Menu.beiSucursal.EditValue);
                reporte.Parameters["Mostrar_Con_Saldo"].Value = uccxC_Menu.barEditItemChk.EditValue;
                
                printControlReporte.PrintingSystem = reporte.PrintingSystem;
                reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printControlReporte_Load(object sender, EventArgs e)
        {

        }

        private void XCXC_Rpt021_frm_Load(object sender, EventArgs e)
        {
            uccxC_Menu.beiSucursal.EditValue = param.IdSucursal;
        }
    }
}