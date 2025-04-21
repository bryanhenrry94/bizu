namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_CbteCble_Mant
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
            this.cmb_tipocomprobante = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.ctCbtecbletipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbvwtipoComp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltc_TipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidTipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_Interno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCbte_Anul = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodTipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_Nemonico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_codCbteCble = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txt_concepto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_no_comprobante = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lbl_descargar_excel = new System.Windows.Forms.LinkLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.UC_Diario = new Core.Erp.Winform.Controles.UCCon_GridDiarioContable();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.frmConTipoCbteCbleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipocomprobante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCbtecbletipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbvwtipoComp)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmConTipoCbteCbleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_tipocomprobante
            // 
            this.cmb_tipocomprobante.Enabled = false;
            this.cmb_tipocomprobante.Location = new System.Drawing.Point(375, 34);
            this.cmb_tipocomprobante.Name = "cmb_tipocomprobante";
            this.cmb_tipocomprobante.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_tipocomprobante.Properties.DataSource = this.ctCbtecbletipoInfoBindingSource;
            this.cmb_tipocomprobante.Properties.DisplayMember = "tc_TipoCbte";
            this.cmb_tipocomprobante.Properties.PopupView = this.cmbvwtipoComp;
            this.cmb_tipocomprobante.Properties.ValueMember = "IdTipoCbte";
            this.cmb_tipocomprobante.Size = new System.Drawing.Size(250, 20);
            this.cmb_tipocomprobante.TabIndex = 23;
            this.cmb_tipocomprobante.EditValueChanged += new System.EventHandler(this.cmb_tipocomprobante_EditValueChanged);
            // 
            // ctCbtecbletipoInfoBindingSource
            // 
            this.ctCbtecbletipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Cbtecble_tipo_Info);
            // 
            // cmbvwtipoComp
            // 
            this.cmbvwtipoComp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltc_TipoCbte,
            this.colidTipoCbte,
            this.coltc_Interno,
            this.coltc_Estado,
            this.colIdTipoCbte_Anul,
            this.colCodTipoCbte,
            this.coltc_Nemonico});
            this.cmbvwtipoComp.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cmbvwtipoComp.Name = "cmbvwtipoComp";
            this.cmbvwtipoComp.OptionsBehavior.Editable = false;
            this.cmbvwtipoComp.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cmbvwtipoComp.OptionsView.ShowGroupPanel = false;
            // 
            // coltc_TipoCbte
            // 
            this.coltc_TipoCbte.Caption = "Tipo";
            this.coltc_TipoCbte.FieldName = "tc_TipoCbte";
            this.coltc_TipoCbte.Name = "coltc_TipoCbte";
            this.coltc_TipoCbte.Visible = true;
            this.coltc_TipoCbte.VisibleIndex = 0;
            this.coltc_TipoCbte.Width = 295;
            // 
            // colidTipoCbte
            // 
            this.colidTipoCbte.Caption = "ID";
            this.colidTipoCbte.FieldName = "IdTipoCbte";
            this.colidTipoCbte.Name = "colidTipoCbte";
            this.colidTipoCbte.Visible = true;
            this.colidTipoCbte.VisibleIndex = 2;
            this.colidTipoCbte.Width = 497;
            // 
            // coltc_Interno
            // 
            this.coltc_Interno.Caption = "Interno";
            this.coltc_Interno.FieldName = "tc_Interno";
            this.coltc_Interno.Name = "coltc_Interno";
            this.coltc_Interno.Visible = true;
            this.coltc_Interno.VisibleIndex = 3;
            this.coltc_Interno.Width = 93;
            // 
            // coltc_Estado
            // 
            this.coltc_Estado.FieldName = "tc_Estado";
            this.coltc_Estado.Name = "coltc_Estado";
            // 
            // colIdTipoCbte_Anul
            // 
            this.colIdTipoCbte_Anul.FieldName = "IdTipoCbte_Anul";
            this.colIdTipoCbte_Anul.Name = "colIdTipoCbte_Anul";
            // 
            // colCodTipoCbte
            // 
            this.colCodTipoCbte.FieldName = "CodTipoCbte";
            this.colCodTipoCbte.Name = "colCodTipoCbte";
            this.colCodTipoCbte.OptionsColumn.AllowEdit = false;
            this.colCodTipoCbte.Visible = true;
            this.colCodTipoCbte.VisibleIndex = 1;
            this.colCodTipoCbte.Width = 295;
            // 
            // coltc_Nemonico
            // 
            this.coltc_Nemonico.FieldName = "tc_Nemonico";
            this.coltc_Nemonico.Name = "coltc_Nemonico";
            this.coltc_Nemonico.OptionsColumn.AllowEdit = false;
            // 
            // txt_codCbteCble
            // 
            this.txt_codCbteCble.Location = new System.Drawing.Point(125, 35);
            this.txt_codCbteCble.MaxLength = 20;
            this.txt_codCbteCble.Name = "txt_codCbteCble";
            this.txt_codCbteCble.Size = new System.Drawing.Size(75, 20);
            this.txt_codCbteCble.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Código Comprobante:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de Comprobante:";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(375, 9);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(100, 20);
            this.dtFecha.TabIndex = 8;
            // 
            // txt_concepto
            // 
            this.txt_concepto.Location = new System.Drawing.Point(125, 62);
            this.txt_concepto.MaxLength = 250;
            this.txt_concepto.Multiline = true;
            this.txt_concepto.Name = "txt_concepto";
            this.txt_concepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_concepto.Size = new System.Drawing.Size(800, 60);
            this.txt_concepto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Concepto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de Comprobante:";
            // 
            // lbl_no_comprobante
            // 
            this.lbl_no_comprobante.BackColor = System.Drawing.Color.White;
            this.lbl_no_comprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_no_comprobante.Location = new System.Drawing.Point(125, 9);
            this.lbl_no_comprobante.Name = "lbl_no_comprobante";
            this.lbl_no_comprobante.Size = new System.Drawing.Size(75, 21);
            this.lbl_no_comprobante.TabIndex = 1;
            this.lbl_no_comprobante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Comprobante:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lbl_descargar_excel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_tipocomprobante);
            this.panel1.Controls.Add(this.txt_concepto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtFecha);
            this.panel1.Controls.Add(this.txt_codCbteCble);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl_no_comprobante);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 130);
            this.panel1.TabIndex = 24;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.Location = new System.Drawing.Point(503, 12);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(35, 13);
            this.lblEstado.TabIndex = 46;
            this.lblEstado.Text = "label7";
            this.lblEstado.Visible = false;
            // 
            // lbl_descargar_excel
            // 
            this.lbl_descargar_excel.AutoSize = true;
            this.lbl_descargar_excel.Location = new System.Drawing.Point(731, 38);
            this.lbl_descargar_excel.Name = "lbl_descargar_excel";
            this.lbl_descargar_excel.Size = new System.Drawing.Size(194, 13);
            this.lbl_descargar_excel.TabIndex = 45;
            this.lbl_descargar_excel.TabStop = true;
            this.lbl_descargar_excel.Text = "Descargar plantilla de excel para diarios";
            this.lbl_descargar_excel.Visible = false;
            this.lbl_descargar_excel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_descargar_excel_LinkClicked);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xls";
            this.saveFileDialog1.FileName = "Plantilla_diario";
            // 
            // UC_Diario
            // 
            this.UC_Diario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UC_Diario.IdCtaCble_x_Banco = null;
            this.UC_Diario.Location = new System.Drawing.Point(0, 159);
            this.UC_Diario.Name = "UC_Diario";
            this.UC_Diario.Size = new System.Drawing.Size(946, 295);
            this.UC_Diario.TabIndex = 0;
            this.UC_Diario.valorTxt = null;
            this.UC_Diario.Visible_Botones = false;
            this.UC_Diario.Visible_Cabecera = false;
            this.UC_Diario.Visible_columna_CentroCosto = true;
            this.UC_Diario.Visible_columna_GrupoPuntoCargo = false;
            this.UC_Diario.Visible_columna_PuntoCargo = false;
            this.UC_Diario.Visible_columna_SubCentroCosto = false;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(946, 29);
            this.ucGe_Menu.TabIndex = 5;
            this.ucGe_Menu.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_bntAprobar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_bntDiseñoReporte = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_bntImprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_bntImprimir_Guia = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_bntLimpiar = DevExpress.XtraBars.BarItemVisibility.Always;
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
            this.ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_btnImpFrm = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpLote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpRep = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImprimirSoporte = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnModificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnproductos = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // frmConTipoCbteCbleBindingSource
            // 
            this.frmConTipoCbteCbleBindingSource.DataSource = typeof(Core.Erp.Winform.Contabilidad.frmCon_TipoCbteCble_Cons);
            // 
            // frmCon_CbteCble_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 454);
            this.Controls.Add(this.UC_Diario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmCon_CbteCble_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprobante Contable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCon_CbteCble_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmCon_CbteCble_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipocomprobante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCbtecbletipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbvwtipoComp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmConTipoCbteCbleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_codCbteCble;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox txt_concepto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_no_comprobante;
        private System.Windows.Forms.Label label1;
        private Controles.UCCon_GridDiarioContable UC_Diario;
        private DevExpress.XtraGrid.Views.Grid.GridView cmbvwtipoComp;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_TipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn colidTipoCbte;
        private System.Windows.Forms.BindingSource ctCbtecbletipoInfoBindingSource;
        private System.Windows.Forms.BindingSource frmConTipoCbteCbleBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_Interno;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_Estado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte_Anul;
        private DevExpress.XtraGrid.Columns.GridColumn colCodTipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_Nemonico;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lbl_descargar_excel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblEstado;
        public DevExpress.XtraEditors.SearchLookUpEdit cmb_tipocomprobante;
    }
}