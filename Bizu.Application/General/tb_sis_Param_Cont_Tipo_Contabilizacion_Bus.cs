using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;
using Bizu.Application.General;


namespace Bizu.Application.General
{
    public class tb_sis_Param_Cont_Tipo_Contabilizacion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        tb_sis_Param_Cont_Tipo_Contabilizacion_Data data = new tb_sis_Param_Cont_Tipo_Contabilizacion_Data();
        public List<tb_sis_Param_Cont_Tipo_Contabilizacion_Info> ConsultarParamConta() {
            try
            {
                return data.ConsultarParamConta();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultarParamConta", ex.Message), ex) { EntityType = typeof(tb_sis_Param_Cont_Tipo_Contabilizacion_Bus) };
                   
            }
        }

        public String ConsEspeParamConta(String idConta) {
            try
            {
                return data.ConsEspeParamConta(idConta);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsEspeParamConta", ex.Message), ex) { EntityType = typeof(tb_sis_Param_Cont_Tipo_Contabilizacion_Bus) };
                   
            }
        }

        
    }
}
