using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Application.General;
using Bizu.Domain.General;

namespace Bizu.Reports.Bancos
{
   public  class XBAN_Rpt001_Bus
    {
       XBAN_Rpt001_Data odata = new XBAN_Rpt001_Data();


       public List<XBAN_Rpt001_Info> Cargar_data(int idempresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return odata.Cargar_data(idempresa, FechaIni, FechaFin);
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
