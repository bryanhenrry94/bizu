using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Infrastructure.Facturacion;
using Bizu.Domain.Facturacion;
using Bizu.Application.General;

namespace Bizu.Application.Facturacion
{
  public   class fa_catalogo_tipo_Bus
    {
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
      string mensaje = "";
      fa_catalogo_tipo_Data Data = new fa_catalogo_tipo_Data();


      public List<fa_catalogo_tipo_Info> Get_List_catalogo_tip()
      {
          try
          {
              return Data.Get_List_catalogo_tipo();
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
          }
      }


      public Boolean ValidarCodigoExiste(int Cod)
      {
          try
          {
              return Data.ValidarCodigoExiste(Cod);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ValidarCodigoExiste", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
          }
      
      }


      public bool GuardarDB(ref fa_catalogo_tipo_Info info)
      {
          try
          {
              return Data.GuardarDB(info);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
          }
               
      }

      public bool ModificarDB(ref fa_catalogo_tipo_Info info)
      {
          try
          {
              return Data.ModificarDB(info);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
          }
      
      
      }

      public fa_catalogo_tipo_Info Get_Info_catalogo_tipo(int cod)
      {
          try
          {
              return Data.Get_Info_catalogo_tipo(cod);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerInfo", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
          }
          
         
      }


    }
}
