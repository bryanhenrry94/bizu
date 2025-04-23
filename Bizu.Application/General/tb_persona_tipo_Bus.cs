using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;
using Bizu.Application.General;

namespace Bizu.Application.General
{
    public class tb_persona_tipo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        tb_persona_tipo_Data odata = new tb_persona_tipo_Data();

        public List<tb_persona_tipo_Info> Get_List_persona_tipo()
        {
            try
            {
                return odata.Get_List_persona_tipo();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaLista_PersonaTipo", ex.Message), ex) { EntityType = typeof(tb_persona_tipo_Bus) };

            }
        }
    }
}