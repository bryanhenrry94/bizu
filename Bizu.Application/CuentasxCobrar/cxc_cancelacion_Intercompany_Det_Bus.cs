using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.CuentasxCobrar;
using Bizu.Domain.CuentasxCobrar;
using Bizu.Application.General;

namespace Bizu.Application.CuentasxCobrar
{
    public class cxc_cancelacion_Intercompany_Det_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cxc_cancelacion_Intercompany_Det_Data Data = new cxc_cancelacion_Intercompany_Det_Data();

        public List<cxc_cancelacion_Intercompany_det_Info> Get_List_cancelacion_Intercompany_det(int IdEmpresa, decimal IdCancelacion)
        {
            try
            {
                  return Data.Get_List_cancelacion_Intercompany_det(IdEmpresa, IdCancelacion);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_cancelacion_Intercompany_det", ex.Message), ex) { EntityType = typeof(cxc_cancelacion_Intercompany_Det_Bus) };
            }

        }

        public Boolean GuardarDB(List<cxc_cancelacion_Intercompany_det_Info> info)
        {
            try
            {
                return Data.GuardarDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_cancelacion_Intercompany_Det_Bus) };
            }

        }

        public cxc_cancelacion_Intercompany_det_Info Get_List_cancelacion_Intercompany_det(int IdEmpresa, decimal IdCancelacion, int Secuencia)
        {
            try
            {
                return Data.Get_List_cancelacion_Intercompany_det(IdEmpresa, IdCancelacion, Secuencia);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_cancelacion_Intercompany_det", ex.Message), ex) { EntityType = typeof(cxc_cancelacion_Intercompany_Det_Bus) };
            }

        }
    }
}
