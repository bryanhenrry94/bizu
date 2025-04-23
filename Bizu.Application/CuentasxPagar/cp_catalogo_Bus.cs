using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.CuentasxPagar;
using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Application.CuentasxPagar;

using Bizu.Application.General;

namespace Bizu.Application.CuentasxPagar
{
    public class cp_catalogo_Bus
    {
        cp_catalogo_Data oData = new cp_catalogo_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        public List<cp_catalogo_Info> Get_List_catalogo(string IdCatalogo_tipo)
        {
            try
            {
                return oData.Get_List_catalogo(IdCatalogo_tipo);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_catalogo", ex.Message), ex) { EntityType = typeof(cp_catalogo_Bus) };
            }
        
        }
    }
}
