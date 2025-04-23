using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bizu.Reports.CuentasxCobrar
{
    public class XCXC_Rpt006_Bus
    {
        XCXC_Rpt006_Data dataRpt = new XCXC_Rpt006_Data();

        public List<XCXC_Rpt006_Info> get_RptCobros(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, decimal IdClienteIni, decimal IdClienteFin, DateTime FechaIni, DateTime FechaHasta, List<string> IdTipoCobro, string TipoFecha, Boolean fechFilt)
        {
            try
            {
                return dataRpt.get_RptCobros(IdEmpresa, IdSucursalIni, IdSucursalFin, IdClienteIni, IdClienteFin, FechaIni, FechaHasta, IdTipoCobro, TipoFecha, fechFilt);
            }
            catch (Exception)
            {
                return new List<XCXC_Rpt006_Info>();
            }
        }

        public XCXC_Rpt006_Bus()
        {

        }
    } 
}
