using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Domain.Facturacion;
using Bizu.Infrastructure.Facturacion;

using Bizu.Application.General;

namespace Bizu.Application.Facturacion
{
  public  class fa_factura_det_Bus
    {
      string mensaje="";
      fa_factura_det_Data oData = new fa_factura_det_Data();

      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();


      public Boolean GuardarDB(List<fa_factura_det_info> Lista, ref decimal Id, ref string msg)
      {

          try
          {
              return oData.GuardarDB(Lista,ref Id, ref msg);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDetalle", ex.Message), ex) { EntityType = typeof(fa_factura_det_Bus) };
          }
      }


      

      public List<fa_factura_det_info> Get_List_factura_det(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta, ref string msg)
      {
          try
          {
              return oData.Get_List_factura_det(IdEmpresa,  IdSucursal,  IdBodega,  IdCbteVta, ref  msg);
          }
          catch (Exception ex)
          {

              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ConsultaDetalle", ex.Message), ex) { EntityType = typeof(fa_factura_det_Bus) };
          }
      
      }


      public Boolean ModificarDB(List<fa_factura_det_info> Lista, fa_factura_Info info)
      {
          try
          {
              return oData.ModificarDB(Lista,info);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarDetalle", ex.Message), ex) { EntityType = typeof(fa_factura_det_Bus) };
          }

      }
    }
}
