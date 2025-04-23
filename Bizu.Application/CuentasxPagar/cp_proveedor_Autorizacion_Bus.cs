using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Domain.CuentasxPagar;
using Bizu.Application.General;

namespace Bizu.Application.CuentasxPagar
{
   public class cp_proveedor_Autorizacion_Bus
   {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";
       cp_proveedor_Autorizacion_Data data = new cp_proveedor_Autorizacion_Data();
       public List<cp_proveedor_Autorizacion_Info> Get_List_proveedor_Autorizacion(int IdEmpresa, decimal IdProveedor)
       {
           try
           {
               cp_proveedor_Autorizacion_Data tp_data_ = new cp_proveedor_Autorizacion_Data();
               return tp_data_.Get_List_proveedor_Autorizacion(IdEmpresa,IdProveedor);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_proveedor_Autorizacion", ex.Message), ex) { EntityType = typeof(cp_proveedor_Autorizacion_Bus) };
           }

       }

       public List<cp_proveedor_Autorizacion_Info> Get_List_proveedor_Autorizacion(int IdEmpresa)
       {
           try
           {
                cp_proveedor_Autorizacion_Data tp_data_ = new cp_proveedor_Autorizacion_Data();
                return tp_data_.Get_List_proveedor_Autorizacion(IdEmpresa);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_proveedor_Autorizacion", ex.Message), ex) { EntityType = typeof(cp_proveedor_Autorizacion_Bus) };
           }

       }

       public List<cp_proveedor_Autorizacion_Info> Get_List_proveedor_Autorizacion(int Iempresa, decimal Iproveedor, DateTime fecha)
       {
           try
           {
               cp_proveedor_Autorizacion_Data tp_data_ = new cp_proveedor_Autorizacion_Data();
               return tp_data_.Get_List_proveedor_Autorizacion(Iempresa, Iproveedor,fecha);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_proveedor_Autorizacion", ex.Message), ex) { EntityType = typeof(cp_proveedor_Autorizacion_Bus) };
           }
       }

       public List<cp_proveedor_Autorizacion_Info> Get_List_proveedor_Autorizacion(int IdEmpresa, decimal Iproveedor, string NumAutoriza, string Establecimiento, string Pto_Emision, decimal NumDoc)
       {
           try
           {
               cp_proveedor_Autorizacion_Data tp_data_ = new cp_proveedor_Autorizacion_Data();
               return tp_data_.Get_List_proveedor_Autorizacion(IdEmpresa, Iproveedor, NumAutoriza, Establecimiento, Pto_Emision, NumDoc);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_proveedor_Autorizacion", ex.Message), ex) { EntityType = typeof(cp_proveedor_Autorizacion_Bus) };
           }
       }

       public Boolean GrabarDB(cp_proveedor_Autorizacion_Info info, ref decimal idAutorizacion)
       {
           try
           {
               return data.GrabarDB(info, ref idAutorizacion);

           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_proveedor_Autorizacion_Bus) };
           }
       }

       public Boolean GrabarDB(List<cp_proveedor_Autorizacion_Info> lista)
       {
           try
           {
              return data.GrabarDB(lista);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_proveedor_Autorizacion_Bus) };
           }
       }

       public Boolean ModificarDB(List<cp_proveedor_Autorizacion_Info> lista, int IdEmpresa, decimal IdProveedor)
       {
           try
           { 
               return data.ModificarDB(lista,IdEmpresa, IdProveedor);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_proveedor_Autorizacion_Bus) };
           }
       }

       public Boolean EliminarDB(List<cp_proveedor_Autorizacion_Info> lista)
       {
           try
           {
                return data.EliminarDB(lista);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(cp_proveedor_Autorizacion_Bus) };
           }
       }

       public Boolean ModificarDB(cp_proveedor_Autorizacion_Info info)
       {

           try
           {
               return data.ModificarDB(info);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_proveedor_Autorizacion_Bus) };
           }
       }

       public cp_proveedor_Autorizacion_Info Get_Info_proveedor_Autorizacion(int Iempresa, decimal Iproveedor, decimal iAutorizacion)
       {
           try
           {
               return data.Get_Info_proveedor_Autorizacion(Iempresa,Iproveedor,iAutorizacion);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_proveedor_Autorizacion", ex.Message), ex) { EntityType = typeof(cp_proveedor_Autorizacion_Bus) };
           }
       }

       public cp_proveedor_Autorizacion_Info ExisteNAutorizacion(int IdEmpresa, decimal IdProveedor, string NAutorizacion)
       {
           try
           {
               return data.ExisteNAutorizacion(IdEmpresa, IdProveedor, NAutorizacion);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ExisteNAutorizacion", ex.Message), ex) { EntityType = typeof(cp_proveedor_Autorizacion_Bus) };
           }
       }

       public cp_proveedor_Autorizacion_Info Get_Info_proveedor_Autorizacion(int Iempresa, decimal Iproveedor, string Ser1, string ser2, string numeroFact)
       {
           try
           {
               return data.Get_Info_proveedor_Autorizacion(Iempresa, Iproveedor, Ser1, ser2, numeroFact);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_proveedor_Autorizacion", ex.Message), ex) { EntityType = typeof(cp_proveedor_Autorizacion_Bus) };
           }
       }
  }
}
