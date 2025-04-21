using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Business.CuentasxCobrar
{
    public class cxc_auditoria_de_diario_contable_cobranza_Bus
    {
        string MensajeError = "";

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cxc_parametro_Info paramInfo = new cxc_parametro_Info();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cxc_auditoria_de_diario_contable_cobranza_Data data = new cxc_auditoria_de_diario_contable_cobranza_Data();

        public List<cxc_Factura_sin_diario_Info> Get_List_Facturas_ConSin_Diario(int IdEmpresa, int IdSucursal, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return data.Get_List_Facturas_ConSin_Diario(IdEmpresa, IdSucursal, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Facturas_ConSin_Diario", ex.Message), ex) { EntityType = typeof(cxc_auditoria_de_diario_contable_cobranza_Bus) };
            }

        }

        public List<cxc_Factura_detalle_por_cuenta_contable_Info> Get_List_Facturas_ConSin_Diario_Detalle(int IdEmpresa, int IdSucursal, string IdCuenta, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return data.Get_List_Facturas_ConSin_Diario_Detalle(IdEmpresa, IdSucursal, IdCuenta, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Facturas_ConSin_Diario_Detalle", ex.Message), ex) { EntityType = typeof(cxc_auditoria_de_diario_contable_cobranza_Bus) };
            }
        }
    }
}