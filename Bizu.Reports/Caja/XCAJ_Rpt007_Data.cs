using Bizu.Infrastructure.General;
using Bizu.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.Caja
{
    public class XCAJ_Rpt007_Data
    {
        public List<XCAJ_Rpt007_Info> Get_list_reporte(int IdEmpresa, int IdCaja)
        {
            try
            {
                List<XCAJ_Rpt007_Info> Lista = new List<XCAJ_Rpt007_Info>();
               
                using (EntitiesCaja_General Context = new EntitiesCaja_General())
                {
                    var lst = from q in Context.vwCAJ_Rpt007
                              where q.IdEmpresa == IdEmpresa
                              && q.IdCaja == IdCaja
                              select q;

                    foreach (var item in lst)
                    {
                        XCAJ_Rpt007_Info info = new XCAJ_Rpt007_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdCaja = item.IdCaja;
                        info.IdCustodio = item.IdCustodio;
                        info.NombreCustodio = item.NombreCustodio;
                        info.PeriodoDesde = item.PeriodoDesde;
                        info.PeriodoHasta = item.PeriodoHasta;
                        info.FondoAsignado = item.FondoAsignado;
                        info.TotalCompra = item.TotalCompra;
                        info.SaldoCompra = item.SaldoCompra;
                        info.TotalAprobado = item.TotalAprobado;
                        info.Total_a_Pagar = item.Total_a_Pagar;
                        info.Saldo_a_Pagar = item.Saldo_a_Pagar;
                        info.EstadoAprob = item.EstadoAprob;
                        info.Observacion = item.Observacion;
                        info.IdUsuarioCreacion = item.IdUsuarioCreacion;
                        info.FechaCreacion = item.FechaCreacion;
                        info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        info.FechaUltMod = item.FechaUltMod;
                        info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                        info.FechaUltAnu = item.FechaUltAnu;
                        info.MotivoAnulacion = item.MotivoAnulacion;
                        info.IdUsuarioRevision = item.IdUsuarioRevision;
                        info.FechaUltRevision = item.FechaUltRevision;
                        info.IdEmpresa_ct = item.IdEmpresa_ct;
                        info.IdTipoCbte_ct = item.IdTipoCbte_ct;
                        info.IdCbteCble_ct = item.IdCbteCble_ct;
                        info.IdEmpresa_Ogiro = item.IdEmpresa_Ogiro;
                        info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                        info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                        info.Estado = item.Estado;
                        info.IdSecuencia = item.IdSecuencia;
                        info.Fecha = item.Fecha;
                        info.IdRubro = item.IdRubro;
                        info.CodigoRubro = item.CodigoRubro;
                        info.NombreRubro = item.NombreRubro;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdTipoDocumento = item.IdTipoDocumento;
                        info.NumeroDocumento = item.NumeroDocumento;
                        info.Subtotal = item.Subtotal;
                        info.IdCod_Impuesto = item.IdCod_Impuesto;
                        info.Iva = item.Iva;
                        info.Total = item.Total;
                        info.Aprobado = item.Aprobado;
                        info.Check = item.Check;
                        info.IdCtaCble = item.IdCtaCble;

                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XCAJ_Rpt005_Data) };
            }
        }
    }
}