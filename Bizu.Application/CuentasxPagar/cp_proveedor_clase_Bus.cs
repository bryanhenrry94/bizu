using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Domain.CuentasxPagar;
using Bizu.Application.General;



namespace Bizu.Application.CuentasxPagar
{
  public  class cp_proveedor_clase_Bus
    {

      cp_proveedor_clase_Data Odata = new cp_proveedor_clase_Data();
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
      cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


      string mensaje = "";

      public Boolean GuardarDB(cp_proveedor_clase_Info info,ref int Id,ref string mensaje)
      {
          try
          {
              info.IdUsuario = param.IdUsuario;
              info.FechaTransac = param.Fecha_Transac;
              info.FechaUltModi = param.Fecha_Transac;
              info.IdUsuarioUltModi = param.IdUsuario;

              return Odata.GuardarDB(info, ref Id, ref  mensaje);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_proveedor_clase_Bus) };
              
          }
      }

      public Boolean ModificarDB(cp_proveedor_clase_Info info,ref  string mensaje)
      {
          try
          {

              info.FechaUltModi = param.Fecha_Transac;
              info.IdUsuarioUltModi = param.IdUsuario;

              return Odata.ModificarDB(info,ref mensaje);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_proveedor_clase_Bus) };
          }

      }

      public List<cp_proveedor_clase_Info> Get_List_proveedor_clase(int IdEmpresa)
      {
          try
          {
              return Odata.Get_List_proveedor_clase(IdEmpresa);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_proveedor_clase", ex.Message), ex) { EntityType = typeof(cp_proveedor_clase_Bus) };
          }
      }

      public cp_proveedor_clase_Info Get_Info_proveedor_clase(int IdEmpresa, int IdClaseProveedor)
      {
          try
          {
               return Odata.Get_Info_proveedor_clase(IdEmpresa,IdClaseProveedor);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_proveedor_clase", ex.Message), ex) { EntityType = typeof(cp_proveedor_clase_Bus) };
             
          }
      
      
      }


      public Boolean AnularDB(cp_proveedor_clase_Info info,ref string mensaje)
      {
          try
          {
              info.FechaAnu = param.Fecha_Transac;
              info.IdUsuarioAnu= param.IdUsuario;

              return Odata.AnularDB(info, ref mensaje);

          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(cp_proveedor_clase_Bus) };
              
          }
      }

      public cp_proveedor_clase_Bus()
      {
            
      }


    }
}
