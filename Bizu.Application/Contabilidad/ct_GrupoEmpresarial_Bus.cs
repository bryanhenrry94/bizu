using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure.Contabilidad;
using Bizu.Application.General;

namespace Bizu.Application.Contabilidad
{
   public class ct_GrupoEmpresarial_Bus
    {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";
       ct_GrupoEmpresarial_Data data = new ct_GrupoEmpresarial_Data();

       public Boolean GrabarDB(ct_GrupoEmpresarial_Info Info)
       {
           try
           {
               return data.GrabarDB(Info);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_GrupoEmpresarial_Bus) };
           }

       }

       public List<ct_GrupoEmpresarial_Info> Get_list_GrupoEmpresarial()
       {
           try
           {
                 return data.Get_list_GrupoEmpresarial();
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_GrupoEmpresarial", ex.Message), ex) { EntityType = typeof(ct_GrupoEmpresarial_Bus) };
           }

       }
       
       public Boolean ModificarDB(ct_GrupoEmpresarial_Info info)
       {
           try
           {
                return data.ModificarDB(info);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_GrupoEmpresarial_Bus) };
           }

       }
      
       public Boolean AnularDB(ct_GrupoEmpresarial_Info info)
       {
           try
           {
                 return data.AnularDB(info);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ct_GrupoEmpresarial_Bus) };
           }

       }

       public ct_GrupoEmpresarial_Bus()
       {
           
       }
    }
}
