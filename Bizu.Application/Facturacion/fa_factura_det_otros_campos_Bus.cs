using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Domain.Facturacion;
using Bizu.Infrastructure.Facturacion;

using Bizu.Application.General;

namespace Bizu.Application.Facturacion
{
  public  class fa_factura_det_otros_campos_Bus
    {
      fa_factura_det_otros_campos_Data oData = new fa_factura_det_otros_campos_Data();

      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

      string mensaje = "";

      public Boolean GuardarDetalleOtrosCampos(List<fa_factura_det_otros_campos_Info> Lst)
      {
          try
          {
              return oData.GuardarDB(Lst);
          }
          catch (Exception ex)
          {

              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDetalleOtrosCampos", ex.Message), ex) { EntityType = typeof(fa_factura_det_otros_campos_Bus) };

          }



      }  
    }
}
