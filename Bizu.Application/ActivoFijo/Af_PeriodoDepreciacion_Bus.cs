using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.ActivoFijo;
using Bizu.Infrastructure.ActivoFijo;
using Bizu.Application.General;

namespace Bizu.Application.ActivoFijo
{
    public class Af_PeriodoDepreciacion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        public List<Af_PeriodoDepreciacion_Info> Get_List_PeriodoDepreciacion()
        {
            List<Af_PeriodoDepreciacion_Info> lM = new List<Af_PeriodoDepreciacion_Info>();
            Af_PeriodoDepreciacion_Data data = new Af_PeriodoDepreciacion_Data();
            try
            {
                lM = data.Get_List_PeriodoDepreciacion();
                return (lM);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_PeriodoDepreciacion", ex.Message), ex) { EntityType = typeof(Af_PeriodoDepreciacion_Bus) };
            }
        }

    }
}
