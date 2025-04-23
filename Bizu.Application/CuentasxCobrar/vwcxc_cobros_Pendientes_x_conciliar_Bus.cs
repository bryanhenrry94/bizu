using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Domain.CuentasxCobrar;
using Bizu.Infrastructure.CuentasxCobrar;
using Bizu.Domain.General;
using Bizu.Application.General;



namespace Bizu.Application.CuentasxCobrar
{
    public class vwcxc_cobros_Pendientes_x_conciliar_Bus
    {
      vwcxc_cobros_Pendientes_x_conciliar_Data oData = new vwcxc_cobros_Pendientes_x_conciliar_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public List<vwcxc_cobros_Pendientes_x_conciliar_Info> Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo(int IdEmpresa, int IdSucursal, decimal IdCliente, Cl_Enumeradores.TipoConciliacion IdTipoConciliacion, ref string mensaje)
        {
            try
            {
                return oData.Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo(IdEmpresa, IdSucursal, IdCliente,IdTipoConciliacion, ref mensaje);
            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo", ex.Message), ex) { EntityType = typeof(vwcxc_cobros_x_cheque_deposito_Bus) };
            }

        }

        public List<vwcxc_cobros_Pendientes_x_conciliar_Info> Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo_Todos(int IdEmpresa, int IdSucursal, Cl_Enumeradores.TipoConciliacion IdTipoConciliacion, ref string mensaje)
        {
            try
            {
                return oData.Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo_Todos(IdEmpresa, IdSucursal, IdTipoConciliacion, ref mensaje);
            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo", ex.Message), ex) { EntityType = typeof(vwcxc_cobros_x_cheque_deposito_Bus) };
            }

        }

        public List<vwcxc_cobros_Pendientes_x_conciliar_Info> Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo_Con(int IdEmpresa, int IdSucursal, decimal IdCliente, Cl_Enumeradores.TipoConciliacion IdTipoConciliacion, ref string mensaje)
        {
            try
            {
                return oData.Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo_Con(IdEmpresa, IdSucursal, IdCliente, IdTipoConciliacion, ref mensaje);
            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo", ex.Message), ex) { EntityType = typeof(vwcxc_cobros_x_cheque_deposito_Bus) };
            }

        }

        public List<vwcxc_cobros_Pendientes_x_conciliar_Info> Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo_Edehsa(int IdEmpresa, int IdSucursal, decimal IdCliente, Cl_Enumeradores.TipoConciliacion IdTipoConciliacion, ref string mensaje)
        {
            try
            {
                return oData.Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo_Edehsa(IdEmpresa, IdSucursal, IdCliente, IdTipoConciliacion, ref mensaje);
            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_cobros_Pendientes_x_conciliar_CreDeb_Saldo", ex.Message), ex) { EntityType = typeof(vwcxc_cobros_x_cheque_deposito_Bus) };
            }

        }

        
    }
}
