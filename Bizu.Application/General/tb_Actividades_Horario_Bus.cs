using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;

namespace Bizu.Application.General
{
    public class tb_Actividades_Horario_Bus
    {
        Itb_Actividades_Horario_Data Odata;
        Itb_Actividades_Horario_Acciones_Data OdataAcciones;


        public tb_Actividades_Horario_Bus()
        {
            Odata = new tb_Actividades_Horario_Data_SQL();
            OdataAcciones = new tb_Actividades_Horario_Acciones_Data_SQL();
        }

        public List<tb_Actividades_Horario_Info> consultar(ref string mensajeErrorOut)
        {
            try
            {

                return Odata.consultar(ref mensajeErrorOut);
            }
            catch (Exception ex)
            {

                return new List<tb_Actividades_Horario_Info>();
            }
        }


        public tb_Actividades_Horario_Info consultar(string IdTransaccion, ref string mensajeErrorOut)
        {
            try
            {


                return Odata.consultar(IdTransaccion, ref mensajeErrorOut);
            }
            catch (Exception ex)
            {

                return new tb_Actividades_Horario_Info();
            }
        }

        public Boolean GrabarDB(tb_Actividades_Horario_Info Info, ref string mensajeErrorOut)
        {
            try
            {

                Odata.GrabarDB(Info, ref mensajeErrorOut);
                OdataAcciones.GrabarDB(Info.listaAcciones, ref mensajeErrorOut);

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }


        public bool ModificarDB(tb_Actividades_Horario_Info Info, ref string mensajeErrorOut)
        {
            try
            {

                Odata.ModificarDB(Info, ref mensajeErrorOut);
                OdataAcciones.GrabarDB(Info.listaAcciones, ref mensajeErrorOut);

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
