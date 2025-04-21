using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class in_parametro_Impuesto_Iva_Ice_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        in_parametro_Impuesto_Iva_Ice_Data oData = new in_parametro_Impuesto_Iva_Ice_Data();

        public List<in_parametro_Impuesto_Iva_Ice_Info> Get_List_Impuesto_Iva_Ice(int IdEmpresa)
        {
            try
            {
                return oData.Get_List_Impuesto_Iva_Ice(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Impuesto_Iva_Ice", ex.Message), ex) { EntityType = typeof(in_Catalogo_Bus) };

            }
        }

        public in_parametro_Impuesto_Iva_Ice_Info Get_Info_Impuesto_Iva_Ice(int IdEmpresa)
        {
            try
            {
                return oData.Get_Info_Impuesto_Iva_Ice(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Impuesto_Iva_Ice", ex.Message), ex) { EntityType = typeof(in_Catalogo_Bus) };

            }
        }

        public Boolean GuardarDB(in_parametro_Impuesto_Iva_Ice_Info info, ref string msg)
        {
            try
            {
                return oData.GuardarDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_parametro_Impuesto_Iva_Ice_Bus) };

            }
        }

        public Boolean ModificarDB(in_parametro_Impuesto_Iva_Ice_Info info)
        {
            try
            {
                return oData.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_Catalogo_Bus) };

            }
        }

    }
}
