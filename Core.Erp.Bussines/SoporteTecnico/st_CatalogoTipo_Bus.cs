using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.SoporteTecnico;
using Core.Erp.Info.SoporteTecnico;
using Core.Erp.Business.General;


namespace Core.Erp.Business.SoporteTecnico
{
    public class st_CatalogoTipo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        st_CatalogoTipo_Data data = new st_CatalogoTipo_Data();
        string mensaje = "";

        public List<st_CatalogoTipo_Info> ObtenerList_Tipo()
        {
            try
            {                
                return data.Get_List_CatalogoTipo();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerList_Tipo", ex.Message), ex) { EntityType = typeof(st_CatalogoTipo_Bus) };         
            }
        }
        
        public Boolean GrabaItem(st_CatalogoTipo_Info info, ref string msg , ref int IdCatalgoTipo)
        {
            try
            {                
                return data.GrabaDB(info, ref msg, ref IdCatalgoTipo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabaItem", ex.Message), ex) { EntityType = typeof(st_CatalogoTipo_Bus) };
         
            }
        }

        public Boolean ModificaItem(st_CatalogoTipo_Info info, ref string msg)
        {
            try
            {
                return data.ModificaDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificaItem", ex.Message), ex) { EntityType = typeof(st_CatalogoTipo_Bus) };
         
            }
        }

        public st_CatalogoTipo_Bus() {
            try
            {

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "st_CatalogoTipo_Bus", ex.Message), ex) { EntityType = typeof(st_CatalogoTipo_Bus) };
         
            }
        }
    }
}
