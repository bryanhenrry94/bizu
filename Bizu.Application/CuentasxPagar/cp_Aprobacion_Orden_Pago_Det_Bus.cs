using Bizu.Application.General;
using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Domain.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bizu.Application.CuentasxPagar
{
    public class cp_Aprobacion_Orden_Pago_Det_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cp_Aprobacion_Orden_Pago_Det_Data oData = new cp_Aprobacion_Orden_Pago_Det_Data();

        public List<cp_Aprobacion_Orden_Pago_Det_Info> Get_List_Aprobacion_Orden_Pago_Det(int IdEmpresa, string Estado)
        {
            try
            {
                return oData.Get_List_Aprobacion_Orden_Pago_Det(IdEmpresa, Estado);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Guardar_AprobacionOrdenPago", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Orden_Pago_Bus) };
            }
        }

        public Boolean GuardarDB(List<cp_Aprobacion_Orden_Pago_Det_Info> Lst, ref decimal Id, ref string mensaje)
        {
            try
            {
                return oData.GuardarDB(Lst, ref Id, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Guardar_AprobacionOrdenPago", ex.Message), ex) { EntityType = typeof(cp_Aprobacion_Orden_Pago_Bus) };
            }
        }

    }
}
