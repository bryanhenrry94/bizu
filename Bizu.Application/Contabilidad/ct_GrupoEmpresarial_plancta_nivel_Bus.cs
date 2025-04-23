using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure.Contabilidad;
using Bizu.Application.General;

namespace Bizu.Application.Contabilidad
{
    public class ct_GrupoEmpresarial_plancta_nivel_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        ct_GrupoEmpresarial_plancta_nivel_Data data = new ct_GrupoEmpresarial_plancta_nivel_Data();

        public Boolean GrabarDB(ct_GrupoEmpresarial_plancta_nivel_Info Info,ref int Id)
        {
            try
            {
               return data.GrabarDB(Info,ref Id);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_IdCta", ex.Message), ex) { EntityType = typeof(ct_GrupoEmpresarial_plancta_Bus) };
            }

        }

        public List<ct_GrupoEmpresarial_plancta_nivel_Info> Get_list_GrupoEmpresarial_plancta_nivel()
        {
            try
            {
                  return data.Get_list_GrupoEmpresarial_plancta_nivel();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_IdCta", ex.Message), ex) { EntityType = typeof(ct_GrupoEmpresarial_plancta_Bus) };
            }

        }

        public ct_GrupoEmpresarial_plancta_nivel_Info Get_Info_GrupoEmpresarial_plancta_nivel(int IdNivelCta_gr)
        {
            try
            {
                 return data.Get_Info_GrupoEmpresarial_plancta_nivel(IdNivelCta_gr);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_IdCta", ex.Message), ex) { EntityType = typeof(ct_GrupoEmpresarial_plancta_Bus) };
            }

        }
        
        public Boolean ModificarDB(ct_GrupoEmpresarial_plancta_nivel_Info info)
        {
            try
            {
                   return data.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_IdCta", ex.Message), ex) { EntityType = typeof(ct_GrupoEmpresarial_plancta_Bus) };
            }

        }
        
        public ct_GrupoEmpresarial_plancta_nivel_Bus()
        {
            
        }
    }
}
