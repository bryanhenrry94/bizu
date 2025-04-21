namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Ingreso_x_GuiaRemision_Mant
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
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gridControlIngreso = new DevExpress.XtraGrid.GridControl();
            this.gridViewIngreso = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IdCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCentroCosto_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCentroCosto_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costo_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NumGuia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Secuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Checked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pr_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_detalle_x_tiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdEntidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pe_nombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Fecha_registro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_dm_precio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cantidad_GR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pr_peso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cantidad_sinConversion_GR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_dm_cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Saldo_GR_x_Ing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Saldo_GR_x_Ing_AUX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_unidad_medida = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUnidadMedida1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdTipoConsumo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NomProyecto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbPuntoCargo_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPunto_cargo_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_punto_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_sub_centro_costo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_grupo_punto_cargo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkTodos = new DevExpress.XtraEditors.CheckEdit();
            this.btn_imprimir = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1 = new Core.Erp.Winform.Controles.UCInv_GridCbte_Cble_x_Ing_Egr_Inv();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_serie2 = new DevExpress.XtraEditors.TextEdit();
            this.txt_serie1 = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_secuencia = new DevExpress.XtraEditors.TextEdit();
            this.cmbMotivoInv = new Core.Erp.Winform.Controles.UCIn_MotivoInvCmb();
            this.cmbTipoMovi = new Core.Erp.Winform.Controles.UCIn_TipoMoviInv_Cmb();
            this.ucIn_Sucursal_Bodega1 = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_cargar_datos = new DevExpress.XtraEditors.SimpleButton();
            this.txt_IdGuiaRemision = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumIngreso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroCosto_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_unidad_medida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPuntoCargo_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sub_centro_costo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_grupo_punto_cargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkTodos.Properties)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_serie2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_serie1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_secuencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdGuiaRemision.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Superior_Mant1
            // 
            this.ucGe_Menu_Superior_Mant1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior_Mant1.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpLote = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnproductos = true;
            this.ucGe_Menu_Superior_Mant1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior_Mant1.Margin = new System.Windows.Forms.Padding(4);
            this.ucGe_Menu_Superior_Mant1.Name = "ucGe_Menu_Superior_Mant1";
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(949, 29);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 1;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Superior_Mant1.Visible_bntReImprimir = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Superior_Mant1.Visible_bntSalir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Actualizar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_conciliacion_Auto = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Generar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cbte = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cheq = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Reten = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAceptar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Superior_Mant1.Visible_btnContabilizar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Superior_Mant1.Visible_btnModificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Superior_Mant1.Load += new System.EventHandler(this.ucGe_Menu_Superior_Mant1_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 484);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 484);
            this.panel2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 90);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 394);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(941, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detalle Ingreso G/R";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gridControlIngreso);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(935, 318);
            this.panel4.TabIndex = 1;
            // 
            // gridControlIngreso
            // 
            this.gridControlIngreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlIngreso.Location = new System.Drawing.Point(0, 0);
            this.gridControlIngreso.MainView = this.gridViewIngreso;
            this.gridControlIngreso.Name = "gridControlIngreso";
            this.gridControlIngreso.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbCentroCosto_grid,
            this.cmbPuntoCargo_grid,
            this.cmb_unidad_medida,
            this.cmb_sub_centro_costo,
            this.cmb_grupo_punto_cargo});
            this.gridControlIngreso.Size = new System.Drawing.Size(935, 318);
            this.gridControlIngreso.TabIndex = 0;
            this.gridControlIngreso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewIngreso});
            // 
            // gridViewIngreso
            // 
            this.gridViewIngreso.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IdCentroCosto,
            this.col_NumGuia,
            this.col_Secuencia,
            this.col_Checked,
            this.col_IdProducto,
            this.col_pr_codigo,
            this.col_pr_descripcion,
            this.col_detalle_x_tiem,
            this.col_IdEntidad,
            this.col_pe_nombreCompleto,
            this.col_Fecha_registro,
            this.col_Observacion,
            this.col_dm_precio,
            this.col_cantidad_GR,
            this.col_pr_peso,
            this.col_cantidad_sinConversion_GR,
            this.col_dm_cantidad,
            this.col_Saldo_GR_x_Ing,
            this.col_Estado,
            this.col_Saldo_GR_x_Ing_AUX,
            this.col_IdUnidadMedida,
            this.col_IdTipoConsumo,
            this.col_NomProyecto});
            this.gridViewIngreso.CustomizationFormBounds = new System.Drawing.Rectangle(853, 395, 210, 172);
            this.gridViewIngreso.GridControl = this.gridControlIngreso;
            this.gridViewIngreso.Name = "gridViewIngreso";
            this.gridViewIngreso.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewIngreso.OptionsFind.AlwaysVisible = true;
            this.gridViewIngreso.OptionsView.ShowAutoFilterRow = true;
            this.gridViewIngreso.OptionsView.ShowGroupPanel = false;
            this.gridViewIngreso.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewIngreso_RowClick);
            this.gridViewIngreso.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewIngreso_FocusedRowChanged);
            this.gridViewIngreso.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewIngreso_CellValueChanged);
            this.gridViewIngreso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewIngreso_KeyDown);
            // 
            // col_IdCentroCosto
            // 
            this.col_IdCentroCosto.Caption = "Centro de Costo";
            this.col_IdCentroCosto.ColumnEdit = this.cmbCentroCosto_grid;
            this.col_IdCentroCosto.FieldName = "IdCentroCosto";
            this.col_IdCentroCosto.Name = "col_IdCentroCosto";
            this.col_IdCentroCosto.Visible = true;
            this.col_IdCentroCosto.VisibleIndex = 10;
            this.col_IdCentroCosto.Width = 85;
            // 
            // cmbCentroCosto_grid
            // 
            this.cmbCentroCosto_grid.AutoHeight = false;
            this.cmbCentroCosto_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCentroCosto_grid.DisplayMember = "Centro_costo2";
            this.cmbCentroCosto_grid.Name = "cmbCentroCosto_grid";
            this.cmbCentroCosto_grid.PopupView = this.repositoryItemSearchLookUpEdit1View;
            this.cmbCentroCosto_grid.ValueMember = "IdCentroCosto";
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCentroCosto_cmbgrid,
            this.colCentro_costo_cmbgrid});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCentroCosto_cmbgrid
            // 
            this.colIdCentroCosto_cmbgrid.Caption = "IdCentroCosto";
            this.colIdCentroCosto_cmbgrid.FieldName = "IdCentroCosto";
            this.colIdCentroCosto_cmbgrid.Name = "colIdCentroCosto_cmbgrid";
            this.colIdCentroCosto_cmbgrid.Visible = true;
            this.colIdCentroCosto_cmbgrid.VisibleIndex = 1;
            this.colIdCentroCosto_cmbgrid.Width = 251;
            // 
            // colCentro_costo_cmbgrid
            // 
            this.colCentro_costo_cmbgrid.Caption = "Centro de Costo";
            this.colCentro_costo_cmbgrid.FieldName = "Centro_costo";
            this.colCentro_costo_cmbgrid.Name = "colCentro_costo_cmbgrid";
            this.colCentro_costo_cmbgrid.Visible = true;
            this.colCentro_costo_cmbgrid.VisibleIndex = 0;
            this.colCentro_costo_cmbgrid.Width = 929;
            // 
            // col_NumGuia
            // 
            this.col_NumGuia.Caption = "# Guía Remisión";
            this.col_NumGuia.FieldName = "NumGuia";
            this.col_NumGuia.Name = "col_NumGuia";
            this.col_NumGuia.OptionsColumn.AllowEdit = false;
            this.col_NumGuia.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.col_NumGuia.Visible = true;
            this.col_NumGuia.VisibleIndex = 1;
            this.col_NumGuia.Width = 81;
            // 
            // col_Secuencia
            // 
            this.col_Secuencia.Caption = "Secuencia";
            this.col_Secuencia.FieldName = "Secuencia";
            this.col_Secuencia.Name = "col_Secuencia";
            // 
            // col_Checked
            // 
            this.col_Checked.Caption = "*";
            this.col_Checked.FieldName = "Checked";
            this.col_Checked.Name = "col_Checked";
            this.col_Checked.OptionsColumn.AllowEdit = false;
            this.col_Checked.Visible = true;
            this.col_Checked.VisibleIndex = 0;
            this.col_Checked.Width = 74;
            // 
            // col_IdProducto
            // 
            this.col_IdProducto.Caption = "IdProducto";
            this.col_IdProducto.FieldName = "IdProducto";
            this.col_IdProducto.Name = "col_IdProducto";
            // 
            // col_pr_codigo
            // 
            this.col_pr_codigo.Caption = "Cod Prod.";
            this.col_pr_codigo.FieldName = "pr_codigo";
            this.col_pr_codigo.Name = "col_pr_codigo";
            this.col_pr_codigo.Visible = true;
            this.col_pr_codigo.VisibleIndex = 2;
            this.col_pr_codigo.Width = 99;
            // 
            // col_pr_descripcion
            // 
            this.col_pr_descripcion.Caption = "Producto";
            this.col_pr_descripcion.FieldName = "pr_descripcion";
            this.col_pr_descripcion.Name = "col_pr_descripcion";
            this.col_pr_descripcion.OptionsColumn.AllowEdit = false;
            this.col_pr_descripcion.Visible = true;
            this.col_pr_descripcion.VisibleIndex = 3;
            this.col_pr_descripcion.Width = 206;
            // 
            // col_detalle_x_tiem
            // 
            this.col_detalle_x_tiem.Caption = "Detalle x Item";
            this.col_detalle_x_tiem.FieldName = "detalle_x_tiem";
            this.col_detalle_x_tiem.Name = "col_detalle_x_tiem";
            this.col_detalle_x_tiem.Visible = true;
            this.col_detalle_x_tiem.VisibleIndex = 4;
            this.col_detalle_x_tiem.Width = 125;
            // 
            // col_IdEntidad
            // 
            this.col_IdEntidad.Caption = "IdEntidad";
            this.col_IdEntidad.FieldName = "IdEntidad";
            this.col_IdEntidad.Name = "col_IdEntidad";
            // 
            // col_pe_nombreCompleto
            // 
            this.col_pe_nombreCompleto.Caption = "Nombre";
            this.col_pe_nombreCompleto.FieldName = "pe_nombreCompleto";
            this.col_pe_nombreCompleto.Name = "col_pe_nombreCompleto";
            this.col_pe_nombreCompleto.OptionsColumn.AllowEdit = false;
            this.col_pe_nombreCompleto.Width = 71;
            // 
            // col_Fecha_registro
            // 
            this.col_Fecha_registro.Caption = "Fecha";
            this.col_Fecha_registro.DisplayFormat.FormatString = "d";
            this.col_Fecha_registro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.col_Fecha_registro.FieldName = "Fecha_registro";
            this.col_Fecha_registro.Name = "col_Fecha_registro";
            this.col_Fecha_registro.OptionsColumn.AllowEdit = false;
            this.col_Fecha_registro.Width = 56;
            // 
            // col_Observacion
            // 
            this.col_Observacion.Caption = "Observación";
            this.col_Observacion.FieldName = "Observacion";
            this.col_Observacion.Name = "col_Observacion";
            this.col_Observacion.OptionsColumn.AllowEdit = false;
            this.col_Observacion.Width = 148;
            // 
            // col_dm_precio
            // 
            this.col_dm_precio.FieldName = "dm_precio";
            this.col_dm_precio.Name = "col_dm_precio";
            // 
            // col_cantidad_GR
            // 
            this.col_cantidad_GR.Caption = "Cant. G/R";
            this.col_cantidad_GR.DisplayFormat.FormatString = "{0:n2}";
            this.col_cantidad_GR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_cantidad_GR.FieldName = "cantidad_GR";
            this.col_cantidad_GR.Name = "col_cantidad_GR";
            this.col_cantidad_GR.OptionsColumn.AllowEdit = false;
            this.col_cantidad_GR.Visible = true;
            this.col_cantidad_GR.VisibleIndex = 5;
            this.col_cantidad_GR.Width = 72;
            // 
            // col_pr_peso
            // 
            this.col_pr_peso.Caption = "Peso";
            this.col_pr_peso.FieldName = "dm_peso";
            this.col_pr_peso.Name = "col_pr_peso";
            this.col_pr_peso.Visible = true;
            this.col_pr_peso.VisibleIndex = 6;
            this.col_pr_peso.Width = 86;
            // 
            // col_cantidad_sinConversion_GR
            // 
            this.col_cantidad_sinConversion_GR.Caption = "Cant. G/R";
            this.col_cantidad_sinConversion_GR.DisplayFormat.FormatString = "{0:n2}";
            this.col_cantidad_sinConversion_GR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_cantidad_sinConversion_GR.FieldName = "cantidad_sinConversion_GR";
            this.col_cantidad_sinConversion_GR.Name = "col_cantidad_sinConversion_GR";
            this.col_cantidad_sinConversion_GR.Visible = true;
            this.col_cantidad_sinConversion_GR.VisibleIndex = 7;
            this.col_cantidad_sinConversion_GR.Width = 86;
            // 
            // col_dm_cantidad
            // 
            this.col_dm_cantidad.Caption = "Cant. Recibida";
            this.col_dm_cantidad.DisplayFormat.FormatString = "{0:n2}";
            this.col_dm_cantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_dm_cantidad.FieldName = "dm_cantidad";
            this.col_dm_cantidad.Name = "col_dm_cantidad";
            this.col_dm_cantidad.Visible = true;
            this.col_dm_cantidad.VisibleIndex = 8;
            this.col_dm_cantidad.Width = 81;
            // 
            // col_Saldo_GR_x_Ing
            // 
            this.col_Saldo_GR_x_Ing.Caption = "Saldo";
            this.col_Saldo_GR_x_Ing.DisplayFormat.FormatString = "{0:n2}";
            this.col_Saldo_GR_x_Ing.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_Saldo_GR_x_Ing.FieldName = "Saldo_GR_x_Ing";
            this.col_Saldo_GR_x_Ing.Name = "col_Saldo_GR_x_Ing";
            this.col_Saldo_GR_x_Ing.OptionsColumn.AllowEdit = false;
            this.col_Saldo_GR_x_Ing.Visible = true;
            this.col_Saldo_GR_x_Ing.VisibleIndex = 9;
            this.col_Saldo_GR_x_Ing.Width = 70;
            // 
            // col_Estado
            // 
            this.col_Estado.Caption = "Estado";
            this.col_Estado.FieldName = "Estado";
            this.col_Estado.Name = "col_Estado";
            this.col_Estado.OptionsColumn.AllowEdit = false;
            this.col_Estado.Width = 47;
            // 
            // col_Saldo_GR_x_Ing_AUX
            // 
            this.col_Saldo_GR_x_Ing_AUX.DisplayFormat.FormatString = "{0:n2}";
            this.col_Saldo_GR_x_Ing_AUX.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_Saldo_GR_x_Ing_AUX.FieldName = "Saldo_GR_x_Ing_AUX";
            this.col_Saldo_GR_x_Ing_AUX.Name = "col_Saldo_GR_x_Ing_AUX";
            // 
            // col_IdUnidadMedida
            // 
            this.col_IdUnidadMedida.Caption = "IdUnidadMedida";
            this.col_IdUnidadMedida.ColumnEdit = this.cmb_unidad_medida;
            this.col_IdUnidadMedida.FieldName = "IdUnidadMedida";
            this.col_IdUnidadMedida.Name = "col_IdUnidadMedida";
            // 
            // cmb_unidad_medida
            // 
            this.cmb_unidad_medida.AutoHeight = false;
            this.cmb_unidad_medida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_unidad_medida.DisplayMember = "Descripcion";
            this.cmb_unidad_medida.Name = "cmb_unidad_medida";
            this.cmb_unidad_medida.PopupView = this.gridView3;
            this.cmb_unidad_medida.ValueMember = "IdUnidadMedida";
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdUnidadMedida1,
            this.colDescripcion1});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colIdUnidadMedida1
            // 
            this.colIdUnidadMedida1.Caption = "IdUnidadMedida";
            this.colIdUnidadMedida1.FieldName = "IdUnidadMedida";
            this.colIdUnidadMedida1.Name = "colIdUnidadMedida1";
            this.colIdUnidadMedida1.Visible = true;
            this.colIdUnidadMedida1.VisibleIndex = 0;
            this.colIdUnidadMedida1.Width = 179;
            // 
            // colDescripcion1
            // 
            this.colDescripcion1.Caption = "Descripcion";
            this.colDescripcion1.FieldName = "Descripcion";
            this.colDescripcion1.Name = "colDescripcion1";
            this.colDescripcion1.Visible = true;
            this.colDescripcion1.VisibleIndex = 1;
            this.colDescripcion1.Width = 1001;
            // 
            // col_IdTipoConsumo
            // 
            this.col_IdTipoConsumo.Caption = "IdTipoConsumo";
            this.col_IdTipoConsumo.FieldName = "IdTipoConsumo";
            this.col_IdTipoConsumo.Name = "col_IdTipoConsumo";
            // 
            // col_NomProyecto
            // 
            this.col_NomProyecto.Caption = "Proyecto";
            this.col_NomProyecto.FieldName = "NomProyecto";
            this.col_NomProyecto.Name = "col_NomProyecto";
            this.col_NomProyecto.Width = 90;
            // 
            // cmbPuntoCargo_grid
            // 
            this.cmbPuntoCargo_grid.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmbPuntoCargo_grid.AutoHeight = false;
            this.cmbPuntoCargo_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPuntoCargo_grid.DisplayMember = "nom_punto_cargo2";
            this.cmbPuntoCargo_grid.Name = "cmbPuntoCargo_grid";
            this.cmbPuntoCargo_grid.PopupView = this.gridView2;
            this.cmbPuntoCargo_grid.ReadOnly = true;
            this.cmbPuntoCargo_grid.ValueMember = "IdPunto_cargo";
            this.cmbPuntoCargo_grid.Click += new System.EventHandler(this.cmbPuntoCargo_grid_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPunto_cargo_cmbgrid,
            this.colnom_punto_cargo});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdPunto_cargo_cmbgrid
            // 
            this.colIdPunto_cargo_cmbgrid.Caption = "IdPuntoCargo";
            this.colIdPunto_cargo_cmbgrid.FieldName = "IdPunto_cargo";
            this.colIdPunto_cargo_cmbgrid.Name = "colIdPunto_cargo_cmbgrid";
            this.colIdPunto_cargo_cmbgrid.Visible = true;
            this.colIdPunto_cargo_cmbgrid.VisibleIndex = 1;
            this.colIdPunto_cargo_cmbgrid.Width = 267;
            // 
            // colnom_punto_cargo
            // 
            this.colnom_punto_cargo.Caption = "Nombre";
            this.colnom_punto_cargo.FieldName = "nom_punto_cargo";
            this.colnom_punto_cargo.Name = "colnom_punto_cargo";
            this.colnom_punto_cargo.Visible = true;
            this.colnom_punto_cargo.VisibleIndex = 0;
            this.colnom_punto_cargo.Width = 913;
            // 
            // cmb_sub_centro_costo
            // 
            this.cmb_sub_centro_costo.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_sub_centro_costo.AutoHeight = false;
            this.cmb_sub_centro_costo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_sub_centro_costo.DisplayMember = "Centro_costo2";
            this.cmb_sub_centro_costo.Name = "cmb_sub_centro_costo";
            this.cmb_sub_centro_costo.PopupView = this.gridView1;
            this.cmb_sub_centro_costo.ReadOnly = true;
            this.cmb_sub_centro_costo.ValueMember = "IdRegistro";
            this.cmb_sub_centro_costo.Click += new System.EventHandler(this.cmb_sub_centro_costo_Click);
            this.cmb_sub_centro_costo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_sub_centro_costo_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn17,
            this.gridColumn18});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "ID";
            this.gridColumn17.FieldName = "IdCentroCosto_sub_centro_costo";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 1;
            this.gridColumn17.Width = 219;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Subcentro de costo";
            this.gridColumn18.FieldName = "Centro_costo";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 0;
            this.gridColumn18.Width = 961;
            // 
            // cmb_grupo_punto_cargo
            // 
            this.cmb_grupo_punto_cargo.AutoHeight = false;
            this.cmb_grupo_punto_cargo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_grupo_punto_cargo.DisplayMember = "nom_punto_cargo_grupo2";
            this.cmb_grupo_punto_cargo.Name = "cmb_grupo_punto_cargo";
            this.cmb_grupo_punto_cargo.PopupView = this.gridView4;
            this.cmb_grupo_punto_cargo.ValueMember = "IdPunto_cargo_grupo";
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn20,
            this.gridColumn21});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "ID";
            this.gridColumn20.FieldName = "IdPunto_cargo_grupo";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 1;
            this.gridColumn20.Width = 163;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Grupo";
            this.gridColumn21.FieldName = "nom_punto_cargo_grupo";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 0;
            this.gridColumn21.Width = 1017;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkTodos);
            this.panel3.Controls.Add(this.btn_imprimir);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtObservacion);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(935, 44);
            this.panel3.TabIndex = 0;
            // 
            // checkTodos
            // 
            this.checkTodos.Location = new System.Drawing.Point(9, 7);
            this.checkTodos.Name = "checkTodos";
            this.checkTodos.Properties.Caption = "Seleccionar visibles";
            this.checkTodos.Size = new System.Drawing.Size(114, 20);
            this.checkTodos.TabIndex = 4;
            this.checkTodos.CheckedChanged += new System.EventHandler(this.checkTodos_CheckedChanged_1);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(188, 5);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_imprimir.TabIndex = 6;
            this.btn_imprimir.Text = "imprimir";
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Observación:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(355, 7);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(500, 31);
            this.txtObservacion.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(941, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diario Contable";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucInv_GridCbte_Cble_x_Ing_Egr_Inv1
            // 
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.Location = new System.Drawing.Point(3, 3);
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.Margin = new System.Windows.Forms.Padding(4);
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.Name = "ucInv_GridCbte_Cble_x_Ing_Egr_Inv1";
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.Size = new System.Drawing.Size(935, 362);
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txt_serie2);
            this.panel5.Controls.Add(this.txt_serie1);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txt_secuencia);
            this.panel5.Controls.Add(this.cmbMotivoInv);
            this.panel5.Controls.Add(this.cmbTipoMovi);
            this.panel5.Controls.Add(this.ucIn_Sucursal_Bodega1);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.btn_cargar_datos);
            this.panel5.Controls.Add(this.txt_IdGuiaRemision);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.dtpFecha);
            this.panel5.Controls.Add(this.lblAnulado);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.txtNumIngreso);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(949, 90);
            this.panel5.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "-";
            // 
            // txt_serie2
            // 
            this.txt_serie2.EditValue = "";
            this.txt_serie2.Location = new System.Drawing.Point(148, 57);
            this.txt_serie2.Margin = new System.Windows.Forms.Padding(2);
            this.txt_serie2.Name = "txt_serie2";
            this.txt_serie2.Properties.ReadOnly = true;
            this.txt_serie2.Size = new System.Drawing.Size(30, 20);
            this.txt_serie2.TabIndex = 34;
            // 
            // txt_serie1
            // 
            this.txt_serie1.EditValue = "";
            this.txt_serie1.Location = new System.Drawing.Point(98, 57);
            this.txt_serie1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_serie1.Name = "txt_serie1";
            this.txt_serie1.Properties.ReadOnly = true;
            this.txt_serie1.Size = new System.Drawing.Size(30, 20);
            this.txt_serie1.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "# Comprobante:";
            // 
            // txt_secuencia
            // 
            this.txt_secuencia.EditValue = "";
            this.txt_secuencia.Location = new System.Drawing.Point(195, 57);
            this.txt_secuencia.Margin = new System.Windows.Forms.Padding(2);
            this.txt_secuencia.Name = "txt_secuencia";
            this.txt_secuencia.Properties.ReadOnly = true;
            this.txt_secuencia.Size = new System.Drawing.Size(75, 20);
            this.txt_secuencia.TabIndex = 31;
            // 
            // cmbMotivoInv
            // 
            this.cmbMotivoInv.Location = new System.Drawing.Point(658, 54);
            this.cmbMotivoInv.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMotivoInv.Name = "cmbMotivoInv";
            this.cmbMotivoInv.Size = new System.Drawing.Size(276, 25);
            this.cmbMotivoInv.TabIndex = 29;
            this.cmbMotivoInv.Tipo_Ing_Egr = ein_Tipo_Ing_Egr.ING;
            // 
            // cmbTipoMovi
            // 
            this.cmbTipoMovi.Enabled = false;
            this.cmbTipoMovi.Location = new System.Drawing.Point(657, 29);
            this.cmbTipoMovi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoMovi.Name = "cmbTipoMovi";
            this.cmbTipoMovi.Size = new System.Drawing.Size(278, 25);
            this.cmbTipoMovi.TabIndex = 28;
            this.cmbTipoMovi.Visible_buton_Acciones = true;
            // 
            // ucIn_Sucursal_Bodega1
            // 
            this.ucIn_Sucursal_Bodega1.Location = new System.Drawing.Point(285, 30);
            this.ucIn_Sucursal_Bodega1.Margin = new System.Windows.Forms.Padding(4);
            this.ucIn_Sucursal_Bodega1.Name = "ucIn_Sucursal_Bodega1";
            this.ucIn_Sucursal_Bodega1.Size = new System.Drawing.Size(288, 51);
            this.ucIn_Sucursal_Bodega1.TabIndex = 27;
            this.ucIn_Sucursal_Bodega1.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.Normal;
            this.ucIn_Sucursal_Bodega1.Visible_cmb_bodega = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(587, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Concepto:";
            // 
            // btn_cargar_datos
            // 
            this.btn_cargar_datos.Location = new System.Drawing.Point(195, 34);
            this.btn_cargar_datos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cargar_datos.Name = "btn_cargar_datos";
            this.btn_cargar_datos.Size = new System.Drawing.Size(75, 19);
            this.btn_cargar_datos.TabIndex = 24;
            this.btn_cargar_datos.Text = "Buscar G/R";
            this.btn_cargar_datos.Click += new System.EventHandler(this.btn_cargar_datos_Click);
            // 
            // txt_IdGuiaRemision
            // 
            this.txt_IdGuiaRemision.Location = new System.Drawing.Point(98, 34);
            this.txt_IdGuiaRemision.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IdGuiaRemision.Name = "txt_IdGuiaRemision";
            this.txt_IdGuiaRemision.Size = new System.Drawing.Size(80, 20);
            this.txt_IdGuiaRemision.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "ID G/R:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nº Ing:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(342, 9);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(95, 20);
            this.dtpFecha.TabIndex = 9;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(443, 9);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(127, 20);
            this.lblAnulado.TabIndex = 11;
            this.lblAnulado.Text = "*** Anulado ***";
            this.lblAnulado.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(587, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Motivo Inv:";
            // 
            // txtNumIngreso
            // 
            this.txtNumIngreso.Location = new System.Drawing.Point(98, 9);
            this.txtNumIngreso.Name = "txtNumIngreso";
            this.txtNumIngreso.ReadOnly = true;
            this.txtNumIngreso.Size = new System.Drawing.Size(80, 20);
            this.txtNumIngreso.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha:";
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 513);
            this.ucGe_BarraEstadoInferior_Forms1.Margin = new System.Windows.Forms.Padding(4);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(949, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 3;
            // 
            // FrmIn_Ingreso_x_GuiaRemision_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "FrmIn_Ingreso_x_GuiaRemision_Mant";
            this.Text = "Devolución de Guía Remisión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIn_Ingreso_x_GuiaRemision_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmIn_Ingreso_x_GuiaRemision_Mant_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCentroCosto_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_unidad_medida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPuntoCargo_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sub_centro_costo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_grupo_punto_cargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkTodos.Properties)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_serie2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_serie1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_secuencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdGuiaRemision.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtNumIngreso;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl gridControlIngreso;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn col_NumGuia;
        private DevExpress.XtraGrid.Columns.GridColumn col_Secuencia;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdEntidad;
        private DevExpress.XtraGrid.Columns.GridColumn col_pe_nombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn col_Fecha_registro;
        private DevExpress.XtraGrid.Columns.GridColumn col_Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn col_pr_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn col_pr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn col_dm_precio;
        private DevExpress.XtraGrid.Columns.GridColumn col_cantidad_GR;
        private DevExpress.XtraGrid.Columns.GridColumn col_dm_cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn col_Saldo_GR_x_Ing;
        private DevExpress.XtraGrid.Columns.GridColumn col_pr_peso;
        private DevExpress.XtraGrid.Columns.GridColumn col_Estado;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdCentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn col_Checked;
        private DevExpress.XtraGrid.Columns.GridColumn col_Saldo_GR_x_Ing_AUX;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbCentroCosto_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo_cmbgrid;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbPuntoCargo_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPunto_cargo_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_punto_cargo;
        private System.Windows.Forms.Label lblAnulado;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_unidad_medida;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidadMedida1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.CheckEdit checkTodos;
        private Controles.UCInv_GridCbte_Cble_x_Ing_Egr_Inv ucInv_GridCbte_Cble_x_Ing_Egr_Inv1;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdTipoConsumo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_sub_centro_costo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_grupo_punto_cargo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraGrid.Columns.GridColumn col_detalle_x_tiem;
        private DevExpress.XtraEditors.SimpleButton btn_imprimir;
        private DevExpress.XtraGrid.Columns.GridColumn col_cantidad_sinConversion_GR;
        private DevExpress.XtraGrid.Columns.GridColumn col_NomProyecto;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txt_IdGuiaRemision;
        private DevExpress.XtraEditors.SimpleButton btn_cargar_datos;
        private System.Windows.Forms.Label label7;
        private Controles.UCIn_MotivoInvCmb cmbMotivoInv;
        private Controles.UCIn_TipoMoviInv_Cmb cmbTipoMovi;
        private Controles.UCIn_Sucursal_Bodega ucIn_Sucursal_Bodega1;
        private DevExpress.XtraEditors.TextEdit txt_secuencia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txt_serie2;
        private DevExpress.XtraEditors.TextEdit txt_serie1;
        private System.Windows.Forms.Label label5;
    }
}