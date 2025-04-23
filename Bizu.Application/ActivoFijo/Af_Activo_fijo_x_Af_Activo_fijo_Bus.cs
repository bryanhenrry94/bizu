using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.ActivoFijo;
using Bizu.Infrastructure.ActivoFijo;
namespace Bizu.Application.ActivoFijo
{
  public  class Af_Activo_fijo_x_Af_Activo_fijo_Bus
  {
      Af_Activo_fijo_x_Af_Activo_fijo_Data data = new Af_Activo_fijo_x_Af_Activo_fijo_Data();
      public bool GuardarDB(List< Af_Activo_fijo_x_Af_Activo_fijo_Info> lista)
      {
          try
          {
             
             
               data.GuardarDB(lista);
              
              return true;

          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_x_Af_Activo_fijo_Bus) };
       
              
          }

      }

      public bool EliminarDB(int idempresa,int idactivo_padre)
      {
          try
          {
              return data.EliminarDB(idempresa,idactivo_padre);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_x_Af_Activo_fijo_Bus) };
       
              
          }

      }
      public List<Af_Activo_fijo_x_Af_Activo_fijo_Info> Get_List_activos_relacionados(int idempresa, int idactivo_hijo)
      { try
          {
              return data.Get_List_activos_relacionados(idempresa, idactivo_hijo);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_activos_relacionados", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_x_Af_Activo_fijo_Bus) };
       
              
          }

      }
    }
}
