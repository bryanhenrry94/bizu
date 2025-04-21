using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;

namespace Core.Erp.Data.General
{
    public class tb_tarea_equipo_Data
    {
        public bool GrabarBD(List<tb_tarea_equipo_Info> List_Info)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();

                foreach(var _item in List_Info)
                {
                    tb_tarea_equipo _tarea_equipo = new tb_tarea_equipo();
                    _tarea_equipo.IdEmpresa = _item.IdEmpresa;
                    _tarea_equipo.IdTarea = _item.IdTarea;
                    _tarea_equipo.IdUsuario = _item.IdUsuario;
                    context.tb_tarea_equipo.Add(_tarea_equipo);
                    context.SaveChanges();
                }

                return true;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool EliminarBD(int IdEmpresa, decimal IdTarea)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();

                int iResult = context.Database.ExecuteSqlCommand("DELETE FROM tb_tarea_equipo WHERE IdEmpresa = " + IdEmpresa + " AND IdTarea = " + IdTarea);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tb_tarea_equipo_Info> Get_List(int IdEmpresa, decimal IdTarea)
        {
            try
            {
                List<tb_tarea_equipo_Info> list_tarea_equipo = new List<tb_tarea_equipo_Info>();

                EntitiesGeneral context = new EntitiesGeneral();

                var query = from q in context.tb_tarea_equipo
                            where q.IdEmpresa == IdEmpresa
                            && q.IdTarea == IdTarea
                            select q;

                foreach (var _item in query)
                {
                    tb_tarea_equipo_Info _tarea_equipo = new tb_tarea_equipo_Info();
                    _tarea_equipo.IdEmpresa = _item.IdEmpresa;
                    _tarea_equipo.IdTarea = _item.IdTarea;
                    _tarea_equipo.IdUsuario = _item.IdUsuario;

                    list_tarea_equipo.Add(_tarea_equipo);
                }

                return list_tarea_equipo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
