using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.Facturacion;
using Bizu.Infrastructure.Facturacion;
using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;

namespace Bizu.Application.Facturacion
{
    class fa_factura_x_in_Ing_Egr_Inven_Bus
    {
        fa_factura_x_in_Ing_Egr_Inven_Data data = new fa_factura_x_in_Ing_Egr_Inven_Data();

        public Boolean GuardarDB(fa_factura_x_in_Ing_Egr_Inven_Info info, ref string mensajeE)
        {
            try
            {
                return data.GuardarDB(info, ref mensajeE);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_factura_x_in_Ing_Egr_Inven_Bus) };

            }

        }

        public fa_factura_x_in_Ing_Egr_Inven_Info Get_Info_fa_factura_x_in_Ing_Egr_Inven_Relacion(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                return data.Get_Info_fa_factura_x_in_Ing_Egr_Inven_Relacion(IdEmpresa, IdSucursal, IdBodega, IdCbteVta);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "get_CbteCble_x_Costo_Info", ex.Message), ex) { EntityType = typeof(fa_factura_x_in_Ing_Egr_Inven_Bus) };
            }
        }
    }
}
