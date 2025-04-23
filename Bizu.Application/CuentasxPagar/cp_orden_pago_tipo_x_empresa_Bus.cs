using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Domain.CuentasxPagar;
using Bizu.Application.General;

namespace Bizu.Application.CuentasxPagar
{
    public class cp_orden_pago_tipo_x_empresa_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cp_orden_pago_tipo_x_empresa_Data data = new cp_orden_pago_tipo_x_empresa_Data();
        public List<cp_orden_pago_tipo_x_empresa_Info> Get_List_orden_pago_tipo_x_empresa(int IdEmpresa)
        {
            try
            {
                return data.Get_List_orden_pago_tipo_x_empresa(IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_orden_pago_tipo_x_empresa", ex.Message), ex) { EntityType = typeof(cp_orden_pago_tipo_x_empresa_Bus) };
            }
        }

        public cp_orden_pago_tipo_x_empresa_Info Get_Info_orden_pago_tipo_x_empresa(int IdEmpresa, string IdTipo_Op)
        {
            try
            {
                return data.Get_Info_orden_pago_tipo_x_empresa(IdEmpresa,IdTipo_Op);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_orden_pago_tipo_x_empresa", ex.Message), ex) { EntityType = typeof(cp_orden_pago_tipo_x_empresa_Bus) };
            }
        }
        public Boolean GuardarDB(cp_orden_pago_tipo_x_empresa_Info Info, ref string msgError)
        {
            try
            {
                return data.GuardarDB(Info, ref msgError);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_orden_pago_tipo_x_empresa_Bus) };
            }
        }

        public Boolean ModificarDB(cp_orden_pago_tipo_x_empresa_Info Info, ref string msgError)
        {
            try
            {
                return data.ModificarDB(Info ,ref msgError);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_orden_pago_tipo_x_empresa_Bus) };
            }
        }

        public Boolean ValidarCodigoExiste(string cod, int IdEmpresa)
        {
            try
            {
                return data.ValidarCodigoExiste(cod,IdEmpresa);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ValidarCodigoExiste", ex.Message), ex) { EntityType = typeof(cp_orden_pago_tipo_x_empresa_Bus) };
            }
        }
    }
}
