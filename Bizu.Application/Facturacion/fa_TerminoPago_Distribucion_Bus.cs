using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.Facturacion;
using Bizu.Domain.Facturacion;
using Bizu.Application.General;

namespace Bizu.Application.Facturacion
{
    public class fa_TerminoPago_Distribucion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        fa_TerminoPago_Distribucion_Data data = new fa_TerminoPago_Distribucion_Data();

        public List<fa_TerminoPago_Distribucion_Info> Get_List_TerminoPago_Distribucion(string IdTipoFormaPago)
        {
            try
            {
                return data.Get_List_TerminoPago_Distribucion(IdTipoFormaPago);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "obtenerLista", ex.Message), ex) { EntityType = typeof(fa_TerminoPago_Distribucion_Bus) };
           
            }
        }

        public Boolean GuardarDB(List<fa_TerminoPago_Distribucion_Info> lst, ref string msjError)
        {
            try
            {
                return data.GuardarDB(lst);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(fa_TerminoPago_Distribucion_Bus) };
           
            }
        }

        public Boolean ModificarDB(List<fa_TerminoPago_Distribucion_Info> lst)
        {
            try
            {
                return data.ModificarDB(lst); 
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(fa_TerminoPago_Distribucion_Bus) };
           
            }
        }

        public Boolean EliminarDB(string IdTipoFormaPago, ref string msjError)
        {
            try
            {
                return data.EliminarDB(IdTipoFormaPago);
            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "eliminar", ex.Message), ex) { EntityType = typeof(fa_TerminoPago_Distribucion_Bus) };
           
            }
        }
    }
}
