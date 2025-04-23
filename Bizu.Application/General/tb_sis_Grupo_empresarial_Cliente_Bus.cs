using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;


namespace Bizu.Application.General
{
   public  class tb_sis_Grupo_empresarial_Cliente_Bus
    {

       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

       tb_sis_Grupo_empresarial_Cliente_Data OData = new tb_sis_Grupo_empresarial_Cliente_Data();



       public List<tb_sis_Grupo_empresarial_Cliente_Info> Get_List_Grupo_empresarial_Cliente(ref string mensaje)
       {
           try
           {
               return OData.Get_List_Grupo_empresarial_Cliente(ref mensaje);
           }
           catch (Exception ex)
           {

               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ValidarSiExiste", ex.Message), ex) { EntityType = typeof(tb_sis_Grupo_empresarial_Cliente_Bus) };
         
               
           }

       }

       public tb_sis_Grupo_empresarial_Cliente_Bus()
       {

       }
    }
}
