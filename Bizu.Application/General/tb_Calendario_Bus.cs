using Bizu.Infrastructure.General;
using Bizu.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Application.General;


namespace Bizu.Application.General
{
    public class tb_Calendario_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        tb_Calendario_Data Data = new tb_Calendario_Data();

        public List<tb_Calendario_Info> Get_List_DiasSinFeriadoNiSabadosNiDomingos(DateTime FechaInicial, int CantidadDiasaObtener)
        {
            try
            {
            return Data.Get_List_DiasSinFeriadoNiSabadosNiDomingos(FechaInicial, CantidadDiasaObtener);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Obtener_Bodegas", ex.Message), ex) { EntityType = typeof(tb_Calendario_Bus) };
         
            }

        }

        public tb_Calendario_Info Get_Info_Calendario(DateTime fecha)
        {
            try
            {
                return Data.Get_Info_Calendario(fecha);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaGeneralxFecha", ex.Message), ex) { EntityType = typeof(tb_Calendario_Bus) };
         
            }
           
        
        }

        public List<tb_Calendario_Info> Get_List_Calendario()
        {
            try
            {
                return Data.Get_List_Calendario();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaCalendarioFeriadoSi", ex.Message), ex) { EntityType = typeof(tb_Calendario_Bus) };

            }

        }

        public List<tb_Calendario_Info> Get_List_Calendario_Feriad()
        {
            try
            {
                return Data.Get_List_Calendario_Feriado();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaCalendarioFeriado", ex.Message), ex) { EntityType = typeof(tb_Calendario_Bus) };
         
            }
          
        }

        public List<tb_Calendario_Info> Get_List_Calendario_Feriado()
        {
            try
            {
                return Data.Get_List_Calendario_Feriado();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaCalendarioFeriadoSi", ex.Message), ex) { EntityType = typeof(tb_Calendario_Bus) };
         
            }
           
        }

        public int ConsultaMaxMin(int i) {
            try
            {
                 return Data.ConsultaMaxMin(i);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaMaxMin", ex.Message), ex) { EntityType = typeof(tb_Calendario_Bus) };
         
            }

        }

        public List<tb_Calendario_Info> Get_List_Calendario_x_rango_fechas(DateTime Fecha_Ini, DateTime Fecha_Fin)
        {
            try
            {
                return Data.Get_List_Calendario_x_rango_fechas(Fecha_Ini,Fecha_Fin);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Calendario_x_rango_fechas", ex.Message), ex) { EntityType = typeof(tb_Calendario_Bus) };

            }
        }

        public List<tb_Calendario_Info> Get_List_Calendario_Feriado_x_ani(int anio)
        {
            try
            {
               return Data.Get_List_Calendario_Feriado_x_anio(anio);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaFecha", ex.Message), ex) { EntityType = typeof(tb_Calendario_Bus) };
         
            }

        }

        public Boolean GrabarFeriadoDescripcion(List<tb_Calendario_Info> info) {
            try
            {
                return Data.GrabarFeriadoDescripcion(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaFecha", ex.Message), ex) { EntityType = typeof(tb_Calendario_Bus) };
         
            }
       
        }
        public Boolean ExisteIDCalendario_ro(int IdCalendario)
        {
            try
            {
                return Data.Get_Existe_IdCalendario_ro(IdCalendario);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ExisteIDCalendario", ex.Message), ex) { EntityType = typeof(tb_Calendario_Bus) };

            }

        }



        public Boolean ExisteIDCalendario(int IdCalendario) {
            try
            {
                   return Data.Get_Existe_IdCalendario(IdCalendario);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ExisteIDCalendario", ex.Message), ex) { EntityType = typeof(tb_Calendario_Bus) };
         
            }

        }

        public Boolean Get_ExisteFeriad(int IdCalendario)
        {
            try
            {
                 return Data.Get_ExisteFeriado(IdCalendario);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ExisteFeriado", ex.Message), ex) { EntityType = typeof(tb_Calendario_Bus) };
         
            }

        }

        public Boolean GrabarDB(tb_Calendario_Info info)
        {
            try
            {
                return Data.GrabarDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarFeriado", ex.Message), ex) { EntityType = typeof(tb_Calendario_Bus) };
         
            }

        }

        public Boolean ModificarD(tb_Calendario_Info info)
        {
            try
            {
                return Data.ModificarDB(info); 
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarFeriado", ex.Message), ex) { EntityType = typeof(tb_Calendario_Bus) };
         
            }

        }

        public Boolean AnularFeriado(tb_Calendario_Info info) {
            try
            {
                return Data.AnularDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "AnularFeriado", ex.Message), ex) { EntityType = typeof(tb_Calendario_Bus) };
         
            }

        }

        //Derek Mejía Soria 17/12/2013
        public List<tb_Calendario_Info> ConsultaGeneralGP() {
            try
            {
               return Data.Get_List_Calendario_Agrupado_x_anio();     
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaGeneralGP", ex.Message), ex) { EntityType = typeof(tb_Calendario_Bus) };
         
            }
   
        }
    }
}
