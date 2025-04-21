using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Business.General
{
    public class tb_Actividades_Horario_Acciones_Bus
    {
        Itb_Actividades_Horario_Acciones_Data Odata;

        public tb_Actividades_Horario_Acciones_Bus()
        {
            try
            {
                Odata = new tb_Actividades_Horario_Acciones_Data_SQL();

            }
            catch (Exception ex)
            {


            }

        }

        public List<tb_Actividades_Horario_Acciones_Info> consultar(string sIdTransaccion, ref string mensajeErrorOut)
        {
            try
            {
                return Odata.Consultar(sIdTransaccion, ref mensajeErrorOut);
            }
            catch (Exception ex)
            {

                return new List<tb_Actividades_Horario_Acciones_Info>();
            }
        }

        public bool GrabarDB(List<tb_Actividades_Horario_Acciones_Info> ListInfo, ref string mensajeErrorOut)
        {
            try
            {
                return Odata.GrabarDB(ListInfo, ref mensajeErrorOut);
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
