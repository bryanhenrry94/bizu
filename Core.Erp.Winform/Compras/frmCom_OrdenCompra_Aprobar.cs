using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.Mail;
using Core.Erp.Info.Mail;

using Core.Erp.Winform.Inventario;
using DevExpress.XtraPrinting;

using Core.Erp.Reportes.Compras;

using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

namespace Core.Erp.Winform.Compras
{
    public partial class frmCom_OrdenCompra_Aprobar : DevExpress.XtraEditors.XtraForm
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        BindingList<com_ordencompra_local_Info> LstOC = new BindingList<com_ordencompra_local_Info>();
        com_ordencompra_local_Bus BusOC = new com_ordencompra_local_Bus();
        com_ordencompra_local_Info InfoOC = new com_ordencompra_local_Info();
        frmCom_OrdenCompra_Mant frm = new frmCom_OrdenCompra_Mant();
        com_Catalogo_Bus BusEstAP = new com_Catalogo_Bus();
        List<com_Catalogo_Info> LstEA = new List<com_Catalogo_Info>();
        com_ordencompra_local_Info info = new com_ordencompra_local_Info();
        in_Ing_Egr_Inven_Info info_IngComp = new in_Ing_Egr_Inven_Info();
        List<in_Ing_Egr_Inven_det_Info> list_IngxComp;
        tb_Sucursal_Bus BusSucursal = new tb_Sucursal_Bus();
        in_Ing_Egr_Inven_det_Bus bus_inven = new in_Ing_Egr_Inven_det_Bus();

        List<com_ordencompra_local_det_Info> LstDetOC = new List<com_ordencompra_local_det_Info>();
        com_ordencompra_local_det_Bus BusDetOC = new com_ordencompra_local_det_Bus();
        com_parametro_Bus bus_Comparam;
        in_Motivo_Inven_Bus bus_MotivoInv;
        in_movi_inve_Bus bus_MovInv;
        com_parametro_Info info_Comparam;
        BindingList<in_Ing_Egr_Inven_det_Info> ListaBind;
        List<in_Ingreso_x_OrdenCompra_det_Info> list;
        in_Ingreso_x_OrdenCompra_det_Bus bus_IngxCompDet;
        in_Ing_Egr_Inven_Bus Bus_IngEgr;
        in_Ing_Egr_Inven_det_Bus Bus_IngEgrDet;
        vwin_Ingr_Egr_Inven_det_Bus bus_IngEgrDet1 = new vwin_Ingr_Egr_Inven_det_Bus();
        BindingList<vwin_Ing_Egr_Inven_det_Info> ListaBind1;
        List<vwin_Ing_Egr_Inven_det_Info> list_validar = new List<vwin_Ing_Egr_Inven_det_Info>();
        vwin_Ing_Egr_Inven_det_Info Info_validar = new vwin_Ing_Egr_Inven_det_Info();
        List<in_Ing_Egr_Inven_det_Info> lista = new List<in_Ing_Egr_Inven_det_Info>();

        string tipo = "";

        double? Total = 0;        
        #endregion

        public frmCom_OrdenCompra_Aprobar()
        {
            try
            {
                InitializeComponent();

                LstEA = BusEstAP.Get_ListEstadoAprobacion();
                com_Catalogo_Info todos = new com_Catalogo_Info();
                todos.CodCatalogo = "TODOS";
                todos.descripcion = "TODOS";
                LstEA.Add(todos);

                cmbEstadoApro.Properties.DataSource = LstEA;
                cmbEstadoApro.Properties.ValueMember = "IdCatalogocompra";
                cmbEstadoApro.Properties.DisplayMember = "descripcion";
                cmbEstadoApro.EditValue = "xAPRO";
                DateTime fecha = new DateTime();
                fecha = DateTime.Now;
                dTPFechaFin.Value = fecha.AddDays(1);
                dTPFechaIni.Value = fecha.AddDays(-30);

                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        void LimpiarDatos()
        {
            try
            {
                dTPFechaFin.Focus();
                LstOC = new BindingList<com_ordencompra_local_Info>();
                seteargrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                string leftColumn = "Fecha: [Date Printed][Time Printed]";
                string middleColumn = "Página:[Page # of Pages #]";
                string rightColumn = "Usuario:" + param.IdUsuario;

                PageHeaderFooter phf = printableComponentLink1.PageHeaderFooter as PageHeaderFooter;

                phf.Header.Content.Clear();
                phf.Footer.Content.Clear();
                Font fte = new System.Drawing.Font("Tahoma", 8.5f, FontStyle.Bold, GraphicsUnit.Point);

                phf.Header.Font = fte;
                phf.Footer.Font = fte;
                phf.Header.Content.AddRange(new string[] { leftColumn, "", rightColumn, "hola" });
                phf.Header.LineAlignment = BrickAlignment.Center;
                phf.Footer.Content.AddRange(new string[] { "", "", middleColumn });
                phf.Footer.LineAlignment = BrickAlignment.Center;
                printableComponentLink1.Component = gridCtrlOCPend;

                printableComponentLink1.ShowPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (getDet())
                {
                    grabar();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (getDet())
                {
                    grabar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void buscar()
        {
            try
            {
                cmb_Aprob.DataSource = BusEstAP.Get_ListEstadoAprobacion();
                //  LstOC = BusOC.BusquedasOrdenCompra(param.IdEmpresa,1, dTPFechaIni.Value, dTPFechaFin.Value, Convert.ToString(this.cmbEstadoApro.EditValue));              

                LstOC = new BindingList<com_ordencompra_local_Info>(BusOC.Get_List_ordencompra_local(param.IdEmpresa, dTPFechaIni.Value, dTPFechaFin.Value, Convert.ToString(this.cmbEstadoApro.EditValue), "A"));

                foreach (var item in LstOC)
                {
                    item.Ico = (Bitmap)imageList1.Images[0];
                }

                gridCtrlOCPend.DataSource = LstOC;

            }
            catch (Exception ex)
            {
            }

        }

        private void mnu_Modificar_Click(object sender, EventArgs e)
        {
            try
            {

                InfoOC = (com_ordencompra_local_Info)gridVwOCPend.GetFocusedRow();
                if (InfoOC != null)
                {

                    frm = new frmCom_OrdenCompra_Mant();
                    frm.Set_Info(InfoOC);
                    frm.Set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.Text = frm.Text + " ***MODIFICAR***";
                    frm.event_frmCom_OrdenCompra_Mant_FormClosing += new frmCom_OrdenCompra_Mant.delegate_frmCom_OrdenCompra_Mant_FormClosing(frm_event_frmCom_OrdenCompra_Mant_FormClosing);
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmCom_OC_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                buscar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnu_consultar_Click(object sender, EventArgs e)
        {

            try
            {
                InfoOC = (com_ordencompra_local_Info)gridVwOCPend.GetFocusedRow();
                if (InfoOC != null)
                {
                    frm = new frmCom_OrdenCompra_Mant();
                    frm.Set_Info(InfoOC);
                    frm.Set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridVwOCPend_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.RowHandle > -1)
                    gridVwOCPend.SetFocusedRowCellValue(colCheck, true);


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                buscar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void seteargrid()
        {
            try
            {
                LstOC = new BindingList<com_ordencompra_local_Info>();
                gridCtrlOCPend.DataSource = LstOC;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void grabar()
        {

            try
            {
                string msg = "";
                cmbEstadoApro.Focus();

                foreach (var item in LstOC)
                {
                    //item.IdEstadoAprobacion_cat = "APRO";
                    if (item.check == true)
                    {
                        switch (item.IdEstadoAprobacion_cat)
                        {

                            case "ANU":
                                item.FechaHoraAnul = param.Fecha_Transac;
                                item.IdUsuarioUltAnu = param.IdUsuario;
                                item.MotivoAnulacion = "O/C Anulada x " + item.MotivoReprobacion;
                                if (item.MotivoAnulacion.Length > 499)
                                    item.MotivoAnulacion = item.MotivoAnulacion.Substring(0, 498);

                                //if (BusOC.ReversarOC(item, ref msg))
                                //    MessageBox.Show("Se ha Anulado la Orden de Compra No." +
                                //        item.oc_NumDocumento, "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                break;

                            case "APRO":

                                item.co_fecha_aprobacion = DateTime.Now;
                                item.IdUsuario_Aprueba = param.IdUsuario;
                                item.MotivoReprobacion = "O/C Aprobada x " + item.MotivoReprobacion;
                                if (item.MotivoReprobacion.Length > 499)
                                    item.MotivoReprobacion = item.MotivoReprobacion.Substring(0, 498);

                                if (BusOC.Modificar_Estado_Aprob(item, ref msg))
                                {
                                    MessageBox.Show("Se ha actualizado correctamente la Orden de Compra No." + item.oc_NumDocumento, "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    this.bus_Comparam = new com_parametro_Bus();
                                    this.info_Comparam = this.bus_Comparam.Get_Info_parametro(param.IdEmpresa);

                                    if (Convert.ToBoolean(this.info_Comparam.NotificaAprobacionOC))
                                    {
                                        if (Convert.ToBoolean(this.info_Comparam.NotificaAprobacionOCAuto))
                                        {
                                            this.Notificar_Proveedor(param.IdEmpresa, param.IdSucursal, item.IdOrdenCompra);
                                        }
                                        else
                                        {
                                            if (MessageBox.Show("Desea notificar al proveedor la aprobación de la OC", this.param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                            {
                                                this.Notificar_Proveedor(param.IdEmpresa, param.IdSucursal, item.IdOrdenCompra);
                                            }
                                            
                                        }
                                    }
                                }

                                break;

                            case "xAPRO":

                                // MessageBox.Show("LA OPCION DE DESAPROBAR ESTA BLOQUEADA TEMPORALMENTE ..OC#" + item.oc_NumDocumento, "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                if (BusOC.Modificar_Estado_Aprob(item, ref msg))
                                {
                                    MessageBox.Show("Se ha actualizado correctamente la Orden de Compra No." +
                                       item.oc_NumDocumento, "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                break;

                            case "REP":

                                item.IdUsuario_Reprue = param.IdUsuario;
                                item.co_fechaReproba = param.Fecha_Transac;
                                item.MotivoReprobacion = "O/C Reprobada x " + item.MotivoReprobacion;
                                if (item.MotivoReprobacion.Length > 499)
                                    item.MotivoReprobacion = item.MotivoReprobacion.Substring(0, 498);

                                if (BusOC.Modificar_Estado_Aprob(item, ref msg))
                                {
                                    MessageBox.Show("Se ha actualizado correctamente la Orden de Compra No." +
                                       item.oc_NumDocumento, "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                }

                                break;
                            default:
                                break;
                        }
                    }
                }
                LimpiarDatos();
                cmbEstadoApro.EditValue = "xAPRO";
                buscar();


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Get(int sucursal, int bodega)
        {
            try
            {
                info_IngComp.IdEmpresa = param.IdEmpresa;
                info_IngComp.IdNumMovi = 0;
                info_IngComp.IdSucursal = sucursal;
                info_IngComp.IdBodega = bodega;
                info_IngComp.CodMoviInven = "";
                info_IngComp.IdMotivo_Inv = 3;
                info_IngComp.cm_observacion = "Aprobacion directa de producto de servicio";
                info_IngComp.cm_fecha = DateTime.Now;
                info_IngComp.signo = "+";

                bus_Comparam = new com_parametro_Bus();
                info_Comparam = new com_parametro_Info();
                info_Comparam = bus_Comparam.Get_Info_parametro(param.IdEmpresa);

                info_IngComp.IdMovi_inven_tipo = info_Comparam.IdMovi_inven_tipo_OC;
                info_IngComp.Fecha_Transac = param.Fecha_Transac;
                info_IngComp.nom_pc = param.nom_pc;
                info_IngComp.ip = param.ip;
                info_IngComp.IdUsuario = param.IdUsuario;

                GetDetalle();

                info_IngComp.listIng_Egr = list_IngxComp;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GetDetalle()
        {
            try
            {
                list_IngxComp = new List<in_Ing_Egr_Inven_det_Info>();

                //int focus = gridViewIngreso.FocusedRowHandle;
                //gridViewIngreso.FocusedRowHandle = focus + 1;

                foreach (var item in ListaBind)
                {
                    if (item.IdEstadoAproba == null || item.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.PEND.ToString())
                    {
                        in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();

                        if (item.IdProductoTipo == 2)
                        {
                            info.Checked = item.Checked;
                            info.IdEmpresa_oc = item.IdEmpresa_oc;
                            info.IdSucursal_oc = item.IdSucursal_oc;
                            info.IdOrdenCompra = item.IdOrdenCompra;
                            info.Secuencia_oc = item.Secuencia_oc;
                            info.IdOrdenCompra = item.IdOrdenCompra;
                            info.IdProducto = item.IdProducto;
                            info.IdBodega = item.IdBodega;
                            info.dm_stock_ante = item.dm_stock_ante;
                            info.dm_stock_actu = item.dm_stock_actu;
                            info.dm_observacion = item.dm_observacion;
                            info.dm_precio = item.dm_precio;
                            info.mv_costo_sinConversion = item.mv_costo;
                            info.mv_costo = item.mv_costo;
                            info.dm_peso = item.dm_peso;
                            info.IdCentroCosto = item.IdCentroCosto;
                            info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;//(item.IdCentroCosto_sub_centro_costo == null) ? null : list_subcentro_combo.FirstOrDefault(v => v.IdCentroCosto == item.IdCentroCosto && v.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo).IdCentroCosto_sub_centro_costo;
                            info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                            info.IdPunto_cargo = item.IdPunto_cargo;
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdSucursal = item.IdSucursal;
                            info.IdNumMovi = item.IdNumMovi;
                            info.Secuencia = item.Secuencia;
                            info.pr_descripcion = item.pr_descripcion;
                            info.dm_cantidad_sinConversion = item.dm_cantidad;
                            info.IdUnidadMedida_sinConversion = item.IdUnidadMedida;
                            info.dm_cantidad = item.dm_cantidad;
                            info.IdUnidadMedida = item.IdUnidadMedida;
                            info.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;

                            list_IngxComp.Add(info);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscar_Orden_Compra_(int IdProveedor, int ordenCompra)
        {
            try
            {
                bus_IngxCompDet = new in_Ingreso_x_OrdenCompra_det_Bus();
                list = new List<in_Ingreso_x_OrdenCompra_det_Info>();
                list = bus_IngxCompDet.Get_List_Ingreso_x_OrdenCompra_det_x_proveedor_x_OrdenCompra(param.IdEmpresa, IdProveedor, ordenCompra);

                List<in_Ing_Egr_Inven_det_Info> lista_AUX = new List<in_Ing_Egr_Inven_det_Info>();
                string estado;

                foreach (var item in list)
                {
                    in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();
                    estado = "";

                    info.IdEmpresa_oc = item.IdEmpresa;
                    info.IdSucursal_oc = item.IdSucursal;
                    info.IdOrdenCompra = item.IdOrdenCompra;
                    info.Secuencia_oc = item.secuencia_oc_det;
                    info.nom_sucu = item.nom_sucu;
                    info.IdProveedor = item.IdProveedor;
                    info.nom_proveedor = item.nom_proveedor;
                    info.oc_observacion = item.oc_observacion;
                    info.cod_producto = item.cod_producto;
                    info.nom_producto = item.nom_producto;
                    info.IdProducto = item.IdProducto;
                    info.dm_precio = item.oc_precio;
                    info.mv_costo = item.oc_precio;
                    info.cantidad_pedida_OC = item.cantidad_pedida_OC;

                    //info.dm_cantidad = item.cantidad_ing_a_Inven;
                    info.dm_cantidad = item.cantidad_pedida_OC;

                    //info.Saldo_x_Ing_OC = item.Saldo_x_Ing_OC;
                    info.Saldo_x_Ing_OC = 0;

                    info.dm_stock_ante = item.pr_stock;
                    info.dm_stock_actu = item.pr_stock + info.dm_cantidad;
                    info.dm_peso = item.pr_peso;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    info.IdPunto_cargo = item.IdPunto_cargo;
                    info.Saldo_x_Ing_OC_AUX = item.Saldo_x_Ing_OC_AUX;
                    info.IdUnidadMedida = item.IdUnidadMedida;
                    info.IdMotivo_OC = item.IdMotivo_OC;
                    info.Nom_Motivo = item.Nom_Motivo;
                    info.dm_observacion = "Ingreso por Orden de Compra";
                    info.oc_fecha = item.oc_fecha;
                    info.IdEstado_cierre = item.IdEstado_cierre;
                    info.nom_estado_cierre = item.nom_estado_cierre;
                    info.IdRegistro = item.Nomsub_centro_costo;
                    info.Ref_OC = item.Ref_OC;
                    info.do_descuento = Convert.ToDouble(item.do_descuento);
                    info.do_subtotal = Convert.ToDouble(item.do_subtotal);
                    info.do_iva = Convert.ToDouble(item.do_iva);
                    info.do_total = Convert.ToDouble(item.do_total);
                    info.nom_UnidadMedida = item.Descripcion;
                    info.IdUnidadMedida_Consumo = item.IdUnidadMedida;
                    info.IdUnidadMedida = item.IdUnidadMedida;
                    info.oc_NumDocumento = item.oc_NumDocumento;
                    info.IdProductoTipo = item.IdProductoTipo;
                    lista_AUX.Add(info);

                    ListaBind = new BindingList<in_Ing_Egr_Inven_det_Info>(lista_AUX);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Buscar(int idOrdenCompra)
        {
            try
            {
                List<vwin_Ing_Egr_Inven_det_Info> list_IngEgrDet = new List<vwin_Ing_Egr_Inven_det_Info>();
                //if (cmbTipoMovInv.get_TipoMoviInvInfo() == null)
                //{
                //    MessageBox.Show("Seleccione el Tipo de Movimiento", "Sistemas");
                //    return;
                //}

                list_IngEgrDet = bus_IngEgrDet1.Get_List_in_Ing_Egr_Inven_det_Todos(param.IdEmpresa, 1, 6, 11, Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.PEND.ToString(), idOrdenCompra);
                if (list_IngEgrDet.Count() == 0)
                {
                    MessageBox.Show("No existe información para la Sucursal : " + 1 + " , Bodega: " + 6 + " y Tipo de Movimiento: " + 11 + " ", "Sistemas");
                    return;
                }

                ListaBind1 = new BindingList<vwin_Ing_Egr_Inven_det_Info>(list_IngEgrDet.Where(q => q.Estado == "A").ToList());
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean Actualizar_Estados(int IdOrdenCompra)
        {
            try
            {
                //ucIn_Sucursal_Bodega1.Focus();

                foreach (var item2 in ListaBind1)
                {
                    item2.Checked = true;
                }
                list_validar = new List<vwin_Ing_Egr_Inven_det_Info>(ListaBind1.Where(q => q.Checked == true).ToList());
                Buscar(IdOrdenCompra);
                foreach (var item in list_validar)
                {
                    Info_validar = ListaBind1.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdMovi_inven_tipo == item.IdMovi_inven_tipo && q.IdNumMovi == item.IdNumMovi && q.secuencia == item.secuencia);

                    if (Info_validar != null)
                    {
                        ListaBind1.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdMovi_inven_tipo == item.IdMovi_inven_tipo && q.IdNumMovi == item.IdNumMovi && q.secuencia == item.secuencia).Checked = true;
                        ListaBind1.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdMovi_inven_tipo == item.IdMovi_inven_tipo && q.IdNumMovi == item.IdNumMovi && q.secuencia == item.secuencia).IdEstadoAproba = "APRO";
                    }
                }
                //gridControlCons.DataSource = ListaBind;

                List<in_Ing_Egr_Inven_det_Info> lista = new List<in_Ing_Egr_Inven_det_Info>();
                foreach (var item in ListaBind1)
                {
                    in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();

                    if (item.IdProductoTipo == 2)
                    {
                        //PK
                        //&& item.IdBodega >= 2 && item.IdBodega <= 3
                        if (item.signo == "+")
                        {
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdSucursal = item.IdSucursal;
                            info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                            info.IdNumMovi = item.IdNumMovi;
                            info.Secuencia = item.secuencia;

                            info.IdBodega = item.IdBodega;
                            info.IdProducto = item.IdProducto;
                            info.nom_producto = item.nom_producto;
                            info.dm_cantidad = item.dm_cantidad;
                            info.dm_stock_ante = item.dm_stock_ante;
                            info.dm_stock_actu = item.dm_stock_actu;
                            info.dm_observacion = item.dm_observacion;
                            info.dm_precio = item.dm_precio;
                            info.mv_costo = item.mv_costo;
                            info.dm_peso = item.dm_peso;
                            info.IdCentroCosto = item.IdCentroCosto;
                            info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                            info.IdPunto_cargo = item.IdPunto_cargo;
                            info.IdUnidadMedida = item.IdUnidadMedida;
                            info.IdEstadoAproba = item.IdEstadoAproba;
                            info.Motivo_Aprobacion = item.Motivo_Aprobacion;
                            info.IdMotivo_Inv = item.IdMotivo_Inv;

                            info.IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion;
                            info.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion;
                            info.mv_costo_sinConversion = item.mv_costo_sinConversion;
                            lista.Add(info);
                        }
                        else
                        {
                            //MessageBox.Show(
                            //        "El Producto: " + item.nom_producto +
                            //        " 'No tiene Costo' " + " / 'No se Puede Aprobar:'",
                            //        param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }

                var itemTipMov = "+";



                if (itemTipMov != null)
                {
                    tipo = "+";
                }
                string mensaje = "";


                if (bus_IngEgrDet1.Modificar_Estado_IngEgr_Det(lista, tipo, ref mensaje))
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Error al Actualizar Estados, " + mensaje, param.Nombre_sistema);
                    return false;
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

        private Boolean getDet()
        {
            try
            {
                dTPFechaFin.Focus();
                LstOC = new BindingList<com_ordencompra_local_Info>();
                if (gridVwOCPend.RowCount > 0)
                {
                    for (int i = 0; i < gridVwOCPend.RowCount; i++)
                    {
                        var info = gridVwOCPend.GetRow(i) as com_ordencompra_local_Info;

                        if (info != null && info.check == true)
                        {

                            LstOC.Add(info);
                        }
                    }

                    if (LstOC.Count < 1)
                    {
                        MessageBox.Show("Debe seleccionar las Ordenes de Compra a grabar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar las Ordenes de Compra a grabar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return false;
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

        private void gridVwOCPend_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridVwOCPend.GetRow(e.RowHandle) as com_ordencompra_local_Info;
                if (data == null)
                    return;
                if (data.Estado == "I" /*||data.IdEstadoAprobacion == "REP"*/)
                    e.Appearance.ForeColor = Color.Red;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridCtrlOCPend_Load(object sender, EventArgs e)
        {
            try
            {
                cmbEstadoApro.Text = "xAPRO";
                buscar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridVwOCPend_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                info = (com_ordencompra_local_Info)this.gridVwOCPend.GetFocusedRow();

                if (e.Column.Name == "colAbrirOC")
                {
                    var row = (com_ordencompra_local_Info)gridVwOCPend.GetFocusedRow();
                    if (row == null) return;

                    switch (param.IdCliente_Ven_x_Default)
                    {
                        case Cl_Enumeradores.eCliente_Vzen.EDEHSA:
                            XCOMP_Rpt001_Bus BusCompra = new XCOMP_Rpt001_Bus();
                            List<XCOMP_Rpt001_Info> data = new List<XCOMP_Rpt001_Info>();
                            data = BusCompra.Get_Data(row.IdEmpresa, row.IdSucursal, row.IdOrdenCompra);

                            try
                            {
                                mail_Cuenta_Correo_Bus Bus_Cuentas_Correo = new mail_Cuenta_Correo_Bus();
                                List<mail_Cuenta_Correo_Info> List_Cuenta_Correo = Bus_Cuentas_Correo.Get_List(param.IdEmpresa);

                                foreach (var item in List_Cuenta_Correo)
                                {
                                    foreach (var item2 in data)
                                    {
                                        item2.correo_notificacion = item.Direccion_Correo;

                                        switch (item2.Por_Iva)
                                        {
                                            case 12:
                                                item2.SubtotalIva2 = item2.do_subtotal;
                                                item2.do_iva2 = item2.do_iva;

                                                break;
                                            case 15:
                                                item2.SubtotalIva4 = item2.do_subtotal;
                                                item2.do_iva4 = item2.do_iva;

                                                break;
                                            case 5:
                                                item2.SubtotalIva5 = item2.do_subtotal;
                                                item2.do_iva5 = item2.do_iva;

                                                break;
                                        }
                                    }
                                }
                            }
                            catch
                            {
                            }

                            int iTotalElementosEnKilo = data.Where(q => q.IdUnidadMedida == "UNI_401").Count();
                            int iTotalElementosGeneral = data.Count();

                            // Si todos los elementos son en kilos, cargar reporte de orden de compra
                            //if (iTotalElementosEnKilo == iTotalElementosGeneral)
                            //{
                            //    XCOMP_Rpt001_Rpt_Conversion Reporte_Edehsa = new XCOMP_Rpt001_Rpt_Conversion();
                            //    Reporte_Edehsa.RequestParameters = false;
                            //    ReportPrintTool pt_Edehsa = new ReportPrintTool(Reporte_Edehsa);
                            //    pt_Edehsa.AutoShowParametersPanel = false;
                            //    Reporte_Edehsa.loadData(data);
                            //    Reporte_Edehsa.ShowPreviewDialog();
                            //}
                            //else
                            //{
                                XCOMP_Rpt001_Rpt Reporte_Edehsa = new XCOMP_Rpt001_Rpt();
                                Reporte_Edehsa.RequestParameters = false;
                                ReportPrintTool pt_Edehsa = new ReportPrintTool(Reporte_Edehsa);
                                pt_Edehsa.AutoShowParametersPanel = false;
                                Reporte_Edehsa.loadData(data);
                                Reporte_Edehsa.ShowPreviewDialog();
                            //}

                            break;

                        case Cl_Enumeradores.eCliente_Vzen.CIDERSUS:
                            XCOMP_Rpt012_Rpt Reporte_Cidersus = new XCOMP_Rpt012_Rpt();
                            Reporte_Cidersus.RequestParameters = false;
                            ReportPrintTool pt_Cidersus = new ReportPrintTool(Reporte_Cidersus);
                            pt_Cidersus.AutoShowParametersPanel = false;

                            XCOMP_Rpt012_Bus BusCompra_Cid = new XCOMP_Rpt012_Bus();
                            List<XCOMP_Rpt012_Info> data_Cid = new List<XCOMP_Rpt012_Info>();

                            data_Cid = BusCompra_Cid.Get_Data(row.IdEmpresa, param.IdSucursal, Convert.ToDecimal(row.IdOrdenCompra));

                            Reporte_Cidersus.loadData(data_Cid);
                            Reporte_Cidersus.ShowPreviewDialog();

                            break;
                    }
                }


                if (e.Column.Name == "colCheck")
                {
                    if ((Boolean)gridVwOCPend.GetFocusedRowCellValue(colCheck))
                    {
                        gridVwOCPend.SetFocusedRowCellValue(colCheck, false);
                        gridVwOCPend.SetFocusedRowCellValue(colap_descripcion, info.IdEstadoAprobacion_AUX);
                    }
                    else
                    {                  
                        if (info.IdEstadoAprobacion_AUX == "ANU")
                        {
                            MessageBox.Show("No se pueden modificar registros Inactivos", "Sistemas");
                            return;
                        }

                        gridVwOCPend.SetFocusedRowCellValue(colCheck, true);
                        gridVwOCPend.SetFocusedRowCellValue(colap_descripcion, "APRO");
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmCom_OrdenCompra_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
            }
        }

        private void toolStripButtonConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                buscar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbEstadoApro_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                toolStripButtonConsultar_Click(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true && LstOC.Count > 0)
                {
                    foreach (var item in LstOC)
                    {
                        item.check = true;
                        item.IdEstadoAprobacion_cat = "APRO";
                    }

                    gridCtrlOCPend.DataSource = null;
                    gridCtrlOCPend.DataSource = LstOC;
                }

                if (checkBox1.Checked == false && LstOC.Count > 0)
                {

                    foreach (var item in LstOC)
                    {
                        item.check = false;
                        item.IdEstadoAprobacion_cat = "xAPRO";
                    }

                    gridCtrlOCPend.DataSource = null;
                    gridCtrlOCPend.DataSource = LstOC;
                }

                CalcularTotal();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                buscar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridVwOCPend_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                info = (com_ordencompra_local_Info)this.gridVwOCPend.GetFocusedRow();

                if (e.Column.Name == "colap_descripcion")
                {

                    lista = bus_inven.Get_List_Ing_Egr_Inven_det_x_OrdenCompra(info.IdEmpresa, info.IdSucursal, info.IdOrdenCompra);


                    if (lista.Count > 0)
                    {

                        FrmIn_Detalle_Ing_Egr_Bodega_Alerta frmConsulta = new FrmIn_Detalle_Ing_Egr_Bodega_Alerta();
                        frmConsulta.Text = "Alertas";
                        frmConsulta.lblMensaje.Text = "La OC#: " + info.IdOrdenCompra + " tiene Ingesos a Bodega";

                        frmConsulta.set_info_list(lista);
                        info.IdEstadoAprobacion_cat = info.IdEstadoAprobacion_AUX;
                        info.check = false;
                        frmConsulta.ShowDialog();
                        return;
                    }
                    else
                    {
                        if (info.IdEstadoAprobacion_AUX == "ANU")
                        {
                            MessageBox.Show("No se pueden modificar registros Inactivos");

                        }
                    }
                }

                CalcularTotal();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CalcularTotal()
        {
            try
            {
                Total = 0;               
                txtTotal.EditValue = Total == null ? "" : Total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmCom_OrdenCompra_Aprobar_Load(object sender, EventArgs e)
        {

        }

        private void dTPFechaFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbEstadoApro_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Notificar_Proveedor(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {                
                // obtener el Info Orden de Compra                
                com_ordencompra_local_Bus Bus_OC = new com_ordencompra_local_Bus();

                com_ordencompra_local_Info Info_OrdenCompra = Bus_OC.Get_Info_ordencompra_local(IdEmpresa, IdSucursal, IdOrdenCompra);


                mail_Mail_Bus Bus_Mail = new mail_Mail_Bus();
                mail_Mail_Info Info_Mail = new mail_Mail_Info();

                cp_proveedor_Bus Bus_Proveedor = new cp_proveedor_Bus();
                cp_proveedor_Info Info_Proveedor = new cp_proveedor_Info();

                mail_Plantilla_Mensaje_Info Info_Plantilla_Mensaje = new mail_Plantilla_Mensaje_Info();
                mail_Plantilla_Mensaje_Bus Bus_Plantilla_Mensaje = new mail_Plantilla_Mensaje_Bus();

                string correo_proveedor = "";
                string sMensaje = "";

                Info_Proveedor = Bus_Proveedor.Get_Info_Proveedor(param.IdEmpresa, Info_OrdenCompra.IdProveedor);

                if (Info_Proveedor.Persona_Info != null)
                {
                    correo_proveedor = Info_Proveedor.Persona_Info.pe_correo;
                }
                
                Info_Plantilla_Mensaje = Bus_Plantilla_Mensaje.Get_Info(param.IdEmpresa, "NOTIF_COMPRA");

                if (Info_Plantilla_Mensaje != null)
                {
                    sMensaje = Info_Plantilla_Mensaje.Mensaje;
                }

                if (!string.IsNullOrEmpty(correo_proveedor) && !string.IsNullOrEmpty(sMensaje))
                {
                    sMensaje = sMensaje.Replace("{idempresa}", param.InfoEmpresa.RazonSocial);
                    sMensaje = sMensaje.Replace("{idproveedor}", Info_Proveedor.Persona_Info.pe_razonSocial);
                    sMensaje = sMensaje.Replace("{iddocumento}", Info_OrdenCompra.IdOrdenCompra.ToString());

                    Info_Mail = new mail_Mail_Info();
                    Info_Mail.IdEmpresa = param.IdEmpresa;
                    Info_Mail.IdSucursal = param.IdSucursal;
                    Info_Mail.IdMail = 0;
                    Info_Mail.IdUsuario = param.IdUsuario;
                    Info_Mail.Origen = "COMP";
                    Info_Mail.Asunto = "Notificación de Aprobación OC#" + Info_OrdenCompra.IdOrdenCompra;
                    Info_Mail.Mensaje = sMensaje;
                    Info_Mail.To.Add(correo_proveedor);

                    string correo_secundario1 = Info_Proveedor.Persona_Info.pe_correo_secundario1;
                    string correo_secundario2 = Info_Proveedor.Persona_Info.pe_correo_secundario2;
                    
                    //if (!string.IsNullOrEmpty(correo_secundario1))
                    //    Info_Mail.CC.Add(correo_secundario1);

                    //if (!string.IsNullOrEmpty(correo_secundario2))
                    //    Info_Mail.CC.Add(correo_secundario2);

                    com_solicitante_Info Info_Solicitante = new com_solicitante_Info();
                    com_solicitante_Bus Bus_Solicitante = new com_solicitante_Bus();

                    Info_Solicitante = Bus_Solicitante.Get_Info(Info_OrdenCompra.IdEmpresa, Convert.ToDecimal(Info_OrdenCompra.IdSolicitante));

                    if (Info_Solicitante != null)
                    {
                        if (Convert.ToDouble(Info_Solicitante.IdPersona) != 0)
                        {
                            tb_persona_Info Info_Persona = new tb_persona_Info();
                            tb_persona_bus Bus_Persona = new tb_persona_bus();

                            Info_Persona = Bus_Persona.Get_Info_Persona(Convert.ToDecimal(Info_Solicitante.IdPersona));

                            if (Info_Persona != null)
                            {
                                //if (!string.IsNullOrEmpty(Info_Persona.pe_correo))
                                //    Info_Mail.CC.Add(Info_Persona.pe_correo);
                            }                                
                        }
                    }

                    string pdfFilePath = System.IO.Path.GetTempPath() + "OC" + Info_OrdenCompra.IdOrdenCompra + ".pdf";

                    //EXPORTAMOS REPORTE OC
                    XCOMP_Rpt001_Rpt Reporte_Edehsa = new XCOMP_Rpt001_Rpt();
                    Reporte_Edehsa.RequestParameters = false;
                    ReportPrintTool pt_Edehsa = new ReportPrintTool(Reporte_Edehsa);
                    pt_Edehsa.AutoShowParametersPanel = false;

                    XCOMP_Rpt001_Bus BusCompra = new XCOMP_Rpt001_Bus();
                    List<XCOMP_Rpt001_Info> data = new List<XCOMP_Rpt001_Info>();

                    data = BusCompra.Get_Data(Info_OrdenCompra.IdEmpresa, Info_OrdenCompra.IdSucursal, Info_OrdenCompra.IdOrdenCompra);
                    Reporte_Edehsa.loadData(data);

                    try
                    {
                        mail_Cuenta_Correo_Bus Bus_Cuentas_Correo = new mail_Cuenta_Correo_Bus();
                        List<mail_Cuenta_Correo_Info> List_Cuenta_Correo = Bus_Cuentas_Correo.Get_List(param.IdEmpresa);

                        foreach (var item in List_Cuenta_Correo)
                        {
                            foreach (var item2 in data)
                            {
                                item2.correo_notificacion = item.Direccion_Correo;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    }

                    Reporte_Edehsa.ExportToPdf(pdfFilePath);

                    mail_Mail_Attachment_Info Info_Adjunto = new mail_Mail_Attachment_Info();
                    Info_Adjunto.IdEmpresa = Info_Mail.IdEmpresa;
                    Info_Adjunto.IdSucursal = Info_Mail.IdSucursal;
                    Info_Adjunto.IdMail = Info_Mail.IdMail;
                    Info_Adjunto.Secuencia = 1;
                    Info_Adjunto.nombre = Info_OrdenCompra.IdOrdenCompra + ".pdf";
                    Info_Adjunto.archivo = System.IO.File.ReadAllBytes(pdfFilePath);

                    Info_Mail.mail_Mail_Attachment.Add(Info_Adjunto);

                    string mensaje = "";

                    Bus_Mail.GrabarBD(Info_Mail, ref mensaje);
                }
                else
                {
                    MessageBox.Show("Verificar que en la ficha del proveedor tenga registrado un correo para las notificaciones, o que exista un mensaje predefinido en la pantalla de configuracion de correo!", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}