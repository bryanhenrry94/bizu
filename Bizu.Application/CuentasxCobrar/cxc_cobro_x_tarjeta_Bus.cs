using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.CuentasxCobrar;
using Bizu.Domain.CuentasxCobrar;
using Bizu.Application.General;
using Bizu.Domain.General;

namespace Bizu.Application.CuentasxCobrar
{
    public class cxc_cobro_x_tarjeta_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cxc_cobro_x_tarjeta_Data data = new cxc_cobro_x_tarjeta_Data();
        cxc_cobro_x_EstadoCobro_Bus busCobroEstado = new cxc_cobro_x_EstadoCobro_Bus();
        cxc_cobro_Bus Bus = new cxc_cobro_Bus();

        public Boolean GuardarDB(cxc_cobro_x_tarjeta_Info Info)
        {
            try
            {
                return data.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_tarjeta_Bus) };
            }
        }

    }
}
