using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.CuentasxCobrar;
using Bizu.Domain.CuentasxCobrar;

namespace Bizu.Application.CuentasxCobrar
{
    public class vwcxc_cobros_conciliados_Bus
    {
        vwcxc_cobros_conciliados_Data conciliadoData = new vwcxc_cobros_conciliados_Data();

        public List<vwcxc_cobros_conciliados_Info> Get_List_cobros_conciliados(int IdEmpresa, int IdSucursal, decimal IdConciliacion, string tipoConciliacion, ref string mensaje)
        {
            try
            {
                return conciliadoData.Get_List_cobros_conciliados(IdEmpresa, IdSucursal, IdConciliacion, tipoConciliacion, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_cobros_conciliados", ex.Message), ex) { EntityType = typeof(vwcxc_cobros_conciliados_Bus) };
            }   
        }



    }
}
