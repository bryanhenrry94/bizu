using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Domain.CuentasxPagar;
using Bizu.Infrastructure.CuentasxPagar;

using Bizu.Application.General;


namespace Bizu.Application.CuentasxPagar
{
   public class cp_Autorizacion_x_Doc_x_Pag_Bus
    {
       string mensaje = "";
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

       cp_Autorizacion_x_Doc_x_Pag_Data odata = new cp_Autorizacion_x_Doc_x_Pag_Data();

        public Boolean GuardarDB(cp_Autorizacion_x_Doc_x_Pag_Info Info, ref string msg)
        {
            try
            {
                return odata.GuardarDB(Info, ref  msg);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_Autorizacion_x_Doc_x_Pag_Bus) };
            }
        }


        public Boolean Verificar_NumAutorizacion_Ogiro(string NumAutorizacion, ref string msg)
        {
            try
            {

                return odata.Verificar_NumAutorizacion_Ogiro(NumAutorizacion, ref  msg);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Verificar_NumAutorizacion_Ogiro", ex.Message), ex) { EntityType = typeof(cp_Autorizacion_x_Doc_x_Pag_Bus) };
            }
        }
    }
}
