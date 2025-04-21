namespace Core.Erp.Winform.General
{
    partial class FrmGe_Secuencia_Documento_Talonario_Mant
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpuntoEmision = new DevExpress.XtraEditors.TextEdit();
            this.txtEstablecimiento = new DevExpress.XtraEditors.TextEdit();
            this.txtUltDoc = new DevExpress.XtraEditors.TextEdit();
            this.txtGenerar = new DevExpress.XtraEditors.TextEdit();
            this.txtFoco = new System.Windows.Forms.TextBox();
            this.ultraCmbE_TipoDoc = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDocFinal = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnumeroDoc = new DevExpress.XtraEditors.TextEdit();
            this.lblfechacad = new System.Windows.Forms.Label();
            this.lblumdocumento = new System.Windows.Forms.Label();
            this.chkUsado = new System.Windows.Forms.CheckBox();
            this.lblnumautorizacion = new System.Windows.Forms.Label();
            this.txtNumeroAut = new DevExpress.XtraEditors.TextEdit();
            this.chkestado = new System.Windows.Forms.CheckBox();
            this.dtFechaCad = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkelectronica = new System.Windows.Forms.CheckBox();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.txtpuntoEmision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstablecimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenerar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmbE_TipoDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumeroDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroAut.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Punto Emision";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Establecimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Documento Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad a Generar";
            // 
            // txtpuntoEmision
            // 
            this.txtpuntoEmision.Location = new System.Drawing.Point(103, 79);
            this.txtpuntoEmision.Name = "txtpuntoEmision";
            this.txtpuntoEmision.Properties.Appearance.Options.UseTextOptions = true;
            this.txtpuntoEmision.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtpuntoEmision.Properties.Mask.BeepOnError = true;
            this.txtpuntoEmision.Properties.Mask.SaveLiteral = false;
            this.txtpuntoEmision.Size = new System.Drawing.Size(75, 20);
            this.txtpuntoEmision.TabIndex = 2;
            this.txtpuntoEmision.EditValueChanged += new System.EventHandler(this.txtpuntoEmision_EditValueChanged);
            this.txtpuntoEmision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpuntoEmision_KeyPress);
            // 
            // txtEstablecimiento
            // 
            this.txtEstablecimiento.Location = new System.Drawing.Point(15, 79);
            this.txtEstablecimiento.Name = "txtEstablecimiento";
            this.txtEstablecimiento.Properties.Appearance.Options.UseTextOptions = true;
            this.txtEstablecimiento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtEstablecimiento.Properties.Mask.BeepOnError = true;
            this.txtEstablecimiento.Properties.Mask.SaveLiteral = false;
            this.txtEstablecimiento.Size = new System.Drawing.Size(75, 20);
            this.txtEstablecimiento.TabIndex = 1;
            this.txtEstablecimiento.EditValueChanged += new System.EventHandler(this.txtEstablecimiento_EditValueChanged);
            this.txtEstablecimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstablecimiento_KeyPress);
            // 
            // txtUltDoc
            // 
            this.txtUltDoc.Location = new System.Drawing.Point(190, 79);
            this.txtUltDoc.Name = "txtUltDoc";
            this.txtUltDoc.Properties.Appearance.Options.UseTextOptions = true;
            this.txtUltDoc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtUltDoc.Properties.Mask.BeepOnError = true;
            this.txtUltDoc.Properties.Mask.EditMask = "\\d?{0,50}";
            this.txtUltDoc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtUltDoc.Properties.Mask.SaveLiteral = false;
            this.txtUltDoc.Size = new System.Drawing.Size(75, 20);
            this.txtUltDoc.TabIndex = 3;
            this.txtUltDoc.EditValueChanged += new System.EventHandler(this.txtUltDoc_EditValueChanged);
            // 
            // txtGenerar
            // 
            this.txtGenerar.Location = new System.Drawing.Point(15, 121);
            this.txtGenerar.Name = "txtGenerar";
            this.txtGenerar.Properties.Appearance.Options.UseTextOptions = true;
            this.txtGenerar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtGenerar.Properties.Mask.BeepOnError = true;
            this.txtGenerar.Properties.Mask.SaveLiteral = false;
            this.txtGenerar.Size = new System.Drawing.Size(75, 20);
            this.txtGenerar.TabIndex = 4;
            this.txtGenerar.EditValueChanged += new System.EventHandler(this.txtGenerar_EditValueChanged);
            this.txtGenerar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGenerar_KeyPress);
            // 
            // txtFoco
            // 
            this.txtFoco.Location = new System.Drawing.Point(534, -28);
            this.txtFoco.Name = "txtFoco";
            this.txtFoco.Size = new System.Drawing.Size(100, 20);
            this.txtFoco.TabIndex = 15;
            // 
            // ultraCmbE_TipoDoc
            // 
            this.ultraCmbE_TipoDoc.Location = new System.Drawing.Point(15, 33);
            this.ultraCmbE_TipoDoc.Name = "ultraCmbE_TipoDoc";
            this.ultraCmbE_TipoDoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ultraCmbE_TipoDoc.Properties.DisplayMember = "descripcion";
            this.ultraCmbE_TipoDoc.Properties.NullText = "";
            this.ultraCmbE_TipoDoc.Properties.PopupView = this.gridView4;
            this.ultraCmbE_TipoDoc.Properties.ValueMember = "codDocumentoTipo";
            this.ultraCmbE_TipoDoc.Size = new System.Drawing.Size(250, 20);
            this.ultraCmbE_TipoDoc.TabIndex = 0;
            this.ultraCmbE_TipoDoc.EditValueChanged += new System.EventHandler(this.ultraCmbE_TipoDoc_EditValueChanged);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Codigo,
            this.col_descripcion});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "codDocumentoTipo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 1;
            this.Codigo.Width = 221;
            // 
            // col_descripcion
            // 
            this.col_descripcion.Caption = "Descripcion";
            this.col_descripcion.FieldName = "descripcion";
            this.col_descripcion.Name = "col_descripcion";
            this.col_descripcion.Visible = true;
            this.col_descripcion.VisibleIndex = 0;
            this.col_descripcion.Width = 920;
            // 
            // txtDocFinal
            // 
            this.txtDocFinal.Enabled = false;
            this.txtDocFinal.Location = new System.Drawing.Point(15, 165);
            this.txtDocFinal.Name = "txtDocFinal";
            this.txtDocFinal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDocFinal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDocFinal.Properties.Mask.BeepOnError = true;
            this.txtDocFinal.Properties.Mask.EditMask = "d";
            this.txtDocFinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDocFinal.Properties.Mask.SaveLiteral = false;
            this.txtDocFinal.Properties.ReadOnly = true;
            this.txtDocFinal.Size = new System.Drawing.Size(150, 20);
            this.txtDocFinal.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Documento Final";
            // 
            // txtnumeroDoc
            // 
            this.txtnumeroDoc.EditValue = "";
            this.txtnumeroDoc.Location = new System.Drawing.Point(427, 117);
            this.txtnumeroDoc.Name = "txtnumeroDoc";
            this.txtnumeroDoc.Properties.Appearance.Options.UseTextOptions = true;
            this.txtnumeroDoc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtnumeroDoc.Properties.Mask.BeepOnError = true;
            this.txtnumeroDoc.Properties.Mask.EditMask = "\\d?{0,50}";
            this.txtnumeroDoc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtnumeroDoc.Properties.Mask.SaveLiteral = false;
            this.txtnumeroDoc.Properties.ReadOnly = true;
            this.txtnumeroDoc.Size = new System.Drawing.Size(150, 20);
            this.txtnumeroDoc.TabIndex = 0;
            this.txtnumeroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumeroDoc_KeyPress);
            // 
            // lblfechacad
            // 
            this.lblfechacad.AutoSize = true;
            this.lblfechacad.Location = new System.Drawing.Point(306, 145);
            this.lblfechacad.Name = "lblfechacad";
            this.lblfechacad.Size = new System.Drawing.Size(94, 13);
            this.lblfechacad.TabIndex = 73;
            this.lblfechacad.Text = "Fecha Caducidad:";
            // 
            // lblumdocumento
            // 
            this.lblumdocumento.AutoSize = true;
            this.lblumdocumento.Location = new System.Drawing.Point(306, 120);
            this.lblumdocumento.Name = "lblumdocumento";
            this.lblumdocumento.Size = new System.Drawing.Size(105, 13);
            this.lblumdocumento.TabIndex = 74;
            this.lblumdocumento.Text = "Numero Documento:";
            // 
            // chkUsado
            // 
            this.chkUsado.AutoSize = true;
            this.chkUsado.Location = new System.Drawing.Point(309, 55);
            this.chkUsado.Name = "chkUsado";
            this.chkUsado.Size = new System.Drawing.Size(149, 17);
            this.chkUsado.TabIndex = 3;
            this.chkUsado.Text = "La secuencia fue utilizada";
            this.chkUsado.UseVisualStyleBackColor = true;
            // 
            // lblnumautorizacion
            // 
            this.lblnumautorizacion.AutoSize = true;
            this.lblnumautorizacion.Location = new System.Drawing.Point(306, 170);
            this.lblnumautorizacion.Name = "lblnumautorizacion";
            this.lblnumautorizacion.Size = new System.Drawing.Size(108, 13);
            this.lblnumautorizacion.TabIndex = 78;
            this.lblnumautorizacion.Text = "Numero Autorizacion:";
            // 
            // txtNumeroAut
            // 
            this.txtNumeroAut.Location = new System.Drawing.Point(427, 167);
            this.txtNumeroAut.Name = "txtNumeroAut";
            this.txtNumeroAut.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumeroAut.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNumeroAut.Properties.Mask.BeepOnError = true;
            this.txtNumeroAut.Properties.Mask.EditMask = "\\d{0,37}";
            this.txtNumeroAut.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNumeroAut.Properties.Mask.SaveLiteral = false;
            this.txtNumeroAut.Size = new System.Drawing.Size(250, 20);
            this.txtNumeroAut.TabIndex = 6;
            this.txtNumeroAut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroAut_KeyPress);
            // 
            // chkestado
            // 
            this.chkestado.AutoSize = true;
            this.chkestado.Location = new System.Drawing.Point(309, 78);
            this.chkestado.Name = "chkestado";
            this.chkestado.Size = new System.Drawing.Size(56, 17);
            this.chkestado.TabIndex = 2;
            this.chkestado.Text = "Activo";
            this.chkestado.UseVisualStyleBackColor = true;
            // 
            // dtFechaCad
            // 
            this.dtFechaCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaCad.Location = new System.Drawing.Point(427, 141);
            this.dtFechaCad.Name = "dtFechaCad";
            this.dtFechaCad.Size = new System.Drawing.Size(100, 20);
            this.dtFechaCad.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtNumeroAut);
            this.panel3.Controls.Add(this.chkelectronica);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblumdocumento);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtDocFinal);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dtFechaCad);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtpuntoEmision);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.chkUsado);
            this.panel3.Controls.Add(this.txtEstablecimiento);
            this.panel3.Controls.Add(this.txtGenerar);
            this.panel3.Controls.Add(this.lblnumautorizacion);
            this.panel3.Controls.Add(this.chkestado);
            this.panel3.Controls.Add(this.ultraCmbE_TipoDoc);
            this.panel3.Controls.Add(this.txtUltDoc);
            this.panel3.Controls.Add(this.lblfechacad);
            this.panel3.Controls.Add(this.txtnumeroDoc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(701, 201);
            this.panel3.TabIndex = 84;
            // 
            // chkelectronica
            // 
            this.chkelectronica.Location = new System.Drawing.Point(309, 28);
            this.chkelectronica.Name = "chkelectronica";
            this.chkelectronica.Size = new System.Drawing.Size(164, 25);
            this.chkelectronica.TabIndex = 5;
            this.chkelectronica.Text = "Es Documento Electronico";
            this.chkelectronica.UseVisualStyleBackColor = true;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(701, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_bntAprobar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_bntDiseñoReporte = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_bntImprimir = DevExpress.XtraBars.BarItemVisibility.Never;
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
            // FrmGe_Secuencia_Documento_Talonario_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 230);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.txtFoco);
            this.Name = "FrmGe_Secuencia_Documento_Talonario_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Secuencia Documento";
            this.Load += new System.EventHandler(this.FrmGe_Secuencia_Documento_Talonario_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtpuntoEmision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstablecimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUltDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenerar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCmbE_TipoDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumeroDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroAut.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtpuntoEmision;
        private DevExpress.XtraEditors.TextEdit txtEstablecimiento;
        private DevExpress.XtraEditors.TextEdit txtUltDoc;
        private DevExpress.XtraEditors.TextEdit txtGenerar;
        private System.Windows.Forms.TextBox txtFoco;
        private DevExpress.XtraEditors.SearchLookUpEdit ultraCmbE_TipoDoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.TextEdit txtDocFinal;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtnumeroDoc;
        private System.Windows.Forms.Label lblfechacad;
        private System.Windows.Forms.Label lblumdocumento;
        private System.Windows.Forms.CheckBox chkUsado;
        private System.Windows.Forms.Label lblnumautorizacion;
        private DevExpress.XtraEditors.TextEdit txtNumeroAut;
        private System.Windows.Forms.CheckBox chkestado;
        private System.Windows.Forms.DateTimePicker dtFechaCad;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkelectronica;
        private DevExpress.XtraGrid.Columns.GridColumn col_descripcion;
    }
}