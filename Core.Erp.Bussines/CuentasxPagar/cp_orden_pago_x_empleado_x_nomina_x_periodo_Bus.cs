using Core.Erp.Business.General;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_orden_pago_x_empleado_x_nomina_x_periodo_Bus
    {
        cp_orden_pago_x_empleado_x_nomina_x_periodo_Data oData = new cp_orden_pago_x_empleado_x_nomina_x_periodo_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        public Boolean GuardarDB(cp_orden_pago_x_empleado_x_nomina_x_periodo_Info info, ref string mensaje)
        {
            try
            {
                return oData.GuardarDB(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_orden_pago_det_Bus) };
            }


        }
        public Boolean ModificarDB(cp_orden_pago_x_empleado_x_nomina_x_periodo_Info info, ref string mensaje)
        {
            try
            {
                return oData.ModificarDB(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_orden_pago_det_Bus) };
            }


        }
    }
}
