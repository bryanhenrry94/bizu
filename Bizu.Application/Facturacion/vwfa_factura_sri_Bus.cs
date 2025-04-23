using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Infrastructure.Facturacion;
using Bizu.Domain.Facturacion;
using Bizu.Application.General;

namespace Bizu.Application.Facturacion
{
    public class vwfa_factura_sri_Bus
    {
        vwfa_factura_sri_Data oData = new vwfa_factura_sri_Data();

        public List<vwfa_factura_sri_Info> Get_list_Factura_Sri(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta, ref string msg)
        {
            try
            {
                return oData.Get_list_Factura_Sri(IdEmpresa, IdSucursal, IdBodega, IdCbteVta, ref msg);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "get_CbteCble_x_Costo_Info", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };
            }
        }
    }
}
