using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure.Contabilidad;
using Bizu.Application.General;

namespace Bizu.Application.Contabilidad
{
    public class ct_cbtecble_Reversado_Bus
    {
        string mensaje = "";

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ct_cbtecble_Reversado_Data oData = new ct_cbtecble_Reversado_Data();

        public Boolean GuardarDB(ct_cbtecble_Reversado_Info Info)
        {
            try
            {
                return oData.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ct_cbtecble_Reversado_Bus) };
                
            }
        }

        public ct_cbtecble_Reversado_Info Get_Info_cbtecble_Reversado(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
        {
            try
            {
                  return oData.Get_CbteCble_Reversado_Info(IdEmpresa, IdTipoCbte, IdCbteCble);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_CbteCble_Reversado_Info", ex.Message), ex) { EntityType = typeof(ct_cbtecble_Reversado_Bus) };
            }

        
        }
    }
}
