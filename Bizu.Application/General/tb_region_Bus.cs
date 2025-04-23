using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Domain.General;
using Bizu.Infrastructure.General;
using Bizu.Application.General;

namespace Bizu.Application.General
{
   public class tb_region_Bus
   {
       tb_region_Data data=new tb_region_Data();
       public List<tb_region_Info> Get_List_Region()
       {
                   try 
	        {	        
		        return data.Get_List_Region();
	        }
	catch (Exception ex)
	{
		
		         Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Obtener_BodegasTodas", ex.Message), ex) { EntityType = typeof(tb_Bodega_Bus) };
         
	}
       }
    }
}
