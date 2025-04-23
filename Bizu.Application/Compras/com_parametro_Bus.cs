using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Compras;
using Bizu.Infrastructure.Compras;


namespace Bizu.Application.Compras
{
    public class com_parametro_Bus
    {
        com_parametro_Data odata = new com_parametro_Data();

        public com_parametro_Info Get_Info_parametro(int idempresa)
        {
            try
            {
                com_parametro_Info list = new com_parametro_Info();

                list = odata.Get_Info_parametro(idempresa);

                return list; 
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_parametro", ex.Message), ex) { EntityType = typeof(com_parametro_Bus) };

            }

        }

        public List<com_parametro_Info> Get_List_parametro(int idempresa)
        {
            try
            {
                List<com_parametro_Info> list = new List<com_parametro_Info>();

                list = odata.Get_List_parametro(idempresa);

                return list;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_parametro", ex.Message), ex) { EntityType = typeof(com_parametro_Bus) };
            }
           
        }

        public Boolean GuardarDB(com_parametro_Info Info, ref string msg)
        {
            try
            {
                return odata.GuardarDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_parametro_Bus) };
            }

        }

        public Boolean ModificarDB(com_parametro_Info Info, ref  string msg)
        {
            try
            {
                return odata.ModificarDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(com_parametro_Bus) };
            }
        }

        public com_parametro_Bus()
        {
                
        }

    }
}
