using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;

namespace Core.Erp.Data.General
{
    public interface Itb_Actividades_Horario_Tipo_Ejecucion_Data
    {
        List<tb_Actividades_Horario_Tipo_Ejecucion_Info> consulta(ref string mensajeErrorOut);
    }
}
