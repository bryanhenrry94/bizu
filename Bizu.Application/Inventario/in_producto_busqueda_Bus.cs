using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Inventario;
using Bizu.Infrastructure.Inventario;
using Bizu.Domain.General;
using Bizu.Application.General;

namespace Bizu.Application.Inventario
{
   public class in_producto_busqueda_Bus
    {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje="";

       //in_producto_busqueda_Dat oD = new in_producto_busqueda_Dat();
       public List<in_Producto_Info> obtenerListProducto(List<in_categorias_Info> listCategoria, int IdEmpresa, int IdSucursal, int IdBodega)
       {
           try
           {
              //return oD.obtenerListProducto(listCategoria, IdEmpresa, IdSucursal, IdBodega);
               return new List<in_Producto_Info>();
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "obtenerListProducto", ex.Message), ex) { EntityType = typeof(in_producto_busqueda_Bus) };

           }


       }

       public List<in_Producto_Info> obtenerListProducto(int IdEmpresa, int IdSucursal, int IdBodega)
       {
           try
           {
               //return oD.obtenerListProducto(listCategoria, IdEmpresa, IdSucursal, IdBodega);
               return new List<in_Producto_Info>();
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "obtenerListProducto", ex.Message), ex) { EntityType = typeof(in_producto_busqueda_Bus) };

           }


       }
       
       public List<in_Producto_Info> Stokc_X_Bodeta(in_Producto_Info prd)
       {
           try
           {
               return new List<in_Producto_Info>();
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Stokc_X_Bodeta", ex.Message), ex) { EntityType = typeof(in_producto_busqueda_Bus) };

           }

       }
   }
}
