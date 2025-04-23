using Bizu.Infrastructure.General;
using Bizu.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Application.General
{
    public class tb_banco_procesos_bancarios_tipo_Bus
    {
        tb_banco_procesos_bancarios_tipo_Data oData = new tb_banco_procesos_bancarios_tipo_Data();

        public List<tb_banco_procesos_bancarios_tipo_Info> Get_list_procesos()
        {
            try
            {
                return oData.Get_list_procesos();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_procesos", ex.Message), ex) { EntityType = typeof(tb_banco_procesos_bancarios_tipo_Bus) };
            }
        }

        public bool GuardarDB(tb_banco_procesos_bancarios_tipo_Info Info, ref string mensaje)
        {
            try
            {
                return oData.GuardarDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public bool ModificarDB(tb_banco_procesos_bancarios_tipo_Info Info, ref string mensaje)
        {
            try
            {
                return oData.ModificarDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }
    }
}
