using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.SRI;
using Bizu.Infrastructure.SRI;
using Bizu.Application.General;

namespace Bizu.Application.SRI
{
    public class sri_ciudad_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        sri_ciudad_Data Data = new sri_ciudad_Data();

        public List<sri_ciudad_Info> ConsultaGeneralCiu()
        {
            try
            {
               return Data.ConsultaGeneralCiu();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaGeneralCiu", ex.Message), ex) { EntityType = typeof(sri_ciudad_Bus) };
            }

        }

        public List<sri_ciudad_Info> ConsultaGeneralCiuxProv(String Provincia)
        {
            try
            {
               return Data.ConsultaGeneralCiuxProv(Provincia);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaGeneralCiuxProv", ex.Message), ex) { EntityType = typeof(sri_ciudad_Bus) };
            }

        }
    }
}
