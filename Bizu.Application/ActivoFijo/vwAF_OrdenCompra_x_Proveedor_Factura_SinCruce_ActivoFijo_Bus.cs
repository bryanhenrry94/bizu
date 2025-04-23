using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Infrastructure.ActivoFijo;
using Bizu.Domain.ActivoFijo;
using Bizu.Domain.Facturacion;

namespace Bizu.Application.ActivoFijo
{
    public class vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Bus
    {
        vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Data dataOcActivo = new vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Data();

        public List<vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info> Get_List_OC_Factura_ActivoFijo(int IdEmpresa, decimal IdProveedor, List<fa_catalogo_Info> lstNaturaleza)
        {
            try
            {
                return dataOcActivo.Get_List_OC_Factura_ActivoFijo(IdEmpresa, IdProveedor, lstNaturaleza);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_OC_Factura_ActivoFijo", ex.Message), ex) { EntityType = typeof(vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Bus) };
            }
        }

        public vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info Get_Info_OC_Factura_ActivoFijo(int IdEmpresa, decimal IdProveedor, int IdOrdenCompra, int secuencia)
        {
            try
            {
                return dataOcActivo.Get_Info_OC_Factura_ActivoFijo(IdEmpresa, IdProveedor, IdOrdenCompra, secuencia);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_OC_Factura_ActivoFijo", ex.Message), ex) { EntityType = typeof(vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Bus) };
            }
        }


        public vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Bus()
        {

        }
    }
}
