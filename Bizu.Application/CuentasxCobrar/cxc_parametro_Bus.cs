using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.CuentasxCobrar;
using Bizu.Domain.CuentasxCobrar;
using Bizu.Application.General;

namespace Bizu.Application.CuentasxCobrar
{//06052013//
    public class cxc_parametro_Bus
    {
        cxc_parametro_Data data = new cxc_parametro_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        public cxc_parametro_Info Get_Info_parametro(int IdEmpresa)
        {
            try
            {
              return data.Get_Info_parametro(IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_parametro", ex.Message), ex) { EntityType = typeof(cxc_parametro_Bus) };
            }

        }

        public Boolean GuardarDB(cxc_parametro_Info Info)
        {
            try
            {
             return data.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_parametro_Bus) };
            }

        }
    }
}
