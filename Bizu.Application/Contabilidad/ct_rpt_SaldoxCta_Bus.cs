using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure.Contabilidad;
using Bizu.Application.General;

namespace  Bizu.Application.Contabilidad
{
    public class ct_rpt_SaldoxCta_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<ct_rpt_SaldoxCta_Info> Get_List_SaldoxCta(int IdEmpresa)
        {
            List<ct_rpt_SaldoxCta_Info> lm = new List<ct_rpt_SaldoxCta_Info>();
            ct_rpt_SaldoxCta_Data data = new ct_rpt_SaldoxCta_Data();
            try
            {
                lm = data.Get_list_rpt_SaldoxCta(IdEmpresa);
                return (lm);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_rpt_SaldoxCta", ex.Message), ex) { EntityType = typeof(ct_rpt_SaldoxCta_Bus) };
            }
        }

        public Boolean GrabarDB(List<ct_rpt_SaldoxCta_Info> Lista)
        {
            try
            {
                ct_rpt_SaldoxCta_Data data = new ct_rpt_SaldoxCta_Data();
                return data.GrabarDB(Lista);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_rpt_SaldoxCta_Bus) };
            }
        }

        public Boolean GrabarDB(ct_rpt_SaldoxCta_Info info)
        {
            try
            {
                ct_rpt_SaldoxCta_Data data = new ct_rpt_SaldoxCta_Data();
                return data.GrabarDB(info); 
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_rpt_SaldoxCta_Bus) };
            }
        }

        public Boolean EliminarDB(List<ct_rpt_SaldoxCta_Info> Lista)
        {
            try
            {
                ct_rpt_SaldoxCta_Data data = new ct_rpt_SaldoxCta_Data();
                return data.EliminarDB(Lista);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ct_rpt_SaldoxCta_Bus) };
            }
        }

        public Boolean EliminarDB(ct_rpt_SaldoxCta_Info info)
        {
            try
            {
                ct_rpt_SaldoxCta_Data data = new ct_rpt_SaldoxCta_Data();
                return data.EliminarDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ct_rpt_SaldoxCta_Bus) };
            }
        }

        public List<ct_rpt_SaldoxCta_Info> Get_Saldo_Inicial_x_Cuenta(int IdEmpresa, List<string> listCuentas, DateTime FechaIni, DateTime FechaFin, ref string MensajeError)
        {

            try
            {
                ct_rpt_SaldoxCta_Data data = new ct_rpt_SaldoxCta_Data();
                return data.Get_Saldo_Inicial_x_Cuenta(IdEmpresa, listCuentas, FechaIni, FechaFin, ref MensajeError);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Saldo_Inicial_x_Cuenta", ex.Message), ex) { EntityType = typeof(ct_rpt_SaldoxCta_Bus) };
            }
        }

        public ct_rpt_SaldoxCta_Bus()
        {
            
        }
    }
}
