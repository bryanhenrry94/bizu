using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Bancos;
using Bizu.Infrastructure.Bancos;
using Bizu.Application.General;

namespace Bizu.Application.Bancos
{
    public class vwba_Cbte_Ban_detallePagos_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

         vwba_Cbte_Ban_detallePagos_Data data = new vwba_Cbte_Ban_detallePagos_Data();

         public List<vwba_Cbte_Ban_detallePagos_Info> Get_List_Cbte_Ban_detallePagos(int IdEmpresa, int IdTipocbte, decimal IdCbteCble)
         {
             try
             {
                     return data.Get_List_Cbte_Ban_detallePagos(IdEmpresa, IdTipocbte, IdCbteCble);
             }
             catch (Exception ex)
             {
                 Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                 throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Cbte_Ban_detallePagos", ex.Message), ex) { EntityType = typeof(vwba_Cbte_Ban_detallePagos_Bus) };
             }

         }



         public List<vwba_ordenGiroPendientes_Info> Get_List_PgCheque(int IdEmpresa, int IdTipocbte, decimal IdCbteCble)
        {
            try
            {
               return data.Get_List_PgCheque(IdEmpresa, IdTipocbte, IdCbteCble);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_PgCheque", ex.Message), ex) { EntityType = typeof(vwba_Cbte_Ban_detallePagos_Bus) };
            }

        }
        public vwba_Cbte_Ban_detallePagos_Bus()
        {
            
        }
    }
}
