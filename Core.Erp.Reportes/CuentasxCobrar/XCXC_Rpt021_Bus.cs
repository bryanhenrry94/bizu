using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt021_Bus
    {
        XCXC_Rpt021_Data dataRpt = new XCXC_Rpt021_Data();

        public List<XCXC_Rpt021_Info> Get_Data(int IdEmpresa, int IdSucursal, decimal   IdCliente)
        {
            try
            {
                return dataRpt.Get_Data(IdEmpresa, IdSucursal, IdCliente);
            }
            catch (Exception)
            {
                return new List<XCXC_Rpt021_Info>();
            }
        }

        public XCXC_Rpt021_Bus()
        {

        }
    }
}
