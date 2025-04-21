using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;

using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Business.CuentasxPagar
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
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_OrdenPagoDetalle", ex.Message), ex) { EntityType = typeof(vwcp_orden_pago_det_Bus) };
            }
        }
    }
}
