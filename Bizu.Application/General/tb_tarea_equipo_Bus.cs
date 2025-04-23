using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;

namespace Bizu.Application.General
{
    public class tb_tarea_equipo_Bus
    {
        private tb_tarea_equipo_Data data;

        public tb_tarea_equipo_Bus()
        {
            this.data = new tb_tarea_equipo_Data();
        }

        public bool GrabarBD(List<tb_tarea_equipo_Info> List_Info)
        {
            try
            {
                return this.data.GrabarBD(List_Info);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EliminarBD(int IdEmpresa, decimal IdTarea)
        {
            try
            {
                return this.data.EliminarBD(IdEmpresa, IdTarea);
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
                return this.data.Get_List(IdEmpresa, IdTarea);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}