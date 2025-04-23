using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.CuentasxPagar;
using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Application.General;

namespace Bizu.Application.CuentasxPagar
{
    public class cp_TerminoPago_Bus
    {
        
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cp_TerminoPago_Data odata = new cp_TerminoPago_Data();

        public List<cp_TerminoPago_Info> Get_List_TerminoPago(int idempresa)
        {
            try
            {
                return odata.Get_List_TerminoPago(idempresa);
            }
            catch (Exception ex)
            {

                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerPedido_Detalle", ex.Message), ex) { EntityType = typeof(cp_TerminoPago_Bus) };
            }
        }

        public Boolean GuardarDB(cp_TerminoPago_Info _Info, ref string msjError)
        {
            try
            {
                return odata.GuardarDB(_Info);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(cp_TerminoPago_Bus) };

            }
        }

        public Boolean ModificarDB(cp_TerminoPago_Info _Info, ref string msjError)
        {
            try
            {
                return odata.ModificarDB(_Info);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Modificacion", ex.Message), ex) { EntityType = typeof(cp_TerminoPago_Bus) };

            }
        }

        public Boolean AnularDB(cp_TerminoPago_Info _Info, ref string msjError)
        {
            try
            {
                return odata.AnularDB(_Info);

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Modificacion", ex.Message), ex) { EntityType = typeof(cp_TerminoPago_Bus) };

            }
        }

        //public List<cp_TerminoPago_Info> Get_List_TerminoPago_Proveedor(int idempresa, int idproveedor)
        //{
        //    try
        //    {
        //        return odata.Get_List_TerminoPago_Proveedor(idempresa, idproveedor);
        //    }
        //    catch (Exception ex)
        //    {

        //        Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerPedido_Detalle", ex.Message), ex) { EntityType = typeof(cp_TerminoPago_Bus) };
        //    }
        //}

        //public List<cp_TerminoPago_Info> Get_List_TerminoPago()
        //{
        //    try
        //    {
        //        return odata.Get_List_TerminoPago();
        //    }
        //    catch (Exception ex)
        //    {

        //        Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerPedido_Detalle", ex.Message), ex) { EntityType = typeof(cp_TerminoPago_Bus) };
        //    }
        //}

              

    }
}
