using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.Inventario;
using Bizu.Domain.Inventario;
using Bizu.Application.General;

namespace Bizu.Application.Inventario
{
    public class in_Producto_Composicion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        public List<in_Producto_Composicion_Info> ObtenerListProductoComposicion(int IdEmpresa, int IdProductoPadre)
        {
            try
            {
                in_Producto_Composicion_Data data = new in_Producto_Composicion_Data();
                return data.Get_List_Producto_Composicion(IdEmpresa, IdProductoPadre);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerListProductoComposicion", ex.Message), ex) { EntityType = typeof(in_Producto_Composicion_Bus) };

            }
        }

        public Boolean GrabarDB(List<in_Producto_Composicion_Info> ListInfo, int IdProductoPadre, ref string mensaje)
        {
            try
            {
                in_Producto_Composicion_Data data = new in_Producto_Composicion_Data();
                return data.GrabarDB(ListInfo, IdProductoPadre, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(in_Producto_Composicion_Bus) };

            }
        }

        public Boolean eliminarregistrotabla(List<in_Producto_Composicion_Info> lst, int idEmpresa, int IdProductoPadre, ref string mensaje)
        {
            try
            {
                in_Producto_Composicion_Data data = new in_Producto_Composicion_Data();
                return data.eliminarregistrotabla(lst, idEmpresa, IdProductoPadre, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "eliminarregistrotabla", ex.Message), ex) { EntityType = typeof(in_Producto_Composicion_Bus) };
            }
        }

        public Boolean eliminarRegistro_x_producto(int idEmpresa, int IdProductoPadre, ref string mensaje)
        {
            try
            {
                in_Producto_Composicion_Data data = new in_Producto_Composicion_Data();
                return data.eliminarRegistro_x_producto(idEmpresa, IdProductoPadre, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "eliminarRegistro_x_producto", ex.Message), ex) { EntityType = typeof(in_Producto_Composicion_Bus) };
            }
        }
    }
}