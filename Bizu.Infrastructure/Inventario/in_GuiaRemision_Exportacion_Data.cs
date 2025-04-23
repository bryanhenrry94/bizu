using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.Inventario;

namespace Bizu.Infrastructure.Inventario
{
    public class in_GuiaRemision_Exportacion_Data
    {
        public Boolean Existe(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision)
        {
            try
            {
                EntitiesInventario Context = new EntitiesInventario();

                var query = from q in Context.in_GuiaRemision_Exportacion
                            where q.IdEmpresa == IdEmpresa
                            && q.IdSucursal == IdSucursal
                            && q.IdGuiaRemision == IdGuiaRemision
                            select q;

                if (query.Count() == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean EliminarDB(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision)
        {
            try
            {
                EntitiesInventario Context = new EntitiesInventario();
                int filasAfectadas = 0;

                filasAfectadas = Context.Database.ExecuteSqlCommand("delete from in_GuiaRemision_Exportacion where IdEmpresa = " + IdEmpresa + " and IdSucursal = " + IdSucursal + " and IdGuiaRemision = " + IdGuiaRemision);
               
                if (filasAfectadas == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean GrabarDB(in_GuiaRemision_Exportacion_Info Info)
        {
            try
            {
                EntitiesInventario Context = new EntitiesInventario();

                in_GuiaRemision_Exportacion Address = new in_GuiaRemision_Exportacion();
                Address.IdEmpresa = Info.IdEmpresa;
                Address.IdSucursal = Info.IdSucursal;
                Address.IdGuiaRemision = Info.IdGuiaRemision;
                Address.EmbarqueTipo = Info.EmbarqueTipo;
                Address.Ruta = Info.Ruta;
                Address.Contenedor = Info.Contenedor;
                Address.Sello = Info.Sello;
                Address.Vapor = Info.Vapor;
                Address.Embalaje = Info.Embalaje;
                Address.PesoNeto = Info.PesoNeto;
                Address.PesoBruto = Info.PesoBruto;
                Address.Exportador_nombre = Info.Exportador_nombre;
                Address.Exportador_direccion = Info.Exportador_direccion;
                Address.Exportador_correo = Info.Exportador_correo;
                Address.Exportador_telefono = Info.Exportador_telefono;
                Address.Exportador_fax = Info.Exportador_fax;
                Address.Comprador_nombre = Info.Comprador_nombre;
                Address.Comprador_direccion = Info.Comprador_direccion;
                Address.Comprador_correo = Info.Comprador_correo;
                Address.Comprador_telefono = Info.Comprador_telefono;
                Address.Comprador_fax = Info.Comprador_fax;

                Context.in_GuiaRemision_Exportacion.Add(Address);
                Context.SaveChanges();
                
                return true;                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public in_GuiaRemision_Exportacion_Info Get_Info(int IdEmpresa, int IdSucursal, decimal IdGuiaRemision)
        {          
            try
            {
                EntitiesInventario Context = new EntitiesInventario();

                in_GuiaRemision_Exportacion Address = (from q in Context.in_GuiaRemision_Exportacion
                                                       where q.IdEmpresa == IdEmpresa
                                                       && q.IdSucursal == IdSucursal
                                                       && q.IdGuiaRemision == IdGuiaRemision
                                                       select q).FirstOrDefault();

                if (Address != null)
                {
                    in_GuiaRemision_Exportacion_Info Info = new in_GuiaRemision_Exportacion_Info();
                    Info.IdEmpresa = Address.IdEmpresa;
                    Info.IdSucursal = Address.IdSucursal;
                    Info.IdGuiaRemision = Address.IdGuiaRemision;
                    Info.EmbarqueTipo = Address.EmbarqueTipo;
                    Info.Ruta = Address.Ruta;
                    Info.Contenedor = Address.Contenedor;
                    Info.Sello = Address.Sello;
                    Info.Vapor = Address.Vapor;
                    Info.Embalaje = Address.Embalaje;
                    Info.PesoNeto = Address.PesoNeto;
                    Info.PesoBruto = Address.PesoBruto;
                    Info.Exportador_nombre = Address.Exportador_nombre;
                    Info.Exportador_direccion = Address.Exportador_direccion;
                    Info.Exportador_correo = Address.Exportador_correo;
                    Info.Exportador_telefono = Address.Exportador_telefono;
                    Info.Exportador_fax = Address.Exportador_fax;
                    Info.Comprador_nombre = Address.Comprador_nombre;
                    Info.Comprador_direccion = Address.Comprador_direccion;
                    Info.Comprador_correo = Address.Comprador_correo;
                    Info.Comprador_telefono = Address.Comprador_telefono;
                    Info.Comprador_fax = Address.Comprador_fax;

                    return Info;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }
    }
}
