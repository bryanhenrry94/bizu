using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Bizu.Application.General;
using Bizu.Domain.General;
using System.Collections.Generic;

namespace Bizu.Reports.CuentasxPagar
{
    public partial class XCXP_Rpt021_Rpt_A5 : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        XCXP_Rpt021_Bus busReporte = new XCXP_Rpt021_Bus();
        List<XCXP_Rpt021_Info> ListaRepor = new List<XCXP_Rpt021_Info>();
        
        List<XCXP_Rpt021_Info> ListaRepor2 = new List<XCXP_Rpt021_Info>();

        public XCXP_Rpt021_Rpt_A5()
        {
            InitializeComponent();
        }


        public void set_parametros(int IdEmpresa, decimal IdCbteCble_OG,int IdTipoCbte_OG)
        {
            try
            {
                this.PIdCbteCble_OG.Value = IdCbteCble_OG;
                this.PIdCbteCble_OG.Visible = false;

                this.PIdEmpresa.Value = IdEmpresa;
                this.PIdEmpresa.Visible = false;

                this.PIdTipoCbte_OG.Value = IdTipoCbte_OG;
                this.PIdTipoCbte_OG.Visible = false;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCXP_Rpt003_Rpt) };
            }
        }

        private void XCXP_Rpt021_Rpt_A5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                
                decimal ordenGiro = 0;
                decimal idproveedor = 0;

                double Iva = 0;

                ListaRepor =  busReporte.Get_Lista_Orden_Giro(Convert.ToInt32(this.PIdEmpresa.Value),
                    Convert.ToDecimal(this.PIdCbteCble_OG.Value), Convert.ToInt32(this.PIdTipoCbte_OG.Value));

                foreach (var item in ListaRepor)
                {
                    if (item.dc_Valor > 0 && item.pc_Cuenta != "IVA Cargado al Gasto" && item.pc_Cuenta != "IVA - Compras")
                    {
                        XCXP_Rpt021_Info InfoRepor = new XCXP_Rpt021_Info();

                        InfoRepor.Codigo = item.Codigo;
                        InfoRepor.Descripcion = item.Descripcion;
                        InfoRepor.IdEmpresa = item.IdEmpresa;
                        InfoRepor.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        InfoRepor.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        InfoRepor.codigoSRI = item.codigoSRI;
                        InfoRepor.co_descripcion = item.co_descripcion;
                        InfoRepor.em_nombre = item.em_nombre;
                        InfoRepor.Su_Descripcion = item.Su_Descripcion;
                        InfoRepor.pr_nombre = item.pr_nombre;
                        InfoRepor.nom_CentroCosto = item.nom_CentroCosto;
                        InfoRepor.IdIden_credito = item.IdIden_credito;
                        InfoRepor.IdProveedor = item.IdProveedor;
                        InfoRepor.nom_CentroCosto_sub_centro_costo = item.nom_CentroCosto_sub_centro_costo;
                        InfoRepor.co_fechaOg = item.co_fechaOg;
                        InfoRepor.co_serie = item.co_serie;
                        InfoRepor.co_factura = item.co_factura;
                        InfoRepor.co_FechaFactura = item.co_FechaFactura;
                        InfoRepor.co_FechaFactura_vct = item.co_FechaFactura_vct;
                        InfoRepor.co_observacion = item.co_observacion;
                        InfoRepor.co_subtotal_iva = item.co_subtotal_iva;
                        InfoRepor.co_subtotal_siniva = item.co_subtotal_siniva;
                        InfoRepor.co_baseImponible = item.co_baseImponible;
                        InfoRepor.co_total = item.co_total;
                        InfoRepor.co_valorpagar = item.co_valorpagar;
                        InfoRepor.secuencia = item.secuencia;
                        InfoRepor.IdCtaCble = item.IdCtaCble;
                        InfoRepor.pc_Cuenta = item.pc_Cuenta;
                        InfoRepor.idCentroCosto = item.idCentroCosto;
                        InfoRepor.idCentroCosto_sub_centro_costo = item.idCentroCosto_sub_centro_costo;
                        InfoRepor.dc_Valor = item.dc_Valor;
                        InfoRepor.dc_Observacion = item.dc_Observacion;
                        InfoRepor.IdPunto_cargo = item.IdPunto_cargo;
                        InfoRepor.nom_punto_cargo = item.nom_punto_cargo;
                        InfoRepor.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        InfoRepor.nom_punto_cargo_grupo = item.nom_punto_cargo_grupo;
                        InfoRepor.pe_cedulaRuc = item.pe_cedulaRuc;
                        InfoRepor.pe_direccion = item.pe_direccion;
                        InfoRepor.pe_telfono_Contacto = item.pe_telfono_Contacto;
                        InfoRepor.dc_Valor_D = item.dc_Valor_D;
                        InfoRepor.dc_Valor_H = item.dc_Valor_H;
                        InfoRepor.pr_nombre = item.pr_nombre;
                        InfoRepor.Descripcion = item.Descripcion;
                        InfoRepor.co_descripcion = item.co_descripcion;

                        foreach (var item2 in ListaRepor)
                        {
                            if (item2.pc_Cuenta == "IVA Cargado al Gasto" || item2.pc_Cuenta == "IVA - Compras")
                            {
                                InfoRepor.dc_Iva_Total = item2.dc_Valor;
                            }
                        }

                        ListaRepor2.Add(InfoRepor);
                    }
                }
                
                this.DataSource = ListaRepor2;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "XCXP_Rpt021_Rpt_A5_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt021_Rpt_A5) };
            }
        }

        private void xrSubreportNotaCredito_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                ((XRSubreport)sender).ReportSource.Parameters["idCbte_cxp"].Value = Convert.ToDecimal(this.PIdCbteCble_OG.Value);
                ((XRSubreport)sender).ReportSource.Parameters["idEmpresa"].Value = param.IdEmpresa;
                ((XRSubreport)sender).ReportSource.Parameters["idTipoCbte_cxp"].Value = Convert.ToInt32(this.PIdTipoCbte_OG.Value);
                ((XRSubreport)sender).ReportSource.RequestParameters = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "xrSubreportNotaCredito_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt021_Rpt_A5) };
            }
        }

        private void xrSubreportRetenciones_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                ((XRSubreport)sender).ReportSource.Parameters["idOrdenGiro"].Value = Convert.ToDecimal(this.PIdCbteCble_OG.Value);
                ((XRSubreport)sender).ReportSource.Parameters["p_IdTipoCbte"].Value = Convert.ToInt32(this.PIdTipoCbte_OG.Value);
                ((XRSubreport)sender).ReportSource.RequestParameters = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "xrSubreportRetenciones_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_Rpt021_Rpt_A5) };
            }
        }

    }
}
