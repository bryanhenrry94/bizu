using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;

namespace Bizu.Reports.Bancos
{
   public class XBAN_Rpt008_Data
    {
        string mensaje = "";


        public List<XBAN_Rpt008_Info> get_ReporteFlujoCajaResumido(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<XBAN_Rpt008_Info> lstRpt = new List<XBAN_Rpt008_Info>();

                using (EntitiesBancos_Reporte_Ge listado = new EntitiesBancos_Reporte_Ge())
                {
                    var select = from q in listado.spBAN_Rpt008(IdEmpresa, FechaIni, FechaFin)
                                 select q;

                    foreach (var item in select)
                    {
                        XBAN_Rpt008_Info infoRpt = new XBAN_Rpt008_Info();
                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.idTipoFlujo = item.idTipoFlujo;
                        infoRpt.descripcion_flujo = item.descripcion_flujo;                       
                        infoRpt.Des_tipo_cbte = item.Des_tipo_cbte;                     
                        infoRpt.dc_Valor = item.dc_Valor;
                        infoRpt.ba_descripcion = item.ba_descripcion;                    
                        infoRpt.ba_Num_Cuenta = item.ba_Num_Cuenta;
                        infoRpt.Orden = item.Orden;
                        infoRpt.id_Des_tipo_cbte = item.id_Des_tipo_cbte;

                        lstRpt.Add(infoRpt);
                    }

                }

                return lstRpt;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XBAN_Rpt014_Data) };
            }
        }


    }
}
