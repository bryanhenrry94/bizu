using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.CuentasxPagar;
using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Application.General;

namespace Bizu.Application.CuentasxPagar
{
    public class cp_codigo_SRI_x_CtaCble_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cp_codigo_SRI_x_CtaCble_Data data = new cp_codigo_SRI_x_CtaCble_Data();


        public List<cp_codigo_SRI_x_CtaCble_Info> Get_codigo_SRI_x_CtaCble() {
            try
            {
                return data.Get_codigo_SRI_x_CtaCble();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_codigo_SRI_x_CtaCble", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_x_CtaCble_Bus) };
            }
        
        }

        public List<cp_codigo_SRI_x_CtaCble_Info> Get_codigo_SRI_x_CtaCble(int IdEmpresa)
        {
            try
            {
                return data.Get_codigo_SRI_x_CtaCble(IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_codigo_SRI_x_CtaCble", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_x_CtaCble_Bus) };
            }

        }


        public List<cp_codigo_SRI_x_CtaCble_Info> Get_codigo_SRI_x_CtaCble(int IdEmpresa, int IdCodigo_SRI)
        {
            try
            {
                return data.Get_codigo_SRI_x_CtaCble(IdEmpresa, IdCodigo_SRI);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_codigo_SRI_x_CtaCble", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_x_CtaCble_Bus) };
            }
        }


        public cp_codigo_SRI_x_CtaCble_Info GetInfo_codigo_SRI_x_CtaCble(int IdEmpresa, int IdCodigo_SRI)
        {
            try
            {
                return data.GetInfo_codigo_SRI_x_CtaCble(IdCodigo_SRI, IdEmpresa);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GetInfo_codigo_SRI_x_CtaCble", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_x_CtaCble_Bus) };
            }
        }


        public Boolean GuardarDB(cp_codigo_SRI_x_CtaCble_Info info)
        {
            try
            {
                return data.GuardarDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_x_CtaCble_Bus) };
            }

        }

        public Boolean ModificarDB(cp_codigo_SRI_x_CtaCble_Info info)
        {
            try
            {
                return data.ModificarDB(info);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_codigo_SRI_x_CtaCble_Bus) };
            }
        }

    }
}
