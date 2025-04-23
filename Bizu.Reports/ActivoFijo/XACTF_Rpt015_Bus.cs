using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Application.General;
using Bizu.Domain.General;

namespace Bizu.Reports.ActivoFijo
{
    public class XACTF_Rpt015_Bus
    {
        XACTF_Rpt015_Data dataRpt = new XACTF_Rpt015_Data();

        public List<XACTF_Rpt015_Info> get_RptCompraSinIngreso_AF(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return dataRpt.get_RptCompraSinIngreso_AF(IdEmpresa, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
                oLog.Log_Error(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }


        public XACTF_Rpt015_Bus()
        {

        }
    }
}
