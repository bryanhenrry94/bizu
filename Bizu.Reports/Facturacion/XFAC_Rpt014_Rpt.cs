using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Bizu.Application.General;
using System.Collections.Generic;
using System.Reflection;
using Bizu.Application.Inventario;
using Bizu.Domain.Inventario;

namespace Bizu.Reports.Facturacion
{
    public partial class XFAC_Rpt014_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        in_marca_bus Bus_Marca = new in_marca_bus();
        public List<Int32> List_IdMarca = new List<Int32>();
        public List<Int32> List_IdCliente = new List<Int32>();        

        public XFAC_Rpt014_Rpt()
        {
            InitializeComponent();
        }

        private void XFAC_Rpt014_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {                
                lblEmpresa.Text = param.NombreEmpresa;
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                
                XFAC_Rpt014_Bus BUS = new XFAC_Rpt014_Bus();

                List<XFAC_Rpt014_Info> ListDataRpt = new List<XFAC_Rpt014_Info>();

                DateTime FechaIni;
                DateTime FechaFin;
                int IdSucursal = 0;
                bool bMostrarDetalle = false;
                int IdCliente = 0;
                
                FechaIni = Convert.ToDateTime(Parameters["FechaIni"].Value).Date;
                FechaFin = Convert.ToDateTime(Parameters["FechaFin"].Value).Date;
                IdSucursal = Convert.ToInt32(Parameters["IdSucursal"].Value);
                bMostrarDetalle = Convert.ToBoolean(Parameters["MostrarDetalle"].Value);
                IdCliente = Convert.ToInt32(Parameters["IdCliente"].Value);

                //List_IdCliente.Add(IdCliente);

                ListDataRpt = BUS.Get_ListCostoProductoVendido(param.IdEmpresa, IdSucursal, FechaIni, FechaFin, param.IdUsuario, List_IdCliente, 
                    List_IdMarca, bMostrarDetalle);

                this.DataSource = ListDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XFAC_Rpt014_Rpt_BeforePrint", ex.Message), ex) 
                { EntityType = typeof(XFAC_Rpt014_Rpt) };
            }
        }

        private void xrTableCell26_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
        
        //PORCENTAJE DESCUENTO - GRUPO
        private void xrLabel15_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            double VentaBruta = 0;
            double Descuento = 0;

            VentaBruta = Convert.ToDouble(xrLabel13.Summary.GetResult());
            Descuento = Convert.ToDouble(xrLabel14.Summary.GetResult());

            e.Result = (VentaBruta == 0) ? 0 : (Descuento / VentaBruta);
            e.Handled = true;            
        }

        //PORCENTAJE COSTO PRODUCTO VENDIDO - GRUPO
        private void xrLabel18_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            double CostoProductoVendido = 0;
            double VentasNetas = 0;

            CostoProductoVendido = Convert.ToDouble(xrLabel17.Summary.GetResult());
            VentasNetas = Convert.ToDouble(xrLabel16.Summary.GetResult());

            e.Result = (VentasNetas == 0) ? 0 : (CostoProductoVendido / VentasNetas);
            e.Handled = true;    
        }

        //PORCENTAJE TOTAL UTILIDAD BRUTA - GRUPO
        private void xrLabel20_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {            
            double UtilidadBruta = 0;
            double VentasNetas = 0;

            UtilidadBruta = Convert.ToDouble(xrLabel19.Summary.GetResult());
            VentasNetas = Convert.ToDouble(xrLabel16.Summary.GetResult());

            e.Result = (VentasNetas == 0) ? 0 : UtilidadBruta / VentasNetas;
            e.Handled = true;    
        }

        //TOTAL PRECIO UNITARIO KG - GRUPO
        private void xrLabel21_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            double VentasNetas = 0;
            double PesoTotal = 0;

            VentasNetas = Convert.ToDouble(xrLabel16.Summary.GetResult());
            PesoTotal = Convert.ToDouble(xrLabel11.Summary.GetResult());

            e.Result = (PesoTotal == 0) ? 0 : VentasNetas / PesoTotal;
            e.Handled = true;    
        }

        //TOTAL COSTO UNITARIO KG - GRUPO
        private void xrLabel22_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            double CostoProductoVendido = 0;
            double PesoTotal = 0;

            CostoProductoVendido = Convert.ToDouble(xrLabel17.Summary.GetResult());
            PesoTotal = Convert.ToDouble(xrLabel11.Summary.GetResult());

            e.Result = (PesoTotal == 0) ? 0 : CostoProductoVendido / PesoTotal;
            e.Handled = true;    
        }

        //PORCENTAJE DESCUENTO - INFORME
        private void xrLabel26_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {        
            double VentaBruta = 0;
            double Descuento = 0;

            VentaBruta = Convert.ToDouble(xrLabel24.Summary.GetResult());
            Descuento = Convert.ToDouble(xrLabel25.Summary.GetResult());

            e.Result = (VentaBruta == 0) ? 0 : (Descuento / VentaBruta);
            e.Handled = true;                    
        }

        //PORCENTAJE COSTO PRODUCTO VENDIDO - INFORME
        private void xrLabel29_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {        
            double CostoProductoVendido = 0;
            double VentasNetas = 0;

            CostoProductoVendido = Convert.ToDouble(xrLabel28.Summary.GetResult());
            VentasNetas = Convert.ToDouble(xrLabel27.Summary.GetResult());

            e.Result = (VentasNetas == 0) ? 0 : (CostoProductoVendido / VentasNetas);
            e.Handled = true;            
        }

        //PORCENTAJE TOTAL UTILIDAD BRUTA - INFORME
        private void xrLabel31_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            double UtilidadBruta = 0;
            double VentasNetas = 0;

            UtilidadBruta = Convert.ToDouble(xrLabel30.Summary.GetResult());
            VentasNetas = Convert.ToDouble(xrLabel27.Summary.GetResult());

            e.Result = (VentasNetas == 0) ? 0 : UtilidadBruta / VentasNetas;
            e.Handled = true;            
        }

        //TOTAL PRECIO UNITARIO KG - INFORME
        private void xrLabel32_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {        
            double VentasNetas = 0;
            double PesoTotal = 0;

            VentasNetas = Convert.ToDouble(xrLabel27.Summary.GetResult());
            PesoTotal = Convert.ToDouble(xrLabel10.Summary.GetResult());

            e.Result = (PesoTotal == 0) ? 0 : VentasNetas / PesoTotal;
            e.Handled = true;            
        }

        //TOTAL COSTO UNITARIO KG - INFORME
        private void xrLabel33_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
            double CostoProductoVendido = 0;
            double PesoTotal = 0;

            CostoProductoVendido = Convert.ToDouble(xrLabel28.Summary.GetResult());
            PesoTotal = Convert.ToDouble(xrLabel10.Summary.GetResult());

            e.Result = (PesoTotal == 0) ? 0 : CostoProductoVendido / PesoTotal;
            e.Handled = true;            
        }
    }
}
