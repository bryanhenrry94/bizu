namespace Core.Erp.Winform.Mail
{
    partial class FrmMail_CuentaCorreo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IdCuenta = new DevExpress.XtraEditors.TextEdit();
            this.txt_nombre = new DevExpress.XtraEditors.TextEdit();
            this.txt_direccion_correo_electronico = new DevExpress.XtraEditors.TextEdit();
            this.chk_enviar_copia_a_correo_oculto = new DevExpress.XtraEditors.CheckEdit();
            this.txt_correo_electronico_copia_oculta = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_empresa = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_servidor_correo = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_usuario = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_contrasena = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_tipo_conexion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_puerto = new DevExpress.XtraEditors.SpinEdit();
            this.chk_cuenta_predeterminada = new DevExpress.XtraEditors.CheckEdit();
            this.col_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_RazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.chk_estado = new DevExpress.XtraEditors.CheckEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdCuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_direccion_correo_electronico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_enviar_copia_a_correo_oculto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_correo_electronico_copia_oculta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_empresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_servidor_correo.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_usuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_contrasena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_conexion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_puerto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_cuenta_predeterminada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_estado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_correo_electronico_copia_oculta);
            this.groupBox1.Controls.Add(this.chk_enviar_copia_a_correo_oculto);
            this.groupBox1.Controls.Add(this.txt_direccion_correo_electronico);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_IdCuenta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información sobre el Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Cuenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección de Correo Electrónico:";
            // 
            // txt_IdCuenta
            // 
            this.txt_IdCuenta.Location = new System.Drawing.Point(181, 22);
            this.txt_IdCuenta.Name = "txt_IdCuenta";
            this.txt_IdCuenta.Size = new System.Drawing.Size(100, 20);
            this.txt_IdCuenta.TabIndex = 3;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(181, 45);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Properties.MaxLength = 250;
            this.txt_nombre.Size = new System.Drawing.Size(300, 20);
            this.txt_nombre.TabIndex = 4;
            // 
            // txt_direccion_correo_electronico
            // 
            this.txt_direccion_correo_electronico.Location = new System.Drawing.Point(181, 68);
            this.txt_direccion_correo_electronico.Name = "txt_direccion_correo_electronico";
            this.txt_direccion_correo_electronico.Properties.MaxLength = 150;
            this.txt_direccion_correo_electronico.Size = new System.Drawing.Size(200, 20);
            this.txt_direccion_correo_electronico.TabIndex = 5;
            // 
            // chk_enviar_copia_a_correo_oculto
            // 
            this.chk_enviar_copia_a_correo_oculto.Location = new System.Drawing.Point(19, 92);
            this.chk_enviar_copia_a_correo_oculto.Name = "chk_enviar_copia_a_correo_oculto";
            this.chk_enviar_copia_a_correo_oculto.Properties.Caption = "Enviar copia correo oculta";
            this.chk_enviar_copia_a_correo_oculto.Size = new System.Drawing.Size(157, 19);
            this.chk_enviar_copia_a_correo_oculto.TabIndex = 6;
            this.chk_enviar_copia_a_correo_oculto.CheckedChanged += new System.EventHandler(this.chk_enviar_copia_a_correo_oculto_CheckedChanged);
            // 
            // txt_correo_electronico_copia_oculta
            // 
            this.txt_correo_electronico_copia_oculta.Location = new System.Drawing.Point(181, 91);
            this.txt_correo_electronico_copia_oculta.Name = "txt_correo_electronico_copia_oculta";
            this.txt_correo_electronico_copia_oculta.Properties.MaxLength = 150;
            this.txt_correo_electronico_copia_oculta.Properties.ReadOnly = true;
            this.txt_correo_electronico_copia_oculta.Size = new System.Drawing.Size(200, 20);
            this.txt_correo_electronico_copia_oculta.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Empresa:";
            // 
            // cmb_empresa
            // 
            this.cmb_empresa.Location = new System.Drawing.Point(193, 31);
            this.cmb_empresa.Name = "cmb_empresa";
            this.cmb_empresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_empresa.Properties.DisplayMember = "RazonSocial";
            this.cmb_empresa.Properties.PopupView = this.searchLookUpEdit1View;
            this.cmb_empresa.Properties.ValueMember = "IdEmpresa";
            this.cmb_empresa.Size = new System.Drawing.Size(300, 20);
            this.cmb_empresa.TabIndex = 9;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IdEmpresa,
            this.col_RazonSocial});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_puerto);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmb_tipo_conexion);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_servidor_correo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 93);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del Servidor";
            // 
            // txt_servidor_correo
            // 
            this.txt_servidor_correo.Location = new System.Drawing.Point(181, 16);
            this.txt_servidor_correo.Name = "txt_servidor_correo";
            this.txt_servidor_correo.Properties.MaxLength = 150;
            this.txt_servidor_correo.Size = new System.Drawing.Size(200, 20);
            this.txt_servidor_correo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Servidor de Correo [SMTP]:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_contrasena);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_usuario);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 65);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información del Inicio de Sesion";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(181, 16);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Properties.MaxLength = 150;
            this.txt_usuario.Size = new System.Drawing.Size(200, 20);
            this.txt_usuario.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Usuario:";
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Location = new System.Drawing.Point(181, 39);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.Properties.MaxLength = 50;
            this.txt_contrasena.Size = new System.Drawing.Size(200, 20);
            this.txt_contrasena.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Contraseña:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tipo de Conexión:";
            // 
            // cmb_tipo_conexion
            // 
            this.cmb_tipo_conexion.Location = new System.Drawing.Point(181, 39);
            this.cmb_tipo_conexion.Name = "cmb_tipo_conexion";
            this.cmb_tipo_conexion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_tipo_conexion.Properties.DisplayMember = "nombre";
            this.cmb_tipo_conexion.Properties.MaxLength = 25;
            this.cmb_tipo_conexion.Properties.PopupView = this.gridView1;
            this.cmb_tipo_conexion.Properties.ValueMember = "id";
            this.cmb_tipo_conexion.Size = new System.Drawing.Size(200, 20);
            this.cmb_tipo_conexion.TabIndex = 9;
            this.cmb_tipo_conexion.EditValueChanged += new System.EventHandler(this.cmb_tipo_conexion_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_nombre});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Puerto (SMTP):";
            // 
            // txt_puerto
            // 
            this.txt_puerto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_puerto.Location = new System.Drawing.Point(181, 61);
            this.txt_puerto.Name = "txt_puerto";
            this.txt_puerto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_puerto.Size = new System.Drawing.Size(100, 20);
            this.txt_puerto.TabIndex = 11;
            // 
            // chk_cuenta_predeterminada
            // 
            this.chk_cuenta_predeterminada.EditValue = true;
            this.chk_cuenta_predeterminada.Location = new System.Drawing.Point(343, 353);
            this.chk_cuenta_predeterminada.Name = "chk_cuenta_predeterminada";
            this.chk_cuenta_predeterminada.Properties.Caption = "Cuenta Predeterminada";
            this.chk_cuenta_predeterminada.Size = new System.Drawing.Size(150, 19);
            this.chk_cuenta_predeterminada.TabIndex = 12;
            // 
            // col_nombre
            // 
            this.col_nombre.Caption = "Nombre";
            this.col_nombre.FieldName = "nombre";
            this.col_nombre.Name = "col_nombre";
            this.col_nombre.Visible = true;
            this.col_nombre.VisibleIndex = 0;
            // 
            // col_IdEmpresa
            // 
            this.col_IdEmpresa.Caption = "IdEmpresa";
            this.col_IdEmpresa.FieldName = "IdEmpresa";
            this.col_IdEmpresa.Name = "col_IdEmpresa";
            this.col_IdEmpresa.Visible = true;
            this.col_IdEmpresa.VisibleIndex = 0;
            this.col_IdEmpresa.Width = 189;
            // 
            // col_RazonSocial
            // 
            this.col_RazonSocial.Caption = "Razon Social";
            this.col_RazonSocial.FieldName = "RazonSocial";
            this.col_RazonSocial.Name = "col_RazonSocial";
            this.col_RazonSocial.Visible = true;
            this.col_RazonSocial.VisibleIndex = 1;
            this.col_RazonSocial.Width = 503;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(546, 29);
            this.ucGe_Menu.TabIndex = 0;
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
            this.ucGe_Menu.Visible_btnGuardar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_btnImpFrm = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpLote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpRep = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImprimirSoporte = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnModificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnproductos = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // chk_estado
            // 
            this.chk_estado.EditValue = true;
            this.chk_estado.Location = new System.Drawing.Point(31, 353);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Properties.Caption = "Activo";
            this.chk_estado.Size = new System.Drawing.Size(134, 19);
            this.chk_estado.TabIndex = 13;
            // 
            // FrmMail_CuentaCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 384);
            this.Controls.Add(this.chk_estado);
            this.Controls.Add(this.chk_cuenta_predeterminada);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmb_empresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmMail_CuentaCorreo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración de Cuenta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMail_CuentaCorreo_FormClosing);
            this.Load += new System.EventHandler(this.FrmMail_CuentaCorreo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdCuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_direccion_correo_electronico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_enviar_copia_a_correo_oculto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_correo_electronico_copia_oculta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_empresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_servidor_correo.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_usuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_contrasena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_conexion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_puerto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_cuenta_predeterminada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_estado.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txt_correo_electronico_copia_oculta;
        private DevExpress.XtraEditors.CheckEdit chk_enviar_copia_a_correo_oculto;
        private DevExpress.XtraEditors.TextEdit txt_direccion_correo_electronico;
        private DevExpress.XtraEditors.TextEdit txt_nombre;
        private DevExpress.XtraEditors.TextEdit txt_IdCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_empresa;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit txt_servidor_correo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.TextEdit txt_contrasena;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txt_usuario;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SpinEdit txt_puerto;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_tipo_conexion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.CheckEdit chk_cuenta_predeterminada;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn col_RazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn col_nombre;
        private DevExpress.XtraEditors.CheckEdit chk_estado;
    }
}