using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.Mail;

namespace Bizu.Infrastructure.Mail
{
    public class mail_Cuenta_Correo_Data
    {
        public Boolean GrabarBD(mail_Cuenta_Correo_Info Info, ref string mensaje)
        {
            try
            {
                EntitiesMail context = new EntitiesMail();

                mail_Cuenta_Correo Address = new mail_Cuenta_Correo();
                Address.IdEmpresa = Info.IdEmpresa;
                Address.IdCuenta = Info.IdCuenta;
                Address.Nombre = Info.Nombre;
                Address.Direccion_Correo = Info.Direccion_Correo;
                Address.Enviar_copia_correo_oculta = Info.Enviar_copia_correo_oculta;
                Address.Cuenta_Correo_Copia = Info.Cuenta_Correo_Copia;
                Address.Servidor_Correo = Info.Servidor_Correo;
                Address.Tipo_Conexion = Info.Tipo_Conexion;
                Address.Puerto = Info.Puerto;
                Address.Usuario = Info.Usuario;
                Address.Contrasena = Info.Contrasena;
                Address.Cuenta_Predeterminada = Info.Cuenta_Predeterminada;
                Address.Estado = Info.Estado;

                context.mail_Cuenta_Correo.Add(Address);
                context.SaveChanges();

                mensaje = "Cuenta de correo " + Info.IdCuenta + " registrada con éxito!";

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean ModificarBD(mail_Cuenta_Correo_Info Info, ref string mensaje)
        {
            try
            {
                EntitiesMail context = new EntitiesMail();

                mail_Cuenta_Correo Address = new mail_Cuenta_Correo();

                Address = (from q in context.mail_Cuenta_Correo
                           where q.IdEmpresa == Info.IdEmpresa
                           && q.IdCuenta == Info.IdCuenta
                           select q).First();

                if (Address != null)
                {
                    Address.Nombre = Info.Nombre;
                    Address.Direccion_Correo = Info.Direccion_Correo;
                    Address.Enviar_copia_correo_oculta = Info.Enviar_copia_correo_oculta;
                    Address.Cuenta_Correo_Copia = Info.Cuenta_Correo_Copia;
                    Address.Servidor_Correo = Info.Servidor_Correo;
                    Address.Tipo_Conexion = Info.Tipo_Conexion;
                    Address.Puerto = Info.Puerto;
                    Address.Usuario = Info.Usuario;
                    Address.Contrasena = Info.Contrasena;
                    Address.Cuenta_Predeterminada = Info.Cuenta_Predeterminada;
                    Address.Estado = Info.Estado;

                    context.SaveChanges();

                    mensaje = "Cuenta de Correo actualizada con éxito";

                    return true;
                }
                else
                {
                    mensaje = "Ocurrio un error, no se pudo actualizar la cuenta de correo: " + Info.IdCuenta;

                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean Establecer_Cuenta_Predeterminada(int IdEmpresa, string IdCuenta)
        {
            try
            {
                EntitiesMail context = new EntitiesMail();

                var Address = (from q in context.mail_Cuenta_Correo
                              where q.IdEmpresa == IdEmpresa
                              && q.IdCuenta != IdCuenta
                              select q).First();

                if (Address != null)
                {
                    Address.Cuenta_Predeterminada = false;

                    context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<mail_Cuenta_Correo_Info> Get_List(int IdEmpresa)
        {
            try
            {
                List<mail_Cuenta_Correo_Info> Lista = new List<mail_Cuenta_Correo_Info>();

                EntitiesMail context = new EntitiesMail();

                var query = from q in context.mail_Cuenta_Correo
                            where q.IdEmpresa == IdEmpresa
                            select q;

                foreach (var item in query)
                {
                    mail_Cuenta_Correo_Info Info = new mail_Cuenta_Correo_Info();
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdCuenta = item.IdCuenta;
                    Info.Nombre = item.Nombre;
                    Info.Direccion_Correo = item.Direccion_Correo;
                    Info.Enviar_copia_correo_oculta = item.Enviar_copia_correo_oculta;
                    Info.Cuenta_Correo_Copia = item.Cuenta_Correo_Copia;
                    Info.Servidor_Correo = item.Servidor_Correo;
                    Info.Tipo_Conexion = item.Tipo_Conexion;
                    Info.Puerto = item.Puerto;
                    Info.Usuario = item.Usuario;
                    Info.Contrasena = item.Contrasena;
                    Info.Cuenta_Predeterminada = item.Cuenta_Predeterminada;
                    Info.Estado = item.Estado;

                    Lista.Add(Info);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string Get_IdCuenta_Predeterminada(int IdEmpresa)
        {
            try
            {
                string IdCuenta = "";

                EntitiesMail context = new EntitiesMail();

                var query = from q in context.mail_Cuenta_Correo
                            where q.IdEmpresa == IdEmpresa
                            && q.Cuenta_Predeterminada == true
                            select q;

                foreach (var item in query)
                {
                    IdCuenta = item.IdCuenta;
                }


                return IdCuenta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public mail_Cuenta_Correo_Info Get_Info(int IdEmpresa, string IdCuenta)
        {
            try
            {
                mail_Cuenta_Correo_Info Info = new mail_Cuenta_Correo_Info();

                EntitiesMail context = new EntitiesMail();

                var query = from q in context.mail_Cuenta_Correo
                            where q.IdEmpresa == IdEmpresa
                            && q.IdCuenta == IdCuenta
                            select q;

                foreach (var item in query)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdCuenta = item.IdCuenta;
                    Info.Nombre = item.Nombre;
                    Info.Direccion_Correo = item.Direccion_Correo;
                    Info.Enviar_copia_correo_oculta = item.Enviar_copia_correo_oculta;
                    Info.Cuenta_Correo_Copia = item.Cuenta_Correo_Copia;
                    Info.Servidor_Correo = item.Servidor_Correo;
                    Info.Tipo_Conexion = item.Tipo_Conexion;
                    Info.Puerto = item.Puerto;
                    Info.Usuario = item.Usuario;
                    Info.Contrasena = item.Contrasena;
                    Info.Cuenta_Predeterminada = item.Cuenta_Predeterminada;
                    Info.Estado = item.Estado;
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