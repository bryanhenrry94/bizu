using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Compras;
using Bizu.Infrastructure.Compras;
using Bizu.Application.General;

namespace Bizu.Application.Compras
{
    public class com_TerminoPago_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        com_TerminoPago_Data data = new com_TerminoPago_Data();

        public List<com_TerminoPago_Info> Get_List_TerminoPago()
        {
            try
            {
                return data.Get_List_TerminoPago();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_TerminoPago", ex.Message), ex) { EntityType = typeof(com_TerminoPago_Bus) };
            }

        }

        public Boolean GuardarDB(com_TerminoPago_Info Info)
        {
            try
            {
                return data.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_TerminoPago", ex.Message), ex) { EntityType = typeof(com_TerminoPago_Bus) };
            }
        }

        public bool ModificarDB(com_TerminoPago_Info info)
        {
            try
            {
                return data.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_TerminoPago", ex.Message), ex) { EntityType = typeof(com_TerminoPago_Bus) };
            }
        }

        public Boolean AnularDB(com_TerminoPago_Info Info)
        {
            try
            {
                return data.AnularDB(Info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_TerminoPago", ex.Message), ex) { EntityType = typeof(com_TerminoPago_Bus) };
            }
        }

    }
}