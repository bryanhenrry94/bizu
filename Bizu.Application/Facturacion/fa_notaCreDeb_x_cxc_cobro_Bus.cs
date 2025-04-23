using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Infrastructure.Facturacion;
using Bizu.Domain.Facturacion;

using Bizu.Application.General;

namespace Bizu.Application.Facturacion
{
  public class fa_notaCreDeb_x_cxc_cobro_Bus
    {
      fa_notaCreDeb_x_cxc_cobro_Data oData = new fa_notaCreDeb_x_cxc_cobro_Data();

      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

      public Boolean GuardarDB(fa_notaCreDeb_x_cxc_cobro_Info Item, ref string mensaje)
      {
          try
          {
              return oData.GuardarDB(Item, ref mensaje);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Guardar_NotaCreDeb_x_Cobro", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_x_cxc_cobro_Bus) };
           
          }
      }

      public fa_notaCreDeb_x_cxc_cobro_Info Get_info_cobro_x_nc(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
      {
          try
          {
              return oData.Get_info_cobro_x_nc(IdEmpresa, IdSucursal, IdBodega, IdNota);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Guardar_NotaCreDeb_x_Cobro", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_x_cxc_cobro_Bus) };

          }
      }


      


    }
}
