namespace Bizu.Presentation.Mail
{
    partial class FrmMail_BandejaSalida
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_enviar_mail = new System.Windows.Forms.ToolStripButton();
            this.btn_anular = new System.Windows.Forms.ToolStripButton();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.gridControl_Mail = new DevExpress.XtraGrid.GridControl();
            this.gridView_Mail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Mail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Mail)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_enviar_mail,
            this.btn_anular,
            this.btn_salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(667, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_enviar_mail
            // 
            this.btn_enviar_mail.Image = global::Bizu.Presentation.Properties.Resources.erp_256;
            this.btn_enviar_mail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_enviar_mail.Name = "btn_enviar_mail";
            this.btn_enviar_mail.Size = new System.Drawing.Size(85, 22);
            this.btn_enviar_mail.Text = "Enviar Mail";
            this.btn_enviar_mail.Click += new System.EventHandler(this.btn_enviar_mail_Click);
            // 
            // btn_anular
            // 
            this.btn_anular.Image = global::Bizu.Presentation.Properties.Resources.erp_256;
            this.btn_anular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_anular.Name = "btn_anular";
            this.btn_anular.Size = new System.Drawing.Size(62, 22);
            this.btn_anular.Text = "Anular";
            this.btn_anular.Click += new System.EventHandler(this.btn_anular_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::Bizu.Presentation.Properties.Resources.erp_256;
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(49, 22);
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // gridControl_Mail
            // 
            this.gridControl_Mail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Mail.Location = new System.Drawing.Point(0, 25);
            this.gridControl_Mail.MainView = this.gridView_Mail;
            this.gridControl_Mail.Name = "gridControl_Mail";
            this.gridControl_Mail.Size = new System.Drawing.Size(667, 262);
            this.gridControl_Mail.TabIndex = 2;
            this.gridControl_Mail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Mail});
            // 
            // gridView_Mail
            // 
            this.gridView_Mail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn5});
            this.gridView_Mail.GridControl = this.gridControl_Mail;
            this.gridView_Mail.Name = "gridView_Mail";
            this.gridView_Mail.OptionsBehavior.ReadOnly = true;
            this.gridView_Mail.OptionsView.ShowGroupPanel = false;
            this.gridView_Mail.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_Mail_RowCellStyle);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "IdMail";
            this.gridColumn1.FieldName = "IdMail";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Asunto";
            this.gridColumn2.FieldName = "Asunto";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 107;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Para";
            this.gridColumn3.FieldName = "To";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 91;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "CC";
            this.gridColumn4.FieldName = "CC";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Width = 95;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Mensaje";
            this.gridColumn6.FieldName = "Mensaje";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 195;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Error";
            this.gridColumn5.FieldName = "MensajeError";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 161;
            // 
            // FrmMail_BandejaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 287);
            this.Controls.Add(this.gridControl_Mail);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmMail_BandejaSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bandeja de Salida";
            this.Load += new System.EventHandler(this.FrmMail_BandejaSalida_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Mail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Mail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_enviar_mail;
        private System.Windows.Forms.ToolStripButton btn_anular;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private DevExpress.XtraGrid.GridControl gridControl_Mail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Mail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;

    }
}