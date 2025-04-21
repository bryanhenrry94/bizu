using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Facturacion
{
    public partial class XFAC_Rpt015_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XFAC_Rpt015_Rpt()
        {
            InitializeComponent();
        }

        private void XFAC_Rpt014_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {                
                lblEmpresa.Text = param.NombreEmpresa;
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;

                XFAC_Rpt015_Bus BUS = new XFAC_Rpt015_Bus();

                List<XFAC_Rpt015_Info> ListDataRpt = new List<XFAC_Rpt015_Info>();
                
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;
                int IdBodegaIni = 0;
                int IdBodegaFin = 0;
                int IdVendedorIni = 0;
                int IdVendedorFin = 0;
                DateTime FechaIni;
                DateTime FechaFin;
                int IdClienteIni = 0;
                int IdClienteFin = 0;     
                
                FechaIni = Convert.ToDateTime(Parameters["FechaIni"].Value).Date;
                FechaFin = Convert.ToDateTime(Parameters["FechaFin"].Value).Date;
                IdSucursalIni = Convert.ToInt32(Parameters["IdSucursalIni"].Value);
                IdSucursalFin = Convert.ToInt32(Parameters["IdSucursalFin"].Value);
                IdBodegaIni = Convert.ToInt32(Parameters["IdBodegaIni"].Value);
                IdBodegaFin = Convert.ToInt32(Parameters["IdBodegaFin"].Value);
                IdClienteIni = Convert.ToInt32(Parameters["IdClienteIni"].Value);
                IdClienteFin = Convert.ToInt32(Parameters["IdClienteFin"].Value);
                IdVendedorIni = Convert.ToInt32(Parameters["IdVendedorIni"].Value);
                IdVendedorFin = Convert.ToInt32(Parameters["IdVendedorFin"].Value);

                
                ListDataRpt = BUS.Get_Data(param.IdEmpresa, IdSucursalIni,IdSucursalFin, IdBodegaIni, IdBodegaFin,IdVendedorIni,
                                            IdVendedorFin, FechaIni, FechaFin, IdClienteIni, IdClienteFin);

                this.DataSource = ListDataRpt;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XFAC_Rpt014_Rpt_BeforePrint", ex.Message), ex) 
                { EntityType = typeof(XFAC_Rpt015_Rpt) };
            }
        }

    }
}
