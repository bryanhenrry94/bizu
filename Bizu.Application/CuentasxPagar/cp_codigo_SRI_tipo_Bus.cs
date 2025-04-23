using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Domain.CuentasxPagar;
using Bizu.Application.General;

namespace Bizu.Application.CuentasxPagar
{
   public  class cp_codigo_SRI_tipo_Bus
    {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";
       public List<cp_codigo_SRI_tipo_Info> Get_List_codigo_SRI_tipo()
       {
           try
           {
                cp_codigo_SRI_tipo_Data tp_data_ = new cp_codigo_SRI_tipo_Data();
                return tp_data_.Get_List_codigo_SRI_tipo();
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_codigo_SRI_tipo", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_tipo_Bus) };
           }


        }

       public Boolean GrabarDB(cp_codigo_SRI_tipo_Info info)
        {
            try
            {
                cp_codigo_SRI_tipo_Data data = new cp_codigo_SRI_tipo_Data();
                return data.GrabarDB(info);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_tipo_Bus) };
            }
        }



       public Boolean ModificarDB(cp_codigo_SRI_tipo_Info info)
        {

            try
            {
                cp_codigo_SRI_tipo_Data data = new cp_codigo_SRI_tipo_Data();
                return data.ModificarDB(info);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_tipo_Bus) };
            }
        }



       public cp_codigo_SRI_tipo_Bus()
       {
           
       }
   }
}
