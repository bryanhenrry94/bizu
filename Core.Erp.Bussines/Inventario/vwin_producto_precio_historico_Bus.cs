using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;

namespace Core.Erp.Business.Inventario
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
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Producto_Precio_Historico", ex.Message), ex) { EntityType = typeof(vwin_producto_precio_historico_Bus) };
            }
        }
    }
}
