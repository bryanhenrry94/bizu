using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.General;
using Bizu.Infrastructure.General;
using Bizu.Application.General;


namespace Bizu.Application.General
{
    public class tb_banco_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";

        tb_Banco_Data oData = new tb_Banco_Data();

        public List<tb_banco_Info> Get_List_Banco()
        {
            try
            {
                   return oData.Get_List_Banco();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_Bus) };
            }
     
        }

        public tb_banco_Info Get_Info_Banco(int IdBanco)
        {
            try
            {
                return oData.Get_Info_Banco(IdBanco);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_Bus) };
            }

        }

        public Boolean GrabarDB(tb_banco_Info Info, ref string msg)
        {
            try
            {
                bool res = false;
                res = oData.GrabarDB(Info, ref msg);
                               
                return res;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_Bus) };
            }
     
        }

        public Boolean ActualizarDB(tb_banco_Info Info, ref string msg)
        {
            try
            {
                bool res = false;

                res = oData.ActualizarDB(Info, ref msg);
                                
                return res;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_Bus) };
            }
        }

        public Boolean AnulaDB(tb_banco_Info Info, ref string msg)
        {
            try
            {
                return oData.AnulaDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ListaBancos", ex.Message), ex) { EntityType = typeof(tb_banco_Bus) };
            }
        }
    }
}
