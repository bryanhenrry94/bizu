namespace Bizu.Reports.Contabilidad
{
    partial class XCONTA_Rpt007_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XCONTA_Rpt007_frm));
            //this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Bizu.Reports.frmEspere), true, true);
            this.cmb_imagen = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gc_balance_comp = new DevExpress.XtraGrid.GridControl();
            this.gw_balance_comp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nom_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_GrupoCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdCtaCblePadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Saldo_Inicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Saldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo_x_Movi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pc_EsMovimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbIcono = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colDebito_Mes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCredito_Mes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnImprimirExcel = new System.Windows.Forms.ToolStripButton();
            this.btn_imprimir_grilla = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkMostrarCC = new System.Windows.Forms.CheckBox();
            this.btn_Generar_Reporte = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_centro_costo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.uCct_Pto_Cargo_Grupo = new Bizu.Reports.Controles.UCct_Pto_Cargo_Grupo();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dt_FechaDesde = new System.Windows.Forms.DateTimePicker();
            this.chkMostrar_Cero = new System.Windows.Forms.CheckBox();
            this.lblPeriodo = new DevExpress.XtraEditors.LabelControl();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.gridConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Id_CtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSaldoInicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDebe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridLookUpEditCtaCtble = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpc_Cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridLookUpEditSucursal = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridViewSucursal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCtaCble = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Cuenta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Cuenta2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCblePadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCatalogo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Naturaleza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNivelCta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGrupoCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_EsMovimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_es_flujo_efectivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpc_clave_corta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Plancta_nivel_Info = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuentaPadre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryCmbAnticipo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpc_CuentaAnti = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_balance_comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_balance_comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIcono)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_centro_costo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditCtaCtble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCtaCble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCmbAnticipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_imagen
            // 
            this.cmb_imagen.AutoHeight = false;
            this.cmb_imagen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_imagen.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "S", 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "N", -1)});
            this.cmb_imagen.Name = "cmb_imagen";
            this.cmb_imagen.SmallImages = this.imageList1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "consultar_32x32.png");
            // 
            // gc_balance_comp
            // 
            this.gc_balance_comp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_balance_comp.Location = new System.Drawing.Point(0, 122);
            this.gc_balance_comp.MainView = this.gw_balance_comp;
            this.gc_balance_comp.Name = "gc_balance_comp";
            this.gc_balance_comp.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbIcono});
            this.gc_balance_comp.Size = new System.Drawing.Size(1114, 312);
            this.gc_balance_comp.TabIndex = 16;
            this.gc_balance_comp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gw_balance_comp});
            // 
            // gw_balance_comp
            // 
            this.gw_balance_comp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IdCtaCble,
            this.col_nom_cuenta,
            this.col_GrupoCble,
            this.col_IdCtaCblePadre,
            this.col_Saldo_Inicial,
            this.col_Saldo,
            this.colSaldo_x_Movi,
            this.col_pc_EsMovimiento,
            this.colDebito_Mes,
            this.colCredito_Mes});
            this.gw_balance_comp.CustomizationFormBounds = new System.Drawing.Rectangle(597, 431, 210, 172);
            this.gw_balance_comp.GridControl = this.gc_balance_comp;
            this.gw_balance_comp.GroupCount = 1;
            this.gw_balance_comp.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saldo_inicial_x_Movi", this.col_Saldo_Inicial, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saldo_x_Movi", this.col_Saldo, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debito_Mes_x_Movi", this.colDebito_Mes, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credito_Mes_x_Movi", this.colCredito_Mes, "{0:c2}")});
            this.gw_balance_comp.Name = "gw_balance_comp";
            this.gw_balance_comp.OptionsBehavior.AutoExpandAllGroups = true;
            this.gw_balance_comp.OptionsBehavior.Editable = false;
            this.gw_balance_comp.OptionsBehavior.ReadOnly = true;
            this.gw_balance_comp.OptionsPrint.PrintHeader = false;
            this.gw_balance_comp.OptionsPrint.PrintHorzLines = false;
            this.gw_balance_comp.OptionsPrint.PrintVertLines = false;
            this.gw_balance_comp.OptionsView.ShowFooter = true;
            this.gw_balance_comp.OptionsView.ShowGroupPanel = false;
            this.gw_balance_comp.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gw_balance_comp.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gw_balance_comp.OptionsView.ShowViewCaption = true;
            this.gw_balance_comp.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.col_GrupoCble, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gw_balance_comp.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gw_balance_comp_RowCellClick);
            // 
            // col_IdCtaCble
            // 
            this.col_IdCtaCble.Caption = "Cuenta Contable";
            this.col_IdCtaCble.FieldName = "IdCtaCble";
            this.col_IdCtaCble.Name = "col_IdCtaCble";
            this.col_IdCtaCble.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.col_IdCtaCble.Visible = true;
            this.col_IdCtaCble.VisibleIndex = 0;
            this.col_IdCtaCble.Width = 111;
            // 
            // col_nom_cuenta
            // 
            this.col_nom_cuenta.Caption = "Cuenta";
            this.col_nom_cuenta.FieldName = "nom_cuenta";
            this.col_nom_cuenta.Name = "col_nom_cuenta";
            this.col_nom_cuenta.Visible = true;
            this.col_nom_cuenta.VisibleIndex = 1;
            this.col_nom_cuenta.Width = 506;
            // 
            // col_GrupoCble
            // 
            this.col_GrupoCble.Caption = "Grupo Ctble";
            this.col_GrupoCble.FieldName = "GrupoCble";
            this.col_GrupoCble.Name = "col_GrupoCble";
            this.col_GrupoCble.Visible = true;
            this.col_GrupoCble.VisibleIndex = 1;
            // 
            // col_IdCtaCblePadre
            // 
            this.col_IdCtaCblePadre.Caption = "Padre Ctble";
            this.col_IdCtaCblePadre.FieldName = "IdCtaCblePadre";
            this.col_IdCtaCblePadre.Name = "col_IdCtaCblePadre";
            // 
            // col_Saldo_Inicial
            // 
            this.col_Saldo_Inicial.Caption = "Saldo Inicial";
            this.col_Saldo_Inicial.DisplayFormat.FormatString = "c2";
            this.col_Saldo_Inicial.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_Saldo_Inicial.FieldName = "Saldo_Inicial";
            this.col_Saldo_Inicial.Name = "col_Saldo_Inicial";
            this.col_Saldo_Inicial.Visible = true;
            this.col_Saldo_Inicial.VisibleIndex = 2;
            this.col_Saldo_Inicial.Width = 123;
            // 
            // col_Saldo
            // 
            this.col_Saldo.Caption = "Saldo";
            this.col_Saldo.DisplayFormat.FormatString = "c2";
            this.col_Saldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_Saldo.FieldName = "Saldo";
            this.col_Saldo.Name = "col_Saldo";
            this.col_Saldo.Visible = true;
            this.col_Saldo.VisibleIndex = 5;
            this.col_Saldo.Width = 204;
            // 
            // colSaldo_x_Movi
            // 
            this.colSaldo_x_Movi.Caption = "Saldo_x_Movi";
            this.colSaldo_x_Movi.FieldName = "Saldo_x_Movi";
            this.colSaldo_x_Movi.Name = "colSaldo_x_Movi";
            // 
            // col_pc_EsMovimiento
            // 
            this.col_pc_EsMovimiento.Caption = "*";
            this.col_pc_EsMovimiento.ColumnEdit = this.cmbIcono;
            this.col_pc_EsMovimiento.FieldName = "pc_EsMovimiento";
            this.col_pc_EsMovimiento.Name = "col_pc_EsMovimiento";
            this.col_pc_EsMovimiento.Visible = true;
            this.col_pc_EsMovimiento.VisibleIndex = 6;
            this.col_pc_EsMovimiento.Width = 35;
            // 
            // cmbIcono
            // 
            this.cmbIcono.AutoHeight = false;
            this.cmbIcono.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIcono.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "S", 0)});
            this.cmbIcono.Name = "cmbIcono";
            this.cmbIcono.SmallImages = this.imageList1;
            // 
            // colDebito_Mes
            // 
            this.colDebito_Mes.Caption = "Debito Mes";
            this.colDebito_Mes.DisplayFormat.FormatString = "c2";
            this.colDebito_Mes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDebito_Mes.FieldName = "Debito_Mes";
            this.colDebito_Mes.Name = "colDebito_Mes";
            this.colDebito_Mes.Visible = true;
            this.colDebito_Mes.VisibleIndex = 3;
            this.colDebito_Mes.Width = 99;
            // 
            // colCredito_Mes
            // 
            this.colCredito_Mes.Caption = "Credito Mes";
            this.colCredito_Mes.DisplayFormat.FormatString = "c2";
            this.colCredito_Mes.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCredito_Mes.FieldName = "Credito_Mes";
            this.colCredito_Mes.Name = "colCredito_Mes";
            this.colCredito_Mes.Visible = true;
            this.colCredito_Mes.VisibleIndex = 4;
            this.colCredito_Mes.Width = 102;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImprimir,
            this.btnImprimirExcel,
            this.btn_imprimir_grilla,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1114, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(73, 22);
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnImprimirExcel
            // 
            this.btnImprimirExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirExcel.Image")));
            this.btnImprimirExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimirExcel.Name = "btnImprimirExcel";
            this.btnImprimirExcel.Size = new System.Drawing.Size(103, 22);
            this.btnImprimirExcel.Text = "Imprimir Excel";
            this.btnImprimirExcel.Click += new System.EventHandler(this.btnImprimirExcel_Click);
            // 
            // btn_imprimir_grilla
            // 
            this.btn_imprimir_grilla.Image = global::Bizu.Reports.Properties.Resources.imprimir5_64x64;
            this.btn_imprimir_grilla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_imprimir_grilla.Name = "btn_imprimir_grilla";
            this.btn_imprimir_grilla.Size = new System.Drawing.Size(102, 22);
            this.btn_imprimir_grilla.Text = "Imprimir tabla";
            this.btn_imprimir_grilla.Click += new System.EventHandler(this.btn_imprimir_grilla_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Bizu.Reports.Properties.Resources.salir_64x64;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkMostrarCC);
            this.panel1.Controls.Add(this.btn_Generar_Reporte);
            this.panel1.Controls.Add(this.cmb_centro_costo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.uCct_Pto_Cargo_Grupo);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.dt_FechaDesde);
            this.panel1.Controls.Add(this.chkMostrar_Cero);
            this.panel1.Controls.Add(this.lblPeriodo);
            this.panel1.Controls.Add(this.dtpFechaHasta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 97);
            this.panel1.TabIndex = 20;
            // 
            // chkMostrarCC
            // 
            this.chkMostrarCC.AutoSize = true;
            this.chkMostrarCC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMostrarCC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkMostrarCC.Location = new System.Drawing.Point(208, 63);
            this.chkMostrarCC.Name = "chkMostrarCC";
            this.chkMostrarCC.Size = new System.Drawing.Size(143, 17);
            this.chkMostrarCC.TabIndex = 37;
            this.chkMostrarCC.Text = "Mostrar centros de costo";
            this.chkMostrarCC.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkMostrarCC.UseVisualStyleBackColor = true;
            // 
            // btn_Generar_Reporte
            // 
            this.btn_Generar_Reporte.ImageOptions.ImageIndex = 0;
            this.btn_Generar_Reporte.ImageOptions.ImageList = this.imageList1;
            this.btn_Generar_Reporte.Location = new System.Drawing.Point(21, 64);
            this.btn_Generar_Reporte.Name = "btn_Generar_Reporte";
            this.btn_Generar_Reporte.Size = new System.Drawing.Size(118, 27);
            this.btn_Generar_Reporte.TabIndex = 36;
            this.btn_Generar_Reporte.Text = "Generar Reporte";
            this.btn_Generar_Reporte.Click += new System.EventHandler(this.btnCargarReporte_Click);
            // 
            // cmb_centro_costo
            // 
            this.cmb_centro_costo.Location = new System.Drawing.Point(663, 17);
            this.cmb_centro_costo.Name = "cmb_centro_costo";
            this.cmb_centro_costo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_centro_costo.Properties.DisplayMember = "Centro_costo";
            this.cmb_centro_costo.Properties.PopupView = this.searchLookUpEdit1View;
            this.cmb_centro_costo.Properties.ValueMember = "IdCentroCosto";
            this.cmb_centro_costo.Size = new System.Drawing.Size(282, 20);
            this.cmb_centro_costo.TabIndex = 22;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCentroCosto,
            this.colCentro_costo});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCentroCosto
            // 
            this.colIdCentroCosto.Caption = "IdCentroCosto";
            this.colIdCentroCosto.FieldName = "IdCentroCosto";
            this.colIdCentroCosto.Name = "colIdCentroCosto";
            this.colIdCentroCosto.Visible = true;
            this.colIdCentroCosto.VisibleIndex = 0;
            this.colIdCentroCosto.Width = 122;
            // 
            // colCentro_costo
            // 
            this.colCentro_costo.Caption = "Centro_costo";
            this.colCentro_costo.FieldName = "Centro_costo";
            this.colCentro_costo.Name = "colCentro_costo";
            this.colCentro_costo.Visible = true;
            this.colCentro_costo.VisibleIndex = 1;
            this.colCentro_costo.Width = 597;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Centro Costo:";
            // 
            // uCct_Pto_Cargo_Grupo
            // 
            this.uCct_Pto_Cargo_Grupo.Location = new System.Drawing.Point(586, 37);
            this.uCct_Pto_Cargo_Grupo.Name = "uCct_Pto_Cargo_Grupo";
            this.uCct_Pto_Cargo_Grupo.Size = new System.Drawing.Size(369, 54);
            this.uCct_Pto_Cargo_Grupo.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(202, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 13);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Hasta:";
            // 
            // dt_FechaDesde
            // 
            this.dt_FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_FechaDesde.Location = new System.Drawing.Point(87, 14);
            this.dt_FechaDesde.Name = "dt_FechaDesde";
            this.dt_FechaDesde.Size = new System.Drawing.Size(100, 20);
            this.dt_FechaDesde.TabIndex = 18;
            // 
            // chkMostrar_Cero
            // 
            this.chkMostrar_Cero.AutoSize = true;
            this.chkMostrar_Cero.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMostrar_Cero.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkMostrar_Cero.Location = new System.Drawing.Point(208, 40);
            this.chkMostrar_Cero.Name = "chkMostrar_Cero";
            this.chkMostrar_Cero.Size = new System.Drawing.Size(143, 17);
            this.chkMostrar_Cero.TabIndex = 0;
            this.chkMostrar_Cero.Text = "Mostrar registros en Cero";
            this.chkMostrar_Cero.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkMostrar_Cero.UseVisualStyleBackColor = true;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Location = new System.Drawing.Point(36, 16);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(34, 13);
            this.lblPeriodo.TabIndex = 15;
            this.lblPeriodo.Text = "Desde:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(251, 13);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaHasta.TabIndex = 9;
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaCorte_ValueChanged);
            // 
            // gridConsulta
            // 
            this.gridConsulta.Location = new System.Drawing.Point(345, 147);
            this.gridConsulta.MainView = this.gridView;
            this.gridConsulta.Name = "gridConsulta";
            this.gridConsulta.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.GridLookUpEditCtaCtble,
            this.GridLookUpEditSucursal,
            this.cmbCtaCble,
            this.repositoryCmbAnticipo});
            this.gridConsulta.Size = new System.Drawing.Size(358, 218);
            this.gridConsulta.TabIndex = 31;
            this.gridConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridConsulta.Visible = false;
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Id_CtaCble,
            this.colnom_cuenta,
            this.ColSaldoInicial,
            this.ColDebe,
            this.ColCredito,
            this.ColSaldo});
            this.gridView.GridControl = this.gridConsulta;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // col_Id_CtaCble
            // 
            this.col_Id_CtaCble.Caption = "IdCuenta";
            this.col_Id_CtaCble.FieldName = "IdCtaCble";
            this.col_Id_CtaCble.Name = "col_Id_CtaCble";
            this.col_Id_CtaCble.Visible = true;
            this.col_Id_CtaCble.VisibleIndex = 0;
            // 
            // colnom_cuenta
            // 
            this.colnom_cuenta.Caption = "Descripcion";
            this.colnom_cuenta.FieldName = "nom_cuenta";
            this.colnom_cuenta.Name = "colnom_cuenta";
            this.colnom_cuenta.Visible = true;
            this.colnom_cuenta.VisibleIndex = 1;
            // 
            // ColSaldoInicial
            // 
            this.ColSaldoInicial.Caption = "SaldoIncial";
            this.ColSaldoInicial.FieldName = "Saldo_Inicial";
            this.ColSaldoInicial.Name = "ColSaldoInicial";
            this.ColSaldoInicial.Visible = true;
            this.ColSaldoInicial.VisibleIndex = 2;
            // 
            // ColDebe
            // 
            this.ColDebe.Caption = "Debe";
            this.ColDebe.FieldName = "Debito_Mes";
            this.ColDebe.Name = "ColDebe";
            this.ColDebe.Visible = true;
            this.ColDebe.VisibleIndex = 3;
            // 
            // ColCredito
            // 
            this.ColCredito.Caption = "Haber";
            this.ColCredito.FieldName = "Credito_Mes";
            this.ColCredito.Name = "ColCredito";
            this.ColCredito.Visible = true;
            this.ColCredito.VisibleIndex = 4;
            // 
            // ColSaldo
            // 
            this.ColSaldo.Caption = "Saldo";
            this.ColSaldo.FieldName = "Saldo";
            this.ColSaldo.Name = "ColSaldo";
            this.ColSaldo.Visible = true;
            this.ColSaldo.VisibleIndex = 5;
            // 
            // GridLookUpEditCtaCtble
            // 
            this.GridLookUpEditCtaCtble.AutoHeight = false;
            this.GridLookUpEditCtaCtble.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GridLookUpEditCtaCtble.DisplayMember = "pc_Cuenta";
            this.GridLookUpEditCtaCtble.Name = "GridLookUpEditCtaCtble";
            this.GridLookUpEditCtaCtble.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.GridLookUpEditCtaCtble.ValueMember = "IdCtaCble";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpc_Cuenta,
            this.colIdCtaCble});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colpc_Cuenta
            // 
            this.colpc_Cuenta.Caption = "Cuenta";
            this.colpc_Cuenta.FieldName = "pc_Cuenta";
            this.colpc_Cuenta.Name = "colpc_Cuenta";
            this.colpc_Cuenta.Visible = true;
            this.colpc_Cuenta.VisibleIndex = 0;
            // 
            // colIdCtaCble
            // 
            this.colIdCtaCble.Caption = "Cta Cble";
            this.colIdCtaCble.FieldName = "IdCtaCble";
            this.colIdCtaCble.Name = "colIdCtaCble";
            this.colIdCtaCble.Visible = true;
            this.colIdCtaCble.VisibleIndex = 1;
            // 
            // GridLookUpEditSucursal
            // 
            this.GridLookUpEditSucursal.AutoHeight = false;
            this.GridLookUpEditSucursal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GridLookUpEditSucursal.DisplayMember = "Su_Descripcion";
            this.GridLookUpEditSucursal.Name = "GridLookUpEditSucursal";
            this.GridLookUpEditSucursal.PopupView = this.gridViewSucursal;
            this.GridLookUpEditSucursal.ValueMember = "IdSucursal";
            // 
            // gridViewSucursal
            // 
            this.gridViewSucursal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa1,
            this.colIdSucursal1,
            this.colSu_Descripcion});
            this.gridViewSucursal.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewSucursal.Name = "gridViewSucursal";
            this.gridViewSucursal.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewSucursal.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpresa1
            // 
            this.colIdEmpresa1.FieldName = "IdEmpresa";
            this.colIdEmpresa1.Name = "colIdEmpresa1";
            // 
            // colIdSucursal1
            // 
            this.colIdSucursal1.FieldName = "IdSucursal";
            this.colIdSucursal1.Name = "colIdSucursal1";
            // 
            // colSu_Descripcion
            // 
            this.colSu_Descripcion.Caption = "Nombre";
            this.colSu_Descripcion.FieldName = "Su_Descripcion";
            this.colSu_Descripcion.Name = "colSu_Descripcion";
            this.colSu_Descripcion.Visible = true;
            this.colSu_Descripcion.VisibleIndex = 0;
            // 
            // cmbCtaCble
            // 
            this.cmbCtaCble.AutoHeight = false;
            this.cmbCtaCble.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCtaCble.DisplayMember = "pc_Cuenta2";
            this.cmbCtaCble.Name = "cmbCtaCble";
            this.cmbCtaCble.PopupView = this.repositoryItemSearchLookUpEdit1View;
            this.cmbCtaCble.ValueMember = "IdCtaCble";
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa2,
            this.colIdCtaCble1,
            this.colpc_Cuenta1,
            this.colpc_Cuenta2,
            this.colIdCtaCblePadre,
            this.colIdCatalogo1,
            this.colpc_Naturaleza,
            this.colIdNivelCta,
            this.colIdGrupoCble,
            this.colpc_Estado,
            this.colpc_EsMovimiento,
            this.colpc_es_flujo_efectivo,
            this.colpc_clave_corta,
            this.col_Plancta_nivel_Info,
            this.colCheck,
            this.colCuentaPadre});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpresa2
            // 
            this.colIdEmpresa2.FieldName = "IdEmpresa";
            this.colIdEmpresa2.Name = "colIdEmpresa2";
            // 
            // colIdCtaCble1
            // 
            this.colIdCtaCble1.Caption = "Cta Cble";
            this.colIdCtaCble1.FieldName = "IdCtaCble";
            this.colIdCtaCble1.Name = "colIdCtaCble1";
            this.colIdCtaCble1.Visible = true;
            this.colIdCtaCble1.VisibleIndex = 1;
            this.colIdCtaCble1.Width = 147;
            // 
            // colpc_Cuenta1
            // 
            this.colpc_Cuenta1.Caption = "Cuenta";
            this.colpc_Cuenta1.FieldName = "pc_Cuenta";
            this.colpc_Cuenta1.Name = "colpc_Cuenta1";
            this.colpc_Cuenta1.Visible = true;
            this.colpc_Cuenta1.VisibleIndex = 2;
            this.colpc_Cuenta1.Width = 932;
            // 
            // colpc_Cuenta2
            // 
            this.colpc_Cuenta2.FieldName = "pc_Cuenta2";
            this.colpc_Cuenta2.Name = "colpc_Cuenta2";
            // 
            // colIdCtaCblePadre
            // 
            this.colIdCtaCblePadre.FieldName = "IdCtaCblePadre";
            this.colIdCtaCblePadre.Name = "colIdCtaCblePadre";
            // 
            // colIdCatalogo1
            // 
            this.colIdCatalogo1.FieldName = "IdCatalogo";
            this.colIdCatalogo1.Name = "colIdCatalogo1";
            // 
            // colpc_Naturaleza
            // 
            this.colpc_Naturaleza.FieldName = "pc_Naturaleza";
            this.colpc_Naturaleza.Name = "colpc_Naturaleza";
            // 
            // colIdNivelCta
            // 
            this.colIdNivelCta.FieldName = "IdNivelCta";
            this.colIdNivelCta.Name = "colIdNivelCta";
            // 
            // colIdGrupoCble
            // 
            this.colIdGrupoCble.FieldName = "IdGrupoCble";
            this.colIdGrupoCble.Name = "colIdGrupoCble";
            // 
            // colpc_Estado
            // 
            this.colpc_Estado.FieldName = "pc_Estado";
            this.colpc_Estado.Name = "colpc_Estado";
            // 
            // colpc_EsMovimiento
            // 
            this.colpc_EsMovimiento.FieldName = "pc_EsMovimiento";
            this.colpc_EsMovimiento.Name = "colpc_EsMovimiento";
            // 
            // colpc_es_flujo_efectivo
            // 
            this.colpc_es_flujo_efectivo.FieldName = "pc_es_flujo_efectivo";
            this.colpc_es_flujo_efectivo.Name = "colpc_es_flujo_efectivo";
            // 
            // colpc_clave_corta
            // 
            this.colpc_clave_corta.Caption = "Clave Corta";
            this.colpc_clave_corta.FieldName = "pc_clave_corta";
            this.colpc_clave_corta.Name = "colpc_clave_corta";
            this.colpc_clave_corta.Visible = true;
            this.colpc_clave_corta.VisibleIndex = 0;
            this.colpc_clave_corta.Width = 95;
            // 
            // col_Plancta_nivel_Info
            // 
            this.col_Plancta_nivel_Info.FieldName = "_Plancta_nivel_Info";
            this.col_Plancta_nivel_Info.Name = "col_Plancta_nivel_Info";
            // 
            // colCheck
            // 
            this.colCheck.FieldName = "Check";
            this.colCheck.Name = "colCheck";
            // 
            // colCuentaPadre
            // 
            this.colCuentaPadre.FieldName = "CuentaPadre";
            this.colCuentaPadre.Name = "colCuentaPadre";
            // 
            // repositoryCmbAnticipo
            // 
            this.repositoryCmbAnticipo.AutoHeight = false;
            this.repositoryCmbAnticipo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryCmbAnticipo.DisplayMember = "pc_Cuenta2";
            this.repositoryCmbAnticipo.Name = "repositoryCmbAnticipo";
            this.repositoryCmbAnticipo.PopupView = this.gridView2;
            this.repositoryCmbAnticipo.ValueMember = "IdCtaCble";
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpc_CuentaAnti});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colpc_CuentaAnti
            // 
            this.colpc_CuentaAnti.Caption = "Cuenta";
            this.colpc_CuentaAnti.FieldName = "pc_Cuenta2";
            this.colpc_CuentaAnti.Name = "colpc_CuentaAnti";
            this.colpc_CuentaAnti.Visible = true;
            this.colpc_CuentaAnti.VisibleIndex = 0;
            // 
            // XCONTA_Rpt007_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 434);
            this.Controls.Add(this.gridConsulta);
            this.Controls.Add(this.gc_balance_comp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "XCONTA_Rpt007_frm";
            this.Text = "Reporte Balance de Comprobación";
            this.Load += new System.EventHandler(this.XCONTA_Rpt007_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_balance_comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_balance_comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIcono)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_centro_costo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditCtaCtble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLookUpEditSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCtaCble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCmbAnticipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_balance_comp;
        private DevExpress.XtraGrid.Views.Grid.GridView gw_balance_comp;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdCtaCble;
        private DevExpress.XtraGrid.Columns.GridColumn col_nom_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn col_GrupoCble;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdCtaCblePadre;
        private DevExpress.XtraGrid.Columns.GridColumn col_Saldo_Inicial;
        private DevExpress.XtraGrid.Columns.GridColumn col_Saldo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblPeriodo;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.CheckBox chkMostrar_Cero;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_imagen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dt_FechaDesde;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo_x_Movi;
        private DevExpress.XtraGrid.Columns.GridColumn col_pc_EsMovimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colDebito_Mes;
        private DevExpress.XtraGrid.Columns.GridColumn colCredito_Mes;
        private Controles.UCct_Pto_Cargo_Grupo uCct_Pto_Cargo_Grupo;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_centro_costo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btn_Generar_Reporte;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbIcono;
        private System.Windows.Forms.CheckBox chkMostrarCC;
        private System.Windows.Forms.ToolStripButton btn_imprimir_grilla;
        public DevExpress.XtraGrid.GridControl gridConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbCtaCble;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble1;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta1;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCblePadre;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo1;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Naturaleza;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNivelCta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGrupoCble;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Estado;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_EsMovimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_es_flujo_efectivo;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_clave_corta;
        private DevExpress.XtraGrid.Columns.GridColumn col_Plancta_nivel_Info;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colCuentaPadre;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit GridLookUpEditSucursal;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal1;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryCmbAnticipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_CuentaAnti;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit GridLookUpEditCtaCtble;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        private DevExpress.XtraGrid.Columns.GridColumn col_Id_CtaCble;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn ColSaldoInicial;
        private DevExpress.XtraGrid.Columns.GridColumn ColDebe;
        private DevExpress.XtraGrid.Columns.GridColumn ColCredito;
        private DevExpress.XtraGrid.Columns.GridColumn ColSaldo;
        private System.Windows.Forms.ToolStripButton btnImprimirExcel;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}