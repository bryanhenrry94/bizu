using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.General;
using Bizu.Domain.General;
using Bizu.Application.General;


namespace Bizu.Application.General
{
    public class vwtb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        vwtb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Data data = new vwtb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Data();
        public List<vwtb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info> Get_List_tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu(int IdEmpresa, string IdProcesoConta)
        {
            try
            {
                return data.Get_List_tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu(IdEmpresa, IdProcesoConta);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "obtenerLista", ex.Message), ex) { EntityType = typeof(vwtb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Bus) };
            }
        }
    }
}
