using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.General;

namespace Bizu.Infrastructure.General
{
    interface Itb_Actividades_Horario_Tipo_Tiempo_Data
    {
        List<tb_Actividades_Horario_Tipo_Tiempo_Info> consultar();
    }
}
