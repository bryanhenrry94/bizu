using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.CuentasxCobrar;
using Bizu.Domain.CuentasxCobrar;
using Bizu.Application.General;

namespace Bizu.Application.CuentasxCobrar
{
    public class cxc_EstadoCobro_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        cxc_EstadoCobro_Data data = new cxc_EstadoCobro_Data();

        public Boolean Guardar(cxc_EstadoCobro_Info Info)
        {
            try
            {
                return data.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
            }
        }
        public Boolean ModificarDB(cxc_EstadoCobro_Info Info)
        {
            try
            {
                return data.ModificarDB(Info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
            }
        }
        public List<cxc_EstadoCobro_Info> Get_List_EstadoCobro()
        {
            try
            {
                return data.Get_List_EstadoCobro();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_EstadoCobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
            }
        }
    }
}
