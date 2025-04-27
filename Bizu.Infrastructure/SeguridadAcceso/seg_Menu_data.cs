using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using Bizu.Domain.SeguridadAcceso;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;

namespace Bizu.Infrastructure.SeguridadAcceso
{
    public class seg_Menu_data
    {

        public List<seg_Menu_info> Get_List_Menu(ref string MensajeError)
        {
            List<seg_Menu_info> returnValue = new List<seg_Menu_info>();
            try
            {
                EntitiesSeguAcceso OESeguridad = new EntitiesSeguAcceso();

                var selectMenu = from C in OESeguridad.seg_menu
                                 orderby C.posicionmenu
                                 select C;

                foreach (var item in selectMenu)
                {
                    seg_Menu_info oM = new seg_Menu_info();
                    oM.IdMenu = item.idmenu;
                    oM.IdMenuPadre = (int)item.idmenupadre;
                    oM.DescripcionMenu = item.descripcionmenu;
                    oM.PosicionMenu = item.posicionmenu;
                    oM.Habilitado = item.habilitado;
                    oM.Tiene_FormularioAsociado = item.tiene_formularioasociado;                    
                    oM.nom_Formulario = item.nom_formulario;
                    oM.nom_Asembly = item.nom_asembly;
                    oM.imagen_peque = item.imagen_peque;
                    oM.imagen_grande = item.imagen_grande;
                    oM.icono = item.icono;
                    oM.nivel = (item.nivel == null) ? 0 : Convert.ToInt32(item.nivel);
                    
                    returnValue.Add(oM);
                }

                return (returnValue);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }

        public List<seg_Menu_info> Get_List_Menu_x_Empresa(int idEmpresa,ref string MensajeError)
        {
            List<seg_Menu_info> returnValue = new List<seg_Menu_info>();
            
            try
            {                
                EntitiesSeguAcceso OEselectMenuEmpresa = new EntitiesSeguAcceso();                
                var selectMenu_x_Empresa = from menu in OEselectMenuEmpresa.seg_menu
                                           join filtro in OEselectMenuEmpresa.seg_menu_x_empresa
                                           on menu.idmenu equals filtro.idmenu
                                           where filtro.idempresa == idEmpresa
                                           select menu;
                foreach (var item in selectMenu_x_Empresa)
                {
                    seg_Menu_info info = new seg_Menu_info();
                    
                    info.IdMenu = item.idmenu;
                    info.IdMenuPadre = item.idmenupadre;
                    info.DescripcionMenu = item.descripcionmenu;
                    info.PosicionMenu = item.posicionmenu;
                    info.Habilitado = item.habilitado;
                    info.Tiene_FormularioAsociado = item.tiene_formularioasociado;
                    info.nom_Formulario = item.nom_formulario;
                    info.nom_Asembly = item.nom_asembly;
                    info.imagen_grande = item.imagen_grande;
                    info.imagen_peque = item.imagen_peque;
                    info.icono = item.icono;
                    info.nivel = item.nivel;

                    returnValue.Add(info);
                }
                return returnValue;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }

        public List<seg_Menu_info> Get_List_Menu_x_Empresa_x_Usuario(string idUsuario, int idEmpresa, ref string MensajeError)
        {
            List<seg_Menu_info> returnValue = new List<seg_Menu_info>();
            try
            {                
                EntitiesSeguAcceso entidadMenu = new EntitiesSeguAcceso();
                var consulta = from m in entidadMenu.vw_seg_menu_x_usuario_x_empresa
                               where m.idempresa == idEmpresa && m.idusuario == idUsuario
                               select m;
                
                foreach (var item in consulta)
                {
                    seg_Menu_info info = new seg_Menu_info();
                    info.IdMenu = item.idmenu;
                    info.IdMenuPadre = item.idmenupadre;
                    info.DescripcionMenu = item.descripcionmenu;
                    info.PosicionMenu = item.posicionmenu;
                    info.Habilitado = item.habilitado;
                    info.Tiene_FormularioAsociado = item.tiene_formularioasociado;
                    info.nom_Formulario = item.nom_formulario;
                    info.nom_Asembly = item.nom_asembly;
                    info.imagen_grande = item.imagen_grande;
                    info.imagen_peque = item.imagen_peque;
                    info.icono = item.icono;
                    info.nivel = item.nivel;

                    returnValue.Add(info);
                }
                               
                return returnValue;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }

        public List<seg_Menu_info> Get_List_Menu_x_Empresa_x_Usuario_Control(int idEmpresa, string idUsuario, string NomFor)
        {
            List<seg_Menu_info> returnValue = new List<seg_Menu_info>();
            try
            {
                EntitiesSeguAcceso entidadMenu = new EntitiesSeguAcceso();
                var consulta = from m in entidadMenu.vw_seg_menu_x_usuario_x_empresa
                               where m.idempresa == idEmpresa && m.idusuario == idUsuario
                               && m.nom_formulario == NomFor
                               select m;

                foreach (var item in consulta)
                {
                    seg_Menu_info info = new seg_Menu_info();
                    info.IdMenu = item.idmenu;
                    info.IdMenuPadre = item.idmenupadre;
                    info.DescripcionMenu = item.descripcionmenu;
                    info.PosicionMenu = item.posicionmenu;
                    info.Habilitado = item.habilitado;
                    info.Tiene_FormularioAsociado = item.tiene_formularioasociado;
                    info.nom_Formulario = item.nom_formulario;
                    info.nom_Asembly = item.nom_asembly;
                    info.imagen_grande = item.imagen_grande;
                    info.imagen_peque = item.imagen_peque;
                    info.icono = item.icono;
                    info.nivel = item.nivel;
                    info.Eliminacion = item.eliminacion;
                    info.Escritura = item.escritura;
                    info.Lectura = item.lectura;

                    returnValue.Add(info);
                }

                return returnValue;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                throw new Exception(ex.ToString());
            }
        }

        public seg_Menu_info Get_Info_Menu(int idmenu,ref string MensajeError)
        {
            seg_Menu_info info = new seg_Menu_info();
            try
            {
                EntitiesSeguAcceso OESeguridad = new EntitiesSeguAcceso();

                var selectMenu = from C in OESeguridad.seg_menu
                                 orderby C.posicionmenu
                                 where C.idmenu == idmenu
                                 select C;

                foreach (var item in selectMenu)
                {
                    seg_Menu_info oM = new seg_Menu_info();
                    oM.IdMenu = item.idmenu;
                    oM.DescripcionMenu = item.descripcionmenu;
                    oM.Tiene_FormularioAsociado = item.tiene_formularioasociado;
                    oM.Habilitado = item.habilitado;
                    oM.IdMenuPadre = (int)item.idmenupadre;
                    oM.PosicionMenu = item.posicionmenu;                    
                    oM.nom_Formulario = item.nom_formulario;
                    oM.nom_Asembly = item.nom_asembly;
                    oM.imagen_peque = item.imagen_peque;
                    oM.imagen_grande = item.imagen_grande;
                    oM.icono = item.icono;
                    oM.nivel = (item.nivel == null) ? 0 : Convert.ToInt32(item.nivel);
                    
                    info = oM;
                }

                return info;
            }

            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }

        }
        
        #region Modificar

        public Boolean ModificarDB(seg_Menu_info info, ref string MensajeError)
        {
            try
            {
                int resultado = 0;
                using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
                {
                    var contact = context.seg_menu.FirstOrDefault(dinfo => dinfo.idmenu == info.IdMenu);
                    if (contact != null)
                    {
                        contact.idmenupadre = info.IdMenuPadre;
                        contact.descripcionmenu = info.DescripcionMenu;
                        contact.posicionmenu = info.PosicionMenu;
                        contact.habilitado = info.Habilitado;
                        contact.tiene_formularioasociado = info.Tiene_FormularioAsociado;
                        info.nom_Asembly = (info.nom_Asembly == null) ? "" : info.nom_Asembly;
                        info.nom_Formulario = (info.nom_Formulario == null) ? "" : info.nom_Formulario;
                        contact.nom_formulario = info.nom_Formulario;
                        contact.nom_asembly = info.nom_Asembly;

                        contact.imagen_peque = info.imagen_peque;
                        contact.imagen_grande = info.imagen_grande;
                        contact.icono = info.icono;
                        contact.nivel = (info.nivel == null) ? 0 : Convert.ToInt32(info.nivel);

                        resultado = context.SaveChanges();
                    }
                    if (resultado > 0)
                    {
                        info.IdMenu = contact.idmenu;
                        info.DescripcionMenu = contact.descripcionmenu;
                        
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(List<seg_Menu_info> lista, ref string MensajeError)
        {
            try
            {
                using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
                {
                    foreach (var item in lista)
                    {
                        var contact = context.seg_menu.FirstOrDefault(menu => menu.idmenu == item.IdMenu);
                        if (contact != null)
                        {
                            contact.descripcionmenu = item.DescripcionMenu;
                            contact.posicionmenu = item.PosicionMenu;
                            contact.nom_asembly = item.nom_Asembly;
                            contact.nom_formulario = item.nom_Formulario;
                            contact.habilitado = item.Habilitado;
                            contact.tiene_formularioasociado = item.Tiene_FormularioAsociado;
                            contact.imagen_peque = item.imagen_peque;
                            contact.imagen_grande = item.imagen_grande;
                            contact.icono = item.icono;
                            contact.nivel = item.nivel;
                            context.SaveChanges();
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean Anular(int idMenu, ref string MensajeError)
        {
            try
            {
                using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
                {
                    var contact = context.seg_menu.FirstOrDefault(dinfo => dinfo.idmenu == idMenu);
                    if (contact != null)
                    {
                        contact.habilitado = false;

                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }

        #endregion

        #region Id Maximo
        public int getIdMenu_Max(ref string MensajeError)
        {
            try
            {                
                int Idsecuencia;
                EntitiesSeguAcceso OEPermisos = new EntitiesSeguAcceso();
                var selectMax = (from C in OEPermisos.seg_menu
                                 select C.idmenu).Max();
                Idsecuencia = Convert.ToInt32(selectMax.ToString()) + 1;
                return Idsecuencia;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }
        #endregion

        #region Grabar
        public Boolean GrabarDB(seg_Menu_info info, ref string MensajeError)
        {            
            try
            {
                using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
                {                    
                    var address = new seg_menu();
                    address.idmenu = getIdMenu_Max(ref MensajeError);
                    address.idmenupadre = info.IdMenuPadre;
                    address.descripcionmenu = info.DescripcionMenu;
                    address.posicionmenu = info.PosicionMenu;
                    address.habilitado = info.Habilitado;
                    address.tiene_formularioasociado = info.Tiene_FormularioAsociado;
                    address.nom_formulario = info.nom_Formulario;
                    address.nom_asembly = info.nom_Asembly;                                        
                    address.imagen_peque = info.imagen_peque;
                    address.imagen_grande = info.imagen_grande;
                    address.icono = info.icono;
                    address.nivel = (info.nivel == null) ? 0 : Convert.ToInt32(info.nivel);                                        
                    context.seg_menu.Add(address);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }
        #endregion

        #region Eliminar

        public Boolean EliminarDB(List<seg_Menu_info> Lista, ref string MensajeError)
        {
            try
            {
                foreach (var item in Lista)
                {
                    EliminarDB(item,ref MensajeError);
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }
        public Boolean EliminarDB(seg_Menu_info info,ref string MensajeError)
        {
            try
            {
                using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
                {                                                            
                    var contact = context.seg_menu.FirstOrDefault(dinfo => dinfo.idmenu == info.IdMenu);
                    if (contact != null)
                    {
                        context.seg_menu.Remove(contact);
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }
        public Boolean ExisteRelacionMenu(int idMenu, ref string MensajeError)
        {
            try
            {
                Boolean existe = false;
                using (EntitiesSeguAcceso context = new EntitiesSeguAcceso())
                {
                    var menu_empresa = (from c in context.seg_menu_x_empresa
                                        where c.idmenu == idMenu
                                        select c);
                    if (menu_empresa.Count() > 0)
                        existe = true;
                }
                return existe;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }
        #endregion

    }
}
