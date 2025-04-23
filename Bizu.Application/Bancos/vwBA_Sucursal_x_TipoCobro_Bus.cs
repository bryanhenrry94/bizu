using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Bancos;
using Bizu.Infrastructure .Bancos;
using Bizu.Application.General;

namespace Bizu.Application.Bancos
{
    public class vwBA_Sucursal_x_TipoCobro_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        vwBA_Sucursal_x_TipoCobro_Data data = new vwBA_Sucursal_x_TipoCobro_Data();
        public List<vwBA_Sucursal_x_TipoCobro_Info> Get_List_vwBA_Sucursal_x_TipoCobro(int IdEmpresa)
        {
            try
            {
                 return data.Get_List_vwBA_Sucursal_x_TipoCobro(IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_vwBA_Sucursal_x_TipoCobro", ex.Message), ex) { EntityType = typeof(vwBA_Sucursal_x_TipoCobro_Bus) };
            }

        }
    }
}
