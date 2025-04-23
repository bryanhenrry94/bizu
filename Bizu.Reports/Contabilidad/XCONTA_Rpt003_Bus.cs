using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Application.General;
using Bizu.Domain.General;


namespace Bizu.Reports.Contabilidad
{
  public  class XCONTA_Rpt003_Bus
    {
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
      
      XCONTA_Rpt003_Data Odata = new XCONTA_Rpt003_Data();

      string mensaje = "";

      public List<XCONTA_Rpt003_Info> consultar_data(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble, ref String mensaje)
        {
            try
            {
                return Odata.consultar_data(IdEmpresa, IdTipoCbte,  IdCbteCble, ref  mensaje);
            }

            catch (Exception ex)
            {

                tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
                oLog.Log_Error(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }

    }
}
