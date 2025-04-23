using Bizu.Domain.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Infrastructure.CuentasxPagar
{
    public class cp_proveedor_datos_acreditacion_Data
    {
        public List<cp_proveedor_datos_acreditacion_Info> GetList(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                List<cp_proveedor_datos_acreditacion_Info> miLista = new List<cp_proveedor_datos_acreditacion_Info>();

                EntitiesCuentasxPagar dbContext = new EntitiesCuentasxPagar();

                var query = dbContext.cp_proveedor_datos_acreditacion
                    .Where(q => q.IdEmpresa == IdEmpresa && q.IdProveedor == IdProveedor).ToList();

                foreach(var item in query)
                {
                    cp_proveedor_datos_acreditacion_Info Info = new cp_proveedor_datos_acreditacion_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdProveedor = item.IdProveedor;
                    Info.Secuencia = item.Secuencia;
                    Info.IdBanco = item.IdBanco;
                    Info.IdTipoCuenta = item.IdTipoCuenta;
                    Info.NumeroCuenta = item.NumeroCuenta;
                    Info.IdTipoIdentificacion = item.IdTipoIdentificacion;
                    Info.Identificacion = item.Identificacion;
                    Info.Beneficiario = item.Beneficiario;
                    Info.Correo = item.Correo;
                    Info.Predefinida = item.Predefinida;

                    // llena la lista que luego se devuelve en el return
                    miLista.Add(Info);
                }

                return miLista;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool EliminarBD(int IdEmpresa, decimal IdProveedor, int Secuencia)
        {
            try
            {
                // Obtén el contexto de la base de datos
                using (var dbContext = new EntitiesCuentasxPagar())
                {
                    // Encuentra la entidad que deseas eliminar
                    var entidadAEliminar = dbContext.cp_proveedor_datos_acreditacion
                        .Where(cpxtc => cpxtc.IdEmpresa == IdEmpresa && cpxtc.IdProveedor == IdProveedor && cpxtc.Secuencia == Secuencia)
                        .FirstOrDefault();

                    if (entidadAEliminar != null)
                    {
                        // Elimina la entidad del contexto y luego confirma los cambios en la base de datos
                        dbContext.cp_proveedor_datos_acreditacion.Remove(entidadAEliminar);
                        dbContext.SaveChanges();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GrabarBD(cp_proveedor_datos_acreditacion_Info Info)
        {
            try
            {
                // Obtén el contexto de la base de datos
                using (var dbContext = new EntitiesCuentasxPagar())
                {
                    // Asigna nueva Secuencia
                    Info.Secuencia = GetSecuencia(Info.IdEmpresa, Info.IdProveedor);

                    // Encuentra la entidad que deseas eliminar
                    var entidad = new cp_proveedor_datos_acreditacion();
                    entidad.IdEmpresa = Info.IdEmpresa;
                    entidad.IdProveedor = Info.IdProveedor;
                    entidad.Secuencia = Info.Secuencia;
                    entidad.IdBanco = Info.IdBanco;
                    entidad.IdTipoCuenta = Info.IdTipoCuenta;
                    entidad.NumeroCuenta = Info.NumeroCuenta;
                    entidad.IdTipoIdentificacion = Info.IdTipoIdentificacion;
                    entidad.Identificacion = Info.Identificacion;
                    entidad.Beneficiario = Info.Beneficiario;
                    entidad.Correo = Info.Correo;
                    entidad.Predefinida = Info.Predefinida;

                    if (entidad != null)
                    {                        
                        dbContext.cp_proveedor_datos_acreditacion.Add(entidad);
                        dbContext.SaveChanges();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int GetSecuencia(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                // Obtén el contexto de la base de datos
                using (var dbContext = new EntitiesCuentasxPagar())
                {
                    var maxSecuencia = dbContext.cp_proveedor_datos_acreditacion
                        .Where(d => d.IdEmpresa == IdEmpresa && d.IdProveedor == IdProveedor)
                        .Max(d => (int?)d.Secuencia);

                    if (maxSecuencia == 0)
                        return 1;
                    else
                        return Convert.ToInt32(maxSecuencia) + 1;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ModificarBD(cp_proveedor_datos_acreditacion_Info Info)
        {
            try
            {
                // Obtén el contexto de la base de datos
                using (var dbContext = new EntitiesCuentasxPagar())
                {
                    // Encuentra la entidad que deseas eliminar
                    var entidad = dbContext.cp_proveedor_datos_acreditacion.Where(
                        q => q.IdEmpresa == Info.IdEmpresa
                        && q.IdProveedor == Info.IdProveedor
                        && q.Secuencia == Info.Secuencia
                        ).First();

                    if (entidad != null)
                    {
                        entidad.IdBanco = Info.IdBanco;
                        entidad.IdTipoCuenta = Info.IdTipoCuenta;
                        entidad.NumeroCuenta = Info.NumeroCuenta;
                        entidad.IdTipoIdentificacion = Info.IdTipoIdentificacion;
                        entidad.Identificacion = Info.Identificacion;
                        entidad.Beneficiario = Info.Beneficiario;
                        entidad.Correo = Info.Correo;
                        entidad.Predefinida = Info.Predefinida;

                        // Actualiza registro
                        dbContext.SaveChanges();

                        // Si es predeterminada
                        if (Info.Predefinida == true)
                        {
                            var query = dbContext.cp_proveedor_datos_acreditacion.Where(
                                q => q.IdEmpresa == Info.IdEmpresa
                                && q.IdProveedor == Info.IdProveedor
                                && q.Secuencia != Info.Secuencia).ToList();

                            // les establece a los demas registros como Predeterminada = False
                            foreach (var item in query)
                            {
                                item.Predefinida = false;

                                dbContext.SaveChanges();
                            }                                                       
                        }
                    }                    

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
