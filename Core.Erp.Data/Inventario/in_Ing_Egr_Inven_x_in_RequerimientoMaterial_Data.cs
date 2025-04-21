using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Data.Inventario
{
    public class in_Ing_Egr_Inven_x_in_RequerimientoMaterial_Data
    {
        public Boolean GrabarDB(in_Ing_Egr_Inven_x_in_RequerimientoMaterial_Info Info, ref string mensaje)
        {
            try
            {
                EntitiesInventario Context = new EntitiesInventario();

                in_Ing_Egr_Inven_x_in_RequerimientoMaterial Address = new in_Ing_Egr_Inven_x_in_RequerimientoMaterial();
                Address.IdEmpresa = Info.IdEmpresa;
                Address.IdSucursal = Info.IdSucursal;
                Address.IdMovi_inven_tipo = Info.IdMovi_inven_tipo;
                Address.IdNumMovi = Info.IdNumMovi;
                Address.IdBodega = Info.IdBodega;
                Address.Num_Requerimiento = Info.Num_Requerimiento;

                Context.in_Ing_Egr_Inven_x_in_RequerimientoMaterial.Add(Address);
                Context.SaveChanges();

                return true;
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
                EntitiesInventario Context = new EntitiesInventario();

                in_Ing_Egr_Inven_x_in_RequerimientoMaterial Address = (from q in Context.in_Ing_Egr_Inven_x_in_RequerimientoMaterial
                              where q.IdEmpresa == Info.IdEmpresa
                              && q.IdSucursal == Info.IdSucursal
                              && q.IdMovi_inven_tipo == Info.IdMovi_inven_tipo
                              && q.IdNumMovi == Info.IdNumMovi
                               select q).FirstOrDefault();

                if (Address != null)
                {                    
                    Address.IdBodega = Info.IdBodega;
                    Address.Num_Requerimiento = Info.Num_Requerimiento;
                    
                    Context.SaveChanges();
                }
                else
                {
                    GrabarDB(Info, ref mensaje);
                }                

                return true;
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
                EntitiesInventario Context = new EntitiesInventario();
                in_Ing_Egr_Inven_x_in_RequerimientoMaterial_Info Info = new in_Ing_Egr_Inven_x_in_RequerimientoMaterial_Info();

                in_Ing_Egr_Inven_x_in_RequerimientoMaterial Address = (from q in Context.in_Ing_Egr_Inven_x_in_RequerimientoMaterial
                            where q.IdEmpresa == IdEmpresa
                            && q.IdSucursal == IdSucursal
                            && q.IdMovi_inven_tipo == IdMovi_inven_tipo
                            && q.IdNumMovi == IdNumMovi
                            select q).FirstOrDefault();

                if (Address != null)
                {
                    Info.IdEmpresa = Address.IdEmpresa;
                    Info.IdSucursal = Address.IdSucursal;
                    Info.IdMovi_inven_tipo = Address.IdMovi_inven_tipo;
                    Info.IdNumMovi = Address.IdNumMovi;
                    Info.IdBodega = Address.IdBodega;
                    Info.Num_Requerimiento = Address.Num_Requerimiento;
                }

                return Info;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
