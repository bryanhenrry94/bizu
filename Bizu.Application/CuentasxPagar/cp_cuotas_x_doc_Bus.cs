using Bizu.Application.General;
using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Domain.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Application.CuentasxPagar
{
    public class cp_cuotas_x_doc_Bus
    {
        cp_cuotas_x_doc_Data oData = new cp_cuotas_x_doc_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public List<cp_cuotas_x_doc_Info> Get_list_cuotas_x_doc(int IdEmpresa)
        {
            try
            {
                return oData.Get_list_cuotas_x_doc(IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_cuotas_x_doc", ex.Message), ex) { EntityType = typeof(cp_cuotas_x_doc_Bus) };
            }
        }

        public cp_cuotas_x_doc_Info Get_info_cuotas_x_doc(int IdEmpresa, decimal IdCuota)
        {
            try
            {
                return oData.Get_info_cuotas_x_doc(IdEmpresa, IdCuota);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_cuotas_x_doc", ex.Message), ex) { EntityType = typeof(cp_cuotas_x_doc_Bus) };
            }
        }

        public cp_cuotas_x_doc_Info Get_info_cuotas_x_doc(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
        {
            try
            {
                return oData.Get_info_cuotas_x_doc(IdEmpresa, IdTipoCbte,IdCbteCble);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_cuotas_x_doc", ex.Message), ex) { EntityType = typeof(cp_cuotas_x_doc_Bus) };
            }
        }

        public Boolean GuardarDB(cp_cuotas_x_doc_Info info)
        {
            try
            {
                return oData.GuardarDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_cuotas_x_doc", ex.Message), ex) { EntityType = typeof(cp_cuotas_x_doc_Bus) };
            }
        }

        public Boolean ModificarDB(cp_cuotas_x_doc_Info info)
        {
            try
            {
                return oData.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_cuotas_x_doc", ex.Message), ex) { EntityType = typeof(cp_cuotas_x_doc_Bus) };
            }
        }

        public Boolean AnularDB(int IdEmpresa, decimal IdCuota)
        {
            try
            {
                return oData.AnularDB(IdEmpresa, IdCuota);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_cuotas_x_doc", ex.Message), ex) { EntityType = typeof(cp_cuotas_x_doc_Bus) };
            }
        }
    }
}
