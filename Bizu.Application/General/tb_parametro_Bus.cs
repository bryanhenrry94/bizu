using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bizu.Domain.General;
using Bizu.Infrastructure.General;
using Bizu.Application.General;


namespace Bizu.Application.General
{
   public class tb_parametro_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        tb_parametro_Data data = new tb_parametro_Data();
        string mensaje = "";


        public List<tb_parametro_Info> Get_List_parametro()
        {
            try
            {
                return data.Get_List_parametro();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_parametro", ex.Message), ex) { EntityType = typeof(tb_parametro_Bus) };

            }
        }

        public Boolean ModificarDB(tb_parametro_Info info, ref string msg)
        {
            try
            {
                return data.ModificarDB(info,ref msg );
            }
            catch (Exception ex)
            {
                       Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(tb_parametro_Bus) };
            }
        }


        public Boolean GuardarDB(tb_parametro_Info info, ref string msg)
        {
            try
            {
                return data.GuardarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(tb_parametro_Bus) };
            }
        }


        public string Get_valor_parametro(string  dato,  ref string msg)
        {
            try
            {
                return data.getValor(dato, ref msg);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_parametro", ex.Message), ex) { EntityType = typeof(tb_parametro_Bus) };

            }
        }


    }
}
