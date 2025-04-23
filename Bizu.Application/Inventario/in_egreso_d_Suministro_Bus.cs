using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Inventario;
using Bizu.Infrastructure.Inventario;
using Bizu.Application.General;

namespace Bizu.Application.Inventario
{
   public class in_egreso_d_Suministro_Bus
    {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";
       in_egreso_d_Suministro_Data oData = new in_egreso_d_Suministro_Data();
       public Boolean GuardarDB(in_egreso_d_Suministro_Info Info)
       {
           try
           {
                return oData.GuardarDB(Info);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_egreso_d_Suministro_Bus) };

           }

       }
    }
}
