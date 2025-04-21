using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Contabilidad
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