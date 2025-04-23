using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Bizu.Application.General;
using System.Collections.Generic;

namespace Bizu.Reports.Inventario
{
    public partial class XINV_Rpt037_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();        

        public XINV_Rpt037_Rpt()
        {
            InitializeComponent();
        }
       
        private void XINV_FJ_Rpt006_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                XINV_Rpt037_Bus BUS = new XINV_Rpt037_Bus();

                List<XINV_Rpt037_Info> ListDataRpt = new List<XINV_Rpt037_Info>();
                
                int IdSucursal = 0;                
                int IdBodega = 0;                                
                int IdMovi_inven_tipo = 0;
                int IdNumMovi = 0;
                decimal IdProducto = 0;
                
                IdSucursal = Convert.ToInt32(Parameters["IdSucursal"].Value);                
                IdBodega = Convert.ToInt32(Parameters["IdBodega"].Value);                
                IdMovi_inven_tipo = Convert.ToInt32(Parameters["IdMovi_inven_tipo"].Value);
                IdNumMovi = Convert.ToInt32(Parameters["IdNumMovi"].Value);
                IdProducto = Convert.ToInt32(Parameters["IdProducto"].Value);                

                ListDataRpt = BUS.Get_Data(param.IdEmpresa, IdSucursal, IdBodega, IdMovi_inven_tipo, IdNumMovi, IdProducto);

                foreach (var item in ListDataRpt)
                {
                    xrBarCode1.Text = item.pr_codigo_barra;
                    xrBarCode1.ShowText = true;
                }

                this.DataSource = ListDataRpt;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XINV_FJ_Rpt006_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt037_Rpt) };
            }
        }
    }
}
