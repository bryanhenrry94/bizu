﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.CuentasxPagar;
using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Application.General;
using Bizu.Domain.Contabilidad;
using Bizu.Application.Contabilidad;
using Bizu.Domain.General;
using Bizu.Domain.CuentasxPagar.xmlLiquidacionCompra;
using System.Xml.Serialization;
using System.IO;

namespace Bizu.Application.CuentasxPagar
{
    public class cp_orden_giro_Bus
    {
        cp_orden_giro_Data data = new cp_orden_giro_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
        cp_reembolso_Bus Reem_B = new cp_reembolso_Bus();
        cp_orden_giro_pagos_sri_Bus pagoSRI_B = new cp_orden_giro_pagos_sri_Bus();
        cp_orden_giro_x_com_ordencompra_local_Bus OC_B = new cp_orden_giro_x_com_ordencompra_local_Bus();
        cp_parametros_Bus busParam = new cp_parametros_Bus();
        cp_retencion_Bus Bus_Retencion = new cp_retencion_Bus();
        cp_cuotas_x_doc_Bus bus_cuotas_x_doc = new cp_cuotas_x_doc_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_liquidacion_compra_Bus Bus_LiquidacionCompra = new cp_liquidacion_compra_Bus();

        string mensaje = "";

        public Boolean Modificar_tipo_flujo(int IdEmpresa, int IdTipoCbte_OG, decimal IdCbteCble, Nullable<decimal> IdTipoFlujo)
        {
            try
            {
                return data.Modificar_tipo_flujo(IdEmpresa, IdTipoCbte_OG, IdCbteCble, IdTipoFlujo);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Modificar_tipo_flujo", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        private Boolean Validar_y_corregir_objeto(cp_orden_giro_Info orden_giro_Info, ref string msg)
        {
            try
            {
                #region 'Validaciones'
                /*--- validaciones */


                if (orden_giro_Info.IdEmpresa <= 0 && orden_giro_Info.IdSucursal <= 0)
                {
                    msg = "Error en la cabecera de fact uno de los PK es <=0";
                    return false;
                }


                if (orden_giro_Info.IdProveedor <= 0)
                {
                    msg = "Erro en la cabecera  IdProveedor es <=0";
                    return false;
                }




                if (orden_giro_Info.Info_CbteCble_x_OG._cbteCble_det_lista_info == null)
                {
                    msg = "la factura no tiene detalle ";
                    return false;
                }

                if (orden_giro_Info.Info_CbteCble_x_OG._cbteCble_det_lista_info.Count == 0)
                {
                    msg = "la factura no tiene detalle ";
                    return false;
                }


                foreach (var item in orden_giro_Info.Info_CbteCble_x_OG._cbteCble_det_lista_info)
                {

                    if (item.IdCtaCble == "")
                    {
                        msg = "el IdCtaCble id:" + item.IdCtaCble + " no puede ser blanco ";
                    }

                    if (item.dc_Valor == 0)
                    {
                        msg = "el dc_Valor no puede ser cero";
                    }
                }

                /*--- Fin validaciones */


                /*--- corrigiendo data */

                if (orden_giro_Info.IdCtaCble_CXP == "" || orden_giro_Info.IdCtaCble_CXP == null || orden_giro_Info.IdCtaCble_Gasto == "" || orden_giro_Info.IdCtaCble_Gasto == null)
                {
                    cp_proveedor_Bus BusProv = new cp_proveedor_Bus();
                    cp_proveedor_Info InfoProve = new cp_proveedor_Info();
                    InfoProve = BusProv.Get_Info_Proveedor(orden_giro_Info.IdEmpresa, orden_giro_Info.IdProveedor);
                    orden_giro_Info.IdCtaCble_CXP = InfoProve.IdCtaCble_CXP;
                    orden_giro_Info.IdCtaCble_Gasto = InfoProve.IdCtaCble_Gasto;
                }


                if (orden_giro_Info.IdCod_101 == 0)
                {
                    cp_codigo_SRI_Bus busCodSri = new cp_codigo_SRI_Bus();
                    orden_giro_Info.IdCod_101 = busCodSri.Get_List_codigo_SRI("COD_101").FirstOrDefault().IdCodigo_SRI;
                }

                if (orden_giro_Info.IdCod_ICE == 0)
                {
                    cp_codigo_SRI_Bus busCodSri = new cp_codigo_SRI_Bus();
                    orden_giro_Info.IdCod_ICE = busCodSri.Get_List_codigo_SRI("COD_ICE").FirstOrDefault().IdCodigo_SRI;
                }

                if (orden_giro_Info.IdIden_credito == 0)
                {
                    cp_codigo_SRI_Bus busCodSri = new cp_codigo_SRI_Bus();
                    orden_giro_Info.IdIden_credito = busCodSri.Get_List_codigo_SRI("COD_IDCREDITO").FirstOrDefault().IdCodigo_SRI;
                }

                if (orden_giro_Info.PaisPago == "")
                {
                    orden_giro_Info.PaisPago = null;
                }


                /*--- corrigiendo data */

                #endregion

                return true;

            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Validar_y_corregir_objeto", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public List<cp_orden_giro_Info> Get_List_orden_giro(int IdEmpresa, decimal OrdenGiro)
        {
            try
            {
                return data.Get_List_orden_giro(IdEmpresa, OrdenGiro);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_orden_giro", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };

            }

        }

        public Boolean Generar_OrdenPago_x_Faxtura(cp_orden_giro_Info info_og, DateTime Fecha_OP, ref string mensaje)
        {
            try
            {
                return data.Generar_OrdenPago_x_Faxtura(info_og, Fecha_OP, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Generar_OrdenPago_x_Faxtura", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };

            }

        }

        public cp_orden_giro_Info Get_Info_orden_giro(int IdEmpresa, int IdTipoCbte_Ogiro, decimal IdCbteCble_Ogiro)
        {
            try
            {
                return data.Get_Info_orden_giro(IdEmpresa, IdTipoCbte_Ogiro, IdCbteCble_Ogiro);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_orden_giro", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public cp_orden_giro_Info Get_Info_orden_giro(cp_orden_giro_Info info)
        {
            try
            {
                return data.Get_Info_orden_giro(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_orden_giro", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public List<cp_orden_giro_Info> Get_List_orden_giro(int IdEmpresa, DateTime F_inicio, DateTime F_fin)
        {
            try
            {
                return data.Get_List_orden_giro(IdEmpresa, F_inicio, F_fin);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_orden_giro", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public List<cp_orden_giro_Info> Get_List_orden_giro_SinIngresos(int IdEmpresa, DateTime F_inicio, DateTime F_fin)
        {
            try
            {
                return data.Get_List_orden_giro_SinIngresos(IdEmpresa, F_inicio, F_fin);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_orden_giro", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }

        }

        public cp_orden_giro_Info Get_Info_orden_giro_Saldo(int IdEmpresa, int IdTipoCbte_Ogiro, decimal IdCbteCble_Ogiro)
        {
            try
            {
                return data.Get_Info_orden_giro_Saldo(IdEmpresa, IdTipoCbte_Ogiro, IdCbteCble_Ogiro);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_orden_giro", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }

        }

        public List<cp_orden_giro_Info> Get_List_orden_giro_x_Pagar(int IdEmpresa, bool Mostrar_fact_conci_caja, ref string mensaje)
        {

            try
            {
                return data.Get_List_orden_giro_x_Pagar(IdEmpresa, Mostrar_fact_conci_caja, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_rpt_nota_credito", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }




        }

        public Boolean GrabarDB(cp_orden_giro_Info Info_OrdenGiro, ref decimal idCbteCble, ref string mensaje)
        {
            Boolean res = false;

            try
            {
                if (Validar_y_corregir_objeto(Info_OrdenGiro, ref mensaje))
                {
                    if (data.ExisteFacturaPorProveedor(Info_OrdenGiro.IdEmpresa, Info_OrdenGiro.IdProveedor, Info_OrdenGiro.IdOrden_giro_Tipo, Info_OrdenGiro.co_serie, Info_OrdenGiro.co_factura))
                    {
                        mensaje = "La Factura#: " + Info_OrdenGiro.co_serie + "-" + Info_OrdenGiro.co_factura + ". Ya se encuentra ingresada";
                        res = false;
                        return false;
                    }

                    if (!CbteCble_B.GrabarDB(Info_OrdenGiro.Info_CbteCble_x_OG, ref idCbteCble, ref mensaje))
                    {
                        mensaje = "No se pudo Ingresar el Cbte Cble de la Factura Proveedor \n Comuníquese con sistema por favor" + mensaje; return false;
                    }
                    else
                    {
                        Info_OrdenGiro.IdCbteCble_Ogiro = idCbteCble;
                        if (!data.GrabarDB(Info_OrdenGiro, ref mensaje))
                        {
                            mensaje = "No se pudo Ingresar la Factura Proveedor \n Comuníquese con sistema por favor" + mensaje; return false;
                        }

                        if (Info_OrdenGiro.lst_reembolso != null)
                        {
                            if (Info_OrdenGiro.lst_reembolso.Count != 0)
                            {
                                if (!Reem_B.GuardarDBLst(Info_OrdenGiro.lst_reembolso, Info_OrdenGiro.IdEmpresa, Info_OrdenGiro.IdTipoCbte_Ogiro, Info_OrdenGiro.IdCbteCble_Ogiro, ref mensaje))
                                {

                                    mensaje = "No se pudo Ingresar lo(s) reembolso(s) \n Comuníquese con sistema por favor" + mensaje; return false;
                                }
                            }
                        }

                        if (Info_OrdenGiro.lst_formasPagoSRI != null)
                        {
                            if (Info_OrdenGiro.lst_formasPagoSRI.Count != 0)
                            {
                                if (!pagoSRI_B.GuardarDB(Info_OrdenGiro.lst_formasPagoSRI, Info_OrdenGiro.IdEmpresa, Info_OrdenGiro.IdTipoCbte_Ogiro, Info_OrdenGiro.IdCbteCble_Ogiro, ref mensaje))
                                {
                                    mensaje = "No se pudo Ingresar la(s) Forma(s) de Pago \n Comuníquese con sistema por favor" + mensaje; return false;
                                }
                            }
                        }

                        if (Info_OrdenGiro.Info_cuotas_x_doc.lst_cuotas_det.Count != 0)
                        {
                            Info_OrdenGiro.Info_cuotas_x_doc.IdEmpresa_ct = Info_OrdenGiro.IdEmpresa;
                            Info_OrdenGiro.Info_cuotas_x_doc.IdTipoCbte = Info_OrdenGiro.IdTipoCbte_Ogiro;
                            Info_OrdenGiro.Info_cuotas_x_doc.IdCbteCble = Info_OrdenGiro.IdCbteCble_Ogiro;
                            bus_cuotas_x_doc.GuardarDB(Info_OrdenGiro.Info_cuotas_x_doc);
                        }

                        if (Info_OrdenGiro.Info_Retencion != null && Info_OrdenGiro.Info_Retencion.Info_CbteCble_x_RT != null)
                        {
                            if (Info_OrdenGiro.Info_Retencion.IdEmpresa != 0)
                            {
                                Info_OrdenGiro.Info_Retencion.IdCbteCble_Ogiro = Info_OrdenGiro.IdCbteCble_Ogiro = idCbteCble;

                                //grabando la retencion
                                if (Bus_Retencion.Graba_CbteCble_Ret_FactProveedor(Info_OrdenGiro.Info_Retencion, Info_OrdenGiro.Info_Retencion.Info_CbteCble_x_RT, ref mensaje))
                                {
                                    switch (param.IdCliente_Ven_x_Default)
                                    {
                                        case Cl_Enumeradores.eCliente_Vzen.EDEHSA:
                                            if (Info_OrdenGiro.Info_Retencion.NumRetencion != "")
                                            {
                                                Bus_Retencion.Modificar_Num_Retencion(Info_OrdenGiro.Info_Retencion, ref mensaje);
                                            }

                                            break;
                                        default:
                                            Bus_Retencion.Modificar_Num_Retencion(Info_OrdenGiro.Info_Retencion, ref mensaje);

                                            break;
                                    }
                                }
                                else
                                {
                                    mensaje = "Hubo un inconveniente al ingresar la retención comuniquese con sistemas.." + mensaje; res = false;
                                }
                            }
                        }

                        decimal IdCbteCble = 0; IdCbteCble = idCbteCble;                                           
                    }
                }
                else
                {
                    res = false;
                    return false;
                }


                res = true;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarFactProveedor", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
            return res;

        }

        public Boolean GrabarDB_Retencion(cp_orden_giro_Info Info_OrdenGiro, decimal idCbteCble, ref string mensaje) //Sunchodesa
        {
            Boolean res = false;
            try
            {

                if (Info_OrdenGiro.lst_formasPagoSRI != null)
                {
                    if (Info_OrdenGiro.lst_formasPagoSRI.Count != 0)
                    {
                        if (!pagoSRI_B.GuardarDB(Info_OrdenGiro.lst_formasPagoSRI, Info_OrdenGiro.IdEmpresa, Info_OrdenGiro.IdTipoCbte_Ogiro, Info_OrdenGiro.IdCbteCble_Ogiro, ref mensaje))
                        {
                            mensaje = "No se pudo Ingresar la(s) Forma(s) de Pago \n Comuníquese con sistema por favor" + mensaje; return false;
                        }
                    }

                }


                if (Info_OrdenGiro.Info_Retencion != null && Info_OrdenGiro.Info_Retencion.Info_CbteCble_x_RT != null)
                {

                    if (Info_OrdenGiro.Info_Retencion.IdEmpresa != 0)
                    {
                        Info_OrdenGiro.Info_Retencion.IdCbteCble_Ogiro = Info_OrdenGiro.IdCbteCble_Ogiro = idCbteCble;


                        //grabando la retencion

                        if (Bus_Retencion.Graba_CbteCble_Ret_FactProveedor(Info_OrdenGiro.Info_Retencion, Info_OrdenGiro.Info_Retencion.Info_CbteCble_x_RT, ref mensaje))
                        {
                            //actualizando el suencial de la retencion serie y #retencion
                            Bus_Retencion.Modificar_Num_Retencion(Info_OrdenGiro.Info_Retencion, ref mensaje);

                        }
                        else
                        {
                            mensaje = "Hubo un inconveniente al ingresar la retención comuniquese con sistemas.." + mensaje; res = false;
                        }

                    }
                }
                decimal IdCbteCble = 0; IdCbteCble = idCbteCble;
                res = true;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GrabarFactProveedor", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
            return res;

        }

        public Boolean AnularFacturaProveedor(cp_orden_giro_Info ordenGiro_I,
            List<cp_orden_giro_x_com_ordencompra_local_Info> LstImportacionOC, ref decimal IdCbteCbleRev, ref string msg2)
        {
            Boolean res = true;
            try
            {
                if (CbteCble_B.ReversoCbteCble(ordenGiro_I.IdEmpresa, ordenGiro_I.IdCbteCble_Ogiro, ordenGiro_I.IdTipoCbte_Ogiro,
                    Convert.ToInt32(ordenGiro_I.IdTipoCbte_Anulacion), ref IdCbteCbleRev, ref msg2, ordenGiro_I.IdUsuarioUltAnu))
                {
                    ordenGiro_I.IdCbteCble_Anulacion = IdCbteCbleRev;
                    if (data.EliminarDB(ordenGiro_I, ref msg2))
                    {

                        #region Anula Retención
                        decimal idrev = 0;
                        cp_retencion_Info Info_retencion = Bus_Retencion.Get_Info_retencion(ordenGiro_I.IdEmpresa, ordenGiro_I.IdCbteCble_Ogiro, ordenGiro_I.IdTipoCbte_Ogiro);

                        //cp_retencion_x_ct_cbtecble_Info ret_x_dia = ret_B.ObtenerObjetoRetXCbteCble(ordenGiro_I.IdEmpresa, ordenGiro_I.IdCbteCble_Ogiro,
                        //    ordenGiro_I.IdTipoCbte_Ogiro);

                        if (Info_retencion.IdRetencion != 0)
                        {
                            if (!Bus_Retencion.AnularDB(Info_retencion, ref idrev, ref msg2))
                                return false;
                        }
                        #endregion

                        #region Eliminar Aprobación de ing a bodega x OC

                        cp_Aprobacion_Ing_Bod_x_OC_Bus bus_aprob_ing_bod_x_OC = new cp_Aprobacion_Ing_Bod_x_OC_Bus();
                        cp_Aprobacion_Ing_Bod_x_OC_Info info_aprob_ing_bod_x_OC = new cp_Aprobacion_Ing_Bod_x_OC_Info();

                        info_aprob_ing_bod_x_OC = bus_aprob_ing_bod_x_OC.Get_Info_Aprobacion_Ing_Bod_x_OC(ordenGiro_I.IdEmpresa, ordenGiro_I.IdTipoCbte_Ogiro, ordenGiro_I.IdCbteCble_Ogiro);
                        if (info_aprob_ing_bod_x_OC.IdAprobacion != 0)
                        {
                            bus_aprob_ing_bod_x_OC.EliminarDB(info_aprob_ing_bod_x_OC.IdEmpresa, info_aprob_ing_bod_x_OC.IdAprobacion, ordenGiro_I.IdUsuarioUltAnu, ordenGiro_I.MotivoAnu, ref mensaje);
                        }

                        #endregion

                        OC_B.EliminarLista(LstImportacionOC);
                    }
                    else return false;

                }
                else return false;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "AnularFacturaProveedor", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
            return res;

        }

        public Boolean AnularFacturaProveedor_Edehsa(cp_orden_giro_Info ordenGiro_I,
           List<cp_orden_giro_x_com_ordencompra_local_Info> LstImportacionOC, ref decimal IdCbteCbleRev, ref string msg2)
        {
            Boolean res = true;
            try
            {
                if (CbteCble_B.ReversoCbteCble_Edehsa(ordenGiro_I.IdEmpresa, ordenGiro_I.IdCbteCble_Ogiro, ordenGiro_I.IdTipoCbte_Ogiro,
                    Convert.ToInt32(ordenGiro_I.IdTipoCbte_Anulacion), Convert.ToDateTime(ordenGiro_I.Fecha_UltAnu), ref IdCbteCbleRev, ref msg2, ordenGiro_I.IdUsuarioUltAnu))
                {
                    ordenGiro_I.IdCbteCble_Anulacion = IdCbteCbleRev;
                    if (data.EliminarDB(ordenGiro_I, ref msg2))
                    {

                        #region Anula Retención
                        decimal idrev = 0;
                        cp_retencion_Info Info_retencion = Bus_Retencion.Get_Info_retencion(ordenGiro_I.IdEmpresa, ordenGiro_I.IdCbteCble_Ogiro, ordenGiro_I.IdTipoCbte_Ogiro);

                        //cp_retencion_x_ct_cbtecble_Info ret_x_dia = ret_B.ObtenerObjetoRetXCbteCble(ordenGiro_I.IdEmpresa, ordenGiro_I.IdCbteCble_Ogiro,
                        //    ordenGiro_I.IdTipoCbte_Ogiro);

                        if (Info_retencion.IdRetencion != 0)
                        {
                            Info_retencion.Fecha_UltAnu = ordenGiro_I.Fecha_UltAnu;

                            if (!Bus_Retencion.AnularDB(Info_retencion, ref idrev, ref msg2))
                                return false;
                        }
                        #endregion

                        #region Eliminar Aprobación de ing a bodega x OC

                        cp_Aprobacion_Ing_Bod_x_OC_Bus bus_aprob_ing_bod_x_OC = new cp_Aprobacion_Ing_Bod_x_OC_Bus();
                        cp_Aprobacion_Ing_Bod_x_OC_Info info_aprob_ing_bod_x_OC = new cp_Aprobacion_Ing_Bod_x_OC_Info();

                        info_aprob_ing_bod_x_OC = bus_aprob_ing_bod_x_OC.Get_Info_Aprobacion_Ing_Bod_x_OC(ordenGiro_I.IdEmpresa, ordenGiro_I.IdTipoCbte_Ogiro, ordenGiro_I.IdCbteCble_Ogiro);
                        if (info_aprob_ing_bod_x_OC.IdAprobacion != 0)
                        {
                            bus_aprob_ing_bod_x_OC.EliminarDB(info_aprob_ing_bod_x_OC.IdEmpresa, info_aprob_ing_bod_x_OC.IdAprobacion, ordenGiro_I.IdUsuarioUltAnu, ordenGiro_I.MotivoAnu, ref mensaje);
                        }

                        #endregion
                        
                        OC_B.EliminarLista(LstImportacionOC);
                    }
                    else return false;

                }
                else return false;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "AnularFacturaProveedor", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
            return res;

        }

        public Boolean Modificar_ValorRetencion(int IdEmpresa, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro, double valorRetencion, ref string mensaje)
        {
            try
            {

                return data.Modificar_ValorRetencion(IdEmpresa, IdCbteCble_Ogiro, IdTipoCbte_Ogiro, valorRetencion, ref mensaje);
            }

            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Modificar_ValorRetencion", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public Boolean VericarNumDocumento(int IdEmpresa, decimal IdProveedor, string tipoDocumento, string Serie, string NumDocumento, ref string mensaje)
        {
            try
            {

                return data.VericarNumDocumento(IdEmpresa, IdProveedor, tipoDocumento, Serie, NumDocumento, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "VericarNumDocumento", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };

            }

        }

        public List<cp_orden_giro_Info> Get_List_orden_giro(int IdEmpresa, int anio, int mes)
        {
            try
            {
                return data.Get_List_orden_giro(IdEmpresa, anio, mes);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_orden_giro", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public List<cp_orden_giro_Info> Get_List_orden_giro_NumComprobante(int IdEmpresa)
        {
            try
            {
                return data.Get_List_orden_giro_NumComprobante(IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_orden_giro", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public List<cp_orden_giro_Info> Get_List_orden_giro_SRI(int IdEmpresa, int anio, int mes)
        {
            try
            {
                return data.Get_List_orden_giro_SRI(IdEmpresa, anio, mes);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_orden_giro", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public List<cp_orden_giro_Info> Get_List_orden_giro_SRI_Factura_X_Proveedor(int IdEmpresa, string CedRuc)
        {
            try
            {
                return data.Get_List_orden_giro_SRI_Factura_X_Proveedor(IdEmpresa, CedRuc);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_orden_giro", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        //public List<cp_orden_giro_Info> Get_List_orden_giro_SRI_Polig(int IdEmpresa, int anio, int mes)
        //{
        //    try
        //    {
        //        return data.Get_List_orden_giro_SRI_Polig(IdEmpresa, anio, mes);
        //    }
        //    catch (Exception ex)
        //    {
        //        Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
        //        throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_orden_giro", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
        //    }
        //}

        public decimal GetNDocumentoXTipo(String CodTipoDocumento, int IdEmpresa)
        {
            try
            {
                return data.GetNDocumentoXTipo(CodTipoDocumento, IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GetNDocumentoXTipo", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };

            }

        }        

        public Boolean ExisteFacturaPorProveedor(int IdEmpresa, decimal IdProveedor, String co_Factura)
        {
            try
            {
                return data.ExisteFacturaPorProveedor(IdEmpresa, IdProveedor, co_Factura);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ExisteFacturaPorProveedor", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public Boolean ExisteFacturaPorProveedor(int IdEmpresa, decimal IdProveedor, String co_serie, String co_Factura)
        {
            try
            {
                return data.ExisteFacturaPorProveedor(IdEmpresa, IdProveedor, co_serie, co_Factura);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ExisteFacturaPorProveedor", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public Boolean ExisteFacturaPorProveedor(int IdEmpresa, decimal IdProveedor, string TipoDoc, String co_serie, String co_Factura)
        {
            try
            {
                return data.ExisteFacturaPorProveedor(IdEmpresa, IdProveedor, TipoDoc, co_serie, co_Factura);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ExisteFacturaPorProveedor", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public Boolean ExisteFacturaPorProveedor(int IdEmpresa, string cedulaRuc, String co_serie, String co_Factura)
        {
            try
            {
                return data.ExisteFacturaPorProveedor(IdEmpresa, cedulaRuc, co_serie, co_Factura);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ExisteFacturaPorProveedor", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public Boolean ModificarDB_proceso_cerrado(cp_orden_giro_Info info, ref string mensaje)
        {
            try
            {
                if (data.ModificarDB_proceso_cerrado(info, ref mensaje))
                {
                    if (info.lst_formasPagoSRI != null)
                    {
                        if (info.lst_formasPagoSRI.Count != 0)
                        {
                            if (!pagoSRI_B.GuardarDB(info.lst_formasPagoSRI, info.IdEmpresa, info.IdTipoCbte_Ogiro, info.IdCbteCble_Ogiro, ref mensaje))
                            {
                                mensaje = "No se pudo Ingresar la(s) Forma(s) de Pago \n Comuníquese con sistema por favor" + mensaje; return false;
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ExisteFacturaPorProveedor", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public bool ModificarDB(cp_orden_giro_Info InfoOrdenGiro_I, ref string msg)
        {
            Boolean res = true;

            try
            {

                cp_orden_giro_Info info = new cp_orden_giro_Info();
                info.IdEmpresa = InfoOrdenGiro_I.IdEmpresa;
                info.IdTipoCbte_Ogiro = InfoOrdenGiro_I.IdTipoCbte_Ogiro;
                info.IdCbteCble_Ogiro = InfoOrdenGiro_I.IdCbteCble_Ogiro;

                cp_orden_giro_Data odata = new cp_orden_giro_Data();

                info = odata.Get_Info_orden_giro(info);

                if (info.co_serie == InfoOrdenGiro_I.co_serie && info.co_factura == InfoOrdenGiro_I.co_factura)
                {
                    // no valido               
                }
                else
                {
                    //valido
                    if (data.ExisteFacturaPorProveedor(InfoOrdenGiro_I.IdEmpresa, InfoOrdenGiro_I.IdProveedor, InfoOrdenGiro_I.co_serie, InfoOrdenGiro_I.co_factura))
                    {
                        msg = "La Factura#: " + InfoOrdenGiro_I.co_serie + "-" + InfoOrdenGiro_I.co_factura + ". Ya se encuentra ingresada";
                        res = false;
                        return false;
                    }
                }

                //diario contable x OG
                if (CbteCble_B.ModificarDB(InfoOrdenGiro_I.Info_CbteCble_x_OG, ref msg))
                {
                    //OG
                    cp_orden_giro_Data OdataOG = new cp_orden_giro_Data();
                    if (OdataOG.ModificarDB(InfoOrdenGiro_I, ref msg))
                    {
                        #region reembolso formaspago y retenciones
                        InfoOrdenGiro_I.lst_reembolso.ForEach(p => { p.IdCbteCble_Ogiro = InfoOrdenGiro_I.IdCbteCble_Ogiro; p.IdTipoCbte_Ogiro = InfoOrdenGiro_I.IdTipoCbte_Ogiro; });

                        if (!Reem_B.ModificarLst(InfoOrdenGiro_I.lst_reembolso, InfoOrdenGiro_I.IdEmpresa, InfoOrdenGiro_I.IdCbteCble_Ogiro, InfoOrdenGiro_I.IdTipoCbte_Ogiro))
                        {
                            msg = "No se pudo Modificar lo(s) reembolso(s) \n Comuníquese con sistemas por favor";

                            res = false;
                        }
                        InfoOrdenGiro_I.lst_formasPagoSRI.ForEach(p => { p.IdCbteCble_Ogiro = InfoOrdenGiro_I.IdCbteCble_Ogiro; p.IdTipoCbte_Ogiro = InfoOrdenGiro_I.IdTipoCbte_Ogiro; });
                        if (!pagoSRI_B.ModificarDB(InfoOrdenGiro_I.lst_formasPagoSRI, InfoOrdenGiro_I.IdEmpresa, InfoOrdenGiro_I.IdCbteCble_Ogiro, InfoOrdenGiro_I.IdTipoCbte_Ogiro, ref msg))
                        {
                            msg = "No se pudo Modificar la(s) forma(s) de pago \n Comuníquese con sistemas por favor";
                            res = false;
                        }



                        if (InfoOrdenGiro_I.Info_Retencion != null && InfoOrdenGiro_I.Info_Retencion.Info_CbteCble_x_RT != null)
                        {

                            if (InfoOrdenGiro_I.Info_Retencion.IdEmpresa != 0)
                            {

                                //  Verificar Retencion
                                cp_retencion_Bus bus_Reten = new cp_retencion_Bus();
                                if (bus_Reten.Existe_Retencion(InfoOrdenGiro_I.Info_Retencion.IdEmpresa, InfoOrdenGiro_I.Info_Retencion.IdRetencion))
                                {
                                    if (InfoOrdenGiro_I.Info_Retencion.serie1 == "" && InfoOrdenGiro_I.Info_Retencion.serie2 == "")
                                    {
                                        //Modifica
                                        if (!Bus_Retencion.ModificarDB(InfoOrdenGiro_I.Info_Retencion, InfoOrdenGiro_I.Info_Retencion.Info_CbteCble_x_RT, ref msg))
                                        {
                                            msg = "No se pudo Actualizar las retenciones"; res = false;
                                        }
                                    }
                                    else
                                    {
                                        if (!Bus_Retencion.ModificarDB(InfoOrdenGiro_I.Info_Retencion, InfoOrdenGiro_I.Info_Retencion.Info_CbteCble_x_RT, ref msg))
                                        {
                                            msg = "No se pudo Actualizar las retenciones"; res = false;
                                        }
                                    }
                                }
                                else
                                {

                                    InfoOrdenGiro_I.Info_Retencion.IdCbteCble_Ogiro = InfoOrdenGiro_I.IdCbteCble_Ogiro;



                                    if (Bus_Retencion.Graba_CbteCble_Ret_FactProveedor(InfoOrdenGiro_I.Info_Retencion, InfoOrdenGiro_I.Info_Retencion.Info_CbteCble_x_RT, ref mensaje))
                                    {
                                        //actualizando el suencial de la retencion serie y #retencion
                                        switch (param.IdCliente_Ven_x_Default)
                                        {
                                            case Cl_Enumeradores.eCliente_Vzen.EDEHSA:
                                                if (InfoOrdenGiro_I.Info_Retencion.NumRetencion != "")
                                                {
                                                    Bus_Retencion.Modificar_Num_Retencion(InfoOrdenGiro_I.Info_Retencion, ref mensaje);
                                                }

                                                break;
                                            default:
                                                Bus_Retencion.Modificar_Num_Retencion(InfoOrdenGiro_I.Info_Retencion, ref mensaje);

                                                break;
                                        }
                                    }
                                    else
                                    {
                                        mensaje = "Hubo un inconveniente al ingresar la retención comuniquese con sistemas.." + mensaje; res = false;
                                    }


                                }
                            }
                        }


                        #endregion

                        if (InfoOrdenGiro_I.Info_cuotas_x_doc.lst_cuotas_det.Count != 0)
                        {
                            InfoOrdenGiro_I.Info_cuotas_x_doc.IdEmpresa_ct = InfoOrdenGiro_I.IdEmpresa;
                            InfoOrdenGiro_I.Info_cuotas_x_doc.IdTipoCbte = InfoOrdenGiro_I.IdTipoCbte_Ogiro;
                            InfoOrdenGiro_I.Info_cuotas_x_doc.IdCbteCble = InfoOrdenGiro_I.IdCbteCble_Ogiro;
                            bus_cuotas_x_doc.GuardarDB(InfoOrdenGiro_I.Info_cuotas_x_doc);
                        }                                               

                        msg = "La Fact. Proveedor # " + InfoOrdenGiro_I.IdCbteCble_Ogiro + " se modificó Exitósamente";
                    }
                }
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarFacturaProveedor", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
            return res;
        }

        public Boolean ModificarDB_PDF(cp_orden_giro_Info info, ref string mensaje)
        {
            try
            {
                return data.ModificarDB_PDF(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ExisteFacturaPorProveedor", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public Boolean ModificarDB_NumDocumento(cp_orden_giro_Info info, ref string mensaje)
        {
            try
            {
                return data.ModificarDB_NumDocumento(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ExisteFacturaPorProveedor", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public Boolean GenerarXml_LiquidacionCompra(int IdEmpresa, int IdSucursal, int IdTipoCbte_Ogiro, decimal IdCbteCble_Ogiro, string RutaDescarga, ref string msg)
        {
            try
            {
                string sIdCbteFact = "";

                List<vwcp_liquidacionCompra_sri_Info> lista_LiquidacionCompra_sri = new List<vwcp_liquidacionCompra_sri_Info>();
                vwcp_liquidacionCompra_sri_Bus Bus_LiquidacionCompra_SRI = new vwcp_liquidacionCompra_sri_Bus();
                cp_liquidacion_compra_Bus Bus_LiquidacionCompra = new cp_liquidacion_compra_Bus();

                cp_liquidacion_compra_Info Info_LiquidacionCompra = Bus_LiquidacionCompra.Get_Info(IdEmpresa, IdTipoCbte_Ogiro, IdCbteCble_Ogiro);

                if (Info_LiquidacionCompra == null)
                {
                    return false;
                }

                lista_LiquidacionCompra_sri = Bus_LiquidacionCompra_SRI.Get_list_LiquidacionCompra_Sri(Info_LiquidacionCompra.IdEmpresa, Info_LiquidacionCompra.IdLiquidacionCompra, ref msg);

                if (lista_LiquidacionCompra_sri.Count != 0)
                {
                    //validar objeto
                    if (!ValidarObjeto_XML_LiquidacionCompra(lista_LiquidacionCompra_sri, ref  msg))
                        return false;

                    List<liquidacionCompra> lista = new List<liquidacionCompra>();
                    lista = Bus_LiquidacionCompra.Get_List_Xml_LiquidacionCompra(Info_LiquidacionCompra.IdEmpresa, Info_LiquidacionCompra.IdLiquidacionCompra, ref msg);

                    if (lista.Count != 0)
                    {
                        foreach (var item in lista)
                        {
                            sIdCbteFact = item.infoTributaria.razonSocial.Substring(0, 3) + "-" + Cl_Enumeradores.eTipoCodComprobante.LIQCOM + "-" + item.infoTributaria.estab + "-" + item.infoTributaria.ptoEmi + "-" + item.infoTributaria.secuencial;
                            XmlSerializerNamespaces NamespaceObject = new XmlSerializerNamespaces();
                            NamespaceObject.Add("", "");
                            XmlSerializer mySerializer = new XmlSerializer(typeof(liquidacionCompra));
                            StreamWriter myWriter = new StreamWriter(RutaDescarga + sIdCbteFact + ".xml");
                            mySerializer.Serialize(myWriter, item, NamespaceObject);
                            myWriter.Close();
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "GenerarXml_LiquidacionCompra", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public Boolean ValidarObjeto_XML_LiquidacionCompra(List<vwcp_liquidacionCompra_sri_Info> lista, ref string MensajeError)
        {
            try
            {
                Boolean res = true;

                foreach (var item in lista)
                {
                    //Empresa
                    if (String.IsNullOrEmpty(item.RazonSocial))
                    {
                        MensajeError = "Falta Razón Social Empresa. Por Favor verifique";
                        res = false;
                    }
                    if (String.IsNullOrEmpty(item.NombreComercial))
                    {
                        MensajeError = "Falta Nombre Comercial Empresa. Por Favor verifique";
                        res = false;
                    }

                    if (String.IsNullOrEmpty(item.em_direccion))
                    {
                        MensajeError = "Falta Dirección Matriz Empresa. Por Favor verifique";
                        res = false;
                    }

                    if (String.IsNullOrEmpty(item.em_ruc))
                    {
                        MensajeError = "Falta Tipo de Identificación Empresa. Por Favor verifique";
                        res = false;
                    }

                    //if (String.IsNullOrEmpty(item.ContribuyenteEspecial))
                    //{
                    //    MensajeError = "Falta Número de Contribuyente Especial Empresa. Por Favor verifique";
                    //    res = false;
                    //}

                    //Factura                    

                    if (String.IsNullOrEmpty(item.co_serie))
                    {
                        MensajeError = "Falta serie del Documento. Por Favor verifique";
                        res = false;
                    }

                    if (String.IsNullOrEmpty(item.numDocumento))
                    {
                        MensajeError = "Falta Secuencial del Documento. Por Favor verifique";
                        res = false;
                    }

                    //Cliente
                    if (String.IsNullOrEmpty(item.Su_Direccion))
                    {
                        MensajeError = "Falta Dirección Establecimiento. Por Favor verifique";
                        res = false;
                    }

                    if (String.IsNullOrEmpty(item.RazonSocial))
                    {
                        MensajeError = "Falta Razón Social Comprador. Por Favor verifique";
                        res = false;
                    }

                    if (String.IsNullOrEmpty(item.pe_cedulaRuc))
                    {
                        MensajeError = "Falta Identificación del Comprador. Por Favor verifique";
                        res = false;
                    }
                }

                return res;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ValidarObjeto_XML_LiquidacionCompra", ex.Message), ex) { EntityType = typeof(cp_orden_giro_Bus) };
            }
        }

        public bool Verifica_EstaAplicadaRetencion(int IdEmpresa, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
        {            
            try
            {
                return this.data.Verifica_EstaAplicadaRetencion(IdEmpresa, IdCbteCble_Ogiro, IdTipoCbte_Ogiro);
            }
            catch (Exception exception)
            {
                throw exception;
            }            
        }

        public cp_orden_giro_Info Get_OrdenGiro_Por_SerieComprobante(int IdEmpresa, decimal IdProveedor, string SerieComprobante)
        {
            try
            {
                return this.data.Get_OrdenGiro_Por_SerieComprobante(IdEmpresa, IdProveedor, SerieComprobante);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}