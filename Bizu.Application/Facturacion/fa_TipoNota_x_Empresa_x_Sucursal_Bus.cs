using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Facturacion;
using Bizu.Infrastructure.Facturacion;
using Bizu.Application.General;


namespace Bizu.Application.Facturacion
{
    public class fa_TipoNota_x_Empresa_x_Sucursal_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        fa_TipoNota_x_Empresa_x_Sucursal_Data data = new fa_TipoNota_x_Empresa_x_Sucursal_Data();

        public List<fa_TipoNota_x_Empresa_x_Sucursal_Info> Get_List_TipoNota_x_Empresa_x_Sucursal(int IdEmpresa, int IdSucursal)
        {
            try
            {
                return data.Get_List_TipoNota_x_Empresa_x_Sucursal(IdEmpresa, IdSucursal);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerxTipoNota", ex.Message), ex) { EntityType = typeof(fa_TipoNota_x_Empresa_x_Sucursal_Bus) };

            }

        }


        public fa_TipoNota_x_Empresa_x_Sucursal_Info Get_Info_TipoNota_x_Empresa_x_Sucursal_x_TipoNota(int IdEmpresa, int IdSucursal, int idTipoNota)
        {
            try
            {
                return data.Get_Info_TipoNota_x_Empresa_x_Sucursal_x_TipoNota(IdEmpresa, IdSucursal,idTipoNota);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerxTipoNota", ex.Message), ex) { EntityType = typeof(fa_TipoNota_x_Empresa_x_Sucursal_Bus) };

            }
        }
        public List<fa_TipoNota_x_Empresa_x_Sucursal_Info> Get_List_TipoNota_x_Empresa_x_Sucursal_x_TipoNota(int IdEmpresa, int idTipoNota)
        {
            try
            {
                  return data.Get_List_TipoNota_x_Empresa_x_Sucursal_x_TipoNota(IdEmpresa,idTipoNota);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerxTipoNota", ex.Message), ex) { EntityType = typeof(fa_TipoNota_x_Empresa_x_Sucursal_Bus) };
           
            }

        }

        public Boolean GuardarDB(List<fa_TipoNota_x_Empresa_x_Sucursal_Info> List, ref string Mensaje)
        {
            try
            {
                return data.GuardarDB(List, ref Mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(fa_TipoNota_x_Empresa_x_Sucursal_Bus) };
           
            }

        }

        public Boolean ModificarDB(List<fa_TipoNota_x_Empresa_x_Sucursal_Info> List, ref string Mensaje)
        {
            try
            {
                return data.ModificarDB(List,ref Mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(fa_TipoNota_x_Empresa_x_Sucursal_Bus) };
           
            }
        }
    }
}
