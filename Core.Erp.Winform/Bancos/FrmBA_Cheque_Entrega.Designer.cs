namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_Cheque_Entrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBA_Cheque_Entrega));
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlCbteCble = new DevExpress.XtraGrid.GridControl();
            this.gridViewCbteCble = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCbteCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipocbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtNotaAdicional = new DevExpress.XtraEditors.MemoEdit();
            this.dtpFechaEntrega = new DevExpress.XtraEditors.DateEdit();
            this.txtApellidos = new DevExpress.XtraEditors.TextEdit();
            this.txtNombres = new DevExpress.XtraEditors.TextEdit();
            this.txtCedula = new DevExpress.XtraEditors.TextEdit();
            this.btnFileDialog = new DevExpress.XtraEditors.SimpleButton();
            this.btnCamera = new DevExpress.XtraEditors.SimpleButton();
            this.pic_foto = new System.Windows.Forms.PictureBox();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCbteCble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCbteCble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotaAdicional.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaEntrega.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaEntrega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlCbteCble);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(549, 351);
            this.groupControl1.TabIndex = 3;
            // 
            // gridControlCbteCble
            // 
            this.gridControlCbteCble.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCbteCble.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlCbteCble.Location = new System.Drawing.Point(2, 181);
            this.gridControlCbteCble.MainView = this.gridViewCbteCble;
            this.gridControlCbteCble.Margin = new System.Windows.Forms.Padding(2);
            this.gridControlCbteCble.Name = "gridControlCbteCble";
            this.gridControlCbteCble.Size = new System.Drawing.Size(545, 168);
            this.gridControlCbteCble.TabIndex = 3;
            this.gridControlCbteCble.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCbteCble});
            // 
            // gridViewCbteCble
            // 
            this.gridViewCbteCble.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdCbteCble,
            this.colIdTipocbte,
            this.colFecha,
            this.colCheque,
            this.colObservacion,
            this.colValor});
            this.gridViewCbteCble.DetailHeight = 284;
            this.gridViewCbteCble.GridControl = this.gridControlCbteCble;
            this.gridViewCbteCble.Name = "gridViewCbteCble";
            this.gridViewCbteCble.OptionsBehavior.Editable = false;
            this.gridViewCbteCble.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCbteCble.OptionsView.ShowFooter = true;
            this.gridViewCbteCble.OptionsView.ShowGroupPanel = false;
            this.gridViewCbteCble.OptionsView.ShowViewCaption = true;
            this.gridViewCbteCble.ViewCaption = "Datos del Cheque";
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.Caption = "IdEmpresa";
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.MinWidth = 15;
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Width = 56;
            // 
            // colIdCbteCble
            // 
            this.colIdCbteCble.Caption = "IdCbteCble";
            this.colIdCbteCble.FieldName = "IdCbteCble";
            this.colIdCbteCble.MinWidth = 15;
            this.colIdCbteCble.Name = "colIdCbteCble";
            this.colIdCbteCble.Width = 56;
            // 
            // colIdTipocbte
            // 
            this.colIdTipocbte.Caption = "TipoCbte";
            this.colIdTipocbte.FieldName = "IdTipocbte";
            this.colIdTipocbte.MinWidth = 15;
            this.colIdTipocbte.Name = "colIdTipocbte";
            this.colIdTipocbte.Width = 56;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.DisplayFormat.FormatString = "d";
            this.colFecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFecha.FieldName = "cb_Fecha";
            this.colFecha.MinWidth = 15;
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            this.colFecha.Width = 68;
            // 
            // colCheque
            // 
            this.colCheque.Caption = "# Cheque";
            this.colCheque.FieldName = "cb_Cheque";
            this.colCheque.MinWidth = 15;
            this.colCheque.Name = "colCheque";
            this.colCheque.Visible = true;
            this.colCheque.VisibleIndex = 1;
            this.colCheque.Width = 78;
            // 
            // colObservacion
            // 
            this.colObservacion.Caption = "Observación";
            this.colObservacion.FieldName = "cb_Observacion";
            this.colObservacion.MinWidth = 15;
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 2;
            this.colObservacion.Width = 170;
            // 
            // colValor
            // 
            this.colValor.Caption = "Valor";
            this.colValor.DisplayFormat.FormatString = "{0:n2}";
            this.colValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValor.FieldName = "cb_Valor";
            this.colValor.MinWidth = 15;
            this.colValor.Name = "colValor";
            this.colValor.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cb_Valor", "{0:n2}")});
            this.colValor.Visible = true;
            this.colValor.VisibleIndex = 3;
            this.colValor.Width = 77;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtNotaAdicional);
            this.groupControl2.Controls.Add(this.dtpFechaEntrega);
            this.groupControl2.Controls.Add(this.txtApellidos);
            this.groupControl2.Controls.Add(this.txtNombres);
            this.groupControl2.Controls.Add(this.txtCedula);
            this.groupControl2.Controls.Add(this.btnFileDialog);
            this.groupControl2.Controls.Add(this.btnCamera);
            this.groupControl2.Controls.Add(this.pic_foto);
            this.groupControl2.Controls.Add(this.labelControl13);
            this.groupControl2.Controls.Add(this.labelControl12);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(2, 23);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(545, 158);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Datos  de la Persona Recibe Cheque";
            // 
            // txtNotaAdicional
            // 
            this.txtNotaAdicional.Location = new System.Drawing.Point(91, 115);
            this.txtNotaAdicional.Margin = new System.Windows.Forms.Padding(2);
            this.txtNotaAdicional.Name = "txtNotaAdicional";
            this.txtNotaAdicional.Size = new System.Drawing.Size(300, 32);
            this.txtNotaAdicional.TabIndex = 137;
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.EditValue = new System.DateTime(2024, 1, 29, 20, 28, 33, 986);
            this.dtpFechaEntrega.Location = new System.Drawing.Point(91, 23);
            this.dtpFechaEntrega.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaEntrega.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaEntrega.Properties.Mask.EditMask = "g";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(75, 20);
            this.dtpFechaEntrega.TabIndex = 136;
            // 
            // txtApellidos
            // 
            this.txtApellidos.EditValue = "";
            this.txtApellidos.Location = new System.Drawing.Point(91, 92);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Properties.MaxLength = 100;
            this.txtApellidos.Size = new System.Drawing.Size(150, 20);
            this.txtApellidos.TabIndex = 135;
            // 
            // txtNombres
            // 
            this.txtNombres.EditValue = "";
            this.txtNombres.Location = new System.Drawing.Point(91, 69);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Properties.MaxLength = 100;
            this.txtNombres.Size = new System.Drawing.Size(150, 20);
            this.txtNombres.TabIndex = 134;
            // 
            // txtCedula
            // 
            this.txtCedula.EditValue = "";
            this.txtCedula.Location = new System.Drawing.Point(91, 46);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Properties.MaxLength = 13;
            this.txtCedula.Size = new System.Drawing.Size(75, 20);
            this.txtCedula.TabIndex = 133;
            this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
            // 
            // btnFileDialog
            // 
            this.btnFileDialog.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFileDialog.ImageOptions.SvgImage")));
            this.btnFileDialog.Location = new System.Drawing.Point(351, 68);
            this.btnFileDialog.Name = "btnFileDialog";
            this.btnFileDialog.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnFileDialog.Size = new System.Drawing.Size(40, 33);
            this.btnFileDialog.TabIndex = 132;
            this.btnFileDialog.Click += new System.EventHandler(this.btnFileDialog_Click);
            // 
            // btnCamera
            // 
            this.btnCamera.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCamera.ImageOptions.SvgImage")));
            this.btnCamera.Location = new System.Drawing.Point(351, 31);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCamera.Size = new System.Drawing.Size(39, 33);
            this.btnCamera.TabIndex = 131;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // pic_foto
            // 
            this.pic_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_foto.Location = new System.Drawing.Point(396, 25);
            this.pic_foto.Name = "pic_foto";
            this.pic_foto.Size = new System.Drawing.Size(128, 124);
            this.pic_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_foto.TabIndex = 24;
            this.pic_foto.TabStop = false;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(10, 95);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(45, 13);
            this.labelControl13.TabIndex = 21;
            this.labelControl13.Text = "Apellidos:";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(10, 71);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(45, 13);
            this.labelControl12.TabIndex = 20;
            this.labelControl12.Text = "Nombres:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(10, 122);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(72, 13);
            this.labelControl10.TabIndex = 15;
            this.labelControl10.Text = "Nota Adicional:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(10, 49);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(36, 13);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "Cedula:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(10, 25);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(73, 13);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Fecha Entrega:";
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
            this.ucGe_Menu.Size = new System.Drawing.Size(549, 24);
            this.ucGe_Menu.TabIndex = 4;
            this.ucGe_Menu.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_bntAprobar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_bntDiseñoReporte = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_bntImprimir = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_bntImprimir_Guia = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_bntLimpiar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_bntReImprimir = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_bntSalir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_btn_Actualizar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btn_Generar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnAceptar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnContabilizar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnEstadosOC = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpFrm = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpLote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpRep = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImprimirSoporte = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnModificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnproductos = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // FrmBA_Cheque_Entrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 351);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.Name = "FrmBA_Cheque_Entrega";
            this.Text = "Entrega de Cheque";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrnBA_entrega_cheque_FormClosing);
            this.Load += new System.EventHandler(this.FrnBA_entrega_cheque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCbteCble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCbteCble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotaAdicional.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaEntrega.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaEntrega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlCbteCble;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCbteCble;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbteCble;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipocbte;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.MemoEdit txtNotaAdicional;
        private DevExpress.XtraEditors.DateEdit dtpFechaEntrega;
        private DevExpress.XtraEditors.TextEdit txtApellidos;
        private DevExpress.XtraEditors.TextEdit txtNombres;
        private DevExpress.XtraEditors.TextEdit txtCedula;
        private DevExpress.XtraEditors.SimpleButton btnFileDialog;
        private DevExpress.XtraEditors.SimpleButton btnCamera;
        private System.Windows.Forms.PictureBox pic_foto;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
    }
}