using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;



namespace Core.Erp.Reportes.Bancos
{
    public class XBAN_Rpt006_Data
    {

        public List<XBAN_Rpt006_Info> Get_Data_Reporte(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble, ref string MensajeError)
        {
            try
            {
                List<XBAN_Rpt006_Info> lstRpt = new List<XBAN_Rpt006_Info>();
                using (EntitiesBancos_Reporte_Ge listado = new EntitiesBancos_Reporte_Ge())
                {
                    var select = from q in listado.vwBAN_Rpt006
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdTipocbte == IdTipoCbte
                                 && q.IdCbteCble == IdCbteCble
                                 select q;

                    foreach (var _det in select)
                    {

                        XBAN_Rpt006_Info infoRpt = new XBAN_Rpt006_Info
                        {
                            IdEmpresa = _det.IdEmpresa,
                            IdPeriodo = Convert.ToInt32(_det.IdPeriodo),
                            IdBanco = _det.IdBanco,
                            ba_descripcion = _det.ba_descripcion,
                            tc_TipoCbte = _det.tc_TipoCbte,
                            IdCbteCble = _det.IdCbteCble,
                            IdTipocbte = _det.IdTipocbte,
                            Cod_Cbtecble = _det.Cod_Cbtecble,
                            IdProveedor = _det.IdProveedor,
                            NombreProveedor = "",
                            cb_Fecha = _det.cb_Fecha,
                            cb_Observacion = _det.cb_Observacion,
                            cb_secuencia = _det.cb_secuencia,
                            cb_Valor = _det.cb_Valor,
                            ValorEnLetras = _det.ValorEnLetras,
                            cb_Cheque = _det.cb_Cheque,
                            cb_FechaCheque = _det.cb_FechaCheque,
                            Estado = _det.Estado,
                            MotivoAnulacion = _det.MotivoAnulacion,
                            cb_giradoA = _det.cb_giradoA,
                            cb_ciudadChq = _det.cb_ciudadChq,
                            IdCbteCble_Anulacion = _det.IdCbteCble_Anulacion,
                            IdTipoCbte_Anulacion = _det.IdTipoCbte_Anulacion,
                            IdTipoFlujo = _det.IdTipoFlujo,
                            IdTipoNota = _det.IdTipoNota,
                            NomTipoNota = _det.NomTipoNota,
                            Por_Anticipo = _det.Por_Anticipo,
                            PosFechado = _det.PosFechado,
                            IdPersona_Girado_a = _det.IdPersona_Girado_a,
                            nom_ciudadChq = _det.nom_ciudadChq
                        };

                        
                        lstRpt.Add(infoRpt);
                        break;
                    }
                }
                return lstRpt;
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XBAN_Rpt006_Data) };
            }
        }
    }
}
