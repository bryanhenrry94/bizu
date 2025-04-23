using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bizu.Domain.Facturacion;
using Bizu.Infrastructure.Facturacion;
using Bizu.Application.General;
using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure.Contabilidad;
using Bizu.Application.Contabilidad;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;
using Bizu.Domain.Inventario;
using Bizu.Application.Inventario;
using Bizu.Infrastructure.Inventario;
using Bizu.Domain.class_sri.FacturaV2;
using Bizu.Domain.CuentasxCobrar;
using Bizu.Application.CuentasxCobrar;


namespace Bizu.Application.Facturacion
{
   public class fa_factura_x_fa_guia_remision_Bus
    {
       fa_factura_x_fa_guia_remision_Data data = new fa_factura_x_fa_guia_remision_Data();

       public fa_factura_x_fa_guia_remision_info Get_Info_GuiasxFactura(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
       {
           try
           {
               return data.Get_Info_fa_factura_x_fa_guia_remision(IdEmpresa, IdSucursal, IdBodega, IdCbteVta);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "get_CbteCble_x_Costo_Info", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };

           }
       }


       public Boolean GuardarFacxGuir(fa_factura_x_fa_guia_remision_info info)
       {
           try
           {
               return data.GuardarFacxGuir(info);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarFacxGuir", ex.Message), ex) { EntityType = typeof(fa_factura_Bus) };


           }
       }
      
    }
}
