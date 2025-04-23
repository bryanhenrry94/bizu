using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bizu.Domain.CuentasxPagar;
using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Application.General;

namespace Bizu.Application.CuentasxPagar
{
  public  class cp_conciliacion_Caja_det_Bus
    {

      cp_conciliacion_Caja_det_Data odata = new cp_conciliacion_Caja_det_Data();
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
      
      public Boolean GrabarDB(List<cp_conciliacion_Caja_det_Info> lista, ref string mensaje)
      {
          try
          {
              return odata.GrabarDB(lista, ref mensaje);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_Bus) };
          }
      
      
      }

      public Boolean GrabarDB(cp_conciliacion_Caja_det_Info info, ref string mensaje)
      {

          try
          {
              return odata.GrabarDB(info, ref mensaje);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_Bus) };
          }
      
      }

      public Boolean ModificarDB(cp_conciliacion_Caja_det_Info info, ref string mensaje)
      {

          try
          {
              return odata.ModificarDB(info, ref mensaje);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_Bus) };
          }

      }

      /// <summary>
      /// En el detalle de conciliación actualizo la OP con la que se va a cancelar
      /// </summary>
      public Boolean ModificarOP(int IdEmpresa_conci, decimal IdConci_caja, int IdEmpresa_FP_ND, decimal IdCbteCble_FP_ND, int IdTipoCbte_FP_ND, int IdEmpresa_OP, decimal IdOrdenPago_OP)
      {
          try
          {
              return odata.ModificarOP(IdEmpresa_conci,IdConci_caja,IdEmpresa_FP_ND,IdCbteCble_FP_ND,IdTipoCbte_FP_ND,IdEmpresa_OP,IdOrdenPago_OP);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarOP", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_Bus) };
          }
      }

      public List<cp_conciliacion_Caja_det_Info> Get_List_Conciliacion_Caja_Det(int IdEmpresa, decimal IdConciliacion_caja)
      {
          try
          {
              return odata.Get_List_Conciliacion_Caja_Det(IdEmpresa, IdConciliacion_caja);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_Bus) };
          }
      
      }
    }
}
