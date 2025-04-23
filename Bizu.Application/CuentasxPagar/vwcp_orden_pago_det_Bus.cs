using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Domain.CuentasxPagar;
using Bizu.Infrastructure.CuentasxPagar;

using Bizu.Application.General;
using Bizu.Application.Inventario;
using Bizu.Domain.Inventario;

namespace Bizu.Application.CuentasxPagar
{
    public class vwcp_orden_pago_det_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        vwcp_orden_pago_det_Data odata = new vwcp_orden_pago_det_Data();

        public List<vwcp_orden_pago_det_Info> Get_List_OrdenPagoDetalle(int IdEmpresa_Ogiro, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro, ref string mensaje)
        {
            try
            {
                return odata.Get_List_OrdenPagoDetalle(IdEmpresa_Ogiro, IdCbteCble_Ogiro, IdTipoCbte_Ogiro, ref mensaje);
            }
            catch (Exception ex)
            {   
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_OrdenPagoDetalle", ex.Message), ex) { EntityType = typeof(vwcp_orden_pago_det_Bus) };
            }
        }
    }
}
