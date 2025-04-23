using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;



namespace Bizu.Application.General
{
   public  class tb_rango_fecha_busqueda_x_periodo_Bus
    {

       List<tb_rango_fecha_busqueda_x_periodo_Info> listado = new List<tb_rango_fecha_busqueda_x_periodo_Info>();

       tb_rango_fecha_busqueda_x_periodo_Data OData = new tb_rango_fecha_busqueda_x_periodo_Data();



       public List<tb_rango_fecha_busqueda_x_periodo_Info> Obtener_Listado_Rango_fechas()
       {
           try
           {
               return OData.Obtener_Listado_Rango_fechas();
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Obtener_Listado_Rango_fechas", ex.Message), ex) { EntityType = typeof(tb_rango_fecha_busqueda_x_periodo_Bus) };
         
           }
       }

    }
}
