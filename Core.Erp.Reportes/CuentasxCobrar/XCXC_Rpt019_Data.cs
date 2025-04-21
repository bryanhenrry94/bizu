using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt019_Data
    {
        string mensaje = "";
        public List<XCXC_Rpt019_Info> getDatosCobros(int IdEmpresa, int IdSucursal, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                List<XCXC_Rpt019_Info> lstReport = new List<XCXC_Rpt019_Info>();
                fechaIni = Convert.ToDateTime(fechaIni.ToShortDateString());
                fechaFin = Convert.ToDateTime(fechaFin.ToShortDateString());

                int IdSucursalIni = (IdSucursal == 0) ? 0 : IdSucursal;
                int IdSucursalFin = (IdSucursal == 0) ? 9999999 : IdSucursal;


                using (Entities_CuentasxCobrar ListadoCobro = new Entities_CuentasxCobrar())
                {
                    var select = from q in ListadoCobro.vwCXC_Rpt019
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                 && q.vt_fecha >= fechaIni && q.vt_fecha <= fechaFin
                                 && q.Estado == "A"
                                 select q;

                    foreach (var item in select)
                    {

                        XCXC_Rpt019_Info itemInfo = new XCXC_Rpt019_Info();

                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdCbteVta = item.IdCbteVta;
                        itemInfo.IdSucursal = IdSucursal;
                        itemInfo.CodCbteVta = item.CodCbteVta;
                        itemInfo.vt_tipoDoc = item.vt_tipoDoc;
                        itemInfo.IdCliente = item.IdCliente;
                        itemInfo.vt_serie1 = item.vt_serie1;
                        itemInfo.vt_serie2 = item.vt_serie2;
                        itemInfo.vt_NumFactura = item.vt_NumFactura;
                        itemInfo.IdCliente = item.IdCliente;
                        itemInfo.IdVendedor = item.IdVendedor;
                        itemInfo.vt_plazo = Convert.ToDecimal(item.vt_plazo);
                        itemInfo.vt_fecha = item.vt_fecha;
                        itemInfo.vt_fech_venc = item.vt_fech_venc;
                        itemInfo.fechaCobro = item.fechaCobro;
                        itemInfo.vt_tipo_venta = item.vt_tipo_venta;
                        itemInfo.vt_Observacion = item.vt_Observacion;
                        itemInfo.IdPeriodo = item.IdPeriodo;
                        itemInfo.vt_anio = item.vt_anio;
                        itemInfo.vt_mes = item.vt_mes;
                        itemInfo.Fecha_Transaccion = item.Fecha_Transaccion;

                        itemInfo.Estado = item.Estado;
                        itemInfo.Su_Descripcion = item.Su_Descripcion;
                        itemInfo.bo_Descripcion = item.bo_Descripcion;
                        itemInfo.Ve_Vendedor = item.Ve_Vendedor;
                        itemInfo.pe_nombreCompleto = item.pe_nombreCompleto;
                        itemInfo.vt_Subtotal = Math.Round(Convert.ToDouble(item.vt_Subtotal),2);
                        itemInfo.vt_iva = Math.Round(Convert.ToDouble(item.vt_iva), 2);
                        itemInfo.vt_total = Math.Round(Convert.ToDouble(item.vt_total), 2);
                        itemInfo.CobroTotal = item.CobroTotal;

                        itemInfo.diasCobro = item.diasCobro;
                        itemInfo.ciudadNom = item.ciudadNom;
                        itemInfo.provinciaNom = item.provinciaNom;
                        itemInfo.Saldo = Math.Round(Convert.ToDouble(item.Saldo), 2);

                        lstReport.Add(itemInfo);

                    }
                }
                return lstReport;


            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                return new List<XCXC_Rpt019_Info>();
            }
        }
    }
}
