using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Application.Contabilidad;
using Bizu.Domain.Contabilidad;
using Bizu.Application.General;
using Bizu.Domain.General;

namespace Bizu.Reports.Contabilidad
{
    public class XCONTA_Rpt024_Bus
    {
        public XCONTA_Rpt024_Bus()
        {

        }

        XCONTA_Rpt024_Data Odata = new XCONTA_Rpt024_Data();

        public List<XCONTA_Rpt024_Info> consultar_data(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return Odata.consultar_data(IdEmpresa, FechaIni, FechaFin);
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