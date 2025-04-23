using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.CuentasxCobrar;
using Bizu.Infrastructure;
using Bizu.Infrastructure.CuentasxCobrar;
using Bizu.Application.General;
using Bizu.Domain.General;

namespace Bizu.Application.CuentasxCobrar
{
    public class cxc_retencion_Multiple_Documentos_ValorAplicado_Bus
    {
        #region Declaracion

        cxc_retencion_Multiple_Documentos_ValorAplicado_Data data = new cxc_retencion_Multiple_Documentos_ValorAplicado_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string MensajeError = "";

        #endregion

        public Boolean GuardarDB(List<cxc_retencion_Multiple_Documentos_ValorAplicado_Info> lista)
        {
            try
            {
                return data.GuardarDB(lista);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_retencion_Multiple_Documentos_ValorAplicado_Bus) };
            }

        }

        public Boolean ModificarDetalleCobro(List<cxc_retencion_Multiple_Documentos_ValorAplicado_Info> lista)
        {
            try
            {
                return data.ModificarDetalleCobro(lista);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDetalleCobro", ex.Message), ex) { EntityType = typeof(cxc_retencion_Multiple_Documentos_ValorAplicado_Bus) };
            }

        }

        public List<cxc_retencion_Multiple_Documentos_ValorAplicado_Info> Get_List_Cobro_detalle(int IdEmpresa, int idMulti, int idcobro)
        {
            try
            {
                return data.Get_List_Retencion_detalle(IdEmpresa, idMulti, idcobro);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Cobro_detalle", ex.Message), ex) { EntityType = typeof(cxc_retencion_Multiple_Documentos_ValorAplicado_Bus) };
            }

        }

        public cxc_retencion_Multiple_Documentos_ValorAplicado_Info Get_Retencion_detalle(int IdEmpresa, int idMulti, int idcobro)
        {
            try
            {
                return data.Get_Retencion_detalle(IdEmpresa, idMulti, idcobro);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Cobro_detalle", ex.Message), ex) { EntityType = typeof(cxc_retencion_Multiple_Documentos_ValorAplicado_Bus) };
            }

        }

        public List<cxc_retencion_Multiple_Documentos_ValorAplicado_Info> Get_List_cobro_x_documento(int IdEmpresa, int IdMulti)
        {
            try
            {
                return data.Get_List_Retencion_x_documento(IdEmpresa, IdMulti);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_documento", ex.Message), ex) { EntityType = typeof(cxc_retencion_Multiple_Documentos_ValorAplicado_Bus) };
            }
        }
    }
}