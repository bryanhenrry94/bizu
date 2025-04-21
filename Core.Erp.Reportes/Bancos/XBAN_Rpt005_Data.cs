using Core.Erp.Reportes.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Reportes.Bancos
{
    public class XBAN_Rpt005_Data
    {
        public List<XBAN_Rpt005_Info> GetData(int IdEmpresa, decimal IdComprobante, int IdTipoComprobante, ref string MensajeError)
        {
            try
            {
                List<XBAN_Rpt005_Info> Result = new List<XBAN_Rpt005_Info>();

                using (EntitiesBancos_Reporte_Ge conexion = new EntitiesBancos_Reporte_Ge())
                {

                    var Select = from q in conexion.vwBAN_Rpt005
                                 where q.IdEmpresa == IdEmpresa && q.IdCbteCble == IdComprobante && q.IdTipocbte == IdTipoComprobante
                                 select q;

                    foreach (var rpt in Select)
                    {
                        XBAN_Rpt005_Info infoRpt = new XBAN_Rpt005_Info
                        {
                            IdEmpresa = rpt.IdEmpresa,
                            IdCbteCble = rpt.IdCbteCble,
                            IdTipocbte = rpt.IdTipocbte,
                            Cod_Cbtecble = rpt.Cod_Cbtecble,
                            cb_Observacion = rpt.cb_Observacion,
                            cb_secuencia = rpt.cb_secuencia,
                            cb_Valor = rpt.cb_Valor,
                            cb_Cheque = rpt.cb_Cheque,
                            cb_ChequeImpreso = rpt.cb_ChequeImpreso,
                            cb_FechaCheque = rpt.cb_FechaCheque,
                            Fecha_Transac = rpt.Fecha_Transac,
                            Estado = rpt.Estado,
                            cb_giradoA = rpt.cb_giradoA,
                            cb_ciudadChq = rpt.cb_ciudadChq,
                            CodTipoCbteBan = rpt.CodTipoCbteBan,
                            cb_Fecha = rpt.cb_Fecha,
                            con_Fecha = rpt.con_Fecha,
                            con_Valor = rpt.con_Valor,
                            con_Observacion = rpt.con_Observacion,
                            con_IdCbteCble = rpt.con_IdCbteCble,
                            IdCtaCble = rpt.IdCtaCble,
                            pc_Cuenta = rpt.pc_Cuenta,
                            ValorEnLetras = rpt.ValorEnLetras,
                            dc_Valor = rpt.dc_Valor,
                            nom_ciudad = rpt.nom_ciudad,
                            ba_descripcion = "",
                            ba_Num_Cuenta = ""
                        };

                        if (infoRpt.dc_Valor < 0)
                        {
                            infoRpt.dc_ValorHaber = infoRpt.dc_Valor * -1;
                        }
                        else
                        {
                            infoRpt.dc_ValorDebe = infoRpt.dc_Valor;
                        }

                        Result.Add(infoRpt);

                    }

                    return Result;
                }
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XBAN_Rpt005_Data) };
            }
        }
    }
}