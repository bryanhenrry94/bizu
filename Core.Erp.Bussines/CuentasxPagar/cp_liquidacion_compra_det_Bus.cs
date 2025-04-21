using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_liquidacion_compra_det_Bus
    {
        cp_liquidacion_compra_det_Data Data = new cp_liquidacion_compra_det_Data();

        public bool GrabarDB(List<cp_liquidacion_compra_det_Info> Info, ref string msg)
        {
            try
            {                               
                return Data.GrabarDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }

        public bool EliminarDB(int IdEmpresa, decimal IdLiquidacionCompra, ref string msg)
        {
            try
            {
                return Data.EliminarDB(IdEmpresa, IdLiquidacionCompra, ref msg);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }
    }
}
