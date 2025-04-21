using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt016_Bus
    {
        XACTF_Rpt016_Data oData = new XACTF_Rpt016_Data();

        public List<XACTF_Rpt016_Info> Consultar_Data(int IdEmpresa, int IdActivoFijo)
        {
            try
            {
                return oData.Consultar_Data(IdEmpresa, IdActivoFijo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
