using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Compras
{
    public class XCOMP_Rpt011_Bus
    {
        XCOMP_Rpt011_Data odata = new XCOMP_Rpt011_Data();

        public List<XCOMP_Rpt011_Info> Cargar_data(int IdEmpresa, int IdSucursal, int IdProveedor, string IdCentroCosto, DateTime Fecha_Desde, DateTime Fecha_Hasta)
        {
            try
            {
                return odata.Cargar_data(IdEmpresa, IdSucursal, IdProveedor, IdCentroCosto, Fecha_Desde, Fecha_Hasta);
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