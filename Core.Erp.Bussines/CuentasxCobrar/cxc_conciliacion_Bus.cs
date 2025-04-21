using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;

namespace Core.Erp.Business.CuentasxCobrar
{
   public class cxc_conciliacion_Bus
    {
       cxc_conciliacion_Data oData = new cxc_conciliacion_Data();
       cxc_conciliacion_det_Data oDataDetalle = new cxc_conciliacion_det_Data();
       cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
       cxc_cobro_Bus cobro_B = new cxc_cobro_Bus();
       fa_notaCreDeb_x_cxc_cobro_Bus Bus_NotaCreDeb = new fa_notaCreDeb_x_cxc_cobro_Bus();
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       cxc_parametro_Info paramInfo = new cxc_parametro_Info();
       decimal idctctb = 0;
       
       public Boolean GuardarDB(cxc_conciliacion_Info Item, ct_Cbtecble_Info CbteCbleInfo , Cl_Enumeradores.TipoConciliacion TipoConciliacion,  ref decimal Id, ref string mensaje)
       {
           try
           {
               cxc_cobro_Info CobrosInfo = new cxc_cobro_Info();
               cxc_cobro_Det_Info CobroDetalleInfo = new cxc_cobro_Det_Info();
               List<cxc_cobro_Det_Info> lstCobDetInfo = new List<cxc_cobro_Det_Info>();
               fa_notaCreDeb_x_cxc_cobro_Info info_NotaCreDeb = new fa_notaCreDeb_x_cxc_cobro_Info();
               Boolean resultCobro = true;

               //inserto la tabla conciliacion y conciliacion_det
               oData.Guardar_Conciliacion(Item, ref Id, ref  mensaje);
               decimal idConciliacion = Id;

               //si es por anticipo solo inserto el detalle del cobro
               if (Cl_Enumeradores.TipoConciliacion.ANT_CLI == TipoConciliacion || Cl_Enumeradores.TipoConciliacion.ANT_CLIF == TipoConciliacion)
               {
                   ct_Cbtecble_Bus CbteCbleBus = new ct_Cbtecble_Bus();
                   decimal idCbteCble = 0;
                   decimal IdCobroDet = 0;

                   //*****************************  INICIO GRABAR COBRO DETALLE  *********************      

                   var select_detalle_cobro = from T in Item.DetalleCobroFact
                                              group T by new
                                              {
                                                  T.IdEmpresa,
                                                  T.IdSucursal,
                                                  T.IdCobro,                                                   
                                              }
                                                  into grouping
                                                  select new { grouping.Key.IdEmpresa, grouping.Key.IdSucursal, grouping.Key.IdCobro };

                   //recorre el detalle de la conciliacion agrupado por cobro
                   foreach (var item in select_detalle_cobro)
                   {                       
                       IdCobroDet = Convert.ToInt32(item.IdCobro);

                       CobrosInfo = cobro_B.Get_Info_cobro_x_cliente(Item.IdEmpresa, Item.IdSucursal, IdCobroDet, Convert.ToInt32(Item.IdCliente));

                       if (CobrosInfo != null)
                       {
                           CobrosInfo.cr_fecha = Item.Fecha;
                           CobrosInfo.cr_fechaCobro = Item.Fecha;
                           CobrosInfo.cr_fechaDocu = Item.Fecha;
                       }

                       //inserto detalle del cobro en la tabla cxc_cobro_det
                       resultCobro = Grabar_DetalleCobro_x_Conciliacion(Item, IdCobroDet);                                                
                   }

                   //cxc_conciliacion_det_Bus Bus_conciliacion_det = new cxc_conciliacion_det_Bus();
                   //Bus_conciliacion_det.Modificar_Secuencia_Cobro_DB(Item.Detalle, ref mensaje);
                   
                   //inserto la contabilidad de los registros
                   if (CbteCbleBus.GrabarDB(CbteCbleInfo, ref idCbteCble, ref mensaje))
                   {
                       //actualizo la cabecera de la concilacion con los id del cbte cble
                       Item.IdEmpresa_cbte_cble = CbteCbleInfo.IdEmpresa;
                       Item.IdTipoCbte_cbte_cble = CbteCbleInfo.IdTipoCbte;
                       Item.IdCbteCble_cbte_cble = idCbteCble;
                       Item.IdConciliacion = Id;
                       oData.ModificarConciliacion(Item, ref mensaje);
                   }
                  
                   //*********************** FIN GRABAR COBRO DETALLE **************************                  
               }
               else
               {                  
                   CobrosInfo = Get_Cobro(Item, ref Id);
                   CobrosInfo.EsNegativo = Item.cxc_cobro_Info.EsNegativo;
                   if (CobrosInfo.EsNegativo == "SI")
                   {
                       CobrosInfo.cr_TotalCobro = CobrosInfo.cr_TotalCobro * -1;
                       foreach (var item in CobrosInfo.ListaCobro)
                       {
                           item.dc_ValorPago = item.dc_ValorPago * -1;
                       }
                   }

                   resultCobro = cobro_B.GuardarDB(Cl_Enumeradores.PantallaEjecucion.COBROS, ref CobrosInfo, ref mensaje);
                  
                   //inserto la contabilidad de los registros
                   ct_Cbtecble_Bus CbteCbleBus = new ct_Cbtecble_Bus();                   
                   decimal idCbteCble = 0;
                   if (CbteCbleBus.GrabarDB(CbteCbleInfo, ref idCbteCble, ref mensaje))
                   {
                       //actualizo la cabecera de la concilacion con los id del cbte cble
                       Item.IdEmpresa_cbte_cble = CbteCbleInfo.IdEmpresa;
                       Item.IdTipoCbte_cbte_cble = CbteCbleInfo.IdTipoCbte;
                       Item.IdCbteCble_cbte_cble = idCbteCble;
                       Item.IdConciliacion = Id;
                       oData.ModificarConciliacion(Item, ref mensaje);
                   }
                   
               }

               if (resultCobro)
               {
                   ModificarDB(Item, CobrosInfo, Id, ref mensaje);

                   if (Cl_Enumeradores.TipoConciliacion.NT_CR_DB == TipoConciliacion)
                   {
                       info_NotaCreDeb = Get_faNotaCreDeb_x_Cobro(CobrosInfo, Item);

                       if (CobrosInfo.EsNegativo == "SI")
                       {
                           info_NotaCreDeb.Valor_cobro = 0;
                       }
                       Bus_NotaCreDeb.GuardarDB(info_NotaCreDeb, ref mensaje);
                   }
               }

               return true;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_EstadoCobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
           }
       }

       public void ModificarDB(cxc_conciliacion_Info Item,cxc_cobro_Info CobrosInfo,  decimal Id, ref string mensaje) 
       {
           try
           {               
               cxc_conciliacion_det_Info conciliacionDetalle = new cxc_conciliacion_det_Info();             
               List<cxc_cobro_Det_Info> Info_cxc_cobro_det = new List<cxc_cobro_Det_Info>();
               cxc_cobro_Det_Bus Bus_cxc_cobro_det = new cxc_cobro_Det_Bus();

               Info_cxc_cobro_det = Bus_cxc_cobro_det.Get_List_Cobro_detalle(CobrosInfo.IdEmpresa, CobrosInfo.IdSucursal, Convert.ToDecimal(CobrosInfo.IdCobro));

               //actualizamos secuencia del detalle de la conciliacion con el detalle del cobro
               foreach (var info_cxc_conciliacion_det in Item.Detalle)
               {
                   if (info_cxc_conciliacion_det.IdTipoConciliacion == "VTA")
                   {
                       foreach (var item_prueba in Info_cxc_cobro_det)
                       {
                           if (info_cxc_conciliacion_det.IdEmpresa_cbr == item_prueba.IdEmpresa
                                && info_cxc_conciliacion_det.IdSucursal_cbr == item_prueba.IdSucursal
                                && info_cxc_conciliacion_det.IdCobro == item_prueba.IdCobro
                                && info_cxc_conciliacion_det.secuencia_cbr == item_prueba.secuencial                               
                               )
                           {
                               conciliacionDetalle = new cxc_conciliacion_det_Info();
                               conciliacionDetalle = info_cxc_conciliacion_det;
                               conciliacionDetalle.IdConciliacion = Id;                               
                               conciliacionDetalle.IdEmpresa_cbr = CobrosInfo.IdEmpresa;
                               conciliacionDetalle.IdSucursal_cbr = CobrosInfo.IdSucursal;
                               conciliacionDetalle.IdCobro = CobrosInfo.IdCobro;
                               conciliacionDetalle.secuencia_cbr = item_prueba.secuencial;

                               oDataDetalle.ModificarDB(conciliacionDetalle, ref mensaje);   
                           }
                       }
                   }
                   else
                   {
                       foreach (var item_prueba in Info_cxc_cobro_det)
                       {
                           if (info_cxc_conciliacion_det.IdCobro == item_prueba.IdCobro
                               && info_cxc_conciliacion_det.IdEmpresa_nt == item_prueba.IdEmpresa
                               && info_cxc_conciliacion_det.IdSucursal_nt == item_prueba.IdSucursal
                               //&& info_cxc_conciliacion_det.IdBodega_nt == item_prueba.IdBodega_Cbte
                               && info_cxc_conciliacion_det.IdNota_nt == item_prueba.IdCbte_vta_nota
                               )
                           {
                               conciliacionDetalle = new cxc_conciliacion_det_Info();
                               conciliacionDetalle = info_cxc_conciliacion_det;
                               conciliacionDetalle.IdConciliacion = Id;                               
                               conciliacionDetalle.IdEmpresa_cbr = CobrosInfo.IdEmpresa;
                               conciliacionDetalle.IdSucursal_cbr = CobrosInfo.IdSucursal;
                               conciliacionDetalle.IdCobro = CobrosInfo.IdCobro;
                               conciliacionDetalle.secuencia_cbr = item_prueba.secuencial;
                           }
                       }
                   }
               }                     
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetModificarConciliacion", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
               
           }
       }

       public cxc_cobro_Info Get_Cobro(cxc_conciliacion_Info cab,  ref decimal Id)
       {
           try
           {
              cxc_cobro_Info info = new cxc_cobro_Info();
               info.IdEmpresa = cab.IdEmpresa;
               info.IdSucursal = cab.IdSucursal;
               info.IdCliente = cab.IdCliente;

               info.cr_fecha = cab.Fecha;
               info.cr_fechaDocu = cab.Fecha;
               info.cr_fechaCobro = cab.Fecha;

               info.IdCobro_a_aplicar = null;
               info.cr_Banco = null;
               info.cr_cuenta = null;
               info.cr_NumDocumento = null;
               info.cr_Tarjeta = null;
               info.cr_propietarioCta = null;
               info.cr_estado = "A";
               info.cr_recibo = 0;
               info.IdBanco = null;
               info.MotiAnula = null;
               info.cr_Codigo = "";

               info.nom_pc = param.nom_pc;
               info.ip = param.ip;
               // _Info.Fecha_Transac = DateTime.Now;
               info.Fecha_Transac = Convert.ToDateTime(DateTime.Now);
               info.IdUsuario = param.IdUsuario;

               // campos vista
               info.IdCobro_tipo = cab.cxc_cobro_Info.IdCobro_tipo;
               info.IdTipoNotaCredito = cab.cxc_cobro_Info.IdTipoNotaCredito;
               info.IdCaja = cab.cxc_cobro_Info.IdCaja;
               info.cr_TotalCobro = cab.cxc_cobro_Info.cr_TotalCobro;
               // campos vista      
               info.cr_observacion = "Conciliación #: " + Id + " del cliente " + cab.cxc_cobro_Info.cr_observacion;

               //Detalle conciliacion
               info.ListaCobro = new List<cxc_cobro_Det_Info>();
               decimal IdCobroDet = 0;
               info.ListaCobro = GetDetalleCobro(cab, ref IdCobroDet);

               return info;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Cobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
           }

       }

       public List<cxc_cobro_Det_Info> GetDetalleCobro(cxc_conciliacion_Info cab, ref decimal IdCobro)
       {
           try
           {
               List<cxc_cobro_Det_Info> lstCobroDet = new  List<cxc_cobro_Det_Info>();
               foreach (var item in cab.DetalleCobroFact)
               {

                   cxc_cobro_Det_Info info_det = new cxc_cobro_Det_Info();

                   info_det.IdEmpresa = item.IdEmpresa;
                   IdCobro = Convert.ToDecimal(item.IdCobro);
                   info_det.IdSucursal = item.IdSucursal;
                   info_det.IdCobro = Convert.ToDecimal(item.IdCobro);
                   info_det.secuencial = item.Secuencia;
                   info_det.dc_TipoDocumento = item.TipoDoc_vta;
                   if (item.TipoDoc_vta == "FACT")
                   {
                       info_det.IdBodega_Cbte = Convert.ToInt32(item.IdBodega_fa);
                       info_det.IdCbte_vta_nota = Convert.ToDecimal(item.IdCbteVta_fa);
                   }
                   else 
                   {
                       info_det.IdBodega_Cbte = Convert.ToInt32(item.IdBodega_nt);
                       info_det.IdCbte_vta_nota = Convert.ToInt32(item.IdNota_nt);
                   }
                   info_det.dc_ValorPago = item.Valor_Aplicado;
                   info_det.IdUsuario = param.IdUsuario;
                   info_det.Fecha_Transac = Convert.ToDateTime(DateTime.Now);
                   info_det.nom_pc = param.nom_pc;
                   info_det.ip = param.ip;
                   info_det.IdCentroCosto = item.IdCentroCosto;

                   lstCobroDet.Add(info_det);
               }
               return lstCobroDet;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getDetalleCobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
           }
       
       }
       
       public Boolean Grabar_DetalleCobro_x_Conciliacion(cxc_conciliacion_Info cab, decimal IdCobro)
       {
           try
           {
               cxc_cobro_Det_Bus BusDet_cobro = new cxc_cobro_Det_Bus();
               bool resultCobro = false;
               //cab.DetalleCobroFact

               List<cxc_conciliacion_det_Info> cxc_conciliacion_det = cab.DetalleCobroFact.Where(q => q.IdCobro == Convert.ToDecimal(IdCobro)).ToList();

               foreach (var item in cxc_conciliacion_det)
               {
                   cxc_cobro_Det_Info CobroDetalleInfo = new cxc_cobro_Det_Info();
                   CobroDetalleInfo.IdEmpresa = item.IdEmpresa;
                   CobroDetalleInfo.IdSucursal = item.IdSucursal;
                   IdCobro = Convert.ToDecimal(item.IdCobro);
                   CobroDetalleInfo.IdCobro = Convert.ToDecimal(item.IdCobro);
                   CobroDetalleInfo.secuencial = item.Secuencia;
                   CobroDetalleInfo.dc_TipoDocumento = item.TipoDoc_vta;

                   if (item.TipoDoc_vta == "FACT")
                   {
                       CobroDetalleInfo.IdBodega_Cbte = Convert.ToInt32(item.IdBodega_fa);
                       CobroDetalleInfo.IdCbte_vta_nota = Convert.ToDecimal(item.IdCbteVta_fa);
                   }
                   else
                   {
                       CobroDetalleInfo.IdBodega_Cbte = Convert.ToInt32(item.IdBodega_nt);
                       CobroDetalleInfo.IdCbte_vta_nota = Convert.ToInt32(item.IdNota_nt);
                   }

                   CobroDetalleInfo.dc_ValorPago = item.Valor_Aplicado;
                   CobroDetalleInfo.IdUsuario = param.IdUsuario;
                   CobroDetalleInfo.Fecha_Transac = Convert.ToDateTime(DateTime.Now);
                   CobroDetalleInfo.nom_pc = param.nom_pc;
                   CobroDetalleInfo.ip = param.ip;
                   CobroDetalleInfo.IdCentroCosto = item.IdCentroCosto;

                   //inserto la tabla cxc_cobro_det
                   resultCobro = BusDet_cobro.GuardarDB(CobroDetalleInfo);

                   if (resultCobro)
                   {
                        item.IdEmpresa_cbr = CobroDetalleInfo.IdEmpresa;
                        item.IdSucursal_cbr = CobroDetalleInfo.IdSucursal;
                        item.secuencia_cbr = CobroDetalleInfo.secuencial;
                   }
               }

               return resultCobro;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getDetalleCobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
           }

       }

       public fa_notaCreDeb_x_cxc_cobro_Info Get_faNotaCreDeb_x_Cobro(cxc_cobro_Info info, cxc_conciliacion_Info Item)
        {
            try
            {
                string mensaje = "";
                fa_notaCreDeb_x_cxc_cobro_Info info_NotaCreDeb = new fa_notaCreDeb_x_cxc_cobro_Info();
                cxc_conciliacion_det_Info conciliaInfo = new cxc_conciliacion_det_Info();
                    info_NotaCreDeb.IdEmpresa_cbr= info.IdEmpresa;
                    info_NotaCreDeb.IdSucursal_cbr = info.IdSucursal;
                    info_NotaCreDeb.IdCobro_cbr = info.IdCobro;
                    conciliaInfo = Item.Detalle.First();
                    info_NotaCreDeb.IdEmpresa_nt = Convert.ToInt32(conciliaInfo.IdEmpresa_nt);
                    info_NotaCreDeb.IdSucursal_nt = Convert.ToInt32(conciliaInfo.IdSucursal_nt);;
                    info_NotaCreDeb.IdBodega_nt = Convert.ToInt32(conciliaInfo.IdBodega_nt);
                    info_NotaCreDeb.IdNota_nt = Convert.ToInt32(conciliaInfo.IdNota_nt);

                    info_NotaCreDeb.Valor_cobro = info.cr_TotalCobro;

                    return info_NotaCreDeb;                    
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_faNotaCreDeb_x_Cobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
            }
        
        }

       public List<cxc_conciliacion_Info> Get_List_conciliacion(int IdEmpresa, ref string mensaje)
       {
           try
           {
               return oData.Get_List_conciliacion(IdEmpresa, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_EstadoCobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
           }
       }
       
       public cxc_conciliacion_Info Get_Info_conciliacion(int IdEmpresa, int IdSucursal, int IdConciliacion, ref string mensaje)
       {
           try
           {
               return oData.Get_Info_conciliacion(IdEmpresa, IdSucursal, IdConciliacion, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_EstadoCobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
           }
       }

       public Boolean Anular_Conciliacion(cxc_conciliacion_Info SETINFO_, ref string mensaje)
       {
           try
           {
               Boolean estado = false;

               estado = oData.Anular_Conciliacion(SETINFO_, ref mensaje);

               if(estado == true)
               {
                  Contabilizar_Anulacion_Poli(SETINFO_.IdEmpresa, SETINFO_.IdSucursal, Convert.ToInt32(SETINFO_.IdConciliacion), Convert.ToDateTime(SETINFO_.Fecha_UltAnu));
               }


               return estado;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular_Conciliacion", ex.Message), ex) { EntityType = typeof(cxc_cobro_x_EstadoCobro_Bus) };
           }
       }

       public Boolean Contabilizar_Anulacion_Poli(int IdEmpresa, int IdSucursal, int IdConciliacion, DateTime FechaAnul)
       {
           try
           {
               string mensaje= "";
               cxc_parametro_Bus paramBus = new cxc_parametro_Bus();
               
               cxc_conciliacion_Info Info = new cxc_conciliacion_Info();
               cxc_conciliacion_Data data = new cxc_conciliacion_Data();
               Info = data.Get_Info_conciliacion(IdEmpresa, IdSucursal, IdConciliacion, ref mensaje);
               paramInfo = paramBus.Get_Info_parametro(Info.IdEmpresa);

               Info.Fecha_UltAnu = FechaAnul;

               if (Info.IdCbteCble_cbte_cble != null)
               {
                   GeneraCbteCtblANULACIONSOLODIARIO(Info);
               }

               //cxc_cobro_tipo_Data DataCobrotipo = new cxc_cobro_tipo_Data();
               //List<cxc_cobro_tipo_Info> ListaCobrotipo = new List<cxc_cobro_tipo_Info>();
               //ListaCobrotipo = DataCobrotipo.Get_List_Cobro_Tipo();
               //var s = from q in ListaCobrotipo where q.IdCobro_tipo == Info.IdCobro_tipo select q.tc_Que_Tipo_Registro_Genera;
               //string queGenera = "";
               //foreach (var item in s)
               //{
               //    queGenera = item;
               //}

               //if (queGenera == "DIARIO")
               //{
               //    GeneraCbteCtblANULACIONSOLODIARIO(Info);

               //}
               //if (queGenera == "MOVI_CAJA")
               //{
               //    GeneraCbteCtblANULACIONSOLODIARIO(Info);

               //    GeneraMoviCajaANULACION(Info, InfoAnulado.ct_IdTipoCbte, InfoAnulado.ct_IdCbteCble);
               //}
               //if (queGenera == "NTDB_CLI")
               //{
               //    GeneraCbteCtblANULACIONSOLODIARIO(Info);
               //}

               return true;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Contabilizar_Anulacion", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
           }
       }

       public void GeneraCbteCtblANULACIONSOLODIARIO(cxc_conciliacion_Info Info)
       {
           try
           {
               ct_Cbtecble_Bus bus = new ct_Cbtecble_Bus();

               string msg = "";

               bus.ReversoCbteCble(param.IdEmpresa, Info.IdCbteCble_cbte_cble, Info.IdTipoCbte_cbte_cble,
                                  Convert.ToInt32(paramInfo.pa_IdTipoCbteCble_CxC_ANU), ref idctctb, ref msg, param.IdUsuario);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GeneraCbteCtblANULACIONSOLODIARIO", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
           }
       }
    }
}
