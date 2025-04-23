using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Bizu.Presentation.General;
using Bizu.Presentation.Controles;

using Bizu.Application.Facturacion;
using Bizu.Application.General;
using Bizu.Application.Inventario;
using Bizu.Application.Contabilidad;

using Bizu.Domain.Facturacion;
using Bizu.Domain.General;
using Bizu.Domain.Contabilidad;

using System.Windows;
using DevExpress.Xpf;
using Bizu.Domain.Inventario;
using Bizu.Reports.Inventario;
using System.Net;
using System.IO;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;

namespace Bizu.Presentation.Inventario
{
    public partial class FrmIn_Guia_Remision_Mant : DevExpress.XtraEditors.XtraForm
    {
        //PARAMETROS GENERALES
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action _Accion;

        //BUS
        tb_transportista_Bus Bustransportista = new tb_transportista_Bus();
        ct_Centro_costo_Bus Bus_CentroCosto = new ct_Centro_costo_Bus();
        in_Ing_Egr_Inven_Bus Bus_Ing_Egr = new in_Ing_Egr_Inven_Bus();
        in_GuiaRemision_Det_Bus BusDetalle = new in_GuiaRemision_Det_Bus();
        in_GuiaRemision_Bus Bus = new in_GuiaRemision_Bus();
        in_GuiaRemision_Exportacion_Bus Bus_GuiaRemision_Exportacion = new in_GuiaRemision_Exportacion_Bus();
        in_producto_Bus Bus_Producto = new in_producto_Bus();
        in_UnidadMedida_Bus Bus_UnidadMedida = new in_UnidadMedida_Bus();
        in_Ing_Egr_Inven_x_in_GuiaRemision_Bus Bus_Inv_x_GuiaRemision = new in_Ing_Egr_Inven_x_in_GuiaRemision_Bus();
        fa_cliente_Obra_Bus Bus_Cliente_Obra = new fa_cliente_Obra_Bus();
        in_Parametro_Bus Bus_Param_Inv = new in_Parametro_Bus();

        //INFO
        in_Ing_Egr_Inven_x_in_GuiaRemision_Info Info_Inv_x_GuiaRemision = new in_Ing_Egr_Inven_x_in_GuiaRemision_Info();
        in_GuiaRemision_Info Info_GuiaRemision = new in_GuiaRemision_Info();
        fa_cliente_Obra_Info Info_Cliente_Obra = new fa_cliente_Obra_Info();
        in_Parametro_Info info_parametros = new in_Parametro_Info();
        private in_Producto_Info Info_Producto_Selected_View;

        //LISTAS
        List<ct_Centro_costo_Info> List_CentroCosto = new List<ct_Centro_costo_Info>();
        List<in_UnidadMedida_Info> List_UnidadMedida = new List<in_UnidadMedida_Info>();
        List<in_Producto_Info> listProducto = new List<in_Producto_Info>();
        List<in_GuiaRemision_Det_Info> List_GuiaRemision = new List<in_GuiaRemision_Det_Info>();
        List<tb_transportista_Info> LisTransportista = new List<tb_transportista_Info>();
        BindingList<in_GuiaRemision_Det_Info> BindingList_GuiaRemision = new BindingList<in_GuiaRemision_Det_Info>();

        public delegate void Delegate_frmIn_Guia_Remision_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_frmIn_Guia_Remision_Mant_FormClosing Event_frmIn_Guia_Remision_Mant_FormClosing;

        public FrmIn_Guia_Remision_Mant()
        {
            try
            {
                InitializeComponent();

                Event_frmIn_Guia_Remision_Mant_FormClosing += frmIn_Guia_Remision_Mant_Event_frmIn_Guia_Remision_Mant_FormClosing;

                ucGe_Menu_Superior_Mant.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant_event_btnGuardar_y_Salir_Click;
                ucGe_Menu_Superior_Mant.event_btnGuardar_Click += ucGe_Menu_Superior_Mant_event_btnGuardar_Click;
                ucGe_Menu_Superior_Mant.event_btnAnular_Click += ucGe_Menu_Superior_Mant_event_btnAnular_Click;
                ucGe_Menu_Superior_Mant.event_btnImprimir_Click += ucGe_Menu_Superior_Mant_event_btnImprimir_Click;
                ucGe_Menu_Superior_Mant.event_btnSalir_Click += ucGe_Menu_Superior_Mant_event_btnSalir_Click;
                ucGe_Menu_Superior_Mant.event_btn_Generar_XML_Click += ucGe_Menu_Superior_Mant_event_btn_Generar_XML_Click;

                ucGe_Sucursal_Bodega_Origen.Event_cmb_sucursal1_EditValueChanged += ucGe_Sucursal_Event_cmb_sucursal1_EditValueChanged;
                ucGe_Sucursal_Bodega_Origen.Event_cmb_bodega1_EditValueChanged += ucGe_Sucursal_Event_cmb_bodega1_EditValueChanged;
                ucGe_Beneficiario.event_cmb_beneficiario_EditValueChanged += ucGe_Beneficiario_event_cmb_beneficiario_EditValueChanged;

                gridView_Producto.RowClick += gridView_Producto_RowClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void gridView_Producto_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Info_Producto_Selected_View = (sender as DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedRow() as in_Producto_Info;
        }

        void ucGe_Sucursal_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //if (ucGe_Sucursal.get_bodega() != null)
                //    cmbTipoMovi.cargar_TipoMotivo(ucGe_Sucursal.get_IdSucursal(), ucGe_Sucursal.get_IdBodega(), "-", "");
                //else
                //    cmbTipoMovi.Inicializar_Catalogos();

                cargarNumDoc();
                CargarProducto();

                BindingList_GuiaRemision = new BindingList<in_GuiaRemision_Det_Info>();
                gridControlGuia.DataSource = BindingList_GuiaRemision;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CargarProducto()
        {
            try
            {
                listProducto = new List<in_Producto_Info>();

                if (ucGe_Sucursal_Bodega_Origen.cmb_bodega.EditValue != null && ucGe_Sucursal_Bodega_Origen.cmb_sucursal.EditValue != null)
                {
                    ucGe_Sucursal_Bodega_Origen.cmb_sucursal.EditValue = (ucGe_Sucursal_Bodega_Origen.cmb_sucursal.EditValue == "") ? 0 : ucGe_Sucursal_Bodega_Origen.cmb_sucursal.EditValue;
                    ucGe_Sucursal_Bodega_Origen.cmb_bodega.EditValue = (ucGe_Sucursal_Bodega_Origen.cmb_bodega.EditValue == "") ? 0 : ucGe_Sucursal_Bodega_Origen.cmb_bodega.EditValue;

                    if (Convert.ToBoolean(this.info_parametros.P_Maneja_Lote))
                    {
                        listProducto = Bus_Producto.Get_list_Producto_modulo_x_inventario_Lote(param.IdEmpresa, Convert.ToInt32(ucGe_Sucursal_Bodega_Origen.cmb_sucursal.EditValue), Convert.ToInt32(ucGe_Sucursal_Bodega_Origen.cmb_bodega.EditValue));
                    }
                    else
                    {
                        listProducto = Bus_Producto.Get_list_Producto_modulo_x_inventario(param.IdEmpresa, Convert.ToInt32(ucGe_Sucursal_Bodega_Origen.cmb_sucursal.EditValue), Convert.ToInt32(ucGe_Sucursal_Bodega_Origen.cmb_bodega.EditValue));
                    }
                }

                cmbProducto_grid.DataSource = listProducto;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Sucursal_Event_cmb_sucursal1_EditValueChanged(object sender, EventArgs e)
        {

        }

        void ucGe_Beneficiario_event_cmb_beneficiario_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucGe_Beneficiario.Get_Persona_beneficiario_Info() != null)
                {
                    vwtb_persona_beneficiario_Info Info_persona_beneficiario = ucGe_Beneficiario.Get_Persona_beneficiario_Info();

                    if (Info_persona_beneficiario != null)
                    {                      
                        string MensajeError = "";
                        List_CentroCosto = Bus_CentroCosto.Get_list_Centro_Costo(param.IdEmpresa, ref MensajeError);

                        List<ct_Centro_costo_Info> List_CentroCosto_tmp = new List<ct_Centro_costo_Info>();

                        if (Info_persona_beneficiario.IdTipo_Persona == Cl_Enumeradores.eTipoPersona.CLIENTE.ToString())
                        {                            
                            cmb_CentroCosto.DataSource = List_CentroCosto_tmp;
                            cmb_centro_costo.Properties.DataSource = List_CentroCosto_tmp;
                        }
                        else
                        {                           
                            cmb_CentroCosto.DataSource = List_CentroCosto_tmp;
                            cmb_centro_costo.Properties.DataSource = List_CentroCosto_tmp;


                            tb_persona_bus Bus_Persona = new tb_persona_bus();
                            tb_persona_Info Info_Persona = new tb_persona_Info();

                            Info_Persona = Bus_Persona.Get_Info_Persona(Info_persona_beneficiario.IdPersona);

                            txtDestinoCarga.Text = Info_Persona.pe_direccion;
                            txtMailPrincipal.Text = Info_Persona.pe_correo;
                        }

                        cmb_centro_costo.EditValue = null;
                    }
                }

                set_datos_exportacion();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Superior_Mant_event_btn_Generar_XML_Click(object sender, EventArgs e)
        {
            Generar_Xml();
        }

        void frmIn_Guia_Remision_Mant_Event_frmIn_Guia_Remision_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        void ucGe_Menu_Superior_Mant_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ucGe_Menu_Superior_Mant_event_btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        void ucGe_Menu_Superior_Mant_event_btnAnular_Click(object sender, EventArgs e)
        {
            Anular();
        }

        void ucGe_Menu_Superior_Mant_event_btnGuardar_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        void ucGe_Menu_Superior_Mant_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void cargar_combo()
        {
            try
            {
                string MensajeError = "";

                LisTransportista = Bustransportista.Get_List_transportista(param.IdEmpresa);
                cmb_Transportista.Properties.DataSource = LisTransportista;
                cmb_Transportista.Properties.DisplayMember = "Nombre";
                cmb_Transportista.Properties.ValueMember = "IdTransportista";

                List_UnidadMedida = Bus_UnidadMedida.Get_list_UnidadMedida();
                cmb_UnidadMedida.DataSource = List_UnidadMedida;

                in_Catalogo_Bus Bus_Catalogo = new in_Catalogo_Bus();
                List<in_Catalogo_Info> List_Catalogo = Bus_Catalogo.Get_List_Catalogo(9);

                cmb_EmbarqueTipo.DataSource = List_Catalogo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void cargarNumDoc()
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    UCNumDoc.IdTipoDocumento = Cl_Enumeradores.eTipoDocumento_Talonario.GUIA;

                    tb_Sucursal_Info Info_Sucursal = new tb_Sucursal_Info();

                    if (ucGe_Sucursal_Bodega_Origen.get_sucursal() != null && ucGe_Sucursal_Bodega_Origen.get_bodega() != null)
                    {
                        UCNumDoc.IdEstablecimiento = ucGe_Sucursal_Bodega_Origen.get_sucursal().Su_CodigoEstablecimiento;
                        UCNumDoc.IdPuntoEmision = ucGe_Sucursal_Bodega_Origen.get_bodega().cod_punto_emision;
                        UCNumDoc.Get_Primer_Documento_no_usado();
                    }
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

        private void frmIn_Guia_Remision_Mant_Load(object sender, EventArgs e)
        {
            try
            {                
                info_parametros = Bus_Param_Inv.Get_Info_Parametro(param.IdEmpresa);

                cargar_combo();
                cargarNumDoc();

                ucGe_Sucursal_Bodega_Origen.cmb_sucursal.EditValue = param.IdSucursal;
                txtOrigenCarga.Text = param.InfoSucursal.Su_Direccion;

                BindingList_GuiaRemision = new BindingList<in_GuiaRemision_Det_Info>();
                gridControlGuia.DataSource = BindingList_GuiaRemision;

                ucGe_Beneficiario.set_Persona_beneficiario_Info(Cl_Enumeradores.eTipoPersona.CLIENTE, 0);

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant.Visible_bntImprimir = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu_Superior_Mant.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu_Superior_Mant.Visible_btn_Generar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Never;
                        UCNumDoc.Set_Perfil_solo_lectura(true);
                        Set_Action_In_Control();
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Never;
                        UCNumDoc.Set_Perfil_solo_lectura(true);
                        Set_Action_In_Control();
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Never;
                        ucGe_Menu_Superior_Mant.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Never;
                        UCNumDoc.Set_Perfil_solo_lectura(true);
                        Set_Action_In_Control();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Set_Info(in_GuiaRemision_Info _Info_GuiaRemision)
        {
            this.Info_GuiaRemision = _Info_GuiaRemision;
        }

        public void Set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            this._Accion = iAccion;
        }

        public void Get()
        {
            try
            {
                Info_GuiaRemision = new in_GuiaRemision_Info();
                Info_GuiaRemision.IdEmpresa = param.IdEmpresa;
                Info_GuiaRemision.IdSucursal = Convert.ToInt16(ucGe_Sucursal_Bodega_Origen.cmb_sucursal.EditValue);
                Info_GuiaRemision.IdGuiaRemision = Convert.ToDecimal(txt_IdGuiaRemision.EditValue);
                if (ucGe_Sucursal_Bodega_Origen.cmb_bodega.EditValue != null)
                {
                    if (Convert.ToString(ucGe_Sucursal_Bodega_Origen.cmb_bodega.EditValue) != "")
                    {
                        Info_GuiaRemision.IdBodega = Convert.ToInt32(ucGe_Sucursal_Bodega_Origen.cmb_bodega.EditValue);
                    }
                }
                Info_GuiaRemision.FechaEmision = dtpFechaEmision.Value;
                Info_GuiaRemision.FechaTrasladoIni = dtpFecIniTrasl.Value;
                Info_GuiaRemision.FechaTrasladoFin = dtpFecFinTrasl.Value;

                tb_sis_Documento_Tipo_Talonario_Info Talonario = UCNumDoc.Get_Info_Talonario();

                if (Talonario != null)
                {
                    Info_GuiaRemision.Serie1 = Talonario.Establecimiento.Trim();
                    Info_GuiaRemision.Serie2 = Talonario.PuntoEmision.Trim();
                    Info_GuiaRemision.NumDocumento = Talonario.NumDocumento.Trim();
                }

                Info_GuiaRemision.IdTipo_Persona = ucGe_Beneficiario.Get_Persona_beneficiario_Info().IdTipo_Persona;
                Info_GuiaRemision.IdEntidad = ucGe_Beneficiario.Get_Persona_beneficiario_Info().IdEntidad;                

                if (cmb_centro_costo.EditValue != null)
                    Info_GuiaRemision.IdCentroCosto = Convert.ToString(cmb_centro_costo.EditValue);
                else
                    Info_GuiaRemision.IdCentroCosto = null;

                Info_GuiaRemision.Origen = txtOrigenCarga.Text.Trim();
                Info_GuiaRemision.Destino = txtDestinoCarga.Text.Trim();
                Info_GuiaRemision.Observacion = txtObservacion.Text.Trim();
                Info_GuiaRemision.IdMotivo = Convert.ToInt32(ucIn_Motivo_GuiaRemision_cmb.cmb_motivo.EditValue);
                Info_GuiaRemision.IdEstado_cierre = "ABI";
                Info_GuiaRemision.Estado = "A";
                Info_GuiaRemision.IdUsuarioCreacion = param.IdUsuario;
                Info_GuiaRemision.FechaCreacion = DateTime.Now;
                //Info_GuiaRemision.IdUsuarioModificacion;
                //Info_GuiaRemision.FechaModificacion;
                //Info_GuiaRemision.IdUsuarioAnulacion;
                //Info_GuiaRemision.FechaAnulacion;
                //Info_GuiaRemision.MotivoAnulacion;
                //Info_GuiaRemision.FechaAutorizacion;
                //Info_GuiaRemision.NumAutorizacion;
                Info_GuiaRemision.IdTransportista = Convert.ToInt32(cmb_Transportista.EditValue);
                Info_GuiaRemision.Placa = txtNumPlaca.Text.Trim();
                Info_GuiaRemision.Ruta = txt_rutaTraslado.Text.Trim();
                Info_GuiaRemision.Correo = txtMailPrincipal.Text;

                Info_GuiaRemision.in_GuiaRemision_Det = new List<in_GuiaRemision_Det_Info>(BindingList_GuiaRemision);

                if (chk_exportacion.Checked)
                {
                    Info_GuiaRemision.in_GuiaRemision_Exportacion = new in_GuiaRemision_Exportacion_Info();
                    Info_GuiaRemision.in_GuiaRemision_Exportacion.IdEmpresa = Info_GuiaRemision.IdEmpresa;
                    Info_GuiaRemision.in_GuiaRemision_Exportacion.IdSucursal = Info_GuiaRemision.IdSucursal;
                    Info_GuiaRemision.in_GuiaRemision_Exportacion.IdGuiaRemision = Info_GuiaRemision.IdGuiaRemision;
                    Info_GuiaRemision.in_GuiaRemision_Exportacion.EmbarqueTipo = cmb_EmbarqueTipo.Text;
                    Info_GuiaRemision.in_GuiaRemision_Exportacion.Ruta = Convert.ToString(txt_ruta_embarque.EditValue);
                    Info_GuiaRemision.in_GuiaRemision_Exportacion.Contenedor = Convert.ToString(txt_contenedor.EditValue);
                    Info_GuiaRemision.in_GuiaRemision_Exportacion.Sello = Convert.ToString(txt_sello.EditValue);
                    Info_GuiaRemision.in_GuiaRemision_Exportacion.Vapor = Convert.ToString(txt_vapor.EditValue);
                    Info_GuiaRemision.in_GuiaRemision_Exportacion.Embalaje = Convert.ToString(txt_embalaje.EditValue);
                    Info_GuiaRemision.in_GuiaRemision_Exportacion.PesoNeto = Convert.ToDouble(txt_pesoNeto.EditValue);
                    Info_GuiaRemision.in_GuiaRemision_Exportacion.PesoBruto = Convert.ToDouble(txt_pesoBruto.EditValue);
                    Info_GuiaRemision.in_GuiaRemision_Exportacion.Exportador_nombre = Convert.ToString(txt_exp_nombre_exportador.EditValue);
                    Info_GuiaRemision.in_GuiaRemision_Exportacion.Exportador_direccion = Convert.ToString(txt_exp_direccion_exportador.EditValue);
                    Info_GuiaRemision.in_GuiaRemision_Exportacion.Exportador_correo = Convert.ToString(txt_exp_correo_exportador.EditValue);
                    Info_GuiaRemision.in_GuiaRemision_Exportacion.Exportador_telefono = Convert.ToString(txt_exp_telefono_exportador.EditValue);
                    Info_GuiaRemision.in_GuiaRemision_Exportacion.Exportador_fax = Convert.ToString(txt_exp_fax_exportador.EditValue);
                    Info_GuiaRemision.in_GuiaRemision_Exportacion.Comprador_nombre = Convert.ToString(txt_exp_nombre_comprador.EditValue);
                    Info_GuiaRemision.in_GuiaRemision_Exportacion.Comprador_direccion = Convert.ToString(txt_direccion_exp_comprador.EditValue);
                    Info_GuiaRemision.in_GuiaRemision_Exportacion.Comprador_correo = Convert.ToString(txt_correo_exp_comprador.EditValue);
                    Info_GuiaRemision.in_GuiaRemision_Exportacion.Comprador_telefono = Convert.ToString(txt_telefono_exp_comprador.EditValue);
                    Info_GuiaRemision.in_GuiaRemision_Exportacion.Comprador_fax = Convert.ToString(txt_fax_exp_comprador.EditValue);
                }              
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Set_Action_In_Control()
        {
            try
            {
                txt_IdGuiaRemision.EditValue = Info_GuiaRemision.IdGuiaRemision;
                ucGe_Sucursal_Bodega_Origen.cmb_sucursal.EditValue = Info_GuiaRemision.IdSucursal;
                ucGe_Sucursal_Bodega_Origen.cmb_bodega.EditValue = Info_GuiaRemision.IdBodega;
                dtpFechaEmision.Value = Info_GuiaRemision.FechaEmision;
                dtpFecIniTrasl.Value = Info_GuiaRemision.FechaTrasladoIni;
                dtpFecFinTrasl.Value = Info_GuiaRemision.FechaTrasladoFin;
                cmb_Transportista.EditValue = Info_GuiaRemision.IdTransportista;
                txtObservacion.Text = Info_GuiaRemision.Observacion;
                txtNumPlaca.Text = Info_GuiaRemision.Placa;

                Cl_Enumeradores.eTipoPersona TipoPersona = (Cl_Enumeradores.eTipoPersona)Enum.Parse(typeof(Cl_Enumeradores.eTipoPersona), Info_GuiaRemision.IdTipo_Persona);

                ucGe_Beneficiario.set_Persona_beneficiario_Info(TipoPersona, Info_GuiaRemision.IdEntidad);
                txtOrigenCarga.Text = Info_GuiaRemision.Origen;
                txtDestinoCarga.Text = Info_GuiaRemision.Destino;
                cmb_centro_costo.EditValue = Info_GuiaRemision.IdCentroCosto;
                txt_rutaTraslado.Text = Info_GuiaRemision.Ruta;
                UCNumDoc.Set_Serie_Num_Documento(Info_GuiaRemision.Serie1, Info_GuiaRemision.Serie2, Info_GuiaRemision.NumDocumento);
                ucIn_Motivo_GuiaRemision_cmb.cmb_motivo.EditValue = Info_GuiaRemision.IdMotivo;
                List_GuiaRemision = BusDetalle.Get_List(Info_GuiaRemision.IdEmpresa, Info_GuiaRemision.IdSucursal, Info_GuiaRemision.IdGuiaRemision);

                if (Info_GuiaRemision.Estado == "A")
                {
                    lblAnulado.Visible = false;
                }
                else
                {
                    if (Info_GuiaRemision.Estado == "I")
                    {
                        lblAnulado.Visible = true;
                    }
                }

                txtMailPrincipal.Text = Info_GuiaRemision.Correo;

                BindingList_GuiaRemision = new BindingList<in_GuiaRemision_Det_Info>(List_GuiaRemision);
                gridControlGuia.DataSource = BindingList_GuiaRemision;

                Info_GuiaRemision.in_GuiaRemision_Exportacion = Bus_GuiaRemision_Exportacion.Get_Info(Info_GuiaRemision.IdEmpresa, Info_GuiaRemision.IdSucursal, Info_GuiaRemision.IdGuiaRemision);

                if (Info_GuiaRemision.in_GuiaRemision_Exportacion != null)
                {
                    chk_exportacion.Checked = true;

                    cmb_EmbarqueTipo.Text = Info_GuiaRemision.in_GuiaRemision_Exportacion.EmbarqueTipo;
                    txt_ruta_embarque.EditValue = Info_GuiaRemision.in_GuiaRemision_Exportacion.Ruta;
                    txt_contenedor.EditValue = Info_GuiaRemision.in_GuiaRemision_Exportacion.Contenedor;
                    txt_sello.EditValue = Info_GuiaRemision.in_GuiaRemision_Exportacion.Sello;
                    txt_vapor.EditValue = Info_GuiaRemision.in_GuiaRemision_Exportacion.Vapor;
                    txt_embalaje.EditValue = Info_GuiaRemision.in_GuiaRemision_Exportacion.Embalaje;
                    txt_pesoNeto.EditValue = Info_GuiaRemision.in_GuiaRemision_Exportacion.PesoNeto;
                    txt_pesoBruto.EditValue = Info_GuiaRemision.in_GuiaRemision_Exportacion.PesoBruto;
                    txt_exp_nombre_exportador.EditValue = Info_GuiaRemision.in_GuiaRemision_Exportacion.Exportador_nombre;
                    txt_exp_direccion_exportador.EditValue = Info_GuiaRemision.in_GuiaRemision_Exportacion.Exportador_direccion;
                    txt_exp_correo_exportador.EditValue = Info_GuiaRemision.in_GuiaRemision_Exportacion.Exportador_correo;
                    txt_exp_telefono_exportador.EditValue = Info_GuiaRemision.in_GuiaRemision_Exportacion.Exportador_telefono;
                    txt_exp_fax_exportador.EditValue = Info_GuiaRemision.in_GuiaRemision_Exportacion.Exportador_fax;
                    txt_exp_nombre_comprador.EditValue = Info_GuiaRemision.in_GuiaRemision_Exportacion.Comprador_nombre;
                    txt_direccion_exp_comprador.EditValue = Info_GuiaRemision.in_GuiaRemision_Exportacion.Comprador_direccion;
                    txt_correo_exp_comprador.EditValue = Info_GuiaRemision.in_GuiaRemision_Exportacion.Comprador_correo;
                    txt_telefono_exp_comprador.EditValue = Info_GuiaRemision.in_GuiaRemision_Exportacion.Comprador_telefono;
                    txt_fax_exp_comprador.EditValue = Info_GuiaRemision.in_GuiaRemision_Exportacion.Comprador_fax;
                }
                else
                {
                    chk_exportacion.Checked = false;
                }

                Info_Inv_x_GuiaRemision = Bus_Inv_x_GuiaRemision.Get(Info_GuiaRemision.IdEmpresa, Info_GuiaRemision.IdSucursal, Info_GuiaRemision.IdGuiaRemision);

                if (Info_Inv_x_GuiaRemision != null)
                {
                    btnEgr.EditValue = Info_Inv_x_GuiaRemision.IdNumMovi;
                }              
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public Boolean Validar()
        {
            try
            {
                if (Convert.ToDecimal(ucGe_Sucursal_Bodega_Origen.cmb_sucursal.EditValue) == 0 || ucGe_Sucursal_Bodega_Origen.cmb_sucursal.EditValue == null)
                {
                    MessageBox.Show("Por Favor ingrese la sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucGe_Sucursal_Bodega_Origen.cmb_sucursal.Focus();
                    return false;
                }

                if (dtpFecFinTrasl.Value.Date < dtpFecIniTrasl.Value.Date)
                {
                    MessageBox.Show("La fecha de Finalización del Traslado no pude ser menor a la fecha Inicial del Traslado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtpFecFinTrasl.Focus();
                    return false;
                }

                if (dtpFecIniTrasl.Value.Date < dtpFechaEmision.Value.Date)
                {
                    MessageBox.Show("La fecha de Inicio del Traslado no pude ser menor a la fecha de Emisión", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtpFecIniTrasl.Focus();
                    return false;
                }

                if (this.ucGe_Beneficiario.Get_Persona_beneficiario_Info() == null)
                {
                    MessageBox.Show("Ingrese el Destinatario ", "Sistemas");
                    ucGe_Beneficiario.Focus();
                    return false;
                }

                if (this.txtMailPrincipal.Text == null)
                {
                    MessageBox.Show("Ingrese correo del Destinatario ", "Sistemas");
                    txtMailPrincipal.Focus();
                    return false;
                }

                if (ucIn_Motivo_GuiaRemision_cmb.cmb_motivo.EditValue == null)
                {
                    MessageBox.Show("Por Favor ingrese el motivo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucIn_Motivo_GuiaRemision_cmb.cmb_motivo.Focus();
                    return false;
                }

                if (txtOrigenCarga.Text == "")
                {
                    MessageBox.Show("Por Favor ingrese el origen de la carga", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtOrigenCarga.Focus();
                    return false;
                }

                if (txtDestinoCarga.Text == "")
                {
                    MessageBox.Show("Por Favor ingrese el destino de la carga", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDestinoCarga.Focus();
                    return false;
                }

                if (cmb_Transportista.EditValue == null)
                {
                    MessageBox.Show("Por Favor ingrese el transportista", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb_Transportista.Focus();
                    return false;
                }

                if (txtNumPlaca.Text == "")
                {
                    MessageBox.Show("No se ha registrado Placa", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNumPlaca.Focus();
                    return false;
                }

                if (txt_rutaTraslado.Text == "")
                {
                    MessageBox.Show("Ingrese la ruta del traslado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_rutaTraslado.Focus();
                    return false;
                }

                if (BindingList_GuiaRemision.Count() == 0 || BindingList_GuiaRemision == null)
                {
                    MessageBox.Show("Por Favor ingrese información de la guía", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (UCNumDoc.Get_Info_Talonario().NumDocumento == "")
                {
                    MessageBox.Show("Por Favor ingrese secuencia de la Guía", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UCNumDoc.Focus();
                    return false;
                }

                tb_sis_Documento_Tipo_Talonario_Info Talonario = UCNumDoc.Get_Info_Talonario();

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (Talonario != null)
                    {
                        Info_GuiaRemision.Serie1 = Talonario.PuntoEmision.Trim();
                        Info_GuiaRemision.Serie2 = Talonario.Establecimiento.Trim();
                        Info_GuiaRemision.NumDocumento = Talonario.NumDocumento.Trim();

                        if (!UCNumDoc.existe_numRetencion())
                        {
                            MessageBox.Show("La numeración de la Guía ya se encuentra registrada!!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado el secuencial de la Guía!!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                foreach (var item in BindingList_GuiaRemision)
                {
                    if (item.IdProducto == null)
                    {
                        MessageBox.Show("Por Favor ingrese Producto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (Convert.ToDecimal(item.IdProducto) == 0)
                    {
                        MessageBox.Show("Por Favor ingrese Id del producto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (item.Codigo == "")
                    {
                        MessageBox.Show("Por Favor ingrese código del producto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (item.Descripcion == "")
                    {
                        MessageBox.Show("Por Favor ingrese descripción del producto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (item.Cantidad_sinConversion == null)
                    {
                        MessageBox.Show("Cantidad Sin Conversion no puede ser vacio", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (item.Cantidad_sinConversion == 0)
                    {
                        MessageBox.Show("Cantidad Sin Conversion no puede ser igual a cero", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (item.IdUnidadMedida == null)
                    {
                        MessageBox.Show("Ingrese la unidad de medida", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (esMateriaPrima(Convert.ToDecimal(item.IdProducto)))
                    {
                        MessageBox.Show("No se puede realizar Guía de Rimision para producto con parametrización de Materia Prima, consulte con Dep. Contabilidad nuevo proceso", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (info_parametros.Mostrar_CentroCosto_en_transacciones == "S")
                    {
                        if (item.IdCentroCosto == null)
                        {
                            MessageBox.Show("Ingrese el centro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                }
                              
                tb_Bodega_Info info_Bodega = new tb_Bodega_Info();
                info_Bodega = ucGe_Sucursal_Bodega_Origen.get_bodega();

                if (MessageBox.Show("¿Está seguro que desea generar el egreso por Guía de Remisión a la bodega [" + info_Bodega.IdBodega + "] " + info_Bodega.bo_Descripcion + "?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return false;
                }

                string mensaje = "";

                //EJEMPLO DE AGRUPAR
                var select_ = from T in BindingList_GuiaRemision
                              group T by new
                              {
                                  T.IdEmpresa,
                                  T.IdSucursal,
                                  T.IdProducto,
                                  T.Peso
                              }
                                  into grouping
                              select new { grouping.Key, CantidadTotal = grouping.Sum(q => q.Cantidad), CantidadTotal_SinConversion = grouping.Sum(p => p.Cantidad_sinConversion) };

                foreach (var item in select_)
                {
                    bool esValido = Bus.Validar_Stock(param.IdEmpresa, Convert.ToInt16(ucGe_Sucursal_Bodega_Origen.cmb_sucursal.EditValue), Convert.ToInt16(ucGe_Sucursal_Bodega_Origen.cmb_bodega.EditValue), Convert.ToDecimal(item.Key.IdProducto), Convert.ToDateTime(dtpFechaEmision.Value).Date, Convert.ToDouble(item.CantidadTotal_SinConversion), ref mensaje);

                    if (!esValido)
                    {
                        MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
                
                //EXPORTACION
                #region exportacion
                if (chk_exportacion.Checked)
                {
                    if (string.IsNullOrEmpty(cmb_EmbarqueTipo.Text))
                    {
                        MessageBox.Show("Seleccione el Tipo de Embarque!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cmb_EmbarqueTipo.Focus();
                        return false;
                    }

                    if (txt_ruta_embarque.EditValue == null)
                    {
                        MessageBox.Show("Ingrese la Ruta!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_ruta_embarque.Focus();
                        return false;
                    }

                    if (txt_contenedor.EditValue == null)
                    {
                        MessageBox.Show("Ingrese Contenedor!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_contenedor.Focus();
                        return false;
                    }

                    if (txt_sello.EditValue == null)
                    {
                        MessageBox.Show("Ingrese Sello!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_sello.Focus();
                        return false;
                    }

                    if (txt_vapor.EditValue == null)
                    {
                        MessageBox.Show("Ingrese Vapor!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_vapor.Focus();
                        return false;
                    }

                    if (Convert.ToDecimal(txt_pesoNeto.EditValue) == 0)
                    {
                        MessageBox.Show("Ingrese Peso Neto!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_pesoNeto.Focus();
                        return false;
                    }

                    if (Convert.ToDecimal(txt_pesoBruto.EditValue) == 0)
                    {
                        MessageBox.Show("Ingrese Peso Bruto!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_pesoBruto.Focus();
                        return false;
                    }
                }
                #endregion

                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private Boolean esMateriaPrima(decimal IdProducto)
        {
            try
            {
                in_Producto_Info Info_Producto = Bus_Producto.Get_info_Producto(param.IdEmpresa, IdProducto);

                if (Info_Producto.IdCategoria == "1") // MATERIA PRIMA
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private void frmIn_Guia_Remision_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmIn_Guia_Remision_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewGuia_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                in_GuiaRemision_Det_Info Info_Det = gridViewGuia.GetFocusedRow() as in_GuiaRemision_Det_Info;

                if (e.Column == colIdProducto)
                {                    
                    if (Info_Producto_Selected_View != null)
                    {
                        gridViewGuia.SetFocusedRowCellValue(colCodigo, Info_Producto_Selected_View.pr_codigo);
                        gridViewGuia.SetFocusedRowCellValue(colDescripcion, Info_Producto_Selected_View.pr_descripcion);
                        gridViewGuia.SetFocusedRowCellValue(colIdUnidadMedida, Info_Producto_Selected_View.IdUnidadMedida);
                        gridViewGuia.SetFocusedRowCellValue(colPesoUnit, Info_Producto_Selected_View.PesoEspecifico);
                        gridViewGuia.SetFocusedRowCellValue(colIdUnidadMedida_sinConversion, Info_Producto_Selected_View.IdUnidadMedida_Consumo);
                        gridViewGuia.SetFocusedRowCellValue(colIdCategoria, Info_Producto_Selected_View.IdCategoria);

                        if (Convert.ToBoolean(info_parametros.P_Maneja_Lote) && Bus_Producto.Producto_maneja_lote(param.IdEmpresa, Convert.ToDecimal(Info_Det.IdProducto)))
                            Info_Det.Lote = Info_Producto_Selected_View.Lote;
                        else
                            Info_Det.Lote = null;
                    }
                    else
                    {
                        gridViewGuia.SetFocusedRowCellValue(colCodigo, null);
                        gridViewGuia.SetFocusedRowCellValue(colDescripcion, null);
                        gridViewGuia.SetFocusedRowCellValue(colIdUnidadMedida, null);
                        gridViewGuia.SetFocusedRowCellValue(colPesoUnit, 0);
                        gridViewGuia.SetFocusedRowCellValue(colIdUnidadMedida_sinConversion, null);
                        gridViewGuia.SetFocusedRowCellValue(colIdCategoria, null);
                    }
                }
                
                if (e.Column == colCantidad_sinConversion)
                {
                    if (info_parametros.Maneja_Stock_Negativo == "N")
                    {
                        if (Info_Det.IdProducto > 0)
                        {
                            in_Producto_Info ItemProd_Busc = new in_Producto_Info();

                            if (Convert.ToBoolean(info_parametros.P_Maneja_Lote) && Bus_Producto.Producto_maneja_lote(param.IdEmpresa, Convert.ToDecimal(Info_Det.IdProducto)))
                                ItemProd_Busc = listProducto.FirstOrDefault(p => p.IdProducto == Info_Det.IdProducto && p.Lote == Info_Det.Lote);
                            else
                                ItemProd_Busc = listProducto.FirstOrDefault(p => p.IdProducto == Info_Det.IdProducto);

                            if (Info_Det.Cantidad_sinConversion > ItemProd_Busc.pr_stock)
                            {
                                MessageBox.Show("La cantidad Supera Al Stock");
                                Info_Det.Cantidad_sinConversion = Convert.ToDouble(ItemProd_Busc.pr_stock);
                            }

                            if (Info_Det.Cantidad_sinConversion < 0) Info_Det.Cantidad_sinConversion = Info_Det.Cantidad_sinConversion * -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewGuia_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void ReporteDocumento()
        {
            try
            {
                Get();
                fa_rpt_guia_remision_Info InfoReport = new fa_rpt_guia_remision_Info();
                List<fa_rpt_guia_remision_Info> lstReport = new List<fa_rpt_guia_remision_Info>();
                List<fa_guia_remision_det_Info> lsttmp = new List<fa_guia_remision_det_Info>();
                //lsttmp = BusDetalle.Get_List_guia_remision_det(_Info.IdEmpresa, _Info.IdSucursal, _Info.IdBodega, _Info.IdGuiaRemision);
                //lsttmp.ForEach(var => var.pr_descripcion = BusProduCto.Get_Descripcion_Producto(param.IdEmpresa, var.IdProducto));
                //_Info.ListaDetalle = lsttmp;
                //InfoReport.Info = _Info;
                //InfoReport.ListaDetalle = _Info.ListaDetalle;
                //InfoReport.empresainfo = param.InfoEmpresa;
                //lstReport.Add(InfoReport);
                //if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                //{
                //    _Info = new fa_guia_remision_Info();
                //    _Info.Estado = "A";
                //}
                //else
                //{
                //    _Info.Estado = SetInfo.Estado;
                //}
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void Imprimir()
        {
            try
            {
                if (chk_exportacion.Checked)
                {
                    XINV_Rpt041_Rpt Reporte = new XINV_Rpt041_Rpt();
                    Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                    Reporte.Parameters["IdSucursal"].Value = Convert.ToInt32(ucGe_Sucursal_Bodega_Origen.cmb_sucursal.EditValue);
                    Reporte.Parameters["IdGuiaRemision"].Value = Convert.ToDecimal(txt_IdGuiaRemision.EditValue);

                    Reporte.RequestParameters = false;
                    DevExpress.XtraReports.UI.ReportPrintTool pt = new DevExpress.XtraReports.UI.ReportPrintTool(Reporte);
                    pt.AutoShowParametersPanel = false;

                    Reporte.ShowPreviewDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Anular()
        {
            try
            {
                string mesanjeError = "";

                Get();

                FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();

                if (Info_GuiaRemision.IdGuiaRemision == 0)
                {
                    return;
                }

                if (lblAnulado.Visible)
                {
                    MessageBox.Show("No se puede anular guia por que ya se encuentra anulada");
                    return;
                }

                if (MessageBox.Show("¿Está seguro que desea anular la guia de remision " + Info_GuiaRemision.IdGuiaRemision + "?", param.NombreEmpresa, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ofrm.ShowDialog();
                    Info_GuiaRemision.IdUsuarioAnulacion = param.IdUsuario;
                    Info_GuiaRemision.FechaAnulacion = DateTime.Now;
                    Info_GuiaRemision.MotivoAnulacion = ofrm.motivoAnulacion;

                    if (ofrm.cerrado == "N")
                    {
                        if (Bus.Anular(Info_GuiaRemision, ref mesanjeError))
                        {
                            string smensaje = string.Format("{0} # {1} se anuló con éxito.", "La Guía de Remisión", Info_GuiaRemision.IdGuiaRemision);
                            MessageBox.Show(smensaje, param.Nombre_sistema);
                            lblAnulado.Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private bool ValidarItems()
        {
            try
            {               
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.EDEHSA:
                        List<string> grupo_mp = new List<string>();
                        grupo_mp.Add("1"); // Materia Prima
                        grupo_mp.Add("2"); // Suministros

                        in_producto_x_tb_bodega_Costo_Historico_Bus BusProd_x_Costo = new in_producto_x_tb_bodega_Costo_Historico_Bus();
                        in_producto_x_tb_bodega_Costo_Historico_Info Info_Produc_x_Costo = new in_producto_x_tb_bodega_Costo_Historico_Info();

                        foreach (var item in BindingList_GuiaRemision)
                        {
                            Info_Produc_x_Costo = BusProd_x_Costo.get_UltimoCosto_x_Producto_Bodega(
                                param.IdEmpresa,
                                Convert.ToInt32(ucGe_Sucursal_Bodega_Origen.cmb_sucursal.EditValue),
                                Convert.ToInt32(ucGe_Sucursal_Bodega_Origen.cmb_bodega.EditValue),
                                Convert.ToDecimal(item.IdProducto),
                                Convert.ToDateTime(dtpFechaEmision.Text));

                            item.Costo = Info_Produc_x_Costo.costo;
                        }

                        // Obtengo el total de items con costo 0
                        int iTotalItemsCostoCero = BindingList_GuiaRemision.Where(q => q.Costo == 0).Count();
                        // Si el resultado de items con costo 0 es mayor a 0 y es diferente al numero de elementos de mi lista. 
                        if (iTotalItemsCostoCero > 0 && iTotalItemsCostoCero != BindingList_GuiaRemision.Count())
                        {
                            MessageBox.Show("¡Cuidado! No se pueden mezclar items con costo $0 con items que tienen costo. Por favor, asegúrate de combinar elementos que tengan costo para evitar problemas en el sistema.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }

                        int iTotalItemsGrupoMP = BindingList_GuiaRemision.Where(q => grupo_mp.Contains(q.IdCategoria)).Count();
                        if (iTotalItemsGrupoMP > 0 && iTotalItemsGrupoMP != BindingList_GuiaRemision.Count())
                        {
                            MessageBox.Show("¡Atención! No se pueden mezclar items que no sean de Materia Prima o Suministros. Por favor, verifica los elementos que estás intentando combinar.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }

                        break;
                }

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }           
        }

        private Boolean Grabar()
        {
            try
            {
                if (!Validar()) return false;
                if (!ValidarItems()) return false;
                string ms = "";

                Get();

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        if (Bus.GrabarDB(Info_GuiaRemision, ref ms))
                        {
                            MessageBox.Show("Guía de Remisión # " + Info_GuiaRemision.IdGuiaRemision + " Ingresada con éxito.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            _Accion = Cl_Enumeradores.eTipo_action.actualizar;
                        }

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Info_GuiaRemision.IdUsuarioModificacion = param.IdUsuario;
                        Info_GuiaRemision.FechaModificacion = DateTime.Now;

                        if (Bus.ModificarDB(Info_GuiaRemision, ref ms))
                        {
                            MessageBox.Show("La Guía de Remisión # " + Info_GuiaRemision.IdGuiaRemision + " Modificada con éxito.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                }

                if (MessageBox.Show("¿Desea generar xml de la Guía Remisión N° " + Info_GuiaRemision.IdGuiaRemision + "?", "Generar XML", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Generar_Xml();
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error: " + ex.Message, param.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void cmb_Transportista_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                tb_transportista_Info Info_transportista = LisTransportista.FirstOrDefault(q => q.IdTransportista == Convert.ToInt16(cmb_Transportista.EditValue));

                if (Info_transportista != null)
                {
                    txtNumPlaca.Text = Info_transportista.Placa;
                }
                else
                {
                    txtNumPlaca.Text = "";
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Generar_Xml()
        {
            try
            {
                string mensaje = "";

                if (Bus.Generar_Guardar_Xml_Guia(param.IdEmpresa, Convert.ToInt32(ucGe_Sucursal_Bodega_Origen.cmb_sucursal.EditValue), Info_GuiaRemision.IdGuiaRemision, ref mensaje))
                {
                    in_Parametro_Bus Bus_Inventario = new in_Parametro_Bus();
                    in_Parametro_Info Info_Parametro = new in_Parametro_Info();
                    string RutaDescarga = "";

                    Info_Parametro = Bus_Inventario.Get_Info_Parametro(param.IdEmpresa);

                    if (Info_Parametro != null)
                    {
                        RutaDescarga = Info_Parametro.pa_ruta_descarga_xml_guia_elct;
                    }

                    MessageBox.Show("xml generado con éxito en la ruta " + RutaDescarga, param.Nombre_sistema, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(mensaje, param.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void gridControlGuia_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridViewGuia.DeleteSelectedRows();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void chk_exportacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_exportacion.Checked)
            {
                TabExportacion.Visible = true;
            }
            else
            {
                TabExportacion.Visible = false;
            }

            set_datos_exportacion();
        }

        private void set_datos_exportacion()
        {
            try
            {
                tb_Empresa_Info Info_Empresa = param.InfoEmpresa;

                if (Info_Empresa != null)
                {
                    txt_exp_nombre_exportador.EditValue = Info_Empresa.RazonSocial;
                    txt_exp_direccion_exportador.EditValue = Info_Empresa.em_direccion;
                    txt_exp_correo_exportador.EditValue = Info_Empresa.em_Email;
                    txt_exp_telefono_exportador.EditValue = Info_Empresa.em_telefonos;
                    txt_exp_fax_exportador.EditValue = Info_Empresa.em_fax;
                }
                else
                {
                    txt_exp_nombre_exportador.EditValue = null;
                    txt_direccion_exp_comprador.EditValue = null;
                    txt_exp_correo_exportador.EditValue = null;
                    txt_exp_telefono_exportador.EditValue = null;
                    txt_exp_fax_exportador.EditValue = null;
                }

                vwtb_persona_beneficiario_Info Info_Beneficiario = ucGe_Beneficiario.Get_Persona_beneficiario_Info();

                if (Info_Beneficiario.IdTipo_Persona == Cl_Enumeradores.eTipoPersona.CLIENTE.ToString())
                {
                    fa_Cliente_Info Info_Cliente = ucGe_Beneficiario.Get_Info_Cliente();

                    if (Info_Cliente != null)
                    {
                        txt_exp_nombre_comprador.EditValue = Info_Cliente.Persona_Info.pe_razonSocial;
                        txt_direccion_exp_comprador.EditValue = Info_Cliente.Persona_Info.pe_direccion;
                        txt_correo_exp_comprador.EditValue = Info_Cliente.Mail_Principal;
                        txt_telefono_exp_comprador.EditValue = Info_Cliente.Persona_Info.pe_telefonoCasa;
                        txt_fax_exp_comprador.EditValue = Info_Cliente.Persona_Info.pe_fax;
                    }
                    else
                    {
                        txt_exp_nombre_comprador.EditValue = null;
                        txt_direccion_exp_comprador.EditValue = null;
                        txt_correo_exp_comprador.EditValue = null;
                        txt_telefono_exp_comprador.EditValue = null;
                        txt_fax_exp_comprador.EditValue = null;
                    }
                }
                else
                {
                    if (Info_Beneficiario.IdTipo_Persona == Cl_Enumeradores.eTipoPersona.PERSONA.ToString() || Info_Beneficiario.IdTipo_Persona == Cl_Enumeradores.eTipoPersona.PROVEE.ToString())
                    {
                        tb_persona_Info Info_Persona = ucGe_Beneficiario.Get_Info_Persona();

                        if (Info_Persona != null)
                        {
                            txt_exp_nombre_comprador.EditValue = Info_Persona.pe_razonSocial;
                            txt_direccion_exp_comprador.EditValue = Info_Persona.pe_direccion;
                            txt_correo_exp_comprador.EditValue = Info_Persona.pe_correo;
                            txt_telefono_exp_comprador.EditValue = Info_Persona.pe_telefonoCasa;
                            txt_fax_exp_comprador.EditValue = Info_Persona.pe_fax;
                        }
                        else
                        {
                            txt_exp_nombre_comprador.EditValue = null;
                            txt_direccion_exp_comprador.EditValue = null;
                            txt_correo_exp_comprador.EditValue = null;
                            txt_telefono_exp_comprador.EditValue = null;
                            txt_fax_exp_comprador.EditValue = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_centro_costo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cl_Enumeradores.eTipo_action.grabar == _Accion)
                {
                    if (ucGe_Beneficiario.Get_Persona_beneficiario_Info() != null)
                    {
                        vwtb_persona_beneficiario_Info Info_persona_beneficiario = ucGe_Beneficiario.Get_Persona_beneficiario_Info();

                        if (Info_persona_beneficiario.IdTipo_Persona == Cl_Enumeradores.eTipoPersona.CLIENTE.ToString())
                        {
                            Info_Cliente_Obra = Bus_Cliente_Obra.Get_Info(param.IdEmpresa, Info_persona_beneficiario.IdEntidad, Convert.ToString(cmb_centro_costo.EditValue));

                            if (Info_Cliente_Obra != null)
                            {
                                txtDestinoCarga.Text = Info_Cliente_Obra.DireccionObra;
                                txtMailPrincipal.Text = Info_Cliente_Obra.CorreoObra;
                            }
                        }
                        else
                        {
                            tb_persona_bus Bus_Persona = new tb_persona_bus();
                            tb_persona_Info Info_Persona = new tb_persona_Info();

                            Info_Persona = Bus_Persona.Get_Info_Persona(Info_persona_beneficiario.IdPersona);

                            txtDestinoCarga.Text = Info_Persona.pe_direccion;
                            txtMailPrincipal.Text = Info_Persona.pe_correo;
                        }
                    }


                    cmbProducto_grid.DataSource = listProducto;
                }

                foreach (var item in BindingList_GuiaRemision)
                {
                    item.IdCentroCosto = (cmb_centro_costo.EditValue == null) ? null : Convert.ToString(cmb_centro_costo.EditValue);
                    gridControlGuia.RefreshDataSource();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEgr_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (Info_Inv_x_GuiaRemision == null)
            {
                MessageBox.Show("No existe movimiento de bodega", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            show_formulario_inventario(Convert.ToInt32(Info_Inv_x_GuiaRemision.IdEmpresa), Convert.ToInt16(Info_Inv_x_GuiaRemision.IdSucursal), Convert.ToInt16(Info_Inv_x_GuiaRemision.IdMovi_inven_tipo), Convert.ToInt16(Info_Inv_x_GuiaRemision.IdNumMovi));
        }

        private void show_formulario_inventario(int IdEmpresa, int IdSucursal, int IdMovi_inven_tipo, decimal IdNumMovi)
        {
            try
            {
                in_Ing_Egr_Inven_Info Info_Ing_Egr = new in_Ing_Egr_Inven_Info();

                Info_Ing_Egr = Bus_Ing_Egr.Get_Info_Ing_Egr_Inven(param.IdEmpresa, IdSucursal, IdMovi_inven_tipo, IdNumMovi);

                if (Info_Ing_Egr.IdEmpresa != 0)
                {
                    Bizu.Presentation.Inventario.FrmIn_Egresos_Varios_Mant frm_Egr = new Bizu.Presentation.Inventario.FrmIn_Egresos_Varios_Mant();
                    frm_Egr.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm_Egr.setInfo_(Info_Ing_Egr);
                    frm_Egr.MdiParent = this.MdiParent;
                    frm_Egr.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdContratista_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}