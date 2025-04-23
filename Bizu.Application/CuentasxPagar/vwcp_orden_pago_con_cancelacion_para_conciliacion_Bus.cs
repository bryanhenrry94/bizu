using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Domain.CuentasxPagar;
using Bizu.Infrastructure.CuentasxPagar;

using Bizu.Application.General;



namespace Bizu.Application.CuentasxPagar
{
   public class vwcp_orden_pago_con_cancelacion_para_conciliacion_Bus
    {
       vwcp_orden_pago_con_cancelacion_para_conciliacion_Data OPD = new vwcp_orden_pago_con_cancelacion_para_conciliacion_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";


        public List<vwcp_orden_pago_con_cancelacion_para_conciliacion_Info> Get_List_orden_pago_con_cancelacion_para_conciliacion(int IdEmpresa, ref string mensaje)
       {
           try
           {
               return OPD.Get_List_orden_pago_con_cancelacion_para_conciliacion(IdEmpresa, ref mensaje);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_con_cancelacion_para_conciliacion", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };
           }
       }

       public List<vwcp_orden_pago_con_cancelacion_para_conciliacion_Info> Get_List_orden_pago_con_cancelacion_para_conciliacion(int IdEmpresa, decimal IdConciliacion, ref string mensaje)
       {
           try
           {
               return OPD.Get_List_orden_pago_con_cancelacion_para_conciliacion(IdEmpresa, IdConciliacion, ref mensaje);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_con_cancelacion_para_conciliacion", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };
           }
       }
    }
}
