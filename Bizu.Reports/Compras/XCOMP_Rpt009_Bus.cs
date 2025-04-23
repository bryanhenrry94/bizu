using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Application.General;
using Bizu.Domain.General;

namespace Bizu.Reports.Compras
{
    public class XCOMP_Rpt009_Bus
    {
        XCOMP_Rpt009_Data odata = new XCOMP_Rpt009_Data();

        public List<XCOMP_Rpt009_Info> Cargar_data(int IdEmpresa, int IdSucursal, decimal IdProducto, string IdCentroCosto, DateTime FechaIni, DateTime FechaFin)
        {
            List<XCOMP_Rpt009_Info> list;
            try
            {
                list = this.odata.Cargar_data(IdEmpresa, IdSucursal, IdProducto, IdCentroCosto, FechaIni, FechaFin);
            }
            catch (Exception exception)
            {
                new tb_sis_Log_Error_Vzen_Bus().Log_Error(exception.ToString());
                throw new Exception(exception.ToString());
            }
            return list;
        }
    }
}
