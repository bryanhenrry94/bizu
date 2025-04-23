using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

using Bizu.Application.General;
using Bizu.Domain.General;
using System.Linq;


namespace Bizu.Reports.Bancos
{
    public partial class XBAN_Rpt013_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        string MensajeError = "";

        public XBAN_Rpt013_rpt()
        {
            InitializeComponent();
            lblfecha.Text = DateTime.Now.ToString();
            lblUsuario.Text = param.IdUsuario;
        }

        private void XBAN_Rpt013_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {

                XBAN_Rpt013_Bus OBusRpt = new XBAN_Rpt013_Bus();
                List<XBAN_Rpt013_Info> lista = new List<XBAN_Rpt013_Info>();

                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                int PIdEmpresa = Convert.ToInt32(Parameters["PIdEmpresa"].Value);
                int PIdTipoCbte = Convert.ToInt32(Parameters["PIdTipoCbte"].Value);
                decimal PIdCbteCble = Convert.ToInt32(Parameters["PIdCbteCble"].Value);

                lista = OBusRpt.Get_Data_Reporte(PIdEmpresa, PIdTipoCbte, PIdCbteCble, ref MensajeError);               
         
                XBAN_Rpt013_Info Registro=  lista.FirstOrDefault();
                if (Registro!= null)
                { lblAnulado.Visible = (Registro.Estado == "I") ? true : false; }

                xrLabel8.Visible = false;
                xrLabel9.Visible = false;

                this.DataSource = lista.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XBAN_Rpt013_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt013_rpt) };   
            }
        }
    }
}