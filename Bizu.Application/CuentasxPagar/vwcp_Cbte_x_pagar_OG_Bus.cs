using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Domain.CuentasxPagar;
using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Application.General;

namespace Bizu.Application.CuentasxPagar
{
   public  class vwcp_Cbte_x_pagar_OG_Bus
    {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje="";
       vwcp_Cbte_x_pagar_OG_Data data = new vwcp_Cbte_x_pagar_OG_Data();

       public List<vwcp_Cbte_x_pagar_OG_Info> Get_List_Cbte_x_pagar_OG(int IdEmpresa, decimal IdProveedor, string TipoReg)
       {
           try
           {
               return data.Get_List_Cbte_x_pagar_OG(IdEmpresa, IdProveedor, TipoReg);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Cbte_x_pagar_OG", ex.Message), ex) { EntityType = typeof(vwcp_Cbte_x_pagar_OG_Bus) };
           }

       }

       public List<vwcp_Cbte_x_pagar_OG_Info> Get_List_Cbte_x_pagar_OG(int IdEmpresa, decimal IdOrdenPago)
       {
           try
           {
               return data.Get_List_Cbte_x_pagar_OG(IdEmpresa, IdOrdenPago);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Cbte_x_pagar_OG", ex.Message), ex) { EntityType = typeof(vwcp_Cbte_x_pagar_OG_Bus) };
           }
       
       }
    }
}
