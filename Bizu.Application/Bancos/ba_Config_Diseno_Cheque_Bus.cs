using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Bancos;
using Bizu.Infrastructure.Bancos;
using Bizu.Application.General;

namespace Bizu.Application.Bancos
{
    public class ba_Config_Diseno_Cheque_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_Config_Diseno_Cheque_Data chequeB = new ba_Config_Diseno_Cheque_Data();

        public ba_Config_Diseno_Cheque_Info Get_List_Config_Diseno_Cheque(ba_Banco_Cuenta_Info Cheque_I)
        {
            try
            {
                return chequeB.Get_List_Config_Diseno_Cheque(Cheque_I);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Config_Diseno_Cheque", ex.Message), ex) { EntityType = typeof(ba_Config_Diseno_Cheque_Bus) };
            }
        }
        
        public Boolean GrabarDB(ba_Config_Diseno_Cheque_Info Cheque_I, ref string mensaje)
        {
            try
            {
                return chequeB.GrabarDB(Cheque_I, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ba_Config_Diseno_Cheque_Bus) };
            }
        }
       
        public Boolean Actualizar(ba_Config_Diseno_Cheque_Info Cheque_I, ref string mensaje)
        {
            {
                try
                {
                    return chequeB.Actualizar(Cheque_I, ref mensaje);
                }
                catch (Exception ex)
                {
                    Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                    throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Actualizar", ex.Message), ex) { EntityType = typeof(ba_Config_Diseno_Cheque_Bus) };
                }
            }


        }
    }
}