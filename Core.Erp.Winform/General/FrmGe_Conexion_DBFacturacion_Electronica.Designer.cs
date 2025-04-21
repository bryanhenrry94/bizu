namespace Core.Erp.Winform.General
{
    partial class FrmGe_Conexion_DBFacturacion_Electronica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGe_Conexion_DBFacturacion_Electronica));
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.xtraTabPage7 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_Comprobantes_Recibidos = new DevExpress.XtraGrid.GridControl();
            this.gridView_Comprobantes_Recibidos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ejecutar_script = new DevExpress.XtraEditors.SimpleButton();
            this.txt_script_comprobantes_recibidos = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.xtraTabControl3 = new DevExpress.XtraTab.XtraTabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_puerto = new DevExpress.XtraEditors.SpinEdit();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_base_datos = new DevExpress.XtraEditors.TextEdit();
            this.chk_autenticacion_windows = new DevExpress.XtraEditors.CheckEdit();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_contrasena = new DevExpress.XtraEditors.TextEdit();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_usuario = new DevExpress.XtraEditors.TextEdit();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_server = new DevExpress.XtraEditors.TextEdit();
            this.label16 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cmb_tipo_base = new System.Windows.Forms.ComboBox();
            this.txt_cadena_conexion = new DevExpress.XtraEditors.ButtonEdit();
            this.btn_probar_conexion = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.xtraTabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Comprobantes_Recibidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Comprobantes_Recibidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).BeginInit();
            this.xtraTabControl3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_puerto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_base_datos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_autenticacion_windows.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_contrasena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_usuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_server.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cadena_conexion.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.ucGe_Menu.Size = new System.Drawing.Size(699, 29);
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
            // xtraTabPage7
            // 
            this.xtraTabPage7.Name = "xtraTabPage7";
            this.xtraTabPage7.Size = new System.Drawing.Size(693, 280);
            this.xtraTabPage7.Text = "Otras Opciones";
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.Controls.Add(this.gridControl_Comprobantes_Recibidos);
            this.xtraTabPage6.Controls.Add(this.panel2);
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.Size = new System.Drawing.Size(693, 280);
            this.xtraTabPage6.Text = "Comprobantes Recibidos";
            // 
            // gridControl_Comprobantes_Recibidos
            // 
            this.gridControl_Comprobantes_Recibidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Comprobantes_Recibidos.Location = new System.Drawing.Point(0, 121);
            this.gridControl_Comprobantes_Recibidos.MainView = this.gridView_Comprobantes_Recibidos;
            this.gridControl_Comprobantes_Recibidos.Name = "gridControl_Comprobantes_Recibidos";
            this.gridControl_Comprobantes_Recibidos.Size = new System.Drawing.Size(693, 159);
            this.gridControl_Comprobantes_Recibidos.TabIndex = 44;
            this.gridControl_Comprobantes_Recibidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Comprobantes_Recibidos,
            this.gridView1});
            // 
            // gridView_Comprobantes_Recibidos
            // 
            this.gridView_Comprobantes_Recibidos.GridControl = this.gridControl_Comprobantes_Recibidos;
            this.gridView_Comprobantes_Recibidos.Name = "gridView_Comprobantes_Recibidos";
            this.gridView_Comprobantes_Recibidos.OptionsBehavior.ReadOnly = true;
            this.gridView_Comprobantes_Recibidos.OptionsView.ShowAutoFilterRow = true;
            this.gridView_Comprobantes_Recibidos.OptionsView.ShowGroupPanel = false;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl_Comprobantes_Recibidos;
            this.gridView1.Name = "gridView1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ejecutar_script);
            this.panel2.Controls.Add(this.txt_script_comprobantes_recibidos);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 121);
            this.panel2.TabIndex = 43;
            // 
            // btn_ejecutar_script
            // 
            this.btn_ejecutar_script.Location = new System.Drawing.Point(12, 92);
            this.btn_ejecutar_script.Name = "btn_ejecutar_script";
            this.btn_ejecutar_script.Size = new System.Drawing.Size(98, 23);
            this.btn_ejecutar_script.TabIndex = 2;
            this.btn_ejecutar_script.Text = "Ejecutar Script";
            this.btn_ejecutar_script.Click += new System.EventHandler(this.btn_ejecutar_script_Click);
            // 
            // txt_script_comprobantes_recibidos
            // 
            this.txt_script_comprobantes_recibidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_script_comprobantes_recibidos.Location = new System.Drawing.Point(127, 4);
            this.txt_script_comprobantes_recibidos.Name = "txt_script_comprobantes_recibidos";
            this.txt_script_comprobantes_recibidos.Size = new System.Drawing.Size(547, 111);
            this.txt_script_comprobantes_recibidos.TabIndex = 1;
            this.txt_script_comprobantes_recibidos.Text = resources.GetString("txt_script_comprobantes_recibidos.Text");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Script Consulta:";
            // 
            // xtraTabControl3
            // 
            this.xtraTabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl3.Location = new System.Drawing.Point(0, 194);
            this.xtraTabControl3.Name = "xtraTabControl3";
            this.xtraTabControl3.SelectedTabPage = this.xtraTabPage6;
            this.xtraTabControl3.Size = new System.Drawing.Size(699, 308);
            this.xtraTabControl3.TabIndex = 44;
            this.xtraTabControl3.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage6,
            this.xtraTabPage7});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_puerto);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.txt_base_datos);
            this.panel1.Controls.Add(this.chk_autenticacion_windows);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.txt_contrasena);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txt_usuario);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txt_server);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.cmb_tipo_base);
            this.panel1.Controls.Add(this.txt_cadena_conexion);
            this.panel1.Controls.Add(this.btn_probar_conexion);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 165);
            this.panel1.TabIndex = 42;
            // 
            // txt_puerto
            // 
            this.txt_puerto.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_puerto.Location = new System.Drawing.Point(336, 29);
            this.txt_puerto.Name = "txt_puerto";
            this.txt_puerto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_puerto.Size = new System.Drawing.Size(75, 20);
            this.txt_puerto.TabIndex = 52;
            this.txt_puerto.EditValueChanged += new System.EventHandler(this.txt_puerto_EditValueChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(289, 32);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 13);
            this.label24.TabIndex = 51;
            this.label24.Text = "Puerto:";
            // 
            // txt_base_datos
            // 
            this.txt_base_datos.EditValue = "";
            this.txt_base_datos.Location = new System.Drawing.Point(128, 117);
            this.txt_base_datos.Name = "txt_base_datos";
            this.txt_base_datos.Properties.MaxLength = 50;
            this.txt_base_datos.Size = new System.Drawing.Size(150, 20);
            this.txt_base_datos.TabIndex = 7;
            this.txt_base_datos.EditValueChanged += new System.EventHandler(this.txt_base_datos_EditValueChanged);
            // 
            // chk_autenticacion_windows
            // 
            this.chk_autenticacion_windows.Location = new System.Drawing.Point(128, 51);
            this.chk_autenticacion_windows.Name = "chk_autenticacion_windows";
            this.chk_autenticacion_windows.Properties.Caption = "Autenticación Windows";
            this.chk_autenticacion_windows.Size = new System.Drawing.Size(147, 19);
            this.chk_autenticacion_windows.TabIndex = 4;
            this.chk_autenticacion_windows.CheckedChanged += new System.EventHandler(this.chk_autenticacion_windows_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 120);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(80, 13);
            this.label23.TabIndex = 47;
            this.label23.Text = "Base de Datos:";
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.EditValue = "";
            this.txt_contrasena.Location = new System.Drawing.Point(128, 93);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.Properties.MaxLength = 50;
            this.txt_contrasena.Size = new System.Drawing.Size(100, 20);
            this.txt_contrasena.TabIndex = 6;
            this.txt_contrasena.EditValueChanged += new System.EventHandler(this.txt_contrasena_EditValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Contraseña:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.EditValue = "";
            this.txt_usuario.Location = new System.Drawing.Point(128, 71);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Properties.MaxLength = 50;
            this.txt_usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_usuario.TabIndex = 5;
            this.txt_usuario.EditValueChanged += new System.EventHandler(this.txt_usuario_EditValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Usuario:";
            // 
            // txt_server
            // 
            this.txt_server.EditValue = "";
            this.txt_server.Location = new System.Drawing.Point(128, 29);
            this.txt_server.Name = "txt_server";
            this.txt_server.Properties.MaxLength = 50;
            this.txt_server.Size = new System.Drawing.Size(150, 20);
            this.txt_server.TabIndex = 2;
            this.txt_server.EditValueChanged += new System.EventHandler(this.txt_server_EditValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Servidor:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 144);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(109, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Cadena de Conexion:";
            // 
            // cmb_tipo_base
            // 
            this.cmb_tipo_base.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_base.FormattingEnabled = true;
            this.cmb_tipo_base.Items.AddRange(new object[] {
            "Microsoft SQL Server",
            "Oracle",
            "Access",
            "MySQL"});
            this.cmb_tipo_base.Location = new System.Drawing.Point(128, 5);
            this.cmb_tipo_base.Name = "cmb_tipo_base";
            this.cmb_tipo_base.Size = new System.Drawing.Size(150, 21);
            this.cmb_tipo_base.TabIndex = 1;
            this.cmb_tipo_base.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_base_SelectedIndexChanged);
            // 
            // txt_cadena_conexion
            // 
            this.txt_cadena_conexion.EditValue = "";
            this.txt_cadena_conexion.Location = new System.Drawing.Point(128, 141);
            this.txt_cadena_conexion.Name = "txt_cadena_conexion";
            this.txt_cadena_conexion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_cadena_conexion.Properties.MaxLength = 150;
            this.txt_cadena_conexion.Properties.ReadOnly = true;
            this.txt_cadena_conexion.Size = new System.Drawing.Size(551, 20);
            this.txt_cadena_conexion.TabIndex = 9;
            // 
            // btn_probar_conexion
            // 
            this.btn_probar_conexion.Location = new System.Drawing.Point(417, 108);
            this.btn_probar_conexion.Name = "btn_probar_conexion";
            this.btn_probar_conexion.Size = new System.Drawing.Size(115, 29);
            this.btn_probar_conexion.TabIndex = 8;
            this.btn_probar_conexion.Text = "Probar Conexion";
            this.btn_probar_conexion.UseVisualStyleBackColor = true;
            this.btn_probar_conexion.Click += new System.EventHandler(this.btn_probar_conexion_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 7);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Tipo de Base:";
            // 
            // FrmGe_Parametro_BaseExterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 502);
            this.Controls.Add(this.xtraTabControl3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmGe_Parametro_BaseExterna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración Base Datos - Comprobantes Electronicos";
            this.Load += new System.EventHandler(this.FrmGe_Parametro_BaseExterna_Load);
            this.xtraTabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Comprobantes_Recibidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Comprobantes_Recibidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).EndInit();
            this.xtraTabControl3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_puerto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_base_datos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_autenticacion_windows.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_contrasena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_usuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_server.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cadena_conexion.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage7;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private DevExpress.XtraGrid.GridControl gridControl_Comprobantes_Recibidos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Comprobantes_Recibidos;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btn_ejecutar_script;
        private System.Windows.Forms.RichTextBox txt_script_comprobantes_recibidos;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label24;
        private DevExpress.XtraEditors.TextEdit txt_base_datos;
        private DevExpress.XtraEditors.CheckEdit chk_autenticacion_windows;
        private System.Windows.Forms.Label label23;
        private DevExpress.XtraEditors.TextEdit txt_contrasena;
        private System.Windows.Forms.Label label18;
        private DevExpress.XtraEditors.TextEdit txt_usuario;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraEditors.TextEdit txt_server;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmb_tipo_base;
        private DevExpress.XtraEditors.ButtonEdit txt_cadena_conexion;
        private System.Windows.Forms.Button btn_probar_conexion;
        private System.Windows.Forms.Label label19;
        private DevExpress.XtraEditors.SpinEdit txt_puerto;
    }
}