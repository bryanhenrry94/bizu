using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Caja
{
    public partial class XCAJ_Rpt007_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<XCAJ_Rpt007_Info> lst_rpt = new List<XCAJ_Rpt007_Info>();
        XCAJ_Rpt007_Bus bus_rpt = new XCAJ_Rpt007_Bus();

        public XCAJ_Rpt007_Rpt()
        {
            InitializeComponent();
        }

        private void XCAJ_Rpt006_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                lblFecha.Text = DateTime.Now.ToString();
                lblUsuario.Text = param.IdUsuario;
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;

                int IdCaja = Convert.ToInt32(P_IdCaja.Value);

                lst_rpt = bus_rpt.Get_list_reporte(param.IdEmpresa, IdCaja);
                this.DataSource = lst_rpt;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}