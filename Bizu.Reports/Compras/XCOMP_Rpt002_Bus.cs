using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bizu.Reports.Compras
{
    public class XCOMP_Rpt002_Bus
    {
        XCOMP_Rpt002_Data OCdata = new XCOMP_Rpt002_Data();


        public List<XCOMP_Rpt002_Info> consultar_data(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra, ref string mensaje)
        {
            try
            {
                return OCdata.consultar_data(IdEmpresa, IdSucursal, IdSolicitudCompra);
            }
            catch (Exception ex)
            {
                return new List<XCOMP_Rpt002_Info>();
            }
        }

        public XCOMP_Rpt002_Bus()
        {

        }
    }
}

