using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class vwin_producto_x_tb_bodega_Precios_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        vwin_producto_x_tb_bodega_Precios_Data data = new vwin_producto_x_tb_bodega_Precios_Data();

        public List<vwin_producto_x_tb_bodega_Precios_Info> Get_List_Producto_x_Bodega_Precios(int idempresa, int idbodega_Inicio, int idbodega_Fin, int IdMarca, int IdLinea, string IdCategoria, decimal IdProductoIni, decimal IdProductoFin)
        {
            try
            {
                return data.Get_List_Producto_x_Bodega_Precios(idempresa, idbodega_Inicio, idbodega_Fin, IdMarca, IdLinea, IdCategoria, IdProductoIni, IdProductoFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Producto_x_Bodega_Precios", ex.Message), ex) { EntityType = typeof(vwin_producto_x_tb_bodega_Precios_Bus) };

            }
        }
    }
}
