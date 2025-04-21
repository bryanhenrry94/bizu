using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.class_sri.FacturaV2;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Stream = System.IO.Stream;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Aprobacion_Ing_Bod_x_OC_Mant : DevExpress.XtraEditors.XtraForm
    {        
        Cl_Enumeradores.eTipo_action Accion;
        public delegate void delegate_frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing event_frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing;

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ct_centro_costo_sub_centro_costo_Bus bus_subcentro = new ct_centro_costo_sub_centro_costo_Bus();
        ct_Centro_costo_Bus Bus_CentroCosto = new ct_Centro_costo_Bus();
        ct_Plancta_Bus BusPlanCta = new ct_Plancta_Bus();
        ct_punto_cargo_Bus bus_puntoCargo = new ct_punto_cargo_Bus();
        cp_Aprobacion_Ing_Bod_x_OC_Bus Bus_Aprob = new cp_Aprobacion_Ing_Bod_x_OC_Bus();
        cp_orden_giro_pagos_sri_Bus pagoSRI_B = new cp_orden_giro_pagos_sri_Bus();
        cp_parametros_Bus data_cpParam = new cp_parametros_Bus();
        cp_proveedor_Bus BusProveedor = new cp_proveedor_Bus();
        cp_codigo_SRI_Bus dat_ti = new cp_codigo_SRI_Bus();
        cp_parametros_Bus bus_cpParam = new cp_parametros_Bus();
        tb_persona_bus BusPersona = new tb_persona_bus();

        List<ct_Plancta_Info> listPlanCta = new List<ct_Plancta_Info>();
        List<ct_centro_costo_sub_centro_costo_Info> listaSubcentero = new List<ct_centro_costo_sub_centro_costo_Info>();
        List<ct_punto_cargo_Info> listPuntoCargo = new List<ct_punto_cargo_Info>();
        List<ct_Centro_costo_Info> list_centroCosto = new List<ct_Centro_costo_Info>();
        List<cp_TipoDocumento_Info> LstTipDoc = new List<cp_TipoDocumento_Info>();
        List<cp_orden_giro_pagos_sri_Info> lst_formasPagoSRI = new List<cp_orden_giro_pagos_sri_Info>();
        List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> list_Aprob = new List<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
        List<cp_codigo_SRI_Info> ListCodigoSRI = new List<cp_codigo_SRI_Info>();
        BindingList<cp_Aprobacion_Ing_Bod_x_OC_det_Info> lstBind = new BindingList<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
        BindingList<cp_orden_giro_pagos_sri_Info> BindingList_pagosSRI;

        cp_Aprobacion_Ing_Bod_x_OC_Info Info;
        cp_Aprobacion_Ing_Bod_x_OC_det_Info InfoDet = new cp_Aprobacion_Ing_Bod_x_OC_det_Info();
        cp_orden_giro_Info Info_OrdenGiro = new cp_orden_giro_Info();
        public cp_Aprobacion_Ing_Bod_x_OC_Info _SetInfo { get; set; }       
        cp_proveedor_Info InfoProveedor = new cp_proveedor_Info();
        tb_persona_Info InfoPersona = new tb_persona_Info();
        cp_parametros_Info info_cpParam;
        
        int RowHandle = 0;
        double SumDescuento = 0;
        double SumValorIva = 0;
        double SumSubtotal = 0;
        double SumTotal = 0;
        double SumSubtotal0 = 0;
        double SumSubtotaliva = 0;

        byte[] readBuffer2;
        string NumAutoriza = "";
        string Establecimiento = "";
        string Pto_Emision = "";
        
        public frmCP_Aprobacion_Ing_Bod_x_OC_Mant()
        {
            InitializeComponent();

            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
            event_frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing += frmCP_Aprobacion_Ing_Bod_x_OC_Mant_event_frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing;
            ucCp_Proveedor1.event_cmb_proveedor_EditValueChanged += ucCp_Proveedor1_event_cmb_proveedor_EditValueChanged;
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            Anular();
            this.Close();
        }

        void ucCp_Proveedor1_event_cmb_proveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucCp_Proveedor1.get_ProveedorInfo() != null)
                {
                    Buscar_Ingresos();
                    if (String.IsNullOrEmpty(ucCp_Proveedor1.get_ProveedorInfo().IdCtaCble_Gasto))
                    {
                        info_cpParam = new cp_parametros_Info();
                        info_cpParam = bus_cpParam.Get_Info_parametros(param.IdEmpresa);
                    }
                }
                else
                    LimpiarDatos();

                if (ucCp_Proveedor1.get_ProveedorInfo() != null)
                {
                    if (ucCp_Proveedor1.get_ProveedorInfo().idCredito_Predeter != null)
                        cmbSustTrib.EditValue = ucCp_Proveedor1.get_ProveedorInfo().idCredito_Predeter;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void get_reembolso_y_formasPago()
        {
            lst_formasPagoSRI = BindingList_pagosSRI.ToList();
        }

        void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar()) return;
                if (grabar()) Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar()) return;
                grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmCP_Aprobacion_Ing_Bod_x_OC_Mant_event_frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        void cargar_combos()
        {
            try
            {
                string MensajeError = "";

                // carga combo Sustento Tributario
                cp_codigo_SRI_Bus dat_ti = new cp_codigo_SRI_Bus();
                ListCodigoSRI = dat_ti.Get_List_codigo_SRI_(param.IdEmpresa).FindAll(c => c.co_estado == "A" && c.IdTipoSRI == "COD_IDCREDITO");

                cmbSustTrib.Properties.DataSource = ListCodigoSRI;
                cmbSustTrib.Properties.DisplayMember = "descriConcate";
                cmbSustTrib.Properties.ValueMember = "IdCodigo_SRI";

                // carga combo Tipo Documento
                cp_TipoDocumento_Bus TipDoc_B = new cp_TipoDocumento_Bus();
                LstTipDoc = TipDoc_B.Get_List_TipoDocumento().FindAll(c => c.CodSRI != "04" && c.CodSRI != "05");
                LstTipDoc.ForEach(c => c.Descripcion = "[" + c.CodSRI + "] - " + c.Descripcion);
                cmbTipoDocu.Properties.DataSource = LstTipDoc;
                cmbTipoDocu.Properties.DisplayMember = "Descripcion";
                cmbTipoDocu.Properties.ValueMember = "CodTipoDocumento";

                // carga plan de cuentas
                listPlanCta = new List<ct_Plancta_Info>();
                listPlanCta = BusPlanCta.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
                cmbCtaCtble_Gasto_x_cxp.DataSource = listPlanCta;

                // carga punto de cargo
                listPuntoCargo = bus_puntoCargo.Get_List_PuntoCargo(param.IdEmpresa);
                CmbPuntoCargo.DataSource = listPuntoCargo;

                // carga centro de costo
                list_centroCosto = new List<ct_Centro_costo_Info>();
                list_centroCosto = Bus_CentroCosto.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);
                cmb_centroCosoto.DataSource = list_centroCosto;

                // carga subcentro de costo
                listaSubcentero = bus_subcentro.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                cmbSubcentro.DataSource = listaSubcentero;

                // carga orden giro pagos sri
                BindingList_pagosSRI = new BindingList<cp_orden_giro_pagos_sri_Info>();
                cp_orden_giro_pagos_sri_Bus BusPagosSri = new cp_orden_giro_pagos_sri_Bus();
                BindingList_pagosSRI = new BindingList<cp_orden_giro_pagos_sri_Info>(BusPagosSri.Get_List_orden_giro_pagos_sri(0, 0, 0));
                gridControl_formasPagoSRI.DataSource = BindingList_pagosSRI;
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_Aprobacion_Ing_Bod_x_OC_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFecFactura.EditValue = DateTime.Now;
                dtp_fecha_contabilizacion.EditValue = DateTime.Now;
                dtpFecAproba.EditValue = DateTime.Now;

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.EDEHSA:
                        de_FechaVctoAuto.Visible = false;
                        lblFechaVctoAuto.Visible = false;
                        col_relacion_centro_cuenta.Visible = false;
                        Col_PuntoCargoFJ.Visible = false;
                        Col_CentroCosto.Visible = true;
                        ColIdSubcentroCosoto.Visible = false;
                        colDescuento.Visible = false;
                        break;
                    default:
                        col_relacion_centro_cuenta.Visible = false;
                        Col_PuntoCargoFJ.Visible = false;
                        Col_CentroCosto.Visible = true;
                        ColIdSubcentroCosoto.Visible = false;
                        break;
                }

                cargar_combos();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        info_cpParam = new cp_parametros_Info();
                        info_cpParam = bus_cpParam.Get_Info_parametros(param.IdEmpresa);
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        SetInfo();
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        SetInfo();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getInfo()
        {
            try
            {
                Info = new cp_Aprobacion_Ing_Bod_x_OC_Info();
                Info.IdEmpresa = param.IdEmpresa;
                Info.IdAprobacion = Convert.ToDecimal((txtIdAprobacion.EditValue == "") ? 0 : Convert.ToDecimal(txtIdAprobacion.EditValue));
                Info.Fecha_Factura = Convert.ToDateTime(dtpFecFactura.EditValue);
                Info.Fecha_aprobacion = Convert.ToDateTime(dtpFecAproba.EditValue);
                Info.co_FechaContabilizacion = Convert.ToDateTime(Convert.ToDateTime(dtp_fecha_contabilizacion.EditValue).ToShortDateString());
                Info.Fecha_vcto = Convert.ToDateTime(dtpFecVtc.EditValue);
                Info.co_plazo = Convert.ToInt32(txt_plazo.Text);
                Info.IdOrden_giro_Tipo = Convert.ToString(cmbTipoDocu.EditValue).Trim();
                Info.IdIden_credito = Convert.ToInt32(cmbSustTrib.EditValue);
                Info.IdProveedor = ucCp_Proveedor1.get_ProveedorInfo().IdProveedor;

                string[] serie = Convert.ToString(txeSerie.EditValue).Split('-');
                Establecimiento = serie[0];
                Pto_Emision = serie[1];
                Info.Observacion = Convert.ToString(txtObservacion.EditValue).Trim() + "FP:#" + Establecimiento + "-" + Pto_Emision + "-" + txeNumDocum.Text + " Prv:" + ucCp_Proveedor1.get_ProveedorInfo().pr_nombre;
                Info.Serie = Establecimiento;
                Info.Serie2 = Pto_Emision;
                Info.num_documento = Convert.ToString(txeNumDocum.EditValue).Trim();
                Info.num_auto_Proveedor = Convert.ToString(txeIdNumAutoriza.EditValue).Trim();
                Info.num_auto_Imprenta = "";
                Info.co_subtotal_iva = Math.Round((txtSubtotalIva.EditValue == "" ? 0 : Convert.ToDouble(txtSubtotalIva.EditValue)), 2);
                Info.co_subtotal_siniva = Math.Round((txtSubtotal0.EditValue == "" ? 0 : Convert.ToDouble(txtSubtotal0.EditValue)), 2);
                Info.Descuento = Math.Round((txtTotDescuento.EditValue == "" ? 0 : Convert.ToDouble(txtTotDescuento.EditValue)), 2);
                Info.co_baseImponible = Math.Round((txtSubtotal.EditValue == "" ? 0 : Convert.ToDouble(txtSubtotal.EditValue)), 2);
                double por_iva = param.iva.porcentaje;
                if (lstBind.Where(q => q.Checked == true).Count() != 0)
                    por_iva = lstBind.Where(q => q.Checked == true).ToList().Max(q => q.PorIva);
                Info.co_Por_iva = por_iva;
                Info.GastoIva = Convert.ToBoolean(check_GastoIva.Checked);
                Info.co_valoriva = Math.Round((txtTotalIva.EditValue == "" ? 0 : Convert.ToDouble(txtTotalIva.EditValue)), 2);
                Info.co_total = Math.Round((txtTotal.EditValue == "" ? 0 : Convert.ToDouble(txtTotal.EditValue)), 2);
                Info.IdCtaCble_CXP = ucCp_Proveedor1.get_ProveedorInfo().IdCtaCble_CXP;
                if (Info.GastoIva == true)
                    Info.pa_ctacble_iva = info_cpParam.pa_ctacble_x_Iva_Gastos_default;
                else
                    Info.pa_ctacble_iva = info_cpParam.pa_ctacble_iva;
                Info.IdCentroCosoto_CXP = ucCp_Proveedor1.get_ProveedorInfo().IdCentroCosoto;
                Info.Archivo_PDF = readBuffer2;
                Info.IdEmpresa_Ogiro = Info.IdEmpresa;
                Info.IdTipoCbte_Ogiro = info_cpParam.pa_TipoCbte_OG;
                Info.IdCbteCble_Ogiro = Convert.ToDecimal(txt_IdCbteCble_Ogiro.EditValue);
                Info.listDetalle = lstBind.Where(v => v.Checked == true).ToList();
                Info.co_FechaVctoAutorizacion = null;
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetInfo()
        {
            try
            {
                Info = _SetInfo;

                txtIdAprobacion.EditValue = Convert.ToString(_SetInfo.IdAprobacion);
                ucCp_Proveedor1.set_ProveedorInfo(_SetInfo.IdProveedor);
                cmbTipoDocu.EditValue = _SetInfo.IdOrden_giro_Tipo;
                txt_IdCbteCble_Ogiro.EditValue = _SetInfo.IdCbteCble_Ogiro;
                cmbSustTrib.EditValue = _SetInfo.IdIden_credito;
                txtObservacion.EditValue = _SetInfo.Observacion;
                dtpFecAproba.EditValue = _SetInfo.Fecha_aprobacion;
                dtpFecFactura.EditValue = _SetInfo.Fecha_Factura;
                dtp_fecha_contabilizacion.EditValue = _SetInfo.co_FechaContabilizacion;
                txeSerie.EditValue = _SetInfo.Serie + "-" + _SetInfo.Serie2;
                txeNumDocum.EditValue = _SetInfo.num_documento;
                txeIdNumAutoriza.EditValue = _SetInfo.num_auto_Proveedor;
                txtSubtotalIva.EditValue = Convert.ToString(_SetInfo.co_subtotal_iva);
                txtSubtotal0.EditValue = Convert.ToString(_SetInfo.co_subtotal_siniva);
                txtTotDescuento.EditValue = Convert.ToString(_SetInfo.Descuento);
                txtSubtotal.EditValue = Convert.ToString(_SetInfo.co_baseImponible);
                txtTotalIva.EditValue = Convert.ToString(_SetInfo.co_valoriva);
                txtTotal.EditValue = Convert.ToString(_SetInfo.co_total);

                de_FechaVctoAuto.EditValue = _SetInfo.co_FechaVctoAutorizacion;
                // consulta detalle
                cp_Aprobacion_Ing_Bod_x_OC_det_Bus Bus = new cp_Aprobacion_Ing_Bod_x_OC_det_Bus();
                List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> lista = new List<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
                lista = Bus.Get_List_Aprobacion_Ing_Bod_x_OC_det(_SetInfo.IdEmpresa, _SetInfo.IdAprobacion);

                if (lista.Count() > 0)
                {
                    cp_Aprobacion_Ing_Bod_x_OC_det_Info2 info_Orden = new cp_Aprobacion_Ing_Bod_x_OC_det_Info2();
                    foreach (var item in lista)
                    {
                        info_Orden = Bus.Get_List_Aprobacion_Ing_Bod_x_OC_det2(Convert.ToInt32(item.IdEmpresa_Ing_Egr_Inv), Convert.ToInt32(item.IdSucursal_Ing_Egr_Inv), item.IdNumMovi_Ing_Egr_Inv, item.IdMovi_inven_tipo_Ing_Egr_Inv, item.Secuencia_Ing_Egr_Inv);

                        item.IdOrdenCompra = info_Orden.IdOrdenCompra;
                        item.nom_producto = info_Orden.Nom_Producto;
                    }
                }

                gridControlAproIngEgrxOC.DataSource = lista;

                colFecha_Ing_Bod.Visible = false;
                colnom_bodega.Visible = false;
                colChecked.Visible = false;

                BindingList_pagosSRI = new BindingList<cp_orden_giro_pagos_sri_Info>();
                cp_orden_giro_pagos_sri_Bus BusPagosSri = new cp_orden_giro_pagos_sri_Bus();
                BindingList_pagosSRI = new BindingList<cp_orden_giro_pagos_sri_Info>(BusPagosSri.Get_List_orden_giro_pagos_sri(_SetInfo.IdEmpresa, Convert.ToDecimal(_SetInfo.IdCbteCble_Ogiro), Convert.ToInt32(_SetInfo.IdTipoCbte_Ogiro)));
                gridControl_formasPagoSRI.DataSource = BindingList_pagosSRI;

                cp_orden_giro_Bus ordenGiro_B = new cp_orden_giro_Bus();
                cp_orden_giro_Info Info_OrdenGiro = new cp_orden_giro_Info();

                Info_OrdenGiro = ordenGiro_B.Get_Info_orden_giro(Convert.ToInt32(Info.IdEmpresa_Ogiro), Convert.ToInt32(Info.IdTipoCbte_Ogiro), Convert.ToDecimal(Info.IdCbteCble_Ogiro));

                if (Info_OrdenGiro != null)
                {
                    lblanulado.Visible = (Info_OrdenGiro.Estado == "I") ? true : false;
                    lblanulado.Text = "*ANULADO* TipCbt:" + Info_OrdenGiro.IdTipoCbte_Anulacion + "-#CbtCble:" + Info_OrdenGiro.IdCbteCble_Anulacion;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public Boolean Validar()
        {
            try
            {
                txtObservacion.Focus();
                Boolean res = true;

                if (ucCp_Proveedor1.get_ProveedorInfo() == null)
                {
                    MessageBox.Show("Seleccione un proveedor", param.Nombre_sistema);
                    return false;
                }

                if (cmbSustTrib.EditValue == null)
                {
                    MessageBox.Show("Seleccione el Sustento Tributario", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbSustTrib.Focus();
                    return false;
                }

                if (cmbTipoDocu.EditValue == null)
                {
                    MessageBox.Show("Seleccione el Tipo de Documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbTipoDocu.Focus();
                    return false;
                }

                if (String.IsNullOrEmpty(Convert.ToString(txeSerie.EditValue)))
                {
                    MessageBox.Show("Ingrese la serie del Documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txeSerie.Focus();
                    return false;
                }

                if (!String.IsNullOrEmpty(Convert.ToString(txeNumDocum.EditValue)))
                {
                    cp_orden_giro_Bus ordenGiro_B = new cp_orden_giro_Bus();

                    if (Convert.ToDecimal(txt_IdCbteCble_Ogiro.EditValue) == 0)
                    {
                        if (this.Accion == Cl_Enumeradores.eTipo_action.grabar && ordenGiro_B.ExisteFacturaPorProveedor(param.IdEmpresa, ucCp_Proveedor1.get_ProveedorInfo().IdProveedor, Convert.ToString(cmbTipoDocu.EditValue), txeSerie.Text, Convert.ToString(txeNumDocum.EditValue)))
                        {
                            MessageBox.Show("El número de documento ya fue ingresado verifique ", param.Nombre_sistema);
                            return false;
                        }
                    }
                }

                bool Item_mes_anterior = false;
                foreach (var item in lstBind)
                {
                    if (item.Checked == true)
                    {
                        if (item.IdCtaCble_Gasto == null || item.IdCtaCble_Gasto == "")
                        {
                            MessageBox.Show("Ingrese la Cta Cble del Gasto para el Producto" + item.nom_producto, param.Nombre_sistema);
                            return false;
                        }
                        if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CXP, Convert.ToDateTime(dtp_fecha_contabilizacion.EditValue)))
                        {
                            Item_mes_anterior = true;
                        }

                        if (item.Fecha_Ing_Bod.Year > Convert.ToDateTime(dtpFecFactura.EditValue).Year)
                        {
                            if (item.Fecha_Ing_Bod.Month != Convert.ToDateTime(dtpFecFactura.EditValue).Month)
                            {
                                if (item.Fecha_Ing_Bod.Month > Convert.ToDateTime(dtpFecFactura.EditValue).Month)
                                {
                                    MessageBox.Show("El ingreso #" + item.IdNumMovi_Ing_Egr_Inv + " tiene fecha mayor al de la factura!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return false;
                                }
                            }
                        }
                    }
                }
                if (Item_mes_anterior)
                {
                    if (MessageBox.Show("Ha escogido movimientos de un periodo cerrado, ¿Desea continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return false;
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CXP, Convert.ToDateTime(dtpFecAproba.EditValue)))
                    return false;

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CONTA, Convert.ToDateTime(dtp_fecha_contabilizacion.EditValue)))
                    return false;


                try
                {
                    var List_pagosSRI_chequados = this.BindingList_pagosSRI.ToList().Count(c => c.check == true);
                    List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> listDet = new List<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
                    double val = 0;

                    listDet = lstBind.Where(v => v.Checked == true).ToList();
                    foreach (var item in listDet)
                    {
                        val = val + item.Total;
                    }

                    if (Convert.ToDouble(val) <= 500)
                    {
                        if (Convert.ToDecimal(List_pagosSRI_chequados) > 0)
                        {
                            MessageBox.Show("No es necesario que aplique las formas de Pago cuando su base imponible es menor o igual a 500\n Se procederá a deschequear todas las Formas de pago ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            var c = pagoSRI_B.Get_List_orden_giro_pagos_sri();
                            BindingList_pagosSRI.Clear();
                            foreach (var item in c)
                            {
                                BindingList_pagosSRI.Add(item);
                            }
                        }
                    }
                    else// es mayor a 500 se pide la forma de pago
                    {
                        if (Convert.ToDecimal(List_pagosSRI_chequados) == 0) // no tiene forma de pago
                        {
                            MessageBox.Show("la factura es mayor a 500 debe escoger al menos una forma de Pago ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Boolean grabar()
        {
            try
            {
                string mensaje = "";
                txtIdAprobacion.Focus();
                getInfo();
                get_reembolso_y_formasPago();
                Info.Info_orden_giro.lst_formasPagoSRI = lst_formasPagoSRI;
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        decimal IdIdAprobacion = 0;
                        Bus_Aprob = new cp_Aprobacion_Ing_Bod_x_OC_Bus();

                        if (Bus_Aprob.GuardarDB(Info, ref IdIdAprobacion, ref mensaje))
                        {
                            txtIdAprobacion.Text = Convert.ToString(IdIdAprobacion);

                            if (Info.IdCbteCble_Ogiro != 0)
                            {
                                if (Info.IdCbteCble_Ogiro != null)
                                    MessageBox.Show("Se ha procedido a grabar el registro de Aprobación #: " + IdIdAprobacion.ToString() + ", con Factura Proveedor #: " + Info.IdCbteCble_Ogiro + " exitosamente.", "Operación Eexitosa");
                                else
                                    MessageBox.Show(mensaje);
                            }

                            LimpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Error al grabar el registro der Aprobación, " + mensaje, param.Nombre_sistema);
                            return false;
                        }

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        break;
                    default:
                        break;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Anular()
        {
            try
            {
                if (Info != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                    if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular) + " /la Aprobación de ingreso a bodega N°: " + Info.IdAprobacion + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string msg = "";
                        string MotivoAnula = "";
                        oFrm.ShowDialog();
                        MotivoAnula = oFrm.motivoAnulacion;

                        switch (param.IdCliente_Ven_x_Default)
                        {
                            case Cl_Enumeradores.eCliente_Vzen.EDEHSA:
                                cp_orden_giro_Bus ordenGiro_B = new cp_orden_giro_Bus();
                                cp_orden_giro_Info Info_OrdenGiro = new cp_orden_giro_Info();
                                List<cp_orden_giro_x_com_ordencompra_local_Info> LstImportacionOC = new List<cp_orden_giro_x_com_ordencompra_local_Info>();
                                string msg2 = "";

                                Info_OrdenGiro = ordenGiro_B.Get_Info_orden_giro(Convert.ToInt32(Info.IdEmpresa_Ogiro), Convert.ToInt32(Info.IdTipoCbte_Ogiro), Convert.ToDecimal(Info.IdCbteCble_Ogiro));

                                if (Info_OrdenGiro != null)
                                {
                                    cp_parametros_Bus paramCP_B = new cp_parametros_Bus();
                                    cp_parametros_Info paramCP_I = new cp_parametros_Info();
                                    decimal IdCbteCbleRev = 0;

                                    paramCP_I = paramCP_B.Get_Info_parametros(param.IdEmpresa);

                                    Info_OrdenGiro.MotivoAnu = MotivoAnula;
                                    Info_OrdenGiro.IdTipoCbte_Anulacion = paramCP_I.pa_TipoCbte_OG_anulacion;
                                    Info_OrdenGiro.IdUsuarioUltAnu = param.IdUsuario;
                                    Info_OrdenGiro.Fecha_UltAnu = oFrm.fechaAnul;

                                    if (ordenGiro_B.AnularFacturaProveedor_Edehsa(Info_OrdenGiro, LstImportacionOC, ref IdCbteCbleRev, ref msg2))
                                    {
                                        string smensaje = string.Format("{0} # {1} se anuló con éxito.", "Factura Proveedor", Info_OrdenGiro.co_factura);
                                        MessageBox.Show(smensaje, param.Nombre_sistema);
                                        Info_OrdenGiro.Estado = "I";
                                    }
                                }

                                break;

                            default:
                                if (Bus_Aprob.EliminarDB(Info.IdEmpresa, Info.IdAprobacion, param.IdUsuario, MotivoAnula, ref msg))
                                {
                                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente) + " la aprobacion por ingreso a bodega " + Info.IdAprobacion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                Accion = _Accion;
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        dtpFecAproba.EditValue = DateTime.Now;
                        dtpFecFactura.EditValue = DateTime.Now;

                        ucGe_Menu.Enabled_bntAnular = false;

                        txtIdAprobacion.Enabled = false;
                        txtIdAprobacion.BackColor = System.Drawing.Color.White;
                        txtIdAprobacion.ForeColor = System.Drawing.Color.Black;

                        txtTotDescuento.Enabled = false;
                        txtTotDescuento.BackColor = System.Drawing.Color.White;
                        txtTotDescuento.ForeColor = System.Drawing.Color.Black;

                        txtTotalIva.Enabled = false;
                        txtTotalIva.BackColor = System.Drawing.Color.White;
                        txtTotalIva.ForeColor = System.Drawing.Color.Black;

                        txtSubtotal.Enabled = false;
                        txtSubtotal.BackColor = System.Drawing.Color.White;
                        txtSubtotal.ForeColor = System.Drawing.Color.Black;

                        txtTotal.Enabled = false;
                        txtTotal.BackColor = System.Drawing.Color.White;
                        txtTotal.ForeColor = System.Drawing.Color.Black;

                        txtSubtotal0.Enabled = false;
                        txtSubtotal0.BackColor = System.Drawing.Color.White;
                        txtSubtotal0.ForeColor = System.Drawing.Color.Black;

                        txtSubtotalIva.Enabled = false;
                        txtSubtotalIva.BackColor = System.Drawing.Color.White;
                        txtSubtotalIva.ForeColor = System.Drawing.Color.Black;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        Inhabilita_Controles();
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Never;

                        ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Never;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Inhabilita_Controles();
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Always;
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Never;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Inhabilita_Controles()
        {
            try
            {
                ucGe_Menu.Enabled_bntAnular = false;
                txtIdAprobacion.Enabled = false;
                txtIdAprobacion.BackColor = System.Drawing.Color.White;
                txtIdAprobacion.ForeColor = System.Drawing.Color.Black;
                txeSerie.Enabled = false;
                ucCp_Proveedor1.Enabled = false;
                ucCp_Proveedor1.BackColor = System.Drawing.Color.White;
                ucCp_Proveedor1.ForeColor = System.Drawing.Color.Black;
                cmbTipoDocu.Enabled = false;
                cmbTipoDocu.BackColor = System.Drawing.Color.White;
                cmbTipoDocu.ForeColor = System.Drawing.Color.Black;
                cmbSustTrib.Enabled = false;
                cmbSustTrib.BackColor = System.Drawing.Color.White;
                cmbSustTrib.ForeColor = System.Drawing.Color.Black;
                txtObservacion.Enabled = false;
                txtObservacion.BackColor = System.Drawing.Color.White;
                txtObservacion.ForeColor = System.Drawing.Color.Black;
                txeNumDocum.Enabled = false;
                txeNumDocum.BackColor = System.Drawing.Color.White;
                txeNumDocum.ForeColor = System.Drawing.Color.Black;
                txeIdNumAutoriza.Enabled = false;
                txeIdNumAutoriza.BackColor = System.Drawing.Color.White;
                txeIdNumAutoriza.ForeColor = System.Drawing.Color.Black;
                dtpFecAproba.Enabled = false;
                dtpFecAproba.BackColor = System.Drawing.Color.White;
                dtpFecAproba.ForeColor = System.Drawing.Color.Black;
                dtpFecFactura.Enabled = false;
                dtpFecFactura.BackColor = System.Drawing.Color.White;
                dtpFecFactura.ForeColor = System.Drawing.Color.Black;
                txtTotDescuento.Enabled = false;
                txtTotDescuento.BackColor = System.Drawing.Color.White;
                txtTotDescuento.ForeColor = System.Drawing.Color.Black;
                txtTotalIva.Enabled = false;
                txtTotalIva.BackColor = System.Drawing.Color.White;
                txtTotalIva.ForeColor = System.Drawing.Color.Black;
                txtSubtotal.Enabled = false;
                txtSubtotal.BackColor = System.Drawing.Color.White;
                txtSubtotal.ForeColor = System.Drawing.Color.Black;
                txtTotal.Enabled = false;
                txtTotal.BackColor = System.Drawing.Color.White;
                txtTotal.ForeColor = System.Drawing.Color.Black;
                txtSubtotal0.Enabled = false;
                txtSubtotal0.BackColor = System.Drawing.Color.White;
                txtSubtotal0.ForeColor = System.Drawing.Color.Black;
                txtSubtotalIva.Enabled = false;
                txtSubtotalIva.BackColor = System.Drawing.Color.White;
                txtSubtotalIva.ForeColor = System.Drawing.Color.Black;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarDatos()
        {
            try
            {
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Always;
                ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Always;
                txtIdAprobacion.EditValue = "";
                txeSerie.EditValue = "";
                txtObservacion.EditValue = "";
                txeIdNumAutoriza.EditValue = "";
                txeNumDocum.EditValue = "";
                dtpFecFactura.EditValue = DateTime.Now;
                dtpFecAproba.EditValue = DateTime.Now;
                dtp_fecha_contabilizacion.EditValue = DateTime.Now;
                cmbTipoDocu.EditValue = null;
                cmbSustTrib.EditValue = null;
                txtSubtotal0.EditValue = "";
                txtSubtotalIva.EditValue = "";
                txtTotDescuento.EditValue = "";
                txtSubtotal.EditValue = "";
                txtTotalIva.EditValue = "";
                txtTotal.EditValue = "";
                txt_plazo.Text = "";

                lstBind = new BindingList<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
                gridControlAproIngEgrxOC.DataSource = lstBind;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_frmCP_Aprobacion_Ing_Bod_x_OC_Mant_FormClosing(sender, e);
        }

        private void ucGe_Menu_Superior_Mant1_Load(object sender, EventArgs e)
        {

        }

        private void buscar()
        {
            try
            {
                if (Accion == Cl_Enumeradores.eTipo_action.consultar) return;

                cp_Aprobacion_Ing_Bod_x_OC_det_Bus Bus_Aprob = new cp_Aprobacion_Ing_Bod_x_OC_det_Bus();
                list_Aprob = new List<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
                list_Aprob = Bus_Aprob.Get_List_Aprobacion_Ing_Bod_x_OC_det_x_Proveedor(param.IdEmpresa, ucCp_Proveedor1.get_ProveedorInfo().IdProveedor);

                if (ucCp_Proveedor1.get_ProveedorInfo() == null)
                {
                    MessageBox.Show("Seleccione el Proveedor");
                    return;
                }

                if (list_Aprob.Count == 0)
                {
                    MessageBox.Show("No existen Datos de Consulta para el Proveedor: " + ucCp_Proveedor1.get_ProveedorInfo().IdProveedor + "");
                    btn_import_PDF.Enabled = false;
                    import_XML.Enabled = false;
                    LimpiarDatos();
                    return;
                }

                foreach (var item in list_Aprob)
                {
                    //calculos
                    if (item.do_porc_des != 0)
                    {
                        item.do_porc_des = item.do_porc_des;
                        item.SubTotal = Math.Round((item.Cantidad * item.Costo_uni), 2);
                    }
                    else
                        item.SubTotal = Math.Round((item.Cantidad * item.Costo_uni), 2);

                    if (item.PorIva > 0)
                    {
                        item.PorIva = item.PorIva;
                        item.valor_Iva = Math.Round((item.SubTotal * (item.PorIva / 100)), 2);
                        item.subtotaliva = item.SubTotal;
                    }
                    else
                    {
                        item.PorIva = item.PorIva;
                        item.valor_Iva = 0;
                        item.subtotal0 = item.SubTotal;
                    }

                    item.Total = item.SubTotal + item.valor_Iva;
                }

                lstBind = new BindingList<cp_Aprobacion_Ing_Bod_x_OC_det_Info>(list_Aprob);
                gridControlAproIngEgrxOC.DataSource = lstBind;
                import_XML.Enabled = true;
                btn_import_PDF.Enabled = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewAproIngEgrxOC_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (Accion == Cl_Enumeradores.eTipo_action.consultar)
                    return;

                if (e.HitInfo.Column != null)
                {
                    e.HitInfo.Column.FieldName = gridViewAproIngEgrxOC.FocusedColumn.FieldName;

                    if (e.HitInfo.Column.FieldName == "Checked")
                    {
                        if ((Boolean)gridViewAproIngEgrxOC.GetFocusedRowCellValue(colChecked))
                            gridViewAproIngEgrxOC.SetFocusedRowCellValue(colChecked, false);
                        else
                            gridViewAproIngEgrxOC.SetFocusedRowCellValue(colChecked, true);
                    }

                    calculos(lstBind);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calculos(BindingList<cp_Aprobacion_Ing_Bod_x_OC_det_Info> ListaBind)
        {
            try
            {
                SumDescuento = 0;
                SumValorIva = 0;
                SumTotal = 0;
                SumSubtotal = 0;
                SumSubtotal0 = 0;
                SumSubtotaliva = 0;

                int dias_plazo = 0;
                dias_plazo = ucCp_Proveedor1.get_ProveedorInfo() == null ? 0 : Convert.ToInt32(ucCp_Proveedor1.get_ProveedorInfo().pr_plazo);
                txtObservacion.Text = "";

                foreach (var item in ListaBind)
                {
                    if (item.Checked == true)
                    {
                        if (string.IsNullOrEmpty(txtObservacion.Text))
                            txtObservacion.Text = item.nom_producto;
                        else
                            txtObservacion.Text = (txtObservacion.Text + " / " + item.nom_producto);

                        SumDescuento = SumDescuento + item.Descuento;
                        SumValorIva = SumValorIva + item.valor_Iva;
                        SumTotal = SumTotal + item.Total;
                        SumSubtotal = SumSubtotal + item.SubTotal;
                        SumSubtotal0 = SumSubtotal0 + item.subtotal0;
                        SumSubtotaliva = SumSubtotaliva + item.subtotaliva;

                        if (item.Dias > dias_plazo) dias_plazo = item.Dias;
                    }
                }

                txtTotDescuento.EditValue = Convert.ToString(SumDescuento);
                txtTotalIva.EditValue = Convert.ToString(SumValorIva);
                txtSubtotal.EditValue = Convert.ToString(SumSubtotal);
                txtTotal.EditValue = Convert.ToString(SumTotal);
                txtSubtotal0.EditValue = Convert.ToString(SumSubtotal0);
                txtSubtotalIva.EditValue = Convert.ToString(SumSubtotaliva);
                txt_plazo.Text = dias_plazo.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSustTrib_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.cmbTipoDocu.EditValue = null;

                if (Accion == Cl_Enumeradores.eTipo_action.consultar)
                    return;

                if (cmbSustTrib.EditValue == null)
                    return;

                cp_proveedor_Info _p = ucCp_Proveedor1.get_ProveedorInfo();
                if (_p == null)
                {
                    MessageBox.Show("Antes de continuar debe seleccionar Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbSustTrib.EditValue = null;
                    return;
                }
                if (_p.Persona_Info.IdTipoDocumento != null)
                {
                    MessageBox.Show("Antes de continuar debe seleccionar Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cp_codigo_SRI_Info info_codSri = new cp_codigo_SRI_Info();
                var a = (List<cp_codigo_SRI_Info>)cmbSustTrib.Properties.DataSource;
                info_codSri = a.First(q => q.IdCodigo_SRI == Convert.ToDecimal(cmbSustTrib.EditValue));

                List<cp_TipoDocumento_Info> lst = new List<cp_TipoDocumento_Info>();

                if (info_codSri != null && info_codSri.codigoSRI != null)
                    foreach (var item in LstTipDoc)
                    {
                        if (item.Sustento_Tributario != null)
                        {
                            //Separa sustento por documento
                            string[] arreglo = item.Sustento_Tributario.Split(',');

                            //Recorre los sustentos del documento
                            for (int i = 0; i < arreglo.Length; i++)
                            {
                                arreglo[i] = arreglo[i].Trim();

                                if (arreglo[i] == info_codSri.codigoSRI)
                                { //Datos SRI cod_secuencia (01 compra ruc)(02 compra cedula)(03 compra pasaporte)

                                    string secuencial = "";
                                    if (_p.Persona_Info.IdTipoDocumento.Trim() == "RUC")
                                        secuencial = "01";
                                    else if (_p.Persona_Info.IdTipoDocumento.Trim() == "CED")
                                        secuencial = "02";
                                    else
                                        secuencial = "03";

                                    string[] arregloSecuenci = item.Codigo_Secuenciales_Transaccion.Split(',');
                                    for (int ise = 0; ise < arregloSecuenci.Length; ise++)
                                    {
                                        arregloSecuenci[ise] = arregloSecuenci[ise].Trim();
                                        if (arregloSecuenci[ise] == secuencial)
                                        {
                                            lst.Add(item);
                                            ise = arregloSecuenci.Length;
                                            i = arreglo.Length;
                                        }
                                    }
                                }
                            }
                        }
                    }

                cmbTipoDocu.Properties.DataSource = lst;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_plazo_TextChanged(object sender, EventArgs e)
        {
            actualizar_fecha_plazo();
        }

        private void actualizar_fecha_plazo()
        {
            try
            {
                if (txt_plazo.Text != "")
                {
                    DateTime fechaFact = Convert.ToDateTime(dtpFecFactura.EditValue);
                    int plazo = Convert.ToInt32(txt_plazo.Text);
                    fechaFact = fechaFact.AddDays(plazo);

                    dtpFecVtc.EditValue = fechaFact;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControlAproIngEgrxOC_Click(object sender, EventArgs e)
        {

        }

        private void chk_seleccionar_visibles_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridViewAproIngEgrxOC.RowCount; i++)
                {
                    gridViewAproIngEgrxOC.SetRowCellValue(i, colChecked, chk_seleccionar_visibles.Checked);
                }

                calculos(lstBind);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscar_Ingresos()
        {
            try
            {
                cp_proveedor_Info InfoProveedor = ucCp_Proveedor1.get_ProveedorInfo();
                int plazo = 0;

                if (InfoProveedor != null)
                    plazo = Convert.ToInt32(InfoProveedor.pr_plazo);

                txt_plazo.Text = plazo.ToString();
                buscar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarIngresos_Click(object sender, EventArgs e)
        {
            Buscar_Ingresos();
        }

        private void dtpFecAproba_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtp_fecha_contabilizacion.EditValue = dtpFecAproba.EditValue;
                dtpFecFactura.EditValue = dtpFecAproba.EditValue;

                int dias_plazo = string.IsNullOrEmpty(txt_plazo.Text) ? 0 : Convert.ToInt32(txt_plazo.Text);
                dtpFecVtc.EditValue = Convert.ToDateTime(dtpFecAproba.EditValue).AddDays(dias_plazo);
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_relacion_centro_cuenta_Click(object sender, EventArgs e)
        {

        }

        private void gridViewAproIngEgrxOC_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                RowHandle = e.FocusedRowHandle;
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_relacion_centro_cuenta_Click(object sender, EventArgs e)
        {

        }

        private void gridViewAproIngEgrxOC_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                cp_Aprobacion_Ing_Bod_x_OC_det_Info fila_OC_det = (cp_Aprobacion_Ing_Bod_x_OC_det_Info)gridViewAproIngEgrxOC.GetFocusedRow();

                if (e.Column == colIdCtaCtble_Gasto_x_cxp)
                {
                    if (gridViewAproIngEgrxOC.GetFocusedRowCellValue(colIdCtaCtble_Gasto_x_cxp) != null)
                    {
                        string IdCtaCble = (string)gridViewAproIngEgrxOC.GetFocusedRowCellValue(colIdCtaCtble_Gasto_x_cxp);

                        ct_Plancta_Info Info_PlanCta = listPlanCta.FirstOrDefault(q => q.IdCtaCble == IdCtaCble);

                        if (Info_PlanCta.pc_EsMovimiento == "N")
                        {
                            MessageBox.Show("Seleccione una cuenta de movimiento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            gridViewAproIngEgrxOC.SetFocusedRowCellValue(colIdCtaCtble_Gasto_x_cxp, null);
                        }
                    }
                }

                if (e.Column == Col_CentroCosto)
                {
                    string MensajeError = "";

                    if (!Bus_CentroCosto.Validar_CentroCosto_EstadoObra(param.IdEmpresa, Convert.ToString(fila_OC_det.IdCentro_Costo), ref MensajeError))
                    {
                        MessageBox.Show(MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gridViewAproIngEgrxOC.SetFocusedRowCellValue(Col_CentroCosto, null);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void import_XML_Click(object sender, EventArgs e)
        {
            try
            {
                Stream MyStream = null;
                OpenFileDialog openDialog = new OpenFileDialog();

                openDialog.InitialDirectory = "C:\\";
                openDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                openDialog.FilterIndex = 2;
                openDialog.RestoreDirectory = true;

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    MyStream = openDialog.OpenFile();

                    if (MyStream != null)
                    {
                        string path = "";
                        path = openDialog.FileName;

                        cp_Aprobacion_Ing_Bod_x_OC_Info info = new cp_Aprobacion_Ing_Bod_x_OC_Info();
                        factura InfoFactura_SRI = new factura();

                        string numAutorizacion = "";
                        DateTime fechaAutorixacion = new DateTime();

                        tb_Proceso_SRI_Bus bus_proSri = new tb_Proceso_SRI_Bus();
                        string mensaje = "";
                        InfoFactura_SRI = bus_proSri.Deserializar_factura_SRI(path, ref numAutorizacion, ref fechaAutorixacion, ref mensaje);

                        if (InfoFactura_SRI != null)
                        {
                            if (InfoFactura_SRI.infoTributaria != null)
                            {
                                if (InfoFactura_SRI.infoTributaria.ambiente == "1")
                                {
                                    MessageBox.Show("El documento importado esta en ambiente de Pruebas!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                string Ruc_Proveedor = InfoFactura_SRI.infoTributaria.ruc;
                                cp_proveedor_Bus ProveedorBus = new cp_proveedor_Bus();
                                cp_proveedor_Info proveedorInfo = new cp_proveedor_Info();

                                proveedorInfo = ProveedorBus.Get_Info_Proveedor(param.IdEmpresa, Ruc_Proveedor);

                                ucCp_Proveedor1.set_ProveedorInfo(proveedorInfo.IdProveedor);

                                int pv = Convert.ToInt32(ucCp_Proveedor1.get_ProveedorInfo().IdProveedor);
                                if (proveedorInfo.IdProveedor == pv)
                                {
                                    if (proveedorInfo != null)
                                    {
                                        if (pv == 0)
                                        {
                                            if (proveedorInfo.IdProveedor != 0)
                                                ucCp_Proveedor1.set_ProveedorInfo(proveedorInfo.IdProveedor);
                                            else
                                            {
                                                MessageBox.Show("No existe un proveedor con este RUC q se encuentra en el xml Subido .. verifique \n\n" + "[" + Ruc_Proveedor + "]" + InfoFactura_SRI.infoTributaria.razonSocial, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                return;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("No existe un proveedor con este RUC q se encuentra en el xml Subido .. verifique \n\n" + "[" + Ruc_Proveedor + "]" + InfoFactura_SRI.infoTributaria.razonSocial, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }

                                    cmbTipoDocu.EditValue = InfoFactura_SRI.infoTributaria.codDoc;
                                    decimal sum_base_12 = 0;
                                    decimal sum_base_0 = 0;

                                    decimal sum_base_2 = 0;
                                    decimal sum_base = 0;

                                    decimal sum_base_12_tot = 0;
                                    decimal sum_base_0_tot = 0;

                                    decimal sum_valor_iva_12 = 0;

                                    foreach (var item in InfoFactura_SRI.detalles)
                                    {
                                        decimal base_12 = 0;
                                        decimal base_0 = 0;
                                        decimal valor_ice = 0;

                                        foreach (var item2 in item.impuestos)
                                        {
                                            if (item2.codigo.Trim() == "2")
                                            {
                                                if (item2.codigoPorcentaje.Trim() == "2" || item2.codigoPorcentaje.Trim() == "3")
                                                    sum_valor_iva_12 = sum_valor_iva_12 + item2.valor;
                                            }

                                            int cod_3 = item.impuestos.Count(q => q.codigo == "3");

                                            if (cod_3 >= 1)
                                            {
                                                if (item2.codigo == "2")
                                                {
                                                    if (item2.codigoPorcentaje == "2")
                                                    {
                                                        base_12 = item2.baseImponible;
                                                        sum_base_2 = sum_base_2 + base_12;
                                                    }

                                                    if (item2.codigoPorcentaje == "0")
                                                    {
                                                        base_0 = item2.baseImponible;
                                                        sum_base = sum_base + base_0;
                                                    }

                                                    if (item2.codigoPorcentaje == "3")
                                                    {
                                                        base_12 = item2.baseImponible;
                                                        sum_base_2 = sum_base_2 + base_12;
                                                    }
                                                }

                                                if (item2.codigo == "3")
                                                    valor_ice = item2.valor;
                                            }
                                            else
                                            {
                                                if (item2.codigo.Trim() == "2")
                                                {
                                                    if (item2.codigoPorcentaje.Trim() == "2" || item2.codigoPorcentaje == "3")
                                                    {
                                                        base_12 = item2.baseImponible;
                                                        sum_base_2 = sum_base_2 + base_12;
                                                    }

                                                    if (item2.codigoPorcentaje.Trim() == "0")
                                                    {
                                                        base_0 = item2.baseImponible;
                                                        sum_base = sum_base + base_0;
                                                    }
                                                }
                                            }
                                        }

                                        sum_base_12_tot = sum_base_12 + sum_base_2;
                                        sum_base_0_tot = sum_base_0 + sum_base;
                                    }

                                    decimal sum_base_3 = 0;
                                    decimal sum_valor_3 = 0;
                                    decimal sum_cod_5 = 0;

                                    foreach (var item in InfoFactura_SRI.infoFactura.totalConImpuestos)
                                    {
                                        if (item.codigo.Trim() == "3")
                                        {
                                            sum_base_3 = sum_base_3 + item.baseImponible;
                                            sum_valor_3 = sum_valor_3 + item.valor;
                                        }

                                        if (item.codigo.Trim() == "5")
                                            sum_cod_5 = sum_cod_5 + item.valor;
                                    }

                                    txeSerie.EditValue = InfoFactura_SRI.infoTributaria.estab + "-" + InfoFactura_SRI.infoTributaria.ptoEmi;
                                    txeNumDocum.EditValue = InfoFactura_SRI.infoTributaria.secuencial;
                                    dtpFecAproba.EditValue = DateTime.Now; //fechaAutorixacion;
                                    dtpFecFactura.EditValue = Convert.ToDateTime(InfoFactura_SRI.infoFactura.fechaEmision);
                                    dtp_fecha_contabilizacion.EditValue = DateTime.Now; //Convert.ToDateTime(InfoFactura_SRI.infoFactura.fechaEmision).Date;
                                    txeIdNumAutoriza.EditValue = numAutorizacion;

                                    MessageBox.Show("XML Importado Satisfactoriamente");
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al Importar XML Error de Formato o Estructura o no Autorizado por el SRI...\n\n\n ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_import_PDF_Click(object sender, EventArgs e)
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
                    readBuffer2 = System.IO.File.ReadAllBytes(path);
                }
            }
        }

        private void dtpFecFactura_EditValueChanged(object sender, EventArgs e)
        {
            actualizar_fecha_plazo();
        }

        private void btn_Autoriza_Click(object sender, EventArgs e)
        {
            try
            {
                if (ucCp_Proveedor1.get_ProveedorInfo() == null)
                {
                    MessageBox.Show("Ingrese el Proveedor", param.Nombre_sistema);
                    return;
                }

                frmCP_AutorizacionProveedor ofrm = new frmCP_AutorizacionProveedor(ucCp_Proveedor1.get_ProveedorInfo().IdProveedor);
                ofrm.ShowDialog();
                cp_proveedor_Autorizacion_Info autori_I = ofrm.OtroFrm_Aut_I;
                if (autori_I != null)
                {
                    NumAutoriza = autori_I.nAutorizacion;
                    Establecimiento = autori_I.Serie1;
                    Pto_Emision = autori_I.Serie2;
                    txeIdNumAutoriza.EditValue = autori_I.nAutorizacion;
                    txeSerie.EditValue = autori_I.Serie1 + "-" + autori_I.Serie2;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txeNumDocum_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //validar secuencial factura
                string secuencia_aux = "";
                string secuencia = "";

                if (!String.IsNullOrEmpty(Convert.ToString(txeNumDocum.EditValue)))
                {
                    if (Convert.ToString(txeNumDocum.EditValue).Length < 9)
                    {
                        int conta = Convert.ToString(txeNumDocum.EditValue).Length;
                        int diferencia = 9 - conta;

                        secuencia_aux = secuencia_aux.PadLeft(diferencia, '0');
                        secuencia = secuencia_aux + txeNumDocum.EditValue;

                        txeNumDocum.EditValue = secuencia;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_OrdenGiro_Pendientes_Ing_x_OC_Click(object sender, EventArgs e)
        {
            try
            {
                frmCP_OrdenGiro_Pendiente_ING_x_OC_Cons Frm = new frmCP_OrdenGiro_Pendiente_ING_x_OC_Cons();
                Frm.ShowDialog();

                if (Frm.Info_Selected != null)
                {
                    txtIdAprobacion.EditValue = 0;
                    ucCp_Proveedor1.set_ProveedorInfo(Frm.Info_Selected.IdProveedor);
                    cmbTipoDocu.EditValue = Frm.Info_Selected.IdOrden_giro_Tipo;
                    txt_IdCbteCble_Ogiro.EditValue = Frm.Info_Selected.IdCbteCble_Ogiro;
                    cmbSustTrib.EditValue = Frm.Info_Selected.IdIden_credito;
                    txtObservacion.EditValue = Frm.Info_Selected.co_observacion;
                    dtpFecAproba.EditValue = param.Fecha_Transac.Date;
                    dtpFecFactura.EditValue = Frm.Info_Selected.co_FechaFactura;
                    dtp_fecha_contabilizacion.EditValue = Frm.Info_Selected.co_FechaContabilizacion;
                    txeSerie.EditValue = Frm.Info_Selected.co_serie;
                    txeNumDocum.EditValue = Frm.Info_Selected.co_factura;
                    txeIdNumAutoriza.EditValue = Frm.Info_Selected.Num_Autorizacion;
                    txtSubtotalIva.EditValue = Convert.ToString(Frm.Info_Selected.co_subtotal_iva);
                    txtSubtotal0.EditValue = Convert.ToString(Frm.Info_Selected.co_subtotal_siniva);
                    txtSubtotal.EditValue = Convert.ToString(Frm.Info_Selected.co_baseImponible);
                    txtTotalIva.EditValue = Convert.ToString(Frm.Info_Selected.co_valoriva);
                    txtTotal.EditValue = Convert.ToString(Frm.Info_Selected.co_total);
                    de_FechaVctoAuto.EditValue = Frm.Info_Selected.fecha_autorizacion;
                    BindingList_pagosSRI = new BindingList<cp_orden_giro_pagos_sri_Info>();
                    cp_orden_giro_pagos_sri_Bus BusPagosSri = new cp_orden_giro_pagos_sri_Bus();
                    BindingList_pagosSRI = new BindingList<cp_orden_giro_pagos_sri_Info>(BusPagosSri.Get_List_orden_giro_pagos_sri(Frm.Info_Selected.IdEmpresa, Convert.ToDecimal(Frm.Info_Selected.IdCbteCble_Ogiro), Convert.ToInt32(Frm.Info_Selected.IdTipoCbte_Ogiro)));
                    gridControl_formasPagoSRI.DataSource = BindingList_pagosSRI;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_repositorio_comprobantes_Click(object sender, EventArgs e)
        {
            try
            {
                FrmGe_Comprobantes_Recibidos_Cons Frm = new FrmGe_Comprobantes_Recibidos_Cons();
                Frm.event_FrmGe_Comprobantes_Recibidos_Cons_FormClosing += frm_event_FrmGe_Comprobantes_Recibidos_Cons_FormClosing;
                Frm.ShowDialog();

                if (Frm.bAcepto)
                {
                    if (Frm.Row_Selected != null)
                    {
                        cp_Aprobacion_Ing_Bod_x_OC_Info info = new cp_Aprobacion_Ing_Bod_x_OC_Info();
                        factura InfoFactura_SRI = new factura();

                        string numAutorizacion = "";
                        DateTime fechaAutorixacion = new DateTime();

                        tb_Proceso_SRI_Bus bus_proSri = new tb_Proceso_SRI_Bus();
                        string mensaje = "";
                        InfoFactura_SRI = bus_proSri.Deserializar_factura_SRI_xml(Frm.Row_Selected.XML, ref numAutorizacion, ref fechaAutorixacion, ref mensaje);

                        if (InfoFactura_SRI != null)
                        {
                            if (InfoFactura_SRI.infoTributaria != null)
                            {
                                if (InfoFactura_SRI.infoTributaria.ambiente == "1")
                                {
                                    MessageBox.Show("El documento importado esta en ambiente de Pruebas!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                string Ruc_Proveedor = InfoFactura_SRI.infoTributaria.ruc;
                                cp_proveedor_Bus ProveedorBus = new cp_proveedor_Bus();
                                cp_proveedor_Info proveedorInfo = new cp_proveedor_Info();

                                proveedorInfo = ProveedorBus.Get_Info_Proveedor(param.IdEmpresa, Ruc_Proveedor);
                                ucCp_Proveedor1.set_ProveedorInfo(proveedorInfo.IdProveedor);

                                int pv = Convert.ToInt32(ucCp_Proveedor1.get_ProveedorInfo().IdProveedor);
                                if (proveedorInfo.IdProveedor == pv)
                                {
                                    if (proveedorInfo != null)
                                    {
                                        if (pv == 0)
                                        {
                                            if (proveedorInfo.IdProveedor != 0)
                                                ucCp_Proveedor1.set_ProveedorInfo(proveedorInfo.IdProveedor);
                                            else
                                            {
                                                MessageBox.Show("No existe un proveedor con este RUC q se encuentra en el xml Subido .. verifique \n\n" + "[" + Ruc_Proveedor + "]" + InfoFactura_SRI.infoTributaria.razonSocial, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                return;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("No existe un proveedor con este RUC q se encuentra en el xml Subido .. verifique \n\n" + "[" + Ruc_Proveedor + "]" + InfoFactura_SRI.infoTributaria.razonSocial, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }

                                    cmbTipoDocu.EditValue = InfoFactura_SRI.infoTributaria.codDoc;
                                    decimal sum_base_12 = 0;
                                    decimal sum_base_0 = 0;

                                    decimal sum_base_2 = 0;
                                    decimal sum_base = 0;

                                    decimal sum_base_12_tot = 0;
                                    decimal sum_base_0_tot = 0;

                                    decimal sum_valor_iva_12 = 0;

                                    foreach (var item in InfoFactura_SRI.detalles)
                                    {
                                        decimal base_12 = 0;
                                        decimal base_0 = 0;
                                        decimal valor_ice = 0;

                                        foreach (var item2 in item.impuestos)
                                        {
                                            if (item2.codigo.Trim() == "2")
                                            {
                                                if (item2.codigoPorcentaje.Trim() == "2" || item2.codigoPorcentaje.Trim() == "3")
                                                    sum_valor_iva_12 = sum_valor_iva_12 + item2.valor;
                                            }

                                            int cod_3 = item.impuestos.Count(q => q.codigo == "3");

                                            if (cod_3 >= 1)
                                            {
                                                if (item2.codigo == "2")
                                                {
                                                    if (item2.codigoPorcentaje == "2")
                                                    {
                                                        base_12 = item2.baseImponible;
                                                        sum_base_2 = sum_base_2 + base_12;
                                                    }

                                                    if (item2.codigoPorcentaje == "0")
                                                    {
                                                        base_0 = item2.baseImponible;
                                                        sum_base = sum_base + base_0;
                                                    }

                                                    if (item2.codigoPorcentaje == "3")
                                                    {
                                                        base_12 = item2.baseImponible;
                                                        sum_base_2 = sum_base_2 + base_12;
                                                    }
                                                }

                                                if (item2.codigo == "3")
                                                    valor_ice = item2.valor;
                                            }
                                            else
                                            {
                                                if (item2.codigo.Trim() == "2")
                                                {
                                                    if (item2.codigoPorcentaje.Trim() == "2" || item2.codigoPorcentaje == "3")
                                                    {
                                                        base_12 = item2.baseImponible;
                                                        sum_base_2 = sum_base_2 + base_12;
                                                    }

                                                    if (item2.codigoPorcentaje.Trim() == "0") // iva 0%
                                                    {
                                                        base_0 = item2.baseImponible;
                                                        sum_base = sum_base + base_0;
                                                    }
                                                }
                                            }
                                        }

                                        sum_base_12_tot = sum_base_12 + sum_base_2;
                                        sum_base_0_tot = sum_base_0 + sum_base;
                                    }

                                    decimal sum_base_3 = 0;
                                    decimal sum_valor_3 = 0;
                                    decimal sum_cod_5 = 0;

                                    foreach (var item in InfoFactura_SRI.infoFactura.totalConImpuestos)
                                    {
                                        if (item.codigo.Trim() == "3")
                                        {
                                            sum_base_3 = sum_base_3 + item.baseImponible;
                                            sum_valor_3 = sum_valor_3 + item.valor;
                                        }

                                        if (item.codigo.Trim() == "5")
                                            sum_cod_5 = sum_cod_5 + item.valor;
                                    }

                                    txeSerie.EditValue = InfoFactura_SRI.infoTributaria.estab + "-" + InfoFactura_SRI.infoTributaria.ptoEmi;
                                    txeNumDocum.EditValue = InfoFactura_SRI.infoTributaria.secuencial;
                                    dtpFecAproba.EditValue = DateTime.Now; //fechaAutorixacion;
                                    dtpFecFactura.EditValue = Convert.ToDateTime(InfoFactura_SRI.infoFactura.fechaEmision);
                                    dtp_fecha_contabilizacion.EditValue = DateTime.Now; //Convert.ToDateTime(InfoFactura_SRI.infoFactura.fechaEmision).Date;
                                    txeIdNumAutoriza.EditValue = numAutorizacion;

                                    MessageBox.Show("XML Importado Satisfactoriamente");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_FrmGe_Comprobantes_Recibidos_Cons_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}