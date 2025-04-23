namespace Bizu.Presentation.Controles
{
    partial class UCScrum_Board
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCScrum_Board));
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel_left = new System.Windows.Forms.Panel();
            this.panel_right = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_nueva_tarea = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_refresh = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_CriterioBusqueda = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblCriterioBusq = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new DevExpress.XtraEditors.DateEdit();
            this.lblFdesde = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new DevExpress.XtraEditors.DateEdit();
            this.lblFHasta = new System.Windows.Forms.Label();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.tablePanelBoard = new DevExpress.Utils.Layout.TablePanel();
            this.stackPanel_finalizada = new DevExpress.Utils.Layout.StackPanel();
            this.stackPanel_enProceso = new DevExpress.Utils.Layout.StackPanel();
            this.stackPanel_pendiente = new DevExpress.Utils.Layout.StackPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CriterioBusqueda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaHasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaHasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaDesde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaDesde.Properties)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelBoard)).BeginInit();
            this.tablePanelBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel_finalizada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel_enProceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel_pendiente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1028, 41);
            this.panel_top.TabIndex = 0;
            // 
            // panel_bottom
            // 
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 560);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1028, 24);
            this.panel_bottom.TabIndex = 4;
            // 
            // panel_left
            // 
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 41);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(60, 519);
            this.panel_left.TabIndex = 1;
            // 
            // panel_right
            // 
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_right.Location = new System.Drawing.Point(951, 41);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(77, 519);
            this.panel_right.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(60, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(891, 66);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_nueva_tarea);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 60);
            this.panel3.TabIndex = 1;
            // 
            // btn_nueva_tarea
            // 
            this.btn_nueva_tarea.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btn_nueva_tarea.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nueva_tarea.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_nueva_tarea.Appearance.Options.UseBackColor = true;
            this.btn_nueva_tarea.Appearance.Options.UseFont = true;
            this.btn_nueva_tarea.Appearance.Options.UseForeColor = true;
            this.btn_nueva_tarea.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_nueva_tarea.ImageOptions.Image")));
            this.btn_nueva_tarea.Location = new System.Drawing.Point(0, 24);
            this.btn_nueva_tarea.Name = "btn_nueva_tarea";
            this.btn_nueva_tarea.Size = new System.Drawing.Size(125, 36);
            this.btn_nueva_tarea.TabIndex = 0;
            this.btn_nueva_tarea.Text = "nueva tarea";
            this.btn_nueva_tarea.Click += new System.EventHandler(this.btn_nueva_tarea_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_refresh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(670, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 60);
            this.panel2.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_refresh.Appearance.Options.UseForeColor = true;
            this.btn_refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.ImageOptions.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(76, 21);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(125, 36);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "Refrescar";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_CriterioBusqueda);
            this.panel1.Controls.Add(this.lblCriterioBusq);
            this.panel1.Controls.Add(this.dtpFechaHasta);
            this.panel1.Controls.Add(this.lblFdesde);
            this.panel1.Controls.Add(this.dtpFechaDesde);
            this.panel1.Controls.Add(this.lblFHasta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(225, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 60);
            this.panel1.TabIndex = 7;
            // 
            // cmb_CriterioBusqueda
            // 
            this.cmb_CriterioBusqueda.Location = new System.Drawing.Point(70, 33);
            this.cmb_CriterioBusqueda.Name = "cmb_CriterioBusqueda";
            this.cmb_CriterioBusqueda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_CriterioBusqueda.Properties.Items.AddRange(new object[] {
            "Mes actual",
            "Última semana",
            "Último mes",
            "Último trimestre",
            "Año pasado",
            "Año actual",
            "Hoy"});
            this.cmb_CriterioBusqueda.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmb_CriterioBusqueda.Size = new System.Drawing.Size(150, 20);
            this.cmb_CriterioBusqueda.TabIndex = 24;
            this.cmb_CriterioBusqueda.SelectedIndexChanged += new System.EventHandler(this.cmb_CriterioBusqueda_SelectedIndexChanged);
            // 
            // lblCriterioBusq
            // 
            this.lblCriterioBusq.AutoSize = true;
            this.lblCriterioBusq.Location = new System.Drawing.Point(67, 13);
            this.lblCriterioBusq.Name = "lblCriterioBusq";
            this.lblCriterioBusq.Size = new System.Drawing.Size(58, 13);
            this.lblCriterioBusq.TabIndex = 21;
            this.lblCriterioBusq.Text = "Buscar por";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.EditValue = new System.DateTime(2021, 7, 14, 10, 47, 30, 93);
            this.dtpFechaHasta.Location = new System.Drawing.Point(266, 35);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaHasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaHasta.Size = new System.Drawing.Size(90, 20);
            this.dtpFechaHasta.TabIndex = 23;
            this.dtpFechaHasta.EditValueChanged += new System.EventHandler(this.dtpFechaHasta_EditValueChanged);
            // 
            // lblFdesde
            // 
            this.lblFdesde.AutoSize = true;
            this.lblFdesde.Location = new System.Drawing.Point(222, 15);
            this.lblFdesde.Name = "lblFdesde";
            this.lblFdesde.Size = new System.Drawing.Size(41, 13);
            this.lblFdesde.TabIndex = 19;
            this.lblFdesde.Text = "Desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.EditValue = new System.DateTime(2021, 7, 14, 10, 47, 30, 93);
            this.dtpFechaDesde.Location = new System.Drawing.Point(266, 12);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaDesde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaDesde.Size = new System.Drawing.Size(90, 20);
            this.dtpFechaDesde.TabIndex = 22;
            this.dtpFechaDesde.EditValueChanged += new System.EventHandler(this.dtpFechaDesde_EditValueChanged);
            // 
            // lblFHasta
            // 
            this.lblFHasta.AutoSize = true;
            this.lblFHasta.Location = new System.Drawing.Point(222, 38);
            this.lblFHasta.Name = "lblFHasta";
            this.lblFHasta.Size = new System.Drawing.Size(38, 13);
            this.lblFHasta.TabIndex = 20;
            this.lblFHasta.Text = "Hasta:";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.tablePanelBoard);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(60, 107);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(891, 453);
            this.xtraScrollableControl1.TabIndex = 7;
            // 
            // tablePanelBoard
            // 
            this.tablePanelBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanelBoard.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tablePanelBoard.Appearance.Options.UseBackColor = true;
            this.tablePanelBoard.AutoSize = true;
            this.tablePanelBoard.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.tablePanelBoard.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 32.89F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33.11F)});
            this.tablePanelBoard.Controls.Add(this.stackPanel_finalizada);
            this.tablePanelBoard.Controls.Add(this.stackPanel_enProceso);
            this.tablePanelBoard.Controls.Add(this.stackPanel_pendiente);
            this.tablePanelBoard.Controls.Add(this.label3);
            this.tablePanelBoard.Controls.Add(this.label2);
            this.tablePanelBoard.Controls.Add(this.label1);
            this.tablePanelBoard.Location = new System.Drawing.Point(3, 0);
            this.tablePanelBoard.Name = "tablePanelBoard";
            this.tablePanelBoard.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanelBoard.ShowGrid = DevExpress.Utils.DefaultBoolean.True;
            this.tablePanelBoard.Size = new System.Drawing.Size(868, 5000);
            this.tablePanelBoard.TabIndex = 0;
            // 
            // stackPanel_finalizada
            // 
            this.stackPanel_finalizada.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.stackPanel_finalizada.Appearance.Options.UseBackColor = true;
            this.stackPanel_finalizada.AutoSize = true;
            this.tablePanelBoard.SetColumn(this.stackPanel_finalizada, 2);
            this.stackPanel_finalizada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel_finalizada.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanel_finalizada.Location = new System.Drawing.Point(581, 43);
            this.stackPanel_finalizada.Name = "stackPanel_finalizada";
            this.tablePanelBoard.SetRow(this.stackPanel_finalizada, 1);
            this.stackPanel_finalizada.Size = new System.Drawing.Size(284, 4954);
            this.stackPanel_finalizada.TabIndex = 6;
            // 
            // stackPanel_enProceso
            // 
            this.stackPanel_enProceso.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.stackPanel_enProceso.Appearance.Options.UseBackColor = true;
            this.stackPanel_enProceso.AutoSize = true;
            this.tablePanelBoard.SetColumn(this.stackPanel_enProceso, 1);
            this.stackPanel_enProceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel_enProceso.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanel_enProceso.Location = new System.Drawing.Point(292, 43);
            this.stackPanel_enProceso.Name = "stackPanel_enProceso";
            this.tablePanelBoard.SetRow(this.stackPanel_enProceso, 1);
            this.stackPanel_enProceso.Size = new System.Drawing.Size(282, 4954);
            this.stackPanel_enProceso.TabIndex = 4;
            // 
            // stackPanel_pendiente
            // 
            this.stackPanel_pendiente.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.stackPanel_pendiente.Appearance.Options.UseBackColor = true;
            this.stackPanel_pendiente.AutoSize = true;
            this.tablePanelBoard.SetColumn(this.stackPanel_pendiente, 0);
            this.stackPanel_pendiente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel_pendiente.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanel_pendiente.Location = new System.Drawing.Point(3, 43);
            this.stackPanel_pendiente.Name = "stackPanel_pendiente";
            this.tablePanelBoard.SetRow(this.stackPanel_pendiente, 1);
            this.stackPanel_pendiente.Size = new System.Drawing.Size(283, 4954);
            this.stackPanel_pendiente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.tablePanelBoard.SetColumn(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(581, 0);
            this.label3.Name = "label3";
            this.tablePanelBoard.SetRow(this.label3, 0);
            this.label3.Size = new System.Drawing.Size(284, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Finalizada";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.tablePanelBoard.SetColumn(this.label2, 1);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(292, 0);
            this.label2.Name = "label2";
            this.tablePanelBoard.SetRow(this.label2, 0);
            this.label2.Size = new System.Drawing.Size(282, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "En Proceso";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.tablePanelBoard.SetColumn(this.label1, 0);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.tablePanelBoard.SetRow(this.label1, 0);
            this.label1.Size = new System.Drawing.Size(283, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pendiente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCScrum_Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraScrollableControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_top);
            this.Name = "UCScrum_Board";
            this.Size = new System.Drawing.Size(1028, 584);
            this.Load += new System.EventHandler(this.UCScrum_Board_Final_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_CriterioBusqueda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaHasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaHasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaDesde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaDesde.Properties)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanelBoard)).EndInit();
            this.tablePanelBoard.ResumeLayout(false);
            this.tablePanelBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel_finalizada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel_enProceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel_pendiente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btn_refresh;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_CriterioBusqueda;
        private System.Windows.Forms.Label lblCriterioBusq;
        private DevExpress.XtraEditors.DateEdit dtpFechaHasta;
        private System.Windows.Forms.Label lblFdesde;
        private DevExpress.XtraEditors.DateEdit dtpFechaDesde;
        private System.Windows.Forms.Label lblFHasta;
        private DevExpress.XtraEditors.SimpleButton btn_nueva_tarea;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanelBoard;
        private DevExpress.Utils.Layout.StackPanel stackPanel_finalizada;
        private DevExpress.Utils.Layout.StackPanel stackPanel_enProceso;
        private DevExpress.Utils.Layout.StackPanel stackPanel_pendiente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
