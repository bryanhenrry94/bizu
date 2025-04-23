using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.Remoting;
using Bizu.Application.General;
using Bizu.Domain.General;
using Bizu.Domain.Contabilidad;
using Bizu.Application.Contabilidad;
using Bizu.Domain.CuentasxPagar;
using Bizu.Application.CuentasxPagar;
using Bizu.Domain.Compras;
using Bizu.Application.Compras;
using Bizu.Domain.Inventario;
using Bizu.Application.Inventario;
using DevExpress.XtraEditors.Controls;

namespace Bizu.Reports.Controles
{
    public partial class UCCom_Menu_Reportes : UserControl
    {
        #region Listas
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<com_Catalogo_Info> lst_catalogo = new List<com_Catalogo_Info>();
        com_Catalogo_Bus bus_catalogo = new com_Catalogo_Bus();

        List<tb_Sucursal_Info> lst_sucursal = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus bus_sucursal = new tb_Sucursal_Bus();

        List<ct_punto_cargo_Info> lst_punto_cargo = new List<ct_punto_cargo_Info>();
        ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();

        List<ct_punto_cargo_grupo_Info> lst_grupo = new List<ct_punto_cargo_grupo_Info>();
        ct_punto_cargo_grupo_Bus bus_grupo = new ct_punto_cargo_grupo_Bus();

        List<in_Producto_Info> lst_producto = new List<in_Producto_Info>();
        in_producto_Bus bus_producto = new in_producto_Bus();

        List<cp_proveedor_Info> lst_proveedor = new List<cp_proveedor_Info>();
        cp_proveedor_Bus bus_proveedor = new cp_proveedor_Bus();

        List<ct_Centro_costo_Info> lst_centroCosto = new List<ct_Centro_costo_Info>();
        ct_Centro_costo_Bus bus_centroCosto = new ct_Centro_costo_Bus();

        tb_Bodega_Bus bus_bodega = new tb_Bodega_Bus();
        List<tb_Bodega_Info> lst_bodega = new List<tb_Bodega_Info>();

        List<in_categorias_Info> lst_Categoria = new List<in_categorias_Info>();
        in_categorias_Info info_Categoria = new in_categorias_Info();
        in_categorias_bus bus_Categoria = new in_categorias_bus();

        List<in_linea_info> lst_Linea = new List<in_linea_info>();
        in_linea_info info_Linea = new in_linea_info();
        in_linea_Bus bus_Linea = new in_linea_Bus();

        string msg = "";
        #endregion

        #region Delegados

        public delegate void delegate_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnImprimir_ItemClick event_btnImprimir_ItemClick;

        public delegate void delegate_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnRefrescar_ItemClick event_btnRefrescar_ItemClick;

        public delegate void delegate_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnsalir_ItemClick event_btnsalir_ItemClick;
        #endregion

        public UCCom_Menu_Reportes()
        {
            InitializeComponent();
            event_btnImprimir_ItemClick += UCGe_Menu_Reportes_Compras_event_btnImprimir_ItemClick;
            event_btnRefrescar_ItemClick += UCGe_Menu_Reportes_Compras_event_btnRefrescar_ItemClick;
            event_btnsalir_ItemClick += UCGe_Menu_Reportes_Compras_event_btnsalir_ItemClick;
            this.Dock = DockStyle.Top;
        }

        public void Cargar_combos()
        {
            try
            {
                lst_sucursal = bus_sucursal.Get_List_Sucursal(param.IdEmpresa);
                cmb_sucursal.DataSource = lst_sucursal;

                lst_grupo = bus_grupo.Get_List_punto_cargo_grupo(param.IdEmpresa, ref msg);
                cmb_grupo.DataSource = lst_grupo;

                lst_punto_cargo = bus_punto_cargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmb_punto_cargo.DataSource = lst_punto_cargo;

                lst_grupo = bus_grupo.Get_List_punto_cargo_grupo(param.IdEmpresa, ref msg);
                cmb_grupo.DataSource = lst_grupo;

                lst_proveedor = bus_proveedor.Get_List_proveedor(param.IdEmpresa);
                cmb_proveedor.DataSource = lst_proveedor;

                lst_centroCosto = bus_centroCosto.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref msg);
                cmb_CentroCosto.DataSource = lst_centroCosto;

                lst_bodega = bus_bodega.Get_List_Bodega(param.IdEmpresa);
                cmb_bodega.DataSource = lst_bodega;

                lst_producto = bus_producto.Get_list_Producto_cmb(param.IdEmpresa);
                cmb_producto.DataSource = lst_producto;

                lst_Categoria = bus_Categoria.Get_List_categorias(param.IdEmpresa);
                cmb_Categoria.DataSource = lst_Categoria;

                lst_Linea = bus_Linea.Get_List_Linea(param.IdEmpresa, "");
                cmb_Linea.DataSource = lst_Linea;

                lst_catalogo = bus_catalogo.Get_IdTipoLista("EST_APRO");
                cmb_EstadoAprobacionOC.DataSource = lst_catalogo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
                
        void UCGe_Menu_Reportes_Compras_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Reportes_Compras_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        void UCGe_Menu_Reportes_Compras_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        
        #region Visible y Enable
       
        public Boolean Visible_Grupo_filtro
        {
            get { return this.ribbonPageGrupo_filtro.Visible; }
            set { this.ribbonPageGrupo_filtro.Visible = value; }
        }
        public Boolean Visible_Grupo_Categoria
        {
            get { return this.GrupoCategoria.Visible; }
            set { this.GrupoCategoria.Visible = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_bei_producto { get { return this.bei_producto.Visibility; } set { this.bei_producto.Visibility = value; } }
        public DevExpress.XtraBars.BarItemVisibility Visible_bei_EstadoAprobacion_OC { get { return this.bei_EstadoAprobacion_OC.Visibility; } set { this.bei_EstadoAprobacion_OC.Visibility = value; } }
        public DevExpress.XtraBars.BarItemVisibility Visible_bei_grupo { get { return this.bei_grupo.Visibility; } set { this.bei_grupo.Visibility = value; } }
        public DevExpress.XtraBars.BarItemVisibility Visible_bei_bodega { get { return this.bei_bodega.Visibility; } set { this.bei_bodega.Visibility = value; } }
        public DevExpress.XtraBars.BarItemVisibility Visible_bei_check1 { get { return this.bei_check1.Visibility; } set { this.bei_check1.Visibility = value; } }
        public DevExpress.XtraBars.BarItemVisibility Visible_bei_check2 { get { return this.bei_check2.Visibility; } set { this.bei_check2.Visibility = value; } }
        public DevExpress.XtraBars.BarItemVisibility Visible_bei_Fecha_Ini { get { return this.dtp_fechaIni.Visibility; } set { this.dtp_fechaIni.Visibility = value; } }
        public DevExpress.XtraBars.BarItemVisibility Visible_bei_Fecha_Fin { get { return this.dtp_fechaFin.Visibility; } set { this.dtp_fechaFin.Visibility = value; } }

        //public DevExpress.XtraBars.BarItem Text_bei_check1 { get { return this.bei_check1.te; } set { this.bei_check1.Visibility = value; } }
        public string Text_bei_check1 { get { return this.bei_check1.Caption; } set { this.bei_check1.Caption = value; } }
        public string Text_bei_check2 { get { return this.bei_check2.Caption; } set { this.bei_check2.Caption = value; } }

        public Boolean Visible_Grupo_acciones
        {
            get { return this.ribbonPageGrupo_acciones.Visible; }
            set { this.ribbonPageGrupo_acciones.Visible = value; }
        }

        public Boolean Visible_GrupoSucursal_producto
        {
            get { return this.GrupoSucursal_producto.Visible; }
            set { this.GrupoSucursal_producto.Visible = value; }
        }

        public Boolean Visible_GrupoPuntoCargo
        {
            get { return this.GrupoPuntoCargo.Visible; }
            set { this.GrupoPuntoCargo.Visible = value; }
        }

        public Boolean Visible_GrupoProveedor
        {
            get { return this.GrupoProveedor.Visible; }
            set { this.GrupoProveedor.Visible = value; }
        }
        
        public Boolean Visible_GrupoCentroCosto
        {
            get { return this.GrupoCentroCosto.Visible; }
            set { this.GrupoCentroCosto.Visible = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_boton_Imprimir
        {
            get { return this.btnImprimir.Visibility; }
            set { this.btnImprimir.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_boton_Refrescar
        {
            get { return this.btnRefrescar.Visibility; }
            set { this.btnRefrescar.Visibility = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility Visible_boton_Salir
        {
            get { return this.btnsalir.Visibility; }
            set { this.btnsalir.Visibility = value; }
        }

        public Boolean Enable_boton_Imprimir
        {
            get { return this.btnImprimir.Enabled; }
            set { this.btnImprimir.Enabled = value; }
        }

        public Boolean Enable_boton_Refrescar
        {
            get { return this.btnRefrescar.Enabled; }
            set { this.btnRefrescar.Enabled = value; }
        }
        
        public Boolean Enable_boton_Salir
        {
            get { return this.btnsalir.Enabled; }
            set { this.btnsalir.Enabled = value; }
        }

        #endregion

        public in_Producto_Info Get_info_producto()
        {
            try
            {
                in_Producto_Info info_producto = new in_Producto_Info();

                if (bei_producto.EditValue == null)
                    info_producto = null;
                else
                    info_producto = lst_producto.FirstOrDefault(q => q.IdEmpresa == param.IdEmpresa && q.IdProducto == Convert.ToDecimal(bei_producto.EditValue));

                return info_producto;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }

        public cp_proveedor_Info Get_info_proveedor()
        {
            try
            {
                cp_proveedor_Info info_proveedor = new cp_proveedor_Info();

                if (bei_proveedor.EditValue == null)
                    info_proveedor = null;
                else
                    info_proveedor = lst_proveedor.FirstOrDefault(q => q.IdEmpresa == param.IdEmpresa && q.IdProveedor == Convert.ToDecimal(bei_proveedor.EditValue));

                return info_proveedor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }

        public ct_punto_cargo_Info Get_info_punto_cargo()
        {
            try
            {
                ct_punto_cargo_Info info_punto_cargo = new ct_punto_cargo_Info();

                if (bei_punto_cargo.EditValue == null)
                    info_punto_cargo = null;
                else
                    info_punto_cargo = lst_punto_cargo.FirstOrDefault(q => q.IdEmpresa == param.IdEmpresa && q.IdPunto_cargo == Convert.ToInt32(bei_punto_cargo.EditValue));

                return info_punto_cargo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }

        public ct_punto_cargo_grupo_Info Get_info_punto_cargo_grupo()
        {
            try
            {
                ct_punto_cargo_grupo_Info info_punto_cargo_grupo = new ct_punto_cargo_grupo_Info();

                if (bei_grupo.EditValue == null)
                    info_punto_cargo_grupo = null;
                else
                    info_punto_cargo_grupo = lst_grupo.FirstOrDefault(q => q.IdEmpresa == param.IdEmpresa && q.IdPunto_cargo_grupo == Convert.ToInt32(bei_grupo.EditValue));

                return info_punto_cargo_grupo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }

        public tb_Sucursal_Info Get_info_sucursal()
        {
            try
            {
                tb_Sucursal_Info info_sucursal = new tb_Sucursal_Info();

                if (bei_sucursal.EditValue == null)
                    info_sucursal = null;
                else
                    info_sucursal = lst_sucursal.FirstOrDefault(q => q.IdEmpresa == param.IdEmpresa && q.IdSucursal == Convert.ToInt32(bei_sucursal.EditValue));

                return info_sucursal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }

        private void btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btnImprimir_ItemClick(sender,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btnRefrescar_ItemClick(sender,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.ParentForm.Close();

                event_btnsalir_ItemClick(sender,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void UCGe_Menu_Reportes_Compras_Load(object sender, EventArgs e)
        {            
            dtp_fechaIni.EditValue = DateTime.Now.AddMonths(-1);
            dtp_fechaFin.EditValue = DateTime.Now.AddMonths(1);

            Cargar_combos();
        }

        private void ribbonControlMenu_Click(object sender, EventArgs e)
        {

        }

        private void bei_grupo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (bei_grupo.EditValue == null)
                    lst_punto_cargo = bus_punto_cargo.Get_List_PuntoCargo(param.IdEmpresa);
                else
                    lst_punto_cargo = bus_punto_cargo.Get_list_PuntoCargo_x_grupo(param.IdEmpresa, Convert.ToInt32(bei_grupo.EditValue));
                cmb_punto_cargo.DataSource = lst_punto_cargo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void bei_Categoria_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (bei_Categoria.EditValue != null)
                {
                    string idCategoria = Convert.ToString(bei_Categoria.EditValue);
                    List<in_linea_info> ListLinea_temp = new List<in_linea_info>();

                    lst_Linea = bus_Linea.Get_List_Linea(param.IdEmpresa, idCategoria);

                    ListLinea_temp = lst_Linea.Where(q => q.IdCategoria.Contains(idCategoria)).ToList();
                    cmb_Linea.DataSource = null;
                    cmb_Linea.DataSource = ListLinea_temp;                  
                }
                else
                {
                    cmb_Linea.DataSource = lst_Linea;                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public List<int> Get_list_Linea_Cheked()
        {
            try
            {
                List<int> lista = new List<int>();

                var listIdCC_Cheked = (from CheckedListBoxItem item in cmb_Linea.Items
                                       where item.CheckState == CheckState.Checked
                                       select (int)item.Value).ToArray();

                foreach (var item in listIdCC_Cheked)
                {
                    lista.Add(item);
                }

                return lista;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new List<int>();
            }
        }

        private void bei_bodega_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                lst_producto = bus_producto.Get_list_Producto(param.IdEmpresa, Convert.ToInt32(bei_sucursal.EditValue), Convert.ToInt32(bei_bodega.EditValue));
                cmb_producto.DataSource = lst_producto;
            }
            catch (Exception ex)
            {
            }
            
        }
    }
}
