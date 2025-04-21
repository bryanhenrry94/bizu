using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Info.SoporteTecnico;
using Core.Erp.Data.General;
using Core.Erp.Data.SoporteTecnico;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;


namespace Core.Erp.Business.SoporteTecnico
{
   public class st_Catalogo_Bus
    {
       string mensaje = ""; 

       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       st_Catalogo_Data CtD = new st_Catalogo_Data();
                   
       public List<st_Catalogo_Info> Get_List_Catalogo(Cl_Enumeradores.TipoCatalogo IdTipoCatalogo)
       {
            try
            {
                return CtD.Get_List_Catalogo(IdTipoCatalogo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerList_Catalogo", ex.Message), ex) { EntityType = typeof(st_Catalogo_Bus) };         
            }
        }

       public List<st_Catalogo_Info> Get_List_MotivoAnulacion()
       {
           try
           {               
               return CtD.Get_List_MotivoAnulacion();
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerList_MotivoAnulacion", ex.Message), ex) { EntityType = typeof(st_Catalogo_Bus) };

           }
       }

       public List<st_Catalogo_Info> Get_CatalogoPorTipo(int IdTipoCatalgo)
       {
           try
           {               
               return CtD.Get_CatalogoPorTipo(IdTipoCatalgo);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObteneCatalogoPorTipo", ex.Message), ex) { EntityType = typeof(st_Catalogo_Bus) };

           }
       }

       public Boolean Anular(st_Catalogo_Info info, ref string msg)
        {
            try 
	        {	        
		        return CtD.AnularDB(info,ref msg);
	        }
	        catch (Exception ex)
	        {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(st_Catalogo_Bus) };
         
	        }
        }

       public Boolean GrabarDB(st_Catalogo_Info info, ref string msg, ref int id)
        {
            try
            {
                return CtD.GrabarDB(info, ref msg,ref id);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(st_Catalogo_Bus) };
         
            }
        }

       public Boolean ModificarDB(st_Catalogo_Info info, ref string msg)
        {
            try
            {
                return CtD.ModificarDB(info,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(st_Catalogo_Bus) };
         
            }
        }

       public string Get_DescripcionDocumentoIdentidad(string codigo, ref string descripcion)
       {
           try
           {
               return CtD.Get_DescripcionDocumentoIdentidad(codigo, ref descripcion);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_DescripcionDocumentoIdentidad", ex.Message), ex) { EntityType = typeof(st_Catalogo_Bus) };

           }
       }

   }
}
