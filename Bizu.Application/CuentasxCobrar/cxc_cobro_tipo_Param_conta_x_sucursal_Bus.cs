using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.CuentasxCobrar;
using Bizu.Infrastructure.CuentasxCobrar;
using Bizu.Application.General;
//
namespace Bizu.Application.CuentasxCobrar
{

    public class cxc_cobro_tipo_Param_conta_x_sucursal_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cxc_cobro_tipo_Param_conta_x_sucursal_Data data = new cxc_cobro_tipo_Param_conta_x_sucursal_Data();

        public List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> Get_List_cobro_tipo_Param_conta_x_sucursal(int IdEmpresa, int IdSucursal)
        {
            try
            {
              return data.Get_List_cobro_tipo_Param_conta_x_sucursal(IdEmpresa, IdSucursal);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Cobro_Tipo_Todos", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_Param_conta_x_sucursal_Bus) };
            }

        }

        public List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> Get_List_cobro_tipo_Param_conta_x_sucursal(int IdEmpresa)
        {
            try
            {
               return data.Get_List_cobro_tipo_Param_conta_x_sucursal(IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Cobro_Tipo_Todos", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_Param_conta_x_sucursal_Bus) };
            }

        }
        public cxc_cobro_tipo_Param_conta_x_sucursal_Info Get_Info_cobro_tipo_Param_conta_x_sucursal(int IdEmpresa, int IdSucursal, string IdCobro_tipo)
        {
            try
            {
                 return data.Get_Info_cobro_tipo_Param_conta_x_sucursal( IdEmpresa,  IdSucursal,  IdCobro_tipo);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_cobro_tipo_Param_conta_x_sucursal", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_Param_conta_x_sucursal_Bus) };
            }

        }
        public List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> Get_List_cobro_tipo_Param_conta_x_sucursal(int IdEmpresa, string IdCobro_tipo)
        {
            try
            {
              return data.Get_List_cobro_tipo_Param_conta_x_sucursal(IdEmpresa, IdCobro_tipo);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_cobro_tipo_Param_conta_x_sucursal", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_Param_conta_x_sucursal_Bus) };
            }

        }
        public Boolean GuardarDB(List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> info)
        {
            try
            {
              return data.GuardarDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_Param_conta_x_sucursal_Bus) };
            }

        }
        public Boolean GuardarDB(List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> lista, int idempresa)
        {
            try
            {
                return data.GuardarDB(lista, idempresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_Param_conta_x_sucursal_Bus) };
            }

        }
        public cxc_cobro_tipo_Param_conta_x_sucursal_Bus()
        {

            
        }
    }
}
