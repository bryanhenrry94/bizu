using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Infrastructure.Facturacion;
using Bizu.Domain.Facturacion;

using Bizu.Application.General;

namespace Bizu.Application.Facturacion
{
   public class fa_pedido_x_formaPago_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
       fa_pedido_x_formaPago_Data odata = new fa_pedido_x_formaPago_Data();

       public Boolean GuardarDB(List<fa_pedido_x_formaPago_Info> Lista, ref string mensajeE)
       {

           try
           {
               return odata.GuardarDB(Lista, ref mensajeE);
           }
           catch (Exception ex)
           {


               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Guardar_FormaPagoPedido", ex.Message), ex) { EntityType = typeof(fa_pedido_x_formaPago_Bus) };
            
           }


       }


       public List<fa_pedido_x_formaPago_Info> Get_List_pedido_x_formaPago(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdPedido)
       {

           try
           {
               return odata.Get_List_pedido_x_formaPago(IdEmpresa, IdSucursal,  IdBodega, IdPedido);

           }
           catch (Exception ex)
           {

               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaLista_PedidoFormaPago", ex.Message), ex) { EntityType = typeof(fa_pedido_x_formaPago_Bus) };
           }
       }
    }
}
