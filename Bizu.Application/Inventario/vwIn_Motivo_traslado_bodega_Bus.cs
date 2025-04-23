using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Domain.Inventario;
using Bizu.Infrastructure.Inventario;
using Bizu.Domain.General;
using Bizu.Application.General;

namespace Bizu.Application.Inventario
{
   public class vwIn_Motivo_traslado_bodega_Bus
    {

       string mensaje = "";
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       vwIn_Motivo_traslado_bodega_Data odata = new vwIn_Motivo_traslado_bodega_Data();
       public List<vwIn_Motivo_traslado_bodega_Info> Get_List_Motivo_traslado_bodega()
       {
           try
           {
               return odata.Get_List_Motivo_traslado_bodega();
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Motivo_traslado_bodega", ex.Message), ex) { EntityType = typeof(vwIn_Motivo_traslado_bodega_Bus) };

           }
       }  
    }
}
