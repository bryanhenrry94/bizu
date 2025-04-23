using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Application.General;
using Bizu.Domain.General;


namespace Bizu.Reports.ActivoFijo
{
    public class XACTF_Rpt008_Bus
    {
        XACTF_Rpt008_Data dataRpt = new XACTF_Rpt008_Data();

        public List<XACTF_Rpt008_Info> get_RptRetiro_AF(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return dataRpt.get_RptRetiro_AF(IdEmpresa, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
                oLog.Log_Error(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }

        public XACTF_Rpt008_Bus()
        {

        }
    }
}
