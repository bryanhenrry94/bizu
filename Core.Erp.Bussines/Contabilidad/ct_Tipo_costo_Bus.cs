using Core.Erp.Data.Contabilidad;
using Core.Erp.Info.Contabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Core.Erp.Business.Contabilidad
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
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_Tipo_costo", ex.Message), ex) { EntityType = typeof(ct_Tipo_costo_Bus) };
            }
        }

    }
}
