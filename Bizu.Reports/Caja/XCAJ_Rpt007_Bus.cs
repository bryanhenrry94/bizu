using Bizu.Application.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.Caja
{
    public class XCAJ_Rpt007_Bus
    {
        XCAJ_Rpt007_Data oData = new XCAJ_Rpt007_Data();

        public List<XCAJ_Rpt007_Info> Get_list_reporte(int IdEmpresa, int IdCaja)
        {
            try
            {
                return oData.Get_list_reporte(IdEmpresa, IdCaja);
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