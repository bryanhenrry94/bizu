using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.Facturacion;
using Bizu.Infrastructure.Facturacion;



namespace Bizu.Application.Facturacion
{
   public  class fa_cliente_tipo_Bus
    {
       fa_cliente_tipo_Data Odata = new fa_cliente_tipo_Data();

       public Boolean Guardar_DB(fa_cliente_tipo_Info Info, ref int IdTipoCliente, ref string msjError)
       {
           try
           {
               return Odata.GuardarDB(Info, ref IdTipoCliente, ref msjError);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "fa_cliente_tipo_Bus", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
           }
       }


       public Boolean ModificarDB(fa_cliente_tipo_Info Info, ref string msjError)
       {
           try
           {
               return Odata.ModificarDB(Info, ref msjError);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Modificar_DB", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
           }
       }


       public Boolean AnularDB(fa_cliente_tipo_Info Info, ref string msjError)
       {
           try
           {
               return Odata.AnularDB(Info, ref msjError);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Anular_DB", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
           }
       }



       public List<fa_cliente_tipo_Info> Get_List_fa_cliente_tipo(int IdEmpresa)
       {           
           try
           {
               return Odata.Get_List_fa_cliente_tipo(IdEmpresa);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_fa_cliente_tipo", ex.Message), ex) { EntityType = typeof(fa_catalogo_tipo_Bus) };
           }
       }

    }
}
