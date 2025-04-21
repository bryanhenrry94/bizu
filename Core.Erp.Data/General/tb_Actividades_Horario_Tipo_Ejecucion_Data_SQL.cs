using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;

namespace Core.Erp.Data.General
{
    public class tb_Actividades_Horario_Tipo_Ejecucion_Data_SQL : Itb_Actividades_Horario_Tipo_Ejecucion_Data
    {
        public List<tb_Actividades_Horario_Tipo_Ejecucion_Info> consulta(ref string mensajeErrorOut)
        {
            try
            {
                List<tb_Actividades_Horario_Tipo_Ejecucion_Info> TEjecuacion = new List<tb_Actividades_Horario_Tipo_Ejecucion_Info>();

                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();

                var selectEmpresa = from C in OEselecEmpresa.tb_Actividades_Horario_Tipo_Ejecucion
                                    select C;

                foreach (var item in selectEmpresa)
                {
                    tb_Actividades_Horario_Tipo_Ejecucion_Info Cbt = new tb_Actividades_Horario_Tipo_Ejecucion_Info();


                    Cbt.IdTipoEjecucion = item.IdTipoEjecucion;
                    Cbt.Descripcion = item.Descripcion;

                    TEjecuacion.Add(Cbt);
                }

                return TEjecuacion;
            }
            catch (Exception ex)
            {
                return new List<tb_Actividades_Horario_Tipo_Ejecucion_Info>();
            }
        }
    }
}
