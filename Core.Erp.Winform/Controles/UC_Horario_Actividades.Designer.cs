namespace Core.Erp.Winform
{
    partial class UC_Horario_Actividades
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Horario_Actividades));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_frecuencia_semanal = new System.Windows.Forms.GroupBox();
            this.chkdomingo = new System.Windows.Forms.CheckBox();
            this.chkSabado = new System.Windows.Forms.CheckBox();
            this.chkViernes = new System.Windows.Forms.CheckBox();
            this.chkJueves = new System.Windows.Forms.CheckBox();
            this.chkmiercoles = new System.Windows.Forms.CheckBox();
            this.chkmartes = new System.Windows.Forms.CheckBox();
            this.chklunes = new System.Windows.Forms.CheckBox();
            this.gb_frecuencia_diaria = new System.Windows.Forms.GroupBox();
            this.txt_hora_ocurre_1_vez_a_las = new DevExpress.XtraEditors.TimeEdit();
            this.gb_ocurre_cada = new System.Windows.Forms.GroupBox();
            this.txt_valor_ocurre_cada = new System.Windows.Forms.NumericUpDown();
            this.cmb_ocurre_cada_tiempo = new System.Windows.Forms.ComboBox();
            this.txt_finaliza_a_las = new DevExpress.XtraEditors.TimeEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_hora_inicia_a = new DevExpress.XtraEditors.TimeEdit();
            this.opt_ocurre_cada = new System.Windows.Forms.RadioButton();
            this.opt_ocurre_1_vez = new System.Windows.Forms.RadioButton();
            this.cmb_tipo_ejecucion = new System.Windows.Forms.ComboBox();
            this.gb_acciones_a_ejecutarse = new System.Windows.Forms.GroupBox();
            this.gridControlAcciones = new DevExpress.XtraGrid.GridControl();
            this.gridViewAccionesEjecutar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTransaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdAccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiempoEspera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.timerSensorDisparo = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.gb_frecuencia_semanal.SuspendLayout();
            this.gb_frecuencia_diaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hora_ocurre_1_vez_a_las.Properties)).BeginInit();
            this.gb_ocurre_cada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valor_ocurre_cada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_finaliza_a_las.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hora_inicia_a.Properties)).BeginInit();
            this.gb_acciones_a_ejecutarse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAcciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccionesEjecutar)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_guardar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(613, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(69, 22);
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.gb_frecuencia_semanal);
            this.panelMain.Controls.Add(this.gb_frecuencia_diaria);
            this.panelMain.Controls.Add(this.cmb_tipo_ejecucion);
            this.panelMain.Controls.Add(this.gb_acciones_a_ejecutarse);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(613, 372);
            this.panelMain.TabIndex = 11;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de Ejecucion";
            // 
            // gb_frecuencia_semanal
            // 
            this.gb_frecuencia_semanal.Controls.Add(this.chkdomingo);
            this.gb_frecuencia_semanal.Controls.Add(this.chkSabado);
            this.gb_frecuencia_semanal.Controls.Add(this.chkViernes);
            this.gb_frecuencia_semanal.Controls.Add(this.chkJueves);
            this.gb_frecuencia_semanal.Controls.Add(this.chkmiercoles);
            this.gb_frecuencia_semanal.Controls.Add(this.chkmartes);
            this.gb_frecuencia_semanal.Controls.Add(this.chklunes);
            this.gb_frecuencia_semanal.Location = new System.Drawing.Point(19, 169);
            this.gb_frecuencia_semanal.Name = "gb_frecuencia_semanal";
            this.gb_frecuencia_semanal.Size = new System.Drawing.Size(579, 62);
            this.gb_frecuencia_semanal.TabIndex = 1;
            this.gb_frecuencia_semanal.TabStop = false;
            this.gb_frecuencia_semanal.Text = "Frecuencia Semanal";
            // 
            // chkdomingo
            // 
            this.chkdomingo.AutoSize = true;
            this.chkdomingo.Checked = true;
            this.chkdomingo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkdomingo.Location = new System.Drawing.Point(109, 43);
            this.chkdomingo.Name = "chkdomingo";
            this.chkdomingo.Size = new System.Drawing.Size(68, 17);
            this.chkdomingo.TabIndex = 6;
            this.chkdomingo.Text = "Domingo";
            this.chkdomingo.UseVisualStyleBackColor = true;
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.Checked = true;
            this.chkSabado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSabado.Location = new System.Drawing.Point(23, 43);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(63, 17);
            this.chkSabado.TabIndex = 5;
            this.chkSabado.Text = "Sabado";
            this.chkSabado.UseVisualStyleBackColor = true;
            // 
            // chkViernes
            // 
            this.chkViernes.AutoSize = true;
            this.chkViernes.Checked = true;
            this.chkViernes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkViernes.Location = new System.Drawing.Point(403, 19);
            this.chkViernes.Name = "chkViernes";
            this.chkViernes.Size = new System.Drawing.Size(61, 17);
            this.chkViernes.TabIndex = 4;
            this.chkViernes.Text = "Viernes";
            this.chkViernes.UseVisualStyleBackColor = true;
            // 
            // chkJueves
            // 
            this.chkJueves.AutoSize = true;
            this.chkJueves.Checked = true;
            this.chkJueves.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJueves.Location = new System.Drawing.Point(308, 19);
            this.chkJueves.Name = "chkJueves";
            this.chkJueves.Size = new System.Drawing.Size(60, 17);
            this.chkJueves.TabIndex = 3;
            this.chkJueves.Text = "Jueves";
            this.chkJueves.UseVisualStyleBackColor = true;
            // 
            // chkmiercoles
            // 
            this.chkmiercoles.AutoSize = true;
            this.chkmiercoles.Checked = true;
            this.chkmiercoles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkmiercoles.Location = new System.Drawing.Point(202, 19);
            this.chkmiercoles.Name = "chkmiercoles";
            this.chkmiercoles.Size = new System.Drawing.Size(71, 17);
            this.chkmiercoles.TabIndex = 2;
            this.chkmiercoles.Text = "Miercoles";
            this.chkmiercoles.UseVisualStyleBackColor = true;
            // 
            // chkmartes
            // 
            this.chkmartes.AutoSize = true;
            this.chkmartes.Checked = true;
            this.chkmartes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkmartes.Location = new System.Drawing.Point(109, 19);
            this.chkmartes.Name = "chkmartes";
            this.chkmartes.Size = new System.Drawing.Size(58, 17);
            this.chkmartes.TabIndex = 1;
            this.chkmartes.Text = "Martes";
            this.chkmartes.UseVisualStyleBackColor = true;
            // 
            // chklunes
            // 
            this.chklunes.AutoSize = true;
            this.chklunes.Checked = true;
            this.chklunes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chklunes.Location = new System.Drawing.Point(23, 19);
            this.chklunes.Name = "chklunes";
            this.chklunes.Size = new System.Drawing.Size(51, 17);
            this.chklunes.TabIndex = 0;
            this.chklunes.Text = "lunes";
            this.chklunes.UseVisualStyleBackColor = true;
            // 
            // gb_frecuencia_diaria
            // 
            this.gb_frecuencia_diaria.Controls.Add(this.txt_hora_ocurre_1_vez_a_las);
            this.gb_frecuencia_diaria.Controls.Add(this.gb_ocurre_cada);
            this.gb_frecuencia_diaria.Controls.Add(this.opt_ocurre_cada);
            this.gb_frecuencia_diaria.Controls.Add(this.opt_ocurre_1_vez);
            this.gb_frecuencia_diaria.Location = new System.Drawing.Point(19, 237);
            this.gb_frecuencia_diaria.Name = "gb_frecuencia_diaria";
            this.gb_frecuencia_diaria.Size = new System.Drawing.Size(579, 123);
            this.gb_frecuencia_diaria.TabIndex = 2;
            this.gb_frecuencia_diaria.TabStop = false;
            this.gb_frecuencia_diaria.Text = "Frecuencia Diaria";
            // 
            // txt_hora_ocurre_1_vez_a_las
            // 
            this.txt_hora_ocurre_1_vez_a_las.EditValue = new System.DateTime(2014, 11, 19, 0, 0, 0, 0);
            this.txt_hora_ocurre_1_vez_a_las.Location = new System.Drawing.Point(145, 25);
            this.txt_hora_ocurre_1_vez_a_las.Name = "txt_hora_ocurre_1_vez_a_las";
            this.txt_hora_ocurre_1_vez_a_las.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_hora_ocurre_1_vez_a_las.Size = new System.Drawing.Size(120, 20);
            this.txt_hora_ocurre_1_vez_a_las.TabIndex = 1;
            // 
            // gb_ocurre_cada
            // 
            this.gb_ocurre_cada.Controls.Add(this.txt_valor_ocurre_cada);
            this.gb_ocurre_cada.Controls.Add(this.cmb_ocurre_cada_tiempo);
            this.gb_ocurre_cada.Controls.Add(this.txt_finaliza_a_las);
            this.gb_ocurre_cada.Controls.Add(this.label1);
            this.gb_ocurre_cada.Controls.Add(this.label2);
            this.gb_ocurre_cada.Controls.Add(this.txt_hora_inicia_a);
            this.gb_ocurre_cada.Location = new System.Drawing.Point(139, 51);
            this.gb_ocurre_cada.Name = "gb_ocurre_cada";
            this.gb_ocurre_cada.Size = new System.Drawing.Size(390, 65);
            this.gb_ocurre_cada.TabIndex = 10;
            this.gb_ocurre_cada.TabStop = false;
            // 
            // txt_valor_ocurre_cada
            // 
            this.txt_valor_ocurre_cada.Location = new System.Drawing.Point(6, 19);
            this.txt_valor_ocurre_cada.Name = "txt_valor_ocurre_cada";
            this.txt_valor_ocurre_cada.Size = new System.Drawing.Size(61, 20);
            this.txt_valor_ocurre_cada.TabIndex = 3;
            this.txt_valor_ocurre_cada.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cmb_ocurre_cada_tiempo
            // 
            this.cmb_ocurre_cada_tiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ocurre_cada_tiempo.FormattingEnabled = true;
            this.cmb_ocurre_cada_tiempo.Location = new System.Drawing.Point(85, 19);
            this.cmb_ocurre_cada_tiempo.Name = "cmb_ocurre_cada_tiempo";
            this.cmb_ocurre_cada_tiempo.Size = new System.Drawing.Size(88, 21);
            this.cmb_ocurre_cada_tiempo.TabIndex = 4;
            this.cmb_ocurre_cada_tiempo.SelectedIndexChanged += new System.EventHandler(this.cmb_ocurre_cada_tiempo_SelectedIndexChanged);
            // 
            // txt_finaliza_a_las
            // 
            this.txt_finaliza_a_las.EditValue = new System.DateTime(2014, 11, 19, 23, 59, 59, 0);
            this.txt_finaliza_a_las.Location = new System.Drawing.Point(266, 39);
            this.txt_finaliza_a_las.Name = "txt_finaliza_a_las";
            this.txt_finaliza_a_las.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_finaliza_a_las.Size = new System.Drawing.Size(120, 20);
            this.txt_finaliza_a_las.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inicia a las:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Finaliza a las:";
            // 
            // txt_hora_inicia_a
            // 
            this.txt_hora_inicia_a.EditValue = new System.DateTime(2014, 11, 19, 0, 0, 0, 0);
            this.txt_hora_inicia_a.Location = new System.Drawing.Point(266, 16);
            this.txt_hora_inicia_a.Name = "txt_hora_inicia_a";
            this.txt_hora_inicia_a.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_hora_inicia_a.Size = new System.Drawing.Size(120, 20);
            this.txt_hora_inicia_a.TabIndex = 6;
            // 
            // opt_ocurre_cada
            // 
            this.opt_ocurre_cada.AutoSize = true;
            this.opt_ocurre_cada.Location = new System.Drawing.Point(19, 64);
            this.opt_ocurre_cada.Name = "opt_ocurre_cada";
            this.opt_ocurre_cada.Size = new System.Drawing.Size(87, 17);
            this.opt_ocurre_cada.TabIndex = 2;
            this.opt_ocurre_cada.Text = "Ocurre cada:";
            this.opt_ocurre_cada.UseVisualStyleBackColor = true;
            this.opt_ocurre_cada.CheckedChanged += new System.EventHandler(this.opt_ocurre_cada_CheckedChanged);
            // 
            // opt_ocurre_1_vez
            // 
            this.opt_ocurre_1_vez.AutoSize = true;
            this.opt_ocurre_1_vez.Checked = true;
            this.opt_ocurre_1_vez.Location = new System.Drawing.Point(19, 28);
            this.opt_ocurre_1_vez.Name = "opt_ocurre_1_vez";
            this.opt_ocurre_1_vez.Size = new System.Drawing.Size(126, 17);
            this.opt_ocurre_1_vez.TabIndex = 0;
            this.opt_ocurre_1_vez.TabStop = true;
            this.opt_ocurre_1_vez.Text = "Ocurre una vez a las:";
            this.opt_ocurre_1_vez.UseVisualStyleBackColor = true;
            this.opt_ocurre_1_vez.CheckedChanged += new System.EventHandler(this.opt_ocurre_1_vez_CheckedChanged);
            // 
            // cmb_tipo_ejecucion
            // 
            this.cmb_tipo_ejecucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_ejecucion.FormattingEnabled = true;
            this.cmb_tipo_ejecucion.Location = new System.Drawing.Point(127, 5);
            this.cmb_tipo_ejecucion.Name = "cmb_tipo_ejecucion";
            this.cmb_tipo_ejecucion.Size = new System.Drawing.Size(181, 21);
            this.cmb_tipo_ejecucion.TabIndex = 6;
            this.cmb_tipo_ejecucion.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_ejecucion_SelectedIndexChanged_1);
            this.cmb_tipo_ejecucion.SelectedValueChanged += new System.EventHandler(this.cmb_tipo_ejecucion_SelectedValueChanged);
            // 
            // gb_acciones_a_ejecutarse
            // 
            this.gb_acciones_a_ejecutarse.Controls.Add(this.gridControlAcciones);
            this.gb_acciones_a_ejecutarse.Location = new System.Drawing.Point(19, 32);
            this.gb_acciones_a_ejecutarse.Name = "gb_acciones_a_ejecutarse";
            this.gb_acciones_a_ejecutarse.Size = new System.Drawing.Size(579, 131);
            this.gb_acciones_a_ejecutarse.TabIndex = 4;
            this.gb_acciones_a_ejecutarse.TabStop = false;
            this.gb_acciones_a_ejecutarse.Text = "Acciones a Ejecutarse";
            // 
            // gridControlAcciones
            // 
            this.gridControlAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAcciones.Location = new System.Drawing.Point(3, 16);
            this.gridControlAcciones.MainView = this.gridViewAccionesEjecutar;
            this.gridControlAcciones.Name = "gridControlAcciones";
            this.gridControlAcciones.Size = new System.Drawing.Size(573, 112);
            this.gridControlAcciones.TabIndex = 4;
            this.gridControlAcciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAccionesEjecutar});
            // 
            // gridViewAccionesEjecutar
            // 
            this.gridViewAccionesEjecutar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTransaccion,
            this.colIdAccion,
            this.colDescripcion,
            this.colTiempoEspera});
            this.gridViewAccionesEjecutar.GridControl = this.gridControlAcciones;
            this.gridViewAccionesEjecutar.Name = "gridViewAccionesEjecutar";
            this.gridViewAccionesEjecutar.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTransaccion
            // 
            this.colIdTransaccion.Caption = "IdTransaccion";
            this.colIdTransaccion.FieldName = "IdTransaccion";
            this.colIdTransaccion.Name = "colIdTransaccion";
            // 
            // colIdAccion
            // 
            this.colIdAccion.Caption = "IdAccion";
            this.colIdAccion.FieldName = "IdAccion";
            this.colIdAccion.Name = "colIdAccion";
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripcion";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            // 
            // colTiempoEspera
            // 
            this.colTiempoEspera.Caption = "Tiempo(seg) Espera Antes de Ejecutarse";
            this.colTiempoEspera.FieldName = "TiempoEspera";
            this.colTiempoEspera.Name = "colTiempoEspera";
            this.colTiempoEspera.Visible = true;
            this.colTiempoEspera.VisibleIndex = 1;
            // 
            // timerSensorDisparo
            // 
            this.timerSensorDisparo.Enabled = true;
            this.timerSensorDisparo.Interval = 1000;
            this.timerSensorDisparo.Tick += new System.EventHandler(this.timerSensorDisparo_Tick);
            // 
            // UC_Horario_Actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UC_Horario_Actividades";
            this.Size = new System.Drawing.Size(613, 397);
            this.Load += new System.EventHandler(this.UC_Horario_Actividades_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.gb_frecuencia_semanal.ResumeLayout(false);
            this.gb_frecuencia_semanal.PerformLayout();
            this.gb_frecuencia_diaria.ResumeLayout(false);
            this.gb_frecuencia_diaria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hora_ocurre_1_vez_a_las.Properties)).EndInit();
            this.gb_ocurre_cada.ResumeLayout(false);
            this.gb_ocurre_cada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valor_ocurre_cada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_finaliza_a_las.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hora_inicia_a.Properties)).EndInit();
            this.gb_acciones_a_ejecutarse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAcciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccionesEjecutar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_frecuencia_semanal;
        private System.Windows.Forms.CheckBox chkdomingo;
        private System.Windows.Forms.CheckBox chkSabado;
        private System.Windows.Forms.CheckBox chkViernes;
        private System.Windows.Forms.CheckBox chkJueves;
        private System.Windows.Forms.CheckBox chkmiercoles;
        private System.Windows.Forms.CheckBox chkmartes;
        private System.Windows.Forms.CheckBox chklunes;
        private System.Windows.Forms.GroupBox gb_frecuencia_diaria;
        private DevExpress.XtraEditors.TimeEdit txt_finaliza_a_las;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TimeEdit txt_hora_inicia_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_ocurre_cada_tiempo;
        private System.Windows.Forms.NumericUpDown txt_valor_ocurre_cada;
        private System.Windows.Forms.RadioButton opt_ocurre_cada;
        private DevExpress.XtraEditors.TimeEdit txt_hora_ocurre_1_vez_a_las;
        private System.Windows.Forms.RadioButton opt_ocurre_1_vez;
        private System.Windows.Forms.ComboBox cmb_tipo_ejecucion;
        private System.Windows.Forms.GroupBox gb_acciones_a_ejecutarse;
        private DevExpress.XtraGrid.GridControl gridControlAcciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAccionesEjecutar;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTransaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAccion;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colTiempoEspera;
        private System.Windows.Forms.Timer timerSensorDisparo;
        private System.Windows.Forms.GroupBox gb_ocurre_cada;


    }
}
