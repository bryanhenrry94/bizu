using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Bizu.Application.Bancos;
using Bizu.Domain.Bancos;
using Bizu.Application.General;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;



namespace Bizu.Reports.Bancos
{
    public partial class XBAN_Rpt010_frm : Form
    {
        ba_Banco_Cuenta_Bus BusCuenta = new ba_Banco_Cuenta_Bus();
        List<ba_Banco_Cuenta_Info> ListaBanco = new List<ba_Banco_Cuenta_Info>();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public XBAN_Rpt010_frm()
        {
            InitializeComponent();
        }

        private void btn_procesar_rpt_Click(object sender, EventArgs e)
        {
            try
            {
                int idBanco = 0;

                idBanco = Convert.ToInt32(cmb_banco.EditValue);

                XBAN_Rpt010_rpt Reporte = new XBAN_Rpt010_rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["P_IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["P_IdBanco"].Value = idBanco;
                Reporte.Parameters["P_Fecha_desde"].Value = dtpFecha_desde.Value;
                Reporte.Parameters["P_Fecha_hasta"].Value = dtpFecha_hasta.Value;

                printControl1.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void XBAN_Rpt010_frm_Load(object sender, EventArgs e)
        {
            try
            {
                
                ListaBanco= BusCuenta.Get_list_Banco_Cuenta(param.IdEmpresa);

                ListaBanco.Add(new ba_Banco_Cuenta_Info(param.IdEmpresa, 0, "TODOS","TODOS"));

                cmb_banco.Properties.DataSource = ListaBanco;
                cmb_banco.EditValue = 1;

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


        private void btn_Imprimir_rpt_Click(object sender, EventArgs e)
        {

            XBAN_Rpt010_Bus BusRpt = new XBAN_Rpt010_Bus();
            string MensajeError = "";
            int IdEmpresa = 0;
            int IdBanco = 0;

            IdBanco = Convert.ToInt32(cmb_banco.EditValue);
            IdEmpresa = param.IdEmpresa;
            DateTime FechaIni = DateTime.Now;
            DateTime FechaFin = DateTime.Now;

            FechaIni = Convert.ToDateTime(dtpFecha_desde.Value);
            FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());

            FechaFin = Convert.ToDateTime(dtpFecha_hasta.Value);
            FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

            List<XBAN_Rpt010_Info> lista = new List<XBAN_Rpt010_Info>();

            if (IdBanco == 0)//todos los bancos 
            {
                ba_Banco_Cuenta_Bus BusBancos = new ba_Banco_Cuenta_Bus();

                foreach (var item in BusBancos.Get_list_Banco_Cuenta(IdEmpresa))
                {
                    List<XBAN_Rpt010_Info> lista_x_cuenta = new List<XBAN_Rpt010_Info>();

                    lista_x_cuenta = BusRpt.Get_Data_Reporte(item.IdEmpresa, item.IdBanco, FechaIni, FechaFin, ref MensajeError);

                    foreach (var item_reg_x_banco in lista_x_cuenta)
                    {
                        lista.Add(item_reg_x_banco);
                    }

                }
            }
            else
            {
                lista = BusRpt.Get_Data_Reporte(IdEmpresa, IdBanco, FechaIni, FechaFin, ref MensajeError);
            }

            gridControlCatalogo.DataSource = lista;
            gridControlCatalogo.ShowPrintPreview();
        }

      
    }
}
