using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Bizu.Application.General;
using System.Collections.Generic;

namespace Bizu.Reports.Inventario
{
    public partial class XINV_Rpt032_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public int idMarca = 0;

        public XINV_Rpt032_Rpt()
        {
            InitializeComponent();
        }
       

        private void XINV_FJ_Rpt006_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;

                xrLUsuario.Text = param.IdUsuario;
                lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");

                XINV_Rpt032_Bus BUS = new XINV_Rpt032_Bus();

                List<XINV_Rpt032_Info> ListDataRpt = new List<XINV_Rpt032_Info>();

                DateTime FechaIni;
                DateTime FechaFin;
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;
                int IdBodegaIni = 0;
                int IdBodegaFin = 0;
                decimal IdProductoIni = 0;
                decimal IdProductoFin = 0;
                string IdCentroCosto = string.Empty;
                string IdSubCentroCosto = string.Empty;
                int IdMovi_inven_tipoIni = 0;
                int IdMovi_inven_tipoFin = 0;
                string TipoMov = string.Empty;
                string IdCategoria = "";
                Int32 IdLinea = 0;
                //string nomtipomov = string.Empty;

                FechaIni = Convert.ToDateTime(Parameters["FechaIni"].Value).Date;
                FechaFin = Convert.ToDateTime(Parameters["FechaFin"].Value).Date;
                IdSucursalIni = Convert.ToInt32(Parameters["IdSucursalIni"].Value);
                IdSucursalFin = Convert.ToInt32(Parameters["IdSucursalFin"].Value);
                IdBodegaIni = Convert.ToInt32(Parameters["IdBodegaIni"].Value);
                IdBodegaFin = Convert.ToInt32(Parameters["IdBodegaFin"].Value);
                IdProductoIni = Convert.ToDecimal(Parameters["IdProductoIni"].Value);
                IdProductoFin = Convert.ToDecimal(Parameters["IdProductoFin"].Value);
                
                IdLinea = Convert.ToInt32(Parameters["IdLinea"].Value);

                ListDataRpt = BUS.Get_list(param.IdEmpresa, IdSucursalIni, IdBodegaIni, IdProductoIni, idMarca, FechaIni, FechaFin);

                this.DataSource = ListDataRpt;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XINV_Rpt031_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt032_Rpt) };
            }
        }

    }
}
