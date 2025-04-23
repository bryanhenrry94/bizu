using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bizu.Domain.CuentasxPagar;
using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Application.General;

namespace Bizu.Application.CuentasxPagar
{
    public class vwcp_Anticipos_para_Conciliar_Bus
    {
        vwcp_Anticipos_para_Conciliar_Data Data = new vwcp_Anticipos_para_Conciliar_Data();

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public List<vwcp_Anticipos_para_Conciliar_Info> Get_list_Anticipos_para_Conciliar(int IdEmpresa, string tipo, DateTime cb_fechaDesde, DateTime cb_fechaHasta, ref string mensaje)
        {
            try
            {
                return Data.Get_list_Anticipos_para_Conciliar(IdEmpresa, tipo, cb_fechaDesde, cb_fechaHasta, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_Anticipos_para_Conciliar", ex.Message), ex) { EntityType = typeof(vwcp_Anticipos_para_Conciliar_Bus) };
            }
        }
    }
}