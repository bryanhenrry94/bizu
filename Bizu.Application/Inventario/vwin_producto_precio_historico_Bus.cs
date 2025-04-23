using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.Inventario;
using Bizu.Infrastructure.Inventario;

namespace Bizu.Application.Inventario
{
    public class vwin_producto_precio_historico_Bus
    {
        vwin_producto_precio_historico_Data Data = new vwin_producto_precio_historico_Data();

        public List<vwin_producto_precio_historico_Info> Get_List_Producto_Precio_Historico(int IdEmpresa, int IdBodega_Inicio, int IdBodega_Fin, int IdMarca, 
            int IdLinea, string IdCategoria, decimal IdProductoIni, decimal IdProductoFin)
        {
            try
            {
                return Data.Get_List_Producto_Precio_Historico(IdEmpresa,IdBodega_Inicio,IdBodega_Fin, IdMarca,IdLinea,IdCategoria,IdProductoIni,IdProductoFin);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Producto_Precio_Historico", ex.Message), ex) { EntityType = typeof(vwin_producto_precio_historico_Bus) };
            }
        }
    }
}
