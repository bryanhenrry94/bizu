using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.CuentasxPagar;
using Bizu.Domain.General;
using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Infrastructure.General;
using Bizu.Application.General;

namespace Bizu.Application.CuentasxPagar
{
    public class cp_TipoDocumento_Bus
    {
        cp_TipoDocumento_Data odata = new cp_TipoDocumento_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public Boolean GuardarDB(ref cp_TipoDocumento_Info Info)
        {
            try
            {
                return odata.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_retencion_det_Bus) };
            }
        }

        public List<cp_TipoDocumento_Info> Get_List_TipoDocumento()
        {
            try
            {
                return odata.Get_List_TipoDocumento();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_TipoDocumento", ex.Message), ex) { EntityType = typeof(cp_retencion_det_Bus) };
            }
        }

        public List<cp_TipoDocumento_Info> Get_List_TipoDocumento(string CodDocumento)
        {
            try
            {
                return odata.Get_List_TipoDocumento(CodDocumento);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_TipoDocumento", ex.Message), ex) { EntityType = typeof(cp_retencion_det_Bus) };
            }
        }

        public List<cp_TipoDocumento_Info> Get_List_TipoDocumento(List<string> ListCodTipoDocumento)
        {
            try
            {
                return odata.Get_List_TipoDocumento(ListCodTipoDocumento);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_TipoDocumento", ex.Message), ex) { EntityType = typeof(cp_retencion_det_Bus) };
            }
        }

        public Boolean ModificarDB(cp_TipoDocumento_Info info)
        {
            try
            {
                return odata.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_retencion_det_Bus) };
            }
        }

        public Boolean AnularDB(cp_TipoDocumento_Info info)
        {
            try
            {
                return odata.AnularDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(cp_retencion_det_Bus) };
            }
        }

        public Boolean HabilitarDB(cp_TipoDocumento_Info info)
        {
            try
            {
                return odata.HabilitarDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "HabilitarDB", ex.Message), ex) { EntityType = typeof(cp_retencion_det_Bus) };
            }
        }

        public Boolean VericarCodigoExiste(string codigo, ref string mensaje)
        {
            try
            {
                cp_TipoDocumento_Data data = new cp_TipoDocumento_Data();
                return data.VericarCodigoExiste(codigo, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "VericarCodigoExiste", ex.Message), ex) { EntityType = typeof(cp_retencion_det_Bus) };
            }
        }

    }
}