using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.Bancos;
using Bizu.Domain.Bancos;
using Bizu.Application.General;

namespace Bizu.Application.Bancos
{
    public class ba_Cbte_Ban_tipo_x_CodBancoExterno_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_Cbte_Ban_tipo_x_CodBancoExterno_Data data = new ba_Cbte_Ban_tipo_x_CodBancoExterno_Data();

        public List<ba_Cbte_Ban_tipo_x_CodBancoExterno_Info> Get_List_Cbte_Ban_tipo_x_CodBancoExterno()
        {
            try
            {
              return data.Get_List_Cbte_Ban_tipo_x_CodBancoExterno();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Cbte_Ban_tipo_x_CodBancoExterno", ex.Message), ex) { EntityType = typeof(ba_Cbte_Ban_tipo_x_CodBancoExterno_Bus) };
            }

        }
    }
}
