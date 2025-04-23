using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Bizu.Application.General;
using System.Collections.Generic;

namespace Bizu.Reports.CuentasxCobrar
{
    public partial class XCXC_Rpt009_Resumido_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public XCXC_Rpt009_Resumido_rpt()
        {
            InitializeComponent();
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
            xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
        }

        private void XCXC_Rpt009_Resumido_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCXC_Rpt009_Bus rptBus = new XCXC_Rpt009_Bus();
                List<XCXC_Rpt009_Info> lstRpt = new List<XCXC_Rpt009_Info>();

                int IdEmpresa = 0;
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;
                int IdCliente = 0;
                int IdTipoCliente = 0;
                DateTime FechaCorte = DateTime.Now;
                IdEmpresa = Convert.ToInt32(this.IdEmpresa.Value);
                IdCliente = Convert.ToInt32(this.PIdCliente.Value);
                IdSucursalIni = Convert.ToInt32(this.IdSucursalIni.Value);
                IdSucursalFin = Convert.ToInt32(this.IdSucursalFin.Value);
                FechaCorte = Convert.ToDateTime(this.FechaCorte.Value).Date;
                IdTipoCliente = Convert.ToInt32(this.PIdTipo_Cliente.Value);

                lstRpt = rptBus.get_DetalleCarteraVencida_Resumida(IdEmpresa, IdCliente, IdSucursalIni, IdSucursalFin, FechaCorte, IdTipoCliente);
                this.DataSource = lstRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XCXC_Rpt009_Resumido_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXC_Rpt009_Resumido_rpt) };
            }
        }
    }
}