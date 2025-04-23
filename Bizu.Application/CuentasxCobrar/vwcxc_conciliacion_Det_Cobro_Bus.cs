using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.CuentasxCobrar;
using Bizu.Domain.CuentasxCobrar;

namespace Bizu.Application.CuentasxCobrar
{
    public class vwcxc_conciliacion_Det_Cobro_Bus
    {
        vwcxc_conciliacion_Det_Cobro_Data conciliaDetData = new vwcxc_conciliacion_Det_Cobro_Data();

        public List<vwcxc_conciliacion_Det_Cobro_Info> Get_List_conciliacion_Det_Cobro(int IdEmpresa, int IdSucursal, decimal IdConciliacion, ref string mensaje)
        {
            try
            {
                return conciliaDetData.Get_List_conciliacion_Det_Cobro(IdEmpresa, IdSucursal, IdConciliacion, ref mensaje);
                
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_conciliacion_Det_Cobro", ex.Message), ex) { EntityType = typeof(vwcxc_cobros_x_cheque_deposito_Bus) };
            }
        }

    }
}
