using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Domain.CuentasxCobrar;
using Bizu.Infrastructure.CuentasxCobrar;

using Bizu.Application.General;

namespace Bizu.Application.CuentasxCobrar
{
  public  class cxc_conciliacion_det_Bus
    {
      cxc_conciliacion_det_Data oData = new cxc_conciliacion_det_Data();

      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

      public Boolean GuardarDB(List<cxc_conciliacion_det_Info> Lst, ref decimal Id, ref string mensaje)
      {
          try
          {
              return oData.GuardarDB(Lst, ref Id, ref mensaje);
          }
          catch (Exception ex)
          {

              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_conciliacion_det_Bus) };
          }


      }

      public Boolean Modificar_Secuencia_Cobro_DB(List<cxc_conciliacion_det_Info> Lst, ref string mensaje)
      {
          try
          {
              return oData.Modificar_Secuencia_Cobro_DB(Lst, ref mensaje);
          }
          catch (Exception ex)
          {

              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_conciliacion_det_Bus) };
          }
      }

      public List<cxc_conciliacion_det_Info> Get_List_conciliacion_det(int IdEmpresa, int IdSucursal, decimal IdConciliacion, ref string mensaje)
      {
          try
          {
              return oData.Get_List_conciliacion_det(IdEmpresa, IdSucursal, IdConciliacion,ref mensaje);
          }
          catch (Exception ex)
          {

              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_conciliacion_det", ex.Message), ex) { EntityType = typeof(cxc_conciliacion_det_Bus) };
          }
      }
    }
}
