using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;
using Bizu.Application.General;


namespace Bizu.Application.General
{
    public class tb_tarjeta_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        tb_tarjeta_Data oData = new tb_tarjeta_Data();
        public List<tb_tarjeta_Info> Get_List_tarjeta()
        {
            try
            {
                return oData.Get_List_tarjeta();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ListaTarjetas", ex.Message), ex) { EntityType = typeof(tb_tarjeta_Bus) };
           
            }

        }

        public int GetId()
        {
            try
            {
                return oData.GetId();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ListaTarjetas", ex.Message), ex) { EntityType = typeof(tb_tarjeta_Bus) };
           
            }
        }

        public Boolean GuardarDB(tb_tarjeta_Info Info)
        {
            try
            {
                return oData.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Grabar .." + ex.Message;
                return false;
            }

        }

        public Boolean ModificarDB(tb_tarjeta_Info Info)
        {
            try
            {
                return oData.ModificarDB(Info);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Modificar .." + ex.Message;
                return false;
            }
        }

        public Boolean AnularDB(tb_tarjeta_Info Info)
        {
            try
            {
                return oData.AnularDB(Info);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error al Anular .." + ex.Message;
            }
            return false;
        }

    }
}
