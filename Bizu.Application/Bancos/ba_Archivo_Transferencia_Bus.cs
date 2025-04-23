using Bizu.Infrastructure.Bancos;
using Bizu.Domain.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Application.General;
using Bizu.Application.Contabilidad;
using Bizu.Domain.General;
using Bizu.Domain.Contabilidad;
using Bizu.Infrastructure;
using Bizu.Domain.CuentasxPagar;
using Bizu.Application.CuentasxPagar;

namespace Bizu.Application.Bancos
{
    public class ba_Archivo_Transferencia_Bus
    {
        ba_Archivo_Transferencia_Data oData = new ba_Archivo_Transferencia_Data();
        ba_Archivo_Transferencia_Det_Data oData_det = new ba_Archivo_Transferencia_Det_Data();

        tb_banco_procesos_bancarios_x_empresa_Bus bus_procesos_x_empresa = new tb_banco_procesos_bancarios_x_empresa_Bus();
        tb_banco_procesos_bancarios_x_empresa_Info info_procesos_x_empresa = new tb_banco_procesos_bancarios_x_empresa_Info();

        ba_Cbte_Ban_Info info_Cbtecble_ban = new ba_Cbte_Ban_Info();
        ba_Cbte_Ban_Bus bus_Cbtecble_ban = new ba_Cbte_Ban_Bus();

        ct_Cbtecble_Bus bus_Cbtecble_conta = new ct_Cbtecble_Bus();
        cp_orden_pago_cancelaciones_Bus bus_op_cancelaciones = new cp_orden_pago_cancelaciones_Bus();

        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info info_cbte_ban_tipo_x_cbtecble = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus bus_cbte_ban_tipo_x_cbtecble = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();

        ba_Banco_Cuenta_Bus bus_banco_cta = new ba_Banco_Cuenta_Bus();
        ba_Banco_Cuenta_Info info_banco_cta = new ba_Banco_Cuenta_Info();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ba_Archivo_Transferencia_Det_Bus bus_archivo_det = new ba_Archivo_Transferencia_Det_Bus();
        string mensaje_error = "";

        public List<ba_Archivo_Transferencia_Info> Get_List_Archivo_transferencia()
        {
            try
            {
                return oData.Get_List_Archivo_transferencia();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };

            }
        }

        public ba_Archivo_Transferencia_Info Get_Info_Archivo_Transferencia(int idEmpresa, decimal idArchivo)
        {
            try
            {
                return oData.Get_Info_Archivo_Transferencia(idEmpresa,idArchivo);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };

            }
        }

        public ba_Archivo_Transferencia_Info Get_Info_Vista_Archivo_transferencia(int idEmpresa, decimal idArchivo, int idBanco, string idProceso)
        {
            try
            {
                return oData.Get_Info_Vista_Archivo_transferencia(idEmpresa, idArchivo, idBanco, idProceso);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Info_Vista_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };

            }
        }

        public List<ba_Archivo_Transferencia_Info> Get_Vista_Archivo_transferencia(int IdEmpresa, DateTime fechaIni, DateTime fechaFin, int idBancoIni, int idBancoFin, string idProceso)
        {
            try
            {
                return oData.Get_Vista_Archivo_transferencia(IdEmpresa, fechaIni,fechaFin,idBancoIni,idBancoFin,idProceso);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Vista_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };

            }
        }

        public List<ba_Archivo_Transferencia_Info> Get_Vista_Archivo_transferencia_x_Estado(string idEstadoArchivo, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                return oData.Get_Vista_Archivo_transferencia_x_Estado(idEstadoArchivo, fechaIni,fechaFin);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Vista_Archivo_transferencia_x_Estado", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };

            }
        }

        public List<ba_Archivo_Transferencia_Info> Get_List_Archivo_transferencia(int IdEmpresa, String Origen_Archivo,DateTime fi,DateTime ff)
        {
            try
            {
                return oData.Get_List_Archivo_transferencia(IdEmpresa, Origen_Archivo,fi,ff);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Vista_Archivo_transferencia_x_Estado", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public List<ba_Archivo_Transferencia_Info> Get_List_Archivo_transferencia(int IdEmpresa, int IdBanco, string IdProceso_bancario, String Origen_Archivo)
        {
            try
            {
                return oData.Get_List_Archivo_transferencia(IdEmpresa, IdBanco, IdProceso_bancario, Origen_Archivo);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Vista_Archivo_transferencia_x_Estado", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public bool GrabarDB(ba_Archivo_Transferencia_Info info,ref int Idarchivo)
        {
            try
            {
                bool res = false;

                if (info.Lst_Archivo_Transferencia_Det.Count() == 0)
                {
                    return false;
                }

                if (oData.GrabarDB(info, ref Idarchivo))
                {
                    foreach (var item in info.Lst_Archivo_Transferencia_Det)
                    {
                        item.IdArchivo = info.IdArchivo;
                        item.IdEstadoRegistro_cat = "REG_EMITI";
                        item.IdProceso_bancario = info.IdProceso_bancario;
                    }
                    res = oData_det.GrabarDB(info.Lst_Archivo_Transferencia_Det);

                    if (res == true)
                    {
                        ba_Cbte_Ban_Bus BusCbteBan = new ba_Cbte_Ban_Bus();
                        List<ba_Cbte_Ban_Info> listCbteBan= new List<ba_Cbte_Ban_Info>();

                        foreach (var item in info.Lst_Archivo_Transferencia_Det)
                        {
                            ba_Cbte_Ban_Info InfoCbteBan = new ba_Cbte_Ban_Info();
                            InfoCbteBan.IdEmpresa = Convert.ToInt32(item.IdEmpresa_mvba);
                            InfoCbteBan.IdTipocbte = Convert.ToInt32(item.IdTipocbte_mvba);
                            InfoCbteBan.IdCbteCble = Convert.ToDecimal(item.IdCbteCble_mvba);

                            listCbteBan.Add(InfoCbteBan);    
                        }

                        BusCbteBan.Modificar_Estado_Preaviso_ch(listCbteBan, eEstado_Preaviso_Cheque.ES_CH_PREAVISO_CH, ref mensaje_error);
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public bool Contabilizar_proceso(ba_Archivo_Transferencia_Info info_archivo, tb_banco_procesos_bancarios_x_empresa_Info info_procesos_x_empresa, string Origen)
        {
            try
            {
                bool res = false;

                if (info_archivo.Contabilizado != true)
                {
                    decimal IdCbteCble = 0;
                    double Valor_total = 0;
                    string Observacion = "";
                    int cont = 0;

                    this.info_Cbtecble_ban = new ba_Cbte_Ban_Info();
                    this.info_cbte_ban_tipo_x_cbtecble = this.bus_cbte_ban_tipo_x_cbtecble.Get_info_Cbte_Ban_tipo_x_ct_CbteCble_tipo(info_archivo.IdEmpresa, "NDBA");
                    this.info_banco_cta = this.bus_banco_cta.Get_Info_Banco_Cuenta(info_archivo.IdEmpresa, info_archivo.IdBanco);

                    List<cp_orden_pago_cancelaciones_Info> list_op_cancelaciones = new List<cp_orden_pago_cancelaciones_Info>();
                    List<ba_Archivo_Transferencia_Det> list_archivo_detalle_act = new List<ba_Archivo_Transferencia_Det>();
                    cp_orden_pago_det_Bus bus_op_det_x_cancelar = new cp_orden_pago_det_Bus();
                    
                    if (info_archivo.Origen_Archivo != "RRHH")
                    {
                        #region Pago a proveedores que tengan op

                        //OBTENGO LA LISTA DE OP PARA HACER DIARIOS POR PROVEEDOR
                        var list_archivo_transferencia = (from q in info_archivo.Lst_Archivo_Transferencia_Det
                                                          group q by new
                                                          {
                                                              q.IdArchivo
                                                          }
                                                              into x
                                                              select new
                                                              {
                                                                  IdArchivo = x.Key.IdArchivo,
                                                                  valor_a_pagar = x.Sum(t => t.Valor)
                                                              });

                        foreach (var item in list_archivo_transferencia)
                        {
                            Valor_total = Convert.ToDouble(Math.Round(item.valor_a_pagar, 2, MidpointRounding.AwayFromZero));

                            #region Armo cabecera diario

                            Observacion = info_archivo.IdProceso_bancario + " # " + info_archivo.IdArchivo.ToString();

                            //CABECERA COMPROBANTE CONTABLE
                            this.info_Cbtecble_ban.info_Cbtecble = new ct_Cbtecble_Info();
                            this.info_Cbtecble_ban.info_Cbtecble.IdEmpresa = info_archivo.IdEmpresa;
                            this.info_Cbtecble_ban.info_Cbtecble.IdTipoCbte = info_cbte_ban_tipo_x_cbtecble.IdTipoCbteCble;
                            this.info_Cbtecble_ban.info_Cbtecble.IdCbteCble = 0;
                            this.info_Cbtecble_ban.info_Cbtecble.IdPeriodo = (info_archivo.Fecha.Year * 100) + info_archivo.Fecha.Month;
                            this.info_Cbtecble_ban.info_Cbtecble.cb_Fecha = info_archivo.Fecha;
                            this.info_Cbtecble_ban.info_Cbtecble.Secuencia = 0;
                            this.info_Cbtecble_ban.info_Cbtecble.Anio = info_archivo.Fecha.Year;
                            this.info_Cbtecble_ban.info_Cbtecble.Mes = info_archivo.Fecha.Month;
                            this.info_Cbtecble_ban.info_Cbtecble.IdUsuario = info_archivo.IdUsuario;
                            this.info_Cbtecble_ban.info_Cbtecble.cb_FechaTransac = param.Fecha_Transac;
                            this.info_Cbtecble_ban.info_Cbtecble.IdSucursal = 1;
                            this.info_Cbtecble_ban.info_Cbtecble.Mayorizado = "N";
                            this.info_Cbtecble_ban.info_Cbtecble.Estado = "A";
                            this.info_Cbtecble_ban.info_Cbtecble.cb_Valor = Valor_total;
                            this.info_Cbtecble_ban.info_Cbtecble.cb_Observacion = Observacion;
                            this.info_Cbtecble_ban.info_Cbtecble._cbteCble_det_lista_info = new List<ct_Cbtecble_det_Info>();

                            //CABECERA ND
                            this.info_Cbtecble_ban.IdEmpresa = this.info_Cbtecble_ban.info_Cbtecble.IdEmpresa;
                            this.info_Cbtecble_ban.IdTipocbte = this.info_Cbtecble_ban.info_Cbtecble.IdTipoCbte;
                            this.info_Cbtecble_ban.IdTipoNota = info_procesos_x_empresa.IdTipoNota;
                            this.info_Cbtecble_ban.IdBanco = info_archivo.IdBanco;
                            this.info_Cbtecble_ban.IdCbteCble = 0;
                            this.info_Cbtecble_ban.IdPeriodo = this.info_Cbtecble_ban.info_Cbtecble.IdPeriodo;
                            this.info_Cbtecble_ban.cb_Fecha = this.info_Cbtecble_ban.info_Cbtecble.cb_Fecha;
                            this.info_Cbtecble_ban.cb_secuencia = this.info_Cbtecble_ban.info_Cbtecble.Secuencia;
                            this.info_Cbtecble_ban.IdUsuario = this.info_Cbtecble_ban.info_Cbtecble.IdUsuario;
                            this.info_Cbtecble_ban.Fecha_Transac = this.info_Cbtecble_ban.info_Cbtecble.cb_FechaTransac;
                            this.info_Cbtecble_ban.IdSucursal = this.info_Cbtecble_ban.info_Cbtecble.IdSucursal;
                            this.info_Cbtecble_ban.cb_ChequeImpreso = "N";
                            this.info_Cbtecble_ban.IdProveedor = null;
                            this.info_Cbtecble_ban.cb_Valor = this.info_Cbtecble_ban.info_Cbtecble.cb_Valor;
                            this.info_Cbtecble_ban.cb_Observacion = this.info_Cbtecble_ban.info_Cbtecble.cb_Observacion;
                            this.info_Cbtecble_ban.Estado = this.info_Cbtecble_ban.info_Cbtecble.Estado;

                            //DETALLE ASIENTO CONTABLE BANCO
                            ct_Cbtecble_det_Info Haber_op = new ct_Cbtecble_det_Info();
                            Haber_op.IdEmpresa = this.info_Cbtecble_ban.info_Cbtecble.IdEmpresa;
                            Haber_op.IdTipoCbte = this.info_Cbtecble_ban.info_Cbtecble.IdTipoCbte;
                            Haber_op.IdCbteCble = 0;
                            Haber_op.secuencia = 0;
                            Haber_op.IdCtaCble = info_banco_cta.IdCtaCble;
                            Haber_op.dc_Valor = Valor_total * -1;
                            Haber_op.dc_Observacion = Observacion;
                            Haber_op.dc_para_conciliar = true;

                            this.info_Cbtecble_ban.info_Cbtecble._cbteCble_det_lista_info.Add(Haber_op);
                            #endregion

                            List<cp_orden_pago_det_Info> list_op_det_x_cancelar = new List<cp_orden_pago_det_Info>();
                            List<decimal> list_op_x_canc = new List<decimal>();

                            foreach (var det_archivo in info_archivo.Lst_Archivo_Transferencia_Det)
                            {
                                list_op_x_canc.Add(det_archivo.IdOrdenPago == null ? 0 : (decimal)det_archivo.IdOrdenPago);
                            }

                            //OBTENGO LA LISTA DE LAS OP PARA MATAR CON LA NDBA
                            list_op_det_x_cancelar = bus_op_det_x_cancelar.Get_list_orden_pago_con_cta_acreedora(info_archivo.IdEmpresa, list_op_x_canc);

                            list_op_cancelaciones = new List<cp_orden_pago_cancelaciones_Info>();

                            foreach (var det_op in list_op_det_x_cancelar)
                            {
                                #region Armo detalle diario

                                ct_Cbtecble_det_Info Debe = new ct_Cbtecble_det_Info();
                                Debe.IdEmpresa = this.info_Cbtecble_ban.info_Cbtecble.IdEmpresa;
                                Debe.IdTipoCbte = this.info_Cbtecble_ban.info_Cbtecble.IdTipoCbte;
                                Debe.IdCbteCble = 0;
                                Debe.secuencia = 0;
                                Debe.IdCtaCble = det_op.IdCtaCble_Acreedora;
                                Debe.dc_Valor = Convert.ToDouble(Math.Round(Convert.ToDecimal(det_op.Valor_a_pagar), 2, MidpointRounding.AwayFromZero));
                                Debe.dc_Observacion = info_archivo.IdProceso_bancario + " # " + info_archivo.IdArchivo.ToString() + " " + det_op.IdTipo_Persona + ": [" + det_op.IdEntidad.ToString() + "] " + det_op.pr_nombre.Trim() + " " + det_op.Referencia;
                                this.info_Cbtecble_ban.info_Cbtecble._cbteCble_det_lista_info.Add(Debe);

                                #endregion

                                #region Cancelaciones x op
                                cp_orden_pago_cancelaciones_Info info_op_cancelaciones = new cp_orden_pago_cancelaciones_Info();
                                info_op_cancelaciones.IdEmpresa = info_archivo.IdEmpresa;
                                info_op_cancelaciones.Idcancelacion = 0;
                                info_op_cancelaciones.Secuencia = 0;
                                info_op_cancelaciones.IdEmpresa_op = det_op.IdEmpresa;
                                info_op_cancelaciones.IdOrdenPago_op = det_op.IdOrdenPago;
                                info_op_cancelaciones.Secuencia_op = det_op.Secuencia;
                                info_op_cancelaciones.IdEmpresa_cxp = det_op.IdEmpresa_cxp;
                                info_op_cancelaciones.IdTipoCbte_cxp = det_op.IdTipoCbte_cxp;
                                info_op_cancelaciones.IdCbteCble_cxp = det_op.IdCbteCble_cxp;
                                info_op_cancelaciones.MontoAplicado = det_op.Valor_a_pagar;
                                info_op_cancelaciones.SaldoActual = 0;
                                info_op_cancelaciones.SaldoAnterior = 0;
                                info_op_cancelaciones.Observacion = "Canc./ de OP con Archivo bancario x " + info_archivo.IdProceso_bancario + " #" + info_archivo.IdArchivo.ToString();
                                info_op_cancelaciones.fechaTransaccion = info_archivo.Fecha;

                                list_op_cancelaciones.Add(info_op_cancelaciones);
                                #endregion
                            }

                            IdCbteCble = 0;

                            if (bus_Cbtecble_conta.GrabarDB(this.info_Cbtecble_ban.info_Cbtecble, ref IdCbteCble, ref mensaje_error))
                            {
                                this.info_Cbtecble_ban.IdCbteCble = IdCbteCble;

                                bus_Cbtecble_ban.GrabarDB(this.info_Cbtecble_ban, ref mensaje_error);

                                foreach (var info_archivo_det in info_archivo.Lst_Archivo_Transferencia_Det)
                                {
                                    info_archivo_det.IdEmpresa_pago = this.info_Cbtecble_ban.IdEmpresa;
                                    info_archivo_det.IdTipoCbte_pago = this.info_Cbtecble_ban.IdTipocbte;
                                    info_archivo_det.IdCbteCble_pago = this.info_Cbtecble_ban.IdCbteCble;

                                    bus_archivo_det.ModificarDB(info_archivo_det);
                                }

                                foreach (var info_can in list_op_cancelaciones)
                                {
                                    info_can.FechaCancelacion = this.info_Cbtecble_ban.cb_Fecha;
                                    info_can.IdEmpresa_pago = this.info_Cbtecble_ban.info_Cbtecble.IdEmpresa;
                                    info_can.IdTipoCbte_pago = this.info_Cbtecble_ban.info_Cbtecble.IdTipoCbte;
                                    info_can.IdCbteCble_pago = IdCbteCble;
                                }

                                bus_op_cancelaciones.GuardarDB(list_op_cancelaciones, info_archivo.IdEmpresa, ref mensaje_error);
                            }
                        }

                        res = true;
                        info_archivo.Contabilizado = true;
                        #endregion
                    }
                    else
                    {                        
                        if (info_archivo.Lst_Archivo_Transferencia_Det.Count != 0)
                        {
                            ba_Archivo_Transferencia_Det_Info info_det_archivo = new ba_Archivo_Transferencia_Det_Info();
                            info_det_archivo = info_archivo.Lst_Archivo_Transferencia_Det.First();
                            //info_param_ro = bus_param_ro.Get_Info(Convert.ToInt32(info_det_archivo.IdEmpresa), Convert.ToInt32(info_det_archivo.IdNominaTipo), Convert.ToInt32(info_det_archivo.IdNominaTipoLiqui));
                        }
                        
                        foreach (var det_op in info_archivo.Lst_Archivo_Transferencia_Det)
                        {
                            if (det_op.IdEmpresa_pago == null)
                            {
                                this.info_Cbtecble_ban.info_Cbtecble = new ct_Cbtecble_Info();
                                this.info_Cbtecble_ban.IdEmpresa = this.info_Cbtecble_ban.info_Cbtecble.IdEmpresa = info_archivo.IdEmpresa;
                                this.info_Cbtecble_ban.IdSucursal = this.info_Cbtecble_ban.info_Cbtecble.IdSucursal = 1;
                                this.info_Cbtecble_ban.IdTipocbte = this.info_Cbtecble_ban.info_Cbtecble.IdTipoCbte = info_cbte_ban_tipo_x_cbtecble.IdTipoCbteCble;
                                this.info_Cbtecble_ban.IdCbteCble = this.info_Cbtecble_ban.info_Cbtecble.IdCbteCble = 0;
                                this.info_Cbtecble_ban.IdPeriodo = this.info_Cbtecble_ban.info_Cbtecble.IdPeriodo = (info_archivo.Fecha.Year * 100) + info_archivo.Fecha.Month;
                                this.info_Cbtecble_ban.cb_Fecha = this.info_Cbtecble_ban.info_Cbtecble.cb_Fecha = info_archivo.Fecha;
                                this.info_Cbtecble_ban.cb_secuencia = this.info_Cbtecble_ban.info_Cbtecble.Secuencia = 0;
                                this.info_Cbtecble_ban.info_Cbtecble.Anio = info_archivo.Fecha.Year;
                                this.info_Cbtecble_ban.info_Cbtecble.Mes = info_archivo.Fecha.Month;
                                this.info_Cbtecble_ban.IdUsuario = this.info_Cbtecble_ban.info_Cbtecble.IdUsuario = info_archivo.IdUsuario;
                                this.info_Cbtecble_ban.Fecha_Transac = this.info_Cbtecble_ban.info_Cbtecble.cb_FechaTransac = DateTime.Now;
                                this.info_Cbtecble_ban.cb_ChequeImpreso = "N"; this.info_Cbtecble_ban.info_Cbtecble.Mayorizado = "N";
                                this.info_Cbtecble_ban.info_Cbtecble._cbteCble_det_lista_info = new List<ct_Cbtecble_det_Info>();
                                this.info_Cbtecble_ban.Estado = this.info_Cbtecble_ban.info_Cbtecble.Estado = "A";

                                Observacion = info_archivo.IdProceso_bancario + " # " + info_archivo.IdArchivo.ToString() + " " + "EMPLEA" + ": [" + det_op.pe_cedulaRuc.ToString() + "] " + det_op.pe_nombreCompleto.Trim() + " " + info_archivo.Observacion;
                                Valor_total = 0;
                                Valor_total += Convert.ToDouble(Math.Round(det_op.Valor, 2, MidpointRounding.AwayFromZero));

                                ct_Cbtecble_det_Info Debe = new ct_Cbtecble_det_Info();
                                Debe.IdEmpresa = this.info_Cbtecble_ban.info_Cbtecble.IdEmpresa;
                                Debe.IdTipoCbte = this.info_Cbtecble_ban.info_Cbtecble.IdTipoCbte;
                                Debe.IdCbteCble = 0;
                                Debe.secuencia = 1;
                                Debe.IdCtaCble = null;
                                Debe.dc_Valor = Convert.ToDouble(Math.Round(Convert.ToDecimal(det_op.Valor), 2, MidpointRounding.AwayFromZero));
                                Debe.dc_Observacion = info_archivo.IdProceso_bancario + " # " + info_archivo.IdArchivo.ToString() + " " + "EMPLEA" + ": [" + det_op.pe_cedulaRuc.ToString() + "] " + det_op.pe_nombreCompleto.Trim() + " " + info_archivo.Observacion;
                                this.info_Cbtecble_ban.info_Cbtecble._cbteCble_det_lista_info.Add(Debe);

                                ct_Cbtecble_det_Info Haber_op = new ct_Cbtecble_det_Info();
                                Haber_op.IdEmpresa = this.info_Cbtecble_ban.info_Cbtecble.IdEmpresa;
                                Haber_op.IdTipoCbte = this.info_Cbtecble_ban.info_Cbtecble.IdTipoCbte;
                                Haber_op.IdCbteCble = 0;
                                Haber_op.secuencia = 2;
                                Haber_op.IdCtaCble = info_banco_cta.IdCtaCble;
                                Haber_op.dc_Valor = Convert.ToDouble(Math.Round(Valor_total, 2, MidpointRounding.AwayFromZero)) * -1;
                                Haber_op.dc_Observacion = Observacion;
                                Haber_op.dc_para_conciliar = true;
                                this.info_Cbtecble_ban.info_Cbtecble._cbteCble_det_lista_info.Add(Haber_op);
                                this.info_Cbtecble_ban.cb_Valor = this.info_Cbtecble_ban.info_Cbtecble.cb_Valor = Convert.ToDouble(Math.Round(Valor_total, 2, MidpointRounding.AwayFromZero));
                                this.info_Cbtecble_ban.cb_Observacion = this.info_Cbtecble_ban.info_Cbtecble.cb_Observacion = Observacion;
                                IdCbteCble = 0;

                                if (bus_Cbtecble_conta.GrabarDB(this.info_Cbtecble_ban.info_Cbtecble, ref IdCbteCble, ref mensaje_error))
                                {

                                    this.info_Cbtecble_ban.IdBanco = info_archivo.IdBanco;
                                    this.info_Cbtecble_ban.IdCbteCble = IdCbteCble;
                                    this.info_Cbtecble_ban.IdTipoNota = info_procesos_x_empresa.IdTipoNota;
                                    this.info_Cbtecble_ban.IdUsuario = param.IdUsuario;

                                    if (bus_Cbtecble_ban.GrabarDB(this.info_Cbtecble_ban, ref mensaje_error))
                                    {
                                        det_op.IdEmpresa_pago = this.info_Cbtecble_ban.IdEmpresa;
                                        det_op.IdTipoCbte_pago = this.info_Cbtecble_ban.IdTipocbte;
                                        det_op.IdCbteCble_pago = this.info_Cbtecble_ban.IdCbteCble;
                                        bus_archivo_det.ModificarDB(det_op);
                                    }
                                }
                            }
                        }

                        info_archivo.Contabilizado = true;
                    }

                    Actualizar_estado_contabilizacion(info_archivo);
                }
                
                return res;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public bool Actualizar_Archivo(ba_Archivo_Transferencia_Info info)
        {
            try
            {
                return oData.Actualizar_Archivo(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Actualizar_Archivo", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public bool EliminarDB(int IdEmpresa, decimal IdArchivo)
        {
            try
            {
                if (bus_archivo_det.EliminarDB(IdEmpresa, IdArchivo))
                {
                    if (oData.EliminarDB(IdEmpresa, IdArchivo))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Actualizar_Archivo", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public bool Actualizar_estado_contabilizacion(ba_Archivo_Transferencia_Info info_archivo)
        {
            try
            {
                return oData.Actualizar_estado_contabilizacion(info_archivo);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Actualizar_estado_contabilizacion", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public bool ModificarDB(ba_Archivo_Transferencia_Info info)
        {
            try
            {
                bool res = false;

                if (oData.ModificarDB(info))
                {
                    if (oData_det.EliminarDB(info.IdEmpresa,info.IdArchivo))
                    {
                        foreach (var item in info.Lst_Archivo_Transferencia_Det)
                        {
                            item.IdArchivo = info.IdArchivo;
                            item.IdEstadoRegistro_cat = "REG_EMITI";
                            item.IdProceso_bancario = info.IdProceso_bancario;
                        }

                        res = oData_det.GrabarDB(info.Lst_Archivo_Transferencia_Det);
                    }

                    info_procesos_x_empresa = bus_procesos_x_empresa.Get_info_proceso_bancario_x_empresa(info.IdEmpresa, info.IdProceso_bancario);                   
                } 

                return res;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public bool AnularDB(ba_Archivo_Transferencia_Info info)
        {
            try
            {
                return oData.AnularDB(info);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };

            }
        }

        public byte[] Get_Archivo(int idEmpresa, decimal idArchivo, string idProceso, int idBanco)
        {
            try
            {
                return oData.Get_Archivo(idEmpresa, idArchivo, idProceso, idBanco);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Archivo", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };

            }
        }

        public string GetId_codigoArchivo_banco(int IdEmpresa, int IdBanco, DateTime fecha)
        {
            try
            {
                return oData.GetId_codigoArchivo_banco(IdEmpresa, IdBanco, fecha);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }        

        public string GetId_codigoArchivo_bolivariano(int IdEmpresa, int IdBanco, DateTime fecha)
        {
            try
            {
                return oData.GetId_codigoArchivo_bolivariano(IdEmpresa, IdBanco, fecha);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public string GetId_codigoArchivo_guayaquil(int IdEmpresa, int IdBanco, DateTime fecha)
        {
            try
            {
                return oData.GetId_codigoArchivo_guayaquil(IdEmpresa, IdBanco, fecha);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public string GetId_codigoArchivo(int IdEmpresa, DateTime fecha)
        {
            try
            {
                return oData.GetId_codigoArchivo(IdEmpresa,fecha);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public int GetId(int IdEmpresa)
        {
            try
            {
                return oData.GetId(IdEmpresa);
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }
    }
}
