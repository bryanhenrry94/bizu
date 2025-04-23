using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;
using Bizu.Application.General;



namespace Bizu.Application.General
{
    public class tb_moneda_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        tb_moneda_Data oData = new tb_moneda_Data();
        public List<tb_moneda_info> Get_List_Moneda()
        {
            try
            {
             return oData.Get_List_Moneda();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerMonedas", ex.Message), ex) { EntityType = typeof(tb_moneda_Bus) };
                
            }

        }
    }
}
