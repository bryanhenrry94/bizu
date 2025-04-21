using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_proveedor_x_tb_ciiu_Data
    {
        public bool GrabarActividadEconomica(cp_proveedor_x_tb_ciiu_Info Info)
        {
            try
            {
                EntitiesCuentasxPagar dbContext = new EntitiesCuentasxPagar();

                var nuevoRegistro = new cp_proveedor_x_tb_ciiu
                {
                    IdEmpresa = Info.IdEmpresa,
                    IdProveedor = Info.IdProveedor,
                    Id = Info.Id
                };

                dbContext.cp_proveedor_x_tb_ciiu.Add(nuevoRegistro);

                dbContext.SaveChanges();

                return true;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<cp_proveedor_x_tb_ciiu_Info> GetList(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                List<cp_proveedor_x_tb_ciiu_Info> Lista = new List<cp_proveedor_x_tb_ciiu_Info>();

                EntitiesCuentasxPagar dbContext = new EntitiesCuentasxPagar();

                var resultado = dbContext.cp_proveedor_x_tb_ciiu
                            .Where(cpxtc => cpxtc.IdEmpresa == IdEmpresa && cpxtc.IdProveedor == IdProveedor)
                            .ToList();

                foreach (var item in resultado)
                {
                    cp_proveedor_x_tb_ciiu_Info Info = new cp_proveedor_x_tb_ciiu_Info();

                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdProveedor = item.IdProveedor;
                    Info.Id = item.Id;

                    Lista.Add(Info);
                }


                return Lista;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool ExisteDB(int IdEmpresa, decimal IdProveedor, int Id)
        {
            try
            {
                List<cp_proveedor_x_tb_ciiu_Info> Lista = new List<cp_proveedor_x_tb_ciiu_Info>();

                EntitiesCuentasxPagar dbContext = new EntitiesCuentasxPagar();

                var resultado = dbContext.cp_proveedor_x_tb_ciiu
                            .Where(cpxtc => cpxtc.IdEmpresa == IdEmpresa && cpxtc.IdProveedor == IdProveedor && cpxtc.Id == Id)
                            .ToList();

                if (resultado.Count > 0)
                    return true;
                else
                    return false;

            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool EliminarBD(int IdEmpresa, decimal IdProveedor, int Id)
        {
            try
            {
                // Obtén el contexto de la base de datos
                using (var dbContext = new EntitiesCuentasxPagar())
                {
                    // Encuentra la entidad que deseas eliminar
                    var entidadAEliminar = dbContext.cp_proveedor_x_tb_ciiu
                        .Where(cpxtc => cpxtc.IdEmpresa == IdEmpresa && cpxtc.IdProveedor == IdProveedor && cpxtc.Id == Id)
                        .FirstOrDefault();

                    if (entidadAEliminar != null)
                    {
                        // Elimina la entidad del contexto y luego confirma los cambios en la base de datos
                        dbContext.cp_proveedor_x_tb_ciiu.Remove(entidadAEliminar);
                        dbContext.SaveChanges();
                    }

                    return true;
                }
            }
            catch(Exception ex) {
                throw ex;
            }
        }
    }
}
