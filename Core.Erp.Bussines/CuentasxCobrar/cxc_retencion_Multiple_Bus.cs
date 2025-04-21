using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.General;

namespace Core.Erp.Business.CuentasxCobrar
{
    public class cxc_retencion_Multiple_Bus
    {
        #region Declaración de variables
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cxc_retencion_Multiple_Data Data = new cxc_retencion_Multiple_Data();
        #endregion

        public Boolean GuardarDB(cxc_retencion_Multiple_Info Info)
        {
            try { return Data.GuardarDB(Info); }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_retencion_Multiple_Bus) };
            }
        }
        public Boolean ModificarDB(cxc_retencion_Multiple_Info Info)
        {
            try { return Data.ModificarDB(Info); }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_retencion_Multiple_Bus) };
            }
        }
        public Boolean AnularDB(cxc_retencion_Multiple_Info Info)
        {
            try { return Data.AnularDB(Info); }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_retencion_Multiple_Bus) };
            }
        }

        public List<cxc_cobro_Info> Get_List_Cobros_para_Consulta_Retenciones(int IdEmpresa, int idSucursal, DateTime desde, DateTime hasta)
        {
            try
            {
                return Data.Get_List_Cobros_para_Consulta_Retenciones(IdEmpresa, idSucursal, desde, hasta);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cobros_para_Consulta", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }

        }
    }
}
