using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt024_Data
    {
        public List<XCONTA_Rpt024_Info> consultar_data(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<XCONTA_Rpt024_Info> lista = new List<XCONTA_Rpt024_Info>();

                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                using (EntitiesContabilidadRptGeneral dbContext = new EntitiesContabilidadRptGeneral())
                {
                    dbContext.SetCommandTimeOut(30000); //timeout 3 minutos

                    var query = from q in dbContext.vwCONTA_Rpt024
                                where q.IdEmpresa == IdEmpresa
                                && q.Fecha >= FechaIni
                                && q.Fecha <= FechaFin
                                select q;

                    foreach (var item in query)
                    {
                        XCONTA_Rpt024_Info Info = new XCONTA_Rpt024_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.Tipo = item.Tipo;
                        Info.NumDiario = item.NumDiario;
                        Info.IdCtaCble = item.IdCtaCble;
                        Info.Cuenta = item.Cuenta;
                        Info.Fecha = item.Fecha;
                        Info.cb_FechaTransac = item.cb_FechaTransac;
                        Info.Debe = item.Debe;
                        Info.Haber = item.Haber;
                        Info.Observacion = item.Observacion;
                        Info.IdUsuario = item.IdUsuario;
                        Info.IdCentroCosto = item.IdCentroCosto;

                        lista.Add(Info);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
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