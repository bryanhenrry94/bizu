using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.SeguridadAcceso;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;
using System.Data.Entity.Validation;		

namespace Bizu.Infrastructure.SeguridadAcceso
{
    public class seg_usuario_data
    {            
        public List<seg_usuario_info> Get_List_Usuario(ref string MensajeError)
        {
            List<seg_usuario_info> lU = new List<seg_usuario_info>();
            try
            {                
                EntitiesSeguAcceso OEUser = new EntitiesSeguAcceso();
                var selectUsers = from C in OEUser.seg_usuario
                                  select C;

                foreach (var item in selectUsers)
                {
                    seg_usuario_info user_info = new seg_usuario_info();
                    user_info.IdUsuario = item.idusuario;
                    user_info.Contrasena = item.contrasena;
                    user_info.estado = item.estado;
                    user_info.Nombre = item.nombre;
                    user_info.ExigirDirectivaContrasenia = item.exigirdirectivacontrasenia;
                    user_info.CambiarContraseniaSgtSesion = item.cambiarcontraseniasgtsesion;
                    lU.Add(user_info);
                }
                return (lU);
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return new List<seg_usuario_info>();
            }
        }

        public List<seg_usuario_info> Get_List_Usuario_x_Empresa(int idEmpresa, ref string MensajeError)
        {
            List<seg_usuario_info> returnValue = new List<seg_usuario_info>();
            try
            {
                EntitiesSeguAcceso OEUser = new EntitiesSeguAcceso();
                var selectUsers = from C in OEUser.seg_usuario
                                  join E in OEUser.seg_usuario_x_empresa
                                  on C.idusuario equals E.idusuario
                                  where E.idempresa==idEmpresa
                                  select C;
                foreach (var item in selectUsers)
                {
                    seg_usuario_info user_info = new seg_usuario_info();
                    user_info.IdUsuario = item.idusuario;
                    user_info.Contrasena = item.contrasena;
                    user_info.estado = item.estado; 
                    user_info.Nombre = item.nombre;
                    returnValue.Add(user_info);
                }
                return returnValue;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return returnValue;
            }
        }

        public seg_usuario_info Get_Info_Usuario(string IdUsuario, ref string MensajeError)
        {           
            try
            {
                seg_usuario_info user_info = new seg_usuario_info();
                EntitiesSeguAcceso OEUser = new EntitiesSeguAcceso();
                var selectUsers = from C in OEUser.seg_usuario
                                  where C.idusuario==IdUsuario
                                  select C;

                foreach (var item in selectUsers)
                {                   
                    user_info.IdUsuario = item.idusuario;
                    user_info.Contrasena = item.contrasena;
                    user_info.estado = item.estado;
                    user_info.Nombre = item.nombre;                  
                }
                return (user_info);
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return new seg_usuario_info();
            }
        }

        public Boolean Get_Estado_Usuario(string IdUsuario, ref string MensajeError)
        {
            Boolean estado = false;
            try
            {
                EntitiesSeguAcceso OEUser = new EntitiesSeguAcceso();
                var selectUsers = from C in OEUser.seg_usuario
                                  where C.idusuario == IdUsuario
                                  select C;

                if (selectUsers.ToList().Count > 0)
                {
                    foreach (var item in selectUsers)
                    {
                        estado = (item.estado == "A") ? true : false;
                    }
                }
                return estado;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return estado;
            }

        }

        public Boolean Update_only_user(seg_usuario_info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
                {
                    var contact = context.seg_usuario.FirstOrDefault(dinfo => dinfo.idusuario == info.IdUsuario);
                    if (contact != null)
                    {
                        contact.idusuario = info.IdUsuario;
                        contact.contrasena = info.Contrasena;
                        contact.estado = info.estado;
                        contact.nombre = info.Nombre;
                        contact.fecha_ultmod = DateTime.Now;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }

        public Boolean Update_usuario_referencias(seg_usuario_info user,List<tb_Empresa_Info> lEmpresa, ref string MensajeError)
        {
            try
            {
                using(EntitiesSeguAcceso entity = new EntitiesSeguAcceso())
                {
                    var contact = (from c in entity.seg_usuario where c.idusuario == user.IdUsuario select c).First();
                    contact.idusuario = user.IdUsuario;
                    contact.contrasena = user.Contrasena;
                    contact.estado = user.estado;
                    contact.nombre = user.Nombre;
                    contact.exigirdirectivacontrasenia = user.ExigirDirectivaContrasenia;
                    contact.cambiarcontraseniasgtsesion = user.CambiarContraseniaSgtSesion;

                    entity.Database.ExecuteSqlCommand("DELETE FROM seg_usuario_x_empresa WHERE IdUsuario = '" + user.IdUsuario + "'");

                    foreach (var item in lEmpresa)
                    {
                        seg_usuario_x_empresa objUser_x_empresa = new seg_usuario_x_empresa();
                        objUser_x_empresa.idempresa = item.IdEmpresa;
                        objUser_x_empresa.idusuario = user.IdUsuario;
                        entity.seg_usuario_x_empresa.Add(objUser_x_empresa);
                    }                    

                    entity.SaveChanges();             
                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }

        public Boolean Existe_Usuario(string IdUsuario, ref string MensajeError)
        {
            try
            {
                EntitiesSeguAcceso EDB = new EntitiesSeguAcceso();
                var Q = from per in EDB.seg_usuario
                        where per.idusuario == IdUsuario
                        select per;
                int filasAfectadas = Q.ToList().Count;

                return (filasAfectadas > 0) ? true : false;

            }           
            catch (DbEntityValidationException ex)
            {
                foreach (var item in ex.EntityValidationErrors)
                {
                    foreach (var item_validaciones in item.ValidationErrors)
                    {
                        MensajeError = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                        
                    }
                }
                return false;
            }
        }

        public Boolean GrabarDB(seg_usuario_info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
                {
                    EntitiesSeguAcceso EDB = new EntitiesSeguAcceso();
                    var Q = from per in EDB.seg_usuario
                            where per.idusuario == info.IdUsuario
                            select per;
                    if (Q.ToList().Count == 0)
                    {
                        var address = new seg_usuario();
                        address.idusuario = info.IdUsuario;
                        address.contrasena = info.Contrasena;                        
                        address.estado = info.estado;
                        address.fecha_transaccion = DateTime.Now;                        

                        context.seg_usuario.Add(address);                        
                        context.SaveChanges();
                    }
                    else
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }

        public Boolean GrabarUser_x_Empresa(seg_usuario_info info,List<int> idEmpresas, ref string MensajeError)
        {
            try
            {
                using (EntitiesSeguAcceso DBentidad = new EntitiesSeguAcceso())
                {
                    seg_usuario user = new seg_usuario 
                    { 
                        idusuario = info.IdUsuario,
                        contrasena=info.Contrasena,
                        estado=info.estado,
                        nombre=info.Nombre, 
                        cambiarcontraseniasgtsesion = info.CambiarContraseniaSgtSesion,
                        exigirdirectivacontrasenia = info.ExigirDirectivaContrasenia
                    };
                    DBentidad.seg_usuario.Add(user);
                    foreach (int id in idEmpresas)
                    {
                        seg_usuario_x_empresa user_x_empresa = new seg_usuario_x_empresa
                        {
                            idempresa = id,
                            idusuario=user.idusuario,
                            observacion=""
                        };
                        DBentidad.seg_usuario_x_empresa.Add(user_x_empresa);
                    }
                    DBentidad.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }

        public Boolean EliminarDB(seg_usuario_info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
                {                    
                    var contact = (from c in context.seg_usuario where c.idusuario == info.IdUsuario select c).First();
                    contact.estado = "I";
                    contact.idusuarioultanu = info.IdUsuarioUltAnu;
                    contact.fecha_ultanu = DateTime.Now;
                    contact.motivoanulacion = info.MotivoAnulacion;
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }

        public Boolean Anular(seg_usuario_info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesSeguAcceso EAnular = new EntitiesSeguAcceso())
                {
                    var selectUser = (from C in EAnular.seg_usuario where C.idusuario == info.IdUsuario select C).FirstOrDefault();
                    if (selectUser != null)
                    {
                        selectUser.motivoanulacion = info.MotivoAnulacion;
                        selectUser.idusuarioultanu = info.IdUsuarioUltAnu;
                        selectUser.fecha_ultanu = info.Fecha_UltAnu;
                        selectUser.estado = "I";
                        EAnular.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }

        public Boolean Validar_Credenciales(seg_usuario_info oUser, ref string MensajeError)
        
        {
            try
            {

                EntitiesSeguAcceso OEseg = new EntitiesSeguAcceso();

                var Q_User = from User in OEseg.seg_usuario
                             where User.idusuario.Equals(oUser.IdUsuario)
                             && User.contrasena.Equals(oUser.Contrasena)
                             && User.estado == "A"
                             select User;


                foreach (var item in Q_User)
                {
                    oUser.estado = item.estado;
                    oUser.CambiarContraseniaSgtSesion = item.cambiarcontraseniasgtsesion;
                    oUser.ExigirDirectivaContrasenia = item.exigirdirectivacontrasenia;
                }

                var OUsera = Q_User.ToList();

                if (OUsera.Count == 0)
                {
                    return (false);
                }
                else
                {
                    return (true);
                }
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;                
            }
        }

        public Boolean Validar_Directiva_Contrasena(seg_usuario_info oUser, ref string MensajeError)
        {
            try
            {
                EntitiesSeguAcceso OEseg = new EntitiesSeguAcceso();
                var Q_User = from User in OEseg.seg_usuario
                             where User.idusuario.Equals(oUser.IdUsuario)
                             && User.estado == "A"
                             select User;
                foreach (var item in Q_User)
                {
                    oUser.estado = item.estado;
                    oUser.CambiarContraseniaSgtSesion = item.cambiarcontraseniasgtsesion;
                    oUser.ExigirDirectivaContrasenia = item.exigirdirectivacontrasenia;
                }

                var OUsera = Q_User.ToList();

                if (OUsera.Count == 0)
                {
                    return (false);
                }
                else
                {
                    return (true);
                }
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }
        
        public Boolean Actualizar_Password(seg_usuario_info info, ref string MensajeError)
        {
            try
            {
                using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
                {
                    var contact = context.seg_usuario.FirstOrDefault(dinfo => dinfo.idusuario == info.IdUsuario);
                    if (contact != null)
                    {
                        contact.contrasena = info.Contrasena;
                        contact.cambiarcontraseniasgtsesion = info.CambiarContraseniaSgtSesion;
                        contact.exigirdirectivacontrasenia = info.ExigirDirectivaContrasenia;
                        contact.idusuarioultmodi = info.IdUsuarioUltModi;
                        contact.fecha_ultmod = info.Fecha_UltMod;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }
        
        public Boolean Validar_IngresoUsuarioXEmpresa(string IdUsuario, int IdEmpresa, string clave, ref string MensajeError)
        {
            try
            {
                EntitiesSeguAcceso OEseg = new EntitiesSeguAcceso();
                var sel = from u in OEseg.seg_usuario
                          where u.idusuario == IdUsuario
                          select u;

                if (sel.ToList().Count == 0)
                {
                    MensajeError = "El Usuario " + IdUsuario + " No se encuentra ingresado en Base";
                    return false;
                }

                foreach (var item in sel)
                {
                    if (item.estado == "I")
                    {
                        MensajeError = "El Usuario " + IdUsuario + " está Inactivo";
                        return false;
                    }
                    if (item.contrasena.Trim() != clave.Trim())
                    {
                        MensajeError = "La Contraseña del Usuario " + IdUsuario + " es Incorrecta";
                        return false;
                    }
                }

                var Q_User = from User in OEseg.seg_usuario
                             join pp in OEseg.seg_usuario_x_empresa on new { } equals new { }
                             where User.idusuario == IdUsuario && User.idusuario == pp.idusuario && User.estado == "A" && pp.idempresa == IdEmpresa
                             select new
                             {
                                 User.idusuario
                             };

                if (Q_User.ToList().Count == 0)
                {
                    MensajeError = "Acceso Incorrecto";
                    return false;
                }
                else
                {
                    MensajeError = "Acceso Correcto";
                    return true;
                }
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }
    }
}
