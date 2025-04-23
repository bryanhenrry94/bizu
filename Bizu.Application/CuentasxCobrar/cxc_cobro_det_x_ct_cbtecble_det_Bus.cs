using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bizu.Domain.CuentasxCobrar;
using Bizu.Infrastructure.CuentasxCobrar;
using Bizu.Application.General;


namespace Bizu.Application.CuentasxCobrar
{
   public class cxc_cobro_det_x_ct_cbtecble_det_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        cxc_cobro_det_x_ct_cbtecble_det_Data oData = new cxc_cobro_det_x_ct_cbtecble_det_Data();

        public Boolean GuardarDB(cxc_cobro_det_x_ct_cbtecble_det_Info info)
        {
            try
            {
                return oData.GuardarDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_cobro_x_ct_cbtecble", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_ct_cbtecble_Bus) };
            }
        }

    
    }
}
