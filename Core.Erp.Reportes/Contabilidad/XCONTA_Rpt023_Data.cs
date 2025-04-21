using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;



namespace Core.Erp.Reportes.Contabilidad
{
  public   class XCONTA_Rpt023_Data
    {



      public List<XCONTA_Rpt023_Info> consultar_data(int IdEmpresa, DateTime FechaIni, DateTime FechaFin
     
    , bool Mostrar_reg_en_cero
   , bool Considerar_Asiento_cierre_anual, string IdUsuario, ref String MensajeError)
      {
          try
          {
              List<XCONTA_Rpt023_Info> listadedatos = new List<XCONTA_Rpt023_Info>();
              FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
              FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());


              using (EntitiesContabilidadRptGeneral Estado_Resultado = new EntitiesContabilidadRptGeneral())
              {


                  Estado_Resultado.SetCommandTimeOut(30000);//timeout 3 minutos

                  IList<spCONTA_Rpt023_Result> listBalance =
                  Estado_Resultado.spCONTA_Rpt023(IdEmpresa, FechaIni, FechaFin, 0,
                   Mostrar_reg_en_cero, Considerar_Asiento_cierre_anual, IdUsuario, "ER").ToList();

                   
                    var Querry_x_ER = from C in listBalance
                                      where C.IdGrupoCble == "COSTO"
                                      orderby C.IdCtaCble ascending
                                      select C;
               

                 

                  foreach (var item in Querry_x_ER)
                  {
                      XCONTA_Rpt023_Info itemInfo = new XCONTA_Rpt023_Info();
                      itemInfo.IdEmpresa = item.IdEmpresa;
                      itemInfo.IdCtaCble = item.IdCtaCble;
                      itemInfo.IdCtaCble_Padre = item.IdCtaCble_Padre;
                      itemInfo.IdCentroCosto = item.IdCentroCosto;
                      itemInfo.IdUsuario = item.IdUsuario;
                      itemInfo.Saldo_Inicial = item.Saldo_Inicial;
                      itemInfo.Saldo_Deudor = item.Saldo_Deudor;
                      itemInfo.Saldo_Acreedor = item.Saldo_Acreedor;
                      itemInfo.Saldo_Acumulado = item.Saldo_Acumulado;
                      itemInfo.nom_cuenta = item.nom_cuenta;
                      itemInfo.CodCentroCosto = item.CodCentroCosto;
                      itemInfo.nom_centrocosto = item.nom_centrocosto;
                      itemInfo.IdNivelCta = item.IdNivelCta;
                      itemInfo.IdGrupoCble = item.IdGrupoCble;
                      itemInfo.nom_grupoCble = item.nom_grupoCble;
                      itemInfo.nom_empresa = item.nom_empresa;
                      itemInfo.TipoBalance = item.TipoBalance;


                      itemInfo.IdTipo_Gasto = item.IdTipo_Gasto;
                      itemInfo.nom_tipo_Gasto = item.nom_tipo_Gasto;

                      itemInfo.IdTipo_Costo = item.IdTipo_Costo;
                      itemInfo.nom_tipo_Costo = item.nom_tipo_Costo;





                                          
                      listadedatos.Add(itemInfo);

                  }


                 
                    
                    

              }
              return listadedatos;
          }
          catch (Exception ex)
          {
              string mensaje = "";
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }

      }
        
    
    
    


    }
}
