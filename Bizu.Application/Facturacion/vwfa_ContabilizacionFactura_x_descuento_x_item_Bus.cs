using Bizu.Infrastructure.Facturacion;
using Bizu.Domain.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Application.Facturacion
{
    public class vwfa_ContabilizacionFactura_x_descuento_x_item_Bus
    {
        vwfa_ContabilizacionFactura_x_descuento_x_item_Data oData = new vwfa_ContabilizacionFactura_x_descuento_x_item_Data();

        public List<vwfa_ContabilizacionFactura_x_descuento_x_item_Info> get_list(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                return oData.get_list(IdEmpresa, IdSucursal, IdBodega, IdCbteVta);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "get_list", ex.Message), ex) { EntityType = typeof(vwfa_ContabilizacionFactura_x_descuento_x_item_Bus) };
            }  
        }
    }
}
