namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_Devolucion_x_NotaCredito_mant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.gridControlProductos = new DevExpress.XtraGrid.GridControl();
            this.gridViewProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProducto_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_precio_publico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_pedidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_ManejaIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_costo_promedio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_peso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_cantidad_sin_conversion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_cantidad_convertida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmv_costo_sin_conversion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmv_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCosto_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCentroCosto_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCentroCosto_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPunto_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbPuntoCargo_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPunto_cargo_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_punto_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdRegistro_subcentro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_subcentrocosto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IdCentroCosto_sub_centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_unidad_medida_convertida = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUnidadMedida_sinConversion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_unidad_medida = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.collIdCentroCosto_sub_centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_grupo_pto_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Punto_cargo_grupo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPunto_cargo_grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_punto_cargo_grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.tablapedidodetInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inProductoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtidDev = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblAutorizacion = new System.Windows.Forms.Label();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodDev = new System.Windows.Forms.TextBox();
            this.faDocumentoTipoinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.UCSucursal = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.UCCliente = new Core.Erp.Winform.Controles.UCFa_Cliente_Facturacion();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.gridControlDocumentosRelacionados = new DevExpress.XtraGrid.GridControl();
            this.gridViewDocumentosRelacionados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.cmbTipoMovi = new Core.Erp.Winform.Controles.UCIn_TipoMoviInv_Cmb();
            this.cmbMotivoInv = new Core.Erp.Winform.Controles.UCIn_MotivoInvCmb();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroCosto_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPuntoCargo_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_subcentrocosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_unidad_medida_convertida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_unidad_medida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Punto_cargo_grupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablapedidodetInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProductoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faDocumentoTipoinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDocumentosRelacionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDocumentosRelacionados)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 268);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.xtraScrollableControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(949, 242);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.gridControlProductos);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(3, 3);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(943, 236);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // gridControlProductos
            // 
            this.gridControlProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProductos.Location = new System.Drawing.Point(0, 0);
            this.gridControlProductos.MainView = this.gridViewProductos;
            this.gridControlProductos.Name = "gridControlProductos";
            this.gridControlProductos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbProducto_grid,
            this.cmbCentroCosto_grid,
            this.cmbPuntoCargo_grid,
            this.repositoryItemImageEdit1,
            this.cmb_subcentrocosto,
            this.cmb_unidad_medida,
            this.cmb_unidad_medida_convertida,
            this.cmb_Punto_cargo_grupo});
            this.gridControlProductos.Size = new System.Drawing.Size(943, 236);
            this.gridControlProductos.TabIndex = 1;
            this.gridControlProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductos});
            // 
            // gridViewProductos
            // 
            this.gridViewProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSecuencia,
            this.colIdProducto,
            this.coldm_cantidad_sin_conversion,
            this.coldm_cantidad_convertida,
            this.colmv_costo_sin_conversion,
            this.colmv_costo,
            this.coldm_observacion,
            this.colIdCentroCosto_grid,
            this.colIdPunto_cargo,
            this.colIdRegistro_subcentro,
            this.col_IdUnidadMedida,
            this.colIdUnidadMedida_sinConversion,
            this.collIdCentroCosto_sub_centro_costo,
            this.col_grupo_pto_cargo});
            this.gridViewProductos.CustomizationFormBounds = new System.Drawing.Rectangle(796, 401, 216, 192);
            this.gridViewProductos.GridControl = this.gridControlProductos;
            this.gridViewProductos.Name = "gridViewProductos";
            this.gridViewProductos.OptionsView.ShowGroupPanel = false;
            this.gridViewProductos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridViewProductos_KeyUp);
            // 
            // colSecuencia
            // 
            this.colSecuencia.Caption = "Secuencia";
            this.colSecuencia.FieldName = "Secuencia";
            this.colSecuencia.Name = "colSecuencia";
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "Producto";
            this.colIdProducto.ColumnEdit = this.cmbProducto_grid;
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 0;
            this.colIdProducto.Width = 322;
            // 
            // cmbProducto_grid
            // 
            this.cmbProducto_grid.AutoHeight = false;
            this.cmbProducto_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProducto_grid.DisplayMember = "pr_descripcion";
            this.cmbProducto_grid.Name = "cmbProducto_grid";
            this.cmbProducto_grid.ValueMember = "IdProducto";
            this.cmbProducto_grid.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto_cmbgrid,
            this.colpr_codigo_cmbgrid,
            this.colpr_descripcion,
            this.colpr_precio_publico,
            this.colpr_stock,
            this.colpr_pedidos,
            this.colpr_ManejaIva,
            this.colpr_costo_promedio,
            this.colpr_peso});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProducto_cmbgrid
            // 
            this.colIdProducto_cmbgrid.Caption = "IdProducto";
            this.colIdProducto_cmbgrid.FieldName = "IdProducto";
            this.colIdProducto_cmbgrid.Name = "colIdProducto_cmbgrid";
            this.colIdProducto_cmbgrid.Visible = true;
            this.colIdProducto_cmbgrid.VisibleIndex = 2;
            this.colIdProducto_cmbgrid.Width = 98;
            // 
            // colpr_codigo_cmbgrid
            // 
            this.colpr_codigo_cmbgrid.Caption = "Código";
            this.colpr_codigo_cmbgrid.FieldName = "pr_codigo";
            this.colpr_codigo_cmbgrid.Name = "colpr_codigo_cmbgrid";
            this.colpr_codigo_cmbgrid.Visible = true;
            this.colpr_codigo_cmbgrid.VisibleIndex = 1;
            this.colpr_codigo_cmbgrid.Width = 102;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "Descripción";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 0;
            this.colpr_descripcion.Width = 287;
            // 
            // colpr_precio_publico
            // 
            this.colpr_precio_publico.Caption = "P.V.P.";
            this.colpr_precio_publico.FieldName = "pr_precio_publico";
            this.colpr_precio_publico.Name = "colpr_precio_publico";
            this.colpr_precio_publico.Visible = true;
            this.colpr_precio_publico.VisibleIndex = 3;
            this.colpr_precio_publico.Width = 77;
            // 
            // colpr_stock
            // 
            this.colpr_stock.Caption = "Stock";
            this.colpr_stock.FieldName = "pr_stock_Bodega";
            this.colpr_stock.Name = "colpr_stock";
            this.colpr_stock.Visible = true;
            this.colpr_stock.VisibleIndex = 4;
            this.colpr_stock.Width = 101;
            // 
            // colpr_pedidos
            // 
            this.colpr_pedidos.Caption = "Pedidos";
            this.colpr_pedidos.FieldName = "pr_pedidos";
            this.colpr_pedidos.Name = "colpr_pedidos";
            this.colpr_pedidos.Visible = true;
            this.colpr_pedidos.VisibleIndex = 5;
            this.colpr_pedidos.Width = 101;
            // 
            // colpr_ManejaIva
            // 
            this.colpr_ManejaIva.Caption = "Maneja Iva";
            this.colpr_ManejaIva.FieldName = "pr_ManejaIva";
            this.colpr_ManejaIva.Name = "colpr_ManejaIva";
            this.colpr_ManejaIva.Visible = true;
            this.colpr_ManejaIva.VisibleIndex = 6;
            this.colpr_ManejaIva.Width = 101;
            // 
            // colpr_costo_promedio
            // 
            this.colpr_costo_promedio.Caption = "Costo";
            this.colpr_costo_promedio.FieldName = "pr_costo_promedio";
            this.colpr_costo_promedio.Name = "colpr_costo_promedio";
            this.colpr_costo_promedio.Visible = true;
            this.colpr_costo_promedio.VisibleIndex = 7;
            this.colpr_costo_promedio.Width = 101;
            // 
            // colpr_peso
            // 
            this.colpr_peso.Caption = "Peso";
            this.colpr_peso.FieldName = "pr_peso";
            this.colpr_peso.Name = "colpr_peso";
            this.colpr_peso.Visible = true;
            this.colpr_peso.VisibleIndex = 8;
            this.colpr_peso.Width = 101;
            // 
            // coldm_cantidad_sin_conversion
            // 
            this.coldm_cantidad_sin_conversion.Caption = "Cantidad";
            this.coldm_cantidad_sin_conversion.FieldName = "dm_cantidad_sinConversion";
            this.coldm_cantidad_sin_conversion.Name = "coldm_cantidad_sin_conversion";
            this.coldm_cantidad_sin_conversion.Visible = true;
            this.coldm_cantidad_sin_conversion.VisibleIndex = 2;
            this.coldm_cantidad_sin_conversion.Width = 110;
            // 
            // coldm_cantidad_convertida
            // 
            this.coldm_cantidad_convertida.Caption = "Cantidad convertida";
            this.coldm_cantidad_convertida.FieldName = "dm_cantidad";
            this.coldm_cantidad_convertida.Name = "coldm_cantidad_convertida";
            this.coldm_cantidad_convertida.OptionsColumn.AllowEdit = false;
            this.coldm_cantidad_convertida.Width = 154;
            // 
            // colmv_costo_sin_conversion
            // 
            this.colmv_costo_sin_conversion.Caption = "Costo";
            this.colmv_costo_sin_conversion.FieldName = "mv_costo_sinConversion";
            this.colmv_costo_sin_conversion.Name = "colmv_costo_sin_conversion";
            this.colmv_costo_sin_conversion.Width = 110;
            // 
            // colmv_costo
            // 
            this.colmv_costo.Caption = "Costo convertido";
            this.colmv_costo.FieldName = "mv_costo";
            this.colmv_costo.Name = "colmv_costo";
            this.colmv_costo.OptionsColumn.AllowEdit = false;
            this.colmv_costo.Width = 133;
            // 
            // coldm_observacion
            // 
            this.coldm_observacion.Caption = "Observación por Producto";
            this.coldm_observacion.FieldName = "dm_observacion";
            this.coldm_observacion.Name = "coldm_observacion";
            this.coldm_observacion.Width = 202;
            // 
            // colIdCentroCosto_grid
            // 
            this.colIdCentroCosto_grid.Caption = "Centro de Costo";
            this.colIdCentroCosto_grid.ColumnEdit = this.cmbCentroCosto_grid;
            this.colIdCentroCosto_grid.FieldName = "IdCentroCosto";
            this.colIdCentroCosto_grid.Name = "colIdCentroCosto_grid";
            this.colIdCentroCosto_grid.Visible = true;
            this.colIdCentroCosto_grid.VisibleIndex = 3;
            this.colIdCentroCosto_grid.Width = 126;
            // 
            // cmbCentroCosto_grid
            // 
            this.cmbCentroCosto_grid.AutoHeight = false;
            this.cmbCentroCosto_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCentroCosto_grid.DisplayMember = "Centro_costo2";
            this.cmbCentroCosto_grid.Name = "cmbCentroCosto_grid";
            this.cmbCentroCosto_grid.ValueMember = "IdCentroCosto";
            this.cmbCentroCosto_grid.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCentroCosto_cmbgrid,
            this.colCentro_costo,
            this.colpc_Estado});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCentroCosto_cmbgrid
            // 
            this.colIdCentroCosto_cmbgrid.Caption = "Código";
            this.colIdCentroCosto_cmbgrid.FieldName = "IdCentroCosto";
            this.colIdCentroCosto_cmbgrid.Name = "colIdCentroCosto_cmbgrid";
            this.colIdCentroCosto_cmbgrid.Visible = true;
            this.colIdCentroCosto_cmbgrid.VisibleIndex = 1;
            this.colIdCentroCosto_cmbgrid.Width = 179;
            // 
            // colCentro_costo
            // 
            this.colCentro_costo.Caption = "Descripción";
            this.colCentro_costo.FieldName = "Centro_costo";
            this.colCentro_costo.Name = "colCentro_costo";
            this.colCentro_costo.Visible = true;
            this.colCentro_costo.VisibleIndex = 0;
            this.colCentro_costo.Width = 820;
            // 
            // colpc_Estado
            // 
            this.colpc_Estado.Caption = "Estado";
            this.colpc_Estado.FieldName = "pc_Estado";
            this.colpc_Estado.Name = "colpc_Estado";
            this.colpc_Estado.Visible = true;
            this.colpc_Estado.VisibleIndex = 2;
            this.colpc_Estado.Width = 181;
            // 
            // colIdPunto_cargo
            // 
            this.colIdPunto_cargo.Caption = "Punto Cargo";
            this.colIdPunto_cargo.ColumnEdit = this.cmbPuntoCargo_grid;
            this.colIdPunto_cargo.FieldName = "IdPunto_cargo";
            this.colIdPunto_cargo.Name = "colIdPunto_cargo";
            this.colIdPunto_cargo.Width = 58;
            // 
            // cmbPuntoCargo_grid
            // 
            this.cmbPuntoCargo_grid.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmbPuntoCargo_grid.AutoHeight = false;
            this.cmbPuntoCargo_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPuntoCargo_grid.DisplayMember = "nom_punto_cargo";
            this.cmbPuntoCargo_grid.Name = "cmbPuntoCargo_grid";
            this.cmbPuntoCargo_grid.ReadOnly = true;
            this.cmbPuntoCargo_grid.ValueMember = "IdPunto_cargo";
            this.cmbPuntoCargo_grid.View = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPunto_cargo_cmbgrid,
            this.colnom_punto_cargo});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colIdPunto_cargo_cmbgrid
            // 
            this.colIdPunto_cargo_cmbgrid.Caption = "Código";
            this.colIdPunto_cargo_cmbgrid.FieldName = "IdPunto_cargo";
            this.colIdPunto_cargo_cmbgrid.Name = "colIdPunto_cargo_cmbgrid";
            this.colIdPunto_cargo_cmbgrid.Visible = true;
            this.colIdPunto_cargo_cmbgrid.VisibleIndex = 1;
            this.colIdPunto_cargo_cmbgrid.Width = 293;
            // 
            // colnom_punto_cargo
            // 
            this.colnom_punto_cargo.Caption = "Nombre";
            this.colnom_punto_cargo.FieldName = "nom_punto_cargo";
            this.colnom_punto_cargo.Name = "colnom_punto_cargo";
            this.colnom_punto_cargo.Visible = true;
            this.colnom_punto_cargo.VisibleIndex = 0;
            this.colnom_punto_cargo.Width = 887;
            // 
            // colIdRegistro_subcentro
            // 
            this.colIdRegistro_subcentro.Caption = "Subcentro de costo";
            this.colIdRegistro_subcentro.ColumnEdit = this.cmb_subcentrocosto;
            this.colIdRegistro_subcentro.FieldName = "IdRegistro";
            this.colIdRegistro_subcentro.Name = "colIdRegistro_subcentro";
            this.colIdRegistro_subcentro.Visible = true;
            this.colIdRegistro_subcentro.VisibleIndex = 4;
            this.colIdRegistro_subcentro.Width = 121;
            // 
            // cmb_subcentrocosto
            // 
            this.cmb_subcentrocosto.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_subcentrocosto.AutoHeight = false;
            this.cmb_subcentrocosto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_subcentrocosto.DisplayMember = "Centro_costo2";
            this.cmb_subcentrocosto.Name = "cmb_subcentrocosto";
            this.cmb_subcentrocosto.ReadOnly = true;
            this.cmb_subcentrocosto.ValueMember = "IdRegistro";
            this.cmb_subcentrocosto.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IdCentroCosto_sub_centro_costo,
            this.col_Centro_costo});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // col_IdCentroCosto_sub_centro_costo
            // 
            this.col_IdCentroCosto_sub_centro_costo.Caption = "ID";
            this.col_IdCentroCosto_sub_centro_costo.FieldName = "IdCentroCosto_sub_centro_costo";
            this.col_IdCentroCosto_sub_centro_costo.Name = "col_IdCentroCosto_sub_centro_costo";
            this.col_IdCentroCosto_sub_centro_costo.Visible = true;
            this.col_IdCentroCosto_sub_centro_costo.VisibleIndex = 1;
            this.col_IdCentroCosto_sub_centro_costo.Width = 76;
            // 
            // col_Centro_costo
            // 
            this.col_Centro_costo.Caption = "Descripción";
            this.col_Centro_costo.FieldName = "Centro_costo";
            this.col_Centro_costo.Name = "col_Centro_costo";
            this.col_Centro_costo.Visible = true;
            this.col_Centro_costo.VisibleIndex = 0;
            this.col_Centro_costo.Width = 1104;
            // 
            // col_IdUnidadMedida
            // 
            this.col_IdUnidadMedida.Caption = "IdUnidadMedida convertida";
            this.col_IdUnidadMedida.ColumnEdit = this.cmb_unidad_medida_convertida;
            this.col_IdUnidadMedida.FieldName = "IdUnidadMedida";
            this.col_IdUnidadMedida.Name = "col_IdUnidadMedida";
            this.col_IdUnidadMedida.OptionsColumn.AllowEdit = false;
            this.col_IdUnidadMedida.OptionsColumn.ReadOnly = true;
            this.col_IdUnidadMedida.Width = 140;
            // 
            // cmb_unidad_medida_convertida
            // 
            this.cmb_unidad_medida_convertida.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_unidad_medida_convertida.AutoHeight = false;
            this.cmb_unidad_medida_convertida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_unidad_medida_convertida.DisplayMember = "Descripcion2";
            this.cmb_unidad_medida_convertida.Name = "cmb_unidad_medida_convertida";
            this.cmb_unidad_medida_convertida.ReadOnly = true;
            this.cmb_unidad_medida_convertida.ValueMember = "IdUnidadMedida";
            this.cmb_unidad_medida_convertida.View = this.gridView5;
            // 
            // gridView5
            // 
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colIdUnidadMedida_sinConversion
            // 
            this.colIdUnidadMedida_sinConversion.Caption = "Unidad medida";
            this.colIdUnidadMedida_sinConversion.ColumnEdit = this.cmb_unidad_medida;
            this.colIdUnidadMedida_sinConversion.FieldName = "IdUnidadMedida_sinConversion";
            this.colIdUnidadMedida_sinConversion.Name = "colIdUnidadMedida_sinConversion";
            this.colIdUnidadMedida_sinConversion.OptionsColumn.AllowEdit = false;
            this.colIdUnidadMedida_sinConversion.OptionsColumn.ReadOnly = true;
            this.colIdUnidadMedida_sinConversion.Visible = true;
            this.colIdUnidadMedida_sinConversion.VisibleIndex = 1;
            this.colIdUnidadMedida_sinConversion.Width = 104;
            // 
            // cmb_unidad_medida
            // 
            this.cmb_unidad_medida.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_unidad_medida.AutoHeight = false;
            this.cmb_unidad_medida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_unidad_medida.DisplayMember = "Descripcion2";
            this.cmb_unidad_medida.Name = "cmb_unidad_medida";
            this.cmb_unidad_medida.ReadOnly = true;
            this.cmb_unidad_medida.ValueMember = "IdUnidadMedida";
            this.cmb_unidad_medida.View = this.gridView6;
            // 
            // gridView6
            // 
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // collIdCentroCosto_sub_centro_costo
            // 
            this.collIdCentroCosto_sub_centro_costo.Caption = "IdSubcentro";
            this.collIdCentroCosto_sub_centro_costo.FieldName = "IdCentroCosto_sub_centro_costo";
            this.collIdCentroCosto_sub_centro_costo.Name = "collIdCentroCosto_sub_centro_costo";
            this.collIdCentroCosto_sub_centro_costo.OptionsColumn.AllowEdit = false;
            // 
            // col_grupo_pto_cargo
            // 
            this.col_grupo_pto_cargo.Caption = "Grupo";
            this.col_grupo_pto_cargo.ColumnEdit = this.cmb_Punto_cargo_grupo;
            this.col_grupo_pto_cargo.FieldName = "IdPunto_cargo_grupo";
            this.col_grupo_pto_cargo.Name = "col_grupo_pto_cargo";
            // 
            // cmb_Punto_cargo_grupo
            // 
            this.cmb_Punto_cargo_grupo.AutoHeight = false;
            this.cmb_Punto_cargo_grupo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Punto_cargo_grupo.DisplayMember = "nom_punto_cargo_grupo";
            this.cmb_Punto_cargo_grupo.Name = "cmb_Punto_cargo_grupo";
            this.cmb_Punto_cargo_grupo.ValueMember = "IdPunto_cargo_grupo";
            this.cmb_Punto_cargo_grupo.View = this.gridView7;
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPunto_cargo_grupo,
            this.colnom_punto_cargo_grupo});
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // colIdPunto_cargo_grupo
            // 
            this.colIdPunto_cargo_grupo.Caption = "IdPuntoCargo";
            this.colIdPunto_cargo_grupo.FieldName = "IdPunto_cargo_grupo";
            this.colIdPunto_cargo_grupo.Name = "colIdPunto_cargo_grupo";
            this.colIdPunto_cargo_grupo.Visible = true;
            this.colIdPunto_cargo_grupo.VisibleIndex = 0;
            // 
            // colnom_punto_cargo_grupo
            // 
            this.colnom_punto_cargo_grupo.Caption = "Grupo";
            this.colnom_punto_cargo_grupo.FieldName = "nom_punto_cargo_grupo";
            this.colnom_punto_cargo_grupo.Name = "colnom_punto_cargo_grupo";
            this.colnom_punto_cargo_grupo.Visible = true;
            this.colnom_punto_cargo_grupo.VisibleIndex = 1;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // inProductoInfoBindingSource
            // 
            this.inProductoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Inventario.in_Producto_Info);
            // 
            // txtidDev
            // 
            this.txtidDev.Location = new System.Drawing.Point(95, 10);
            this.txtidDev.Name = "txtidDev";
            this.txtidDev.ReadOnly = true;
            this.txtidDev.Size = new System.Drawing.Size(70, 20);
            this.txtidDev.TabIndex = 3;
            this.txtidDev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Id. Devolucion:";
            // 
            // lblAutorizacion
            // 
            this.lblAutorizacion.AutoSize = true;
            this.lblAutorizacion.Location = new System.Drawing.Point(757, -35);
            this.lblAutorizacion.Name = "lblAutorizacion";
            this.lblAutorizacion.Size = new System.Drawing.Size(31, 13);
            this.lblAutorizacion.TabIndex = 25;
            this.lblAutorizacion.Text = "0000";
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAnulado.Location = new System.Drawing.Point(474, 9);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(242, 24);
            this.lblAnulado.TabIndex = 0;
            this.lblAnulado.Text = "** Devolucion Anulada **";
            this.lblAnulado.Visible = false;
            // 
            // dateFecha
            // 
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha.Location = new System.Drawing.Point(829, 11);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(82, 20);
            this.dateFecha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(774, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cod. Devolucion:";
            // 
            // txtCodDev
            // 
            this.txtCodDev.Location = new System.Drawing.Point(301, 10);
            this.txtCodDev.MaxLength = 20;
            this.txtCodDev.Name = "txtCodDev";
            this.txtCodDev.Size = new System.Drawing.Size(91, 20);
            this.txtCodDev.TabIndex = 3;
            this.txtCodDev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // faDocumentoTipoinfoBindingSource
            // 
            this.faDocumentoTipoinfoBindingSource.DataSource = typeof(Core.Erp.Info.Facturacion.fa_Documento_Tipo_info);
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bnRetImprimir = true;
            this.ucGe_Menu.Enabled_bntAnular = true;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = true;
            this.ucGe_Menu.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Enabled_btnEstadosOC = true;
            this.ucGe_Menu.Enabled_btnGuardar = true;
            this.ucGe_Menu.Enabled_btnImpFrm = true;
            this.ucGe_Menu.Enabled_btnImpLote = true;
            this.ucGe_Menu.Enabled_btnImpRep = true;
            this.ucGe_Menu.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu.Enabled_btnproductos = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(961, 29);
            this.ucGe_Menu.TabIndex = 36;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = true;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_Actualizar = false;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnContabilizar = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // UCSucursal
            // 
            this.UCSucursal.Location = new System.Drawing.Point(13, 34);
            this.UCSucursal.Name = "UCSucursal";
            this.UCSucursal.Size = new System.Drawing.Size(462, 53);
            this.UCSucursal.TabIndex = 37;
            this.UCSucursal.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.todos;
            this.UCSucursal.Visible_cmb_bodega = true;
            this.UCSucursal.Event_cmb_bodega1_EditValueChanged += new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega.delegate_cmb_bodega1_EditValueChanged(this.UCSucursal_Event_cmb_bodega1_EditValueChanged);
            // 
            // UCCliente
            // 
            this.UCCliente.Location = new System.Drawing.Point(10, 84);
            this.UCCliente.Name = "UCCliente";
            this.UCCliente.Size = new System.Drawing.Size(368, 32);
            this.UCCliente.TabIndex = 38;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(477, 39);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(477, 211);
            this.xtraTabControl1.TabIndex = 39;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.splitContainerControl2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(471, 183);
            this.xtraTabPage1.Text = "Documento Relacionados";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.gridControlDocumentosRelacionados);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(471, 183);
            this.splitContainerControl2.SplitterPosition = 23;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(471, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Core.Erp.Winform.Properties.Resources.Buscar_16x16;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(128, 22);
            this.toolStripButton1.Text = "Buscar Documento";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // gridControlDocumentosRelacionados
            // 
            this.gridControlDocumentosRelacionados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDocumentosRelacionados.Location = new System.Drawing.Point(0, 0);
            this.gridControlDocumentosRelacionados.MainView = this.gridViewDocumentosRelacionados;
            this.gridControlDocumentosRelacionados.Name = "gridControlDocumentosRelacionados";
            this.gridControlDocumentosRelacionados.Size = new System.Drawing.Size(471, 155);
            this.gridControlDocumentosRelacionados.TabIndex = 0;
            this.gridControlDocumentosRelacionados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDocumentosRelacionados});
            // 
            // gridViewDocumentosRelacionados
            // 
            this.gridViewDocumentosRelacionados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridViewDocumentosRelacionados.GridControl = this.gridControlDocumentosRelacionados;
            this.gridViewDocumentosRelacionados.Name = "gridViewDocumentosRelacionados";
            this.gridViewDocumentosRelacionados.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewDocumentosRelacionados.OptionsView.ShowGroupPanel = false;
            this.gridViewDocumentosRelacionados.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridViewDocumentosRelacionados_KeyUp);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "IdNota";
            this.gridColumn3.FieldName = "IdNota";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 119;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Documento";
            this.gridColumn4.FieldName = "Documento";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 177;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Observacion";
            this.gridColumn5.FieldName = "sc_observacion";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 773;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(463, 50);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Observacion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtObservacion);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(457, 44);
            this.panel4.TabIndex = 12;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservacion.Location = new System.Drawing.Point(0, 0);
            this.txtObservacion.MaxLength = 1000;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(457, 44);
            this.txtObservacion.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(4, 174);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(471, 76);
            this.tabControl2.TabIndex = 30;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 29);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.cmbTipoMovi);
            this.splitContainerControl1.Panel1.Controls.Add(this.cmbMotivoInv);
            this.splitContainerControl1.Panel1.Controls.Add(this.label5);
            this.splitContainerControl1.Panel1.Controls.Add(this.label7);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtidDev);
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.tabControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.lblAnulado);
            this.splitContainerControl1.Panel1.Controls.Add(this.UCCliente);
            this.splitContainerControl1.Panel1.Controls.Add(this.label18);
            this.splitContainerControl1.Panel1.Controls.Add(this.UCSucursal);
            this.splitContainerControl1.Panel1.Controls.Add(this.label2);
            this.splitContainerControl1.Panel1.Controls.Add(this.dateFecha);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtCodDev);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(961, 528);
            this.splitContainerControl1.SplitterPosition = 251;
            this.splitContainerControl1.TabIndex = 40;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // cmbTipoMovi
            // 
            this.cmbTipoMovi.Location = new System.Drawing.Point(72, 111);
            this.cmbTipoMovi.Name = "cmbTipoMovi";
            this.cmbTipoMovi.Size = new System.Drawing.Size(293, 28);
            this.cmbTipoMovi.TabIndex = 43;
            this.cmbTipoMovi.Visible_buton_Acciones = true;
            // 
            // cmbMotivoInv
            // 
            this.cmbMotivoInv.Location = new System.Drawing.Point(72, 142);
            this.cmbMotivoInv.Name = "cmbMotivoInv";
            this.cmbMotivoInv.Size = new System.Drawing.Size(346, 26);
            this.cmbMotivoInv.TabIndex = 42;
            this.cmbMotivoInv.Tipo_Ing_Egr = ein_Tipo_Ing_Egr.ING;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Concepto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Motivo Inv:";
            // 
            // frmFa_Devolucion_x_NotaCredito_mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(961, 557);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.lblAutorizacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmFa_Devolucion_x_NotaCredito_mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFA_devol_venta_FormClosing);
            this.Load += new System.EventHandler(this.frmFA_devol_venta_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroCosto_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPuntoCargo_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_subcentrocosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_unidad_medida_convertida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_unidad_medida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Punto_cargo_grupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablapedidodetInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProductoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faDocumentoTipoinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDocumentosRelacionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDocumentosRelacionados)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingSource faDocumentoTipoinfoBindingSource;
        private System.Windows.Forms.Label lblAutorizacion;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox txtidDev;
        public System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCodDev;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private System.Windows.Forms.BindingSource tablapedidodetInfoBindingSource;
        private System.Windows.Forms.BindingSource inProductoInfoBindingSource;
        private Controles.UCIn_Sucursal_Bodega UCSucursal;
        private Controles.UCFa_Cliente_Facturacion UCCliente;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.TabControl tabControl2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraGrid.GridControl gridControlDocumentosRelacionados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDocumentosRelacionados;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private Controles.UCIn_TipoMoviInv_Cmb cmbTipoMovi;
        private Controles.UCIn_MotivoInvCmb cmbMotivoInv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.GridControl gridControlProductos;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewProductos;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        public DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbProducto_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_precio_publico;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_stock;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_pedidos;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_ManejaIva;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_costo_promedio;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_peso;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_cantidad_sin_conversion;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_cantidad_convertida;
        private DevExpress.XtraGrid.Columns.GridColumn colmv_costo_sin_conversion;
        private DevExpress.XtraGrid.Columns.GridColumn colmv_costo;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto_grid;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbCentroCosto_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Estado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPunto_cargo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbPuntoCargo_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPunto_cargo_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_punto_cargo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRegistro_subcentro;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_subcentrocosto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdCentroCosto_sub_centro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn col_Centro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdUnidadMedida;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_unidad_medida_convertida;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidadMedida_sinConversion;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_unidad_medida;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn collIdCentroCosto_sub_centro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn col_grupo_pto_cargo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_Punto_cargo_grupo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPunto_cargo_grupo;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_punto_cargo_grupo;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
    }
}