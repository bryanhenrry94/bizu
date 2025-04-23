using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Facturacion;
using Bizu.Infrastructure.Facturacion;
using Bizu.Application.General;
namespace Bizu.Application.Facturacion
{
    
    public class fa_OrdenDespachoDet_bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        fa_orden_Desp_det_Data odata = new fa_orden_Desp_det_Data();

        public List<fa_orden_Desp_det_Info> Get_List_orden_Desp_det(fa_orden_Desp_Info Info)
        {
            try
            {
                  return odata.Get_List_orden_Desp_det(Info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaxOrdDespacho", ex.Message), ex) { EntityType = typeof(fa_OrdenDespachoDet_bus) };
            }

       }

        public List<fa_orden_Desp_det_Info> Get_List_orden_Desp_x_Pedido(fa_pedido_Info Info)
        {
            try
            {
                return odata.Get_List_orden_Desp_x_Pedido(Info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaxOrdDespachoxPedido", ex.Message), ex) { EntityType = typeof(fa_OrdenDespachoDet_bus) };
            
            }

        }

    }
}
