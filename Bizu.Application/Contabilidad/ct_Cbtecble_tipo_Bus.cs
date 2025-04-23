using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure.Contabilidad;
using Bizu.Domain.General;
using Bizu.Application.General;
namespace Bizu.Application.Contabilidad


{
    public class ct_Cbtecble_tipo_Bus
    {

        ct_Cbtecble_tipo_Data data = new ct_Cbtecble_tipo_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public List<ct_Cbtecble_tipo_Info> Get_list_Cbtecble_tipo(int IdEmpresa, Cl_Enumeradores.eTipoFiltro TipoFiltro,ref string MensajeError)
        {
            List<ct_Cbtecble_tipo_Info> lm = new List<ct_Cbtecble_tipo_Info>();

            try
            {
                lm = data.Get_list_Cbtecble_tipo(IdEmpresa, TipoFiltro, ref MensajeError);
                return (lm);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_Cbtecble_tipo", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_tipo_Bus) };
            }
        }

        public Boolean Get_Es_Interno(int IdEmpresa, int IdTipoCbte, ref string MensajeError) 
        {
            try
            {
                return data.Get_EsCbte_Interno(IdEmpresa,IdTipoCbte, ref MensajeError);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Es_Interno", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_tipo_Bus) };
            }
        }

        public Boolean ModificarDB(ct_Cbtecble_tipo_Info info, ref string MensajeError)
        {

            try
            {
                return data.ModificarDB(info, ref MensajeError);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_tipo_Bus) };
            }
        }

        public Boolean EliminarDB(ct_Cbtecble_tipo_Info info, ref string MensajeError)
        {
            try
            {
                return data.EliminarDB(info, ref MensajeError);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_tipo_Bus) };
            }
        }

        public Boolean GrabarDB(ct_Cbtecble_tipo_Info info, ref string MensajeError)
        {
            try
            {
                return data.GrabarDB(info, ref MensajeError);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_tipo_Bus) };
            }
        }        

        public string Get_Codigo_x_CbtCble_tipo(int IdEmpresa,int IdTipoCbte, ref string MensajeError)
        {
            try
            {
                return data.Get_Codigo_x_CbtCble_tipo(IdEmpresa, IdTipoCbte, ref MensajeError);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Codigo_x_CbtCble_tipo", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_tipo_Bus) };
            }

        }

        public List<ct_Cbtecble_tipo_Info> Get_list_Cbtecble_tipo(int IdEmpresa,ref string MensajeError)
        {
            try 
            {
                return data.Get_list_Cbtecble_tipo(IdEmpresa,ref MensajeError);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_Cbtecble_tipo", ex.Message), ex) { EntityType = typeof(ct_Cbtecble_tipo_Bus) };
            }
        }

        public ct_Cbtecble_tipo_Bus()
        {
           
        }
    }
}
