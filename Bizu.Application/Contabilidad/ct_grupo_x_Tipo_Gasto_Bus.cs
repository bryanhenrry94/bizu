using Bizu.Infrastructure.Contabilidad;
using Bizu.Domain.Contabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Application.Contabilidad
{
    public class ct_grupo_x_Tipo_Gasto_Bus
    {
        ct_grupo_x_Tipo_Gasto_Data oData = new ct_grupo_x_Tipo_Gasto_Data();

        public List<ct_grupo_x_Tipo_Gasto_Info> Get_list_grupo_x_tipo_Gasto(int IdEmpresa)
        {
            try
            {
                return oData.Get_list_grupo_x_tipo_Gasto(IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_grupo_x_tipo_Gasto", ex.Message), ex) { EntityType = typeof(ct_grupo_x_Tipo_Gasto_Bus) };
            }
        }

        public List<ct_grupo_x_Tipo_Gasto_Info> Get_list_grupo_x_tipo_Gasto_nivel_3(int IdEmpresa)
        {
            try
            {
                return oData.Get_list_grupo_x_tipo_Gasto_nivel_3(IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_grupo_x_tipo_Gasto_nivel_3", ex.Message), ex) { EntityType = typeof(ct_grupo_x_Tipo_Gasto_Bus) };
            }
        }

        public List<ct_grupo_x_Tipo_Gasto_Info> Get_list_grupo_x_tipo_Gasto_nivel_menor_3(int IdEmpresa)
        {
            try
            {
                return oData.Get_list_grupo_x_tipo_Gasto_nivel_menor_3(IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_list_grupo_x_tipo_Gasto_nivel_menor_3", ex.Message), ex) { EntityType = typeof(ct_grupo_x_Tipo_Gasto_Bus) };
            }
        }

        public bool GuardarDB(ct_grupo_x_Tipo_Gasto_Info info)
        {
            try
            {
                return oData.GuardarDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ct_grupo_x_Tipo_Gasto_Bus) };
            }
        }

        public bool ModificarDB(ct_grupo_x_Tipo_Gasto_Info info)
        {
            try
            {
                return oData.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_grupo_x_Tipo_Gasto_Bus) };
            }
        }

        public bool AnularDB(ct_grupo_x_Tipo_Gasto_Info info)
        {
            try
            {
                return oData.AnularDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ct_grupo_x_Tipo_Gasto_Bus) };
            }
        }

        public int Get_orden(int IdEmpresa, Nullable<int> IdTipo_gasto_padre)
        {
            try
            {
                return oData.Get_orden(IdEmpresa, IdTipo_gasto_padre);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_orden", ex.Message), ex) { EntityType = typeof(ct_grupo_x_Tipo_Gasto_Bus) };
            }
        }
    }
}
