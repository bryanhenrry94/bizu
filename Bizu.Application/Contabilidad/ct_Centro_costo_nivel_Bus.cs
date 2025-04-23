using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure.Contabilidad;
using Bizu.Application.General;

namespace Bizu.Application.Contabilidad
{
    public class ct_Centro_costo_nivel_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public List<ct_Centro_costo_nivel_Info> Get_list_Centro_costo_nivel(int IdEmpresa)
        {
            List<ct_Centro_costo_nivel_Info> lm = new List<ct_Centro_costo_nivel_Info>();
            ct_Centro_costo_nivel_Data data = new ct_Centro_costo_nivel_Data();


            try
            {
                lm = data.Get_Info_Centro_Costo_nivel(IdEmpresa);
                return (lm);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_nivel_Bus) };
            }
        }
        
        public Boolean ModificarDB(ct_Centro_costo_nivel_Info info)
        {
            try
            {
                ct_Centro_costo_nivel_Data data = new ct_Centro_costo_nivel_Data();
                return data.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_nivel_Bus) };
            }
        }

        public Boolean EliminarDB(ct_Centro_costo_nivel_Info info)
        {
            try
            {
                ct_Centro_costo_nivel_Data data = new ct_Centro_costo_nivel_Data();
                return data.EliminarDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_nivel_Bus) };
            }
        }

        public Boolean GrabarDB(ct_Centro_costo_nivel_Info info)
        {
            try
            {
                ct_Centro_costo_nivel_Data data = new ct_Centro_costo_nivel_Data();
                return data.GrabarDB(info);
            }
            catch (Exception ex) 
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_nivel_Bus) };
            }
        }

        public int Get_Id(int IdEmpresa)
        {
            try
            {
                ct_Centro_costo_nivel_Data data = new ct_Centro_costo_nivel_Data();
                return data.Get_Id(IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_Centro_costo_nivel_Bus) };
            }
        }

        public ct_Centro_costo_nivel_Bus()
        {
            
        }
    }
}
