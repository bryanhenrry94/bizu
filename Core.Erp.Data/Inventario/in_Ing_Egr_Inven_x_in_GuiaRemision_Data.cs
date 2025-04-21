using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Data.Inventario
{
    public class in_Ing_Egr_Inven_x_in_GuiaRemision_Data
    {
        public bool Grabar(in_Ing_Egr_Inven_x_in_GuiaRemision_Info Info, ref string mensaje)
        {
            try
            {
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    in_Ing_Egr_Inven_x_in_GuiaRemision Address = new in_Ing_Egr_Inven_x_in_GuiaRemision();
                    Address.IdEmpresa = Info.IdEmpresa;
                    Address.IdSucursal = Info.IdSucursal;
                    Address.IdMovi_inven_tipo = Info.IdMovi_inven_tipo;
                    Address.IdNumMovi = Info.IdNumMovi;
                    Address.IdGuiaRemision = Info.IdGuiaRemision;

                    Context.in_Ing_Egr_Inven_x_in_GuiaRemision.Add(Address);
                    Context.SaveChanges();

                    mensaje = "registro generado con éxito!";

                    return true;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                throw new Exception(ex.Message);
            }
        }

        public bool Existe(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision)
        {
            try
            {
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var query = from q in Context.in_Ing_Egr_Inven_x_in_GuiaRemision
                                where q.IdEmpresa == IdEmpresa
                                && q.IdSucursal == IdSucursal
                                && q.IdGuiaRemision == IdGuiaRemision
                                select q;

                    if (query.Count() > 0)                    
                        return true;                    
                    else
                        return false;                                        
                }
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
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    int iFilasAfectadas = Context.Database.ExecuteSqlCommand("DELETE FROM in_Ing_Egr_Inven_x_in_GuiaRemision WHERE IdEmpresa = " + IdEmpresa + " AND IdSucursal = " + IdSucursal + " AND IdGuiaRemision = " + IdGuiaRemision);

                    if (iFilasAfectadas > 0)
                        return true;
                    else
                        return false;
                }
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
                in_Ing_Egr_Inven_x_in_GuiaRemision_Info Info = new in_Ing_Egr_Inven_x_in_GuiaRemision_Info();

                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var query = from q in Context.in_Ing_Egr_Inven_x_in_GuiaRemision
                                where q.IdEmpresa == IdEmpresa
                                && q.IdSucursal == IdSucursal
                                && q.IdGuiaRemision == IdGuiaRemision
                                select q;

                    foreach (var item in query)
                    {
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdSucursal = item.IdSucursal;
                        Info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        Info.IdNumMovi = item.IdNumMovi;
                        Info.IdGuiaRemision = item.IdGuiaRemision;
                    }
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
