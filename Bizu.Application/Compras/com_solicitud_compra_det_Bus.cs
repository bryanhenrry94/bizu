using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Domain.Compras;
using Bizu.Infrastructure.Compras;
using Bizu.Application.General;

namespace Bizu.Application.Compras
{
    public class com_solicitud_compra_det_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        com_solicitud_compra_det_Data odata = new com_solicitud_compra_det_Data();
        string mensaje = "";

        public Boolean GuardarDB(List<com_solicitud_compra_det_Info> LstInfo)
        {
            try
            {
                return odata.GuardarDB(LstInfo);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_Bus) };
            }
        }

        public Boolean EliminarDB(com_solicitud_compra_Info Info)
        {

            try
            {
                return odata.EliminarDB(Info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_solicitud_compra_det_aprobacion", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_Bus) };
            }
        }

        public List<com_solicitud_compra_det_Info> Get_list_DetalleLstSolicitudCompra(int idempresa, int idsucursal, decimal idsolicitud)
        {

            try
            {
                return odata.Get_list_DetalleLstSolicitudCompra(idempresa, idsucursal, idsolicitud);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_solicitud_compra_det_aprobacion", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_Bus) };
            }
        }

        public List<com_solicitud_compra_det_Info> Get_list_x_Proyecto(int IdEmpresa, int IdSucursal, int IdProyecto, int IdOferta)
        {
            try
            {
                return odata.Get_list_x_Proyecto(IdEmpresa, IdSucursal, IdProyecto, IdOferta);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_solicitud_compra_det_aprobacion", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_Bus) };
            }
        }

        public com_solicitud_compra_det_Info Get_Info(int idempresa, int idsucursal, decimal idsolicitud, int  Secuencia)
        {

            try
            {
                return odata.Get_Info(idempresa, idsucursal, idsolicitud, Secuencia);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_solicitud_compra_det_aprobacion", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_Bus) };
            }
        }

        public List<com_solicitud_compra_det_Info> Get_list_DetalleLstSolicitudCompra(int idempresa, int idsucursal, DateTime FechaIni, DateTime FechaFin, string IdEstadoAprobacion, ref string mensaje)
        {

            try
            {
                return odata.Get_list_DetalleLstSolicitudCompra(idempresa, idsucursal, FechaIni, FechaFin, IdEstadoAprobacion, ref mensaje);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_DetalleLstSolicitudCompra", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_Bus) };
            }
        }

        public Boolean Actualizar_Producto_Creado(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra, int Secuencia, decimal IdProducto, string nom_producto, ref string mensaje)
        {
            try
            {
                return odata.Actualizar_Producto_Creado(IdEmpresa, IdSucursal, IdSolicitudCompra, Secuencia, IdProducto, nom_producto, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Actualizar_Producto_Creado", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_Bus) };
            }
        }

        public Boolean ModificarEstadoAproba_DetSolCom(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra, int Secuencia, decimal IdProducto, string IdEstadoAprobacion, ref string mensaje)
        {
            try
            {
                return odata.ModificarEstadoAproba_DetSolCom(IdEmpresa, IdSucursal, IdSolicitudCompra, Secuencia, IdProducto, IdEstadoAprobacion, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarEstadoAproba_DetSolCom", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_Bus) };
            }
        }

        public List<com_solicitud_compra_det_Info> GetList_SolicitudPendiente(int IdEmpresa)
        {
            try
            {
                return odata.GetList_SolicitudPendiente(IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GetList_SolicitudPendiente", ex.Message), ex) { EntityType = typeof(com_solicitud_compra_det_Bus) };
            }
        }

        public bool ExisteRubro_SolicitudCompra(int IdEmpresa, int IdSucursal, int IdProyecto, int IdOferta, int Secuencia)
        {
            try
            {
                return this.odata.ExisteRubro_SolicitudCompra(IdEmpresa, IdSucursal, IdProyecto, IdOferta, Secuencia);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
