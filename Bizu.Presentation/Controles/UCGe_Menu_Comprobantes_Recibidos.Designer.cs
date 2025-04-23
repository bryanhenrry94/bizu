namespace Bizu.Presentation.Controles
{
    partial class UCGe_Menu_Comprobantes_Recibidos
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCGe_Menu_Comprobantes_Recibidos));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.beiBuscar = new DevExpress.XtraBars.BarButtonItem();
            this.btnProvisionarFactura = new DevExpress.XtraBars.BarButtonItem();
            this.beiFechaIni = new DevExpress.XtraBars.BarEditItem();
            this.dtpFechaIni = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.beiFechaFin = new DevExpress.XtraBars.BarEditItem();
            this.dtpFechaFin = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.btnAceptar = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.beiTipoComprobante = new DevExpress.XtraBars.BarEditItem();
            this.cmb_TipoComprobante = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Grupo_Filtro = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Grupo_CxP = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Grupo_Acciones = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.beiEstado = new DevExpress.XtraBars.BarEditItem();
            this.cmbEstado = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaIni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaIni.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFin.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_TipoComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.beiBuscar,
            this.btnProvisionarFactura,
            this.beiFechaIni,
            this.beiFechaFin,
            this.btnAceptar,
            this.btnSalir,
            this.btnEliminar,
            this.beiTipoComprobante,
            this.btnImprimir,
            this.beiEstado});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dtpFechaIni,
            this.dtpFechaFin,
            this.cmb_TipoComprobante,
            this.cmbEstado});
            this.ribbonControl1.Size = new System.Drawing.Size(1263, 183);
            // 
            // beiBuscar
            // 
            this.beiBuscar.Caption = "Buscar";
            this.beiBuscar.Id = 1;
            this.beiBuscar.ImageOptions.Image = global::Bizu.Presentation.Properties.Resources.erp_256;
            this.beiBuscar.Name = "beiBuscar";
            this.beiBuscar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.beiBuscar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.beiBuscar_ItemClick);
            // 
            // btnProvisionarFactura
            // 
            this.btnProvisionarFactura.Caption = "Provisionar Factura";
            this.btnProvisionarFactura.Id = 2;
            this.btnProvisionarFactura.ImageOptions.Image = global::Bizu.Presentation.Properties.Resources.erp_256;
            this.btnProvisionarFactura.Name = "btnProvisionarFactura";
            this.btnProvisionarFactura.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnProvisionarFactura.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProvisionarFactura_ItemClick);
            // 
            // beiFechaIni
            // 
            this.beiFechaIni.Caption = "Desde:                   ";
            this.beiFechaIni.Edit = this.dtpFechaIni;
            this.beiFechaIni.EditWidth = 100;
            this.beiFechaIni.Id = 3;
            this.beiFechaIni.Name = "beiFechaIni";
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.AutoHeight = false;
            this.dtpFechaIni.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaIni.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaIni.Name = "dtpFechaIni";
            // 
            // beiFechaFin
            // 
            this.beiFechaFin.Caption = "Hasta:                    ";
            this.beiFechaFin.Edit = this.dtpFechaFin;
            this.beiFechaFin.EditWidth = 100;
            this.beiFechaFin.Id = 4;
            this.beiFechaFin.Name = "beiFechaFin";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.AutoHeight = false;
            this.dtpFechaFin.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaFin.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaFin.Name = "dtpFechaFin";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Caption = "Aceptar";
            this.btnAceptar.Id = 5;
            this.btnAceptar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.ImageOptions.Image")));
            this.btnAceptar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.ImageOptions.LargeImage")));
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnAceptar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAceptar_ItemClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 6;
            this.btnSalir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSalir.ImageOptions.SvgImage")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 7;
            this.btnEliminar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEliminar.ImageOptions.SvgImage")));
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminar_ItemClick);
            // 
            // beiTipoComprobante
            // 
            this.beiTipoComprobante.Caption = "Tipo Comprobante:";
            this.beiTipoComprobante.Edit = this.cmb_TipoComprobante;
            this.beiTipoComprobante.EditWidth = 150;
            this.beiTipoComprobante.Id = 8;
            this.beiTipoComprobante.Name = "beiTipoComprobante";
            // 
            // cmb_TipoComprobante
            // 
            this.cmb_TipoComprobante.AutoHeight = false;
            this.cmb_TipoComprobante.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_TipoComprobante.DisplayMember = "NombreTipoDocumento";
            this.cmb_TipoComprobante.Name = "cmb_TipoComprobante";
            this.cmb_TipoComprobante.PopupView = this.repositoryItemSearchLookUpEdit1View;
            this.cmb_TipoComprobante.ValueMember = "TipoDocumento";
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tipo Documento";
            this.gridColumn1.FieldName = "TipoDocumento";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 207;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nombre";
            this.gridColumn2.FieldName = "NombreTipoDocumento";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 485;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Caption = "Imprimir";
            this.btnImprimir.Id = 9;
            this.btnImprimir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnImprimir.ImageOptions.SvgImage")));
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnImprimir_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Grupo_Filtro,
            this.Grupo_CxP,
            this.Grupo_Acciones});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Accion";
            // 
            // Grupo_Filtro
            // 
            this.Grupo_Filtro.ItemLinks.Add(this.beiFechaIni);
            this.Grupo_Filtro.ItemLinks.Add(this.beiFechaFin);
            this.Grupo_Filtro.ItemLinks.Add(this.beiTipoComprobante);
            this.Grupo_Filtro.ItemLinks.Add(this.beiEstado);
            this.Grupo_Filtro.ItemLinks.Add(this.beiBuscar);
            this.Grupo_Filtro.Name = "Grupo_Filtro";
            this.Grupo_Filtro.Text = "Filtros";
            // 
            // Grupo_CxP
            // 
            this.Grupo_CxP.ItemLinks.Add(this.btnProvisionarFactura);
            this.Grupo_CxP.Name = "Grupo_CxP";
            this.Grupo_CxP.Text = "Cuentas x Pagar";
            // 
            // Grupo_Acciones
            // 
            this.Grupo_Acciones.ItemLinks.Add(this.btnAceptar);
            this.Grupo_Acciones.ItemLinks.Add(this.btnImprimir);
            this.Grupo_Acciones.ItemLinks.Add(this.btnEliminar);
            this.Grupo_Acciones.ItemLinks.Add(this.btnSalir);
            this.Grupo_Acciones.Name = "Grupo_Acciones";
            this.Grupo_Acciones.Text = "Acciones";
            // 
            // beiEstado
            // 
            this.beiEstado.Caption = "Estado";
            this.beiEstado.Edit = this.cmbEstado;
            this.beiEstado.EditWidth = 150;
            this.beiEstado.Id = 10;
            this.beiEstado.Name = "beiEstado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.AutoHeight = false;
            this.cmbEstado.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.DisplayMember = "Descripcion";
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.PopupView = this.gridView1;
            this.cmbEstado.ValueMember = "Descripcion";
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // UCGe_Menu_Comprobantes_Recibidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCGe_Menu_Comprobantes_Recibidos";
            this.Size = new System.Drawing.Size(1263, 180);
            this.Load += new System.EventHandler(this.UCGe_Menu_Comprobantes_Recibidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaIni.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaIni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFin.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_TipoComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Grupo_Filtro;
        private DevExpress.XtraBars.BarButtonItem beiBuscar;
        private DevExpress.XtraBars.BarButtonItem btnProvisionarFactura;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Grupo_CxP;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dtpFechaIni;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dtpFechaFin;
        private DevExpress.XtraBars.BarButtonItem btnAceptar;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Grupo_Acciones;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        public DevExpress.XtraBars.BarEditItem beiFechaIni;
        public DevExpress.XtraBars.BarEditItem beiFechaFin;
        public DevExpress.XtraBars.BarEditItem beiTipoComprobante;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_TipoComprobante;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraBars.BarButtonItem btnImprimir;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbEstado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraBars.BarEditItem beiEstado;
    }
}
