using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bizu.Application.General;
using Bizu.Domain.CuentasxPagar;
using Bizu.Infrastructure.CuentasxPagar;

namespace Bizu.Application.CuentasxPagar
{
  public  class cp_orden_giro_x_com_ordencompra_local_det_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cp_orden_giro_x_com_ordencompra_local_det_Data data = new cp_orden_giro_x_com_ordencompra_local_det_Data();

      public Boolean GrabarDB(cp_orden_giro_x_com_ordencompra_local_det_Info info, ref string mensaje)
      {
          try
          {
              return data.GrabarDB(info, ref mensaje);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_orden_giro_x_com_ordencompra_local_det_Bus) };
          }

      }

      public Boolean EliminarDB(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, int secuencia, ref string mensaje)
      {
          try
          {
              return data.EliminarDB(IdEmpresa, IdSucursal, IdOrdenCompra, secuencia, ref mensaje);
          }
          catch (Exception ex)
          {

              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(cp_orden_giro_x_com_ordencompra_local_det_Bus) };
          }
      
      }

      public Boolean VerificarRegistro(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, int secuencia)
      {
          try
          {
               return data.VerificarRegistro(IdEmpresa,  IdSucursal,  IdOrdenCompra,  secuencia);
          }
          catch (Exception ex)
          {

              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "VerificarRegistro", ex.Message), ex) { EntityType = typeof(cp_orden_giro_x_com_ordencompra_local_det_Bus) };
          }
      }


      public List<cp_orden_giro_x_com_ordencompra_local_det_Info> GetList_OGiro_x_OCompra(int IdEmpresa_Ogiro, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro, ref string mensaje)
      {
          try
          {
              return data.Get_List_orden_giro_x_com_ordencompra_local_det(IdEmpresa_Ogiro, IdCbteCble_Ogiro,  IdTipoCbte_Ogiro, ref mensaje);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_orden_giro_x_com_ordencompra_local_det", ex.Message), ex) { EntityType = typeof(cp_orden_giro_x_com_ordencompra_local_det_Bus) };
          }
      
      }
    }
}
