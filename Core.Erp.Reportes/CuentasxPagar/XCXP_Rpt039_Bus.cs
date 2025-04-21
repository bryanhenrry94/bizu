using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt039_Bus
    {
        XCXP_Rpt039_Data estadodata = new XCXP_Rpt039_Data();


        public List<XCXP_Rpt039_Info> consultar_data(int IdEmpresa, Decimal IdProveedor, DateTime co_fechaOg_Ini, DateTime co_fechaOg_Fin, ref String mensaje)
        {
            try
            {
                return estadodata.consultar_data(IdEmpresa, IdProveedor, co_fechaOg_Ini, co_fechaOg_Fin, ref  mensaje);

            }
            catch (Exception ex)
            {
                return new List<XCXP_Rpt039_Info>();
            }
        }

        public XCXP_Rpt039_Bus()
        {
        }
    }
}
