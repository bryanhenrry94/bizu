using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.CuentasxCobrar;
using Bizu.Infrastructure.CuentasxCobrar;

namespace Bizu.Application.CuentasxCobrar
{
  public  class vwcxc_anticipos_x_cruzar_Bus
    {
      vwcxc_anticipos_x_cruzar_Data oData = new vwcxc_anticipos_x_cruzar_Data();

      public List<vwcxc_anticipos_x_cruzar_Info> Get_List_anticipos_x_cruzar(vwcxc_anticipos_x_cruzar_Info info)
      {
          try
          {
              return oData.Get_List_anticipos_x_cruzar(info);
          }
          catch (Exception ex)
          {

              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_anticipos_x_cruzar", ex.Message), ex) { EntityType = typeof(vwcxc_anticipos_x_cruzar_Bus) };
          }
      }

      public List<vwcxc_anticipos_x_cruzar_Info> Get_List_anticipos_x_cruzar_Todos(vwcxc_anticipos_x_cruzar_Info info)
      {
          try
          {
              return oData.Get_List_anticipos_x_cruzar_Todos(info);
          }
          catch (Exception ex)
          {

              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_anticipos_x_cruzar", ex.Message), ex) { EntityType = typeof(vwcxc_anticipos_x_cruzar_Bus) };
          }
      }

      public List<vwcxc_anticipos_x_cruzar_Info> Get_List_anticipos_x_cruzar_Pendientes_de_Diario(vwcxc_anticipos_x_cruzar_Info info)
      {
          //try
          //{
              return oData.Get_List_anticipos_x_cruzar_Pendientes_de_Diario(info);
          //}
          //catch (Exception ex)
          //{
          //    //Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
          //    //throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_anticipos_x_cruzar_Pendientes_de_Diario", ex.Message), ex) { EntityType = typeof(vwcxc_anticipos_x_cruzar_Bus) };
          //}
      }
    }
}
