using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Domain.CuentasxCobrar;
using Bizu.Infrastructure.CuentasxCobrar;
using Bizu.Domain.General;
using Bizu.Application.General;


namespace Bizu.Application.CuentasxCobrar
{
    public class cxc_cobros_Pendientes_de_deposito_Bus
    {
        cxc_cobros_Pendientes_de_deposito_Data oData = new cxc_cobros_Pendientes_de_deposito_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public cxc_cobros_Pendientes_de_deposito_Info Get_Info_cobros_Pendientes_de_deposito(int IdEmpresa, int IdSucursal, int IdCobro, ref string mensaje)
        {
            try
            {
                return oData.Get_Info_cobros_Pendientes_de_deposito(IdEmpresa, IdSucursal, IdCobro, ref mensaje);
            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_cobros_Pendientes_de_deposito", ex.Message), ex) { EntityType = typeof(cxc_cobros_Pendientes_de_deposito_Bus) };
            }

        }
    }
}
