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
using Bizu.Reports.Contabilidad;

namespace Bizu.Reports.Contabilidad
{
    public partial class XCONTA_Rpt023_frm : Form
    {

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCONTA_Rpt023_frm()
        {
            InitializeComponent();
        }

        private void uCct_Menu_Reportes1_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCONTA_Rpt023_Bus Bus = new XCONTA_Rpt023_Bus();
                List<XCONTA_Rpt023_Info> lista = new List<XCONTA_Rpt023_Info>();
                String msg = "";

                int PIdEmpresa = param.IdEmpresa;
                DateTime PFechaIni = Convert.ToDateTime(uCct_Menu_Reportes.bei_Desde.EditValue);
                DateTime PFechaFin = Convert.ToDateTime(uCct_Menu_Reportes.bei_Hasta.EditValue);
                bool PConsiderar_Asiento_cierre_anual = Convert.ToBoolean(uCct_Menu_Reportes.bei_Check.EditValue);
                bool PMostrar_Reg_en_cero = Convert.ToBoolean(uCct_Menu_Reportes.bei_Check2.EditValue);

                lista = Bus.consultar_data(1, PFechaIni, PFechaFin, PMostrar_Reg_en_cero, PConsiderar_Asiento_cierre_anual,param.IdUsuario, ref msg);

                this.bindingSource1.DataSource = lista;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void uCct_Menu_Reportes_Load(object sender, EventArgs e)
        {

        }

        private void uCct_Menu_Reportes_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void XCONTA_Rpt023_frm_Load(object sender, EventArgs e)
        {

        }

        private void uCct_Menu_Reportes_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pivotGridControlDocumento.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }
    }
}
