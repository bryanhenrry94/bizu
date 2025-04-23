using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.Inventario
{
    public class XINV_Rpt042_Bus
    {
        XINV_Rpt042_Data data = new XINV_Rpt042_Data();

        public List<XINV_Rpt042_Info> Get_Kardes_Movimiento(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin, decimal IdProductoIni, decimal IdProductoFin, string IdCentroCosto, string IdSubCentroCosto, int IdMov_inven_tipoIni, int IdMov_inven_tipoFin, string TipoMov, DateTime FechaIni, DateTime FechaFin, string IdCategoria, Int32 IdLinea)
        {
            try
            {
                return data.Get_Kardes_Movimiento(IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, IdProductoIni, IdProductoFin, IdCentroCosto, IdSubCentroCosto, IdMov_inven_tipoIni, IdMov_inven_tipoFin, TipoMov, FechaIni, FechaFin,IdCategoria,IdLinea);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<XINV_Rpt042_Info> Get_Kardes_Movimiento(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin, decimal IdProductoIni, decimal IdProductoFin, string IdCentroCosto, string IdSubCentroCosto, int IdMov_inven_tipoIni, int IdMov_inven_tipoFin, string TipoMov, DateTime FechaIni, DateTime FechaFin, string IdCategoria, List<Int32?> IdLineaList, Boolean Considerar_saldo_inicial)
        {
            try
            {
                return data.Get_Kardes_Movimiento(IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, IdProductoIni, IdProductoFin, IdCentroCosto, IdSubCentroCosto, IdMov_inven_tipoIni, IdMov_inven_tipoFin, TipoMov, FechaIni, FechaFin, IdCategoria, IdLineaList, Considerar_saldo_inicial);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<XINV_Rpt042_Info> Get_Kardes_Movimiento(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin, decimal IdProductoIni, decimal IdProductoFin, string IdCentroCosto, string IdSubCentroCosto, List<Int32?> IdMov_inven_tipo_list, string TipoMov, DateTime FechaIni, DateTime FechaFin, string IdCategoria, List<Int32?> IdLineaList, Boolean Considerar_saldo_inicial)
        {
            try
            {
                return data.Get_Kardes_Movimiento(IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, IdProductoIni, IdProductoFin, IdCentroCosto, IdSubCentroCosto, IdMov_inven_tipo_list, TipoMov, FechaIni, FechaFin, IdCategoria, IdLineaList, Considerar_saldo_inicial);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
       
    }
}
