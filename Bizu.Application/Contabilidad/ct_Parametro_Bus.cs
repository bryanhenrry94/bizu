using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure.Contabilidad;
using Bizu.Application.General;

namespace Bizu.Application.Contabilidad
{
    public class ct_Parametro_Bus
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ct_Parametro_Data data = new ct_Parametro_Data();
        #endregion
        
        public Boolean GuardarDB(ct_Parametro_Info Info)
        {
            try
            {
                return data.GuardarDB(Info); 
            }
            catch(Exception ex) 
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ct_Parametro_Bus) };
            }
        }

        public Boolean ModificarDB(ct_Parametro_Info Info)
        {
            try
            {
                return data.ModificarDB(Info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(ct_Parametro_Bus) };
            }
        }

        public ct_Parametro_Info Get_Info_Parametro(int IdEmpresa)
        {
            try
            {
                return data.Get_Info_Parametro(IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_Parametro", ex.Message), ex) { EntityType = typeof(ct_Parametro_Bus) };
            }
        }
    }
}
