using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;

namespace Core.Erp.Business.Inventario
{
    public class in_Ing_Egr_Inven_x_in_GuiaRemision_Bus
    {
        in_Ing_Egr_Inven_x_in_GuiaRemision_Data Data = new in_Ing_Egr_Inven_x_in_GuiaRemision_Data();

        public bool Grabar(in_Ing_Egr_Inven_x_in_GuiaRemision_Info Info, ref string mensaje)
        {
            try
            {
                return Data.Grabar(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Existe(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision)
        {
            try
            {
                return Data.Existe(IdEmpresa, IdSucursal, IdGuiaRemision);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Delete(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision)
        {
            try
            {
                return Data.Delete(IdEmpresa, IdSucursal, IdGuiaRemision);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public in_Ing_Egr_Inven_x_in_GuiaRemision_Info Get(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision)
        {
            try
            {
                return Data.Get(IdEmpresa, IdSucursal, IdGuiaRemision);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
