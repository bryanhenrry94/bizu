using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;

namespace Core.Erp.Data.General
{
    public class tb_tarea_Data
    {
        public bool GrabarBD(tb_tarea_Info Info)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    tb_tarea _tarea = new tb_tarea();
                    _tarea.IdEmpresa = Info.IdEmpresa;
                    _tarea.IdTarea = Info.IdTarea = GetID(Info.IdEmpresa);
                    _tarea.Titulo = Info.Titulo;
                    _tarea.Descripcion = Info.Descripcion;
                    _tarea.FechaIni = Info.FechaIni;
                    _tarea.FechaFin = Info.FechaFin;
                    _tarea.IdUsuarioUltAsignacion = Info.IdUsuarioUltAsignacion;
                    _tarea.FechaUltAsignacion = Info.FechaUltAsignacion;
                    _tarea.EstadoTarea = Info.EstadoTarea;
                    _tarea.Estado = Info.Estado;
                    _tarea.Prioridad = Info.Prioridad;
                    _tarea.IdUsuarioCreacion = Info.IdUsuarioCreacion;
                    _tarea.FechaCreacion = Info.FechaCreacion;
                    //_tarea.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                    //_tarea.FechaUltMod = Info.FechaUltMod;
                    //_tarea.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                    //_tarea.FechaUltAnu = Info.FechaUltAnu;
                    //_tarea.MotivoAnu = Info.MotivoAnu;

                    context.tb_tarea.Add(_tarea);
                    context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ModificarBD(tb_tarea_Info Info)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    tb_tarea _tarea = new tb_tarea();

                    _tarea = (from q in context.tb_tarea
                              where q.IdEmpresa == Info.IdEmpresa
                              && q.IdTarea == Info.IdTarea
                              select q).FirstOrDefault();


                    if (_tarea != null)
                    {
                        _tarea.Titulo = Info.Titulo;
                        _tarea.Descripcion = Info.Descripcion;
                        _tarea.FechaIni = Info.FechaIni;
                        _tarea.FechaFin = Info.FechaFin;
                        _tarea.IdUsuarioUltAsignacion = Info.IdUsuarioUltAsignacion;
                        _tarea.FechaUltAsignacion = Info.FechaUltAsignacion;
                        _tarea.EstadoTarea = Info.EstadoTarea;
                        _tarea.Estado = Info.Estado;
                        _tarea.Prioridad = Info.Prioridad;
                        //_tarea.IdUsuarioCreacion = Info.IdUsuarioCreacion;
                        //_tarea.FechaCreacion = Info.FechaCreacion;
                        _tarea.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        _tarea.FechaUltMod = Info.FechaUltMod;
                        _tarea.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        //_tarea.FechaUltAnu = Info.FechaUltAnu;
                        //_tarea.MotivoAnu = Info.MotivoAnu;

                        context.SaveChanges();
                    }   
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EliminarBD(tb_tarea_Info Info)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    tb_tarea _tarea = new tb_tarea();

                    _tarea = (from q in context.tb_tarea
                             where q.IdEmpresa == Info.IdEmpresa
                             && q.IdTarea == Info.IdTarea
                             select q).FirstOrDefault();

                    if (_tarea != null)
                    {
                        context.tb_tarea.Remove(_tarea);
                        context.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AnularBD(tb_tarea_Info Info)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    tb_tarea _tarea = new tb_tarea();

                    _tarea = (from q in context.tb_tarea
                              where q.IdEmpresa == Info.IdEmpresa
                              && q.IdTarea == Info.IdTarea
                              select q).FirstOrDefault();

                    if (_tarea != null)
                    {
                        _tarea.Estado = Info.Estado;
                        _tarea.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        _tarea.FechaUltAnu = Info.FechaUltAnu;
                        _tarea.MotivoAnu = Info.MotivoAnu;
                        context.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tb_tarea_Info> GetList(int IdEmpresa, string IdUsuario, DateTime fechaIni, DateTime fechaFin, string EstadoTarea)
        {
            try
            {
                List<tb_tarea_Info> lista = new List<tb_tarea_Info>();

                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var query = (
                                from q in context.tb_tarea
                                where q.IdEmpresa == IdEmpresa
                                    && q.IdUsuarioCreacion == IdUsuario
                                    && q.EstadoTarea == EstadoTarea
                                    && q.FechaFin >= fechaIni && q.FechaFin <= fechaFin
                                    && q.Estado == "A"
                                select q
                                ).Union(
                                from q in context.tb_tarea
                                where q.IdEmpresa == IdEmpresa
                                && q.IdUsuarioUltAsignacion == IdUsuario
                                && q.IdUsuarioCreacion != IdUsuario
                                && q.EstadoTarea == EstadoTarea
                                && q.FechaFin >= fechaIni && q.FechaFin <= fechaFin
                                && q.Estado == "A"
                                select q
                                ).Union(
                                from q in context.tb_tarea
                                join t in context.tb_tarea_equipo
                                on new { q.IdEmpresa, q.IdTarea } equals new { t.IdEmpresa, t.IdTarea }
                                where q.IdEmpresa == IdEmpresa
                                    && q.IdUsuarioUltAsignacion != IdUsuario
                                    && q.IdUsuarioCreacion != IdUsuario
                                    && t.IdUsuario == IdUsuario
                                    && q.EstadoTarea == EstadoTarea
                                    && q.FechaFin >= fechaIni && q.FechaFin <= fechaFin
                                    && q.Estado == "A"
                                select q
                            );

                    foreach (var Info in query)
                    {
                        tb_tarea_Info _tarea = new tb_tarea_Info();
                        _tarea.IdEmpresa = Info.IdEmpresa;
                        _tarea.IdTarea = Info.IdTarea;
                        _tarea.Titulo = Info.Titulo;
                        _tarea.Descripcion = Info.Descripcion;
                        _tarea.FechaIni = Info.FechaIni;
                        _tarea.FechaFin = Info.FechaFin;
                        _tarea.IdUsuarioUltAsignacion = Info.IdUsuarioUltAsignacion;
                        _tarea.FechaUltAsignacion = Info.FechaUltAsignacion;
                        _tarea.EstadoTarea = Info.EstadoTarea;
                        _tarea.Estado = Info.Estado;
                        _tarea.Prioridad = Info.Prioridad;

                        switch (Info.Prioridad)
                        {
                            case "BAJA":
                                _tarea.IdPrioridad = 1;
                                break;
                            case "MEDIA":
                                _tarea.IdPrioridad = 2;
                                break;
                            case "ALTA":
                                _tarea.IdPrioridad = 3;
                                break;
                        }

                        _tarea.IdUsuarioCreacion = Info.IdUsuarioCreacion;
                        _tarea.FechaCreacion = Info.FechaCreacion;
                        _tarea.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        _tarea.FechaUltMod = Info.FechaUltMod;
                        _tarea.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        _tarea.FechaUltAnu = Info.FechaUltAnu;
                        _tarea.MotivoAnu = Info.MotivoAnu;

                        lista.Add(_tarea);
                    }
                }

                return lista.OrderBy(m => m.FechaFin).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public tb_tarea_Info GetInfo(int IdEmpresa, int IdTarea)
        {
            try
            {
                tb_tarea_Info _tarea = new tb_tarea_Info();

                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var query = from q in context.tb_tarea
                                where q.IdEmpresa == IdEmpresa
                                && q.IdTarea == IdTarea
                                select q;

                    foreach (var Info in query)
                    {
                        _tarea.IdEmpresa = Info.IdEmpresa;
                        _tarea.IdTarea = Info.IdTarea;
                        _tarea.Titulo = Info.Titulo;
                        _tarea.Descripcion = Info.Descripcion;
                        _tarea.FechaIni = Info.FechaIni;
                        _tarea.FechaFin = Info.FechaFin;
                        _tarea.IdUsuarioUltAsignacion = Info.IdUsuarioUltAsignacion;
                        _tarea.FechaUltAsignacion = Info.FechaUltAsignacion;
                        _tarea.EstadoTarea = Info.EstadoTarea;
                        _tarea.Estado = Info.Estado;
                        _tarea.Prioridad = Info.Prioridad;
                        _tarea.IdUsuarioCreacion = Info.IdUsuarioCreacion;
                        _tarea.FechaCreacion = Info.FechaCreacion;
                        _tarea.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        _tarea.FechaUltMod = Info.FechaUltMod;
                        _tarea.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        _tarea.FechaUltAnu = Info.FechaUltAnu;
                        _tarea.MotivoAnu = Info.MotivoAnu;
                    }
                }

                return _tarea;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public decimal GetID(int IdEmpresa)
        {
            try
            {
                decimal ID = 0;

                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var query = from q in context.tb_tarea
                                where q.IdEmpresa == IdEmpresa
                                select q;

                    if (query.Count() > 0)
                    {
                        ID = (from q in context.tb_tarea
                              where q.IdEmpresa == IdEmpresa
                              select q.IdTarea).Max() + 1;
                    }
                    else
                    {
                        ID = 1;
                    }
                }

                return ID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}