using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.CuentasxPagar;
using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Application.General;

namespace Bizu.Application.CuentasxPagar
{
    public class cp_proveedor_Calificacion_Bus
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_proveedor_Calificacion_Data Data = new cp_proveedor_Calificacion_Data();

        public Boolean Anular(cp_proveedor_Calificacion_Info Info)
        {
            try
            {
                return Data.Anular(Info);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Grabar(List<cp_proveedor_Calificacion_Info> List_Info)
        {
            try
            {
                foreach (var item in List_Info)
                {
                    if (item.Modificado)
                    {                                                                                                                      
                        if (Data.Existe(item))
                        {                            
                            item.IdUsuarioModificacion = param.IdUsuario;
                            item.FechaModificacion = param.Fecha_Transac;
                            item.FechaTransaccion = param.Fecha_Transac;                            

                            Data.Modificar(item);
                        }
                        else
                        {
                            item.IdEmpresa = param.IdEmpresa;                            
                            item.IdUsuario = param.IdUsuario;
                            item.FechaCreacion = param.Fecha_Transac;
                            item.Estado = "A";
                            item.FechaTransaccion = param.Fecha_Transac;
                            item.FechaCreacion = DateTime.Now;

                            Data.Grabar(item);
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Grabar(cp_proveedor_Calificacion_Info Info)
        {
            try
            {
                return Data.Grabar(Info);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<cp_proveedor_Calificacion_Info> Get(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                return Data.Get(IdEmpresa, IdProveedor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public List<cp_proveedor_Calificacion_Info> GetAll(int IdEmpresa)
        {
            try
            {
                return Data.GetAll(IdEmpresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<cp_proveedor_Calificacion_Info> GetAll_Liberar(int IdEmpresa)
        {
            try
            {
                return Data.GetAll_Liberar(IdEmpresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
