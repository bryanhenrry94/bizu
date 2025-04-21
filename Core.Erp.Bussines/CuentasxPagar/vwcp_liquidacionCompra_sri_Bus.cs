using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;

namespace Core.Erp.Business.CuentasxPagar
{
    public class vwcp_liquidacionCompra_sri_Bus
    {
        vwcp_liquidacionCompra_sri_Data Data = new vwcp_liquidacionCompra_sri_Data();

        public List<vwcp_liquidacionCompra_sri_Info> Get_list_LiquidacionCompra_Sri(int IdEmpresa, decimal IdLiquidacionCompra, ref string msg)
        {
            try
            {
                return Data.Get_list_LiquidacionCompra_Sri(IdEmpresa, IdLiquidacionCompra, ref msg);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }
    }
}
