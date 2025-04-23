using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Facturacion;
using Bizu.Infrastructure.Facturacion;
using Bizu.Application.General;

namespace Bizu.Application.Facturacion
{
    public class fa_venta_telefonica_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        fa_venta_telefonica_Data data = new fa_venta_telefonica_Data();

        public decimal GetId(int IdEmpresa, int IdSucursal)
        {
            try
            {
                return data.GetId(IdEmpresa,IdSucursal);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(fa_venta_telefonica_Bus) };
           
            }
        }

        public List<fa_venta_telefonica_Info> Get_List_venta_telefonica(int IdEmpresa)
        {
            try
            {
                return data.Get_List_venta_telefonica(IdEmpresa);

            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "obtenerLista", ex.Message), ex) { EntityType = typeof(fa_venta_telefonica_Bus) };
            }
        }

        public List<fa_venta_telefonica_Info> Get_List_venta_telefonica(int IdEmpresa, int IdSucursal)
        {
            try
            {
                return data.Get_List_venta_telefonica(IdEmpresa, IdSucursal);
            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "obtenerLista", ex.Message), ex) { EntityType = typeof(fa_venta_telefonica_Bus) };
            }
        }

        public List<fa_venta_telefonica_Info> Get_List_venta_telefonica(int IdEmpresa, int IdSucursal, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                return data.Get_List_venta_telefonica(IdEmpresa, IdSucursal, fechaInicio, fechaFin);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "obtenerLista", ex.Message), ex) { EntityType = typeof(fa_venta_telefonica_Bus) };
          
            }
        }

        public Boolean GuardarDB(fa_venta_telefonica_Info Info, ref decimal Id)
        {
            try
            {
                return data.GuardarDB(Info, ref Id);
            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(fa_venta_telefonica_Bus) };
            }
        }

        public Boolean ModificarDB(fa_venta_telefonica_Info Info)
        {
            try
            {
                return data.ModificarDB(Info);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(fa_venta_telefonica_Bus) };
            
            }
        }

        public Boolean AnularDB(fa_venta_telefonica_Info Info)
        {
            try
            {
                return data.AnularDB(Info);
            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(fa_venta_telefonica_Bus) };
            }
        }
    }
}
