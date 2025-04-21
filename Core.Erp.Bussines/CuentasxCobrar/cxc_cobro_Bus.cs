using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Data;
using Core.Erp.Info.Caja;
using Core.Erp.Business.Caja;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Bancos;

namespace Core.Erp.Business.CuentasxCobrar
{
    public class cxc_cobro_Bus
    {
        #region Declaracion

        string MensajeError = "";
        decimal idctctb = 0;
        decimal IdCobro_x_Cobro_Tarjeta = 0;

        cxc_cobro_x_EstadoCobro_Data CobroEstado_D = new cxc_cobro_x_EstadoCobro_Data();
        cxc_cobro_tipo_Data DataCobrotipo = new cxc_cobro_tipo_Data();
        List<cxc_cobro_tipo_Info> ListaCobrotipo = new List<cxc_cobro_tipo_Info>();
        cxc_cobro_x_ct_cbtecble_Info InfoAnulado = new cxc_cobro_x_ct_cbtecble_Info();
        cxc_cobro_Det_Bus bus_det = new cxc_cobro_Det_Bus();
        cxc_cobro_Data data = new cxc_cobro_Data();
        Cl_Enumeradores.PantallaEjecucion _Accion;
        caj_Caja_Movimiento_Info CajaMovi_I = new caj_Caja_Movimiento_Info();
        caj_Caja_Movimiento_det_Info CajaMovi_I_DET = new caj_Caja_Movimiento_det_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        caj_parametro_Info infoCaja = new caj_parametro_Info();
        cxc_parametro_Info paramInfo = new cxc_parametro_Info();
        ct_Cbtecble_Info _CbteCbleInfo = new ct_Cbtecble_Info();
        ct_Cbtecble_det_Info _CbteCbleInfo_det = new ct_Cbtecble_det_Info();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        #endregion

        public bool Valida_cobro_x_deposito(cxc_cobro_Info info, ref ba_Cbte_Ban_Info InfoCbteBan_del_deposito)
        {
            try
            {
                return data.Valida_cobro_x_deposito(info, ref InfoCbteBan_del_deposito);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Valida_cobro_x_deposito", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public List<cxc_cobro_Info> Get_List_Cobros_x_depositar_Agrupado_x_cobro(int IdEmpresa, string TipoMovCaj)
        {
            try
            {
                return data.Get_List_Cobros_x_depositar_Agrupado_x_cobro(IdEmpresa, TipoMovCaj);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cobros_x_depositar", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }


        }

        public List<cxc_cobro_Info> Get_List_Cobros_x_depositar_Agrupado_detallado(int IdEmpresa, int mcj_IdTipocbte, decimal mcj_IdCbteCble)
        {
            try
            {
                return data.Get_List_Cobros_x_depositar_Agrupado_detallado(IdEmpresa, mcj_IdTipocbte, mcj_IdCbteCble);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cobros_x_depositar_Agrupado_detallado", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }


        }

        public List<cxc_cobro_Info> Get_List_Cobros_x_depositar(int IdEmpresa, int mcj_IdTipocbte, decimal mcj_IdCbteCble)
        {
            try
            {
                return data.Get_List_cobros_x_depositados(IdEmpresa, mcj_IdTipocbte, mcj_IdCbteCble);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cobros_x_depositar", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public cxc_cobro_Info Get_Info_cobro_x_cliente(int IdEmpresa, int IdSucursal, decimal IdCobro, int IdCliente)
        {
            try
            {
                return data.Get_Info_cobro_x_cliente(IdEmpresa, IdSucursal, IdCobro, IdCliente);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_cobro_x_cliente", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public List<vwcxc_cartera_x_cobrar_Info> NotasCreditoConFacturaXCodigoCLi(String CodCliente)
        {
            try
            {
                return data.NotasCreditoConFacturaXCodigoCLi(CodCliente);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "NotasCreditoConFacturaXCodigoCLi", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public List<cxc_EstadoCobro_Info> Get_List_CobroEstado()
        {
            try
            {
                return data.Get_List_CobroEstado();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_CobroEstado", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }

        }

        public List<cxc_cobro_Info> Get_List_cobro(int IdEmpresa, string tipoCheque, string EstadoCheque, DateTime desde, DateTime hasta, int porfecha)
        {
            try
            {
                return data.Get_List_cobro_x_Cheques(IdEmpresa, tipoCheque, EstadoCheque, desde, hasta, porfecha);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }


        }

        public List<cxc_cobro_Info> Get_List_cobro_x_Tarjeta(int IdEmpresa, string tipoCheque, string EstadoCheque, DateTime desde, DateTime hasta)
        {
            try
            {
                return data.Get_List_cobro_x_Tarjeta(IdEmpresa, tipoCheque, EstadoCheque, desde, hasta);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_Tarjeta", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }

        }

        public List<cxc_cobro_Info> Get_List_cobros_x_depositados(int IdEmpresa, int IdSucursal, decimal IdCobro)
        {
            try
            {
                return data.Get_List_cobros_x_depositados(IdEmpresa, IdSucursal, IdCobro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobros_x_depositados", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }

        }

        public Boolean GuardarDB(Cl_Enumeradores.PantallaEjecucion Accion, ref  cxc_cobro_Info Info, ref string MensajeError, decimal IdCobro_x_Tarjeta = 0)
        {
            cxc_cobro_Info temp = new cxc_cobro_Info();

            temp = Info;

            try
            {
                Boolean ResGrabacion_cobro = false;
                Boolean ResGrabacion_diario = false;
                decimal IdCobro = 0;

                _Accion = Accion;
                IdCobro_x_Cobro_Tarjeta = IdCobro_x_Tarjeta;

                if (Cl_Enumeradores.PantallaEjecucion.ANTICIPOS == Accion)
                {
                    Info.cr_es_anticipo = "S";
                }
                else
                {
                    Info.cr_es_anticipo = "N";
                }

                if (!validar_objeto(Info, ref MensajeError))
                {
                    return false;
                }

                ResGrabacion_cobro = data.GuardarDB(Info, ref IdCobro, ref MensajeError);

                if (ResGrabacion_cobro)
                {
                    if (Info.infoReten.IdEmpresa > 0 && Info.infoReten.IdMultir == 0)
                    {
                        cxc_retencion_Multiple_Bus busReten = new cxc_retencion_Multiple_Bus();
                        busReten.GuardarDB(Info.infoReten);
                    }

                    if (Info.ListaCobro != null && Info.ListaCobro.Count > 0)
                        Info.ListaCobro.ForEach(var => var.IdCobro = temp.IdCobro);

                    cxc_cobro_Det_Bus busDet_cobro = new cxc_cobro_Det_Bus();

                    busDet_cobro.GuardarDB(Info.ListaCobro);

                    if (Info.infoReten.IdEmpresa > 0 && Info.infoReten.IdMultir > 0)
                    {
                        int multireten = 0;
                        Boolean existe;
                        existe = false;
                        multireten = Info.infoReten.IdMultir;


                        if (Info.ListaRetenDocValorApli != null && Info.ListaRetenDocValorApli.Count > 0)
                            Info.ListaRetenDocValorApli.ForEach(var => var.IdCobro = temp.IdCobro);

                        if (Info.ListaRetenDoc != null && Info.ListaRetenDoc.Count > 0)
                            Info.ListaRetenDoc.ForEach(var => var.IdMultir = multireten);
                        if (Info.ListaRetenDocValorApli != null && Info.ListaRetenDocValorApli.Count > 0)
                            Info.ListaRetenDocValorApli.ForEach(var => var.IdMultir = multireten);

                        cxc_retencion_Multiple_Documento_Bus busRetenDoc = new cxc_retencion_Multiple_Documento_Bus();
                        cxc_retencion_Multiple_Documentos_ValorAplicado_Bus busRetenDocValorAplic = new cxc_retencion_Multiple_Documentos_ValorAplicado_Bus();

                        existe = busRetenDoc.ConsultarDocumento(Info.ListaRetenDoc);
                        if (existe == false)
                        {
                            busRetenDoc.GuardarDB(Info.ListaRetenDoc);
                        }

                        busRetenDocValorAplic.GuardarDB(Info.ListaRetenDocValorApli);

                    }

                    if (Cl_Enumeradores.PantallaEjecucion.ANTICIPOS == Accion)
                    {
                        cxc_cobro_x_Anticipo_det_Data cobroAnticipoData = new cxc_cobro_x_Anticipo_det_Data();
                        List<cxc_cobro_x_Anticipo_det_Info> listAnticipoDetalle = new List<cxc_cobro_x_Anticipo_det_Info>();
                        Info.Infocxc_cobro_x_Anticipo_det.IdEmpresa_Cobro = Info.IdEmpresa;
                        Info.Infocxc_cobro_x_Anticipo_det.IdCobro_cobro = Info.IdCobro;
                        Info.Infocxc_cobro_x_Anticipo_det.IdSucursal_cobro = Info.IdSucursal;
                        listAnticipoDetalle.Add(Info.Infocxc_cobro_x_Anticipo_det);
                        cobroAnticipoData.Modificar_datos_cobro(listAnticipoDetalle, ref MensajeError);
                    }

                    ResGrabacion_diario = Contabilizar(Info.IdEmpresa, Info.IdSucursal, Info.IdCobro, Info.IdCbte_vta_nota);
                }

                return ResGrabacion_cobro;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }
        
        public List<cxc_cobro_Info> Get_List_cobro_x_Factura_x_DocxCobrar(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteCble, string TipoDoc, decimal IdCobro_doc_x_cobrar)
        {
            try
            {
                return data.Get_List_cobro_x_Factura_x_DocxCobrar(IdEmpresa, IdSucursal, IdBodega, IdCbteCble, TipoDoc, IdCobro_doc_x_cobrar);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_Factura_x_DocxCobrar", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public Boolean Contabilizar(int IdEmpresa, int IdSucursal, decimal IdCobro, decimal Idvta = 0)
        {
            try
            {
                string msg = "";

                caj_Caja_Movimiento_Bus bus = new caj_Caja_Movimiento_Bus();

                cxc_cobro_x_caj_Caja_Movimiento_Info CxCCMInfo = new cxc_cobro_x_caj_Caja_Movimiento_Info();
                cxc_cobro_x_caj_Caja_Movimiento_Data CxCCMData = new cxc_cobro_x_caj_Caja_Movimiento_Data();
                cxc_cobro_tipo_Info InfoCobrotipo = new cxc_cobro_tipo_Info();
                caj_parametro_Bus buscaja = new caj_parametro_Bus();
                cxc_parametro_Bus paramBus = new cxc_parametro_Bus();

                CxCCMInfo = CxCCMData.Get_Info_cobro_x_caj_Caja_Movimiento(param.IdEmpresa, IdSucursal, IdCobro);

                if (CxCCMInfo.cbr_IdCobro != 0) { return false; }

                //Obtiene el Info del Cobro
                cxc_cobro_Info Info = new cxc_cobro_Info();

                Info = data.Get_Info_Cobro(IdEmpresa, IdSucursal, IdCobro);

                // Obtiene los tipos de cobros  segun el tipo de Cobro / efectivo / TC/ Ch / Retencion
                ///tc_Que_Tipo_Registro_Genera que son DIARIO o MOVI_CAJA 
                //se utiliza el MOVI_CAJA
                ListaCobrotipo = DataCobrotipo.Get_List_Cobro_Tipo();

                var s = from q in ListaCobrotipo
                        where q.IdCobro_tipo == Info.IdCobro_tipo
                        select q.tc_Que_Tipo_Registro_Genera;
                string queGenera = "";

                //Para grabar en la tabla cxc_cobro_x_EstadoCobro
                {
                    cxc_cobro_x_EstadoCobro_Info EstCobro_I = new cxc_cobro_x_EstadoCobro_Info();

                    EstCobro_I.IdEmpresa = Info.IdEmpresa;
                    EstCobro_I.IdSucursal = Info.IdSucursal;
                    EstCobro_I.IdCobro = Info.IdCobro;

                    var c = ListaCobrotipo.First(var => var.IdCobro_tipo == Info.IdCobro_tipo);
                    ///De la lista de tipos de Cobros se obtiene el IdEstadoCobro_Inicial que puede ser PORC o COBR

                    EstCobro_I.IdEstadoCobro = c.IdEstadoCobro_Inicial;
                    EstCobro_I.IdCobro_tipo = Info.IdCobro_tipo;

                    //--------------------------------------------------------------------
                    if (Idvta == 0)
                        EstCobro_I.IdCbte_vta_nota = Info.IdCbte_vta_nota;
                    else
                        EstCobro_I.IdCbte_vta_nota = Idvta;
                    //--------------------------------------------------------------------

                    EstCobro_I.observacion = Info.cr_observacion;
                    EstCobro_I.Fecha = Convert.ToDateTime(Info.cr_fecha.Date);
                    EstCobro_I.IdBanco = Convert.ToInt32(Info.IdBanco);

                    ///Procede a grabar en la tabla cxc_cobro_x_EstadoCobro
                    CobroEstado_D.GuardarDB(EstCobro_I);
                    //-------
                }

                //segun el tipo de cobro se realiza un diario o movimiento de caja
                foreach (var item in s)
                {
                    queGenera = item;
                }

                paramInfo = paramBus.Get_Info_parametro(Info.IdEmpresa);
                infoCaja = buscaja.Get_Info_Parametro(Info.IdEmpresa);

                if (queGenera == "DIARIO")
                {
                    cxc_cobro_x_ct_cbtecble_Bus bus_cobro_x_cbtecble = new cxc_cobro_x_ct_cbtecble_Bus();
                    cxc_cobro_x_ct_cbtecble_Info info_cobro_x_cbtecble = new cxc_cobro_x_ct_cbtecble_Info();

                    info_cobro_x_cbtecble = bus_cobro_x_cbtecble.Get_Info_cobro_x_ct_cbtecble(Info.IdEmpresa, Info.IdSucursal, Info.IdCobro);

                    if (info_cobro_x_cbtecble.cbr_IdCobro == 0)
                    {
                        GeneraCbteCtbl(Info);
                    }
                }
                if (queGenera == "MOVI_CAJA")
                {
                    ///Graba los movimientos de las Cajas
                    /// Graba en las tablas caj_Caja_Movimiento y caj_Caja_Movimiento_det
                    GeneraMoviCaja(Info);

                    ///
                    ///Graba en la tabla intermedia cxc_cobro_x_caj_Caja_Movimiento
                    GuardarCxCxCajaMovimiento(Info);
                }

                if (queGenera == "DEPOSITO")
                {
                    /// Generación del Diario
                    /// Graba en las tablas caj_Caja_Movimiento y caj_Caja_Movimiento_det
                    GeneraMoviCaja(Info);

                    ///
                    ///Graba en la tabla intermedia cxc_cobro_x_caj_Caja_Movimiento
                    GuardarCxCxCajaMovimiento(Info);

                    //Graba el Deposito ba_Cbte_Ban, el Cbte Cble del deposito y la tabla intermedia
                    Registra_Contabiliza_Deposito_x_Cobro(param.IdEmpresa, CajaMovi_I.IdTipocbte, CajaMovi_I.IdCbteCble, "DEPO", ref msg);
                }

                if (queGenera == "NTCR_BAN")
                {

                    ///Graba los movimientos de las Cajas
                    GeneraMoviCaja(Info);
                    ///
                    ///Graba en la tabla intermedia cxc_cobro_x_caj_Caja_Movimiento
                    GuardarCxCxCajaMovimiento(Info);

                    //Graba el Deposito ba_Cbte_Ban, el Cbte Cble del deposito y la tabla intermedia
                }

                //idCbteCble = CajaMovi_I.IdCbteCble;
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Contabilizar", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public Boolean Contabilizar_Anulacion(int IdEmpresa, int IdSucursal, decimal IdCobro, DateTime FechaAnul)
        {
            try
            {
                caj_parametro_Bus buscaja = new caj_parametro_Bus();
                cxc_parametro_Bus paramBus = new cxc_parametro_Bus();
                cxc_cobro_Info Info = new cxc_cobro_Info();
                Info = data.Get_Info_Cobro(IdEmpresa, IdSucursal, IdCobro);
                paramInfo = paramBus.Get_Info_parametro(Info.IdEmpresa);
                infoCaja = buscaja.Get_Info_Parametro(Info.IdEmpresa);

                Info.Fecha_Anulac = FechaAnul;

                cxc_cobro_tipo_Data DataCobrotipo = new cxc_cobro_tipo_Data();
                List<cxc_cobro_tipo_Info> ListaCobrotipo = new List<cxc_cobro_tipo_Info>();

                ListaCobrotipo = DataCobrotipo.Get_List_Cobro_Tipo();

                var s = from q in ListaCobrotipo where q.IdCobro_tipo == Info.IdCobro_tipo select q.tc_Que_Tipo_Registro_Genera;

                string queGenera = "";
                foreach (var item in s)
                {
                    queGenera = item;
                }

                if (queGenera == "DIARIO")
                {
                    GeneraCbteCtblANULACIONSOLODIARIO(Info);

                }
                if (queGenera == "MOVI_CAJA")
                {
                    GeneraCbteCtblANULACIONSOLODIARIO(Info);
                    GeneraMoviCajaANULACION(Info, InfoAnulado.ct_IdTipoCbte, InfoAnulado.ct_IdCbteCble);
                }
                if (queGenera == "DEPOSITO")
                {
                    GeneraCbteCtblANULACIONSOLODIARIO(Info);
                    GeneraMoviCajaANULACION(Info, InfoAnulado.ct_IdTipoCbte, InfoAnulado.ct_IdCbteCble);
                    GeneraMoviBancoANULACION(Info);
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Contabilizar_Anulacion", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public void GuardarCxCxCajaMovimiento(cxc_cobro_Info Info)
        {
            try
            {
                ///
                ///Graba en la tabla intermedia cxc_cobro_x_caj_Caja_Movimiento solo es utilizada por la funcion Contabilizar()
                ///donde se llena el info CajaMovi_I
                ///

                cxc_cobro_x_caj_Caja_Movimiento_Info info = new cxc_cobro_x_caj_Caja_Movimiento_Info();
                info.mcj_IdCbteCble = CajaMovi_I.IdCbteCble;
                info.mcj_IdEmpresa = CajaMovi_I.IdEmpresa;
                info.mcj_IdTipocbte = CajaMovi_I.IdTipocbte;
                info.cbr_IdEmpresa = Info.IdEmpresa;
                info.cbr_IdSucursal = Info.IdSucursal;
                info.cbr_IdCobro = Info.IdCobro;

                cxc_cobro_x_caj_Caja_Movimiento_Data data = new cxc_cobro_x_caj_Caja_Movimiento_Data();
                data.GuardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarCxCxCajaMovimiento", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public void GeneraMoviCajaANULACION(cxc_cobro_Info Info, int IdTipocbte_Anu, decimal IdCbteCble_Anu)
        {
            try
            {
                caj_Caja_Movimiento_Bus bus = new caj_Caja_Movimiento_Bus();
                cxc_cobro_x_caj_Caja_Movimiento_Info CxCCMInfo = new cxc_cobro_x_caj_Caja_Movimiento_Info();
                cxc_cobro_x_caj_Caja_Movimiento_Data CxCCMData = new cxc_cobro_x_caj_Caja_Movimiento_Data();

                CxCCMInfo = CxCCMData.Get_Info_cobro_x_caj_Caja_Movimiento(param.IdEmpresa, Info.IdSucursal, Info.IdCobro);
                CajaMovi_I.IdEmpresa = CxCCMInfo.mcj_IdEmpresa;
                CajaMovi_I.IdTipocbte = CxCCMInfo.mcj_IdTipocbte;
                CajaMovi_I.IdCbteCble = CxCCMInfo.mcj_IdCbteCble;
                CajaMovi_I.IdTipocbte_Anu = IdTipocbte_Anu;
                CajaMovi_I.IdCbteCble_Anu = IdCbteCble_Anu;
                bus.AnularDB(CajaMovi_I, ref  MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GeneraMoviCajaANULACION", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public void GeneraMoviBancoANULACION(cxc_cobro_Info Info)
        {
            try
            {
                ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus Bus_Caja_Movimiento_x_Cbte_Ban_x_Deposito = new ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus();
                ba_Cbte_Ban_Info Info_Banc = new ba_Cbte_Ban_Info();
                caj_Caja_Movimiento_Bus bus = new caj_Caja_Movimiento_Bus();
                cxc_cobro_x_caj_Caja_Movimiento_Info CxCCMInfo = new cxc_cobro_x_caj_Caja_Movimiento_Info();
                cxc_cobro_x_caj_Caja_Movimiento_Data CxCCMData = new cxc_cobro_x_caj_Caja_Movimiento_Data();
                ct_Cbtecble_Bus bus_Cbte = new ct_Cbtecble_Bus();
                List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> listParaBan = new List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info>();
                ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info paramBa_I = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();
                ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus paramBa_B = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();
                ba_Cbte_Ban_Info CbteBan_I = new ba_Cbte_Ban_Info();
                ba_Cbte_Ban_Bus CbteBan_B = new ba_Cbte_Ban_Bus();
                int IdTipoCbteRev = 0;
                decimal IdCbteCbleRev = 0;

                bool respuesta_rev_cbteCble = false;
                bool respuesta_Update_Estado_Cbte = false;

                CxCCMInfo = CxCCMData.Get_Info_cobro_x_caj_Caja_Movimiento(param.IdEmpresa, Info.IdSucursal, Info.IdCobro);

                if (CxCCMInfo != null)
                {
                    //CONSULTAMOS MOVIMIENTOS DE CAJA Y BANCARIO
                    List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info> List_Mov_Caja_x_Cbte_Ban_x_Deposito = Bus_Caja_Movimiento_x_Cbte_Ban_x_Deposito.Get_List_Cbte_Ban_x_Caja_Movimiento(CxCCMInfo.mcj_IdEmpresa, CxCCMInfo.mcj_IdCbteCble, CxCCMInfo.mcj_IdTipocbte);

                    if (List_Mov_Caja_x_Cbte_Ban_x_Deposito.Count() > 0)
                    {
                        listParaBan = paramBa_B.Get_List_Banco_Parametros(param.IdEmpresa);
                        paramBa_I = listParaBan.Find(delegate(ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info P) { return P.CodTipoCbteBan == "DEPO"; });

                        if (paramBa_I == null)
                        {
                            MensajeError = "No puede continuar porque no han ingresado los parámetros de banco.. \n Ingréselos desde la pantalla de parámetros de banco o, comuníquese  con sistemas";
                            return;
                        }
                        else
                        {
                            if (paramBa_I.IdTipoCbteCble <= 0 || paramBa_I.IdTipoCbteCble_Anu <= 0)
                            {
                                MensajeError = "No puede continuar porque están incompletos los parámetros de banco IdTipoCbteCble o IdTipoCbteCble_Anu.. \n Ingréselos desde la pantalla de parámetros de banco o, comuníquese  con sistemas";
                                return;
                            }
                            else
                            {
                                IdTipoCbteRev = paramBa_I.IdTipoCbteCble_Anu;
                            }
                        }

                        foreach (var item in List_Mov_Caja_x_Cbte_Ban_x_Deposito)
                        {
                            respuesta_rev_cbteCble = bus_Cbte.ReversoCbteCble_Edehsa(item.mba_IdEmpresa, item.mba_IdCbteCble, item.mba_IdTipocbte, IdTipoCbteRev, Convert.ToDateTime(Info.Fecha_Anulac), ref IdCbteCbleRev, ref MensajeError, param.IdUsuario);

                            if (respuesta_rev_cbteCble)
                            {
                                CbteBan_I = CbteBan_B.Get_Info_Cbte_Ban(item.mba_IdEmpresa, item.mba_IdTipocbte, item.mba_IdCbteCble, ref MensajeError);

                                if (CbteBan_I != null)
                                {
                                    CbteBan_I.MotivoAnulacion = Info.MotiAnula;
                                    CbteBan_I.IdUsuario_Anu = param.IdUsuario;
                                    CbteBan_I.FechaAnulacion = param.Fecha_Transac;
                                    CbteBan_I.IdTipoCbte_Anulacion = IdTipoCbteRev;
                                    CbteBan_I.IdCbteCble_Anulacion = IdCbteCbleRev;

                                    respuesta_Update_Estado_Cbte = CbteBan_B.AnularDB(CbteBan_I, ref MensajeError);

                                    if (respuesta_Update_Estado_Cbte)
                                    {
                                        bool respuesta_Eliminar_Cobros = false;

                                        respuesta_Eliminar_Cobros = Bus_Caja_Movimiento_x_Cbte_Ban_x_Deposito.EliminarCobros_x_deposito(item.mba_IdEmpresa, item.mba_IdTipocbte, item.mba_IdCbteCble);

                                        if (respuesta_Eliminar_Cobros)
                                            MensajeError = "Comprobante bancario de Depósito # " + CbteBan_I.IdCbteCble + " Anulado correctamente, Con el Tipo de Comprobante de Anulación #" + IdTipoCbteRev + " y el Comprobante de Anulación #: " + IdCbteCbleRev;
                                        else
                                            MensajeError = "No se pudo Eliminar los Cobro depositados...";

                                        MensajeError = "Cbt.Cble. de Anu.: " + CbteBan_I.IdCbteCble_Anulacion.ToString() + " Tipo Cbt.Cble de Anu.: " + CbteBan_I.IdTipoCbte_Anulacion.ToString();
                                    }
                                    else
                                        MensajeError = "No se pudo Anular el Comprobante bancario de Depósito";
                                }
                            }
                            else
                                MensajeError = "No se pudo Reversar el Comprobante bancario de Depósito";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GeneraMoviBancoANULACION", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public void GeneraMoviCaja(cxc_cobro_Info Info)
        {
            try
            {
                caj_Caja_Movimiento_Bus bus = new caj_Caja_Movimiento_Bus();
                cxc_cobro_x_ct_cbtecble_Data datacxcxct = new cxc_cobro_x_ct_cbtecble_Data();
                cxc_cobro_x_ct_cbtecble_Info InfoCxCxCt = new cxc_cobro_x_ct_cbtecble_Info();

                //get_cajaMovi funcion que transforma el Info en un  caj_Caja_Movimiento_Info
                // y Graba en tabla caj_Caja_Movimiento
                CajaMovi_I = get_cajaMovi(Info); // optiene el info de caja
                CajaMovi_I.Info_CbteCble_x_Caja_Movi = get_CbteCbleInfo(Info);// optiene el info de cbtecble
                bus.GrabarDB(ref CajaMovi_I, ref  MensajeError);

                InfoCxCxCt.cbr_IdCobro = Info.IdCobro;
                InfoCxCxCt.cbr_IdEmpresa = Info.IdEmpresa;
                InfoCxCxCt.cbr_IdSucursal = Info.IdSucursal;
                InfoCxCxCt.ct_IdCbteCble = CajaMovi_I.IdCbteCble;
                InfoCxCxCt.ct_IdEmpresa = _CbteCbleInfo.IdEmpresa;
                InfoCxCxCt.ct_IdTipoCbte = _CbteCbleInfo.IdTipoCbte;
                datacxcxct.GuardarDB(InfoCxCxCt);

                foreach (var item in CajaMovi_I.Info_CbteCble_x_Caja_Movi._cbteCble_det_lista_info)
                {
                    if (item.Info_cobro_det.IdCobro > 0 && item.IdCbteCble > 0)
                    {
                        cxc_cobro_det_x_ct_cbtecble_det_Data data_det_cxc_cbta = new cxc_cobro_det_x_ct_cbtecble_det_Data();
                        cxc_cobro_det_x_ct_cbtecble_det_Info info_det_cxc_cbta = new cxc_cobro_det_x_ct_cbtecble_det_Info();

                        info_det_cxc_cbta.IdEmpresa_cb = item.Info_cobro_det.IdEmpresa;
                        info_det_cxc_cbta.IdSucursal_cb = item.Info_cobro_det.IdSucursal;
                        info_det_cxc_cbta.IdCobro_cb = item.Info_cobro_det.IdCobro;
                        info_det_cxc_cbta.secuencial_cb = item.Info_cobro_det.secuencial;

                        info_det_cxc_cbta.IdEmpresa_ct = item.IdEmpresa;
                        info_det_cxc_cbta.IdTipoCbte_ct = item.IdTipoCbte;
                        info_det_cxc_cbta.IdCbteCble_ct = item.IdCbteCble;
                        info_det_cxc_cbta.secuencia_ct = item.secuencia;
                        info_det_cxc_cbta.observacion = "";
                        data_det_cxc_cbta.GuardarDB(info_det_cxc_cbta);
                    }
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GeneraMoviCaja", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public void get_Cbtecble_Movi_Caja(cxc_cobro_Info Info)
        {
            try
            {
                ct_Cbtecble_Bus bus = new ct_Cbtecble_Bus();
                cxc_cobro_x_ct_cbtecble_Data datacxcxct = new cxc_cobro_x_ct_cbtecble_Data();
                cxc_cobro_x_ct_cbtecble_Info InfoCxCxCt = new cxc_cobro_x_ct_cbtecble_Info();
                // armando el diario 
                get_CbteCbleInfo(Info);

                string msg = "";
                bus.GrabarDB(_CbteCbleInfo, ref idctctb, ref msg);

                //tabla intermedia cxc CbteCble
                InfoCxCxCt.cbr_IdCobro = Info.IdCobro;
                InfoCxCxCt.cbr_IdEmpresa = Info.IdEmpresa;
                InfoCxCxCt.cbr_IdSucursal = Info.IdSucursal;
                InfoCxCxCt.ct_IdCbteCble = idctctb;
                InfoCxCxCt.ct_IdEmpresa = _CbteCbleInfo.IdEmpresa;
                InfoCxCxCt.ct_IdTipoCbte = _CbteCbleInfo.IdTipoCbte;
                datacxcxct.GuardarDB(InfoCxCxCt);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_Cbtecble_Movi_Caja", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public caj_Caja_Movimiento_Info get_cajaMovi(cxc_cobro_Info Info)
        {
            try
            {
                //

                fa_Cliente_Info cliente = new fa_Cliente_Info();
                fa_Vendedor_Info vendedor = new fa_Vendedor_Info();
                cliente.IdCliente = Convert.ToInt32(Info.IdCliente);
                fa_Cliente_Bus clientebus = new fa_Cliente_Bus();
                clientebus.ConsultarClienteVendedor(Info.IdEmpresa, ref cliente, ref vendedor);
                //
                CajaMovi_I.IdEntidad = cliente.IdCliente;
                CajaMovi_I.IdPersona = cliente.IdPersona;
                CajaMovi_I.IdTipo_Persona = "CLIENTE";
                CajaMovi_I.cm_fecha = Convert.ToDateTime(DateTime.Now);
                CajaMovi_I.cm_observacion = "Cobro por " + Info.IdCobro_tipo + " # " + Info.cr_NumDocumento + ((Info.cr_cuenta == "") ? "" : " Doc. Num. " + Info.cr_cuenta) + ((Info.cr_cuenta == "") ? "" : " del Banco " + Info.cr_Banco) + " Del Cliente " + cliente.Persona_Info.pe_nombreCompleto + " por el Monto de " + Info.cr_TotalCobro;
                CajaMovi_I.cm_beneficiario = cliente.Persona_Info.pe_nombre + " " + cliente.Persona_Info.pe_apellido;
                CajaMovi_I.cm_Signo = "+";
                CajaMovi_I.cm_valor = Info.cr_TotalCobro;
                CajaMovi_I.Estado = "A";
                CajaMovi_I.Fecha_Transac = Info.Fecha_Transac;
                CajaMovi_I.Fecha_UltMod = Info.Fecha_UltAnu;
                CajaMovi_I.FechaAnulacion = Info.Fecha_UltAnu;
                CajaMovi_I.IdCaja = Info.IdCaja;
                CajaMovi_I.IdSucursal = Convert.ToInt32(Info.IdSucursal);
                CajaMovi_I.IdCbteCble = idctctb;
                CajaMovi_I.CodMoviCaja = "INGCAJXCOBRO";
                CajaMovi_I.IdEmpresa = Info.IdEmpresa;
                CajaMovi_I.IdPeriodo = DateTime.Now.Year * 100 + DateTime.Now.Month;
                CajaMovi_I.IdTipocbte = infoCaja.IdTipoCbteCble_MoviCaja_Ing;
                CajaMovi_I.IdTipoMovi = paramInfo.pa_IdTipoMoviCaja_x_Cobros_x_cliente;
                CajaMovi_I.IdUsuario = param.IdUsuario;
                //CajaMovi_I.IdCentroCosto = "";


                List<caj_Caja_Movimiento_det_Info> Listdet = new List<caj_Caja_Movimiento_det_Info>();
                int contador = 1;

                cxc_cobro_Det_Bus BusDet_cobro = new cxc_cobro_Det_Bus();

                Info.ListaCobro = BusDet_cobro.Get_List_Cobro_detalle(Info.IdEmpresa, Info.IdSucursal, Info.IdCobro);
                if (Info.ListaCobro.Count() > 0)
                {
                    foreach (var item in Info.ListaCobro)
                    {
                        caj_Caja_Movimiento_det_Info info_det = new caj_Caja_Movimiento_det_Info();

                        info_det.IdEmpresa = param.IdEmpresa;
                        info_det.IdOrdenPago = null;
                        info_det.cr_Valor = item.dc_ValorPago;
                        info_det.Secuencia = contador;
                        info_det.IdTipocbte = infoCaja.IdTipoCbteCble_MoviCaja_Ing;
                        info_det.IdCobro_tipo = item.IdCobro_tipo;
                        info_det.cr_fecha = Info.cr_fecha;
                        info_det.cr_Banco = Info.cr_Banco;
                        info_det.cr_cuenta = Info.cr_cuenta;
                        info_det.cr_fechaDocu = Info.cr_fecha;
                        info_det.cr_NumDocumento = Info.cr_NumDocumento;
                        info_det.IdCbteCble = CajaMovi_I.IdCbteCble;
                        info_det.IdTipocbte = CajaMovi_I.IdTipocbte;
                        info_det.IdEmpresa_OP = item.IdEmpresa;

                        switch (param.IdCliente_Ven_x_Default)
                        {
                            case Cl_Enumeradores.eCliente_Vzen.EDEHSA:
                                info_det.IdCentroCosto = item.IdCentroCosto;
                                if (info_det.IdCentroCosto != null)
                                {
                                    CajaMovi_I.IdCentroCosto = info_det.IdCentroCosto;
                                }
                                break;
                        }


                        info_det.info_det_cobro = item;

                        Listdet.Add(info_det);
                        contador = contador + 1;
                    }
                }
                else// se crea una fila por la cabecera el cobro no tiene detalle
                {
                    caj_Caja_Movimiento_det_Info info_det = new caj_Caja_Movimiento_det_Info();

                    info_det.IdEmpresa = param.IdEmpresa;
                    info_det.IdOrdenPago = null;
                    info_det.cr_Valor = Info.cr_TotalCobro;
                    info_det.Secuencia = 1;
                    info_det.IdTipocbte = infoCaja.IdTipoCbteCble_MoviCaja_Ing;
                    info_det.IdCobro_tipo = Info.IdCobro_tipo;
                    info_det.cr_fecha = Info.cr_fecha;
                    info_det.cr_Banco = Info.cr_Banco;
                    info_det.cr_cuenta = Info.cr_cuenta;
                    info_det.cr_fechaDocu = Info.cr_fecha;
                    info_det.cr_NumDocumento = Info.cr_NumDocumento;
                    info_det.IdCbteCble = CajaMovi_I.IdCbteCble;
                    info_det.IdTipocbte = CajaMovi_I.IdTipocbte;
                    info_det.IdEmpresa_OP = null;

                    switch (param.IdCliente_Ven_x_Default)
                    {
                        case Cl_Enumeradores.eCliente_Vzen.EDEHSA:
                            info_det.IdCentroCosto = CajaMovi_I.IdCentroCosto;

                            break;
                    }


                    Listdet.Add(info_det);


                }

                CajaMovi_I.list_Caja_Movi_det = Listdet;

                return CajaMovi_I;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_cajaMovi", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public List<caj_Caja_Movimiento_det_Info> GetDetalle_Grid(cxc_cobro_Info Info)
        {
            try
            {
                List<caj_Caja_Movimiento_det_Info> Listdet = new List<caj_Caja_Movimiento_det_Info>();
                int contador = 1;
                foreach (var item in Info.ListaCobro)
                {
                    caj_Caja_Movimiento_det_Info info_det = new caj_Caja_Movimiento_det_Info();

                    info_det.IdEmpresa = param.IdEmpresa;
                    info_det.IdOrdenPago = null;
                    info_det.cr_Valor = item.dc_ValorPago;
                    info_det.Secuencia = contador;
                    //info_det.IdTipocbte = _IdTipoCbte;
                    info_det.IdCobro_tipo = item.IdCobro_tipo;
                    info_det.cr_fecha = item.Fecha_Transac;
                    //info_det.cr_Banco = item.cr_Banco;
                    //info_det.cr_cuenta = item.cr_cuenta;
                    //info_det.cr_fechaDocu = item.cr_fecha;
                    //info_det.cr_NumDocumento = item.cr_NumDocumento;
                    info_det.IdCbteCble = CajaMovi_I.IdCbteCble;
                    info_det.IdTipocbte = CajaMovi_I.IdTipocbte;
                    info_det.IdEmpresa_OP = item.IdEmpresa;

                    Listdet.Add(info_det);
                    contador = contador + 1;
                }

                CajaMovi_I.list_Caja_Movi_det = Listdet;

                return Listdet;
            }
            catch (Exception ex)
            {
                return new List<caj_Caja_Movimiento_det_Info>();
            }
        }

        public List<caj_Caja_Movimiento_det_Info> get_cajaMoviD(cxc_cobro_Info Info, decimal IdCbteCble, ref string MensajeError)
        {
            try
            {
                List<caj_Caja_Movimiento_det_Info> lista = new List<caj_Caja_Movimiento_det_Info>();
                CajaMovi_I_DET.IdEmpresa = Info.IdEmpresa;

                CajaMovi_I_DET.IdCbteCble = IdCbteCble;
                CajaMovi_I_DET.IdTipocbte = CajaMovi_I.IdTipocbte;
                CajaMovi_I_DET.Secuencia = 1;
                CajaMovi_I_DET.IdCobro_tipo = Info.IdCobro_tipo;
                CajaMovi_I_DET.cr_fecha = Convert.ToDateTime(DateTime.Now);
                CajaMovi_I_DET.cr_Valor = Convert.ToDouble(Info.cr_TotalCobro);
                CajaMovi_I_DET.cr_cuenta = Info.cr_cuenta;
                CajaMovi_I_DET.cr_NumDocumento = Info.cr_NumDocumento;
                CajaMovi_I_DET.cr_fechaDocu = Info.cr_fechaDocu;
                CajaMovi_I_DET.cr_Banco = Info.cr_Banco;
                lista.Add(CajaMovi_I_DET);
                return lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_cajaMoviD", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public void GeneraCbteCtbl(cxc_cobro_Info Info)
        {
            try
            {
                Boolean res = false;

                string msg = "";
                ct_Cbtecble_Bus bus = new ct_Cbtecble_Bus();
                cxc_cobro_x_ct_cbtecble_Data datacxcxct = new cxc_cobro_x_ct_cbtecble_Data();
                cxc_cobro_x_ct_cbtecble_Info InfoCxCxCt = new cxc_cobro_x_ct_cbtecble_Info();

                cxc_cobro_det_x_ct_cbtecble_det_Data data_cxc_det_x_conta_det = new cxc_cobro_det_x_ct_cbtecble_det_Data();
                cxc_cobro_det_x_ct_cbtecble_det_Info Info_cxc_det_x_conta_det = new cxc_cobro_det_x_ct_cbtecble_det_Info();

                // armando el diario 
                get_CbteCbleInfo(Info);

                res = bus.GrabarDB(_CbteCbleInfo, ref idctctb, ref msg);
                if (res == true)
                {
                    //tabla intermedia cxc CbteCble
                    InfoCxCxCt.cbr_IdCobro = Info.IdCobro;
                    InfoCxCxCt.cbr_IdEmpresa = Info.IdEmpresa;
                    InfoCxCxCt.cbr_IdSucursal = Info.IdSucursal;
                    InfoCxCxCt.ct_IdCbteCble = idctctb;
                    InfoCxCxCt.ct_IdEmpresa = _CbteCbleInfo.IdEmpresa;
                    InfoCxCxCt.ct_IdTipoCbte = _CbteCbleInfo.IdTipoCbte;
                    datacxcxct.GuardarDB(InfoCxCxCt);

                    // tabla intermedi detalle 

                    foreach (var item in _CbteCbleInfo._cbteCble_det_lista_info)
                    {

                        if (item.Info_cobro_det.IdCobro > 0 && item.IdCbteCble > 0)
                        {
                            Info_cxc_det_x_conta_det.IdEmpresa_cb = item.Info_cobro_det.IdEmpresa;
                            Info_cxc_det_x_conta_det.IdSucursal_cb = item.Info_cobro_det.IdSucursal;
                            Info_cxc_det_x_conta_det.IdCobro_cb = item.Info_cobro_det.IdCobro;
                            Info_cxc_det_x_conta_det.secuencial_cb = item.Info_cobro_det.secuencial;
                            Info_cxc_det_x_conta_det.IdEmpresa_ct = item.IdEmpresa;
                            Info_cxc_det_x_conta_det.IdTipoCbte_ct = item.IdTipoCbte;
                            Info_cxc_det_x_conta_det.IdCbteCble_ct = item.IdCbteCble;
                            Info_cxc_det_x_conta_det.secuencia_ct = item.secuencia;
                            Info_cxc_det_x_conta_det.observacion = "";
                            data_cxc_det_x_conta_det.GuardarDB(Info_cxc_det_x_conta_det);
                        }
                    }
                }





            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GeneraCbteCtbl", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public void GeneraCbteCtblSoloDiario(cxc_cobro_Info Info)
        {
            try
            {
                ct_Cbtecble_Bus bus = new ct_Cbtecble_Bus();
                cxc_cobro_x_ct_cbtecble_Data datacxcxct = new cxc_cobro_x_ct_cbtecble_Data();
                cxc_cobro_x_ct_cbtecble_Info InfoCxCxCt = new cxc_cobro_x_ct_cbtecble_Info();
                get_CbteCbleInfoSOLODIARIO(Info);
                string msg = "";
                bus.GrabarDB(_CbteCbleInfo, ref idctctb, ref msg);

                //tabla intermedia cxc CbteCble
                InfoCxCxCt.cbr_IdCobro = Info.IdCobro;
                InfoCxCxCt.cbr_IdEmpresa = Info.IdEmpresa;
                InfoCxCxCt.cbr_IdSucursal = Info.IdSucursal;
                InfoCxCxCt.ct_IdCbteCble = idctctb;
                InfoCxCxCt.ct_IdEmpresa = _CbteCbleInfo.IdEmpresa;
                InfoCxCxCt.ct_IdTipoCbte = _CbteCbleInfo.IdTipoCbte;
                datacxcxct.GuardarDB(InfoCxCxCt);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GeneraCbteCtblSoloDiario", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public ct_Cbtecble_Info get_CbteCbleInfo(cxc_cobro_Info Info)
        {
            try
            {
                string MensajeError = "";

                ct_Cbtecble_Bus _Cbtebus = new ct_Cbtecble_Bus();
                ct_Cbtecble_tipo_Bus cbtipobus = new ct_Cbtecble_tipo_Bus();
                ct_Periodo_Bus _PeriodoBus = new ct_Periodo_Bus();
                ct_Periodo_Info _PeriodoInfo = new ct_Periodo_Info();

                _CbteCbleInfo = new ct_Cbtecble_Info();

                _PeriodoInfo = _PeriodoBus.Get_Info_Periodo(Info.IdEmpresa, Info.cr_fecha, ref MensajeError);
                if (_PeriodoInfo != null && _PeriodoInfo.pe_cerrado != "S")
                {

                    fa_Cliente_Info cliente = new fa_Cliente_Info();
                    fa_Vendedor_Info vendedor = new fa_Vendedor_Info();
                    cliente.IdCliente = Info.IdCliente;
                    fa_Cliente_Bus clientebus = new fa_Cliente_Bus();
                    clientebus.ConsultarClienteVendedor(Info.IdEmpresa, ref cliente, ref vendedor);


                    _CbteCbleInfo.IdEmpresa = Info.IdEmpresa;
                    _CbteCbleInfo.IdUsuario = param.IdUsuario;
                    _CbteCbleInfo.CodCbteCble = "CBR" + Info.IdCobro_tipo + Info.IdCobro.ToString();
                    _CbteCbleInfo.IdPeriodo = _PeriodoInfo.IdPeriodo;
                    _CbteCbleInfo.Anio = _PeriodoInfo.IdanioFiscal;
                    _CbteCbleInfo.Mes = _PeriodoInfo.pe_mes;
                    _CbteCbleInfo.IdTipoCbte = infoCaja.IdTipoCbteCble_MoviCaja_Ing;
                    _CbteCbleInfo.cb_Fecha = Info.cr_fecha;
                    _CbteCbleInfo.cb_FechaTransac = param.Fecha_Transac;
                    _CbteCbleInfo.Mayorizado = "N";
                    _CbteCbleInfo.cb_Observacion = "Cbr# " + Info.IdCobro.ToString() + " / " + cliente.Persona_Info.pe_nombre + " " + cliente.Persona_Info.pe_apellido + " en " + Info.IdCobro_tipo + " x el monto: " + Info.cr_TotalCobro;
                    _CbteCbleInfo.Secuencia = _Cbtebus.Get_IdSecuencia(ref MensajeError);
                    _CbteCbleInfo.cb_Valor = Info.cr_TotalCobro;
                    _CbteCbleInfo.Estado = "A";
                    _CbteCbleInfo.IdUsuario = param.IdUsuario;
                    _CbteCbleInfo._cbteCble_det_lista_info = get_CbteCble_det(Info);

                    return _CbteCbleInfo;
                }
                else
                {
                    return new ct_Cbtecble_Info();
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CbteCbleInfo", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public ct_Cbtecble_Info get_CbteCbleInfoSOLODIARIO(cxc_cobro_Info Info)
        {
            try
            {
                ct_Cbtecble_Bus _Cbtebus = new ct_Cbtecble_Bus();
                ct_Cbtecble_tipo_Bus cbtipobus = new ct_Cbtecble_tipo_Bus();
                ct_Periodo_Bus _PeriodoBus = new ct_Periodo_Bus();
                ct_Periodo_Info _PeriodoInfo = new ct_Periodo_Info();
                string MensajeError = "";
                _PeriodoInfo = _PeriodoBus.Get_Info_Periodo(Info.IdEmpresa, Info.cr_fecha, ref MensajeError);
                if (_PeriodoInfo != null && _PeriodoInfo.pe_cerrado != "S")
                {
                    _CbteCbleInfo.IdEmpresa = Info.IdEmpresa;
                    _CbteCbleInfo.IdUsuario = param.IdUsuario;
                    _CbteCbleInfo.IdPeriodo = _PeriodoInfo.IdPeriodo;
                    _CbteCbleInfo.Anio = _PeriodoInfo.IdanioFiscal;
                    _CbteCbleInfo.Mes = _PeriodoInfo.pe_mes;
                    _CbteCbleInfo.IdTipoCbte = paramInfo.pa_IdTipoCbteCble_CxC;
                    _CbteCbleInfo.CodCbteCble = "COBRO" + Info.IdCobro;
                    _CbteCbleInfo.cb_Fecha = Info.cr_fecha;
                    _CbteCbleInfo.cb_FechaTransac = param.Fecha_Transac;
                    _CbteCbleInfo.Mayorizado = "N";
                    _CbteCbleInfo.cb_Observacion = "COBRO # " + Info.IdCobro.ToString() + " en " + Info.IdCobro_tipo + " por el monto de " + Info.cr_TotalCobro;
                    _CbteCbleInfo.Secuencia = _Cbtebus.Get_IdSecuencia(ref MensajeError);
                    _CbteCbleInfo.cb_Valor = Info.cr_TotalCobro;
                    _CbteCbleInfo.Estado = "A";
                    _CbteCbleInfo.IdUsuario = param.IdUsuario;
                    _CbteCbleInfo._cbteCble_det_lista_info = get_CbteCble_det(Info);
                    return _CbteCbleInfo;
                }
                else
                {
                    return new ct_Cbtecble_Info();
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CbteCbleInfoSOLODIARIO", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public List<ct_Cbtecble_det_Info> get_CbteCble_det(cxc_cobro_Info Info)
        {
            string tomarCtaCble = "";
            string IdCtaCbleDeudora = "";
            List<ct_Cbtecble_det_Info> Listadte = new List<ct_Cbtecble_det_Info>();

            try
            {
                cxc_cobro_tipo_Param_conta_x_sucursal_Data dat = new cxc_cobro_tipo_Param_conta_x_sucursal_Data();
                cxc_cobro_tipo_Param_conta_x_sucursal_Info InfocxcTipo = new cxc_cobro_tipo_Param_conta_x_sucursal_Info();
                caj_Caja_Info CajaInfo = new caj_Caja_Info();
                caj_Caja_Bus BusCaja = new caj_Caja_Bus();
                List<cxc_cobro_Det_Info> DetCobro = new List<cxc_cobro_Det_Info>();
                cxc_cobro_Det_Bus BusDetCobro = new cxc_cobro_Det_Bus();
                cxc_cobro_x_Anticipo_det_Bus Bus_cxc_cobro_x_Anti = new cxc_cobro_x_Anticipo_det_Bus();
                cxc_anticipo_facturado_Bus Bus_Anticipos_Facturados = new cxc_anticipo_facturado_Bus();
                List<cxc_cobro_x_Anticipo_det_Info> Lista_cobro_x_anticipo = new List<cxc_cobro_x_Anticipo_det_Info>();
                List<cxc_anticipo_facturado_Info> List_Anticipo_Facturados = new List<cxc_anticipo_facturado_Info>();

                ////////////////////////////////////////////////////////////////////////////
                //// para ver de donde tomo la cuenta s de la caja o del tipo de documento
                var tipoCobro = from q in ListaCobrotipo where q.IdCobro_tipo == Info.IdCobro_tipo select q.tc_Tomar_Cta_Cble_De;
                foreach (var item in tipoCobro)
                {
                    tomarCtaCble = item;
                }
                ////////////////////////////////////////////////////////////////////////////

                //verifico si es por cobro de tarjeta para sacar la cuenta deudora
                if (Cl_Enumeradores.PantallaEjecucion.TARJETA == _Accion)
                {
                    if (IdCobro_x_Cobro_Tarjeta != 0)
                    {
                        cxc_cobro_x_ct_cbtecble_Info InfoCxCxCt = new cxc_cobro_x_ct_cbtecble_Info();
                        cxc_cobro_x_ct_cbtecble_Bus BusCxCxCt = new cxc_cobro_x_ct_cbtecble_Bus();
                        ct_Cbtecble_det_Bus BusDet = new ct_Cbtecble_det_Bus();
                        List<ct_Cbtecble_det_Info> lstCbteCble_det = new List<ct_Cbtecble_det_Info>();
                        InfoCxCxCt = BusCxCxCt.Get_Info_cobro_x_ct_cbtecble(Info.IdEmpresa, Info.IdSucursal, IdCobro_x_Cobro_Tarjeta);
                        lstCbteCble_det = BusDet.Get_list_Cbtecble_det(InfoCxCxCt.ct_IdEmpresa, InfoCxCxCt.ct_IdTipoCbte, InfoCxCxCt.ct_IdCbteCble, ref MensajeError);
                        foreach (ct_Cbtecble_det_Info item in lstCbteCble_det)
                        {
                            if (item.dc_Valor > 0)
                                IdCtaCbleDeudora = item.IdCtaCble;
                        }
                    }
                    else
                    {
                        return new List<ct_Cbtecble_det_Info>();
                    }
                }
                ////////////////////////////////////////////////////////////////////////////

                CajaInfo = BusCaja.Get_Info_Caja(param.IdEmpresa, Info.IdCaja, ref  MensajeError);
                // se va a caer si no existe la caja o  la cuenta contable asignada a esa caja
                if (CajaInfo == null || CajaInfo.IdCtaCble == null)
                    return new List<ct_Cbtecble_det_Info>();

                // si no hay cxc en el cliente se toma de los parametros :InfocxcTipo
                InfocxcTipo = dat.Get_Info_cobro_tipo_Param_conta_x_sucursal(Info.IdEmpresa, Info.IdSucursal, Info.IdCobro_tipo);
                ///////////////////////////

                fa_Cliente_Bus bus = new fa_Cliente_Bus();
                fa_Cliente_Info InfoCliente = new fa_Cliente_Info();

                InfoCliente = bus.Get_Info_Cliente(Info.IdEmpresa, Info.IdCliente);

                /// CUENTA ACREEDORA 
                //Obtiene cuenta acredora si cliente no la tiene

                if (Info.cr_es_anticipo == "N" || Info.cr_es_anticipo == "" || Info.cr_es_anticipo == null)
                {
                    if (InfoCliente.IdCtaCble_cxc == null || InfoCliente.IdCtaCble_cxc == "")
                    {
                        throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "El Cliente no tiene cta cble cxc")) { EntityType = typeof(cxc_cobro_Bus) };
                    }
                }
                else //por anticipo 
                {
                    if (InfoCliente.IdCtaCble_Anti == null || InfoCliente.IdCtaCble_Anti == "")
                    {
                        if (InfocxcTipo.IdCtaCble_Anticipo != null || InfocxcTipo.IdCtaCble_Anticipo != "")
                        {
                            InfoCliente.IdCtaCble_Anti = InfocxcTipo.IdCtaCble_Anticipo;
                        }
                    }
                }
                /// FIN CUENTA ACREEDORA 

                // INSERTANDO LINEA DEUDORA //
                ct_Cbtecble_det_Info dte = new ct_Cbtecble_det_Info();

                dte.IdEmpresa = Info.IdEmpresa;


                if (tomarCtaCble == "CAJA")
                {
                    // ENVIARLO A LA CUENTA DE CAJA CASO CONTRARIO ENVIAR A DE PARAMETROS POR SUCURSAL X TIPO: cxc_cobro_tipo_Param_conta_x_sucursal
                    dte.IdCtaCble = (CajaInfo.IdCtaCble == "" || CajaInfo.IdCtaCble == null) ? InfocxcTipo.IdCtaCble : CajaInfo.IdCtaCble;
                }
                else
                {
                    dte.IdCtaCble = (InfocxcTipo.IdCtaCble == "" || InfocxcTipo.IdCtaCble == null) ? CajaInfo.IdCtaCble : InfocxcTipo.IdCtaCble;
                }


                dte.IdTipoCbte = _CbteCbleInfo.IdTipoCbte;

                if (param.IdCliente_Ven_x_Default == Cl_Enumeradores.eCliente_Vzen.EDEHSA)
                {
                    BusDetCobro = new cxc_cobro_Det_Bus();
                    DetCobro = BusDetCobro.Get_List_Cobro_detalle(param.IdEmpresa, Info.IdSucursal, Info.IdCobro);

                    if (DetCobro.Count() > 0)
                    {
                        foreach (var item in DetCobro)
                        {
                            dte.IdCentroCosto = item.IdCentroCosto;
                        }
                    }
                    else
                    {
                        if (Info.cr_es_anticipo == "S")
                        {
                            Lista_cobro_x_anticipo = Bus_cxc_cobro_x_Anti.Get_List_cobro_x_Anticipo_det(Info.IdEmpresa, Info.IdSucursal, Info.IdCobro, ref MensajeError);

                            if (Lista_cobro_x_anticipo.Count() > 0)
                            {
                                foreach (var item in Lista_cobro_x_anticipo)
                                {
                                    dte.IdCentroCosto = item.IdCentroCosto;
                                }
                            }
                            else
                            {
                                dte.IdCentroCosto = null; // o se puede enviar un centro de costo por default por ahora se envia null
                            }
                        }
                    }
                }

                dte.secuencia = 1;
                dte.dc_Observacion = Info.cr_observacion.Trim() + "CXC  " + InfocxcTipo.IdCobro_tipo + " /" + InfoCliente.Persona_Info.pe_apellido + ' ' + InfoCliente.Persona_Info.pe_apellido + " " + InfoCliente.Persona_Info.pe_razonSocial
                    + " Cbr#" + Info.IdCobro.ToString();
                dte.dc_Valor = Math.Round(_CbteCbleInfo.cb_Valor, 2); // debe 
                Listadte.Add(dte);
                // fIN INSERTANDO LINEA DEUDORA //

                List<ct_Cbtecble_det_Info> DetCbte_cble = new List<ct_Cbtecble_det_Info>();
                BusDetCobro = new cxc_cobro_Det_Bus();
                DetCobro = BusDetCobro.Get_List_Cobro_detalle(param.IdEmpresa, Info.IdSucursal, Info.IdCobro);

                string IdCentroCosto = null;

                double saldo_pendte = 0;
                foreach (var item in DetCobro)
                {
                    saldo_pendte = saldo_pendte + item.dc_ValorPago;
                }

                saldo_pendte = Math.Round(dte.dc_Valor, 2) - Math.Round(saldo_pendte, 2);
                int cont = 1;

                if (DetCobro.Count() > 0)
                {
                    foreach (var item in DetCobro)
                    {
                        cont = cont + 1;
                        // INSERTANDO LINEA CREDITO // cxc
                        dte = new ct_Cbtecble_det_Info();
                        // si es normal tomar la cxc si es anticipo tomar cxc_anticipo
                        if (Cl_Enumeradores.PantallaEjecucion.TARJETA == _Accion)
                            dte.IdCtaCble = IdCtaCbleDeudora;
                        else
                            dte.IdCtaCble = (Info.cr_es_anticipo == "S") ? InfoCliente.IdCtaCble_Anti : InfoCliente.IdCtaCble_cxc;

                        dte.IdEmpresa = Info.IdEmpresa;
                        dte.IdCentroCosto = item.IdCentroCosto;
                        dte.IdTipoCbte = _CbteCbleInfo.IdTipoCbte;
                        dte.secuencia = cont;
                        dte.dc_Observacion = Info.cr_observacion.Trim() + " Cbr# " + item.IdCobro + " x " + item.IdCobro_tipo + " Sec:" + item.secuencial + " a " + InfoCliente.Nombre_Cliente + " x " + item.Documento_Cobrado;
                        dte.dc_Valor = Math.Round(item.dc_ValorPago, 2) * -1; // CREDITO tomarlo del l a consulat dc_valorPago

                        dte.Info_cobro_det = item;
                        Listadte.Add(dte);

                        // guardando el detalle del cobro x cbte contable
                        // fIN INSERTANDO LINEA DEUDORA //
                    }
                }
                else
                {
                    if (Info.cr_es_anticipo == "S")
                    {
                        Lista_cobro_x_anticipo = Bus_cxc_cobro_x_Anti.Get_List_cobro_x_Anticipo_det(Info.IdEmpresa, Info.IdSucursal, Info.IdCobro, ref MensajeError);

                        if (Lista_cobro_x_anticipo.Count() > 0)
                        {
                            foreach (var item in Lista_cobro_x_anticipo)
                            {
                                IdCentroCosto = item.IdCentroCosto;
                            }
                        }
                        else
                        {
                            IdCentroCosto = null; // o se puede enviar un centro de costo por default por ahora se envia null
                        }
                    }
                }

                if (saldo_pendte != 0)
                {
                    fa_parametro_Bus busParamFac = new fa_parametro_Bus();
                    fa_parametro_info Parm = busParamFac.Get_Info_parametro(param.IdEmpresa);

                    dte = new ct_Cbtecble_det_Info();

                    if (InfocxcTipo.IdCtaCble_Anticipo == "" || InfocxcTipo.IdCtaCble_Anticipo == null)
                    {
                        if (!String.IsNullOrEmpty(InfoCliente.IdCtaCble_Anti))
                            dte.IdCtaCble = InfoCliente.IdCtaCble_Anti; ////   cambio por cuenta x anticipo 
                        else
                            dte.IdCtaCble = Parm.IdCtaCble_x_anticipo_cliente; ////   cambio por cuenta x anticipo de parametros
                    }
                    else
                    {
                        dte.IdCtaCble = (InfocxcTipo.IdCtaCble_Anticipo == "" || InfocxcTipo.IdCtaCble_Anticipo == null) ? Parm.IdCtaCble_x_anticipo_cliente : InfocxcTipo.IdCtaCble_Anticipo;
                    }

                    dte.IdEmpresa = Info.IdEmpresa;
                    dte.IdTipoCbte = _CbteCbleInfo.IdTipoCbte;
                    dte.secuencia = cont + 1;
                    dte.dc_Observacion = "Cbr# " + Info.IdCobro.ToString() + " cliente : " + InfoCliente.Persona_Info.pe_nombre + " "
                        + InfoCliente.Persona_Info.pe_apellido + " en " + Info.IdCobro_tipo + " saldo x Anticipo ";
                    dte.dc_Valor = saldo_pendte * -1; // CREDITO tomarlo del la consulat dc_valorPago
                    dte.IdCentroCosto = IdCentroCosto;
                    Listadte.Add(dte);
                }

                return Listadte;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CbteCble_det", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public Boolean Registra_Contabiliza_Deposito_x_Cobro(int IdEmpresa, int IdTipocbte_Caja, decimal IdCbteCble_Caja, string IdCobro_tipo, ref string msg)
        {
            Boolean res = false;
            try
            {
                string tomarCtaCble = "";
                string IdCtaCble_Acreedora = "";

                caj_Caja_Movimiento_Bus BusCaja = new caj_Caja_Movimiento_Bus();
                vwcaj_MovCaja_x_Cobro_Anticipo_Bus MovCajaAniciBus = new vwcaj_MovCaja_x_Cobro_Anticipo_Bus();
                List<vwcaj_MovCaja_x_Cobro_Anticipo_Info> listMovCajaAniciInfo = new List<vwcaj_MovCaja_x_Cobro_Anticipo_Info>();
                List<vwcaj_MovCaja_x_Cobro_Info> ListMovCaja = new List<vwcaj_MovCaja_x_Cobro_Info>();
                ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus BcoTipoCbte = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();

                //// para ver de donde tomo la cuenta s de la caja o del tipo de documento
                var tipoCobro = from q in ListaCobrotipo
                                where q.IdCobro_tipo == IdCobro_tipo
                                select q.tc_Tomar_Cta_Cble_De;

                foreach (var item in tipoCobro)
                {
                    tomarCtaCble = item;
                }

                ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info TipoCbteDepo = BcoTipoCbte.Get_List_Cbte_Ban_tipo_x_ct_CbteCble_tipo(param.IdEmpresa).
                    First(q => q.CodTipoCbteBan == IdCobro_tipo);

                ct_Cbtecble_Bus busCbte = new ct_Cbtecble_Bus();

                switch (_Accion)
                {
                    case Cl_Enumeradores.PantallaEjecucion.ANTICIPOS:
                        ListMovCaja = BusCaja.Get_list_MovimientosCaja_x_Cobro_Anticipo(IdEmpresa, IdTipocbte_Caja, IdCbteCble_Caja, ref  MensajeError);
                        break;
                    case Cl_Enumeradores.PantallaEjecucion.COBROS:
                        ListMovCaja = BusCaja.Get_list_MovimientosCaja_x_Cobro(IdEmpresa, IdTipocbte_Caja, IdCbteCble_Caja, ref  MensajeError);
                        break;

                    case Cl_Enumeradores.PantallaEjecucion.TARJETA:
                        ListMovCaja = BusCaja.Get_list_MovimientosCaja_x_Cobro(IdEmpresa, IdTipocbte_Caja, IdCbteCble_Caja, ref  MensajeError);
                        break;
                }

                //CONSULTAMOS EL CENTRO DE COSTO
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.EDEHSA:
                        foreach (var item in ListMovCaja)
                        {
                            List<cxc_cobro_Det_Info> ListCobro_det = new List<cxc_cobro_Det_Info>();

                            //OBTENEMOS EL CENTRO DE COSTO DEL DETALLE DEL COBRO
                            ListCobro_det = bus_det.Get_List_Cobro_detalle(item.IdEmpresa, param.IdSucursal, item.IdCobro);

                            foreach (var item2 in ListCobro_det)
                            {
                                if (item2.IdCentroCosto != null)
                                    if (item.dc_ValorPago == item2.dc_ValorPago)
                                        item.IdCentroCosto = item2.IdCentroCosto;
                            }
                        }

                        break;
                }

                if (ListMovCaja != null && ListMovCaja.Count > 0)
                {
                    vwcaj_MovCaja_x_Cobro_Info mov = new vwcaj_MovCaja_x_Cobro_Info();

                    // obtengo un movimiento para llenar la cab de cbte cble
                    mov = (vwcaj_MovCaja_x_Cobro_Info)ListMovCaja.First();

                    if (tomarCtaCble == "CAJA")
                    {
                        IdCtaCble_Acreedora = mov.IdCtaCble_Caja;
                    }
                    else
                    {
                        IdCtaCble_Acreedora = (mov.IdCtaCble_TipoCobro == null) ? mov.IdCtaCble_Caja : mov.IdCtaCble_TipoCobro;
                    }


                    double valorAnt = 0;
                    valorAnt = mov.cr_TotalCobro - ListMovCaja.Sum(q => q.dc_ValorPago);
                    string MensajeError = "";

                    ///Armo la cabecera del comprobante del deposito para guardarla
                    List<ct_Cbtecble_det_Info> detalleCbte = new List<ct_Cbtecble_det_Info>();
                    ct_Cbtecble_Info cbtecble_I = new ct_Cbtecble_Info();
                    cbtecble_I.IdEmpresa = param.IdEmpresa;
                    cbtecble_I.IdTipoCbte = TipoCbteDepo.IdTipoCbteCble;
                    cbtecble_I.IdPeriodo = mov.IdPeriodo_Caja;
                    cbtecble_I.CodCbteCble = IdCobro_tipo + " " + Convert.ToString(busCbte.Get_IdCbteCble(param.IdEmpresa, TipoCbteDepo.IdTipoCbteCble, ref MensajeError));
                    cbtecble_I.IdUsuario = param.IdUsuario;
                    cbtecble_I.cb_Fecha = mov.cr_fechaDocu;
                    cbtecble_I.Estado = "A";
                    cbtecble_I.Mayorizado = "N";
                    cbtecble_I.cb_Valor = mov.cr_TotalCobro;

                    ///Armo los detalles del comprobante del deposito para guardarlos
                    ///

                    ///debe
                    ///
                    ct_Cbtecble_det_Info debe = new ct_Cbtecble_det_Info();
                    debe.IdEmpresa = param.IdEmpresa;
                    debe.IdTipoCbte = TipoCbteDepo.IdTipoCbteCble;
                    debe.secuencia = 1;
                    debe.IdCtaCble = mov.IdCtaCble_ban;
                    debe.IdCentroCosto = (mov.IdCentroCosto != null) ? mov.IdCentroCosto : null;
                    debe.IdCentroCosto_sub_centro_costo = null;
                    debe.dc_Valor = mov.cr_TotalCobro;
                    debe.dc_para_conciliar = true;

                    ///haber
                    ///
                    ct_Cbtecble_det_Info haber = new ct_Cbtecble_det_Info();
                    haber.IdEmpresa = param.IdEmpresa;
                    haber.IdTipoCbte = TipoCbteDepo.IdTipoCbteCble;
                    haber.secuencia = 2;
                    haber.IdCtaCble = IdCtaCble_Acreedora;

                    haber.IdCentroCosto = (mov.IdCentroCosto != null) ? mov.IdCentroCosto : null;
                    haber.IdCentroCosto_sub_centro_costo = null;

                    //switch (param.IdCliente_Ven_x_Default)
                    //{

                    //    case Cl_Enumeradores.eCliente_Vzen.EDEHSA:
                    //        haber.IdCentroCosto =  null;
                    //        haber.IdCentroCosto_sub_centro_costo = null;
                    //        break;
                    //    default:
                    //        haber.IdCentroCosto = (mov.IdCentroCosto != null) ? mov.IdCentroCosto : null;
                    //        haber.IdCentroCosto_sub_centro_costo = null;

                    //        break;
                    //}



                    haber.dc_Valor = mov.cr_TotalCobro * -1;


                    string Documentos = "";
                    foreach (var item in ListMovCaja)
                    {
                        Documentos = Documentos + item.Documento_Cobrado;
                    }

                    if (IdCobro_tipo == "NCBA")
                    {
                        cbtecble_I.cb_Observacion = debe.dc_Observacion = haber.dc_Observacion =
                            "Nota Cred. Banca. NºComp " + mov.cr_NumDocumento + " x Cbr" + mov.IdCobro + "/" + mov.IdCobro_tipo +
                            " a " + mov.nCliente + " x " + Documentos +
                            mov.Documento_Cobrado + " Suc:" + mov.nSucursal;
                    }
                    else
                    {
                        cbtecble_I.cb_Observacion = debe.dc_Observacion = haber.dc_Observacion =
                            "Dep NºComp " + mov.cr_NumDocumento + " x Cbr" + mov.IdCobro + "/" + mov.IdCobro_tipo +
                            " a " + mov.nCliente + " x " + Documentos +
                            mov.Documento_Cobrado + " Suc:" + mov.nSucursal;
                    }

                    Documentos = cbtecble_I.cb_Observacion;

                    detalleCbte.Add(debe);
                    detalleCbte.Add(haber);
                    cbtecble_I._cbteCble_det_lista_info = new List<ct_Cbtecble_det_Info>();
                    cbtecble_I._cbteCble_det_lista_info = detalleCbte;

                    /// variables para completar el comprobante bancario
                    /// 
                    decimal IdCbteCble_Bco = 0; string CodCbteCble_Bco = "";

                    if (busCbte.GrabarDB(cbtecble_I, ref IdCbteCble_Bco, ref msg))
                    {
                        ba_Cbte_Ban_Info CbteBan_I = new ba_Cbte_Ban_Info();
                        ba_Cbte_Ban_Bus BusCBan = new ba_Cbte_Ban_Bus();

                        CbteBan_I.IdEmpresa = param.IdEmpresa;
                        CbteBan_I.IdCbteCble = IdCbteCble_Bco;
                        CbteBan_I.IdTipocbte = cbtecble_I.IdTipoCbte;
                        CbteBan_I.Cod_Cbtecble = string.IsNullOrEmpty(CodCbteCble_Bco) ? IdCobro_tipo + " " + IdCbteCble_Bco : CodCbteCble_Bco;
                        CbteBan_I.IdPeriodo = cbtecble_I.IdPeriodo;
                        CbteBan_I.IdBanco = Convert.ToInt32(mov.IdBanco);
                        CbteBan_I.cb_Fecha = cbtecble_I.cb_Fecha;
                        CbteBan_I.cb_Observacion = cbtecble_I.cb_Observacion;
                        CbteBan_I.cb_Valor = mov.cr_TotalCobro;
                        CbteBan_I.cb_ChequeImpreso = "N";
                        CbteBan_I.Estado = "A";
                        CbteBan_I.IdUsuario = param.IdUsuario;
                        CbteBan_I.Fecha_Transac = param.Fecha_Transac;
                        CbteBan_I.nom_pc = param.nom_pc;
                        CbteBan_I.ip = param.ip;

                        if (BusCBan.GrabarDB(CbteBan_I, ref MensajeError))
                        {
                            ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus BusTI = new ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus();
                            caj_Caja_Movimiento_det_Bus BusCaj_movi_Det = new caj_Caja_Movimiento_det_Bus();
                            List<caj_Caja_Movimiento_det_Info> list_Det_caja = new List<caj_Caja_Movimiento_det_Info>();

                            list_Det_caja = BusCaj_movi_Det.Get_listDetalle(IdEmpresa, IdCbteCble_Caja, IdTipocbte_Caja, ref  MensajeError);

                            foreach (var item in list_Det_caja)// recorriendo el detalle de caja
                            {
                                ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info TI = new ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info();
                                TI.mcj_IdEmpresa = item.IdEmpresa;
                                TI.mcj_IdCbteCble = item.IdCbteCble;
                                TI.mcj_IdTipocbte = item.IdTipocbte;
                                TI.mcj_Secuencia = item.Secuencia;
                                //cbte bancario
                                TI.mba_IdEmpresa = param.IdEmpresa;
                                TI.mba_IdCbteCble = IdCbteCble_Bco;
                                TI.mba_IdTipocbte = cbtecble_I.IdTipoCbte;

                                if (BusTI.GrabarDB(TI))
                                    res = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Registra_Contabiliza_Deposito_x_Cobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };

            } return res;

        }

        public Boolean Registra_Contabiliza_Debito_Bancario_x_Cobro(int IdEmpresa, int IdTipocbte_Caja, decimal IdCbteCble_Caja, ref string msg)
        {
            Boolean res = false;
            try
            {
                caj_Caja_Movimiento_Bus BusCaja = new caj_Caja_Movimiento_Bus();
                vwcaj_MovCaja_x_Cobro_Anticipo_Bus MovCajaAniciBus = new vwcaj_MovCaja_x_Cobro_Anticipo_Bus();
                List<vwcaj_MovCaja_x_Cobro_Anticipo_Info> listMovCajaAniciInfo = new List<vwcaj_MovCaja_x_Cobro_Anticipo_Info>();
                List<vwcaj_MovCaja_x_Cobro_Info> ListMovCaja = new List<vwcaj_MovCaja_x_Cobro_Info>();
                ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus BcoTipoCbte = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();
                ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info TipoCbteDepo = BcoTipoCbte.Get_List_Cbte_Ban_tipo_x_ct_CbteCble_tipo(param.IdEmpresa).
                    First(q => q.CodTipoCbteBan == "NDBA");

                ct_Cbtecble_Bus busCbte = new ct_Cbtecble_Bus();

                switch (_Accion)
                {
                    case Cl_Enumeradores.PantallaEjecucion.ANTICIPOS:
                        ListMovCaja = BusCaja.Get_list_MovimientosCaja_x_Cobro_Anticipo(IdEmpresa, IdTipocbte_Caja, IdCbteCble_Caja, ref  MensajeError);
                        break;
                    case Cl_Enumeradores.PantallaEjecucion.COBROS:
                        ListMovCaja = BusCaja.Get_list_MovimientosCaja_x_Cobro(IdEmpresa, IdTipocbte_Caja, IdCbteCble_Caja, ref  MensajeError);
                        break;
                    case Cl_Enumeradores.PantallaEjecucion.TARJETA:
                        ListMovCaja = BusCaja.Get_list_MovimientosCaja_x_Cobro(IdEmpresa, IdTipocbte_Caja, IdCbteCble_Caja, ref  MensajeError);
                        break;
                }



                if (ListMovCaja != null)
                {
                    vwcaj_MovCaja_x_Cobro_Info mov = new vwcaj_MovCaja_x_Cobro_Info();

                    // obtengo un movimiento para llenar la cab de cbte cble
                    mov = (vwcaj_MovCaja_x_Cobro_Info)ListMovCaja.First();

                    double valorAnt = 0;
                    valorAnt = mov.cr_TotalCobro - ListMovCaja.Sum(q => q.dc_ValorPago);
                    string MensajeError = "";

                    ///Armo la cabecera del comprobante del deposito para guardarla
                    List<ct_Cbtecble_det_Info> detalleCbte = new List<ct_Cbtecble_det_Info>();
                    ct_Cbtecble_Info cbtecble_I = new ct_Cbtecble_Info();
                    cbtecble_I.IdEmpresa = param.IdEmpresa;
                    cbtecble_I.IdTipoCbte = TipoCbteDepo.IdTipoCbteCble;
                    cbtecble_I.IdPeriodo = mov.IdPeriodo_Caja;
                    cbtecble_I.CodCbteCble = "NDBA " + Convert.ToString(busCbte.Get_IdCbteCble(param.IdEmpresa, TipoCbteDepo.IdTipoCbteCble, ref MensajeError));
                    cbtecble_I.IdUsuario = param.IdUsuario;
                    cbtecble_I.cb_Fecha = mov.cr_fechaDocu;
                    cbtecble_I.Estado = "A";
                    cbtecble_I.Mayorizado = "N";
                    cbtecble_I.cb_Valor = mov.cr_TotalCobro;



                    ///Armo los detalles del comprobante del deposito para guardarlos
                    ///

                    ///debe
                    ///
                    ct_Cbtecble_det_Info debe = new ct_Cbtecble_det_Info();
                    debe.IdEmpresa = param.IdEmpresa;
                    debe.IdTipoCbte = TipoCbteDepo.IdTipoCbteCble;
                    debe.secuencia = 1;
                    debe.IdCtaCble = mov.IdCtaCble_ban;
                    debe.IdCentroCosto = null;
                    debe.IdCentroCosto_sub_centro_costo = null;
                    debe.dc_Valor = mov.cr_TotalCobro;

                    ///haber
                    ///
                    ct_Cbtecble_det_Info haber = new ct_Cbtecble_det_Info();
                    haber.IdEmpresa = param.IdEmpresa;
                    haber.IdTipoCbte = TipoCbteDepo.IdTipoCbteCble;
                    haber.secuencia = 2;
                    haber.IdCtaCble = mov.IdCtaCble_TipoCobro;
                    haber.IdCentroCosto = null;
                    haber.IdCentroCosto_sub_centro_costo = null;
                    haber.dc_Valor = mov.cr_TotalCobro * -1;


                    string Documentos = "";
                    foreach (var item in ListMovCaja)
                    {
                        Documentos = Documentos + item.Documento_Cobrado;
                    }

                    cbtecble_I.cb_Observacion = debe.dc_Observacion = haber.dc_Observacion =
                        "Dep NºComp " + mov.cr_NumDocumento + " x Cbr" + mov.IdCobro + "/" + mov.IdCobro_tipo +
                        " a " + mov.nCliente + " x " + Documentos +
                        mov.Documento_Cobrado + " Suc:" + mov.nSucursal;

                    Documentos = cbtecble_I.cb_Observacion;

                    detalleCbte.Add(debe);
                    detalleCbte.Add(haber);
                    cbtecble_I._cbteCble_det_lista_info = new List<ct_Cbtecble_det_Info>();
                    cbtecble_I._cbteCble_det_lista_info = detalleCbte;


                }

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Registra_Contabiliza_Debito_Bancario_x_Cobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            } return res;

        }

        public Boolean Registra_Contabiliza_MovCaja_x_Cobro_enDeposito(List<caj_Caja_Movimiento_Info> LstMovCaja, int idBanco, DateTime FechaDep, ref string msg)
        {
            Boolean res = false;
            try
            {
                caj_Caja_Movimiento_Bus BusCaja = new caj_Caja_Movimiento_Bus();
                List<vwcaj_MovCaja_x_Cobro_Info> ListMovCaja = new List<vwcaj_MovCaja_x_Cobro_Info>();
                ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus BcoTipoCbte = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();
                ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info TipoCbteDepo = BcoTipoCbte.Get_List_Cbte_Ban_tipo_x_ct_CbteCble_tipo(param.IdEmpresa).
                    First(q => q.CodTipoCbteBan == "DEPO");
                ct_Cbtecble_Bus busCbte = new ct_Cbtecble_Bus();

                foreach (caj_Caja_Movimiento_Info item in LstMovCaja)
                {
                    List<vwcaj_MovCaja_x_Cobro_Info> listado = BusCaja.Get_list_MovimientosCaja_x_Cobro(item.IdEmpresa, item.IdTipocbte, item.IdCbteCble, ref  MensajeError);
                    ListMovCaja.AddRange(listado);

                }

                //armo el haber del detalle del comprobante contable
                List<ct_Cbtecble_det_Info> detalleCbteHaber = new List<ct_Cbtecble_det_Info>();
                foreach (caj_Caja_Movimiento_Info det in LstMovCaja)
                {
                    foreach (vwcaj_MovCaja_x_Cobro_Info cab in ListMovCaja)
                    {
                        if (det.IdEmpresa == cab.IdEmpresa && det.IdCbteCble == cab.IdCbteCble && det.IdTipocbte == cab.IdTipocbte)
                        { ///haber
                            ///
                            ct_Cbtecble_det_Info haber = new ct_Cbtecble_det_Info();
                            haber.IdEmpresa = param.IdEmpresa;
                            haber.IdTipoCbte = TipoCbteDepo.IdTipoCbteCble;
                            haber.IdCtaCble = cab.IdCtaCble_TipoCobro;
                            haber.IdCentroCosto = null;
                            haber.IdCentroCosto_sub_centro_costo = null;
                            haber.dc_Observacion = "Dep NºComp " + cab.cr_NumDocumento + " x Cbr" + cab.IdCobro + "/" + cab.IdCobro_tipo +
                            " a " + cab.nCliente + " x " + cab.Documento_Cobrado + " Suc:" + cab.nSucursal;
                            haber.dc_Valor = cab.cm_valor * -1;
                            detalleCbteHaber.Add(haber);
                            break;
                        }
                    }
                }

                if (ListMovCaja != null)
                {

                    double valorTotal = 0;
                    valorTotal = detalleCbteHaber.Sum(q => q.dc_Valor) * -1;
                    string MensajeError = "";
                    ///Armo la cabecera del comprobante del deposito para guardarla
                    ct_Periodo_Bus busPeriodo = new ct_Periodo_Bus();
                    ct_Periodo_Info periodo = busPeriodo.Get_Info_Periodo(param.IdEmpresa, FechaDep, ref MensajeError);


                    ct_Cbtecble_Info cbtecble_I = new ct_Cbtecble_Info();
                    cbtecble_I.IdEmpresa = param.IdEmpresa;
                    cbtecble_I.IdTipoCbte = TipoCbteDepo.IdTipoCbteCble;
                    cbtecble_I.IdPeriodo = periodo.IdPeriodo;
                    cbtecble_I.CodCbteCble = "DEPO " + Convert.ToString(busCbte.Get_IdCbteCble(param.IdEmpresa, TipoCbteDepo.IdTipoCbteCble, ref msg));
                    cbtecble_I.IdUsuario = param.IdUsuario;
                    cbtecble_I.cb_Fecha = FechaDep;
                    cbtecble_I.Estado = "A";
                    cbtecble_I.Mayorizado = "N";
                    cbtecble_I.cb_Valor = valorTotal * -1;

                    //Obtengo el Info del Banco
                    ba_Banco_Cuenta_Bus BusBanco = new ba_Banco_Cuenta_Bus();
                    ba_Banco_Cuenta_Info banco = BusBanco.Get_Info_Banco_Cuenta(param.IdEmpresa, idBanco);

                    ///Armo el detalle del comprobante del deposito para guardarlos
                    ///

                    ///debe
                    ///
                    ct_Cbtecble_det_Info debe = new ct_Cbtecble_det_Info();
                    debe.IdEmpresa = param.IdEmpresa;
                    debe.IdTipoCbte = TipoCbteDepo.IdTipoCbteCble;
                    debe.IdCtaCble = banco.IdCtaCble;
                    debe.IdCentroCosto = null;
                    debe.IdCentroCosto_sub_centro_costo = null;
                    debe.dc_Valor = valorTotal * -1;


                    cbtecble_I.cb_Observacion = debe.dc_Observacion =
                        "Depósito generado automaticamente";

                    cbtecble_I._cbteCble_det_lista_info = new List<ct_Cbtecble_det_Info>();

                    cbtecble_I._cbteCble_det_lista_info.Add(debe);
                    cbtecble_I._cbteCble_det_lista_info.AddRange(detalleCbteHaber);

                    int i = 1;
                    cbtecble_I._cbteCble_det_lista_info.ForEach(p => p.secuencia = i++);

                    /// variables para completar el comprobante bancario
                    /// 
                    decimal IdCbteCble_Bco = 0; string CodCbteCble_Bco = "";

                    if (busCbte.GrabarDB(cbtecble_I, ref IdCbteCble_Bco, ref msg))
                    {
                        ba_Cbte_Ban_Info CbteBan_I = new ba_Cbte_Ban_Info();
                        ba_Cbte_Ban_Bus BusCBan = new ba_Cbte_Ban_Bus();

                        CbteBan_I.IdEmpresa = param.IdEmpresa;
                        CbteBan_I.IdCbteCble = IdCbteCble_Bco;
                        CbteBan_I.IdTipocbte = cbtecble_I.IdTipoCbte;
                        CbteBan_I.Cod_Cbtecble = string.IsNullOrEmpty(CodCbteCble_Bco) ? "DEPO " + IdCbteCble_Bco : CodCbteCble_Bco;
                        CbteBan_I.IdPeriodo = cbtecble_I.IdPeriodo;
                        CbteBan_I.IdBanco = Convert.ToInt32(idBanco);
                        CbteBan_I.cb_Fecha = cbtecble_I.cb_Fecha;
                        CbteBan_I.cb_Observacion = cbtecble_I.cb_Observacion;
                        CbteBan_I.cb_Valor = valorTotal;
                        CbteBan_I.cb_ChequeImpreso = "N";
                        CbteBan_I.Estado = "A";
                        CbteBan_I.IdUsuario = param.IdUsuario;
                        CbteBan_I.Fecha_Transac = param.Fecha_Transac;
                        CbteBan_I.nom_pc = param.nom_pc;
                        CbteBan_I.ip = param.ip;

                        foreach (var item in LstMovCaja)
                        {
                            if (BusCBan.GrabarDB(CbteBan_I, ref MensajeError))
                            {
                                ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus BusTI = new ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus();

                                if (BusTI.GrabarListadoMovCaja_x_Deposito(LstMovCaja, cbtecble_I.IdTipoCbte, IdCbteCble_Bco))
                                    res = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Registra_Contabiliza_MovCaja_x_Cobro_enDeposito", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            } return res;
        }

        public void GeneraCbteCtblANULACION(cxc_cobro_Info Info)
        {
            try
            {
                cxc_cobro_x_ct_cbtecble_Info InfoCOxCT = new cxc_cobro_x_ct_cbtecble_Info();
                cxc_cobro_x_ct_cbtecble_Data DataCOxCT = new cxc_cobro_x_ct_cbtecble_Data();
                ct_Cbtecble_Bus bus = new ct_Cbtecble_Bus();
                InfoCOxCT = DataCOxCT.Get_Info_cobro_x_ct_cbtecble(param.IdEmpresa, Info.IdSucursal, Info.IdCobro);
                string msg = "";
                bus.ReversoCbteCble(param.IdEmpresa, InfoCOxCT.ct_IdCbteCble, InfoCOxCT.ct_IdTipoCbte, Convert.ToInt32(infoCaja.IdTipoCbteCble_MoviCaja_Ing_Anu), ref idctctb, ref msg, param.IdUsuario);
                //insertar en la tabla cxc_cobro_x_ct_cbtecble_x_Anulado para obtener el registro de anulación
                InfoAnulado = new cxc_cobro_x_ct_cbtecble_Info();
                InfoAnulado.cbr_IdEmpresa = Info.IdEmpresa;
                InfoAnulado.cbr_IdSucursal = Info.IdSucursal;
                InfoAnulado.cbr_IdCobro = Info.IdCobro;
                InfoAnulado.ct_IdEmpresa = param.IdEmpresa;
                InfoAnulado.ct_IdTipoCbte = Convert.ToInt32(infoCaja.IdTipoCbteCble_MoviCaja_Ing_Anu);
                InfoAnulado.ct_IdCbteCble = idctctb;
                cxc_cobro_x_ct_cbtecble_Data dataAnulado = new cxc_cobro_x_ct_cbtecble_Data();
                dataAnulado.GuardarCbr_x_Cbte_Reverso(InfoAnulado);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GeneraCbteCtblANULACION", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public void GeneraCbteCtblANULACIONSOLODIARIO(cxc_cobro_Info Info)
        {
            try
            {
                cxc_cobro_x_ct_cbtecble_Info InfoCOxCT = new cxc_cobro_x_ct_cbtecble_Info();
                cxc_cobro_x_ct_cbtecble_Data DataCOxCT = new cxc_cobro_x_ct_cbtecble_Data();
                ct_Cbtecble_Bus bus = new ct_Cbtecble_Bus();
                idctctb = 0;

                InfoCOxCT = DataCOxCT.Get_Info_cobro_x_ct_cbtecble(param.IdEmpresa, Info.IdSucursal, Info.IdCobro);
                string msg = "";

                bus.ReversoCbteCble_Edehsa(param.IdEmpresa, InfoCOxCT.ct_IdCbteCble, InfoCOxCT.ct_IdTipoCbte, Convert.ToInt32(paramInfo.pa_IdTipoCbteCble_CxC_ANU), Convert.ToDateTime(Info.Fecha_Anulac), ref idctctb, ref msg, param.IdUsuario);

                if (idctctb != 0)
                {
                    //insertar en la tabla cxc_cobro_x_ct_cbtecble_x_Anulado para obtener el registro de anulación
                    InfoAnulado = new cxc_cobro_x_ct_cbtecble_Info();
                    InfoAnulado.cbr_IdEmpresa = Info.IdEmpresa;
                    InfoAnulado.cbr_IdSucursal = Info.IdSucursal;
                    InfoAnulado.cbr_IdCobro = Info.IdCobro;
                    InfoAnulado.ct_IdEmpresa = param.IdEmpresa;
                    InfoAnulado.ct_IdTipoCbte = Convert.ToInt32(paramInfo.pa_IdTipoCbteCble_CxC_ANU);
                    InfoAnulado.ct_IdCbteCble = idctctb;
                    cxc_cobro_x_ct_cbtecble_Data dataAnulado = new cxc_cobro_x_ct_cbtecble_Data();
                    dataAnulado.GuardarCbr_x_Cbte_Reverso(InfoAnulado);
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GeneraCbteCtblANULACIONSOLODIARIO", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public Boolean ModificarDB(cxc_cobro_Info Info, Cl_Enumeradores.PantallaEjecucion Accion)
        {
            try
            {
                string msg = "";
                Boolean retu = false;
                _Accion = Accion;

                if (validar_objeto(Info, ref msg) == true)
                {
                    retu = data.ModificarDB(Info);
                    if (retu)
                    {
                        if (Info.ListaCobro != null && Info.ListaCobro.Count > 0)
                            Info.ListaCobro.ForEach(var => var.IdCobro = Info.IdCobro);
                        cxc_cobro_Det_Bus BusDet_cobro = new cxc_cobro_Det_Bus();
                        retu = BusDet_cobro.ModificarDetalleCobro(Info.ListaCobro);

                        cxc_cobro_x_caj_Caja_Movimiento_Bus BusCobro_caja = new cxc_cobro_x_caj_Caja_Movimiento_Bus();
                        cxc_cobro_x_caj_Caja_Movimiento_Info InfoCobro_x_caj_movi = new cxc_cobro_x_caj_Caja_Movimiento_Info();

                        InfoCobro_x_caj_movi = BusCobro_caja.Get_Info_cobro_x_caj_Caja_Movimiento(Info.IdEmpresa, Info.IdSucursal, Info.IdCobro);

                        if (InfoCobro_x_caj_movi.cbr_IdCobro == 0)
                        {
                            retu = Contabilizar(Info.IdEmpresa, Info.IdSucursal, Info.IdCobro, Info.IdCbte_vta_nota);
                        }
                    }
                }
                return retu;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }

        }

        public Boolean ModificarDB_Poli(cxc_cobro_Info Info, Cl_Enumeradores.PantallaEjecucion Accion)
        {
            try
            {
                string msg = "";
                Boolean retu = false;
                _Accion = Accion;

                if (validar_objeto(Info, ref msg) == true)
                {
                    retu = data.ModificarDB(Info);
                    if (retu)
                    {
                        if (Info.ListaCobro != null && Info.ListaCobro.Count > 0)
                            Info.ListaCobro.ForEach(var => var.IdCobro = Info.IdCobro);
                        cxc_cobro_Det_Bus BusDet_cobro = new cxc_cobro_Det_Bus();
                        retu = BusDet_cobro.ModificarDetalleCobro_Poli(Info.ListaCobro);

                        cxc_cobro_x_caj_Caja_Movimiento_Bus BusCobro_caja = new cxc_cobro_x_caj_Caja_Movimiento_Bus();
                        cxc_cobro_x_caj_Caja_Movimiento_Info InfoCobro_x_caj_movi = new cxc_cobro_x_caj_Caja_Movimiento_Info();

                        InfoCobro_x_caj_movi = BusCobro_caja.Get_Info_cobro_x_caj_Caja_Movimiento(Info.IdEmpresa, Info.IdSucursal, Info.IdCobro);

                        if (InfoCobro_x_caj_movi.cbr_IdCobro == 0)
                        {
                            retu = Contabilizar(Info.IdEmpresa, Info.IdSucursal, Info.IdCobro, Info.IdCbte_vta_nota);
                        }
                    }
                }
                return retu;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }

        }

        public Boolean AnularDB(cxc_cobro_Info info)
        {
            try
            {
                if (info.TieneDiarioCont_y_NoTieneDetalleCobro == "SI")
                {
                    Contabilizar_Anulacion(param.IdEmpresa, info.IdSucursal, info.IdCobro, Convert.ToDateTime(info.Fecha_Anulac));

                    return data.AnularDB(info);
                }
                else
                {
                    if (!bus_det.EliminarDetalleCobro(info.IdEmpresa, info.IdSucursal, info.IdCobro))
                        return false;

                    //Contabilizar_Anulacion(param.IdEmpresa, info.IdSucursal, info.IdCobro, Convert.ToDateTime(info.Fecha_Anulac));

                    return data.AnularDB(info);
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public List<vwcxc_cartera_x_cobrar_Info> NotasCreditoConFacturaXCobrar(int IdEmpresa, int IdSucursal, decimal IdCliente)
        {
            try
            {
                return data.NotasCreditoConFacturaXCobrar(IdEmpresa, IdSucursal, IdCliente);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "NotasCreditoConFacturaXCobrar", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }

        }
      
        public List<cxc_cobro_Info> Get_List_Cobros_para_Consulta(int IdEmpresa, int idSucursal, DateTime desde, DateTime hasta)
        {
            try
            {
                return data.Get_List_Cobros_para_Consulta(IdEmpresa, idSucursal, desde, hasta);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cobros_para_Consulta", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }

        }
   
        public List<cxc_cobro_Info> Get_List_cobros_x_Factura(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteCble, string TipoDoc)
        {
            try
            {
                return data.Get_List_cobros_x_Factura(IdEmpresa, IdSucursal, IdBodega, IdCbteCble, TipoDoc);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobros_x_Factura", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }

        }

        public Boolean ExisteCobro(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteCble, string TipoDoc)
        {
            try
            {
                return data.ExisteCobro(IdEmpresa, IdSucursal, IdBodega, IdCbteCble, TipoDoc);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ExisteCobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public List<cxc_cobro_Info> Get_List_cobro_x_Cliente(int IdEmpresa, int IdCliente, DateTime Fecha)
        {
            try
            {
                return data.Get_List_cobro_x_Client(IdEmpresa, IdCliente, Fecha);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_Cliente", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public List<vwcxc_cobros_x_vta_nota_x_Ret_Info> Get_List_cobro_x_RteFte(int IdEmpresa, int IdSucursal, int IdBodega_Cbte, decimal IdCbte_vta_nota, string TipoDoc)
        {
            try
            {
                return data.Get_List_cobro_x_RteFte(IdEmpresa, IdSucursal, IdBodega_Cbte, IdCbte_vta_nota, TipoDoc);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_RteFte", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }


        }

        public List<vwcxc_cobros_x_vta_nota_x_Ret_Info> Get_List_cobro_x_RteIVA(int IdEmpresa, int IdSucursal, int IdBodega_Cbte, decimal IdCbte_vta_nota, string TipoDoc)
        {
            try
            {
                return data.Get_List_cobro_x_RteIVA(IdEmpresa, IdSucursal, IdBodega_Cbte, IdCbte_vta_nota, TipoDoc);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_cobro_x_RteIVA", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }


        }

        public cxc_cobro_Info Get_Info_Cobro(int IdEmpresa, int IdSucursal, decimal IdCobro)
        {
            try
            {
                return data.Get_Info_Cobro(IdEmpresa, IdSucursal, IdCobro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Cobro", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        private Boolean validar_objeto(cxc_cobro_Info Info, ref string mensaje1)
        {
            try
            {
                if (Info.IdEmpresa == 0 && Info.IdSucursal == 0)
                {
                    mensaje1 = "Hay un error en el Idempresa=" + Info.IdEmpresa + " IdSucursal=" + Info.IdSucursal;
                    return false;
                }

                if (Info.IdCliente == 0 && Info.IdCobro_tipo == "")
                {
                    mensaje1 = "Hay un error en el IdCliente=" + Info.IdEmpresa + " IdCobro_tipo=" + Info.IdSucursal;
                    return false;
                }

                if (Info.IdCliente == 0 && Info.IdCobro_tipo == "")
                {
                    mensaje1 = "Hay un error en el IdCliente=" + Info.IdEmpresa + " IdCobro_tipo=" + Info.IdSucursal;
                    return false;
                }

                if (Info.IdCaja == 0)
                {
                    mensaje1 = "el Id caja no puede ser cero ";
                    return false;
                }

                if (Info.cr_es_anticipo == "")
                {
                    Info.cr_es_anticipo = "N";
                }

                if (Info.estado == "")
                {
                    Info.estado = "A";
                }

                if (Info.IdBanco == 0)
                {
                    ba_Banco_Cuenta_Bus BusBanco = new ba_Banco_Cuenta_Bus();

                    var listBancoCuenta = BusBanco.Get_list_Banco_Cuenta(Info.IdEmpresa);

                    if(listBancoCuenta.Count <= 0)
                    {
                        mensaje1 = "No existe cuenta bancaria en modulo de banco para el registro del cobro";
                        return false;
                    }

                    Info.IdBanco = listBancoCuenta.FirstOrDefault().IdBanco;
                }

                Info.cr_fecha = Convert.ToDateTime(Info.cr_fecha);
                Info.cr_fechaCobro = Convert.ToDateTime(Info.cr_fechaCobro);
                Info.cr_fechaDocu = Convert.ToDateTime(Info.cr_fechaDocu);

                ct_Periodo_Bus BusPeriodo = new ct_Periodo_Bus();
                ct_Periodo_Info InfoPeriodo = new ct_Periodo_Info();
                InfoPeriodo = BusPeriodo.Get_Info_Periodo(Info.IdEmpresa, Info.cr_fecha, ref mensaje1);

                if (InfoPeriodo.pe_cerrado == "S")
                {
                    mensaje1 = "El periodo contable esta cerrado no se puede guardar el cobro";
                    return false;
                }

                ct_periodo_x_tb_modulo_Bus BusPerdiodo_x_Modulo = new ct_periodo_x_tb_modulo_Bus();
                if (BusPerdiodo_x_Modulo.Esta_modulo_cerrado_x_periodo(Info.IdEmpresa, Cl_Enumeradores.eModulos.CXC, InfoPeriodo.IdPeriodo))
                {
                    mensaje1 = "El periodo contable para el modulo cxc esta cerrado no se puede guardar el cobro";
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "validar_objeto", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public bool generar_cobro_x_factura(fa_factura_Info info_factura, double valor_cobro, string IdCobro_tipo, DateTime Fecha_cobro, Nullable<int> IdBanco)
        {
            try
            {
                cxc_cobro_Info info_cobro = new cxc_cobro_Info();
                info_cobro.IdEmpresa = info_factura.IdEmpresa;
                info_cobro.IdSucursal = info_factura.IdSucursal;
                info_cobro.IdCobro = 0;
                info_cobro.IdCobro_a_aplicar = null;
                info_cobro.cr_Codigo = info_factura.CodCbteVta;
                info_cobro.IdCobro_tipo = IdCobro_tipo; //Tipo de cobro
                info_cobro.IdCliente = info_factura.IdCliente;
                info_cobro.cr_TotalCobro = valor_cobro;
                info_cobro.cr_fecha = Fecha_cobro.Date;
                info_cobro.cr_fechaCobro = Fecha_cobro.Date;
                info_cobro.cr_fechaDocu = Fecha_cobro.Date;
                info_cobro.cr_observacion = "Canc./: FACT-" + Convert.ToString(((info_factura.vt_NumFactura == "" || info_factura.vt_NumFactura == null) ? 000 : Convert.ToDecimal(info_factura.vt_NumFactura)));
                info_cobro.cr_es_anticipo = "N";
                info_cobro.IdCaja = 1;//Deberia ser parametro
                info_cobro.IdBanco = IdBanco;
                //Campos auditoria
                info_cobro.Fecha_Transac = DateTime.Now;
                info_cobro.IdUsuario = param.IdUsuario;
                info_cobro.nom_pc = param.nom_pc;
                info_cobro.ip = param.ip;

                cxc_cobro_Det_Info info_cobro_det = new cxc_cobro_Det_Info();
                info_cobro_det.IdEmpresa = info_factura.IdEmpresa;
                info_cobro_det.IdSucursal = info_factura.IdSucursal;
                info_cobro_det.secuencial = 1;
                info_cobro_det.dc_TipoDocumento = "FACT";
                info_cobro_det.IdBodega_Cbte = info_factura.IdBodega;
                info_cobro_det.IdCbte_vta_nota = info_factura.IdCbteVta;
                info_cobro_det.dc_ValorPago = valor_cobro;
                //Campos auditoria
                info_cobro_det.Fecha_Transac = DateTime.Now;
                info_cobro_det.IdUsuario = param.IdUsuario;
                info_cobro_det.nom_pc = param.nom_pc;
                info_cobro_det.ip = param.ip;
                info_cobro.ListaCobro.Add(info_cobro_det);

                if (GuardarDB(Cl_Enumeradores.PantallaEjecucion.COBROS, ref info_cobro, ref MensajeError, 0))
                {

                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "validar_objeto", ex.Message), ex) { EntityType = typeof(cxc_cobro_Bus) };
            }
        }

        public cxc_cobro_Bus() { }
    }
}