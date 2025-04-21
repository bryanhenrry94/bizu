using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Compras
{
    public class XCOMP_Rpt013_Bus
    {
        XCOMP_Rpt013_Data odata = new XCOMP_Rpt013_Data();

        public List<XCOMP_Rpt013_Info> Cargar_data(int IdEmpresa, int IdSucursal,
                        decimal IdProducto,
                        int IdProveedor,
                        string IdCategoria,
                        int IdLinea,
                        string IdCentroCosto,
                        DateTime FechaIni,
                        DateTime FechaFin)
        {
            try
            {
                return odata.Cargar_data(IdEmpresa, IdSucursal, IdProducto, IdProveedor, IdCategoria, IdLinea, IdCentroCosto, FechaIni, FechaFin);
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