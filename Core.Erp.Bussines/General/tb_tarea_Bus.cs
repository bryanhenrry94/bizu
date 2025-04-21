using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Business.General
{
    public class tb_tarea_Bus
    {
        private tb_tarea_Data Data;

        public tb_tarea_Bus()
        {
            this.Data = new tb_tarea_Data();
        }

        public bool GrabarBD(tb_tarea_Info Info)
        {
            try
            {
                if (!this.Data.GrabarBD(Info))
                    return false;

                tb_tarea_equipo_Data data_tarea_equipo = new tb_tarea_equipo_Data();
                if (data_tarea_equipo.EliminarBD(Info.IdEmpresa, Info.IdTarea))
                {
                    foreach (var _item in Info.List_Tarea_Equipo)
                    {
                        _item.IdEmpresa = Info.IdEmpresa;
                        _item.IdTarea = Info.IdTarea;
                    }

                    data_tarea_equipo.GrabarBD(Info.List_Tarea_Equipo);
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
                if (!this.Data.ModificarBD(Info))
                    return false;

                tb_tarea_equipo_Data data_tarea_equipo = new tb_tarea_equipo_Data();
                if (data_tarea_equipo.EliminarBD(Info.IdEmpresa, Info.IdTarea))
                {
                    foreach(var _item in Info.List_Tarea_Equipo)
                    {
                        _item.IdEmpresa = Info.IdEmpresa;
                        _item.IdTarea = Info.IdTarea;
                    }

                    data_tarea_equipo.GrabarBD(Info.List_Tarea_Equipo);
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
                return this.Data.EliminarBD(Info);
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
                return this.Data.AnularBD(Info);
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
                return this.Data.GetList(IdEmpresa, IdUsuario, fechaIni, fechaFin, EstadoTarea);
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
                return this.Data.GetInfo(IdEmpresa, IdTarea);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
