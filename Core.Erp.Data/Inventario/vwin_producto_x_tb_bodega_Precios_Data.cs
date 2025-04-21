using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Inventario
{
    public class vwin_producto_x_tb_bodega_Precios_Data
    {
        string mensaje = "";

        public List<vwin_producto_x_tb_bodega_Precios_Info> Get_List_Producto_x_Bodega_Precios(int IdEmpresa, int IdBodega_Inicio, int IdBodega_Fin,
           int IdMarca, int IdLinea, string IdCategoria, decimal IdProductoIni, decimal IdProductoFin)
        {
            try
            {
                List<vwin_producto_x_tb_bodega_Precios_Info> lm = new List<vwin_producto_x_tb_bodega_Precios_Info>();
                EntitiesInventario OEInventario = new EntitiesInventario();

                IdProductoIni = (IdProductoIni == 0 ? 1 : IdProductoIni);
                IdProductoFin = (IdProductoFin == 0 ? 9999 : IdProductoFin);

                var sql = from A in OEInventario.vwin_producto_x_tb_bodega_Precios
                          where A.IdEmpresa == IdEmpresa
                          && A.IdBodega >= IdBodega_Inicio && A.IdBodega <= IdBodega_Fin
                          && A.IdProducto >= IdProductoIni && A.IdProducto <= IdProductoFin
                          select A;

                if (IdMarca != 0)
                    sql = sql.Where(q => q.IdMarca == IdMarca);

                if (IdCategoria != "")
                    sql = sql.Where(q => q.IdCategoria == IdCategoria);

                if (IdLinea != 0)
                    sql = sql.Where(q => q.IdLinea == IdLinea);                

                foreach (var item in sql)
                {
                    vwin_producto_x_tb_bodega_Precios_Info info = new vwin_producto_x_tb_bodega_Precios_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdProducto = item.IdProducto;
                    info.IdBodega = item.IdBodega;
                    info.pr_codigo = item.pr_codigo;
                    
                    info.pr_descripcion = "[" + item.IdProducto + "]" + item.pr_descripcion;
                    info.bo_Descripcion = item.bo_Descripcion;
                    info.IdSucursal = item.IdSucursal;
                    info.Su_Descripcion = item.Su_Descripcion;
                    info.IdMarca = item.IdMarca;
                    info.IdProductoTipo = item.IdProductoTipo;
                    info.IdPresentacion = item.IdPresentacion;
                    info.IdUnidadMedida = item.IdUnidadMedida;

                    info.pr_precio_publico = item.pr_precio_publico;
                    info.pr_precio_mayor = item.pr_precio_mayor;
                    info.pr_precio_puerta = item.pr_precio_puerta;
                    info.pr_precio_minimo = item.pr_precio_minimo;
                    
                    info.pr_precio_publico_nuevo = item.pr_precio_publico;
                    info.pr_precio_mayor_nuevo = item.pr_precio_mayor;                    
                    info.pr_precio_minimo_nuevo = item.pr_precio_minimo;

                    info.IdCategoria = item.IdCategoria;
                    info.nom_Categoria = item.nom_Categoria;
                    info.IdLinea = item.IdLinea;
                    info.nom_linea = item.nom_linea;
                  
                    lm.Add(info);
                }

                return lm;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }
    }
}
