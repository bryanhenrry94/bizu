using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.CuentasxPagar;
using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Application.General;

namespace Bizu.Application.CuentasxPagar
{
    public class cp_Aprobacion_Orden_Pago_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cp_Aprobacion_Orden_Pago_Data oData = new cp_Aprobacion_Orden_Pago_Data();

        public Boolean Guardar_AprobacionOrdenPago(cp_Aprobacion_Orden_Pago_Info Item, ref decimal Id, ref string mensaje)
        {
            try
            {
                return oData.Guardar_AprobacionOrdenPago(Item, ref Id, ref  mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Guardar_AprobacionOrdenPago", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Orden_Pago_Bus) };
            }
        }


    }
}
