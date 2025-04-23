using Bizu.Infrastructure.Contabilidad;
using Bizu.Domain.Contabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Bizu.Application.Contabilidad
{
   public  class ct_Tipo_costo_Bus
    {


       ct_Tipo_costo_Data oData = new ct_Tipo_costo_Data();

     


    


       public ct_Tipo_costo_Bus()
       {

       }

       public List<ct_Tipo_costo_Info> Get_list_Tipo_costo(int IdEmpresa)
       {
         
            try
            {
                return oData.Get_list_Tipo_costo(IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_Tipo_costo", ex.Message), ex) { EntityType = typeof(ct_Tipo_costo_Bus) };
            }
        }

    }
}
