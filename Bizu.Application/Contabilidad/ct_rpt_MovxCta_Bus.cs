using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure.Contabilidad;
using Bizu.Application.General;

namespace Bizu.Application.Contabilidad
{
    public class ct_rpt_MovxCta_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public List<ct_rpt_MovxCta_Info> Get_List_MovxCta(int IdEmpresa, int IdPeriodo)
        {
            try
            {
                ct_rpt_MovxCta_Data data = new ct_rpt_MovxCta_Data();
                return data.Get_list_rpt_MovxCta(IdEmpresa, IdPeriodo); 
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_rpt_MovxCta", ex.Message), ex) { EntityType = typeof(ct_rpt_MovxCta_Bus) };
            }
        }

        public List<ct_rpt_MovxCta_Info> Get_List_MovxCta(int IdEmpresa)
        {
            try
            {
                ct_rpt_MovxCta_Data data = new ct_rpt_MovxCta_Data();
                return data.Get_list_rpt_MovxCta(IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_rpt_MovxCta", ex.Message), ex) { EntityType = typeof(ct_rpt_MovxCta_Bus) };
            }
        }

        public List<ct_rpt_MovxCta_Info> Get_list_MovxCta(int IdEmpresa, DateTime iFechaIni, DateTime iFechaFin)
        {
            try
            {
                ct_rpt_MovxCta_Data data = new ct_rpt_MovxCta_Data();
                return data.Get_list_rpt_MovxCta(IdEmpresa, iFechaIni, iFechaFin);                
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_rpt_MovxCta", ex.Message), ex) { EntityType = typeof(ct_rpt_MovxCta_Bus) };
            }

        }


        public List<ct_rpt_MovxCta_Info> Get_list_MovxCta(int IdEmpresa, List<string> listaCtas, DateTime iFechaIni, DateTime iFechaFin)
        {
            try
            {
                ct_rpt_MovxCta_Data data = new ct_rpt_MovxCta_Data();
                return data.Get_list_rpt_MovxCta(IdEmpresa,listaCtas, iFechaIni, iFechaFin);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_rpt_MovxCta", ex.Message), ex) { EntityType = typeof(ct_rpt_MovxCta_Bus) };
            }
        }

        #region grabar
        public Boolean GrabarDB(List<ct_rpt_MovxCta_Info> Lista)
        {
            try
            {
                ct_rpt_MovxCta_Data data = new ct_rpt_MovxCta_Data();
                return data.GrabarDB(Lista);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_rpt_MovxCta_Bus) };
            }
        }

        public Boolean GrabarDB(ct_rpt_MovxCta_Info info)
        {
            try
            {
                ct_rpt_MovxCta_Data data = new ct_rpt_MovxCta_Data();
                return data.GrabarDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_rpt_MovxCta_Bus) };
            }
        }
        #endregion

        #region metodo eliminar
        public Boolean EliminarDB(List<ct_rpt_MovxCta_Info> Lista)
        {
            try
            {
                ct_rpt_MovxCta_Data data = new ct_rpt_MovxCta_Data();
                return data.EliminarDB(Lista);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ct_rpt_MovxCta_Bus) };
            }
        }

        public Boolean EliminarDB(ct_rpt_MovxCta_Info info)
        {
            try
            {
                ct_rpt_MovxCta_Data data = new ct_rpt_MovxCta_Data();
                return data.EliminarDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ct_rpt_MovxCta_Bus) };
            }
        }
        #endregion


        public ct_rpt_MovxCta_Bus()
        {
            
        }
    }
}
