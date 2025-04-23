using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bizu.Application.General;
using Bizu.Domain.General;


namespace Bizu.Reports.ActivoFijo
{
    public class XACTF_Rpt004_Bus
    {
        XACTF_Rpt004_Data dataRpt = new XACTF_Rpt004_Data();

        public List<XACTF_Rpt004_Info> get_Rpt_DepreMensual(int IdEmpresa, int IdTipoDepreciacion, int IdActivoFijo, int IdPeriodoIni, int IdPeiodoFin)
        {
            try
            {
                return dataRpt.get_Rpt_DepreMensual(IdEmpresa, IdTipoDepreciacion, IdActivoFijo, IdPeriodoIni, IdPeiodoFin);
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
                oLog.Log_Error(ex.ToString());
                throw new Exception(ex.ToString());
            }
        }


        public XACTF_Rpt004_Bus()
        {

        }
    }
}
