using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.CuentasxCobrar
{
    public class XCXC_Rpt019_Bus
    {
        XCXC_Rpt019_Data RptData = new XCXC_Rpt019_Data();

        public List<XCXC_Rpt019_Info> getDatosCobros(int IdEmpresa, int IdSucursal, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                return RptData.getDatosCobros(IdEmpresa, IdSucursal, fechaIni, fechaFin);
            }
            catch (Exception ex)
            {
                return new List<XCXC_Rpt019_Info>();
            }
        }
    }
}
