using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.SRI;
using Bizu.Domain.SRI;
using Bizu.Application.General;

namespace Bizu.Application.SRI
{
    public class sri_provincia_Bus
    {
        sri_provincia_Data Data = new sri_provincia_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        public List<sri_provincia_Info> ConsultaGeneralProv()
        {
            try
            {
                return Data.ConsultaGeneralProv();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaGeneralProv", ex.Message), ex) { EntityType = typeof(sri_provincia_Bus) };
            }

        }
    }
}
