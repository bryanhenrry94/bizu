using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;

namespace Core.Erp.Business.Inventario
{
    public class in_Ing_Egr_Inven_x_in_RequerimientoMaterial_Bus
    {
        in_Ing_Egr_Inven_x_in_RequerimientoMaterial_Data Data = new in_Ing_Egr_Inven_x_in_RequerimientoMaterial_Data();

        public Boolean GrabarDB(in_Ing_Egr_Inven_x_in_RequerimientoMaterial_Info Info, ref string mensaje)
        {
            try
            {
                return Data.GrabarDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean ModificarDB(in_Ing_Egr_Inven_x_in_RequerimientoMaterial_Info Info, ref string mensaje)
        {
            try
            {
                return Data.ModificarDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public in_Ing_Egr_Inven_x_in_RequerimientoMaterial_Info Get_Info(int IdEmpresa, int IdSucursal, int IdMovi_inven_tipo, decimal IdNumMovi, ref string mensaje)
        {
            try
            {
                return Data.Get_Info(IdEmpresa, IdSucursal, IdMovi_inven_tipo, IdNumMovi, ref mensaje);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
