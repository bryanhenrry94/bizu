using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt020_Bus
    {
        XCXC_Rpt020_Data dataRpt = new XCXC_Rpt020_Data();

        public List<XCXC_Rpt020_Info> get_RptCobros(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, decimal IdClienteIni, decimal IdClienteFin, DateTime FechaIni, DateTime FechaHasta, List<string> IdTipoCobro)
        {
            try
            {
                return dataRpt.get_RptCobros(IdEmpresa, IdSucursalIni, IdSucursalFin, IdClienteIni, IdClienteFin, FechaIni, FechaHasta, IdTipoCobro);
            }
            catch (Exception)
            {
                return new List<XCXC_Rpt020_Info>();
            }
        }

        public XCXC_Rpt020_Bus()
        {

        }
    }
}
