using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Business.General
{
    public class tb_Actividades_Horario_Tipo_Ejecucion_Bus
    {
        Itb_Actividades_Horario_Tipo_Ejecucion_Data Odata;

        public tb_Actividades_Horario_Tipo_Ejecucion_Bus()
        {
            Odata = new tb_Actividades_Horario_Tipo_Ejecucion_Data_SQL();
        }

        public List<tb_Actividades_Horario_Tipo_Ejecucion_Info> consultar(ref string mensajeErrorOut)
        {
            try
            {
                return Odata.consulta(ref mensajeErrorOut);
            }
            catch (Exception ex)
            {
                return new List<tb_Actividades_Horario_Tipo_Ejecucion_Info>();
            }
        }
    }
}
