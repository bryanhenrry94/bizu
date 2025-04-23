using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bizu.Infrastructure.General;
using Bizu.Domain.General;
using Bizu.Domain.CuentasxPagar;

namespace Bizu.Infrastructure.CuentasxPagar
{
    public class vwcp_Anticipos_para_Conciliar_Data
    {
        public List<vwcp_Anticipos_para_Conciliar_Info> Get_list_Anticipos_para_Conciliar(int IdEmpresa, string tipo, DateTime cb_fechaDesde, DateTime cb_fechaHasta, ref string mensaje)
        {
            try
            {
                List<vwcp_Anticipos_para_Conciliar_Info> Lst = new List<vwcp_Anticipos_para_Conciliar_Info>();

                using (EntitiesCuentasxPagar OEnti_cxp = new EntitiesCuentasxPagar())
                {
                    var consulta = from q in OEnti_cxp.vwcp_Anticipos_para_Conciliar
                                   where q.IdEmpresaOP == IdEmpresa
                                   && q.tipo.Contains(tipo)
                                   && q.Fecha >= cb_fechaDesde
                                   && q.Fecha <= cb_fechaHasta
                                   && q.valor_saldo_cbte > 0
                                   select q;

                    foreach (var conciliar in consulta)
                    {
                        vwcp_Anticipos_para_Conciliar_Info item = new vwcp_Anticipos_para_Conciliar_Info();
                        item.IdEmpresa_cxp = conciliar.IdEmpresa_cxp;
                        item.IdCbteCble_cxp = conciliar.IdCbteCble_cxp;
                        item.IdTipocbte_cxp = conciliar.IdTipoCbte_cxp;
                        item.Fecha = conciliar.Fecha;
                        item.Observacion = conciliar.Observacion;
                        item.referencia = "";
                        item.tc_TipoCbte = conciliar.tc_TipoCbte;
                        item.Valor_cbte = conciliar.Valor_cbte;
                        item.Valor_cancelado = conciliar.Valor_cancelado;
                        item.valor_Saldo_cbte = conciliar.valor_saldo_cbte;
                        item.tipo = conciliar.tipo;
                        item.IdEmpresaOP = conciliar.IdEmpresaOP;
                        item.IdOrdenPagoOP = conciliar.IdOrdenPagoOP;
                        item.SecuenciaOP = conciliar.SecuenciaOP;
                        item.IdCtaCble = conciliar.IdCtaCble;
                        item.IdCtaCble_Anticipo = conciliar.IdCtaCble_Anticipo;
                        item.Beneficiario = conciliar.Beneficiario;
                        item.IdProveedor = conciliar.IdProveedor;
                        item.IdPersona = conciliar.IdPersona;
                        Lst.Add(item);
                    }
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}