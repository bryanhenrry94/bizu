using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bizu.Domain.CuentasxPagar;
using Bizu.Infrastructure.CuentasxPagar;

using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure.Contabilidad;

using Bizu.Application.General;


namespace Bizu.Application.CuentasxPagar
{
  public  class cp_Aprobacion_Ing_Bod_x_OC_Eliminados_Bus
    {

        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cp_Aprobacion_Ing_Bod_x_OC_Eliminados_Data odata = new cp_Aprobacion_Ing_Bod_x_OC_Eliminados_Data();

        public Boolean GuardarDB(cp_Aprobacion_Ing_Bod_x_OC_Eliminados_Info Info,  ref string msg)
        {
            try
            {
                Boolean res = true;
                res = odata.GuardarDB(Info,  ref msg);
                return res;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Ing_Bod_x_OC_Bus) };
            }
        }


    }
}
