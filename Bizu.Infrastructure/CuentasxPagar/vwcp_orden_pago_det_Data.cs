using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;
using Bizu.Domain.CuentasxPagar;

namespace Bizu.Infrastructure.CuentasxPagar
{
    public class vwcp_orden_pago_det_Data
    {
        public List<vwcp_orden_pago_det_Info> Get_List_OrdenPagoDetalle(int IdEmpresa_Ogiro, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro, ref string mensaje)
        {
            try
            {
                List<vwcp_orden_pago_det_Info> lista = new List<vwcp_orden_pago_det_Info>();

                using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                {
                    var consulta = from T in Context.vwcp_orden_pago_det
                                   where T.IdEmpresa_cxp == IdEmpresa_Ogiro
                                   && T.IdCbteCble_cxp == IdCbteCble_Ogiro
                                   && T.IdTipoCbte_cxp == IdTipoCbte_Ogiro

                                   select T;
                    foreach (var item in consulta)
                    {

                        vwcp_orden_pago_det_Info Deta = new vwcp_orden_pago_det_Info();

                        Deta.IdEmpresa = item.IdEmpresa;
                        Deta.IdOrdenPago = item.IdOrdenPago;
                        Deta.Observacion = item.Observacion;
                        Deta.IdTipo_op = item.IdTipo_op;
                        Deta.IdTipo_Persona = item.IdTipo_Persona;
                        Deta.IdPersona = item .IdPersona;
                        Deta.Fecha = item.Fecha;
                        Deta.Estado = item .Estado;
                        Deta.Secuencia = item.Secuencia;
                        Deta.referencia = item .referencia;
                        Deta.Total_total = item.Total_total;
                        Deta.Total_a_Pagar = item.Total_a_Pagar;
                        Deta.Total_a_pagar_OP = item.Total_a_pagar_OP;
                        Deta.IdEstadoAprobacion = item.IdEstadoAprobacion;
                        Deta.IdEmpresa_cxp = item.IdEmpresa_cxp;
                        Deta.IdCbteCble_cxp = item.IdCbteCble_cxp;
                        Deta.IdTipoCbte_cxp = item.IdTipoCbte_cxp;                                                                                                                            
                        lista.Add(Deta);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
