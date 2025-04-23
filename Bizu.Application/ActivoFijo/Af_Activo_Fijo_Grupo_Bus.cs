using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Application.General;
using Bizu.Infrastructure.ActivoFijo;
using Bizu.Domain.ActivoFijo;

namespace Bizu.Application.ActivoFijo
{
    public class Af_Activo_Fijo_Grupo_Bus
    {
        Af_Activo_Fijo_Grupo_Data oData = new Af_Activo_Fijo_Grupo_Data();

        public List<Af_Activo_Fijo_Grupo_Info> Get_List_ActivoFijo_Grupo(int IdEmpresa)
        {
            try
            {
                return oData.Get_List_ActivoFijo_Grupo(IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_ActivoFijo", ex.Message), ex) { EntityType = typeof(Af_Activo_Fijo_Grupo_Bus) };
            }
        }

        public Boolean GrabarDB(Af_Activo_Fijo_Grupo_Info info, ref string msg)
        {
            try
            {
                return oData.GrabarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_ActivoFijo", ex.Message), ex) { EntityType = typeof(Af_Activo_Fijo_Grupo_Bus) };
            }
        }

        public Boolean ModificarDB(Af_Activo_Fijo_Grupo_Info info, ref string msg)
        {
            try
            {
                return oData.ModificarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_ActivoFijo", ex.Message), ex) { EntityType = typeof(Af_Activo_Fijo_Grupo_Bus) };
            }
        }

        public Boolean AnularDB(Af_Activo_Fijo_Grupo_Info info, ref string msg)
        {
            try
            {
                return oData.AnularDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_ActivoFijo", ex.Message), ex) { EntityType = typeof(Af_Activo_Fijo_Grupo_Bus) };
            }
        }
    }
}
