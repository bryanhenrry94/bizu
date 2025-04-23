using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Bizu.Application.General;
using System.Collections.Generic;

namespace Bizu.Reports.Inventario
{
    public partial class XINV_Rpt038_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public List<int?> IdLinea_List = new List<int?>();

        public XINV_Rpt038_Rpt()
        {
            InitializeComponent();
        }
       
        private void XINV_FJ_Rpt006_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                //xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                XINV_Rpt038_Bus BUS = new XINV_Rpt038_Bus();

                List<XINV_Rpt038_Info> ListDataRpt = new List<XINV_Rpt038_Info>();
                
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;                
                int IdBodegaIni = 0;
                int IdBodegaFin = 0;
                int IdProductoIni = 0;
                int IdProductoFin = 0;
                DateTime FechaIni;
                DateTime FechaFin;
                string IdCategoria = "";

                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                lblFechaImpresion.Text = param.Fecha_Transac.ToLongDateString();
                lblEmpresa.Text = param.NombreEmpresa;

                IdSucursalIni = Convert.ToInt32(Parameters["IdSucursalIni"].Value);
                IdSucursalFin = Convert.ToInt32(Parameters["IdSucursalFin"].Value);
                IdBodegaIni = Convert.ToInt32(Parameters["IdBodegaIni"].Value);
                IdBodegaFin = Convert.ToInt32(Parameters["IdBodegaFin"].Value);
                IdProductoIni = Convert.ToInt32(Parameters["IdProductoIni"].Value);
                IdProductoFin = Convert.ToInt32(Parameters["IdProductoFin"].Value);
                FechaIni = Convert.ToDateTime(Parameters["FechaIni"].Value);
                FechaFin = Convert.ToDateTime(Parameters["FechaFin"].Value);
                IdCategoria = Convert.ToString(Parameters["IdCategoria"].Value);
                
                ListDataRpt = BUS.Get_Data(param.IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, IdProductoIni, IdProductoFin, FechaIni, FechaFin, IdCategoria, IdLinea_List);
               
                this.DataSource = ListDataRpt;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XINV_FJ_Rpt006_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt038_Rpt) };
            }
        }
    }
}
