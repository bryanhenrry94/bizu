using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.General;

namespace Bizu.Infrastructure.General
{
    public interface Itb_Actividades_Horario_Data
    {
        List<tb_Actividades_Horario_Info> consultar(ref string mensajeErrorOut);
        tb_Actividades_Horario_Info consultar(string IdTransaccion, ref string mensajeErrorOut);
        Boolean GrabarDB(tb_Actividades_Horario_Info Info, ref string mensajeErrorOut);
        bool ModificarDB(tb_Actividades_Horario_Info Info, ref string mensajeErrorOut);
    }
}
