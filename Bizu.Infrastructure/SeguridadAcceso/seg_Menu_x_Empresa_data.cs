using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Bizu.Domain.SeguridadAcceso;

namespace Bizu.Infrastructure.SeguridadAcceso
{
    public class seg_Menu_x_Empresa_data
    {
        public List<seg_Menu_x_Empresa_info> Get_List_DescripcionMenu_x_Empresa(int idEmpresa, ref string MensajeError)
        {
            List<seg_Menu_x_Empresa_info> returnValue = new List<seg_Menu_x_Empresa_info>();

            try
            {
                EntitiesSeguAcceso OEselectMenuEmpresa = new EntitiesSeguAcceso();
                var selectMenu_x_Empresa = from menu in OEselectMenuEmpresa.seg_menu
                                           join filtro in OEselectMenuEmpresa.seg_menu_x_empresa
                                           on menu.idmenu equals filtro.idmenu
                                           where filtro.idempresa == idEmpresa
                                           select new
                                           {
                                               filtro.idempresa,
                                               menu.descripcionmenu,
                                               filtro.idmenu,
                                               menu.idmenupadre,
                                               filtro.nombreasambly_x_emp,
                                               filtro.nomformulario_x_emp
                                           };
                foreach (var item in selectMenu_x_Empresa)
                {
                    seg_Menu_x_Empresa_info info = new seg_Menu_x_Empresa_info();
                    info.IdEmpresa = item.idempresa;
                    info.DescripcionMenu = item.descripcionmenu;
                    info.IdMenu = item.idmenu;
                    info.IdMenuPadre = (int)item.idmenupadre;
                    info.NombreAsambly_x_Emp = item.nombreasambly_x_emp;
                    info.NomFormulario_x_Emp = item.nomformulario_x_emp;
                    info.Existe = true;
                    info.Checkeado = true;
                    returnValue.Add(info);
                }
                return returnValue;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return new List<seg_Menu_x_Empresa_info>();
            }
        }

        public List<seg_Menu_x_Empresa_info> Get_No_List_DescripcionMenu_x_Empresa(int idEmpresa, ref string MensajeError)
        {
            List<seg_Menu_x_Empresa_info> returnValue = new List<seg_Menu_x_Empresa_info>();
            try
            {
                EntitiesSeguAcceso entity = new EntitiesSeguAcceso();
                var selectMenu_sin_Empresa = from c in entity.seg_menu
                                             where !(from o in entity.seg_menu_x_empresa
                                                     where o.idempresa == idEmpresa
                                                     select o.idmenu).Contains(c.idmenu)
                                             select c;
                foreach (var item in selectMenu_sin_Empresa)
                {
                    seg_Menu_x_Empresa_info info = new seg_Menu_x_Empresa_info();
                    info.IdEmpresa = idEmpresa;
                    info.DescripcionMenu = item.descripcionmenu;
                    info.IdMenu = item.idmenu;
                    info.IdMenuPadre = (int)item.idmenupadre;
                    info.NombreAsambly_x_Emp = item.nom_asembly;
                    info.NomFormulario_x_Emp = item.nom_formulario;
                    returnValue.Add(info);
                }
                return returnValue;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return new List<seg_Menu_x_Empresa_info>();
            }
        }

        public bool GrabarDB(List<seg_Menu_x_Empresa_info> listaMenu_x_Empresa_Modificada, ref string MensajeError)
        {
            try
            {
                EntitiesSeguAcceso entity = new EntitiesSeguAcceso();
                foreach (seg_Menu_x_Empresa_info item in listaMenu_x_Empresa_Modificada)
                {
                    var Listaregistros = (from c in entity.seg_menu_x_empresa
                                          where c.idempresa == item.IdEmpresa
                                          && c.idmenu == item.IdMenu
                                          select c);
                    seg_menu_x_empresa registro = new seg_menu_x_empresa();
                    if ((Listaregistros.Count() == 0) && (item.Checkeado))
                    {
                        registro.idmenu = item.IdMenu;
                        registro.idempresa = item.IdEmpresa;
                        registro.habilitado = true;
                        registro.nombreasambly_x_emp = item.NombreAsambly_x_Emp;
                        registro.nomformulario_x_emp = item.NomFormulario_x_Emp;
                        entity.seg_menu_x_empresa.Add(registro);
                    }
                    else if ((Listaregistros.Count() > 0) && (item.Checkeado))
                    {
                        registro = Listaregistros.First();
                        registro.nombreasambly_x_emp = item.NombreAsambly_x_Emp;
                        registro.nomformulario_x_emp = item.NomFormulario_x_Emp;
                    }
                    else if ((Listaregistros.Count() > 0) && (!item.Checkeado))
                    {
                        registro = Listaregistros.First();
                        var registrosReferencia = from c in entity.seg_menu_x_empresa_x_usuario
                                                  where c.idempresa == registro.idempresa
                                                  && c.idmenu == registro.idmenu
                                                  select c;
                        foreach (seg_menu_x_empresa_x_usuario registro_a_eliminar in registrosReferencia)
                        {
                            entity.seg_menu_x_empresa_x_usuario.Remove(registro_a_eliminar);
                        }
                        entity.seg_menu_x_empresa.Remove(registro);
                    }
                    else if ((Listaregistros.Count() == 0) && (!item.Checkeado))
                    {

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

        public bool ExisteRelacion(List<seg_Menu_x_Empresa_info> listaMenu_x_Empresa_x_Modificar, ref string MensajeError)
        {
            try
            {
                bool existe = false;
                EntitiesSeguAcceso entity = new EntitiesSeguAcceso();
                foreach (seg_Menu_x_Empresa_info item in listaMenu_x_Empresa_x_Modificar)
                {
                    var Listaregistros = (from c in entity.seg_menu_x_empresa
                                          where c.idempresa == item.IdEmpresa
                                          && c.idmenu == item.IdMenu
                                          select c);
                    seg_menu_x_empresa registro = new seg_menu_x_empresa();
                    if ((Listaregistros.Count() > 0) && (!item.Checkeado))
                    {
                        registro = Listaregistros.First();
                        var registrosReferencia = from c in entity.seg_menu_x_empresa_x_usuario
                                                  where c.idempresa == registro.idempresa
                                                  && c.idmenu == registro.idmenu
                                                  select c;
                        if (registrosReferencia.Count() > 0)
                        {
                            existe = true;
                            break;
                        }
                    }
                }
                return existe;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return true;
            }
        }
    }
}