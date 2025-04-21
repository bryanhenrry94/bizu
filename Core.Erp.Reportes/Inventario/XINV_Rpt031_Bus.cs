using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt031_Bus
    {
        XINV_Rpt031_Data oData = new XINV_Rpt031_Data();

        public List<XINV_Rpt031_Info> Get_list(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, int IdMarca, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                return oData.Get_list(IdEmpresa, IdSucursal, IdBodega, IdProducto, IdMarca, Fecha_ini, Fecha_fin);
            }
            catch (Exception)
            {
                return new List<XINV_Rpt031_Info>();
            }
        }

        public List<XINV_Rpt031_Info> Get_list(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto, List<Int32> IdMarca_List, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                return oData.Get_list(IdEmpresa, IdSucursal, IdBodega, IdProducto, IdMarca_List, Fecha_ini, Fecha_fin);
            }
            catch (Exception)
            {
                return new List<XINV_Rpt031_Info>();
            }
        }

        public List<XINV_Rpt031_Info> Get_list_(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {
                return oData.Get_list_(IdEmpresa, IdSucursal, IdBodega);
            }
            catch (Exception)
            {
                return new List<XINV_Rpt031_Info>();
            }
        }
    }
}
