using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.ActivoFijo;
using Bizu.Infrastructure.ActivoFijo;
using Bizu.Application.General;

namespace Bizu.Application.ActivoFijo
{
    public class Af_Activo_fijo_CtasCbles_Tipo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<Af_Activo_fijo_CtasCbles_Tipo_Info> Get_List_Activo_fijo_CtasCbles_Tipo()
        {
            List<Af_Activo_fijo_CtasCbles_Tipo_Info> lM = new List<Af_Activo_fijo_CtasCbles_Tipo_Info>();
            Af_Activo_fijo_CtasCbles_Tipo_Data data = new Af_Activo_fijo_CtasCbles_Tipo_Data();
            try
            {

                lM = data.Get_List_Activo_fijo_CtasCbles_Tipo();
                return (lM);
            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Activo_fijo_CtasCbles_Tipo", ex.Message), ex) { EntityType = typeof(Af_Activo_fijo_CtasCbles_Tipo_Bus) };
            }
        }
    }
}
