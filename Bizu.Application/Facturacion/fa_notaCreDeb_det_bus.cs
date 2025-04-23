using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Facturacion;
using Bizu.Infrastructure.Facturacion;
using Bizu.Application.General;

namespace Bizu.Application.Facturacion
{
   public  class fa_notaCreDeb_det_bus
    {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";
       fa_notaCreDeb_det_Data odata = new fa_notaCreDeb_det_Data();


       public List<fa_notaCreDeb_det_Info> Get_List_notaCreDeb_det(fa_notaCreDeb_Info Info)
       {
           try
           {
                 return odata.Get_List_notaCreDeb_det(Info);
           }
           catch (Exception ex)
           {
               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerLista", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_det_bus) };
           
           }

       }

       public List<fa_notaCreDeb_det_Info> Get_List_notaCreDeb_det(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
       {
           try
           {
               return odata.Get_List_notaCreDeb_det(IdEmpresa,  IdSucursal,  IdBodega,  IdNota);
           }
           catch (Exception ex)
           {


               Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Consulta", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_det_bus) };
           }
       
       
       }
       

    }
}
