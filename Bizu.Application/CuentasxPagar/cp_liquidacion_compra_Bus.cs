using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Domain.CuentasxPagar;
using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Domain.CuentasxPagar.xmlLiquidacionCompra;
using Bizu.Domain.Inventario;
using Bizu.Application.Inventario;
using Bizu.Domain.class_sri;

namespace Bizu.Application.CuentasxPagar
{
    public class cp_liquidacion_compra_Bus
    {
        string format = "dd/MM/yyyy";

        /// <comentarios/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
        [System.SerializableAttribute()]
        public enum obligadoContabilidad
        {
            /// <comentarios/>
            SI,

            /// <comentarios/>
            NO,
        }

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        cp_liquidacion_compra_Data Data = new cp_liquidacion_compra_Data();

        public bool GrabarDB(cp_liquidacion_compra_Info Info, ref string msg)
        {
            try
            {
                cp_liquidacion_compra_det_Bus Bus_Liquidacion_Compra_Det = new cp_liquidacion_compra_det_Bus();

                if (Data.GrabarDB(Info, ref msg))
                {
                    int Secuencia = 0;

                    if (Modificar_Num_Documento(Info, ref msg)) { }

                    foreach (var item in Info.cp_liquidacion_compra_det)
                    {
                        item.IdEmpresa = Info.IdEmpresa;
                        item.IdLiquidacionCompra = Info.IdLiquidacionCompra;
                        Secuencia += 1;
                        item.Secuencia = Secuencia;
                    }

                    Bus_Liquidacion_Compra_Det.EliminarDB(Info.IdEmpresa, Info.IdLiquidacionCompra, ref msg);

                    if (Bus_Liquidacion_Compra_Det.GrabarDB(Info.cp_liquidacion_compra_det, ref msg))
                    {

                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }

        public bool ModificarDB(cp_liquidacion_compra_Info Info, ref string msg)
        {
            try
            {
                cp_liquidacion_compra_det_Bus Bus_Liquidacion_Compra_Det = new cp_liquidacion_compra_det_Bus();

                if (Data.ModificarDB(Info, ref msg))
                {
                    int Secuencia = 0;

                    foreach (var item in Info.cp_liquidacion_compra_det)
                    {
                        item.IdEmpresa = Info.IdEmpresa;
                        item.IdLiquidacionCompra = Info.IdLiquidacionCompra;
                        Secuencia += 1;
                        item.Secuencia = Secuencia;
                    }

                    Bus_Liquidacion_Compra_Det.EliminarDB(Info.IdEmpresa, Info.IdLiquidacionCompra, ref msg);

                    if (Bus_Liquidacion_Compra_Det.GrabarDB(Info.cp_liquidacion_compra_det, ref msg))
                    {

                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }

        public Boolean Modificar_Num_Documento(cp_liquidacion_compra_Info Info_Liquidacion, ref string mensajeError)
        {
            try
            {
                Boolean res = false;

                tb_sis_Documento_Tipo_Talonario_Bus busTalonario = new tb_sis_Documento_Tipo_Talonario_Bus();
                tb_sis_Documento_Tipo_Talonario_Info infoTalonario = new tb_sis_Documento_Tipo_Talonario_Info();
                tb_Sucursal_Bus Bus_Sucu = new tb_Sucursal_Bus();
                tb_Bodega_Bus Bus_bodega = new tb_Bodega_Bus();

                string mensajeDocumentoDupli = "";
                string cod_estable = "";
                string cod_pto_emision = "";

                Info_Liquidacion.CodDocumentoTipo = string.IsNullOrEmpty(Info_Liquidacion.CodDocumentoTipo) ? "LIQCOM" : Info_Liquidacion.CodDocumentoTipo;


                // el objeto viene sin serie o sin # factura tomo el ultimo num de factura del talonario
                if (Info_Liquidacion.serie1 == "" || Info_Liquidacion.serie1 == null || Info_Liquidacion.serie2 == "" || Info_Liquidacion.serie2 == null
                    || Info_Liquidacion.NumDocumento == "" || Info_Liquidacion.NumDocumento == null)
                {

                    cod_estable = Bus_Sucu.Get_Cod_Establecimiento_x_Sucursal(Info_Liquidacion.IdEmpresa, param.IdSucursal);
                    cod_pto_emision = Bus_bodega.Get_cod_pto_emision_x_Bodega(Info_Liquidacion.IdEmpresa, param.IdSucursal, 1);

                    infoTalonario = busTalonario.Get_Info_Primer_Documento_no_usado(Info_Liquidacion.IdEmpresa, cod_estable, cod_pto_emision, Info_Liquidacion.CodDocumentoTipo, true);


                    if (infoTalonario.NumDocumento == null)
                    {
                        mensajeError = "No hay talonarios para Establecimiento=" + cod_estable + " y punto de emision=" + cod_pto_emision;
                        throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "no hay talonario activos", mensajeError)) { EntityType = typeof(cp_liquidacion_compra_Bus) };
                    }

                    Info_Liquidacion.serie1 = infoTalonario.Establecimiento;
                    Info_Liquidacion.serie2 = infoTalonario.PuntoEmision;
                    Info_Liquidacion.NumDocumento = infoTalonario.NumDocumento;

                }
                else
                {

                    // se puede dar si mas de un usario estan haciendo la factura y tienen en memoria o en la pantalla el mismo talonario
                    //verifico el numero de factura si esta usado
                    infoTalonario.Establecimiento = Info_Liquidacion.serie1;
                    infoTalonario.PuntoEmision = Info_Liquidacion.serie2;
                    infoTalonario.NumDocumento = Info_Liquidacion.NumDocumento;
                    infoTalonario.IdEmpresa = Info_Liquidacion.IdEmpresa;
                    infoTalonario.CodDocumentoTipo = Info_Liquidacion.CodDocumentoTipo;
                    infoTalonario.es_Documento_electronico = true;


                    if (busTalonario.Documento_talonario_esta_Usado(infoTalonario, ref mensajeError, ref mensajeDocumentoDupli))
                    {
                        //si esta en usado busco el siguiente
                        cod_estable = Bus_Sucu.Get_Cod_Establecimiento_x_Sucursal(Info_Liquidacion.IdEmpresa, param.IdSucursal);
                        cod_pto_emision = Bus_bodega.Get_cod_pto_emision_x_Bodega(Info_Liquidacion.IdEmpresa, param.IdSucursal, 1);

                        infoTalonario = busTalonario.Get_Info_Primer_Documento_no_usado(Info_Liquidacion.IdEmpresa, cod_estable,
                            cod_pto_emision, Info_Liquidacion.CodDocumentoTipo, true);

                        if (infoTalonario.NumDocumento == null)
                        {
                            throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "no hay talonario activos", mensajeError)) { EntityType = typeof(cp_liquidacion_compra_Bus) };
                        }

                        Info_Liquidacion.serie1 = infoTalonario.Establecimiento;
                        Info_Liquidacion.serie2 = infoTalonario.PuntoEmision;
                        Info_Liquidacion.NumDocumento = infoTalonario.NumDocumento;

                        if (!infoTalonario.es_Documento_electronico)
                        {
                            //si no es documento electronico le actualizo el numero de autorizacion y la fecha de autorizacion
                            Info_Liquidacion.NAutorizacion = infoTalonario.NumAutorizacion;
                            Info_Liquidacion.Fecha_Autorizacion = DateTime.Now.Date;
                        }

                    }
                    else
                    {
                        if (!infoTalonario.es_Documento_electronico)
                        {
                            //Si no esta siendo usado, si no es documento electronico le actualizo el numero de autorizacion y la fecha de autorizacion
                            infoTalonario = busTalonario.Get_Info_Documento_Tipo_Talonario(Info_Liquidacion.IdEmpresa, Info_Liquidacion.CodDocumentoTipo, cod_estable, cod_pto_emision, Info_Liquidacion.NumDocumento);


                            Info_Liquidacion.NAutorizacion = infoTalonario.NumAutorizacion;
                            Info_Liquidacion.Fecha_Autorizacion = DateTime.Now.Date;
                        }
                    }
                }

                res = Data.Modificar_Num_Retencion(Info_Liquidacion, ref mensajeError);
                busTalonario.Modificar_Estado_Usado(infoTalonario, ref mensajeError);

                return res;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "ModificarNRetencion", ex.Message), ex) { EntityType = typeof(cp_liquidacion_compra_Bus) };
            }

        }

        public cp_liquidacion_compra_Info Get_Info(int IdEmpresa, int IdTipoCbte_Ogiro, decimal IdCbteCble_Ogiro)
        {
            try
            {
                cp_liquidacion_compra_det_Bus Bus_Liquidacion_Compra_Det = new cp_liquidacion_compra_det_Bus();

                return Data.Get_Info(IdEmpresa, IdTipoCbte_Ogiro, IdCbteCble_Ogiro);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }

        public cp_liquidacion_compra_Info Get_Info(int IdEmpresa, decimal IdLiquidacionCompra)
        {
            try
            {
                cp_liquidacion_compra_det_Bus Bus_Liquidacion_Compra_Det = new cp_liquidacion_compra_det_Bus();

                return Data.Get_Info(IdEmpresa, IdLiquidacionCompra);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }

        public List<liquidacionCompra> Get_List_Xml_LiquidacionCompra(int IdEmpresa, decimal IdLiquidacionCompra, ref string msg)
        {
            try
            {
                string secuencia_aux = "";
                string secuencia = "";
                decimal Total_LiquidacionCompra = 0;

                List<liquidacionCompra> lista = new List<liquidacionCompra>();

                List<vwcp_liquidacionCompra_sri_Info> consulta = new List<vwcp_liquidacionCompra_sri_Info>();
                vwcp_liquidacionCompra_sri_Bus Bus_LiquidacionCompra_SRI = new vwcp_liquidacionCompra_sri_Bus();
                in_producto_Bus Bus_Producto = new in_producto_Bus();
                in_UnidadMedida_Bus Bus_UnidadMedida = new in_UnidadMedida_Bus();
                cp_liquidacion_compra_Bus Bus_LiquidacionCompra = new cp_liquidacion_compra_Bus();
                cp_liquidacion_compra_Info Info_LiquidacionCompra = new cp_liquidacion_compra_Info();
                cp_orden_giro_Bus Bus_OrdenGiro = new cp_orden_giro_Bus();
                cp_orden_giro_Info Info_OrdenGiro = new cp_orden_giro_Info();

                consulta = Bus_LiquidacionCompra_SRI.Get_list_LiquidacionCompra_Sri(IdEmpresa, IdLiquidacionCompra, ref msg);

                vwcp_liquidacionCompra_sri_Info info_LiquidacionCompraSRI = new vwcp_liquidacionCompra_sri_Info();

                if (consulta.ToList().Count != 0)
                {
                    //consultar Liquidacion Compra det
                    cp_liquidacion_compra_det_Data Bus_LiquidacionCompra_Det = new cp_liquidacion_compra_det_Data();
                    List<cp_liquidacion_compra_det_Info> LiquidacionCompra_Det = new List<cp_liquidacion_compra_det_Info>();

                    LiquidacionCompra_Det = Bus_LiquidacionCompra_Det.Get_Detalle(IdEmpresa, IdLiquidacionCompra);

                    if (LiquidacionCompra_Det.Count != 0)
                    {
                        info_LiquidacionCompraSRI.LiquidacionCompra_Det = LiquidacionCompra_Det;

                        foreach (var item in consulta)
                        {
                            liquidacionCompra myObject = new liquidacionCompra();
                            myObject.version = "1.1.0";
                            //myObject.id = liquidacionCompraID.comprobante;
                            myObject.idSpecified = true;

                            #region <infoTributaria></infoTributaria>

                            myObject.infoTributaria = new infoTributaria();
                            myObject.infoTributaria.ambiente = "1";
                            myObject.infoTributaria.tipoEmision = "1";
                            myObject.infoTributaria.razonSocial = item.RazonSocial;
                            myObject.infoTributaria.nombreComercial = item.NombreComercial;
                            myObject.infoTributaria.ruc = item.em_ruc;
                            myObject.infoTributaria.claveAcceso = "0000000000000000000000000000000000000000000000000";
                            myObject.infoTributaria.codDoc = "03"; //CODIGO - LIQUIDACION DE COMPRA DE BIENES Y PRESTACION DE SERVICIOS
                            myObject.infoTributaria.estab = item.serie.Substring(0, 3);
                            myObject.infoTributaria.ptoEmi = item.serie.Substring(4, 3);
                            #region validar secuencial liquidacion Compra

                            secuencia_aux = "";
                            secuencia = "";

                            if (!String.IsNullOrEmpty(item.numDocumento))
                            {
                                if (item.numDocumento.Length < 9)
                                {
                                    int conta = item.numDocumento.Length;
                                    int diferencia = 9 - conta;

                                    secuencia_aux = secuencia_aux.PadLeft(diferencia, '0');
                                    secuencia = secuencia_aux + item.numDocumento;

                                    item.numDocumento = secuencia;
                                }
                            }

                            #endregion
                            myObject.infoTributaria.secuencial = item.numDocumento;
                            myObject.infoTributaria.dirMatriz = item.em_direccion;

                            #endregion

                            #region <infoLiquidacionCompra></infoLiquidacionCompra>

                            myObject.infoLiquidacionCompra = new infoLiquidacionCompra();
                            myObject.infoLiquidacionCompra.fechaEmision = item.fecha.ToString(format);
                            myObject.infoLiquidacionCompra.dirEstablecimiento = item.Su_Direccion;

                            //CONTRIBUYENTE ESPECIAL
                            if (item.ContribuyenteEspecial != null)
                            {
                                myObject.infoLiquidacionCompra.contribuyenteEspecial = item.ContribuyenteEspecial;
                            }

                            //if (item.ObligadoAllevarConta == "SI" || item.ObligadoAllevarConta == "S")
                            //{
                            //    myObject.infoLiquidacionCompra.obligadoContabilidad = obligadoContabilidad.SI;
                            //}
                            //else
                            //{
                            //    myObject.infoLiquidacionCompra.obligadoContabilidad = obligadoContabilidad.NO;
                            //}

                            myObject.infoLiquidacionCompra.obligadoContabilidadSpecified = true;

                            switch (item.IdTipoDocumento)
                            {
                                case "CED":
                                    myObject.infoLiquidacionCompra.tipoIdentificacionProveedor = "05";
                                    break;
                                case "PAS":
                                    myObject.infoLiquidacionCompra.tipoIdentificacionProveedor = "06";
                                    break;
                                case "RUC":
                                    myObject.infoLiquidacionCompra.tipoIdentificacionProveedor = "04";
                                    break;
                                default:
                                    break;
                            }

                            myObject.infoLiquidacionCompra.razonSocialProveedor = item.pe_razonSocial;
                            myObject.infoLiquidacionCompra.identificacionProveedor = item.pe_cedulaRuc;
                            myObject.infoLiquidacionCompra.direccionProveedor = item.pe_direccion;

                            List<totalConImpuestos> lista_Impuesto = new List<totalConImpuestos>();

                            double sum_Simpuesto = 0;
                            double sum_totDescto = 0;
                            double sum_Total = 0;

                            foreach (var item2 in info_LiquidacionCompraSRI.LiquidacionCompra_Det)
                            {
                                double subtotal = 0;

                                totalConImpuestos totalImpuesto = new totalConImpuestos();
                                totalImpuesto.codigo = "2";

                                subtotal = Math.Round((item2.Cantidad * item2.Precio - item2.DescUnitario), 2);
                                sum_totDescto = sum_totDescto + item2.DescUnitario;

                                sum_Total = sum_Total + item2.Total;
                                sum_Simpuesto = sum_Simpuesto + subtotal;

                                Total_LiquidacionCompra = Total_LiquidacionCompra + Convert.ToDecimal(item2.Total);

                                switch (item2.por_iva)
                                {
                                    case 0:
                                        totalImpuesto.codigoPorcentaje = "0";
                                        break;
                                    case 12:
                                        totalImpuesto.codigoPorcentaje = "2";
                                        break;
                                    case 14:
                                        totalImpuesto.codigoPorcentaje = "3";
                                        break;
                                    case 15:
                                        totalImpuesto.codigoPorcentaje = "4";
                                        break;
                                    case 5:
                                        totalImpuesto.codigoPorcentaje = "5";
                                        break;
                                }

                                totalImpuesto.baseImponible = Math.Round(Convert.ToDecimal(subtotal), 2);
                                totalImpuesto.valor = Math.Round(Convert.ToDecimal(item2.Iva), 2);

                                lista_Impuesto.Add(totalImpuesto);
                            }

                            myObject.infoLiquidacionCompra.totalSinImpuestos = Math.Round(Convert.ToDecimal(sum_Simpuesto), 2);
                            myObject.infoLiquidacionCompra.totalDescuento = Math.Round(Convert.ToDecimal(sum_totDescto), 2);
                            myObject.infoLiquidacionCompra.importeTotal = Math.Round(Convert.ToDecimal(sum_Total), 2);
                            myObject.infoLiquidacionCompra.moneda = "DOLAR";

                            var resul_Impuesto = from s in lista_Impuesto
                                                 group s by new { s.codigoPorcentaje, s.codigo } into g
                                                 select new {/*taxGroup= */g.Key.codigoPorcentaje, g.Key.codigo, baseImponible = g.Sum(s => s.baseImponible), Valor = g.Sum(x => x.valor) };


                            myObject.infoLiquidacionCompra.totalConImpuestos = new List<totalConImpuestos>();

                            foreach (var item3 in resul_Impuesto)
                            {
                                totalConImpuestos totalImpuesto = new totalConImpuestos();
                                totalImpuesto.codigo = item3.codigo;
                                totalImpuesto.codigoPorcentaje = item3.codigoPorcentaje;
                                totalImpuesto.baseImponible = item3.baseImponible;
                                totalImpuesto.valor = item3.Valor;

                                myObject.infoLiquidacionCompra.totalConImpuestos.Add(totalImpuesto);
                            }

                            Info_LiquidacionCompra = Bus_LiquidacionCompra.Get_Info(IdEmpresa, IdLiquidacionCompra);

                            if (Info_LiquidacionCompra != null)
                                Info_OrdenGiro = Bus_OrdenGiro.Get_Info_orden_giro(Convert.ToInt32(Info_LiquidacionCompra.IdEmpresa_Ogiro), Convert.ToInt32(Info_LiquidacionCompra.IdTipoCbte_Ogiro), Convert.ToDecimal(Info_LiquidacionCompra.IdCbteCble_Ogiro));

                            if (Info_OrdenGiro != null)
                            {
                                //--====================== FORMA DE PAGO X LIQUIDACION DE COMPRA ================
                                cp_orden_giro_pagos_sri_Bus BusFormaPago = new cp_orden_giro_pagos_sri_Bus();
                                List<cp_orden_giro_pagos_sri_Info> listFormaPago = new List<cp_orden_giro_pagos_sri_Info>();
                                listFormaPago = BusFormaPago.Get_List_orden_giro_pagos_sri(IdEmpresa, Info_OrdenGiro.IdCbteCble_Ogiro, Info_OrdenGiro.IdTipoCbte_Ogiro);

                                //List<pagosPago> listFP = new List<pagosPago>();

                                if (listFormaPago.Count() > 0)
                                {
                                    listFormaPago = listFormaPago.Where(q => q.check == true).ToList();

                                    if (listFormaPago.Count() > 0)
                                    {
                                        myObject.infoLiquidacionCompra.pagos = new List<pagosPago>();

                                        double Couta_Pago = sum_Total / listFormaPago.Where(q => q.check == true).Count();

                                        foreach (var itemFP in listFormaPago.Where(q => q.check == true))
                                        {
                                            pagosPago InfoFP = new pagosPago();
                                            InfoFP.formaPago = itemFP.codigo_pago_sri;
                                            InfoFP.plazo = Info_OrdenGiro.co_plazo;
                                            InfoFP.total = Math.Round(Convert.ToDecimal(Couta_Pago), 2);
                                            InfoFP.unidadTiempo = "DIAS";

                                            myObject.infoLiquidacionCompra.pagos.Add(InfoFP);
                                        }
                                    }
                                }
                            }

                            #endregion

                            #region <detalles></detalles>

                            myObject.detalles = new List<detalle>();

                            foreach (var item2 in info_LiquidacionCompraSRI.LiquidacionCompra_Det)
                            {
                                double subtotal = 0;

                                detalle detalle = new detalle();
                                subtotal = item2.Cantidad * item2.Precio - item2.DescUnitario;
                                subtotal = Math.Round(subtotal, 2);
                                sum_totDescto = sum_totDescto + item2.DescUnitario;
                                sum_Total = sum_Total + item2.Total;
                                sum_Simpuesto = sum_Simpuesto + subtotal;
                                Total_LiquidacionCompra = Total_LiquidacionCompra + Convert.ToDecimal(item2.Total);

                                detalle.codigoPrincipal = Convert.ToString(item2.IdProducto);
                                detalle.codigoAuxiliar = item2.Codigo;
                                detalle.descripcion = item2.Descripcion;

                                in_Producto_Info Info_Producto = null;
                                in_UnidadMedida_Info Info_UnidadMedida = null;

                                Info_Producto = Bus_Producto.Get_info_Product(item2.IdEmpresa, Convert.ToDecimal(item2.IdProducto));

                                if (Info_Producto != null)
                                {
                                    if (!string.IsNullOrEmpty(Info_Producto.IdUnidadMedida))
                                        Info_UnidadMedida = Bus_UnidadMedida.Get_Info_UnidadMedida(Info_Producto.IdUnidadMedida);
                                }

                                if (Info_UnidadMedida != null)
                                {
                                    if (!string.IsNullOrEmpty(Info_UnidadMedida.cod_alterno))
                                        detalle.unidadMedida = Info_UnidadMedida.cod_alterno;
                                }

                                detalle.cantidad = Math.Round(Convert.ToDecimal(item2.Cantidad), 6, MidpointRounding.AwayFromZero);
                                detalle.precioUnitario = Math.Round(Convert.ToDecimal(item2.Precio), 6, MidpointRounding.AwayFromZero);
                                detalle.descuento = Math.Round(Convert.ToDecimal(item2.DescUnitario), 2, MidpointRounding.AwayFromZero);
                                detalle.precioTotalSinImpuesto = Math.Round(Convert.ToDecimal(subtotal), 6, MidpointRounding.AwayFromZero);

                                if (Info_UnidadMedida != null)
                                {
                                    detalle.detallesAdicionales = new List<detallesAdicionales>();

                                    detallesAdicionales det_adicional = new detallesAdicionales();
                                    det_adicional.nombre = "Medida";
                                    det_adicional.valor = Info_UnidadMedida.cod_alterno.Trim();

                                    detalle.detallesAdicionales.Add(det_adicional);
                                }

                                impuesto imp = new impuesto();
                                detalle.impuestos = new List<impuesto>();

                                if (item2.Iva > 0)
                                {
                                    imp.codigo = "2";//iva 

                                    if (item2.por_iva == 12)
                                    {
                                        imp.codigoPorcentaje = "2";
                                        imp.tarifa = 12;
                                    }
                                    else
                                    {
                                        if (item2.por_iva == 14)
                                        {
                                            imp.codigoPorcentaje = "3";
                                            imp.tarifa = 14;
                                        }
                                    }

                                    imp.baseImponible = Convert.ToDecimal(subtotal);
                                    imp.valor = Math.Round(Convert.ToDecimal(item2.Iva), 2);
                                }
                                else
                                {
                                    imp.codigo = "2";
                                    imp.codigoPorcentaje = "0";
                                    imp.tarifa = 0;
                                    imp.baseImponible = Convert.ToDecimal(subtotal);
                                    imp.valor = Convert.ToDecimal(item2.Iva);
                                }

                                detalle.impuestos.Add(imp);
                                myObject.detalles.Add(detalle);
                            }

                            #endregion

                            #region <infoAdicional></infoAdicional>

                            //campos adicionales 
                            myObject.infoAdicional = new List<infoAdicional>();

                            if (!String.IsNullOrEmpty(item.CorreoPrincipal)) //poniendo el correo como campo adicional
                            {
                                infoAdicional infoAdicional = new infoAdicional();

                                Cl_ValidarEmail_Info datosAdc = new Cl_ValidarEmail_Info();

                                if (datosAdc.email_bien_escrito(item.CorreoPrincipal))
                                {
                                    infoAdicional.Value = item.CorreoPrincipal;
                                    infoAdicional.nombre = "MAIL";

                                    myObject.infoAdicional.Add(infoAdicional);
                                }
                            }

                            if (!string.IsNullOrEmpty(Info_LiquidacionCompra.observacion))
                            {
                                infoAdicional infoAdicional = new infoAdicional();

                                infoAdicional.Value = Info_LiquidacionCompra.observacion;
                                infoAdicional.nombre = "observaciones";

                                myObject.infoAdicional.Add(infoAdicional);
                            }

                            //SI NO EXISTE INFORMACION ADICIONAL SETEAMOS EN NULL EL CAMPO
                            if (myObject.infoAdicional.Count() <= 0)
                            {
                                myObject.infoAdicional = null;
                            }

                            #endregion

                            lista.Add(myObject);
                        }
                    }
                }

                msg = "Archivo XML de Liquidación de Compra de Bienes y Prestacion de Servicios fue Generado con Exito.";

                return lista;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_List_Xml_LiquidacionCompra", ex.Message), ex) { EntityType = typeof(cp_liquidacion_compra_Bus) };
            }
        }

        public byte[] Get_Comprobante_Efirm_PDF(int IdEmpresa, decimal IdLiquidacionCompra, ref string IdComprobante, ref string mensaje_error)
        {
            try
            {
                tb_Comprobantes_Efirm_Bus Bus_Comprobante = new tb_Comprobantes_Efirm_Bus();
                cp_proveedor_Bus Bus_Proveedor = new cp_proveedor_Bus();
                cp_proveedor_Info Info_Proveedor;
                cp_liquidacion_compra_Info Info_LiquidacionCompra;
                cp_orden_giro_Info Info_OrdenGiro;
                cp_orden_giro_Bus Bus_OrdenGiro = new cp_orden_giro_Bus();
                byte[] result = null;
                int IdEmpresa_Efirm = 0;

                // Recuperar el registro de la liquidacion de compra
                Info_LiquidacionCompra = Get_Info(IdEmpresa, IdLiquidacionCompra);

                // Si el objeto no es vacio
                if (Info_LiquidacionCompra != null)
                {
                    // Obtiene el objeto de la factura de proveedor
                    Info_OrdenGiro = Bus_OrdenGiro.Get_Info_orden_giro(Convert.ToInt32(Info_LiquidacionCompra.IdEmpresa), Convert.ToInt32(Info_LiquidacionCompra.IdTipoCbte_Ogiro), Convert.ToDecimal(Info_LiquidacionCompra.IdCbteCble_Ogiro));

                    // Si el objeto de la factura de proveedor es vacio
                    if (Info_OrdenGiro == null)
                    {
                        mensaje_error = "No se ha encontrado relacion con el documento de proveedor Cbte Ogiro#" + Info_LiquidacionCompra.IdCbteCble_Ogiro;
                        throw new Exception(mensaje_error);
                    }

                    // 03 - Liquidacion de Compra
                    if(Info_OrdenGiro.IdOrden_giro_Tipo != "03")
                    {
                        mensaje_error = "El endpoint solo esta disponible para liquidaciones de compra";
                        throw new Exception(mensaje_error);
                    }

                    // Armar el campo IdComprobante para luego consultar en la base de datos de facturacion electronica
                    IdComprobante = Cl_Enumeradores.eTipoComprobante_Alias.LIQ + "-" + Info_LiquidacionCompra.serie1 + "-" + Info_LiquidacionCompra.serie2 + "-" + Info_LiquidacionCompra.NumDocumento;

                    // Si el campo IdComprobantes es null o vacio
                    if (string.IsNullOrEmpty(IdComprobante))
                    {
                        mensaje_error = "No se puede realizar la consulta para el comprobante #" + IdComprobante;
                        throw new Exception(mensaje_error);
                    }

                    // Obtiene el objeto de la tabla de proveedor
                    Info_Proveedor = Bus_Proveedor.Get_Info_Proveedor(Info_LiquidacionCompra.IdEmpresa, Info_OrdenGiro.IdProveedor);

                    // Si el objeto Info_Proveedor es null
                    if (Info_Proveedor == null)
                    {
                        mensaje_error = "No se puede realizar la consulta porque no existe la cedula/ruc para el proveedor Id#" + Info_OrdenGiro.IdProveedor;
                        throw new Exception(mensaje_error);
                    }

                    // Consulta al webservice para obtener el IdEmpresa_Efirm por el numero de cedula de la empresa
                    IdEmpresa_Efirm = Bus_Comprobante.Get_IdEmpresa_x_Ruc(param.InfoEmpresa.em_ruc, ref mensaje_error);

                    // Consultar el comprobante pdf
                    result = Bus_Comprobante.Get_RidePdf(IdEmpresa_Efirm, Info_Proveedor.Persona_Info.pe_cedulaRuc, IdComprobante, ref mensaje_error);
                }
                else
                {
                    mensaje_error = "No se encontraron registros para el comprobante de Liquidacion de Compra. #" + IdLiquidacionCompra;
                }

                return result;
            }
            catch (Exception ex)
            {
                mensaje_error = ex.Message;
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Comprobante_Efirm_PDF", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }
        }

        public string Get_Comprobante_Efirm_XML(int IdEmpresa, decimal IdLiquidacionCompra, ref string IdComprobante, ref string mensaje_error)
        {
            try
            {
                tb_Comprobantes_Efirm_Bus Bus_Comprobante = new tb_Comprobantes_Efirm_Bus();
                cp_proveedor_Bus Bus_Proveedor = new cp_proveedor_Bus();
                cp_proveedor_Info Info_Proveedor;
                cp_liquidacion_compra_Info Info_LiquidacionCompra;
                cp_orden_giro_Info Info_OrdenGiro;
                cp_orden_giro_Bus Bus_OrdenGiro = new cp_orden_giro_Bus();
                int IdEmpresa_Efirm = 0;
                string result = "";

                Info_LiquidacionCompra = Get_Info(IdEmpresa, IdLiquidacionCompra);

                if (Info_LiquidacionCompra != null)
                {
                    Info_OrdenGiro = Bus_OrdenGiro.Get_Info_orden_giro(Convert.ToInt32(Info_LiquidacionCompra.IdEmpresa), Convert.ToInt32(Info_LiquidacionCompra.IdTipoCbte_Ogiro), Convert.ToDecimal(Info_LiquidacionCompra.IdCbteCble_Ogiro));

                    if (Info_OrdenGiro == null)
                    {
                        mensaje_error = "No se ha encontrado relacion con el documento de proveedor Cbte Ogiro#" + Info_LiquidacionCompra.IdCbteCble_Ogiro;
                        throw new Exception(mensaje_error);
                    }

                    IdComprobante = Cl_Enumeradores.eTipoComprobante_Alias.LIQ + "-" + Info_LiquidacionCompra.serie1 + "-" + Info_LiquidacionCompra.serie2 + "-" + Info_LiquidacionCompra.NumDocumento;

                    if (string.IsNullOrEmpty(IdComprobante))
                    {
                        mensaje_error = "No se puede realizar la consulta para el comprobante #" + IdComprobante;
                        throw new Exception(mensaje_error);
                    }

                    Info_Proveedor = Bus_Proveedor.Get_Info_Proveedor(Info_LiquidacionCompra.IdEmpresa, Info_OrdenGiro.IdProveedor);

                    if (Info_Proveedor == null)
                    {
                        mensaje_error = "No se puede realizar la consulta porque no existe la cedula/ruc para el proveedor Id#" + Info_OrdenGiro.IdProveedor;
                        throw new Exception(mensaje_error);
                    }

                    IdEmpresa_Efirm = Bus_Comprobante.Get_IdEmpresa_x_Ruc(param.InfoEmpresa.em_ruc, ref mensaje_error);

                    result = Bus_Comprobante.Get_Xml(IdEmpresa_Efirm, Info_Proveedor.Persona_Info.pe_cedulaRuc, IdComprobante, ref mensaje_error);
                }
                else
                {
                    mensaje_error = "No se encontraron registros para el comprobante de Ret. #" + IdLiquidacionCompra;
                }

                return result;
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Comprobante_Efirm_XML", ex.Message), ex) { EntityType = typeof(cp_retencion_Bus) };
            }
        }
    }
}