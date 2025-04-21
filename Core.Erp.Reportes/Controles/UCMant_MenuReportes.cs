using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using DevExpress.XtraEditors.Controls;

namespace Core.Erp.Reportes.Controles
{
    public partial class UCMant_MenuReportes : UserControl
    {
        #region Data
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Sucursal_Bus busSucursal = new tb_Sucursal_Bus();
        List<tb_Sucursal_Info> lstSucuInfo = new List<tb_Sucursal_Info>();
        tb_Bodega_Bus busBodega = new tb_Bodega_Bus();
        List<tb_Bodega_Info> lstBodegaInfo = new List<tb_Bodega_Info>();
        in_producto_Bus busProducto = new in_producto_Bus();
        List<in_Producto_Info> lstProductoInfo = new List<in_Producto_Info>();
        in_movi_inven_tipo_Bus busMoviTip = new in_movi_inven_tipo_Bus();
        List<in_movi_inven_tipo_Info> lstMoviTipiInfo = new List<in_movi_inven_tipo_Info>();
        cp_proveedor_Bus busProveedor = new cp_proveedor_Bus();
        List<cp_proveedor_Info> listProveedor = new List<cp_proveedor_Info>();
        cp_proveedor_Info info_proveedor = new cp_proveedor_Info();
        in_linea_Bus BusLinea = new in_linea_Bus();
        List<in_linea_info> ListLinea = new List<in_linea_info>();
        List<ct_Centro_costo_Info> lst_centro_costo = new List<ct_Centro_costo_Info>();
        ct_Centro_costo_Info info_centro_costo = new ct_Centro_costo_Info();
        ct_Centro_costo_Bus bus_centro_costo = new ct_Centro_costo_Bus();
        List<ct_centro_costo_sub_centro_costo_Info> lst_sub_centro_costo = new List<ct_centro_costo_sub_centro_costo_Info>();
        ct_centro_costo_sub_centro_costo_Bus bus_sub_centro_costo = new ct_centro_costo_sub_centro_costo_Bus();
        string MensajeError = "";
        #endregion

        #region Event
        public delegate void delegate_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnConsultar_ItemClick event_tnConsultar_ItemClick;
        public delegate void delegate_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnImprimir_ItemClick event_btnImprimir_ItemClick;
        public delegate void delegate_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e);
        public event delegate_btnSalir_ItemClick event_btnSalir_ItemClick;
        #endregion

        #region Visible_Enable

        public Boolean VisibleGrupoCentroCosto
        {
            get { return this.GrupoCentroCosto.Visible; }
            set { this.GrupoCentroCosto.Visible = value; }
        }

        public Boolean VisibleGrupoCheck
        {
            get { return this.GrupoCheck.Visible; }
            set { this.GrupoCheck.Visible = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisiblebeiCheck1
        {
            get { return this.beiCheck1.Visibility; }
            set { this.beiCheck1.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisiblebeiCheck2
        {
            get { return this.beiCheck2.Visibility; }
            set { this.beiCheck2.Visibility = value; }
        }
        public string CaptionCheck1
        {
            get { return this.beiCheck1.Caption; }
            set { this.beiCheck1.Caption = value; }
        }

        public string CaptionCheck2
        {
            get { return this.beiCheck2.Caption; }
            set { this.beiCheck2.Caption = value; }
        }        

        public Boolean VisibleGrupoSucursal
        {
            get { return this.GrupoSucursal.Visible; }
            set { this.GrupoSucursal.Visible = value; }
        }        
        public Boolean VisibleGrupoFecha
        {
            get { return this.GrupoFecha.Visible; }
            set { this.GrupoFecha.Visible = value; }
        }
        public Boolean VisibleGrupoBotones
        {
            get { return this.GrupoBotones.Visible; }
            set { this.GrupoBotones.Visible = value; }
        }

        public DevExpress.XtraBars.BarItemVisibility VisibleCmbSucursal
        {
            get { return this.cmbSucursal.Visibility; }
            set { this.cmbSucursal.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisibleCmbBodega
        {
            get { return this.cmbBodega.Visibility; }
            set { this.cmbBodega.Visibility = value; }
        }        
        public DevExpress.XtraBars.BarItemVisibility VisibleCmbMaquina
        {
            get { return this.cmbMaquina.Visibility; }
            set { this.cmbMaquina.Visibility = value; }
        }                
        public DevExpress.XtraBars.BarItemVisibility VisibleDtpDesde
        {
            get { return this.dtpDesde.Visibility; }
            set { this.dtpDesde.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisibleDtpHasta
        {
            get { return this.dtpHasta.Visibility; }
            set { this.dtpHasta.Visibility = value; }
        }        
        public DevExpress.XtraBars.BarItemVisibility VisiblebtnConsultar
        {
            get { return this.btnConsultar.Visibility; }
            set { this.btnConsultar.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisiblebtnImprimir
        {
            get { return this.btnImprimir.Visibility; }
            set { this.btnImprimir.Visibility = value; }
        }
        public DevExpress.XtraBars.BarItemVisibility VisiblebtnSalir
        {
            get { return this.btnSalir.Visibility; }
            set { this.btnSalir.Visibility = value; }
        }


        public Boolean EnableBotonImprimir
        {
            get { return this.btnImprimir.Enabled; }
            set { this.btnImprimir.Enabled = value; }
        }

        public Boolean EnableBotonConsultar
        {
            get { return this.btnConsultar.Enabled; }
            set { this.btnConsultar.Enabled = value; }
        }

        public Boolean EnableBotonSalir
        {
            get { return this.btnSalir.Enabled; }
            set { this.btnSalir.Enabled = value; }
        }

        #endregion
        
        public UCMant_MenuReportes()
        {
            InitializeComponent();
            event_btnImprimir_ItemClick += UCMant_MenuReportes_event_btnImprimir_ItemClick;
            event_btnSalir_ItemClick += UCMant_MenuReportes_event_btnSalir_ItemClick;
            event_tnConsultar_ItemClick += UCMant_MenuReportes_event_tnConsultar_ItemClick;
        }

        void UCMant_MenuReportes_event_tnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void UCMant_MenuReportes_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void UCMant_MenuReportes_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }        

        private void Cargar_subcentros_x_centro()
        {
            try
            {
                cmb_subcentro_costo_chk.Items.Clear();
                foreach (var item in lst_sub_centro_costo)
                {
                    cmb_subcentro_costo_chk.Items.Add(item.IdCentroCosto_sub_centro_costo, item.Centro_costo2);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<string> Get_list_sub_centro_chk()
        {
            try
            {
                List<string> Lista = new List<string>();
                foreach (var item in cmb_subcentro_costo_chk.Items.GetCheckedValues())
                {
                    Lista.Add(item.ToString());
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return new List<string>();
            }
        }        

        private void UCMant_MenuReportes_Load(object sender, EventArgs e)
        {
            try
            {
                in_Producto_Info infoProducto = new in_Producto_Info();
                in_movi_inven_tipo_Info infoMoviTipi = new in_movi_inven_tipo_Info();
                cp_proveedor_Info infoProvee = new cp_proveedor_Info();
                in_categorias_Info InfoCategoria = new in_categorias_Info();
                in_linea_info InfoLinea = new in_linea_info();

                dtpDesde.EditValue = DateTime.Now.AddMonths(-1);
                dtpHasta.EditValue = DateTime.Now.AddMonths(1);

                lstSucuInfo = busSucursal.Get_List_Sucursal_Todos(param.IdEmpresa);
                cmbSucursal_Grid.DataSource = lstSucuInfo;

                lstBodegaInfo = busBodega.Get_List_Bodega(param.IdEmpresa, Cl_Enumeradores.eTipoFiltro.todos);
                cmbBodega_Grid.DataSource = lstBodegaInfo;                

                infoProducto.IdProducto = 0;
                infoProducto.pr_descripcion = "Todos";

                infoProvee.IdProveedor = 0;
                infoProvee.pr_nombre = "Todos";

                infoMoviTipi.IdMovi_inven_tipo = 0;
                infoMoviTipi.tm_descripcion = "Todos";

                InfoCategoria.IdCategoria = "";
                InfoCategoria.ca_Categoria = "Todos";

                InfoLinea.IdLinea = 0;
                InfoLinea.nom_linea = "Todos";

                lst_centro_costo = bus_centro_costo.Get_list_Centro_Costo(param.IdEmpresa, ref MensajeError);
                cmb_centro_costo.DataSource = lst_centro_costo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_tnConsultar_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btnImprimir_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                event_btnSalir_ItemClick(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbSucursal_Grid_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbBodega_Grid_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbBodega_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void cmbSucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSucursal.EditValue != null)
                {
                    int idSucursal = Convert.ToInt32(cmbSucursal.EditValue);
                    List<tb_Bodega_Info> Lista_bodega_temp = new List<tb_Bodega_Info>();
                    Lista_bodega_temp = lstBodegaInfo.Where(q => q.IdSucursal == idSucursal || q.IdBodega == 0).ToList();
                    cmbBodega_Grid.DataSource = null;
                    cmbBodega_Grid.DataSource = Lista_bodega_temp;                    
                }
                else
                    cmbBodega_Grid.DataSource = lstBodegaInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public tb_Sucursal_Info Get_info_sucursal()
        {
            try
            {
                tb_Sucursal_Info info_sucursal = new tb_Sucursal_Info();
                if (cmbSucursal.EditValue != null)
                {
                    info_sucursal = lstSucuInfo.FirstOrDefault(q => q.IdSucursal == Convert.ToInt32(cmbSucursal.EditValue));
                }
                else
                    info_sucursal = null;
                return info_sucursal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }

        public tb_Bodega_Info Get_info_bodega()
        {
            try
            {
                tb_Bodega_Info info_bodega = new tb_Bodega_Info();

                if (cmbSucursal.EditValue != null && cmbBodega.EditValue != null)
                {
                    info_bodega = lstBodegaInfo.FirstOrDefault(q => q.IdSucursal == Convert.ToInt32(cmbSucursal.EditValue) && q.IdBodega == Convert.ToInt32(cmbBodega.EditValue));
                }
                else
                    info_bodega = null;
                return info_bodega;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }
      
        public ct_Centro_costo_Info Get_info_centro_costo()
        {
            try
            {
                if (beiCentro_costo.EditValue == null) 
                    return null;
                info_centro_costo = lst_centro_costo.FirstOrDefault(q => q.IdEmpresa == param.IdEmpresa && q.IdCentroCosto == beiCentro_costo.EditValue.ToString());
                return info_centro_costo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }

        private void beiCentro_costo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (beiCentro_costo.EditValue == null)
                    lst_sub_centro_costo = new List<ct_centro_costo_sub_centro_costo_Info>();
                else
                    lst_sub_centro_costo = bus_sub_centro_costo.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa,beiCentro_costo.EditValue.ToString());
                Cargar_subcentros_x_centro();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
       
    }
}
