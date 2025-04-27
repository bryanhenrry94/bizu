using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;

namespace Bizu.Infrastructure.Contabilidad
{
    public class vwct_cbtecble_con_saldo_cxp_Data
    {
        public List<vwct_cbtecble_con_saldo_cxp_Info> Get_list_cbtecble_con_saldo_cxp(int IdEmpresa, string tipo, DateTime cb_fechaDesde,
          DateTime cb_fechaHasta, ref string mensaje)
        {
            try
            {
                List<vwct_cbtecble_con_saldo_cxp_Info> Lst = new List<vwct_cbtecble_con_saldo_cxp_Info>();
                using (EntitiesDBConta conta = new EntitiesDBConta())
                {
                    switch (tipo)
                    {
                        case "DIARIO":
                            var consulta = from q in conta.vwct_cbtecble_con_saldo_cxp_diario
                                           where q.idempresa == IdEmpresa
                                           && q.tipo.Contains(tipo)
                                           && q.cb_fecha >= cb_fechaDesde
                                           && q.cb_fecha <= cb_fechaHasta
                                           && q.valor_saldo_cbte > 0
                                           select q;

                            foreach (var item in consulta)
                            {
                                vwct_cbtecble_con_saldo_cxp_Info info = new vwct_cbtecble_con_saldo_cxp_Info();
                                info.IdEmpresa = item.idempresa;
                                info.IdCbteCble = item.idcbtecble;
                                info.IdTipocbte = item.idtipocbte;
                                info.cb_Fecha = item.cb_fecha;
                                info.cb_Observacion = item.cb_observacion;
                                info.referencia = item.referencia;
                                info.tc_TipoCbte = item.tc_tipocbte;
                                info.Valor_cbte = item.valor_cbte;
                                info.Valor_cancelado_cbte = item.valor_cancelado_cbte;
                                info.valor_Saldo_cbte = item.valor_saldo_cbte;
                                info.tipo = item.tipo;
                                info.IdEmpresaOP = null;
                                info.IdOrdenPagoOP = null;
                                info.SecuenciaOP = null;
                                info.IdCtaCble = null;
                                info.IdCtaCble_Anticipo = null;
                                info.Beneficiario = item.beneficiario;
                                info.IdBeneficiario = item.idproveedor;
                                Lst.Add(info);
                            }
                            break;
                        case "NOTA-CRED":
                        case "NOTA-DEB":
                            var consulta2 = from q in conta.vwct_cbtecble_con_saldo_cxp_nota
                                            where q.idempresa == IdEmpresa
                                            && q.tipo.Contains(tipo)
                                            && q.cn_fecha >= cb_fechaDesde
                                            && q.cn_fecha <= cb_fechaHasta
                                            && q.valor_saldo_cbte > 0
                                            select q;

                            foreach (var item in consulta2)
                            {
                                vwct_cbtecble_con_saldo_cxp_Info info = new vwct_cbtecble_con_saldo_cxp_Info();
                                info.IdEmpresa = item.idempresa;
                                info.IdCbteCble = item.idcbtecble_nota;
                                info.IdTipocbte = item.idtipocbte_nota;
                                info.cb_Fecha = item.cn_fecha;
                                info.cb_Observacion = item.cn_observacion;
                                info.referencia = item.referncia;
                                info.tc_TipoCbte = item.tc_tipocbte;
                                info.Valor_cbte = Convert.ToDouble(item.valor_cbte);
                                info.Valor_cancelado_cbte = item.valor_cancelado_cbte;
                                info.valor_Saldo_cbte = item.valor_saldo_cbte;
                                info.tipo = item.tipo;
                                info.IdEmpresaOP = null;
                                info.IdOrdenPagoOP = null;
                                info.SecuenciaOP = null;
                                info.IdCtaCble = item.idctacble;
                                info.IdCtaCble_Anticipo = item.idctaanticipo;
                                info.Beneficiario = item.beneficiario;
                                info.IdBeneficiario = item.idproveedor;
                                Lst.Add(info);
                            }
                            break;

                        default:
                            var consulta3 = from q in conta.vwct_cbtecble_con_saldo_cxp
                                            where q.idempresa == IdEmpresa
                                            && q.tipo.Contains(tipo)
                                            && q.cb_fecha >= cb_fechaDesde
                                            && q.cb_fecha <= cb_fechaHasta
                                            && q.valor_saldo_cbte > 0
                                            select q;

                            foreach (var item in consulta3)
                            {
                                vwct_cbtecble_con_saldo_cxp_Info info = new vwct_cbtecble_con_saldo_cxp_Info();
                                info.IdEmpresa = item.idempresa;
                                info.IdCbteCble = item.idcbtecble;
                                info.IdTipocbte = item.idtipocbte;
                                info.cb_Fecha = item.cb_fecha;
                                info.cb_Observacion = item.cb_observacion;
                                info.referencia = item.referencia;
                                info.tc_TipoCbte = item.tc_tipocbte;
                                info.Valor_cbte = item.valor_cbte;
                                info.Valor_cancelado_cbte = item.valor_cancelado_cbte;
                                info.valor_Saldo_cbte = item.valor_saldo_cbte;
                                info.tipo = item.tipo;
                                info.IdEmpresaOP = item.idempresaop;
                                info.IdOrdenPagoOP = item.idordenpagoop;
                                info.SecuenciaOP = item.secuenciaop;
                                info.IdCtaCble = item.idctacble;
                                info.IdCtaCble_Anticipo = item.idctacble_anticipo;
                                info.Beneficiario = item.beneficiario;
                                info.IdBeneficiario = item.idbeneficiario;
                                Lst.Add(info);
                            }
                            break;
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public vwct_cbtecble_con_saldo_cxp_Info Get_Info_cbtecble_con_saldo_cxp(int IdEmpresa_op, decimal IdOrdenPago_op, string tipo, ref string mensaje)
        {
            try
            {
                vwct_cbtecble_con_saldo_cxp_Info info = new vwct_cbtecble_con_saldo_cxp_Info();
                using (EntitiesDBConta conta = new EntitiesDBConta())
                {
                    var item = conta.vwct_cbtecble_con_saldo_cxp_anti_provee.FirstOrDefault(q => q.idempresaop == IdEmpresa_op && q.idordenpagoop == IdOrdenPago_op && q.tipo == tipo);

                    info.IdEmpresa = item.idempresa;
                    info.IdCbteCble = item.idcbtecble;
                    info.IdTipocbte = item.idtipocbte;
                    info.cb_Fecha = item.fecha;
                    info.cb_Observacion = item.observacion;
                    info.referencia = "";
                    info.tc_TipoCbte = item.tc_tipocbte;
                    info.Valor_cbte = item.valor_cbte;
                    info.Valor_cancelado_cbte = item.valor_cancelado;
                    info.valor_Saldo_cbte = item.valor_saldo_cbte;
                    info.tipo = item.tipo;
                    info.IdEmpresaOP = item.idempresaop;
                    info.IdOrdenPagoOP = item.idordenpagoop;
                    info.SecuenciaOP = item.secuenciaop;
                    info.IdCtaCble = item.idctacble;
                    info.IdCtaCble_Anticipo = item.idctacble_anticipo;
                    info.Beneficiario = item.beneficiario;
                    info.IdBeneficiario = item.idproveedor;
                }

                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}