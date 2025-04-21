using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;

namespace Core.Erp.Data.General
{
    public class tb_Actividades_Horario_Tipo_Tiempo_Data_SQL : Itb_Actividades_Horario_Tipo_Tiempo_Data
    {
        public List<tb_Actividades_Horario_Tipo_Tiempo_Info> consultar()
        {
            try
            {
                List<tb_Actividades_Horario_Tipo_Tiempo_Info> lista = new List<tb_Actividades_Horario_Tipo_Tiempo_Info>();

                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();

                var selectEmpresa = from C in OEselecEmpresa.tb_Actividades_Horario_Tipo_Tiempo
                                    select C;

                foreach (var item in selectEmpresa)
                {
                    tb_Actividades_Horario_Tipo_Tiempo_Info Cbt = new tb_Actividades_Horario_Tipo_Tiempo_Info();

                    Cbt.IdTipoTiempo = item.IdTipoTiempo;
                    Cbt.descripcion = item.descripcion;
                    lista.Add(Cbt);
                }

                return lista;
            }
            catch (Exception ex)
            {

                return new List<tb_Actividades_Horario_Tipo_Tiempo_Info>();
            }
        }
    }
}
