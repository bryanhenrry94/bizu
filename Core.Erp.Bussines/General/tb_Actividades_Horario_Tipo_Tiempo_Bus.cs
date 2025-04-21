using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Business.General
{
    public class tb_Actividades_Horario_Tipo_Tiempo_Bus
    {
        tb_Actividades_Horario_Tipo_Tiempo_Data_SQL Odata;


        public tb_Actividades_Horario_Tipo_Tiempo_Bus()
        {
            Odata = new tb_Actividades_Horario_Tipo_Tiempo_Data_SQL();
        }

        public List<tb_Actividades_Horario_Tipo_Tiempo_Info> consultar()
        {
            try
            {
                return Odata.consultar();
            }
            catch (Exception ex)
            {
                return new List<tb_Actividades_Horario_Tipo_Tiempo_Info>();
            }
        }
    }
}
