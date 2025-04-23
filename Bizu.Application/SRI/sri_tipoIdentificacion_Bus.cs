using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.SRI;
using Bizu.Infrastructure.SRI;
using Bizu.Application.General;

namespace Bizu.Application.SRI
{
    public class sri_tipoIdentificacion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        sri_tipoIdentificacion_Data Data = new sri_tipoIdentificacion_Data();

        public List<sri_tipoIdentificacion_Info> ConsultaSRITipoIdentificacion()
        {
            try
            {
                return Data.ConsultaSRITipoIdentificacion();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaSRITipoIdentificacion", ex.Message), ex) { EntityType = typeof(sri_tipoIdentificacion_Bus) };
            }

        }
    }
}
