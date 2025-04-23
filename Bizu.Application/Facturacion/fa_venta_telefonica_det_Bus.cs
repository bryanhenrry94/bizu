using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.Facturacion;
using Bizu.Domain.Facturacion;
using Bizu.Application.General;
namespace Bizu.Application.Facturacion
{
    public class fa_venta_telefonica_det_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        fa_venta_telefonica_det_Data data = new fa_venta_telefonica_det_Data();

        public List<fa_venta_telefonica_det_Info> Get_List_venta_telefonica_det(int IdEmpresa, int IdSucursal, decimal IdVenta_Tel)
        {
            try
            {
                return data.Get_List_venta_telefonica_det(IdEmpresa,IdSucursal,IdVenta_Tel);

            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(fa_venta_telefonica_det_Bus) };
            }
        }

        public Boolean GuardarDB(fa_venta_telefonica_det_Info Info)
        {
            try
            {
                return data.GuardarDB(Info);
            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(fa_venta_telefonica_det_Bus) };
            }
        }

        public Boolean GuardarDB(List<fa_venta_telefonica_det_Info> lst, int IdEmpresa, int IdSucursal, decimal IdVentaTel)
        {
            try
            {
                if (lst.Count > 0)
                {
                    var mod = lst.FindAll(var => var.Base == "S");
                    foreach (var x in mod)
                    {
                        data.GuardarDB(x);
                    }

                    var guar = lst.FindAll(var => var.Base == null);
                    foreach (var y in guar)
                    {
                        y.IdEmpresa = IdEmpresa;
                        y.IdSucursal = IdSucursal;
                        y.IdVenta_tel = IdVentaTel;
                        data.GuardarDB(y);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarLista", ex.Message), ex) { EntityType = typeof(fa_venta_telefonica_det_Bus) };
            }
        }

        public Boolean ModificarDB(fa_venta_telefonica_det_Info Info)
        {
            try
            {
                return data.ModificarDB(Info);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(fa_venta_telefonica_det_Bus) };
          
            }
        }

        public Boolean EliminarDetalle(int IdEmpresa, int IdSucursal, decimal IdVenta_Tel)
        {
            try
            {
                return data.EliminarDetalle(IdEmpresa,IdSucursal,IdVenta_Tel);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "eliminarDetalle", ex.Message), ex) { EntityType = typeof(fa_venta_telefonica_det_Bus) };
          
            }
        }

    }
}
