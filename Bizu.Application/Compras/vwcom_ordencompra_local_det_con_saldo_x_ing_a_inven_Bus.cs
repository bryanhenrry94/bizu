using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Domain.Compras;
using Bizu.Infrastructure.Compras;
using Bizu.Application.General;

using Bizu.Domain.Inventario;

namespace Bizu.Application.Compras
{
  public  class vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven_Bus
    {

        vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven_Data odata = new vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven_Data();

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<in_movi_inve_detalle_Info> Get_List_movi_inve_detalle(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {
                return odata.Get_List_movi_inve_detalle(IdEmpresa, IdSucursal, IdOrdenCompra);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_TerminoPago", ex.Message), ex) { EntityType = typeof(vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven_Bus) };

            }

        }
    }
}
