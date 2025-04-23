using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.Contabilidad;
using Bizu.Domain.Contabilidad;
using Bizu.Application.General;

namespace Bizu.Application.Contabilidad
{
    public class ct_rpt_Empresas_A_mostrar_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        public Boolean GrabarDB(ct_rpt_Empresas_A_mostrar_Info info)
        {
            try
            {
                ct_rpt_Empresas_A_mostrar_Data ED = new ct_rpt_Empresas_A_mostrar_Data();
                 return ED.GrabarDB(info);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_rpt_Empresas_A_mostrar_Bus) };               
            }
        }

        public Boolean GrabarDB(List<ct_rpt_Empresas_A_mostrar_Info> listEmpresas)
        {
            try
            {
                ct_rpt_Empresas_A_mostrar_Data ED = new ct_rpt_Empresas_A_mostrar_Data();
                return ED.GrabarListDB(listEmpresas);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_rpt_Empresas_A_mostrar_Bus) };
            }
        }

        public Boolean EliminarDB(List<ct_rpt_Empresas_A_mostrar_Info> listEmpresas)
        {
            try
            {
                ct_rpt_Empresas_A_mostrar_Data ED = new ct_rpt_Empresas_A_mostrar_Data();
                return ED.EliminarDB(listEmpresas);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ct_rpt_Empresas_A_mostrar_Bus) };
            }
        }



        public ct_rpt_Empresas_A_mostrar_Bus()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ct_rpt_Empresas_A_mostrar_Bus", ex.Message), ex) { EntityType = typeof(ct_rpt_Empresas_A_mostrar_Bus) };
            }
        }
    }
}
