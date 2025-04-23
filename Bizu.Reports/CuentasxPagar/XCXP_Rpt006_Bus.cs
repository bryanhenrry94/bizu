using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bizu.Reports.CuentasxPagar
{
    public class XCXP_Rpt006_Bus
    {
        XCXP_Rpt006_Data NCPROVEE = new XCXP_Rpt006_Data();

        public List<XCXP_Rpt006_Info> consultar_data(int IdEmpresa, decimal IdCbteCble_Nota, ref List<XCXP_Rpt006_Info_Resumen> list_Resumen_ret, ref string mensaje)
        {
            try
            {
                return NCPROVEE.consultar_data(IdEmpresa, IdCbteCble_Nota, ref list_Resumen_ret, ref mensaje);
            }
            catch (Exception ex)
            {

                return new List<XCXP_Rpt006_Info>();
            }
        }
        public XCXP_Rpt006_Bus()
        {
        }

    }
}
