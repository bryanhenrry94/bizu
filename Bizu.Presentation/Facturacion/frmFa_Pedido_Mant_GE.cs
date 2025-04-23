using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bizu.Application.Facturacion;
using Bizu.Application.General;
using Bizu.Application.Inventario;
using Bizu.Application.CuentasxCobrar;
using Bizu.Domain.Facturacion;
using Bizu.Domain.General;
using Bizu.Domain.Inventario;
using Bizu.Reports.Facturacion;
using Bizu.Presentation.Controles;
using Bizu.Presentation.General;
using Bizu.Domain.CuentasxCobrar;
using System.Reflection;
using Bizu.Application.Caja;
using Bizu.Reports.Contabilidad;
using System.IO;
using Bizu.Domain.Contabilidad;
using Bizu.Application.Contabilidad;
using Bizu.Presentation.Contabilidad;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;

namespace Bizu.Presentation.Facturacion
{
    public partial class frmFa_Pedido_Mant_GE : DevExpress.XtraEditors.XtraForm
    {
        #region declaracion de Variables

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action _Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        //delegados y eventos
        public delegate void delegate_frmFA_Pedido_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmFA_Pedido_Mant_FormClosing Event_frmFA_Pedido_Mant_FormClosing;


        static string result = Path.GetTempPath();
        String RootReporte = result + @"Factura.repx";
        //int lengthNumFac = 0;
        Boolean fec = false;
        double SumValForPag = 0;
        double SumPorDist = 0;
        string MensajeError = "";
        decimal IdPedido = 0;
        int rowHandle = 0;
        double StockProd = 0;
        Boolean banderaCombo = false;
        Boolean estado = false;

        fa_TerminoPago_Bus FterminopagoBus = new fa_TerminoPago_Bus();
        fa_parametro_Bus Bus_Param_facturacion = new fa_parametro_Bus();
        in_Parametro_Bus Bus_param_inven = new in_Parametro_Bus();

        //Bizu.Application.SeguridadAcceso.Facturacion.fa_factura_Bus Bus_Factura = new Bizu.Application.SeguridadAcceso.Facturacion.fa_factura_Bus();
        //Bizu.Application.SeguridadAcceso.Facturacion.fa_factura_det_Bus Bus_factura_det = new Bizu.Application.SeguridadAcceso.Facturacion.fa_factura_det_Bus();

        // Infos
        tb_Bodega_Info bodega_info = new tb_Bodega_Info();
        tb_Sucursal_Info info_sucursal = new tb_Sucursal_Info();
        tb_Bodega_Info info_bodega = new tb_Bodega_Info();
        fa_Cliente_Info info_cliente = new fa_Cliente_Info();


        //Variables
        decimal id = 0;
        string msg = "";
        public int idbodega { get; set; }
        public int idsucursal { get; set; }

        //UCFa_Grid_detalle_totales UC_grid_totales = new UCFa_Grid_detalle_totales();
        public Cl_Enumeradores.eTipo_action Accion { get; set; }
        public fa_pedido_Info obj { get; set; }
        Funciones Funciones = new Bizu.Domain.General.Funciones();

        tb_sis_Documento_Tipo_Talonario_Bus BusDoc = new tb_sis_Documento_Tipo_Talonario_Bus();
        in_producto_Bus Bus_Producto = new in_producto_Bus();
        in_producto_x_tb_bodega_Bus Bus_Prod_x_bod = new in_producto_x_tb_bodega_Bus();
        ct_punto_cargo_Bus Bus_Punto_Cargo = new ct_punto_cargo_Bus();
        fa_factura_x_formaPago_Bus Bus_FacxForPag = new fa_factura_x_formaPago_Bus();

        caj_Caja_Bus Bus_Caja = new caj_Caja_Bus();
        fa_TerminoPago_Bus Bus_Termino_pago = new fa_TerminoPago_Bus();
        fa_TerminoPago_Distribucion_Bus Bus_Termi_PagoDistri = new fa_TerminoPago_Distribucion_Bus();

        //Clases Info

        in_Parametro_Info Info_param_inven = new in_Parametro_Info();
        in_Producto_Info Info_producto = new in_Producto_Info();
        fa_parametro_info Info_Param_fact = new fa_parametro_info();

        fa_Cliente_Info InfoCliente = new fa_Cliente_Info();
        tb_sis_Documento_Tipo_Talonario_Info Info_Documento_talonario_Actual = new tb_sis_Documento_Tipo_Talonario_Info();
        fa_factura_x_formaPago_Info Info_fac_x_forma_pago = new fa_factura_x_formaPago_Info();
        fa_factura_x_ct_cbtecble_Info Info_Fac_x_cbtecble = new fa_factura_x_ct_cbtecble_Info();
        fa_factura_x_ct_cbtecble_Bus bus_Fac_x_cbtecble = new fa_factura_x_ct_cbtecble_Bus();
        fa_TerminoPago_Info Info_TerminoPago = new fa_TerminoPago_Info();


        //Listas Info
        BindingList<fa_factura_x_fa_TerminoPago_Info> DataSource_ForPag = new BindingList<fa_factura_x_fa_TerminoPago_Info>();
        fa_TerminoPago_Distribucion_Bus BusPagoDistri = new fa_TerminoPago_Distribucion_Bus();
        List<fa_orden_Desp_det_Info> ListaOrdenDEspachoxPedido = new List<fa_orden_Desp_det_Info>();
        List<fa_TerminoPago_Distribucion_Info> ListPagoDistri = new List<fa_TerminoPago_Distribucion_Info>();
        List<fa_factura_x_fa_TerminoPago_Info> List = new List<fa_factura_x_fa_TerminoPago_Info>();
        List<fa_Combo_Info> Lista_Tipo_Pago = new List<fa_Combo_Info>();

        List<in_Producto_Info> Lista_producto = new List<in_Producto_Info>();
        List<fa_TerminoPago_Info> list_TerminoPago = new List<fa_TerminoPago_Info>();

        List<ct_punto_cargo_Info> Lista_PuntoCargo = new List<ct_punto_cargo_Info>();
        List<fa_Documento_Tipo_info> lmTipoDoc = new List<fa_Documento_Tipo_info>();
        List<in_movi_inve_detalle_Info> invList = new List<in_movi_inve_detalle_Info>();
        List<fa_TerminoPago_Distribucion_Info> List_Termino_Pago_x_Distri = new List<fa_TerminoPago_Distribucion_Info>();
        List<fa_factura_x_formaPago_Info> List_fac_x_forma_pago = new List<fa_factura_x_formaPago_Info>();

        //BindingList Info

        BindingList<fa_factura_x_fa_TerminoPago_Info> Binding_list_fac_form_pago = new BindingList<fa_factura_x_fa_TerminoPago_Info>();
        in_producto_Bus BusProd = new in_producto_Bus();
        ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();
        ct_punto_cargo_Info info_punto_cargo = new ct_punto_cargo_Info();
        List<ct_punto_cargo_Info> lst_punto_cargo = new List<ct_punto_cargo_Info>();
        ct_punto_cargo_grupo_Bus bus_grupo_punto_cargo = new ct_punto_cargo_grupo_Bus();
        ct_punto_cargo_grupo_Info info_grupo_punto_cargo = new ct_punto_cargo_grupo_Info();
        List<ct_punto_cargo_grupo_Info> lst_grupo_punto_cargo = new List<ct_punto_cargo_grupo_Info>();

        tb_sis_impuesto_Bus BusImp = new tb_sis_impuesto_Bus();
        List<tb_sis_impuesto_Info> listTipoImpu_x_Iva = new List<tb_sis_impuesto_Info>();


        //PEDIDO
        BindingList<fa_pedido_x_formaPago_Info> DataSource_PedForPag = new BindingList<fa_pedido_x_formaPago_Info>();
        fa_pedido_x_formaPago_Bus Bus_PedidoFormaPago = new fa_pedido_x_formaPago_Bus();
        List<fa_pedido_estadoAprobacion_Info> Lista_Estado_Aprobacion = new List<fa_pedido_estadoAprobacion_Info>();
        List<fa_pedido_det_Info> lista_producto_detalle = new List<fa_pedido_det_Info>();
        List<fa_pedido_det_Info> listTablaAux = new List<fa_pedido_det_Info>();
        List<fa_pedido_det_Info> listTabla = new List<fa_pedido_det_Info>();
        List<fa_pedido_x_formaPago_Info> ListaFormaPago = new List<fa_pedido_x_formaPago_Info>();
        List<fa_pedido_Info> listPedidosNoDespachados = new List<fa_pedido_Info>();
        fa_pedido_Info Info_Pedido = new fa_pedido_Info();
        fa_pedido_det_Info Info_Pedido_Det = new fa_pedido_det_Info();
        List<fa_pedido_det_Info> List_Pedido = new List<fa_pedido_det_Info>();
        BindingList<fa_pedido_det_Info> Binding_List_Pedido_det = new BindingList<fa_pedido_det_Info>();
        fa_pedido_Bus Bus_Pedido = new fa_pedido_Bus();
        fa_pedido_det_Bus Bus_Pedido_Det = new fa_pedido_det_Bus();

        #endregion

        public frmFa_Pedido_Mant_GE()
        {
            InitializeComponent();
            Event_frmFA_Pedido_Mant_FormClosing += frmFa_Factura_Mant_Event_frmFA_Pedido_Mant_FormClosing;

            UC_Cliente.Event_cmb_cliente_EditValueChanged += UC_Cliente_Event_cmb_cliente_EditValueChanged;



            Accion = Cl_Enumeradores.eTipo_action.actualizar;
            TipoPago();
            EstadoAprobacion();
            //UC_grid_producto.idSucursal = idsucursal;
            //UC_grid_producto.idBodega = idbodega;
            cmb_estado_aprobacion.Enabled = true;
        }

        void frmFa_Factura_Mant_Event_frmFA_Pedido_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public frmFa_Pedido_Mant_GE(int id_sucursal, int id_bodega)
            : this()
        {
            try
            {
                idbodega = id_bodega;
                idsucursal = id_sucursal;
                Accion = Cl_Enumeradores.eTipo_action.actualizar;
                TipoPago();
                EstadoAprobacion();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void EstadoAprobacion()
        {
            try
            {
                fa_parametro_Bus busParametro = new fa_parametro_Bus();
                fa_parametro_info info = new fa_parametro_info();

                info = busParametro.Get_Info_parametro(param.IdEmpresa);

                fa_pedido_estadoAprobacion_Bus bus_aprobacion = new fa_pedido_estadoAprobacion_Bus();
                Lista_Estado_Aprobacion = bus_aprobacion.Get_List_EstadoAprobacion();
                this.cmb_estado_aprobacion.DataSource = Lista_Estado_Aprobacion;
                this.cmb_estado_aprobacion.DisplayMember = "Descripcion";
                this.cmb_estado_aprobacion.ValueMember = "IdEstadoAprobacion";

                cmb_estado_aprobacion.SelectedValue = info.IdEstadoAprobacion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void TipoPago()
        {
            try
            {
                fa_Combo_Info combo_tipo = new fa_Combo_Info();
                combo_tipo.IdCombo = "CRE";
                combo_tipo.Descripcion = "CREDITO";
                Lista_Tipo_Pago.Add(combo_tipo);

                combo_tipo = new fa_Combo_Info();
                combo_tipo.IdCombo = "CON";
                combo_tipo.Descripcion = "CONTADO";
                Lista_Tipo_Pago.Add(combo_tipo);

                list_TerminoPago = FterminopagoBus.Get_List_TerminoPago(Cl_Enumeradores.eTipoCreditoCliente.AMB.ToString());
                cmbTerminoPago.Properties.DataSource = list_TerminoPago;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Get_TerminoPago()
        {
            try
            {
                //haac 02/06/2014 Guarda Forma Pago                               
                ListaFormaPago = new List<fa_pedido_x_formaPago_Info>();
                foreach (var item in List)
                {
                    fa_pedido_x_formaPago_Info infoFormaPago = new fa_pedido_x_formaPago_Info();

                    infoFormaPago.IdEmpresa = param.IdEmpresa;
                    infoFormaPago.IdBodega = Convert.ToInt32(UC_Sucursal_Bodega.cmb_bodega.EditValue);
                    infoFormaPago.IdSucursal = Convert.ToInt32(UC_Sucursal_Bodega.cmb_sucursal.EditValue);
                    infoFormaPago.IdTipoFormaPago = Convert.ToString(this.cmbTerminoPago.EditValue);
                    infoFormaPago.Fecha = dtFecha.Value;
                    infoFormaPago.Fecha_vtc = item.Fecha_vct;
                    infoFormaPago.Dias_Plazo = item.Dias_Plazo;
                    infoFormaPago.Por_Distribucion = item.Por_Distribucion;
                    infoFormaPago.Valor = item.Valor;

                    ListaFormaPago.Add(infoFormaPago);
                }
                Info_Pedido.DetformaPago_list = ListaFormaPago;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmFa_Pedido_Mant_GE_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmFA_Pedido_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        #region funciones get & set

        public void Set_Accion(Cl_Enumeradores.eTipo_action Accion_)
        {
            try
            {
                _Accion = Accion_;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Set_Info_in_controls()
        {
            try
            {
                //get_Pedido();

                Info_Pedido.IdUsuario = param.IdUsuario;
                txt_pedido.Text = Convert.ToString(obj.IdPedido);
                txtCodigo.Text = obj.CodPedido;

                UC_Sucursal_Bodega.cmb_sucursal.EditValue = obj.IdSucursal;
                UC_Sucursal_Bodega.cmb_bodega.EditValue = obj.IdBodega;

                UC_Cliente.cmb_cliente.EditValue = obj.IdCliente;
                UC_Cliente.cmb_vendedor.EditValue = obj.IdVendedor;

                dtFecha.Value = obj.cp_fecha;
                txt_plazo.Text = Convert.ToString(obj.cp_diasPlazo);
                dtFechaVenc.Value = obj.cp_fechaVencimiento;
                txt_observacion.Text = obj.cp_observacion;
                cmbTerminoPago.EditValue = obj.cp_tipopago;

                cmb_estado_aprobacion.SelectedValue = obj.IdEstadoAprobacion;
                cmbEstadoProduccion.SelectedValue = obj.IdEstadoProduccion;

                cbxEntrega.Checked = (obj.Entregado == "S") ? true : false;


                //consulta forma pago pedido
                ListaFormaPago = new List<fa_pedido_x_formaPago_Info>();
                ListaFormaPago = Bus_PedidoFormaPago.Get_List_pedido_x_formaPago(param.IdEmpresa, obj.IdSucursal, obj.IdBodega, obj.IdPedido);
                DataSource_PedForPag = new BindingList<fa_pedido_x_formaPago_Info>(ListaFormaPago);
                gridControlFormaPag.DataSource = DataSource_PedForPag;

                txtValForPag.Text = Convert.ToString(SumValForPag);
                txtPorDist.Text = Convert.ToString(SumPorDist);
                cbxEntrega.Checked = (obj.Entregado == "S") ? true : false;

                Info_Pedido.lista_detalle = Bus_Pedido_Det.Get_List_pedido_det(param.IdEmpresa, obj.IdSucursal, obj.IdBodega, obj.IdPedido);
                Binding_List_Pedido_det = new BindingList<fa_pedido_det_Info>(Info_Pedido.lista_detalle);
                gridControl_Factura.DataSource = Binding_List_Pedido_det;

                foreach (var item in Info_Pedido.lista_detalle)
                {
                    fa_pedido_det_Info tabla_pedido = new fa_pedido_det_Info();
                    //tabla_pedido.Codigo_Producto = item.CodProducto;
                    tabla_pedido.IdProducto = item.IdProducto;
                    tabla_pedido.dp_cantidad = item.dp_cantidad;
                    tabla_pedido.dp_PorDescuento = item.dp_PorDescuento;
                    tabla_pedido.dp_desUni = item.dp_desUni;
                    tabla_pedido.Peso = item.Peso;
                    tabla_pedido.dp_precio = item.dp_precio;
                    tabla_pedido.dp_PrecioFinal = item.dp_PrecioFinal;
                    tabla_pedido.Subtotal = item.dp_subtotal;
                    tabla_pedido.dp_total = item.dp_total;
                    tabla_pedido.dp_iva = item.dp_iva;
                    tabla_pedido.Paga_Iva = (item.dp_pagaIva == "S") ? true : false;
                    tabla_pedido.dp_detallexItems = item.dp_detallexItems;
                    tabla_pedido.Secuencial = item.Secuencial;

                    lista_producto_detalle.Add(tabla_pedido);
                }
                gridControl_Factura.DataSource = lista_producto_detalle;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void Set_Info(fa_pedido_Info Info_Pedido)
        {
            try
            {
                this.Info_Pedido = Info_Pedido;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Set_Accion_In_controls()
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Set_Info_in_controls();
                        cargarGridOrdDesXpedi();
                        UC_Cliente.cmb_cliente.Enabled = false;
                        this.btn_grabar.Text = "Actualizar Pedido";
                        txtCodigo.Enabled = false;
                        txt_pedido.Enabled = false;
                        var q = from t in ListaOrdenDEspachoxPedido
                                where t.IdPedido == obj.IdPedido
                                select t.IdProducto;
                        if (q.ToList().Count == 0)
                        { }
                        else
                        { }
                        UC_Sucursal_Bodega.Bloquerar_Combos();

                        CalcularTotales();

                        if (obj.Estado == "I")
                        {
                            lblAnulado.Visible = true;
                            btn_grabar.Enabled = false;
                            btn_guardarSalir.Enabled = false;
                        }
                        Cargar_Grid();
                        break;

                    case Cl_Enumeradores.eTipo_action.grabar:
                        tabControl2.Enabled = false;
                        xtraTabControl_cuerpo.Enabled = false;
                        cmbTerminoPago.Enabled = true;
                        gridView_Factura.OptionsBehavior.ReadOnly = false;
                        Cargar_Grid();
                        this.btn_grabar.Text = "Grabar Pedido";//
                        break;
                        this.btn_grabar.Text = "Grabar Pedido";
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        Set_Info_in_controls();
                        cargarGridOrdDesXpedi();
                        if (obj.Estado == "I")
                        {
                            lblAnulado.Visible = true;
                            btn_grabar.Enabled = false;
                            btn_guardarSalir.Enabled = false;
                            btnLimpiar.Enabled = false;
                        }
                        BtnAnular.Enabled = false;
                        btn_grabar.Enabled = false;
                        btn_guardarSalir.Enabled = false;
                        this.btn_grabar.Text = "Grabar";
                        CalcularTotales();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Set_Info_in_controls();
                        cargarGridOrdDesXpedi();
                        this.btn_grabar.Text = "Anular Pedido";
                        if (obj.Estado == "I")
                        {
                            lblAnulado.Visible = true;
                            btn_grabar.Enabled = false;
                            btn_guardarSalir.Enabled = false;
                            btnLimpiar.Enabled = false;
                        }
                        btn_grabar.Enabled = false;
                        btn_guardarSalir.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public fa_pedido_Info Get_Info_Pedido()
        {
            try
            {
                tb_sis_Documento_Tipo_Talonario_Info talonarioInfo = new tb_sis_Documento_Tipo_Talonario_Info();
                Info_Pedido = new fa_pedido_Info();
                //talonarioInfo = UCNumDoc.Get_Info_Talonario();
                //Info_Pedido.IdCbteVta = txtIdFactura.Text == "" ? 0 : Convert.ToDecimal(txtIdFactura.Text);
                Info_Pedido.IdPedido = Convert.ToInt32(txt_pedido.Text);
                Info_Pedido.Estado = "A";
                Info_Pedido.Fecha_Transac = DateTime.Now;
                Info_Pedido.Fecha_UltAnu = DateTime.Now;
                Info_Pedido.Fecha_UltMod = DateTime.Now;
                Info_Pedido.IdBodega = Convert.ToInt32(UC_Sucursal_Bodega.cmb_bodega.EditValue);
                Info_Pedido.IdSucursal = Convert.ToInt32(UC_Sucursal_Bodega.cmb_sucursal.EditValue);
                Info_Pedido.IdCliente = Convert.ToDecimal((UC_Cliente.cmb_cliente.EditValue == null) ? 0 : UC_Cliente.cmb_cliente.EditValue);
                Info_Pedido.IdEmpresa = param.IdEmpresa;
                //Info_Pedido.IdPeriodo = (DateTime.Now.Year * 100) + DateTime.Now.Month;
                Info_Pedido.IdUsuario = param.IdUsuario;
                Info_Pedido.IdUsuarioUltAnu = param.IdUsuario;
                Info_Pedido.IdUsuarioUltMod = param.IdUsuario;
                Info_Pedido.IdVendedor = Convert.ToInt16(UC_Cliente.cmb_vendedor.EditValue);
                Info_Pedido.ip = param.ip;
                Info_Pedido.nom_pc = param.nom_pc;
                Info_Pedido.cp_fecha = Convert.ToDateTime(dtFecha.Value);
                //Info_Pedido.vt_fech_venc = Convert.ToDateTime(dateFechaVencimiento.Value);
                //Info_Pedido.vt_flete = 0;
                //Info_Pedido.vt_interes = 0;
                //Info_Pedido.vt_NumFactura = talonarioInfo.NumDocumento;
                //Info_Pedido.IdCaja = Convert.ToInt32(cmbCaja.EditValue);
                //Info_Pedido.vt_plazo = Convert.ToInt32(spinEditDiasPlazo.Value);


                Info_Pedido.cp_observacion = txt_observacion.Text;

                //Info_Pedido.vt_OtroValor1 = 0;
                //Info_Pedido.vt_OtroValor2 = 0;

                //Info_Pedido.vt_plazo = Info_TerminoPago.Dias_Vct;
                //Info_Pedido.vt_seguro = 0;
                //Info_Pedido.vt_serie1 = talonarioInfo.Establecimiento;
                //Info_Pedido.vt_serie2 = talonarioInfo.PuntoEmision;
                //Info_Pedido.EsDocumentoElectronico = (bool)talonarioInfo.es_Documento_electronico;
                //Info_Pedido.vt_tipo_venta = Info_TerminoPago.IdTerminoPago;
                //Info_Pedido.vt_tipoDoc = "FACT";
                //Info_Pedido.vt_anio = Info_Pedido.vt_fecha.Year;
                //Info_Pedido.vt_mes = Info_Pedido.vt_fecha.Month;
                //Info_Pedido.Vendedor = (ucFa_VendedorCmb.cmb_vendedor.Text == "") ? "" : ucFa_VendedorCmb.cmb_vendedor.Text;
                //Info_Pedido.Cliente = ucFa_ClienteCmb.cmb_cliente.Text;

                Info_Pedido.lista_detalle = new List<fa_pedido_det_Info>(Binding_List_Pedido_det.Where(q => q.IdProducto != 0));



                return Info_Pedido;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new fa_pedido_Info();
            }
        }

        public List<fa_factura_x_fa_TerminoPago_Info> Get_List_fact_x_Termino_pago()
        {
            try
            {
                List<fa_factura_x_fa_TerminoPago_Info> ListaFormaPago = new List<fa_factura_x_fa_TerminoPago_Info>();
                foreach (var item in Binding_list_fac_form_pago)
                {
                    fa_factura_x_fa_TerminoPago_Info info = new fa_factura_x_fa_TerminoPago_Info();
                    info.IdEmpresa = param.IdEmpresa;
                    //info.IdSucursal = Info_Pedido.IdBodega;
                    //info.IdBodega = Info_Pedido.IdSucursal;
                    //info.IdCbteVta = Info_Pedido.IdCbteVta;

                    //info.Secuencia = item.Secuencia;
                    //info.Fecha = dateFecha.Value;
                    info.Fecha_vct = item.Fecha_vct;
                    info.Dias_Plazo = item.Dias_Plazo;
                    info.Por_Distribucion = item.Por_Distribucion;
                    info.Valor = item.Valor;
                    info.IdTerminoPago = item.IdTerminoPago;
                    ListaFormaPago.Add(info);
                }
                return ListaFormaPago;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<fa_factura_x_fa_TerminoPago_Info>();
            }
        }

        public List<fa_factura_x_formaPago_Info> Get_List_fact_x_forma_pago()
        {
            try
            {
                List<fa_factura_x_formaPago_Info> ListaFormaPago = new List<fa_factura_x_formaPago_Info>();

                //ListaFormaPago = ucFa_FormaPago_x_Factura.Get_List_factura_x_formaPago();


                return ListaFormaPago;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<fa_factura_x_formaPago_Info>();
            }
        }

        #endregion

        #region funciones Grabar & Modifica & Anular & Limpiar & Validar

        private Boolean Anular()
        {
            Boolean Respuesta = false;

            try
            {
                if (MessageBox.Show("¿Realmente Desea Anular la Factura?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion frm = new FrmGe_MotivoAnulacion();
                    if (Info_Pedido.Estado == "I" || lblAnulado.Visible == true)
                    {
                        MessageBox.Show("La Factura se encuentra Anulada.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return Respuesta;
                    }

                    Get_Info_Pedido();
                    frm.ShowDialog();
                    Info_Pedido.MotivoAnulacion = frm.motivoAnulacion;
                    string mensaje_error = "";

                    //Respuesta = Bus_Pedido.AnularDB(Info_Pedido, param.Fecha_Transac, ref mensaje_error);
                    if (Respuesta)
                    {
                        MessageBox.Show("La Factura se Anuló Correctamente.\n" + "**** " + frm.motivoAnulacion + " ****"); lblAnulado.Visible = true;
                        //ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Never;
                        //ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;


                    }
                    else
                    {
                        MessageBox.Show("Error al anular Factura " + "**** " + frm.motivoAnulacion + " ****"); lblAnulado.Visible = true;
                    }
                }

                return Respuesta;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void limpiar()
        {
            try
            {
                //txtIdFactura.Text = "";
                gridControl_Factura.DataSource = null;
                //txtObservacion.Text = "";
                //txtidContable.Text = "";
                //ucFa_ClienteCmb.set_ClienteInfo(0);
                //ucFa_VendedorCmb.set_VendedorInfo(0);
                //cmbCaja.EditValue = Info_Param_fact.IdCaja_Default_Factura;
                cmbTerminoPago.EditValue = "";
                //spinEditDiasPlazo.Value = 0;
                //dateFecha.Value = dateFechaVencimiento.Value = DateTime.Now;
                CalcularTotales();
                cargarNumDoc();
                //txtObservacion.Text = "";



                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                Binding_List_Pedido_det = new BindingList<fa_pedido_det_Info>();
                Info_Pedido.lista_detalle = new List<fa_pedido_det_Info>();

                Set_Accion_In_controls();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Guardar()
        {
            try
            {
                Get_TerminoPago();

                if (Bus_Pedido.GrabarDB(Info_Pedido, ref id, ref msg))
                {
                    Info_Pedido.IdPedido = id;
                    Info_Pedido.Vendedor = UC_Cliente.cmb_vendedor.Text;

                    if (MessageBox.Show("Pedido # " + id + " Ingresada con éxito." + "\n" + "¿Desea Imprimir el Pedido N° " + id + "?", "Imprimir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        toolStripButton1_Click(new Object(), new EventArgs());
                    }
                    else { }

                    txt_pedido.Text = id.ToString();
                    if (Info_Pedido.CodPedido == "")
                    {
                        txtCodigo.Text = "PED" + id;
                    }
                    else { txtCodigo.Text = Info_Pedido.CodPedido; }

                    btn_grabar.Enabled = false;
                    btn_guardarSalir.Enabled = false;
                }
                else
                {
                    if (msg != "")
                    {
                        estado = true;
                        MessageBox.Show(msg);
                    }
                }
                //btn_grabar.Enabled = false;
                //btn_guardarSalir.Enabled = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        Boolean Modificar()
        {
            try
            {
                Boolean bolResult = false;

                this.txt_observacion.Focus();

                Get_Info_Pedido();
                Get_TerminoPago();

                if (!Validar())
                {
                    return bolResult;
                }
                else
                {

                    string msg = "";

                    if (MessageBox.Show("La FACT # " + Info_Pedido.IdPedido + " se procedera a Guardar." + "\n" + "¿Desea Continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        bolResult = Bus_Pedido.ModificarDB(Info_Pedido, ref msg);
                        if (bolResult)
                        {
                            bolResult = true;
                            MessageBox.Show("La FACT # " + Info_Pedido.IdPedido + " Fue Modificada con Exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                        else { MessageBox.Show(msg); };
                    }
                }
                return bolResult;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        Boolean Guardar_Datos()
        {
            try
            {
                Boolean respuesta = false;
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Guardar();
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        respuesta = Modificar();
                        break;
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        Boolean ValidarParametros()
        {
            try
            {
                fa_parametro_Bus BusParametros = new fa_parametro_Bus();
                fa_parametro_info param_fa = new fa_parametro_info();
                param_fa = BusParametros.Get_Info_parametro(param.IdEmpresa);
                if (param_fa != null)
                {
                    if (param_fa.IdMovi_inven_tipo_Factura == 0 || param_fa.IdMovi_inven_tipo_Factura_Anulacion == 0 || param_fa.IdTipoCbteCble_Factura == 0 || param_fa.IdTipoCbteCble_Factura_Costo_VTA == 0 || param_fa.IdTipoCbteCble_Factura_Costo_VTA_Reverso == 0 || param_fa.IdTipoCbteCble_Factura_Reverso == 0)
                    {
                        MessageBox.Show("No puede continuar porque están incompletos los parámetros de Ventas.. \nIngréselos desde la pantalla de parámetros de Ventas o, comuníquese con sistemas", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Faltan Parametros de factuacion ");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        int Valida_IdSucursal = 0;

        public Boolean Validar()
        {
            try
            {
                Valida_IdSucursal = param.IdSucursal;

                if (Valida_IdSucursal != info_sucursal.IdSucursal)
                {
                    MessageBox.Show("El usuario : " + param.IdUsuario + " , no tiene asignada la bodega : " + info_sucursal.Su_Descripcion + "");
                    return false;
                }

                if (Info_Pedido.IdCliente == 0)
                {
                    MessageBox.Show("Por Favor Seleccione un cliente");
                    return false;
                }



                if (this.cmbTerminoPago.EditValue == null || cmbTerminoPago.EditValue == "")
                {
                    MessageBox.Show("Ingrese el Término de Pago ", "Sistemas");
                    return false;
                }

                if (Info_Pedido.IdVendedor == 0)
                {
                    MessageBox.Show("Por Favor Seleccione un vendedor");
                    return false;
                }


                if (Info_Pedido.lista_detalle.Count() == 0)
                {
                    MessageBox.Show("Por Favor Seleccione Al Menos un producto");
                    return false;
                }
                else
                {
                    foreach (var item in Info_Pedido.lista_detalle)
                    {
                        if (item.dp_cantidad == 0 && item.IdProducto != 0)
                        {
                            MessageBox.Show("Por Favor Ingrese cantidad a/los Productos");
                            return false;
                        }

                        if (item.dp_precio == 0 && item.IdProducto != 0)
                        {
                            MessageBox.Show("Por Favor Ingrese precio a/los Productos");
                            return false;
                        }
                    }
                }

                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (Bus_Pedido.VerificarCodigo(Info_Pedido.CodPedido))
                    {
                        MessageBox.Show("El Código Ingresado ya existe por favor ingrese uno diferente");
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        #endregion

        #region Controles


        public void ucGe_Menu_event_btn_Generar_XML_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = "";

                fa_parametro_Bus bus_Param = new fa_parametro_Bus();
                fa_parametro_info param_info = new fa_parametro_info();

                param_info = bus_Param.Get_Info_parametro(param.IdEmpresa);

                //if (Bus_Factura.GenerarXml_Factura(param.IdEmpresa, Convert.ToInt32(UC_Sucursal_Bodega.cmb_sucursal.EditValue), Convert.ToInt32(UC_Sucursal_Bodega.cmb_bodega.EditValue), Info_Pedido.IdCbteVta, param_info.pa_ruta_descarga_xml_fac_elct, ref  mensaje))
                //{
                //    MessageBox.Show(mensaje);
                //}
                //else
                //{ MessageBox.Show(mensaje); }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_event_btnImprimirSoporte_Click(object sender, EventArgs e)
        {
            try
            {
                XFAC_Rpt007_rpt rptSoporte = new XFAC_Rpt007_rpt(param.IdUsuario);
                XFAC_Rpt007_Bus busRpt = new XFAC_Rpt007_Bus();
                List<XFAC_Rpt007_Info> lstRpt = new List<XFAC_Rpt007_Info>();
                rptSoporte.RequestParameters = false;

                lstRpt = busRpt.get_SoporteFactura(Info_Pedido.IdEmpresa, Info_Pedido.IdSucursal, Info_Pedido.IdBodega, Info_Pedido.IdPedido);
                rptSoporte.lstRpt = lstRpt;

                rptSoporte.CreateDocument();
                rptSoporte.ShowPreviewDialog();

                ImprimirDiario();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ImprimirDiario()
        {
            try
            {
                XCONTA_Rpt003_rpt reporte = new XCONTA_Rpt003_rpt();
                Info_Fac_x_cbtecble = bus_Fac_x_cbtecble.Get_info_fa_factura_x_ct_cbtecble(Info_Pedido.IdEmpresa, Info_Pedido.IdSucursal, Info_Pedido.IdBodega, Info_Pedido.IdPedido, Cl_Enumeradores.eMotivo_Diario_x_Vta.X_FACT);

                reporte.set_parametros(Info_Fac_x_cbtecble.ct_IdEmpresa, Info_Fac_x_cbtecble.ct_IdTipoCbte, Info_Fac_x_cbtecble.ct_IdCbteCble);
                reporte.RequestParameters = true;
                reporte.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Anular();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                XFAC_Rpt008_rpt rptSoporte = new XFAC_Rpt008_rpt(param.IdUsuario);
                tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus busDoc_x_Emp = new tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus();
                tb_sis_Documento_Tipo_Reporte_x_Empresa_Info InfoDoc_x_Emp = new tb_sis_Documento_Tipo_Reporte_x_Empresa_Info();

                InfoDoc_x_Emp = busDoc_x_Emp.get_DisenioRpt(param.IdEmpresa, Cl_Enumeradores.eTipoDocumento_Talonario.FACT.ToString());
                if (InfoDoc_x_Emp.File_Disenio_Reporte != null)
                {
                    File.WriteAllBytes(RootReporte, InfoDoc_x_Emp.File_Disenio_Reporte);
                    rptSoporte.LoadLayout(RootReporte);
                }


                XFAC_Rpt008_Bus busRpt = new XFAC_Rpt008_Bus();
                List<XFAC_Rpt008_Info> lstRpt = new List<XFAC_Rpt008_Info>();
                rptSoporte.RequestParameters = false;

                lstRpt = busRpt.get_ImpresionFactura(Info_Pedido.IdEmpresa, Info_Pedido.IdSucursal, Info_Pedido.IdBodega, Info_Pedido.IdPedido);
                rptSoporte.lstRpt = lstRpt;

                rptSoporte.CreateDocument();
                rptSoporte.ShowPreviewDialog();

                ImprimirDiario();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar_Datos())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar_Datos())
                    limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void UCGrid_Evente_ultraGrid_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                CalcularTotales();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void UCGrid_Event_ultraGrid_AfterCellUpdate(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                CalcularTotales();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void UCGrid_Event_ultraGrid_ClickCell(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                CalcularTotales();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        #endregion

        public void Cargar_Grid()
        {
            try
            {
                //Binding_List_Pedido_det = new BindingList<fa_pedido_det_Info>();

                if (Binding_List_Pedido_det.Count() > 0)
                {
                    for (int i = Binding_List_Pedido_det.Count(); i < Info_Param_fact.NumeroDeItemFact; i++)
                    {
                        Binding_List_Pedido_det.Add(new fa_pedido_det_Info());

                    }
                    gridControl_Factura.DataSource = Binding_List_Pedido_det;
                }
                else
                {
                    for (int i = 0; i < Info_Param_fact.NumeroDeItemFact; i++)
                    {
                        Binding_List_Pedido_det.Add(new fa_pedido_det_Info());

                    }
                    gridControl_Factura.DataSource = Binding_List_Pedido_det;
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Generar_Xml()
        {
            try
            {
                string mensaje = "";

                fa_parametro_Bus bus_Param = new fa_parametro_Bus();
                fa_parametro_info param_info = new fa_parametro_info();

                param_info = bus_Param.Get_Info_parametro(param.IdEmpresa);

                //if (Bus_Factura.GenerarXml_Factura(param.IdEmpresa, Convert.ToInt32(UC_Sucursal_Bodega.cmb_sucursal.EditValue), Convert.ToInt32(UC_Sucursal_Bodega.cmb_bodega.EditValue), Info_Pedido.IdCbteVta, param_info.pa_ruta_descarga_xml_fac_elct, ref  mensaje))
                //{
                //    MessageBox.Show(mensaje);
                //}
                //else
                //{ MessageBox.Show(mensaje); }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void frmFA_Pedido_Mant_GE_Load(object sender, EventArgs e)
        {
            try
            {

                UC_Cliente.llblRuc.Visible = false;

                TipoPago();

                UC_Sucursal_Bodega.set_Idsucursal(param.IdSucursal);

                listPedidosNoDespachados = Bus_Pedido.Get_List_pedido(param.IdEmpresa);
                UC_Cliente.CargarCombos();

                Event_frmFA_Pedido_Mant_FormClosing += new delegate_frmFA_Pedido_Mant_FormClosing(frmFA_Pedido_Mant_GE_Event_frmFA_Pedido_Mant_FormClosing);
                txt_plazo.Text = "3";
                dtFechaVenc.Value = dtFecha.Value.AddDays(3);
                UC_Cliente.CargarCombos();

                fa_catalogo_Bus busCatal = new fa_catalogo_Bus();
                cmbEstadoProduccion.DataSource = busCatal.Get_List_catalogo(1);

                UC_Sucursal_Bodega.TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal;

                UC_Cliente.txt_Direccion.Visible = false;
                UC_Cliente.txt_Ruc.Visible = false;
                UC_Cliente.txt_Telefonos.Visible = false;
                UC_Cliente.lbltelefono.Visible = false;
                UC_Cliente.llblRuc.Visible = false;
                UC_Cliente.lblDireccion.Visible = false;



                cargar_combo();

                Info_param_inven = Bus_param_inven.Get_Info_Parametro(param.IdEmpresa);
                Info_Param_fact = Bus_Param_facturacion.Get_Info_parametro(param.IdEmpresa);

                LoadProductos();

                lst_grupo_punto_cargo = bus_grupo_punto_cargo.Get_List_punto_cargo_grupo(param.IdEmpresa, ref MensajeError);
                cmb_Grupo_punto_cargo.DataSource = lst_grupo_punto_cargo;

                lst_punto_cargo = bus_punto_cargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmb_Punto_Cargo.DataSource = lst_punto_cargo;


                if (Accion == 0) { Accion = Cl_Enumeradores.eTipo_action.grabar; }

                Set_Accion_In_controls();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frmFA_Pedido_Mant_GE_Event_frmFA_Pedido_Mant_FormClosing(object sender, EventArgs e) { }

        public void LoadProductos()
        {
            try
            {

                info_bodega = UC_Sucursal_Bodega.get_bodega();
                info_sucursal = UC_Sucursal_Bodega.get_sucursal();


                if (UC_Sucursal_Bodega.get_bodega() != null && UC_Sucursal_Bodega.get_sucursal() != null)
                {
                    gridControl_Factura.DataSource = Binding_List_Pedido_det;
                    load_Producto(param.IdEmpresa, Convert.ToInt32(UC_Sucursal_Bodega.cmb_sucursal.EditValue), Convert.ToInt32(UC_Sucursal_Bodega.cmb_bodega.EditValue));
                }


                Lista_PuntoCargo = Bus_Punto_Cargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmb_Punto_Cargo.DataSource = Lista_PuntoCargo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void load_Producto(int idempresa, int IdSucursal, int IdBodega)
        {
            try
            {
                Lista_producto = Bus_Producto.Get_list_Producto_modulo_x_Ventas(idempresa, IdSucursal, IdBodega);

                foreach (var item in Lista_producto)
                    item.Disponible = item.pr_stock == null ? 0 : Convert.ToDouble(item.pr_stock) - item.pr_pedidos == null ? 0 : Convert.ToDouble(item.pr_pedidos);

                cmbProducto.DataSource = Lista_producto;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private List<fa_catalogo_Info> lstNaturaleza()
        {
            try
            {
                List<fa_catalogo_Info> lstInfo = new List<fa_catalogo_Info>();
                fa_catalogo_Info Info = new fa_catalogo_Info();
                Info.IdCatalogo = Cl_Enumeradores.eTipoNaturalezaProducto.PRD_X_TODO.ToString();
                lstInfo.Add(Info);

                Info = new fa_catalogo_Info();
                Info.IdCatalogo = Cl_Enumeradores.eTipoNaturalezaProducto.PRD_X_VENT.ToString();
                lstInfo.Add(Info);

                return lstInfo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

                return new List<fa_catalogo_Info>();
            }
        }

        void CalcularIva()
        {
            try
            {
                double precio = 0;
                double cantidad = 0;
                double PrecioFinal = 0;
                double subtotal = 0;
                double Iva = 0;
                double Por_Iva = 0;
                double Total = 0;

                foreach (var item in Binding_List_Pedido_det)
                {
                    if (Info_param_inven.Maneja_Stock_Negativo == "N")
                    {

                        if (item.IdProducto > 0)
                        {
                            var ItemProd_Busc = Lista_producto.First(v => v.IdProducto == item.IdProducto);


                            if (item.dp_cantidad > ItemProd_Busc.pr_stock)
                            {
                                MessageBox.Show("La cantidad Supera Al Stock");
                                //item.dp_cantidad = item.stock;
                            }
                            if (item.dp_cantidad < 0)
                            {
                                item.dp_cantidad = item.dp_cantidad * -1;
                            }
                        }
                    }



                    item.dp_desUni = Math.Round((item.dp_PorDescuento * (item.dp_precio)) / 100, 2);

                    item.dp_PrecioFinal = Math.Round(((item.dp_precio) - item.dp_desUni), 2);

                    item.dp_subtotal = item.dp_cantidad * Math.Round((item.dp_PrecioFinal), 2);



                    tb_sis_impuesto_Info InfoTipoImpuesto = new tb_sis_impuesto_Info();
                    InfoTipoImpuesto = listTipoImpu_x_Iva.FirstOrDefault(v => v.IdCod_Impuesto == item.IdCod_Impuesto_Iva);

                    if (InfoTipoImpuesto != null)
                    {
                        Iva = ((subtotal * InfoTipoImpuesto.porcentaje) / 100);
                        Por_Iva = InfoTipoImpuesto.porcentaje;
                    }


                    item.dp_iva = ((item.dp_subtotal) * Por_Iva) / 100;
                    item.dp_total = Math.Round((item.dp_subtotal + item.dp_iva), 2);

                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void CalcularTotales()
        {
            try
            {
                double base0 = 0;
                double base12 = 0;
                double iva = 0;
                lista_producto_detalle = new List<fa_pedido_det_Info>();
                //lista_producto_detalle = (List < fa_pedido_det_Info >) this.gridView_Factura.lstPro_x_Bodega;

                foreach (var item in lista_producto_detalle)
                {
                    if (item.Paga_Iva == true)
                    {
                        base12 += (item.Subtotal == null) ? 0 : item.Subtotal;
                    }
                    else
                    {
                        base0 += (item.dp_total == null) ? 0 : item.dp_total;
                    }
                    iva += (item.dp_iva == null) ? 0 : item.dp_iva;
                }
                txt_Base0.EditValue = (decimal)base0;
                txtBase12.EditValue = (decimal)base12;
                txtSubTotal.EditValue = (decimal)base0 + (decimal)base12;
                txtIva.EditValue = (decimal)iva;
                decimal otros;
                otros = Convert.ToDecimal(txtTransporte.EditValue) + Convert.ToDecimal(txtInteres.EditValue) + Convert.ToDecimal(txtOtro1.EditValue) + Convert.ToDecimal(txtOtro2.EditValue);
                txtTotal.EditValue = Convert.ToDecimal(txtSubTotal.EditValue) + Convert.ToDecimal(txtIva.EditValue) + otros;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void dateFechaVencimiento_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                //TimeSpan o = dateFechaVencimiento.Value - Convert.ToDateTime(dateFecha.Value.ToShortDateString());
                //spinEditDiasPlazo.Value = o.Days;
                //spinEditDiasPlazo_Validating(new object(), new CancelEventArgs());
                //if (this.dateFechaVencimiento.Value < dateFecha.Value)
                //{
                //    dateFechaVencimiento.Value = dateFecha.Value;

                //    return;
                //}
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void spinEditDiasPlazo_Validating(object sender, CancelEventArgs e)
        {
            try
            {

                //if (this.spinEditDiasPlazo.Value < 0)
                //{
                //    dateFechaVencimiento.Value = dateFecha.Value;
                //    spinEditDiasPlazo.Value = 0;
                //    return;
                //}
                //dateFechaVencimiento.Value = dateFecha.Value;
                //dateFechaVencimiento.Value = Convert.ToDateTime(dateFechaVencimiento.Value.ToShortDateString()).AddDays(Convert.ToDouble(spinEditDiasPlazo.Value));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void txtTransporte_AfterExitEditMode(object sender, EventArgs e)
        {
            try
            {
                CalcularTotales();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void mnu_salir_Click(object sender, EventArgs e)
        {


        }

        public void cargarNumDoc()
        {
            try
            {
                if (Convert.ToString(_Accion) == "grabar")
                {
                    //UCNumDoc.IdTipoDocumento = Cl_Enumeradores.eTipoDocumento_Talonario.FACT;
                    //if (UC_Sucursal_Bodega.get_sucursal() != null && UC_Sucursal_Bodega.get_bodega() != null)
                    //{
                    //    UCNumDoc.IdEstablecimiento = UC_Sucursal_Bodega.get_sucursal().Su_CodigoEstablecimiento;
                    //    UCNumDoc.IdPuntoEmision = UC_Sucursal_Bodega.get_bodega().cod_punto_emision;
                    //    UCNumDoc.Get_Primer_Documento_no_usado();
                    //}
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ofrm_RetornodelId2(string TipoAnulacion)
        {
            try
            {
                if (Bus_Pedido_Det.VerificarOrdenDespacho(Info_Pedido))
                {

                    Info_Pedido.IdEmpresa = param.IdEmpresa;
                    Info_Pedido.IdUsuarioUltAnu = param.IdUsuario;
                    Info_Pedido.Fecha_UltAnu = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    Info_Pedido.MotivoAnulacion = TipoAnulacion;
                    if (MessageBox.Show("¿Está seguro que desea anular el pedido #" + txt_pedido.Text + " ?", "Anulación de Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string mensej = "";
                        if (Bus_Pedido.AnularDB(Info_Pedido, ref mensej))
                        {
                            MessageBox.Show("Anulado con éxito el pedido # " + Info_Pedido.IdPedido);
                            lblAnulado.Visible = true;
                            btn_guardarSalir.Enabled = false;
                            btn_grabar.Enabled = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se puede anular el pedido #: " + txt_pedido.Text + "  ya que tiene una Orden de despacho Activa");
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void setFacturaCotizacion(fa_cotizacion_info infoCot)
        {
            try
            {
                //ucFa_ClienteCmb.set_ClienteInfo(infoCot.IdCliente);
                //Info_Pedido.IdUsuario = param.IdUsuario;
                //ucFa_VendedorCmb.set_VendedorInfo(infoCot.IdVendedor);
                //dateFecha.Value = infoCot.cc_fecha;
                //dateFechaVencimiento.Value = infoCot.cc_fechaVencimiento;
                //txtObservacion.Text = infoCot.cc_observacion;
                //spinEditDiasPlazo.Value = infoCot.cc_diasPlazo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void setFacturaGUIR(fa_guia_remision_Info infoGuia)
        {
            try
            {
                //ucFa_ClienteCmb.set_ClienteInfo(infoGuia.IdCliente);
                //Info_Pedido.IdUsuario = param.IdUsuario;
                //ucFa_VendedorCmb.set_VendedorInfo(infoGuia.IdVendedor);
                //txtObservacion.Text = infoGuia.gi_Observacion;
                //dateFecha.Value = Convert.ToDateTime(infoGuia.gi_fecha); spinEditDiasPlazo.Value = Convert.ToDecimal(infoGuia.gi_plazo);
                //dateFechaVencimiento.Value = Convert.ToDateTime(infoGuia.gi_fech_venc);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ultraComboDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

            }
            catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString()); MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)102)
                {
                    btnConsultar_Click(new object(), new EventArgs());
                }

            }
            catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString()); MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {


            }
            catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString()); MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        public void gridViewFormaPago_RowCountChanged(object sender, EventArgs e)
        {


        }

        public void gridViewFormaPago_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {


        }

        public void ultraCombo_tipoFactura_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cargarNumDoc();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void txtTotal_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (banderaCombo)
                {
                    if (Convert.ToInt32(txt_cupo_maximo.Text) == 0)
                    {
                    }
                    else
                    {
                        double Total_NoDespachado = 0;
                        var item = listPedidosNoDespachados.FirstOrDefault(r => r.IdCliente == Convert.ToDecimal(UC_Cliente.cmb_cliente.EditValue));

                        if (item == null)
                        {
                            Total_NoDespachado = 0;
                        }
                        else
                        {
                            Total_NoDespachado = item.dp_total;
                        }

                        double Total_Disponible = Convert.ToDouble(txtTotal.EditValue) + Total_NoDespachado;

                        if (Convert.ToDecimal(Total_Disponible) > Convert.ToDecimal(txt_cupo_maximo.Text))
                        {
                            MessageBox.Show("El valor del pedido ha exedido el cupo del Cliente este se guardara en estado de negociacion ");
                            cmb_estado_aprobacion.SelectedValue = "N";
                        }
                        else
                        {
                            cmb_estado_aprobacion.SelectedValue = "A";
                        }
                    }
                    banderaCombo = false;
                }

                fa_TerminoPago_Info objCmb = new fa_TerminoPago_Info();
                objCmb.IdTerminoPago = Convert.ToString(cmbTerminoPago.EditValue);

                ListPagoDistri = BusPagoDistri.Get_List_TerminoPago_Distribucion(objCmb.IdTerminoPago);

                if (Convert.ToDouble(this.txtTotal.EditValue) == 0)
                {
                    //vMessageBox.Show("Ingrese el valor total de la factura .", "Sistemas");
                    return;
                }

                List = new List<fa_factura_x_fa_TerminoPago_Info>();
                SumValForPag = 0;
                SumPorDist = 0;
                foreach (var item in ListPagoDistri)
                {
                    fa_factura_x_fa_TerminoPago_Info info = new fa_factura_x_fa_TerminoPago_Info();

                    info.Secuencia = item.Secuencia;
                    info.Por_Distribucion = item.Por_distribucion;
                    DateTime fecha = dtFecha.Value.AddDays(item.Num_Dias_Vcto);
                    info.Fecha_vct = fecha;
                    info.Dias_Plazo = item.Num_Dias_Vcto;
                    info.Valor = Convert.ToDouble(txtTotal.EditValue) * (item.Por_distribucion / 100);
                    info.IdTerminoPago = cmbTerminoPago.EditValue.ToString();

                    SumValForPag = SumValForPag + info.Valor;
                    SumPorDist = SumPorDist + info.Por_Distribucion;

                    List.Add(info);
                }

                DataSource_ForPag = new BindingList<fa_factura_x_fa_TerminoPago_Info>(List);
                gridControlFormaPag.DataSource = DataSource_ForPag;

                txtValForPag.Text = Convert.ToString(SumValForPag);
                txtPorDist.Text = Convert.ToString(SumPorDist);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void cmbTerminoPago_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTerminoPago.EditValue != null)
                {
                    if (cmbTerminoPago.Text != "")
                    {
                        Info_TerminoPago = new fa_TerminoPago_Info();
                        Info_TerminoPago = list_TerminoPago.Where(q => q.IdTerminoPago == Convert.ToString(cmbTerminoPago.EditValue)).FirstOrDefault();
                        //spinEditDiasPlazo.EditValue = Info_TerminoPago.Dias_Vct;
                    }
                }
                else
                {
                    //spinEditDiasPlazo.EditValue = 1;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        Boolean Validar_CtasCbles_Factura()
        {
            try
            {
                if (Info_TerminoPago.Dias_Vct == 0)
                {
                    if (InfoCliente.IdCtaCble_cxc == null)
                    {
                        if (MessageBox.Show("El Cliente no Tiene Cta Cble de Contado. No Generará Diario, Desea Continuar?" + "\n", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (InfoCliente.IdCtaCble_cxc_Credito == null)
                    {
                        if (MessageBox.Show("El Cliente no Tiene Cta Cble de Credito. No Generará Diario, Desea Continuar?" + "\n", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            return false;
                        }
                    }
                }

                if (Info_Param_fact.IdCtaCble_IVA == null)
                {
                    if (MessageBox.Show("No hay Parametrizado Cta Cble de IVA. No Generará Diario, Desea Continuar?" + "\n", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return false;
                    }
                }

                in_Producto_Info Info_Producto = new in_Producto_Info();


                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public void ucFa_ClienteCmb_event_cmb_cliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //if (ucFa_ClienteCmb.get_ClienteInfo() != null)
                //{
                //    tabControl2.Enabled = true;
                //    xtraTabControl_cuerpo.Enabled = true;
                //    string IdTipoCredito = "";
                //    InfoCliente = ucFa_ClienteCmb.get_ClienteInfo();
                //    if (InfoCliente.IdTipoCredito == null)
                //        IdTipoCredito = Cl_Enumeradores.eTipoCreditoCliente.AMB.ToString();
                //    else
                //        IdTipoCredito = InfoCliente.IdTipoCredito;





                //    spinEditDiasPlazo.EditValue = InfoCliente.cl_plazo;
                //}
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_Factura_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                double cantidad = 0;
                double precio = 0;
                double precio_final = 0;
                double Descuento_Unitario = 0;
                double Porc_Descuento = 0;
                double Porc_Iva = 0;
                double Descuento_total = 0;
                double subtotal = 0;
                double subtotalDesc = 0;
                double iva = 0;
                double Total_Vta = 0;
                double Peso = 0;

                Info_Pedido_Det = new fa_pedido_det_Info();
                Info_Pedido_Det = (fa_pedido_det_Info)this.gridView_Factura.GetFocusedRow();
                //in_Producto_Info InfoProd = new in_Producto_Info();


                precio = Convert.ToDouble(gridView_Factura.GetFocusedRowCellValue(colPrecio));
                cantidad = Convert.ToDouble(gridView_Factura.GetFocusedRowCellValue(colCantidad));
                Porc_Descuento = Convert.ToDouble(gridView_Factura.GetFocusedRowCellValue(colPorc_Descuento));
                Descuento_total = ((cantidad * precio) * Porc_Descuento) / 100;
                Descuento_Unitario = (Porc_Descuento * precio) / 100;
                subtotal = (precio * cantidad) - Descuento_total;

                iva = 0;
                Porc_Iva = 0;
                Total_Vta = 0;



                if (e.Column == colCantidad || e.Column == colPrecio)
                {

                    //StockProd
                    //if (cantidad > 0)
                    //{

                    if (cantidad > StockProd)
                    {
                        MessageBox.Show("La Cantidad Ingresada : es Menor al Stock Actual : " + StockProd + "");
                        //return false;
                    }
                    //}
                    //else 
                    //{ 
                    gridView_Factura.SetFocusedRowCellValue(colDescuento, Descuento_total);
                    gridView_Factura.SetFocusedRowCellValue(colSubTotal_sin_desc, subtotal);
                    gridView_Factura.SetFocusedRowCellValue(colSubtotal, subtotal);



                    tb_sis_impuesto_Info InfoTipoImpuesto = new tb_sis_impuesto_Info();

                    if (Info_Pedido_Det == null)
                    {
                        InfoTipoImpuesto = listTipoImpu_x_Iva.FirstOrDefault(v => v.IdCod_Impuesto == Convert.ToString(param.iva.IdCod_Impuesto));
                    }
                    else
                    {
                        InfoTipoImpuesto = listTipoImpu_x_Iva.FirstOrDefault(v => v.IdCod_Impuesto == Info_Pedido_Det.IdCod_Impuesto_Iva);
                    }





                    if (InfoTipoImpuesto != null)
                    {
                        iva = ((subtotal * InfoTipoImpuesto.porcentaje) / 100);
                        Porc_Iva = InfoTipoImpuesto.porcentaje;
                    }

                    Total_Vta = subtotal + iva;


                    gridView_Factura.SetFocusedRowCellValue(colSubtotal, subtotal);
                    gridView_Factura.SetFocusedRowCellValue(colIva, iva);
                    gridView_Factura.SetFocusedRowCellValue(colPorce_Iva, Porc_Iva);
                    gridView_Factura.SetFocusedRowCellValue(colTotal, Total_Vta);

                    gridView_Factura.SetFocusedRowCellValue(colPrecioFinal, (precio - Descuento_Unitario));
                    //}
                }

                if (e.Column == colIdCod_Impuesto_Iva)
                {
                    gridView_Factura.SetFocusedRowCellValue(colPrecioFinal, (precio - Descuento_Unitario));
                    gridView_Factura.SetFocusedRowCellValue(colDescuento, Descuento_total);
                    gridView_Factura.SetFocusedRowCellValue(colSubTotal_sin_desc, subtotal);
                    gridView_Factura.SetFocusedRowCellValue(colSubtotal, subtotal - Descuento_total);

                    tb_sis_impuesto_Info InfoTipoImpuesto = new tb_sis_impuesto_Info();
                    InfoTipoImpuesto = listTipoImpu_x_Iva.FirstOrDefault(v => v.IdCod_Impuesto == Info_Pedido_Det.IdCod_Impuesto_Iva);
                    iva = 0;
                    Porc_Iva = 0;

                    if (InfoTipoImpuesto != null)
                    {
                        iva = ((subtotal * InfoTipoImpuesto.porcentaje) / 100);
                        Porc_Iva = InfoTipoImpuesto.porcentaje;
                    }
                    Total_Vta = subtotal + iva;
                    gridView_Factura.SetFocusedRowCellValue(colSubtotal, subtotal);
                    gridView_Factura.SetFocusedRowCellValue(colIva, iva);
                    gridView_Factura.SetFocusedRowCellValue(colPorce_Iva, Porc_Iva);
                    Total_Vta = subtotal + iva;
                    gridView_Factura.SetFocusedRowCellValue(colTotal, Total_Vta);

                }

                if (e.Column == colPorc_Descuento)
                {
                    Descuento_Unitario = (precio * Porc_Descuento) / 100;
                    Descuento_total = ((cantidad * precio) * Porc_Descuento) / 100;
                    subtotal = (precio * cantidad);
                    subtotalDesc = subtotal - Descuento_total;

                    gridView_Factura.SetFocusedRowCellValue(colPrecioFinal, (precio - Descuento_Unitario));
                    gridView_Factura.SetFocusedRowCellValue(colDescuento, Descuento_total);
                    gridView_Factura.SetFocusedRowCellValue(colSubTotal_sin_desc, subtotal);
                    gridView_Factura.SetFocusedRowCellValue(colSubtotal, subtotal - Descuento_total);

                    tb_sis_impuesto_Info InfoTipoImpuesto = new tb_sis_impuesto_Info();
                    InfoTipoImpuesto = listTipoImpu_x_Iva.FirstOrDefault(v => v.IdCod_Impuesto == Info_Pedido_Det.IdCod_Impuesto_Iva);
                    iva = 0;
                    Porc_Iva = 0;

                    if (InfoTipoImpuesto != null)
                    {
                        iva = ((subtotalDesc * InfoTipoImpuesto.porcentaje) / 100);
                        Porc_Iva = InfoTipoImpuesto.porcentaje;
                    }

                    gridView_Factura.SetFocusedRowCellValue(colPorce_Iva, Porc_Iva);
                    gridView_Factura.SetFocusedRowCellValue(colIva, iva);
                    gridView_Factura.SetFocusedRowCellValue(colTotal, (subtotal + iva - Descuento_total));

                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbProducto_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                double Por_Iva = 0;
                in_Producto_Info InfoProd = Lista_producto.First(v => v.IdProducto == Convert.ToDecimal(e.NewValue));

                StockProd = Convert.ToDouble(InfoProd.pr_stock);

                gridView_Factura.SetFocusedRowCellValue(colCodigo_Producto, InfoProd.IdProducto);
                gridView_Factura.SetFocusedRowCellValue(colPrecio, InfoProd.pr_precio_publico);
                gridView_Factura.SetFocusedRowCellValue(colCosto, InfoProd.pr_costo_promedio);
                gridView_Factura.SetFocusedRowCellValue(colStock, InfoProd.pr_stock);
                gridView_Factura.SetFocusedRowCellValue(colIdCtaCble_Ven0, InfoProd.IdCtaCble_Ven0);
                gridView_Factura.SetFocusedRowCellValue(colIdCtaCble_VenIva, InfoProd.IdCtaCble_VenIva);
                gridView_Factura.SetFocusedRowCellValue(colDescuento, InfoProd.Porc_Descuento);
                gridView_Factura.SetFocusedRowCellValue(colPeso, InfoProd.pr_peso);
                gridView_Factura.SetFocusedRowCellValue(colIdCod_Impuesto_Iva, InfoProd.IdCod_Impuesto_Iva);

                tb_sis_impuesto_Info InfoTipoImpuesto = new tb_sis_impuesto_Info();
                InfoTipoImpuesto = listTipoImpu_x_Iva.FirstOrDefault(v => v.IdCod_Impuesto == InfoProd.IdCod_Impuesto_Iva);

                if (InfoTipoImpuesto != null)
                    Por_Iva = InfoTipoImpuesto.porcentaje;

                gridView_Factura.SetFocusedRowCellValue(col_vt_estado, 'A');
                gridView_Factura.SetFocusedRowCellValue(colPorce_Iva, Por_Iva);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_porc_comision_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridControl_Factura_Click(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void ucGe_Menu_event_btn_Generar_XML_Click_1(object sender, EventArgs e)
        {
            try
            {
                Generar_Xml();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void spinEditDiasPlazo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //if (spinEditDiasPlazo.EditValue != null)
                //{
                //    if (spinEditDiasPlazo.Text != "")
                //    {
                //        dateFechaVencimiento.Value = dateFecha.Value.AddDays(Convert.ToInt32(spinEditDiasPlazo.EditValue));
                //    }
                //}
                //else
                //{
                //    dateFechaVencimiento.Value = DateTime.Now;
                //}
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_Factura_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                rowHandle = e.FocusedRowHandle;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void cargar_combo()
        {
            try
            {

                listTipoImpu_x_Iva = BusImp.Get_List_impuesto_para_Ventas("IVA");
                cmbImp_Iva.DataSource = listTipoImpu_x_Iva;


                list_TerminoPago = new List<fa_TerminoPago_Info>();
                list_TerminoPago = Bus_Termino_pago.Get_List_TerminoPago("");

                cmbTerminoPago.Properties.DataSource = list_TerminoPago;

            }
            catch (Exception ex)
            {

            }
        }

        private void gridControl_Factura_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue.ToString() == "46")
                {
                    if (MessageBox.Show("Está seguro que desea eliminar el registro", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView_Factura.DeleteSelectedRows();


                    }
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_cargar_diario_Click(object sender, EventArgs e)
        {
            try
            {

                fa_factura_x_ct_cbtecble_Info Info_Fac_x_cbtecble = new fa_factura_x_ct_cbtecble_Info();
                fa_factura_x_ct_cbtecble_Bus Bus_Fac_x_cbtecble = new fa_factura_x_ct_cbtecble_Bus();

                //Info_Fac_x_cbtecble = Bus_Fac_x_cbtecble.Get_info_fa_factura_x_ct_cbtecble(Info_Pedido.IdEmpresa, Info_Pedido.IdSucursal, Info_Pedido.IdBodega, Info_Pedido.IdCbteVta,Cl_Enumeradores.eMotivo_Diario_x_Vta.X_FACT);

                // ucCon_GridDiario.setInfo(Info_Fac_x_cbtecble.ct_IdEmpresa, Info_Fac_x_cbtecble.ct_IdTipoCbte, Info_Fac_x_cbtecble.ct_IdCbteCble);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UC_Sucursal_Bodega_Event_cmb_bodega1_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {

                LoadProductos();
                cargarNumDoc();
                // ultraCmb_tipoDoc_ValueChanged(new object(), new EventArgs());
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UC_Sucursal_Bodega_Event_cmb_sucursal1_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                LoadProductos();
                cargarNumDoc();
                //ultraCmb_tipoDoc_ValueChanged(new object(), new EventArgs());
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Accion_botton()
        {
            try
            {
                switch (Accion)
                {

                    case Cl_Enumeradores.eTipo_action.grabar:

                        Guardar();
                        //btn_grabar.Enabled = false;
                        //btn_guardarSalir.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        frmFa_CausalesdeModificacio_Anulacion ofrm = new frmFa_CausalesdeModificacio_Anulacion();
                        ofrm.RetornodelId += ofrm_RetornodelId;
                        ofrm.ShowDialog();

                        if (Bus_Pedido_Det.VerificarOrdenDespacho(Info_Pedido))
                        {
                            this.Actualizar();
                        }
                        else
                        {
                            var ListaPedidoDet = lista_producto_detalle.GroupBy(v => v.IdProducto).Select(g => new
                            {
                                Key = g.Key,
                                pe_cantidad = g.Sum(s => s.dp_cantidad),
                                pe_IdProducto = g.First().IdProducto
                            });

                            var ListaOrdDespPedido = ListaOrdenDEspachoxPedido.GroupBy(v => v.IdProducto).Select(g => new
                            {
                                Key = g.Key,
                                desp_cantidad = g.Sum(s => s.od_cantidad),
                                desp_IdProducto = g.First().IdProducto,
                                desp_pr_descripcion = g.First().pr_descripcion,
                                desp_IdOrdenDespacho = g.First().IdOrdenDespacho

                            });

                            foreach (var itemLPD in ListaPedidoDet)
                            {
                                foreach (var itemLODP in ListaOrdDespPedido)
                                {
                                    if (itemLPD.pe_IdProducto == itemLODP.desp_IdProducto)
                                    {
                                        if (itemLODP.desp_cantidad <= itemLPD.pe_cantidad)
                                        { }
                                        else
                                        {
                                            MessageBox.Show("La cantidad a modificar del producto : [" + itemLPD.pe_IdProducto + "] - " + itemLODP.desp_pr_descripcion + ", del pedido #: " + Info_Pedido.IdPedido + " , no se puede modificar ya que dicha cantidad es menor al total de la cantidad de los items despachados en el despacho #:  " + itemLODP.desp_IdOrdenDespacho + "", "Sistemas");

                                            // carga nuevamente el detalle de productos a su estado inicial

                                            Info_Pedido.lista_detalle = obj.lista_detalle;

                                            lista_producto_detalle = new List<fa_pedido_det_Info>();

                                            foreach (var item1 in Info_Pedido.lista_detalle)
                                            {
                                                fa_pedido_det_Info tabla_pedido = new fa_pedido_det_Info();

                                                //tabla_pedido.Codigo_Producto = item1.CodProducto;
                                                tabla_pedido.IdProducto = item1.IdProducto;
                                                tabla_pedido.dp_cantidad = item1.dp_cantidad;
                                                tabla_pedido.dp_PorDescuento = item1.dp_PorDescuento;
                                                tabla_pedido.dp_desUni = item1.dp_desUni;
                                                tabla_pedido.Peso = item1.Peso;
                                                tabla_pedido.dp_precio = item1.dp_precio;
                                                tabla_pedido.dp_PrecioFinal = item1.dp_PrecioFinal;
                                                tabla_pedido.Subtotal = item1.dp_subtotal;
                                                tabla_pedido.dp_total = item1.dp_total;
                                                tabla_pedido.dp_iva = item1.dp_iva;
                                                tabla_pedido.Paga_Iva = (item1.dp_pagaIva == "S") ? true : false;
                                                tabla_pedido.dp_detallexItems = item1.dp_detallexItems;
                                                lista_producto_detalle.Add(tabla_pedido);
                                            }

                                            CalcularTotales();
                                            return;
                                        }
                                    }
                                }
                            }

                            this.Actualizar();
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ofrm_RetornodelId(string TipoAnulacion)
        {
            Info_Pedido.MotivoAnulacion = TipoAnulacion;
        }

        private void Actualizar()
        {
            try
            {
                Info_Pedido.IdUsuarioUltMod = param.IdUsuario;
                Info_Pedido.nom_pc = param.nom_pc;
                Info_Pedido.ip = param.ip;

                if (Bus_Pedido.ModificarDB(Info_Pedido, ref msg))
                {
                    MessageBox.Show(msg, "SISTEMA ERP");
                    btn_grabar.Enabled = false;
                    btn_guardarSalir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Info_Pedido = new fa_pedido_Info();
                UC_Cliente.cmb_cliente.Enabled = true;
                txt_Base0.EditValue = 0;
                txt_cupo_maximo.Text = "";
                txt_observacion.Text = "";
                txt_pedido.Text = "";
                txt_plazo.Text = "";
                txtBase12.EditValue = 0;
                txtInteres.EditValue = 0;
                txtIva.EditValue = 0;
                txtOtro1.EditValue = 0;
                txtOtro2.EditValue = 0;
                txtSubTotal.EditValue = 0;
                txtTotal.EditValue = 0;
                txtTransporte.EditValue = 0;
                UC_Cliente.cmb_cliente.EditValue = "";
                UC_Cliente.cmb_vendedor.EditValue = "";
                txtCodigo.Text = "";
                btn_grabar.Enabled = true;
                btn_guardarSalir.Enabled = true;

                gridControl_Factura.DataSource = null;
                gridControlFormaPag.DataSource = null;

                cmbTerminoPago.EditValue = "";

                Cargar_Grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtTransporte_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularTotales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtInteres_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularTotales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtOtro1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularTotales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtOtro2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularTotales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private fa_pedido_Info get_Pedido()
        {
            try
            {
                //---------------------------------------------------------------------
                //-----------------OBTENEMOS LA CABECERA DEL PEDIDO--------------------
                //---------------------------------------------------------------------
                Info_Pedido = new fa_pedido_Info();
                Info_Pedido.IdEmpresa = param.IdEmpresa;
                Info_Pedido.CodPedido = txtCodigo.Text;
                info_sucursal = new tb_Sucursal_Info();
                //Obtenemos el objeto Info_Pedido de la sucursal del control
                info_sucursal = UC_Sucursal_Bodega.get_sucursal();
                info_bodega = new tb_Bodega_Info();
                Info_Pedido.CodPedido = txtCodigo.Text;
                //Obtenemos el objeto Info_Pedido de la bodega del control
                info_bodega = UC_Sucursal_Bodega.get_bodega();
                Info_Pedido.Trasnporte = Convert.ToDouble(txtTransporte.EditValue);
                Info_Pedido.Otro1 = Convert.ToDouble(txtOtro1.EditValue);
                Info_Pedido.Otro2 = Convert.ToDouble(txtOtro2.EditValue);
                Info_Pedido.Estado = (lblAnulado.Visible == true) ? "I" : "A";
                Info_Pedido.IdSucursal = info_sucursal.IdSucursal;
                Info_Pedido.Sucursal = info_sucursal.Su_Descripcion;
                Info_Pedido.IdBodega = (info_bodega.IdBodega != 0) ? info_bodega.IdBodega : 0;
                Info_Pedido.Bodega = info_bodega.bo_Descripcion;
                Info_Pedido.IdPedido = (this.txt_pedido.Text != "") ? Convert.ToDecimal(this.txt_pedido.Text) : 0;
                info_cliente = new fa_Cliente_Info();
                //Obtenemos el objeto Info_Pedido del Cliente del control

                Info_Pedido.IdCliente = Convert.ToDecimal((UC_Cliente.cmb_cliente.EditValue == null) ? 0 : UC_Cliente.cmb_cliente.EditValue);
                info_cliente.IdVendedor = Convert.ToInt16(UC_Cliente.cmb_vendedor.EditValue);
                Info_Pedido.Cliente = info_cliente.Nombre_Cliente;
                Info_Pedido.IdVendedor = info_cliente.IdVendedor;
                //Obtenemos los demas datos que van a la cabecera del pedido 
                Info_Pedido.cp_fecha = this.dtFecha.Value;
                Info_Pedido.cp_diasPlazo = (this.txt_plazo.Text != "") ? Convert.ToInt32(this.txt_plazo.Text) : 0;
                Info_Pedido.cp_fechaVencimiento = this.dtFechaVenc.Value;
                Info_Pedido.cp_observacion = (this.txt_observacion.Text != "") ? this.txt_observacion.Text : " ";
                Info_Pedido.cp_tipopago = Convert.ToString(cmbTerminoPago.EditValue);

                Info_Pedido.IdEstadoAprobacion = this.cmb_estado_aprobacion.SelectedValue.ToString();

                Info_Pedido.EstadoAprobacion = this.cmb_estado_aprobacion.Text;
                Info_Pedido.IdUsuario = param.IdUsuario;
                Info_Pedido.Fecha_Transac = DateTime.Now;
                Info_Pedido.nom_pc = param.nom_pc;
                Info_Pedido.ip = param.ip;
                Info_Pedido.Entregado = (cbxEntrega.Checked == true) ? "S" : "N";
                ///////////////////////////////////////////////////////////////
                Info_Pedido.IdEstadoProduccion = cmbEstadoProduccion.SelectedValue.ToString();
                //---------------------------------------------------------------------
                //-----------------OBTENEMOS DETALLES DE LOS PRODUCTOS-----------------
                //---------------------------------------------------------------------
                lista_producto_detalle = new List<fa_pedido_det_Info>();
                //lista_producto_detalle = this.UCFAModuloFacturacion.get_Tabla_detalle();
                List<fa_pedido_det_Info> lm = new List<fa_pedido_det_Info>();

                foreach (var item in Binding_List_Pedido_det)
                {
                    fa_pedido_det_Info pedido_det = new fa_pedido_det_Info();
                    pedido_det.IdEmpresa = Info_Pedido.IdEmpresa;
                    pedido_det.IdSucursal = Info_Pedido.IdSucursal;
                    pedido_det.IdBodega = Info_Pedido.IdBodega;
                    pedido_det.IdPedido = Info_Pedido.IdPedido;
                    pedido_det.Secuencial = item.Secuencial;
                    pedido_det.Peso = item.Peso;
                    pedido_det.IdProducto = item.IdProducto;
                    pedido_det.DesProduct = BusProd.Get_Descripcion_Producto(param.IdEmpresa, item.IdProducto);
                    pedido_det.dp_cantidad = item.dp_cantidad;
                    pedido_det.dp_precio = item.dp_precio;
                    pedido_det.dp_PorDescuento = item.dp_PorDescuento;
                    pedido_det.dp_desUni = item.dp_desUni;
                    pedido_det.dp_PrecioFinal = item.dp_PrecioFinal;
                    pedido_det.dp_subtotal = item.dp_subtotal;
                    pedido_det.dp_iva = item.dp_iva;
                    pedido_det.dp_total = item.dp_total;
                    pedido_det.dp_pagaIva = (item.Paga_Iva == true) ? "S" : "N";
                    pedido_det.dp_detallexItems = item.dp_detallexItems;

                    pedido_det.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                    pedido_det.Estado = "A";
                    pedido_det.idPunto_cargo = item.idPunto_cargo;

                    //if (this.gridView_Factura.GetFocusedRowCellValue(colIdPunto_cargo_grupo) != "")
                    //{
                    //    pedido_det.idPunto_cargo_grupo = null;
                    //}
                    //else
                    //{
                    //    pedido_det.idPunto_cargo_grupo = Convert.ToInt32(this.gridView_Factura.GetFocusedRowCellValue(colIdPunto_cargo_grupo));
                    //}
                    pedido_det.idPunto_cargo_grupo = item.idPunto_cargo_grupo;
                    pedido_det.dp_por_iva = item.dp_por_iva;
                    pedido_det.idCod_Impuesto_Ice = item.idCod_Impuesto_Ice;


                    lm.Add(pedido_det);
                }
                Info_Pedido.lista_detalle = lm;
                //---------------------------------------------------------------------
                //-----------------OBTENEMOS VALORES TOTALES DEL PEDIDO----------------
                //---------------------------------------------------------------------
                List<fa_pedido_valor_Info> lm_totales = new List<fa_pedido_valor_Info>();
                List<tb_sis_tipoDocumento_tipoValor_Info> lista_totales = new List<tb_sis_tipoDocumento_tipoValor_Info>();
                //lista_totales=UC_grid_totales.get_lista_detalle();
                foreach (var item1 in lista_totales)
                {
                    fa_pedido_valor_Info total_det = new fa_pedido_valor_Info();
                    total_det.IdEmpresa = Info_Pedido.IdEmpresa;
                    total_det.IdSucursal = Info_Pedido.IdSucursal;
                    total_det.IdBodega = Info_Pedido.IdBodega;
                    total_det.IdPedido = Info_Pedido.IdPedido;
                    total_det.IdTipoValor = item1.IdTipoValor;
                    total_det.signo = 1;
                    total_det.valor = item1.Valor;
                    lm_totales.Add(total_det);
                }
                Info_Pedido.lista_valores = lm_totales;
                return Info_Pedido;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new fa_pedido_Info();
            }
        }

        public void cargarGridOrdDesXpedi()
        {
            try
            {
                Get_Info_Pedido();
                fa_OrdenDespachoDet_bus busOrdeDesp = new fa_OrdenDespachoDet_bus();
                in_producto_Bus busprod = new in_producto_Bus();

                ListaOrdenDEspachoxPedido = busOrdeDesp.Get_List_orden_Desp_x_Pedido(obj);
                ListaOrdenDEspachoxPedido.ForEach(var => var.producto = busprod.Get_Descripcion_Producto(param.IdEmpresa, var.IdProducto));
                gridControlOrdDesXpedi.DataSource = ListaOrdenDEspachoxPedido;
                gridViewOrddesXPedi.ExpandAllGroups();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridControl_Factura_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                fa_pedido_det_Info infoTablaPedido = new fa_pedido_det_Info();

                infoTablaPedido = gridView_Factura.GetFocusedRow() as fa_pedido_det_Info;
                var a = infoTablaPedido.IdProducto;
                decimal idpro = Convert.ToDecimal(a);
                var q = from t in ListaOrdenDEspachoxPedido
                        where t.IdProducto == idpro
                        select t.IdProducto;
                if (q.ToList().Count == 0)
                {

                    //listTablaAux = gridControl_Factura.get_Tabla_detalle();
                    listTabla = new List<fa_pedido_det_Info>();

                    foreach (var item in listTablaAux)
                    {
                        fa_pedido_det_Info info = new fa_pedido_det_Info();

                        if (item.IdProducto == infoTablaPedido.IdProducto)
                        {
                            info.IdProducto = 0;
                            info.dp_cantidad = 0;
                            info.Peso = 0;
                            info.dp_precio = 0;
                            info.dp_PorDescuento = 0;
                            info.dp_desUni = 0;
                            info.dp_PrecioFinal = 0;
                            info.Subtotal = 0;
                            info.dp_iva = 0;
                            info.dp_total = 0;
                            //info.sto = 0;
                            info.dp_detallexItems = "";
                            //info.idpu = 0;
                            //info.precio = 0;

                            listTabla.Add(info);
                        }

                        else
                        {
                            info.IdProducto = item.IdProducto;
                            info.dp_cantidad = item.dp_cantidad;
                            info.Peso = item.Peso;
                            info.dp_precio = item.dp_precio;
                            info.dp_PorDescuento = item.dp_PorDescuento;
                            info.dp_desUni = item.dp_desUni;
                            info.dp_PrecioFinal = item.dp_PrecioFinal;
                            info.Subtotal = item.Subtotal;
                            info.dp_iva = item.dp_iva;
                            info.dp_pagaIva = item.dp_pagaIva;
                            info.dp_total = item.dp_total;
                            info.dp_detallexItems = item.dp_detallexItems;
                            info.Secuencial = item.Secuencial;

                            listTabla.Add(info);
                        }

                    }
                    //UCFAModuloFacturacion.carga_Grid(listTabla);
                    this.CalcularTotales();
                }
                else
                {
                    if (e.KeyValue.ToString() == "46")
                    {
                        MessageBox.Show("El Registro seleccionado tiene una orden de despacho activa");
                    }
                    else
                    { }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btn_guardarSalir_Click(object sender, EventArgs e)
        {
            try
            {
                get_Pedido();

                if (Validar())
                {
                    btn_grabar_Click(sender, e);

                    if (estado == true)
                    {

                    }
                    else
                    {
                        this.Close();
                    }

                    estado = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_observacion.Focus();
                get_Pedido();

                //if (Validar())
                //{
                Accion_botton();
                //}


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void set_Pedidos()
        {
            try
            {
                Info_Pedido = new fa_pedido_Info();
                info_bodega = new tb_Bodega_Info();
                info_sucursal = new tb_Sucursal_Info();
                Info_Pedido.CodPedido = obj.CodPedido;
                Info_Pedido.Estado = obj.Estado;
                Info_Pedido.Bodega = obj.Bodega;
                Info_Pedido.Sucursal = obj.Sucursal;
                Info_Pedido.Vendedor = obj.Vendedor;
                Info_Pedido.Cliente = obj.Cliente;
                Info_Pedido.IdPedido = obj.IdPedido;
                Info_Pedido.IdSucursal = obj.IdSucursal;
                Info_Pedido.IdBodega = obj.IdBodega;
                Info_Pedido.IdCliente = obj.IdCliente;
                Info_Pedido.cp_diasPlazo = obj.cp_diasPlazo;
                Info_Pedido.cp_observacion = obj.cp_observacion;
                Info_Pedido.Otro1 = obj.Otro1;
                Info_Pedido.Otro2 = obj.Otro2;
                Info_Pedido.Trasnporte = obj.Trasnporte;
                Info_Pedido.Interes = obj.Interes;
                Info_Pedido.cp_fecha = obj.cp_fecha;
                //txt_pedido.Text = obj.IdPedido;
                txtCodigo.Text = obj.CodPedido;
                txt_pedido.Text = obj.IdPedido.ToString();
                Info_Pedido.IdSucursal = obj.IdSucursal;
                info_sucursal.IdSucursal = obj.IdSucursal;
                Info_Pedido.IdBodega = obj.IdBodega;
                info_bodega.IdSucursal = obj.IdSucursal;
                info_bodega.IdBodega = obj.IdBodega;
                UC_Cliente.cmb_cliente.EditValue = obj.IdCliente;
                UC_Cliente.cmb_vendedor.Text = obj.Vendedor;
                this.UC_Sucursal_Bodega.set_sucursal(info_sucursal);
                this.UC_Sucursal_Bodega.set_bodega(info_bodega);

                Info_Pedido.lista_detalle = obj.lista_detalle;

                dtFecha.Value = obj.cp_fecha;
                dtFechaVenc.Value = obj.cp_fechaVencimiento;
                txt_plazo.Text = obj.cp_diasPlazo.ToString();
                cmbEstadoProduccion.SelectedValue = obj.IdEstadoProduccion;

                //consulta forma pago pedido
                ListaFormaPago = new List<fa_pedido_x_formaPago_Info>();
                ListaFormaPago = Bus_PedidoFormaPago.Get_List_pedido_x_formaPago(param.IdEmpresa, Info_Pedido.IdSucursal, Info_Pedido.IdBodega, Info_Pedido.IdPedido);
                DataSource_PedForPag = new BindingList<fa_pedido_x_formaPago_Info>(ListaFormaPago);
                gridControlFormaPag.DataSource = DataSource_PedForPag;

                string IdTipoFormaPago = "";
                SumValForPag = 0;
                SumPorDist = 0;

                foreach (var item1 in list_TerminoPago)
                {
                    foreach (var item2 in ListaFormaPago)
                    {
                        if (item1.IdTerminoPago == item2.IdTipoFormaPago)
                        {
                            IdTipoFormaPago = item1.IdTerminoPago;

                            SumPorDist = SumPorDist + item2.Por_Distribucion;
                            SumValForPag = SumValForPag + item2.Valor;
                        }
                    }
                }

                txtValForPag.Text = Convert.ToString(SumValForPag);
                txtPorDist.Text = Convert.ToString(SumPorDist);
                //consulta forma pago pedido   

                cmb_estado_aprobacion.SelectedValue = obj.IdEstadoAprobacion;
                txt_observacion.Text = obj.cp_observacion;
                cbxEntrega.Checked = (obj.Entregado == "S") ? true : false;

                foreach (var item in Info_Pedido.lista_detalle)
                {
                    fa_pedido_det_Info tabla_pedido = new fa_pedido_det_Info();
                    //tabla_pedido.Codigo_Producto = item.CodProducto;
                    tabla_pedido.IdProducto = item.IdProducto;
                    tabla_pedido.dp_cantidad = item.dp_cantidad;
                    tabla_pedido.dp_PorDescuento = item.dp_PorDescuento;
                    tabla_pedido.dp_desUni = item.dp_desUni;
                    tabla_pedido.Peso = item.Peso;
                    tabla_pedido.dp_precio = item.dp_precio;
                    tabla_pedido.dp_PrecioFinal = item.dp_PrecioFinal;
                    tabla_pedido.Subtotal = item.dp_subtotal;
                    tabla_pedido.dp_total = item.dp_total;
                    tabla_pedido.dp_iva = item.dp_iva;
                    tabla_pedido.Paga_Iva = (item.dp_pagaIva == "S") ? true : false;
                    tabla_pedido.dp_detallexItems = item.dp_detallexItems;
                    tabla_pedido.Secuencial = item.Secuencial;

                    lista_producto_detalle.Add(tabla_pedido);
                }

                //UCFAModuloFacturacion.set_grid_detalle(lista_producto_detalle);



                txtInteres.EditValue = obj.Interes;
                txtTransporte.EditValue = obj.Trasnporte;
                txtOtro1.EditValue = obj.Otro1;
                txtOtro2.EditValue = obj.Otro2;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void UC_Cliente_Click(object sender, EventArgs e)
        {


        }

        private void UC_Cliente_Event_cmb_cliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //Info_Cliente_Poligrup = Bus_Cliente_Poligrup.Get_Info(param.IdEmpresa, Convert.ToInt32(Convert.ToDecimal(UC_Cliente.cmb_cliente.EditValue)));
                //cmbTerminoPago.EditValue = (Info_Cliente_Poligrup.IdTerminoPago);

                try
                {

                    tabControl2.Enabled = true;
                    xtraTabControl_cuerpo.Enabled = true;

                    var Item = (fa_Cliente_Info)UC_Cliente.searchLookUpEdit1View.GetFocusedRow();

                    //if (Item.cl_Cupo == 0)
                    //{ return; }


                    txt_cupo_maximo.Text = Item.cl_Cupo.ToString();
                    banderaCombo = true;
                    if (Convert.ToDecimal(txtTotal.EditValue) > Convert.ToDecimal(txt_cupo_maximo.Text))
                    {
                        cmb_estado_aprobacion.SelectedValue = "N";
                    }
                    else
                    {
                        cmb_estado_aprobacion.SelectedValue = "A";
                    }

                    cmb_estado_aprobacion.SelectedValue = "N";
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                }
            }

            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Punto_Cargo_Click(object sender, EventArgs e)
        {
            try
            {
                fa_pedido_det_Info row = (fa_pedido_det_Info)gridView_Factura.GetFocusedRow();
                if (row != null)
                {
                    //Info_Pedido_Det
                    if (row.idPunto_cargo_grupo != null)
                    {
                        frmCon_Punto_Cargo_Cons frm_cons = new frmCon_Punto_Cargo_Cons();

                        GridViewInfo info = gridView_Factura.GetViewInfo() as GridViewInfo;
                        GridCellInfo info_cell = info.GetGridCellInfo(rowHandle, ColIdPunto_Cargo);

                        frm_cons.Cargar_grid_x_grupo((int)row.idPunto_cargo_grupo);

                        //frm_cons.Location = new Point(this.Right, gridControlDiario.Top);                        

                        frm_cons.ShowDialog();
                        info_punto_cargo = frm_cons.Get_Info();
                        if (info_punto_cargo != null)
                        {
                            gridView_Factura.SetFocusedRowCellValue(ColIdPunto_Cargo, info_punto_cargo.IdPunto_cargo);
                        }
                        else
                            gridView_Factura.SetFocusedRowCellValue(ColIdPunto_Cargo, null);
                    }
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbTerminoPago_Closed_1(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            {
                try
                {
                    fa_TerminoPago_Info objCmb = (fa_TerminoPago_Info)cmbTerminoPago.Properties.View.GetFocusedRow();
                    ListPagoDistri = BusPagoDistri.Get_List_TerminoPago_Distribucion(objCmb.IdTerminoPago);

                    if (Convert.ToDouble(this.txtTotal.EditValue) == 0)
                    {
                        //MessageBox.Show("Ingrese el valor total de la factura .", "Sistemas");
                        //return;
                    }

                    List = new List<fa_factura_x_fa_TerminoPago_Info>();
                    SumValForPag = 0;
                    SumPorDist = 0;
                    foreach (var item in ListPagoDistri)
                    {
                        fa_factura_x_fa_TerminoPago_Info info = new fa_factura_x_fa_TerminoPago_Info();

                        info.Secuencia = item.Secuencia;
                        info.Por_Distribucion = item.Por_distribucion;
                        DateTime fecha = dtFecha.Value.AddDays(item.Num_Dias_Vcto);
                        info.Fecha_vct = fecha;
                        info.Dias_Plazo = item.Num_Dias_Vcto;
                        info.Valor = Convert.ToDouble(txtTotal.EditValue) * (item.Por_distribucion / 100);
                        info.IdTerminoPago = cmbTerminoPago.EditValue.ToString();

                        SumValForPag = SumValForPag + info.Valor;
                        SumPorDist = SumPorDist + info.Por_Distribucion;

                        List.Add(info);
                    }

                    DataSource_ForPag = new BindingList<fa_factura_x_fa_TerminoPago_Info>(List);
                    gridControlFormaPag.DataSource = DataSource_ForPag;

                    txtValForPag.Text = Convert.ToString(SumValForPag);
                    txtPorDist.Text = Convert.ToString(SumPorDist);
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                }
            }
        }

        private void cmbTerminoPago_calculo(string info)
        {
            {
                try
                {

                    ListPagoDistri = BusPagoDistri.Get_List_TerminoPago_Distribucion(info);

                    if (Convert.ToDouble(this.txtTotal.EditValue) == 0)
                    {
                        //MessageBox.Show("Ingrese el valor total de la factura .", "Sistemas");
                        //return;
                    }

                    List = new List<fa_factura_x_fa_TerminoPago_Info>();
                    SumValForPag = 0;
                    SumPorDist = 0;
                    foreach (var item in ListPagoDistri)
                    {
                        fa_factura_x_fa_TerminoPago_Info infor = new fa_factura_x_fa_TerminoPago_Info();

                        infor.Secuencia = item.Secuencia;
                        infor.Por_Distribucion = item.Por_distribucion;
                        DateTime fecha = dtFecha.Value.AddDays(item.Num_Dias_Vcto);
                        infor.Fecha_vct = fecha;
                        infor.Dias_Plazo = item.Num_Dias_Vcto;
                        infor.Valor = Convert.ToDouble(txtTotal.EditValue) * (item.Por_distribucion / 100);
                        infor.IdTerminoPago = cmbTerminoPago.EditValue.ToString();

                        SumValForPag = SumValForPag + infor.Valor;
                        SumPorDist = SumPorDist + infor.Por_Distribucion;

                        List.Add(infor);
                    }

                    DataSource_ForPag = new BindingList<fa_factura_x_fa_TerminoPago_Info>(List);
                    gridControlFormaPag.DataSource = DataSource_ForPag;

                    txtValForPag.Text = Convert.ToString(SumValForPag);
                    txtPorDist.Text = Convert.ToString(SumPorDist);
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                }
            }
        }

        private void txtTotal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (banderaCombo)
                {
                    if (Convert.ToInt32(txt_cupo_maximo.Text) == 0)
                    {
                    }
                    else
                    {
                        double Total_NoDespachado = 0;
                        var item = listPedidosNoDespachados.FirstOrDefault(r => r.IdCliente == Convert.ToDecimal(UC_Cliente.cmb_cliente.EditValue));

                        if (item == null)
                        {
                            Total_NoDespachado = 0;
                        }
                        else
                        {
                            Total_NoDespachado = item.dp_total;
                        }

                        double Total_Disponible = Convert.ToDouble(txtTotal.EditValue) + Total_NoDespachado;

                        if (Convert.ToDecimal(Total_Disponible) > Convert.ToDecimal(txt_cupo_maximo.Text))
                        {
                            MessageBox.Show("El valor del pedido ha exedido el cupo del Cliente este se guardara en estado de negociacion ");
                            cmb_estado_aprobacion.SelectedValue = "N";
                        }
                        else
                        {
                            cmb_estado_aprobacion.SelectedValue = "A";
                        }
                    }
                    banderaCombo = false;
                }

                fa_TerminoPago_Info objCmb = new fa_TerminoPago_Info();
                objCmb.IdTerminoPago = Convert.ToString(cmbTerminoPago.EditValue);

                ListPagoDistri = BusPagoDistri.Get_List_TerminoPago_Distribucion(objCmb.IdTerminoPago);

                if (Convert.ToDouble(this.txtTotal.EditValue) == 0)
                {
                    //MessageBox.Show("Ingrese .", "Sistemas");
                    //return;
                }

                List = new List<fa_factura_x_fa_TerminoPago_Info>();
                SumValForPag = 0;
                SumPorDist = 0;
                foreach (var item in ListPagoDistri)
                {
                    fa_factura_x_fa_TerminoPago_Info info = new fa_factura_x_fa_TerminoPago_Info();

                    info.Secuencia = item.Secuencia;
                    info.Por_Distribucion = item.Por_distribucion;
                    DateTime fecha = dtFecha.Value.AddDays(item.Num_Dias_Vcto);
                    info.Fecha_vct = fecha;
                    info.Dias_Plazo = item.Num_Dias_Vcto;
                    info.Valor = Convert.ToDouble(txtTotal.EditValue) * (item.Por_distribucion / 100);
                    info.IdTerminoPago = cmbTerminoPago.EditValue.ToString();

                    SumValForPag = SumValForPag + info.Valor;
                    SumPorDist = SumPorDist + info.Por_Distribucion;

                    List.Add(info);
                }

                DataSource_ForPag = new BindingList<fa_factura_x_fa_TerminoPago_Info>(List);
                gridControlFormaPag.DataSource = DataSource_ForPag;

                txtValForPag.Text = Convert.ToString(SumValForPag);
                txtPorDist.Text = Convert.ToString(SumPorDist);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void BtnAnular_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmFa_CausalesdeModificacio_Anulacion ofrm = new frmFa_CausalesdeModificacio_Anulacion();
                ofrm.RetornodelId += ofrm_RetornodelId2;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void UC_Cliente_Load(object sender, EventArgs e)
        {

        }

    }
}