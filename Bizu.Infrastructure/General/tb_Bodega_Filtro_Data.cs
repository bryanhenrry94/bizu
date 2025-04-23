using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.General;

namespace Bizu.Infrastructure.General
{
    public class tb_Bodega_Filtro_Data
    {
        public bool GrabarBD(List<tb_Bodega_Filtro_Info> List)
        {
            try
            {
                using(EntitiesGeneral Context = new EntitiesGeneral())
                {
                    if(List.Count() > 0)
                    {
                        string IdUsuario = "";

                        IdUsuario = List.FirstOrDefault().IdUsuario;

                        Context.Database.ExecuteSqlCommand("DELETE FROM tb_bodega_Filtro WHERE IdUsuario = '" + IdUsuario + "'");

                        foreach(var item in List)
                        {
                            tb_bodega_Filtro Address = new tb_bodega_Filtro();
                            Address.IdEmpresa = item.IdEmpresa;
                            Address.IdSucursal = item.IdSucursal;
                            Address.IdBodega = item.IdBodega;
                            Address.IdUsuario = item.IdUsuario;

                            Context.tb_bodega_Filtro.Add(Address);
                            Context.SaveChanges();
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
