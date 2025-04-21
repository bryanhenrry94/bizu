using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.Caja;
using Core.Erp.Business.Caja;
using Core.Erp.Business.Facturacion;
using Core.Erp.Reportes.CuentasxCobrar;
using Core.Erp.Reportes.Contabilidad;

namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_CobrosGenerales_Multiretenciones_Man : DevExpress.XtraEditors.XtraForm
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cxc_cobro_tipo_Bus busTipCobro = new cxc_cobro_tipo_Bus();
        List<cxc_cobro_tipo_Info> LstTipCobro = new List<cxc_cobro_tipo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        cxc_cobro_Info InfoGrabarRteFU = new cxc_cobro_Info();
        cxc_cobro_Info InfoGrabarRteIVA = new cxc_cobro_Info();
        List<cxc_cobro_Info> ListaGrabar = new List<cxc_cobro_Info>();

        string MensajeError = "";
        string Tipo_documento = "";
        int IDCaja = 0;
        int contRetFU = 0;
        int contRetIVA = 0;
        byte[] readBuffer;

        fa_factura_Info InfoFactura = new fa_factura_Info();
        fa_notaCreDeb_Info InfoNota = new fa_notaCreDeb_Info();
        fa_factura_Bus busFac = new fa_factura_Bus();
        fa_notaCredDeb_Bus busNd = new fa_notaCredDeb_Bus();

        cxc_cobro_Bus busCobro = new cxc_cobro_Bus();


        BindingList<vwcxc_cobros_x_vta_nota_x_Ret_Info> ListBindRtFU = new BindingList<vwcxc_cobros_x_vta_nota_x_Ret_Info>();
        BindingList<vwcxc_cobros_x_vta_nota_x_Ret_Info> ListBindRtIVA = new BindingList<vwcxc_cobros_x_vta_nota_x_Ret_Info>();

        public Cl_Enumeradores.eTipo_action Accion { get; set; }
        cxc_cobro_tipo_Param_conta_x_sucursal_Bus busParam = new cxc_cobro_tipo_Param_conta_x_sucursal_Bus();

        List<caj_Caja_Info> ListCaja = new List<Info.Caja.caj_Caja_Info>();
        caj_Caja_Bus busCaja = new caj_Caja_Bus();

        cxc_cobro_Info Info_Cobro = new cxc_cobro_Info();
        //List<cxc_cobro_Det_Info> list_det_cobro_Info = new List<cxc_cobro_Det_Info>();
        //fa_TipoNota_Bus BusTipoNota = new fa_TipoNota_Bus();
        //List<fa_TipoNota_Info> ListTipoNota = new List<fa_TipoNota_Info>();
        //cxc_parametro_Bus cxcParametroBus = new cxc_parametro_Bus();

        BindingList<vwcxc_cartera_x_cobrar_Info> bList = new BindingList<vwcxc_cartera_x_cobrar_Info>();

        public frmCxc_CobrosGenerales_Multiretenciones_Man()
        {
            InitializeComponent();
            try
            {
                cargarCombos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setAccion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        void cargarCombos()
        {
            try
            {
                LstTipCobro = busTipCobro.Get_List_Cobro_Tipo();
                cmb_TipoRteFU.DataSource = LstTipCobro.FindAll(var => var.ESRetenFTE.Trim() == "S");
                cmb_tipoRetIVA.DataSource = LstTipCobro.FindAll(var => var.ESRetenIVA.Trim() == "S");
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnu_salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private Boolean grabar()
        {
            //txtSubtotal.Focus();
            Boolean res = true;
            string mensajeE = "";
            int IdMultir = 0;

            try
            {
                if (validar())
                {
                    foreach (var item in ListaGrabar)
                    {
                        cxc_cobro_Info info = item;
                        info.infoReten.IdMultir = IdMultir;

                        info.infoReten.TotalRetencion = Convert.ToDouble(ListBindRtFU.Sum(q => q.dc_ValorPago));

                        if (!busCobro.GuardarDB(Cl_Enumeradores.PantallaEjecucion.COBROS, ref info, ref mensajeE))
                        {
                            mensajeE = mensajeE + " \n\n" + " Tipo Cobro: " + info.IdCobro_tipo + " Valor:" + info.dc_ValorPago;
                            res = false;
                        }
                        else
                        {
                            item.IdSucursal = info.IdSucursal;
                            item.IdCobro = info.IdCobro;
                            IdMultir = info.infoReten.IdMultir;

                            item.IdSucursal = info.IdSucursal;
                            item.IdCobro = info.IdCobro;
                        }
                    }

                    if (res == false)
                    {
                        MessageBox.Show("al menos uno de los cobros no se guardo.. :" + mensajeE, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se guardo con exito la retención.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (MessageBox.Show("¿Desea imprimir la retención?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {


                            switch (param.IdCliente_Ven_x_Default)
                            {
                                case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                                    CargarReporte();
                                    break;
                                case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                                    CargarReporte_diarios();
                                    break;
                                default:
                                    CargarReporte();
                                    if (MessageBox.Show("¿Desea imprimir los diarios de la retención?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        CargarReporte_diarios();
                                    }
                                    break;
                            }

                        }
                    }

                    btnGuardar.Enabled = false;
                    btnGuardarSalir.Enabled = false;
                }
                else res = false;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }
            return res;
        }

        private void btnGuardarSalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabar())
                { Close(); }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private Boolean validar()
        {
            Boolean res = true;
            try
            {
                ///Verifica que todos los Tipos de Cobros tengan asociados las Ctas Cbles Deudora y Acreedora en 
                ///la tabla cxc_cobro_tipo_Param_conta_x_sucursal
                {
                    //if (txtObservaciones.EditValue == null )
                    //{
                    //    MessageBox.Show("Ingrese la Observación.", param.Nombre_sistema, MessageBoxButtons.OK);
                    //    return false;
                    //}

                    List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> paramCxC = new List<cxc_cobro_tipo_Param_conta_x_sucursal_Info>();
                    paramCxC = busParam.Get_List_cobro_tipo_Param_conta_x_sucursal(param.IdEmpresa);
                    foreach (var item in ListBindRtFU)
                    {
                        if (item.Modificable == true)
                        {
                            if (item.IdCobro_tipo == "RTFTE1" || item.IdCobro_tipo == "RTFTE2")
                            {
                                cxc_cobro_tipo_Param_conta_x_sucursal_Info tipocobro = new cxc_cobro_tipo_Param_conta_x_sucursal_Info();
                                try
                                {
                                    tipocobro = paramCxC.First(var => var.IdCobro_tipo == item.IdCobro_tipo);
                                    if (tipocobro == null || tipocobro.IdCobro_tipo == null
                                        || String.IsNullOrEmpty(tipocobro.IdCtaCble))
                                    {
                                        MessageBox.Show("Por favor, verifique los parametros de Ctas Cbles x Tipos de Cobro..", param.Nombre_sistema, MessageBoxButtons.OK);
                                        return false;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Log_Error_bus.Log_Error(ex.ToString());
                                    MessageBox.Show("Por favor, verifique los parametros de Ctas Cbles x Tipos de Cobro..", param.Nombre_sistema, MessageBoxButtons.OK);
                                    return false;
                                }
                            }
                            else
                            {
                                cxc_cobro_tipo_Param_conta_x_sucursal_Info tipocobro = new cxc_cobro_tipo_Param_conta_x_sucursal_Info();
                                try
                                {
                                    tipocobro = paramCxC.First(var => var.IdCobro_tipo == item.IdCobro_tipo);
                                    if (tipocobro == null || tipocobro.IdCobro_tipo == null
                                        || String.IsNullOrEmpty(tipocobro.IdCtaCble))
                                    {
                                        MessageBox.Show("Por favor, verifique los parametros de Ctas Cbles x Tipos de Cobro..", param.Nombre_sistema, MessageBoxButtons.OK);
                                        return false;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Log_Error_bus.Log_Error(ex.ToString());
                                    MessageBox.Show("Por favor, verifique los parametros de Ctas Cbles x Tipos de Cobro..", param.Nombre_sistema, MessageBoxButtons.OK);
                                    return false;
                                }
                            }
                        }
                    }

                }
                ///No se actualiza por eso verifica que haya por lo menos un registro nuevo a grabar
                ///
                try
                {



                    if ((ListBindRtFU.Count < 1))
                    {
                        MessageBox.Show("Por favor, ingrese una nueva retención para grabar..", param.Nombre_sistema, MessageBoxButtons.OK);
                        return false;
                    }
                }

                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show("Por favor, ingrese una nueva retención para grabar..", param.Nombre_sistema, MessageBoxButtons.OK);
                    return false;
                }

                ///(ListBindRtFU.All(var => var.Modificable != true) 
                ///
                int cont = 0;
                foreach (var item in ListBindRtFU)
                {
                    if (item.Modificable == true)
                    {
                        if (item.IdCobro_tipo == "RTFTE1" || item.IdCobro_tipo == "RTFTE2")
                        {
                            if (Convert.ToDouble(item.Base) <= 0)
                            {
                                MessageBox.Show("Por favor, revise las Bases de la Rte FU, no puede ser 0.", param.Nombre_sistema, MessageBoxButtons.OK);
                                return false;
                            }
                            else
                                if (String.IsNullOrEmpty(item.IdCobro_tipo))
                                {
                                    MessageBox.Show("Por favor, seleccione los tipos de retención en la fuente..", param.Nombre_sistema, MessageBoxButtons.OK);
                                    return false;

                                }
                                else cont++;

                        }
                        else
                        {
                            if (Convert.ToDouble(item.Base) <= 0)
                            {
                                MessageBox.Show("Por favor, revise las Bases de la Rte IVA, no puede ser 0.", param.Nombre_sistema, MessageBoxButtons.OK);
                                return false;
                            }
                            else
                                if (String.IsNullOrEmpty(item.IdCobro_tipo))
                                {
                                    MessageBox.Show("Por favor, seleccione los tipos de retención en la fuente..", param.Nombre_sistema, MessageBoxButtons.OK);
                                    return false;

                                }
                                else cont++;
                        }

                    }
                }

                ////////
                //Validar que la que la factura tenga subtotal > 0 para aplicar retencion en la fuente y el iva sea > 0
                //para aplicar la retencion al iva
                double baseFuente = 0;
                double baseIva = 0;

                foreach (var item in ListBindRtFU)
                {
                    if (item.Modificable == true)
                    {
                        if (item.IdCobro_tipo == "RTFTE1" || item.IdCobro_tipo == "RTFTE2")
                        {
                            vwcxc_cartera_x_cobrar_Info infRetFuen = new vwcxc_cartera_x_cobrar_Info();

                            if (item.tipoDocumento == null)
                            {
                                vwcxc_cobros_x_vta_nota_x_Ret_Info infRen = new vwcxc_cobros_x_vta_nota_x_Ret_Info();
                                infRen = ListBindRtFU.FirstOrDefault(q => q.IdCbte_vta_nota == item.IdCbte_vta_nota && q.Base == item.Base);
                                item.tipoDocumento = infRen.tipoDocumento;
                                item.ESRetenFTE = infRen.ESRetenFTE;
                                item.ESRetenIVA = infRen.ESRetenIVA;
                                item.IdBodega_Cbte = infRen.IdBodega_Cbte;
                                item.IdCliente = infRen.IdCliente;
                                item.IdEmpresa = infRen.IdEmpresa;
                                item.IdSucursal = infRen.IdSucursal;
                                item.SubtotalFact = infRen.SubtotalFact;
                                item.tc_descripcion = infRen.tc_descripcion;

                            }
                            if (item.tipoDocumento == null)
                            {
                                MessageBox.Show("Por favor, revise el subtotal de la factura debe ser igual a la base" + "[" + item.IdCbte_vta_nota + "]", param.Nombre_sistema, MessageBoxButtons.OK);
                                return false;
                            }
                            infRetFuen = bList.FirstOrDefault(q => q.IdCbteVta == item.IdCbte_vta_nota && q.TipoDoc == item.tipoDocumento);
                            baseFuente = Convert.ToDouble(infRetFuen.vt_Subtotal);

                            if (Convert.ToDouble(baseFuente) <= 0)
                            {
                                MessageBox.Show("Por favor, revise el subtotal de la factura, no se puede aplicar una retención en la fuente, el subtotal debe ser mayor a 0.", param.Nombre_sistema, MessageBoxButtons.OK);
                                return false;
                            }

                        }
                        else
                        {
                            vwcxc_cartera_x_cobrar_Info infRetFuen = new vwcxc_cartera_x_cobrar_Info();

                            if (item.tipoDocumento == null)
                            {
                                vwcxc_cobros_x_vta_nota_x_Ret_Info infRenI = new vwcxc_cobros_x_vta_nota_x_Ret_Info();
                                infRenI = ListBindRtFU.FirstOrDefault(q => q.IdCbte_vta_nota == item.IdCbte_vta_nota && q.Base == item.Base);
                                item.tipoDocumento = infRenI.tipoDocumento;
                                item.ESRetenFTE = infRenI.ESRetenFTE;
                                item.ESRetenIVA = infRenI.ESRetenIVA;
                                item.IdBodega_Cbte = infRenI.IdBodega_Cbte;
                                item.IdCliente = infRenI.IdCliente;
                                item.IdEmpresa = infRenI.IdEmpresa;
                                item.IdSucursal = infRenI.IdSucursal;
                                item.SubtotalFact = infRenI.SubtotalFact;
                                item.tc_descripcion = infRenI.tc_descripcion;

                            }

                            if (item.tipoDocumento == null)
                            {
                                MessageBox.Show("Por favor, revise el iva de la factura debe ser igual a la base" + "[" + item.IdCbte_vta_nota + "]", param.Nombre_sistema, MessageBoxButtons.OK);
                                return false;
                            }
                            infRetFuen = bList.FirstOrDefault(q => q.IdCbteVta == item.IdCbte_vta_nota && q.TipoDoc == item.tipoDocumento);
                            baseIva = Convert.ToDouble(infRetFuen.vt_iva);

                            if (Convert.ToDouble(baseIva) <= 0)
                            {
                                MessageBox.Show("Por favor, revise el iva de la factura, no se puede aplicar una retencion del iva, el iva debe ser mayor a 0", param.Nombre_sistema, MessageBoxButtons.OK);
                                return false;
                            }
                        }

                    }
                }


                ////////
                if (cont == 0)
                {
                    MessageBox.Show("Por favor, ingrese una nueva retención para grabar..", param.Nombre_sistema, MessageBoxButtons.OK);
                    return false;

                }


                ///validar que la base de la Rte FU no sume más que el subtotal de la factura y el IVA
                ///
                double totalBase = 0;
                double totalBase2 = 0;




                foreach (var item in ListBindRtFU)
                {
                    totalBase = totalBase + Convert.ToDouble(item.Base);
                    if (item.IdCobro_tipo == "RTFTE1" || item.IdCobro_tipo == "RTFTE2")
                    {

                        vwcxc_cobros_x_vta_nota_x_Ret_Info infR = new vwcxc_cobros_x_vta_nota_x_Ret_Info();
                        infR = ListBindRtFU.FirstOrDefault(q => q.IdCbte_vta_nota == item.IdCbte_vta_nota);
                        totalBase2 = infR.SubtotalFact;
                        totalBase = totalBase2;

                        vwcxc_cartera_x_cobrar_Info infRe = new vwcxc_cartera_x_cobrar_Info();
                        infRe = bList.FirstOrDefault(q => q.IdCbteVta == item.IdCbte_vta_nota);

                        if (Math.Round(totalBase, 2) > Math.Round(Convert.ToDouble(infRe.vt_Subtotal), 2))
                        {
                            MessageBox.Show(
                                "Por favor, revise la suma de la Base de la Retención de la Fuente excede el Subtotal de la factura.."
                                , param.Nombre_sistema, MessageBoxButtons.OK);
                            return false;
                        }
                        totalBase = 0;
                    }
                    else
                    {
                        vwcxc_cobros_x_vta_nota_x_Ret_Info infR = new vwcxc_cobros_x_vta_nota_x_Ret_Info();
                        infR = ListBindRtFU.FirstOrDefault(q => q.IdCbte_vta_nota == item.IdCbte_vta_nota);
                        totalBase2 = infR.IvaFact;
                        totalBase = totalBase2;

                        vwcxc_cartera_x_cobrar_Info infRe = new vwcxc_cartera_x_cobrar_Info();
                        infRe = bList.FirstOrDefault(q => q.IdCbteVta == item.IdCbte_vta_nota);

                        if (Math.Round(totalBase, 2) > Math.Round(Convert.ToDouble(infRe.vt_iva), 2))
                        {
                            MessageBox.Show(
                                "Por favor, revise la suma de la Base de la Retención del IVA excede el IVA de la factura.."
                                , param.Nombre_sistema, MessageBoxButtons.OK);
                            return false;
                        }
                        totalBase = 0;
                    }
                }

                res = getInfo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }
            return res;

        }

        private Boolean getInfo()
        {
            Boolean res = true;
            double Valor = 0;
            ListaGrabar = new List<cxc_cobro_Info>();
            try
            {
                foreach (var item in ListBindRtFU)
                {
                    if (item.Modificable == true)
                    {
                        if (item.IdCobro_tipo == "RTFTE1" || item.IdCobro_tipo == "RTFTE2")
                        {
                            cxc_cobro_Info info = new cxc_cobro_Info();
                            cxc_cobro_Det_Info det = new cxc_cobro_Det_Info();
                            cxc_retencion_Multiple_Documento_Info infoRetenDoc = new cxc_retencion_Multiple_Documento_Info();
                            cxc_retencion_Multiple_Documentos_ValorAplicado_Info infoRetenDocValor = new cxc_retencion_Multiple_Documentos_ValorAplicado_Info();

                            ///cabecera
                            ///
                            info.infoReten.IdEmpresa = param.IdEmpresa;
                            info.infoReten.IdSucursal = item.IdSucursal;


                            info.infoReten.Fecha = Convert.ToDateTime((dtpFecha.Value).ToShortDateString());
                            info.infoReten.FechaIngreso = Convert.ToDateTime((dtpFechaIngreso.Value).ToShortDateString());
                            info.infoReten.FechaCobro = Convert.ToDateTime((dtpFechaIngreso.Value).ToShortDateString());

                            //info.infoReten.Fecha = Convert.ToDateTime(item.cr_fecha.ToShortDateString());
                            //info.infoReten.FechaIngreso = Convert.ToDateTime(item.cr_fechaDocu.ToShortDateString());
                            //info.infoReten.FechaCobro = Convert.ToDateTime(item.cr_fechaDocu.ToShortDateString());

                            info.infoReten.IdCliente = item.IdCliente;
                            info.infoReten.IdCaja = Convert.ToInt32(cmbCaja.EditValue);
                            info.infoReten.NumRetencion = "Reten";
                            info.infoReten.FechaRetencion = Convert.ToDateTime(item.cr_fechaDocu.ToShortDateString());
                            Valor = Valor + Convert.ToDouble(item.dc_ValorPago);
                            info.infoReten.TotalRetencion = Valor;
                            info.infoReten.Estado = "A";
                            info.cr_observacion = txtObservaciones.EditValue + "Ret:FTE" + item.PorcentajeRet + "% ";


                            info.IdEmpresa = det.IdEmpresa = param.IdEmpresa;
                            infoRetenDoc.IdEmpresa = param.IdEmpresa;
                            infoRetenDoc.IdEmpresa_cbteVta = item.IdEmpresa;
                            infoRetenDocValor.IdEmpresa = param.IdEmpresa;
                            infoRetenDocValor.IdEmpresa_cbteVta = item.IdEmpresa;

                            info.IdSucursal = item.IdSucursal;
                            det.IdSucursal = item.IdSucursal;
                            infoRetenDoc.IdSucursal_cbteVta = item.IdSucursal;
                            infoRetenDocValor.IdSucursal_cbteVta = item.IdSucursal;

                            info.IdBodega_Cbte = Convert.ToInt32(item.IdBodega_Cbte);
                            det.IdBodega_Cbte = Convert.ToInt32(item.IdBodega_Cbte);
                            infoRetenDoc.IdBodega_cbteVta = Convert.ToInt32(item.IdBodega_Cbte);
                            infoRetenDocValor.IdBodega_cbteVta = Convert.ToInt32(item.IdBodega_Cbte);

                            info.IdCliente = item.IdCliente;
                            det.IdCbte_vta_nota = item.IdCbte_vta_nota;
                            infoRetenDoc.IdCbteVta_cbteVta = Convert.ToInt32(item.IdCbte_vta_nota);
                            infoRetenDocValor.IdCbteVta_cbteVta = Convert.ToInt32(item.IdCbte_vta_nota);

                            info.dc_TipoDocumento = item.tipoDocumento;
                            det.dc_TipoDocumento = item.tipoDocumento;
                            infoRetenDoc.IdTipoDoc_cbteVta = item.tipoDocumento;
                            infoRetenDocValor.IdTipoDoc_cbteVta = item.tipoDocumento;

                            info.IdCaja = Convert.ToInt32(cmbCaja.EditValue);
                            info.IdCobro_tipo = item.IdCobro_tipo;
                            info.cr_NumDocumento = item.cr_NumDocumento;
                            infoRetenDocValor.IdCobro_tipo = item.IdCobro_tipo;

                            info.cr_fecha = Convert.ToDateTime((dtpFecha.Value).ToShortDateString());
                            info.cr_fechaDocu = Convert.ToDateTime((dtpFechaIngreso.Value).ToShortDateString());
                            info.cr_fechaCobro = Convert.ToDateTime((dtpFechaIngreso.Value).ToShortDateString());

                            //info.cr_fecha = Convert.ToDateTime(item.cr_fecha.ToShortDateString());
                            //info.cr_fechaDocu = Convert.ToDateTime(item.cr_fechaDocu.ToShortDateString());
                            //info.cr_fechaCobro = Convert.ToDateTime(item.cr_fechaDocu.ToShortDateString());


                            //-----info.cr_observacion = txtObservaciones.EditValue + "Ret:FTE" + item.PorcentajeRet + "% ";
                            info.estado = "A";
                            info.IdUsuario = det.IdUsuario = param.IdUsuario;
                            info.Fecha_Transac = det.Fecha_Transac = param.Fecha_Transac;
                            info.ip = param.ip;
                            info.nom_pc = param.nom_pc;
                            info.IdBanco = null;

                            ///detalle
                            ///
                            //------det.dc_TipoDocumento = txttipoDoc.Text.Trim();                        
                            det.secuencial = 1;
                            info.cr_TotalCobro = det.dc_ValorPago = Convert.ToDouble(item.dc_ValorPago);

                            infoRetenDocValor.Base = item.SubtotalFact;
                            infoRetenDocValor.PorcentajeRetenc = Convert.ToDouble(item.PorcentajeRet);
                            infoRetenDocValor.ValorRetenc = Convert.ToDouble(item.dc_ValorPago);

                            info.ListaCobro = new List<cxc_cobro_Det_Info>();
                            info.ListaCobro.Add(det);

                            info.ListaRetenDoc = new List<cxc_retencion_Multiple_Documento_Info>();
                            info.ListaRetenDoc.Add(infoRetenDoc);

                            info.ListaRetenDocValorApli = new List<cxc_retencion_Multiple_Documentos_ValorAplicado_Info>();
                            info.ListaRetenDocValorApli.Add(infoRetenDocValor);

                            ListaGrabar.Add(info);
                        }
                        else
                        {
                            cxc_cobro_Info info = new cxc_cobro_Info();
                            cxc_cobro_Det_Info det = new cxc_cobro_Det_Info();
                            cxc_retencion_Multiple_Documento_Info infoRetenDoc = new cxc_retencion_Multiple_Documento_Info();
                            cxc_retencion_Multiple_Documentos_ValorAplicado_Info infoRetenDocValor = new cxc_retencion_Multiple_Documentos_ValorAplicado_Info();
                            ///cabecera
                            ///

                            info.infoReten.IdEmpresa = param.IdEmpresa;
                            info.infoReten.IdSucursal = item.IdSucursal;

                            info.infoReten.Fecha = Convert.ToDateTime((dtpFecha.Value).ToShortDateString());
                            info.infoReten.FechaIngreso = Convert.ToDateTime((dtpFechaIngreso.Value).ToShortDateString());
                            info.infoReten.FechaCobro = Convert.ToDateTime((dtpFechaIngreso.Value).ToShortDateString());

                            //info.infoReten.Fecha = Convert.ToDateTime(item.cr_fecha.ToShortDateString());
                            //info.infoReten.FechaIngreso = Convert.ToDateTime(item.cr_fechaDocu.ToShortDateString());
                            //info.infoReten.FechaCobro = Convert.ToDateTime(item.cr_fechaDocu.ToShortDateString());

                            info.infoReten.IdCliente = item.IdCliente;
                            info.infoReten.IdCaja = Convert.ToInt32(cmbCaja.EditValue);
                            info.infoReten.NumRetencion = "Reten";
                            info.infoReten.FechaRetencion = Convert.ToDateTime(item.cr_fechaDocu.ToShortDateString());
                            Valor = Valor + Convert.ToDouble(item.dc_ValorPago);
                            info.infoReten.TotalRetencion = Valor;
                            info.infoReten.Estado = "A";
                            info.cr_observacion = txtObservaciones.EditValue + "Ret:IVA" + item.PorcentajeRet + "% ";

                            info.IdEmpresa = det.IdEmpresa = param.IdEmpresa;
                            infoRetenDoc.IdEmpresa = param.IdEmpresa;
                            infoRetenDoc.IdEmpresa_cbteVta = param.IdEmpresa;
                            infoRetenDocValor.IdEmpresa = param.IdEmpresa;
                            infoRetenDocValor.IdEmpresa_cbteVta = item.IdEmpresa;


                            info.IdSucursal = item.IdSucursal;
                            det.IdSucursal = item.IdSucursal;
                            infoRetenDoc.IdSucursal_cbteVta = item.IdSucursal;
                            infoRetenDocValor.IdSucursal_cbteVta = item.IdSucursal;

                            info.IdBodega_Cbte = Convert.ToInt32(item.IdBodega_Cbte);
                            det.IdBodega_Cbte = Convert.ToInt32(item.IdBodega_Cbte);
                            infoRetenDoc.IdBodega_cbteVta = Convert.ToInt32(item.IdBodega_Cbte);
                            infoRetenDocValor.IdBodega_cbteVta = Convert.ToInt32(item.IdBodega_Cbte);

                            info.IdCliente = item.IdCliente;
                            det.IdCbte_vta_nota = item.IdCbte_vta_nota;
                            infoRetenDoc.IdCbteVta_cbteVta = Convert.ToInt32(item.IdCbte_vta_nota);
                            infoRetenDocValor.IdCbteVta_cbteVta = Convert.ToInt32(item.IdCbte_vta_nota);

                            info.dc_TipoDocumento = item.tipoDocumento;
                            det.dc_TipoDocumento = item.tipoDocumento;
                            infoRetenDoc.IdTipoDoc_cbteVta = item.tipoDocumento;
                            infoRetenDocValor.IdTipoDoc_cbteVta = item.tipoDocumento;

                            info.IdCaja = Convert.ToInt32(cmbCaja.EditValue);
                            info.IdCobro_tipo = item.IdCobro_tipo;
                            info.cr_NumDocumento = item.cr_NumDocumento;
                            infoRetenDocValor.IdCobro_tipo = item.IdCobro_tipo;

                            info.cr_fecha = Convert.ToDateTime((dtpFecha.Value).ToShortDateString());
                            info.cr_fechaDocu = Convert.ToDateTime((dtpFechaIngreso.Value).ToShortDateString());
                            info.cr_fechaCobro = Convert.ToDateTime((dtpFechaIngreso.Value).ToShortDateString());

                            //info.cr_fecha = Convert.ToDateTime(item.cr_fecha.ToShortDateString());
                            //info.cr_fechaDocu = Convert.ToDateTime(item.cr_fechaDocu.ToShortDateString());
                            //info.cr_fechaCobro = Convert.ToDateTime(item.cr_fechaDocu.ToShortDateString());

                            //------info.cr_observacion = txtObservaciones.EditValue +  "Ret:IVA" + item.PorcentajeRet + "% ";
                            info.estado = "A";
                            info.IdUsuario = det.IdUsuario = param.IdUsuario;
                            info.Fecha_Transac = det.Fecha_Transac = param.Fecha_Transac;
                            info.ip = param.ip;
                            info.nom_pc = param.nom_pc;
                            info.IdBanco = null;
                            ///detalle
                            ///
                            //--------det.dc_TipoDocumento = txttipoDoc.Text.Trim();

                            det.secuencial = 1;
                            info.cr_TotalCobro = det.dc_ValorPago = Convert.ToDouble(item.dc_ValorPago);

                            infoRetenDocValor.Base = item.SubtotalFact;
                            infoRetenDocValor.PorcentajeRetenc = Convert.ToDouble(item.PorcentajeRet);
                            infoRetenDocValor.ValorRetenc = Convert.ToDouble(item.dc_ValorPago);

                            info.ListaCobro = new List<cxc_cobro_Det_Info>();
                            info.ListaCobro.Add(det);

                            info.ListaRetenDoc = new List<cxc_retencion_Multiple_Documento_Info>();
                            info.ListaRetenDoc.Add(infoRetenDoc);

                            info.ListaRetenDocValorApli = new List<cxc_retencion_Multiple_Documentos_ValorAplicado_Info>();
                            info.ListaRetenDocValorApli.Add(infoRetenDocValor);

                            ListaGrabar.Add(info);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }
            return res;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridViewRteFU_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "IdCobro_tipo")
                {

                    vwcxc_cobros_x_vta_nota_x_Ret_Info row = (vwcxc_cobros_x_vta_nota_x_Ret_Info)gridViewRteFU.GetFocusedRow();
                    if (row != null)
                    {
                        cxc_cobro_tipo_Info tipo = LstTipCobro.First(var => var.IdCobro_tipo == e.Value);
                        gridViewRteFU.SetFocusedRowCellValue("PorcentajeRet", tipo.PorcentajeRet);
                        if (row.Base != null && row.Base > 0)
                        {
                            gridViewRteFU.SetFocusedRowCellValue("dc_ValorPago", row.Base * row.PorcentajeRet / 100);
                        }
                        //contRetFU = 0;
                        if (contRetFU == 0)
                        {
                            gridViewRteFU.SetFocusedRowCellValue("Base", Convert.ToString(InfoFactura.Subtotal)); contRetFU = 1;
                            //Convert.ToString(InfoFactura.Subtotal)
                        }
                    }
                }
                else if (e.Column.FieldName == "Base")
                {
                    vwcxc_cobros_x_vta_nota_x_Ret_Info row = (vwcxc_cobros_x_vta_nota_x_Ret_Info)gridViewRteFU.GetFocusedRow();
                    if (row != null)
                    {

                        if (row.Base != null && row.Base > 0)
                        {
                            gridViewRteFU.SetFocusedRowCellValue("dc_ValorPago", row.Base * row.PorcentajeRet / 100);
                            gridViewRteFU.SetFocusedRowCellValue("Modificable", true);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewRteIVA_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "IdCobro_tipo")
                {
                    vwcxc_cobros_x_vta_nota_x_Ret_Info row = (vwcxc_cobros_x_vta_nota_x_Ret_Info)gridViewRteIVA.GetFocusedRow();
                    if (row != null)
                    {
                        cxc_cobro_tipo_Info tipo = LstTipCobro.First(var => var.IdCobro_tipo == e.Value);
                        gridViewRteIVA.SetFocusedRowCellValue("PorcentajeRet", tipo.PorcentajeRet);
                        if (row.Base != null && row.Base > 0)
                        {
                            gridViewRteIVA.SetFocusedRowCellValue("dc_ValorPago", row.Base * row.PorcentajeRet / 100);
                        }
                        gridViewRteIVA.SetFocusedRowCellValue("Modificable", true);
                        if (contRetIVA == 0)
                        {
                            gridViewRteIVA.SetFocusedRowCellValue("Base", Convert.ToString(InfoFactura.IVA)); contRetIVA = 1;
                        }
                    }
                }
                else if (e.Column.FieldName == "Base")
                {
                    vwcxc_cobros_x_vta_nota_x_Ret_Info row = (vwcxc_cobros_x_vta_nota_x_Ret_Info)gridViewRteIVA.GetFocusedRow();
                    if (row != null)
                    {

                        if (row.Base != null && row.Base > 0)
                        {
                            gridViewRteIVA.SetFocusedRowCellValue("dc_ValorPago", row.Base * row.PorcentajeRet / 100);
                            gridViewRteIVA.SetFocusedRowCellValue("Modificable", true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControlRteFU_Click(object sender, EventArgs e)
        {

        }

        private void gridViewRteFU_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                vwcxc_cobros_x_vta_nota_x_Ret_Info row = (vwcxc_cobros_x_vta_nota_x_Ret_Info)gridViewRteFU.GetFocusedRow();
                if (row != null)
                {
                    if (row.Modificable == false)
                    {
                        colcr_fechaCobro.OptionsColumn.AllowEdit = false;
                        colIdCobro_tipo2.OptionsColumn.AllowEdit = false;
                        colBase1.OptionsColumn.AllowEdit = false;
                        colPorcentajeRet2.OptionsColumn.AllowEdit = false;
                        coldc_ValorPago.OptionsColumn.AllowEdit = false;
                        colcr_NumDocumento1.OptionsColumn.AllowEdit = false;
                        colAutorizacion.OptionsColumn.AllowEdit = false;
                    }
                    else// if(row.Modificable == true)
                    {
                        colcr_fechaCobro.OptionsColumn.AllowEdit = true;
                        colIdCobro_tipo2.OptionsColumn.AllowEdit = true;
                        colBase1.OptionsColumn.AllowEdit = true;
                        colPorcentajeRet2.OptionsColumn.AllowEdit = true;
                        coldc_ValorPago.OptionsColumn.AllowEdit = true;
                        colcr_NumDocumento1.OptionsColumn.AllowEdit = true;
                        colAutorizacion.OptionsColumn.AllowEdit = true;
                    }
                }
                else
                {
                    colcr_fechaCobro.OptionsColumn.AllowEdit = true;
                    colIdCobro_tipo2.OptionsColumn.AllowEdit = true;
                    colBase1.OptionsColumn.AllowEdit = true;
                    colPorcentajeRet2.OptionsColumn.AllowEdit = true;
                    coldc_ValorPago.OptionsColumn.AllowEdit = true;
                    colcr_NumDocumento1.OptionsColumn.AllowEdit = true;
                    colAutorizacion.OptionsColumn.AllowEdit = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridViewRteIVA_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                vwcxc_cobros_x_vta_nota_x_Ret_Info row = (vwcxc_cobros_x_vta_nota_x_Ret_Info)gridViewRteIVA.GetFocusedRow();
                if (row != null)
                {
                    if (row.Modificable == false)
                    {
                        colcr_fecha_ri.OptionsColumn.AllowEdit = false;
                        colIdCobro_tipo3.OptionsColumn.AllowEdit = false;
                        colBase.OptionsColumn.AllowEdit = false;
                        colPorcentajeRet3.OptionsColumn.AllowEdit = false;
                        coldc_ValorPago1.OptionsColumn.AllowEdit = false;
                        colcr_NumDocumento.OptionsColumn.AllowEdit = false;
                    }
                    else //if (row.Modificable == true)
                    {
                        colcr_fecha_ri.OptionsColumn.AllowEdit = true;
                        colIdCobro_tipo3.OptionsColumn.AllowEdit = true;
                        colBase.OptionsColumn.AllowEdit = true;
                        colPorcentajeRet3.OptionsColumn.AllowEdit = true;
                        coldc_ValorPago1.OptionsColumn.AllowEdit = true;
                        colcr_NumDocumento.OptionsColumn.AllowEdit = true;
                    }
                }
                else
                {

                    colcr_fecha_ri.OptionsColumn.AllowEdit = true;
                    colIdCobro_tipo3.OptionsColumn.AllowEdit = true;
                    colBase.OptionsColumn.AllowEdit = true;
                    colPorcentajeRet3.OptionsColumn.AllowEdit = true;
                    coldc_ValorPago1.OptionsColumn.AllowEdit = true;
                    colcr_NumDocumento.OptionsColumn.AllowEdit = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewRteFU_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == "Delete")
                {

                    vwcxc_cobros_x_vta_nota_x_Ret_Info row = (vwcxc_cobros_x_vta_nota_x_Ret_Info)gridViewRteFU.GetFocusedRow();


                    if (row != null)
                    {
                        if (row.Modificable == false)
                        {
                            MessageBox.Show("No se puede modificar un registro grabado");
                        }
                        else
                            gridViewRteFU.DeleteSelectedRows();
                    }
                    else gridViewRteFU.DeleteSelectedRows();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewRteIVA_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == "Delete")
                {

                    vwcxc_cobros_x_vta_nota_x_Ret_Info row = (vwcxc_cobros_x_vta_nota_x_Ret_Info)gridViewRteIVA.GetFocusedRow();

                    if (row != null)
                    {
                        if (row.Modificable == false)
                        {
                            MessageBox.Show("No se puede modificar un registro grabado");
                        }
                        else
                            gridViewRteIVA.DeleteSelectedRows();
                    }
                    else gridViewRteIVA.DeleteSelectedRows();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCxc_CobrosGenerales_Multiretenciones_Man_Load(object sender, EventArgs e)
        {
            try
            {
                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    btnGuardar.Enabled = true;
                    btnGuardarSalir.Enabled = true;
                    gridViewRteIVA.OptionsBehavior.ReadOnly = true;
                    gridViewRteIVA.OptionsBehavior.ReadOnly = true;

                    ListCaja = busCaja.Get_list_caja(param.IdEmpresa, ref  MensajeError);
                    cmbCaja.Properties.DataSource = ListCaja;

                    cxc_parametro_Bus busParam = new cxc_parametro_Bus();
                    cxc_parametro_Info infoparam = new cxc_parametro_Info();

                    infoparam = busParam.Get_Info_parametro(param.IdEmpresa);
                    if (infoparam != null)
                        cmbCaja.EditValue = infoparam.pa_IdCaja_x_Default;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void gridViewRteFU_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                vwcxc_cobros_x_vta_nota_x_Ret_Info row = (vwcxc_cobros_x_vta_nota_x_Ret_Info)gridViewRteFU.GetFocusedRow();
                if (row != null)
                {
                    if (row.Modificable == false)
                    {
                        colcr_fechaCobro.OptionsColumn.AllowEdit = false;
                        colIdCobro_tipo2.OptionsColumn.AllowEdit = false;
                        colBase1.OptionsColumn.AllowEdit = false;
                        colPorcentajeRet2.OptionsColumn.AllowEdit = false;
                        coldc_ValorPago.OptionsColumn.AllowEdit = false;
                        colcr_NumDocumento1.OptionsColumn.AllowEdit = false;
                        colAutorizacion.OptionsColumn.AllowEdit = true;
                    }
                    else// if(row.Modificable == true)
                    {
                        colcr_fechaCobro.OptionsColumn.AllowEdit = true;
                        colIdCobro_tipo2.OptionsColumn.AllowEdit = true;
                        colBase1.OptionsColumn.AllowEdit = true;
                        colPorcentajeRet2.OptionsColumn.AllowEdit = true;
                        coldc_ValorPago.OptionsColumn.AllowEdit = true;
                        colcr_NumDocumento1.OptionsColumn.AllowEdit = true;
                        colAutorizacion.OptionsColumn.AllowEdit = true;
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                        CargarReporte();
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        CargarReporte_diarios();
                        break;
                    default:
                        CargarReporte();
                        if (MessageBox.Show("¿Desea imprimir los diarios de la retención?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            CargarReporte_diarios();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void CargarReporte()
        {
            try
            {
                XCXC_Rpt016_Rpt reporte = new XCXC_Rpt016_Rpt();
                reporte.RequestParameters = false;
                reporte.PIdEmpresa.Value = Tipo_documento == "FACT" ? InfoFactura.IdEmpresa : InfoNota.IdEmpresa;
                reporte.PIdEmpresa.Visible = false;
                reporte.PIdSucursal.Value = Tipo_documento == "FACT" ? InfoFactura.IdSucursal : InfoNota.IdSucursal;
                reporte.PIdSucursal.Visible = false;
                reporte.PIdBodega_Cbte.Value = Tipo_documento == "FACT" ? InfoFactura.IdBodega : InfoNota.IdBodega;
                reporte.PIdBodega_Cbte.Visible = false;
                reporte.PIdCbte_vta_nota.Value = Tipo_documento == "FACT" ? InfoFactura.IdCbteVta : InfoNota.IdNota;
                reporte.PIdCbte_vta_nota.Visible = false;
                reporte.PTipoDocumento.Value = Tipo_documento;
                reporte.PTipoDocumento.Visible = false;

                reporte.ShowPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void CargarReporte_diarios()
        {
            try
            {
                cxc_cobro_x_ct_cbtecble_Bus bus_cbte_x_cobro = new cxc_cobro_x_ct_cbtecble_Bus();
                foreach (var item in ListaGrabar)
                {
                    cxc_cobro_x_ct_cbtecble_Info info_cbte_x_cobro = new cxc_cobro_x_ct_cbtecble_Info();
                    info_cbte_x_cobro = bus_cbte_x_cobro.Get_Info_cobro_x_ct_cbtecble(item.IdEmpresa, item.IdSucursal, item.IdCobro);

                    if (info_cbte_x_cobro != null)
                    {
                        XCONTA_Rpt003_rpt reporte = new XCONTA_Rpt003_rpt();

                        reporte.set_parametros(param.IdEmpresa, info_cbte_x_cobro.ct_IdTipoCbte, info_cbte_x_cobro.ct_IdCbteCble);
                        reporte.RequestParameters = false;
                        reporte.ShowPreviewDialog();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ucFa_ClienteCmb1_event_cmb_cliente_EditValueChanged(object sender, EventArgs e)
        {
            txeSaldoPendiente.EditValue = txeValor.EditValue;
            CargarGrillaXCliente();
        }

        public void CargarGrillaXCliente()
        {
            try
            {
                bList = new BindingList<vwcxc_cartera_x_cobrar_Info>(busCobro.NotasCreditoConFacturaXCobrar(param.IdEmpresa, ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal, ucFa_ClienteCmb1.get_ClienteInfo().IdCliente));

                if (bList.Count() > 0)
                {
                    foreach (var item in bList)
                    {
                        item.TotalxCobrado = 0;
                    }

                    if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        bList = new BindingList<vwcxc_cartera_x_cobrar_Info>(bList.Where(q => q.Saldo > 0 && q.Estado == "A").ToList());
                        bList = new BindingList<vwcxc_cartera_x_cobrar_Info>(bList.Where(q => q.dc_ValorRetFu <= 0 && q.vt_Subtotal > 0 || q.dc_ValorRetIva <= 0 && q.vt_iva > 0).ToList());
                        //bList = new BindingList<vwcxc_cartera_x_cobrar_Info>(bList.Where(q => q.vt_Subtotal > 0 || q.vt_iva > 0).ToList());
                    }
                    else
                    {
                        List<cxc_cobro_Det_Info> LstdetCobro = new List<cxc_cobro_Det_Info>();
                        cxc_cobro_Det_Bus BusDet_cobro = new cxc_cobro_Det_Bus();
                        LstdetCobro = BusDet_cobro.Get_List_Cobro_detalle(param.IdEmpresa, Info_Cobro.IdSucursal, Info_Cobro.IdCobro);
                        List<vwcxc_cartera_x_cobrar_Info> detalle = new List<vwcxc_cartera_x_cobrar_Info>();
                        foreach (cxc_cobro_Det_Info item in LstdetCobro)
                        {
                            vwcxc_cartera_x_cobrar_Info inf = new vwcxc_cartera_x_cobrar_Info();
                            inf = bList.FirstOrDefault(q => q.IdCbteVta == item.IdCbte_vta_nota);
                            inf.TotalxCobrado = item.dc_ValorPago;
                            inf.Check = true;
                            inf.SaldoAUX = inf.SaldoAUX + item.dc_ValorPago;
                            detalle.Add(inf);
                        }
                        if (Accion == Cl_Enumeradores.eTipo_action.actualizar && detalle.Count == 0)
                            bList = new BindingList<vwcxc_cartera_x_cobrar_Info>(bList.Where(q => q.Saldo > 0).ToList());
                        else
                            bList = new BindingList<vwcxc_cartera_x_cobrar_Info>(detalle);
                    }
                    gridControlCobro.DataSource = bList;
                }
                else
                {
                    gridControlRteFU.DataSource = bList;
                }



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EliminarLista(int indice)
        {
            ListBindRtFU.RemoveAt(indice);
        }

        private void gridViewCobros_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.HitInfo.Column == null) return;
                e.HitInfo.Column.FieldName = gridViewCobros.FocusedColumn.FieldName;

                vwcxc_cartera_x_cobrar_Info row1 = new vwcxc_cartera_x_cobrar_Info();
                row1 = (vwcxc_cartera_x_cobrar_Info)gridViewCobros.GetRow(e.RowHandle);
                if (row1 != null)
                {
                    if (row1.Check == true)
                    {
                        gridViewCobros.SetFocusedRowCellValue(colCheck, false);

                        if (ListBindRtFU.Count() > 0)
                        {
                            var Eliminar = ListBindRtFU.Where(x => x.IdCbte_vta_nota != row1.IdCbteVta);
                            var lstConcat = ListBindRtIVA.Concat(Eliminar).ToList();
                            ListBindRtFU = new BindingList<vwcxc_cobros_x_vta_nota_x_Ret_Info>(lstConcat);
                            gridControlRteFU.DataSource = ListBindRtFU;
                        }

                    }
                    else
                    {
                        if (e.HitInfo.Column.FieldName == "Check")
                        {
                            if (row1.TipoDoc == "FACT")
                            {
                                InfoFactura = busFac.Get_Info_factura(row1.IdEmpresa, row1.IdSucursal, row1.IdBodega, row1.IdCbteVta);

                            }
                            else
                            {
                                InfoNota = busNd.Get_Info_notaCreDeb_x_ND(row1.IdEmpresa, row1.IdSucursal, row1.IdBodega, row1.IdCbteVta);

                            }

                            //Cargamos en el grid de retenciones                            
                            LstTipCobro = busTipCobro.Get_List_Cobro_Tipo();
                            cmb_TipoRteFU.DataSource = LstTipCobro.FindAll(var => var.IdMotivo_tipo_cobro.Trim() == "RET");

                            if (row1.vt_Subtotal > 0)
                            {
                                if (row1.dc_ValorRetFu <= 0)
                                {
                                    vwcxc_cobros_x_vta_nota_x_Ret_Info info_cobro = new vwcxc_cobros_x_vta_nota_x_Ret_Info();
                                    info_cobro.IdEmpresa = param.IdEmpresa;
                                    info_cobro.IdSucursal = row1.IdSucursal;
                                    info_cobro.IdCobro_tipo = "RTFTE1";
                                    info_cobro.ESRetenFTE = "S";
                                    info_cobro.SubtotalFact = Convert.ToDouble(row1.vt_Subtotal);
                                    info_cobro.Base = Convert.ToDouble(row1.vt_Subtotal);
                                    info_cobro.PorcentajeRet = 1;
                                    info_cobro.dc_ValorPago = (row1.vt_Subtotal * 1) / 100;
                                    info_cobro.tipoDocumento = row1.TipoDoc;
                                    info_cobro.IdBodega_Cbte = row1.IdBodega;
                                    info_cobro.IdCbte_vta_nota = row1.IdCbteVta;
                                    info_cobro.IdCliente = row1.IdCliente;

                                    ListBindRtFU.Add(info_cobro);
                                }
                            }

                            if (row1.vt_iva > 0)
                            {
                                if (row1.dc_ValorRetIva <= 0)
                                {
                                    vwcxc_cobros_x_vta_nota_x_Ret_Info info_cobro = new vwcxc_cobros_x_vta_nota_x_Ret_Info();
                                    info_cobro.IdEmpresa = param.IdEmpresa;
                                    info_cobro.IdSucursal = row1.IdSucursal;
                                    info_cobro.IdCobro_tipo = "RTIVA10";
                                    info_cobro.ESRetenFTE = "S";
                                    info_cobro.SubtotalFact = Convert.ToDouble(row1.vt_iva);
                                    info_cobro.Base = Convert.ToDouble(row1.vt_iva);
                                    info_cobro.PorcentajeRet = 10;
                                    info_cobro.dc_ValorPago = (row1.vt_iva * 10) / 100;
                                    info_cobro.tipoDocumento = row1.TipoDoc;
                                    info_cobro.IdBodega_Cbte = row1.IdBodega;
                                    info_cobro.IdCbte_vta_nota = row1.IdCbteVta;
                                    info_cobro.IdCliente = row1.IdCliente;

                                    ListBindRtFU.Add(info_cobro);
                                }
                            }

                            gridControlRteFU.DataSource = ListBindRtFU;
                            gridControlRteIVA.DataSource = ListBindRtIVA;



                            gridViewCobros.SetFocusedRowCellValue(colCheck, true);



                        }
                    }
                }
                else
                {
                    gridViewCobros.SetFocusedRowCellValue(colCheck, false);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Sumar();
        }

        public void Sumar()
        {
            try
            {
                vwcxc_cartera_x_cobrar_Info row = new vwcxc_cartera_x_cobrar_Info();
                row = (vwcxc_cartera_x_cobrar_Info)gridViewCobros.GetRow(gridViewCobros.FocusedRowHandle);

                if (row.Check)
                {

                    if (Math.Round(Convert.ToDouble(gridViewCobros.GetFocusedRowCellValue(colSaldo)), 2) < Math.Round(Convert.ToDouble(txeSaldoPendiente.EditValue), 2))
                    {

                        if (Convert.ToDecimal(gridViewCobros.GetFocusedRowCellValue(colSaldo)) > 0)
                        {
                            if ((double)gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado) == 0)
                            {
                                gridViewCobros.SetFocusedRowCellValue(colTotalxCobrado, gridViewCobros.GetFocusedRowCellValue(colSaldo));
                            }
                        }
                        if (Convert.ToDouble(txeSaldoPendiente.EditValue) < Convert.ToDouble(gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado)))
                        {
                        }

                    }
                    else
                    {
                        if (Math.Round(Convert.ToDouble(txeSaldoPendiente.EditValue), 2) < Math.Round(Convert.ToDouble(gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado)), 2))
                        {
                        }
                        else
                        {
                            gridViewCobros.SetFocusedRowCellValue(colTotalxCobrado, Convert.ToDouble(txeSaldoPendiente.EditValue));
                            ///resta check true
                            //gridViewCobros.SetFocusedRowCellValue(colSaldo, (double)gridViewCobros.GetFocusedRowCellValue(colSaldo) - (double)gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado));
                        }
                        txeSaldoPendiente.EditValue = 0;
                        //ojooo
                    }
                }
                //resta check
                double TotalxCobrado = (double)gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado);
                if (TotalxCobrado == 0)
                {
                    gridViewCobros.SetFocusedRowCellValue(colSaldo, (double)gridViewCobros.GetFocusedRowCellValue(saldoAUX) - (double)gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado));
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControlCobro_Click(object sender, EventArgs e)
        {

        }

        private void btn_Importar_XML_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListBindRtFU.Count() > 0)
                {

                    Stream myStream = null;
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();

                    openFileDialog1.InitialDirectory = "c:\\";
                    openFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                    openFileDialog1.FilterIndex = 2;
                    openFileDialog1.RestoreDirectory = true;

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {

                        if ((myStream = openFileDialog1.OpenFile()) != null)
                        {

                            string path = "";
                            path = openFileDialog1.FileName;

                            Core.Erp.Info.class_sri.FacturaV2.factura InfoFactura_SRI = new Core.Erp.Info.class_sri.FacturaV2.factura();

                            string numAutoriza = "";
                            DateTime fechAutoriza = new DateTime();

                            tb_Proceso_SRI_Bus bus_proSri = new tb_Proceso_SRI_Bus();
                            vwcxc_cobros_x_vta_nota_x_Ret_Info InfoAutorizacion = new vwcxc_cobros_x_vta_nota_x_Ret_Info();
                            string mensaje = "";
                            InfoAutorizacion = bus_proSri.Deserializar_factura_SRI_Poli(path, ref numAutoriza, ref fechAutoriza, ref mensaje);

                            if (InfoAutorizacion != null)
                            {
                                //llenado de campos  
                                if (ListBindRtFU.Count() > 0)
                                {
                                    foreach (var item in ListBindRtFU)
                                    {
                                        item.dc_Autorizacion = numAutoriza;
                                    }
                                    gridControlRteFU.DataSource = null;
                                    gridControlRteFU.DataSource = ListBindRtFU;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error al Importar XML : " + mensaje);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //Log_Error_bus.Log_Error(ex.ToString());
                //MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Error al Importar XML Error de Formato o Estructura o no Autorizado por el SRI...\n\n\n ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ListBindRtFU.Count() > 0)
            {
                Stream myStream = null;
                OpenFileDialog openFileDialog2 = new OpenFileDialog();

                openFileDialog2.InitialDirectory = "c:\\";
                openFileDialog2.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
                openFileDialog2.FilterIndex = 2;
                openFileDialog2.RestoreDirectory = true;

                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = openFileDialog2.OpenFile()) != null)
                    {

                        string path = "";
                        path = openFileDialog2.FileName;
                        readBuffer = System.IO.File.ReadAllBytes(path);

                        if (ListBindRtFU.Count() > 0)
                        {
                            foreach (var item in ListBindRtFU)
                            {
                                item.DocumentoPDF = Convert.ToString(readBuffer);
                            }
                            gridControlRteFU.DataSource = null;
                            gridControlRteFU.DataSource = ListBindRtFU;
                        }
                    }
                }
            }
        }

        private void btnGuardarPdf_Click(object sender, EventArgs e)
        {

        }
    }
}