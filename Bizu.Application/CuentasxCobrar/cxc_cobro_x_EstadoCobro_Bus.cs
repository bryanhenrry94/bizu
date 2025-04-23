using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.CuentasxCobrar;
using Bizu.Domain.CuentasxCobrar;
using Bizu.Application.General;

namespace Bizu.Application.CuentasxCobrar
{
    public class cxc_cobro_x_EstadoCobro_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cxc_cobro_x_EstadoCobro_Data data = new cxc_cobro_x_EstadoCobro_Data();

        public Boolean GuardarDB_Verifica_si_es_Protestado(List<cxc_cobro_x_EstadoCobro_Info> lista, ref string msg)
        {
            try
            {
              return data.GuardarDB_Verifica_si_es_Protestado(lista,ref msg);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB_Verifica_si_es_Protestado", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
            }

        }

        public List<cxc_cobro_x_EstadoCobro_Info> Get_List_cobro_x_EstadoCobro(int IdEmpresa)
        {
            try
            {
               return data.Get_List_cobro_x_EstadoCobro(IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_EstadoCobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
            }

        }

        public Boolean GuardarDB_(cxc_cobro_x_EstadoCobro_Info InfoEstadoCobro)
        {
            try
            {
                return data.GuardarDB_(InfoEstadoCobro);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB_Verifica_si_es_Protestado", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
            }

        }

        public List<cxc_cobro_x_EstadoCobro_Info> Get_List_cobro_x_EstadoCobro_Concil(int IdEmpresa, int IdSucursal, int IdCobro)
        {
            try
            {
                return data.Get_List_cobro_x_EstadoCobro_Concil(IdEmpresa, IdSucursal, IdCobro);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_EstadoCobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
            }

        }

        public Boolean ModificarEstadoCobro_Concil(List<cxc_cobro_x_EstadoCobro_Info> lista)
        {
            try
            {
                return data.ModificarEstadoCobro_Concil(lista);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDetalleCobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }

        }
    }
}
