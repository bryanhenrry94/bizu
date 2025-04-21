using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;

namespace Core.Erp.Data.General
{
    public interface Itb_Actividades_Horario_Acciones_Data
    {
        List<tb_Actividades_Horario_Acciones_Info> Consultar(string sIdTransaccion, ref string mensajeErrorOut);

        bool GrabarDB(List<tb_Actividades_Horario_Acciones_Info> ListInfo, ref string mensajeErrorOut);
    }
}
