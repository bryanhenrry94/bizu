using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Bancos;
using Bizu.Infrastructure.Bancos;
using Bizu.Domain.General;
using Bizu.Application.General;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.Serialization;



namespace Bizu.Application.Bancos
{
   public  class ba_Transacciones_x_excel_a_conciliar_Bus
    {

       ba_Transacciones_x_excel_a_conciliar_Data Odata = new ba_Transacciones_x_excel_a_conciliar_Data();


       public List<ba_Transacciones_x_excel_a_conciliar_Info> ProcesarDataTable_a_Info(DataTable ds, int idempresa, ref string MensajeError)
       {
           try
           {

               return Odata.ProcesarDataTable_a_Info(ds, idempresa, ref MensajeError);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ProcesarDataTable_a_Info", ex.Message), ex) { EntityType = typeof(ba_Transacciones_x_excel_a_conciliar_Bus) };
           }

       }

    }
}
