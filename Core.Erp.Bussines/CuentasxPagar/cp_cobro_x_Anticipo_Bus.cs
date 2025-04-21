using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Business.CuentasxPagar
{
   public class cp_cobro_x_Anticipo_Bus
    {
       cp_cobro_x_Anticipo_Data data = new cp_cobro_x_Anticipo_Data();

       public List<cp_cobro_x_Anticipo_Info> Get_List_cobro_x_Anticipo(int IdEmpresa, ref string mensaje)
       {
           try
           {
               return data.Get_List_cobro_x_Anticipo(IdEmpresa, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_Anticipo", ex.Message), ex) { EntityType = typeof(cp_cobro_x_Anticipo_Bus) };
           }

       }

    }
}
