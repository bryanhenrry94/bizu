using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.SeguridadAcceso;

namespace Bizu.Infrastructure.SeguridadAcceso
{
    public class seg_Menu_x_Empresa_x_Usuario_data
    {
        public List<seg_Menu_x_Empresa_x_Usuario_info> Get_List_DescripcionMenu_x_Empresa_x_Usuario(int idEmpresa, string idUsuario, ref string MensajeError)
        {
            try
            {
                List<seg_Menu_x_Empresa_x_Usuario_info> returnValue = new List<seg_Menu_x_Empresa_x_Usuario_info>();
                EntitiesSeguAcceso entity = new EntitiesSeguAcceso();
                var select_menu_x_empresa_x_usuario = from c in entity.vw_seg_menu_x_usuario_x_empresa
                                                      where c.idempresa == idEmpresa && c.idusuario == idUsuario
                                                      select c;
                foreach (var item in select_menu_x_empresa_x_usuario.ToList())
                {
                    seg_Menu_x_Empresa_x_Usuario_info info = new seg_Menu_x_Empresa_x_Usuario_info();
                    info.Checkeado = true;
                    info.DescripcionMenu = item.descripcionmenu;
                    info.Eliminacion = item.eliminacion;
                    info.Escritura = item.escritura;
                    info.Existe = true;
                    info.IdEmpresa = item.idempresa;
                    info.IdMenu = item.idmenu;
                    info.IdMenuPadre = (int)item.idmenupadre;
                    info.IdUsuario = item.idusuario;
                    info.Lectura = item.lectura;
                    info.SeModificoValor = false;
                    returnValue.Add(info);
                }
                return returnValue;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return new List<seg_Menu_x_Empresa_x_Usuario_info>();
            }
        }

        public seg_Menu_x_Empresa_x_Usuario_info Get_Info_Menu_x_Empresa_x_Usuario(int idEmpresa, string idUsuario, string Name_Formunalrio, ref string MensajeError)
        {
            try
            {
                seg_Menu_x_Empresa_x_Usuario_info info = new seg_Menu_x_Empresa_x_Usuario_info();

                EntitiesSeguAcceso entity = new EntitiesSeguAcceso();
                var select_menu_x_empresa_x_usuario = from c in entity.vw_seg_menu_x_usuario_x_empresa
                                                      where c.idempresa == idEmpresa
                                                      && c.idusuario == idUsuario
                                                      && c.nom_formulario == Name_Formunalrio
                                                      select c;
                foreach (var item in select_menu_x_empresa_x_usuario.ToList())
                {

                    info.Checkeado = true;
                    info.DescripcionMenu = item.descripcionmenu;
                    info.Lectura = item.lectura;
                    info.Escritura = item.escritura;
                    info.Eliminacion = item.eliminacion;
                    info.Existe = true;
                    info.IdEmpresa = item.idempresa;
                    info.IdMenu = item.idmenu;
                    info.IdMenuPadre = (int)item.idmenupadre;
                    info.IdUsuario = item.idusuario;
                    info.SeModificoValor = false;

                }
                return info;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return new seg_Menu_x_Empresa_x_Usuario_info();
            }
        }

        public List<seg_Menu_x_Empresa_x_Usuario_info> Get_No_List_DescripcionMenu_x_Empresa_x_Usuario(int idEmpresa, string idUsuario, ref string MensajeError)
        {
            try
            {
                List<seg_Menu_x_Empresa_x_Usuario_info> returnValue = new List<seg_Menu_x_Empresa_x_Usuario_info>();
                EntitiesSeguAcceso entity = new EntitiesSeguAcceso();
                seg_Menu_x_Empresa_data data = new seg_Menu_x_Empresa_data();
                MensajeError = "";
                List<seg_Menu_x_Empresa_info> lMenu_x_empresa = data.Get_List_DescripcionMenu_x_Empresa(idEmpresa, ref MensajeError);
                if (!MensajeError.Equals(""))
                {
                    return new List<seg_Menu_x_Empresa_x_Usuario_info>();
                }
                var select_no_menu_x_empresa_x_usuario = from c in lMenu_x_empresa
                                                         where !(from filtro in entity.vw_seg_menu_x_usuario_x_empresa
                                                                 where filtro.idempresa == idEmpresa && filtro.idusuario == idUsuario
                                                                 select filtro.idmenu).Contains(c.IdMenu)
                                                         select c;
                foreach (var item in select_no_menu_x_empresa_x_usuario)
                {
                    seg_Menu_x_Empresa_x_Usuario_info info = new seg_Menu_x_Empresa_x_Usuario_info();
                    info.Checkeado = false;
                    info.DescripcionMenu = item.DescripcionMenu;
                    info.Eliminacion = false;
                    info.Escritura = false;
                    info.Existe = false;
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdMenu = item.IdMenu;
                    info.IdMenuPadre = item.IdMenuPadre;
                    info.IdUsuario = idUsuario;
                    info.Lectura = false;
                    info.SeModificoValor = false;
                    returnValue.Add(info);
                }
                return returnValue;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return new List<seg_Menu_x_Empresa_x_Usuario_info>();
            }
        }

        public bool GrabarDB(List<seg_Menu_x_Empresa_x_Usuario_info> listaMenu_x_Empresa_Modificada, ref string MensajeError)
        {
            try
            {
                EntitiesSeguAcceso entity = new EntitiesSeguAcceso();
                foreach (seg_Menu_x_Empresa_x_Usuario_info item in listaMenu_x_Empresa_Modificada)
                {
                    var Listaregistros = (from c in entity.seg_menu_x_empresa_x_usuario
                                          where c.idempresa == item.IdEmpresa
                                          && c.idmenu == item.IdMenu
                                          && c.idusuario == item.IdUsuario
                                          select c);
                    seg_menu_x_empresa_x_usuario registro = new seg_menu_x_empresa_x_usuario();
                    if ((Listaregistros.Count() == 0) && (item.Checkeado))
                    {
                        registro.idmenu = item.IdMenu;
                        registro.idempresa = item.IdEmpresa;
                        registro.idusuario = item.IdUsuario;
                        registro.lectura = item.Lectura;
                        registro.escritura = item.Escritura;
                        registro.eliminacion = item.Eliminacion;
                        entity.seg_menu_x_empresa_x_usuario.Add(registro);
                    }
                    else if ((Listaregistros.Count() > 0) && (item.Checkeado))
                    {
                        registro = Listaregistros.First();
                        registro.lectura = item.Lectura;
                        registro.escritura = item.Escritura;
                        registro.eliminacion = item.Eliminacion;
                    }
                    else if ((Listaregistros.Count() > 0) && (!item.Checkeado))
                    {
                        registro = Listaregistros.First();
                        entity.seg_menu_x_empresa_x_usuario.Remove(registro);
                    }
                    else if ((Listaregistros.Count() == 0) && (!item.Checkeado))
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                entity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }

    }
}