using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure.Contabilidad;
using Bizu.Application.General;


namespace Bizu.Application.Contabilidad
{
    public  class ct_Balance_x_General_x_Usuario_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        #region CJimenez
        
        ct_Balance_x_General_x_Usuario_Data OD = new ct_Balance_x_General_x_Usuario_Data();
        
        public Boolean Start_spCON_Optener_BalanceGeneral(int IdEmpresa, DateTime i_FechaIni, DateTime i_FechaFin, string i_usuario, string i_pc)
        {
            try
            {
                return OD.Start_spCON_Obtener_BalanceGeneral(IdEmpresa, i_FechaIni, i_FechaFin, i_usuario, i_pc);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Start_spCON_Optener_BalanceGeneral", ex.Message), ex) { EntityType = typeof(ct_Balance_x_General_x_Usuario_Bus) };
            }
        }

        public List<ct_Balance_x_General_x_Usuario_Info> ObtenerDatos_Reporte_Standar(int IdEmpresa, string i_usuario, string i_pc, int i_Nivel, List<ct_Plancta_nivel_Info> niveles)
        {
            try
            {
                return OD.ObtenerDatos_Reporte_Standar(IdEmpresa, i_usuario, i_pc, i_Nivel, niveles);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerDatos_Reporte_Standar", ex.Message), ex) { EntityType = typeof(ct_Balance_x_General_x_Usuario_Bus) };
            }
        }

        public List<ct_Balance_x_General_x_Usuario_Info> ObtenerDatos_Reporte_SL_Anterior(int IdEmpresa, string i_usuario, string i_pc, int i_Nivel, List<ct_Plancta_nivel_Info> niveles)
        {
            try
            {
                return OD.ObtenerDatos_Reporte_SL_Anterior(IdEmpresa, i_usuario, i_pc, i_Nivel, niveles);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerDatos_Reporte_SL_Anterior", ex.Message), ex) { EntityType = typeof(ct_Balance_x_General_x_Usuario_Bus) };
            }
        }

        #endregion 
    }
}
