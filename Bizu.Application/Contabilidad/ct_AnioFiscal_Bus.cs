using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain;

using System.Data;
using System.Windows.Forms;
using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure.Contabilidad;
using Bizu.Application.General;


namespace Bizu.Application.Contabilidad
{
    public class ct_AnioFiscal_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public ct_AnioFiscal_Info Get_Info_Anio_fiscal(int Anio)
        {
            ct_AnioFiscal_Info lm = new ct_AnioFiscal_Info();
            ct_AnioFiscal_Data data = new ct_AnioFiscal_Data();
            try
            {
                lm = data.Get_Info_Anio_fiscal(Anio);
                return lm;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_AnioFiscal", ex.Message), ex) { EntityType = typeof(ct_AnioFiscal_Bus) };
            }
        }
        
        public List<ct_AnioFiscal_Info> Get_list_AnioFiscal()
        {
            List<ct_AnioFiscal_Info> lm = new List<ct_AnioFiscal_Info>();
            ct_AnioFiscal_Data data = new ct_AnioFiscal_Data();

            try
            {
                lm = data.Get_list_AnioFiscal();
                return lm;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_AnioFiscal", ex.Message), ex) { EntityType = typeof(ct_AnioFiscal_Bus) };
            }
        }

        public List<ct_AnioFiscal_Info> Get_list_AnioFiscal(string Estado)
        {
            List<ct_AnioFiscal_Info> lm = new List<ct_AnioFiscal_Info>();
            ct_AnioFiscal_Data data = new ct_AnioFiscal_Data();

            try
            {
                lm = data.Get_list_AnioFiscal(Estado);
                return lm;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_AnioFiscal", ex.Message), ex) { EntityType = typeof(ct_AnioFiscal_Bus) };
            }
        }

        public Boolean ModificarDB(ct_AnioFiscal_Info Info_AnioF, ref string msg)
        {
            try
            {
                ct_AnioFiscal_Data AFD = new ct_AnioFiscal_Data();
                return AFD.ModificarDB(Info_AnioF, ref msg);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_AnioFiscal_Bus) };
            }
        }

        public Boolean AnularDB(ct_AnioFiscal_Info Info_AnioF, ref string msg)
        {
            try
            {
                ct_AnioFiscal_Data AFD = new ct_AnioFiscal_Data();
                return AFD.EliminarDB(Info_AnioF, ref msg);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ct_AnioFiscal_Bus) };
            }
        }

        public Boolean GrabarDB(ct_AnioFiscal_Info Info_AnioF, ref string msg)
        {
            try
            {

                ct_AnioFiscal_Data AFD = new ct_AnioFiscal_Data();
                return AFD.GrabarDB(Info_AnioF, ref msg);


            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_AnioFiscal_Bus) };
            }
        }

        public Boolean Get_Tiene_PeriodosxAnio(int IdEmpresa, int IdAnio, ref string msg)
        {
            try
            {
                ct_AnioFiscal_Data data = new ct_AnioFiscal_Data();
                return data.Get_Tiene_PeriodosxAnio(IdEmpresa, IdAnio, ref msg);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Tiene_PeriodosxAnio", ex.Message), ex) { EntityType = typeof(ct_AnioFiscal_Bus) };
            }
        }
        
        public ct_AnioFiscal_Info Get_Info_cuenta_utilidad_x_anio_fiscal(int IdEmpresa, int Anio)
        {
            try
            {
                ct_AnioFiscal_Data data = new ct_AnioFiscal_Data();
                return data.Get_Info_cuenta_utilidad_x_anio_fiscal(IdEmpresa, Anio);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Tiene_PeriodosxAnio", ex.Message), ex) { EntityType = typeof(ct_AnioFiscal_Bus) };
            }
        }

        public ct_AnioFiscal_Bus()
        {
        }

    }
}