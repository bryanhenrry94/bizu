using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Reports.Contabilidad;

namespace Bizu.Reports.Contabilidad
{
    public class XCONTA_Rpt004_Bus
    {

        
        string mensaje = "";

        private XCONTA_Rpt004_Data oData = new XCONTA_Rpt004_Data();

        public List<XCONTA_Rpt004_Info> GetListConsultaGeneral(int idEmpresa, ref string msg)
        {
            try
            {
                return oData.GetListConsultaGeneral(idEmpresa, ref msg);
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
