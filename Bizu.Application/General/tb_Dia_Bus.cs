using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;
using Bizu.Application.General;


namespace Bizu.Application.General
{
    public class tb_Dia_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        tb_Dia_Data dbDia = new tb_Dia_Data();
        public List<tb_Dia_Info> Get_List_Dia()
        {
            try
            {
                 return dbDia.Get_List_Dia();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaGeneralDia", ex.Message), ex) { EntityType = typeof(tb_Dia_Bus) };
                ;
            }

        }
    }
}
