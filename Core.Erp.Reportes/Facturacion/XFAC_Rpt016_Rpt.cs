using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
using System.Reflection;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Reportes.Facturacion
{
    public partial class XFAC_Rpt016_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        in_marca_bus Bus_Marca = new in_marca_bus();
        public List<Int32> List_IdMarca = new List<Int32>();
        public List<Int32> List_IdCliente = new List<Int32>();

        public XFAC_Rpt016_Rpt()
        {
            InitializeComponent();
        }

        private void XFAC_Rpt014_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {                
                lblEmpresa.Text = param.NombreEmpresa;
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;

                XFAC_Rpt016_Bus BUS = new XFAC_Rpt016_Bus();

                List<XFAC_Rpt016_Info> ListDataRpt = new List<XFAC_Rpt016_Info>();

                DateTime FechaIni;
                DateTime FechaFin;
                int IdSucursal = 0;  
                bool bMostrarDetalle = false;

                FechaIni = Convert.ToDateTime(Parameters["FechaIni"].Value).Date;
                FechaFin = Convert.ToDateTime(Parameters["FechaFin"].Value).Date;
                IdSucursal = Convert.ToInt32(Parameters["IdSucursal"].Value);

                bMostrarDetalle = Convert.ToBoolean(Parameters["MostrarDetalle"].Value);

                ListDataRpt = BUS.Get_ListCostoProductoVendido_Detalle(param.IdEmpresa, IdSucursal, FechaIni, FechaFin, param.IdUsuario, List_IdCliente,
                    List_IdMarca);

                this.DataSource = ListDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XFAC_Rpt014_Rpt_BeforePrint", ex.Message), ex) 
                { EntityType = typeof(XFAC_Rpt016_Rpt) };
            }
        }

        private void xrTableCell26_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }        
    }
}
