using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bizu.Domain.Inventario;
using Bizu.Infrastructure.Inventario;

using Bizu.Application.General;
using Bizu.Infrastructure;
using Bizu.Domain.Compras;



namespace Bizu.Application.Inventario
{
  public  class in_Guia_x_traspaso_bodega_det_Bus
    {
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

      in_Guia_x_traspaso_bodega_det_Data odata = new in_Guia_x_traspaso_bodega_det_Data();

      string mensaje = "";

      public Boolean GuardarDB(List<in_Guia_x_traspaso_bodega_det_Info> LstInfo)
      {
          try
          {
              return odata.GuardarDB(LstInfo);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_Guia_x_traspaso_bodega_det_Bus) };

           
          }
      }


      public Boolean EliminarDB(int IdEmpresa,decimal IdGuia)
      {
          try
          {
              return odata.EliminarDB(IdEmpresa, IdGuia);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(in_Guia_x_traspaso_bodega_det_Bus) };
          }
      }

      public bool Existe_OC_en_guia(com_ordencompra_local_Info info_OC,ref string sGuiasRelacionadas)
      {
          try
          {
              return odata.Existe_OC_en_guia(info_OC, ref sGuiasRelacionadas);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(in_Guia_x_traspaso_bodega_det_Bus) };
          }
      }

      public List<in_Guia_x_traspaso_bodega_det_Info> Get_List_Guia_x_traspaso_bodega_det(int IdEmpresa, decimal IdGuia)
      {
          try
          {
              return odata.Get_List_Guia_x_traspaso_bodega_det(IdEmpresa, IdGuia);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ObtenerListDetGui_OC", ex.Message), ex) { EntityType = typeof(in_Guia_x_traspaso_bodega_det_Bus) };
          
          }
      }

      public List<in_Guia_x_traspaso_bodega_det_Info> Get_List_Guia_x_traspaso_bodega_sin_transferencia_det(int IdEmpresa, decimal IdGuia)
      {
          try
          {
              return odata.Get_List_Guia_x_traspaso_bodega_sin_transferencia_det(IdEmpresa, IdGuia);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Guia_x_traspaso_bodega_x_OC_det", ex.Message), ex) { EntityType = typeof(in_Guia_x_traspaso_bodega_det_Bus) };

          }
      }

      public List<in_Guia_x_traspaso_bodega_det_Info> Get_List_Guia_x_traspaso_bodega_x_OC_det(int idempresa, decimal IdGuia)
      {
          try
          {
              return odata.Get_List_Guia_x_traspaso_bodega_x_OC_det(idempresa, IdGuia);
          }
          catch (Exception ex)
          {
              Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Guia_x_traspaso_bodega_x_OC_det", ex.Message), ex) { EntityType = typeof(in_Guia_x_traspaso_bodega_det_Bus) };

          }
      }
    }
}
