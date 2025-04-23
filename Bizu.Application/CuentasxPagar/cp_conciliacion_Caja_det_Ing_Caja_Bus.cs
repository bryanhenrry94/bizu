using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Domain.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Application.CuentasxPagar
{
    public class cp_conciliacion_Caja_det_Ing_Caja_Bus
    {
        cp_conciliacion_Caja_det_Ing_Caja_Data oData = new cp_conciliacion_Caja_det_Ing_Caja_Data();

        public List<cp_conciliacion_Caja_det_Ing_Caja_Info> Get_List_Ingresos_x_conciliacion(int idEmpresa, decimal idConciliacion_Caja)
        {
            try
            {
                return oData.Get_List_Ingresos_x_conciliacion(idEmpresa, idConciliacion_Caja);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Ingresos_x_conciliacion", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_Ing_Caja_Bus) };
            }
        }

        public List<cp_conciliacion_Caja_det_Ing_Caja_Info> Get_List_Ingresos_x_conciliar(int IdEmpresa, DateTime Fecha_ini, DateTime Fecha_fin, int IdCaja)
        {
            try
            {
                return oData.Get_List_Ingresos_x_conciliar(IdEmpresa, Fecha_ini, Fecha_fin, IdCaja);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Ingresos_x_conciliar", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_Ing_Caja_Bus) };
            }
        }

        public Boolean GuardarDB(List<cp_conciliacion_Caja_det_Ing_Caja_Info> lst)
        {
            try
            {
                return oData.GuardarDB(lst);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_Ing_Caja_Bus) };
            }
        }

        public Boolean EliminarDB(int idEmpresa, decimal idConciliacion_caja)
        {
            try
            {
                return oData.EliminarDB(idEmpresa, idConciliacion_caja);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_Ing_Caja_Bus) };
            }
        }       
    }
}
