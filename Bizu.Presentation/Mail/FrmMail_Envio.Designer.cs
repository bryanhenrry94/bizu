namespace Bizu.Presentation.Mail
{
    partial class FrmMail_Envio
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
            this.txt_para = new DevExpress.XtraEditors.TextEdit();
            this.btn_enviar = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_asunto = new DevExpress.XtraEditors.TextEdit();
            this.txt_mensaje = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_para.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_asunto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para:";
            // 
            // txt_para
            // 
            this.txt_para.Location = new System.Drawing.Point(75, 12);
            this.txt_para.Name = "txt_para";
            this.txt_para.Size = new System.Drawing.Size(450, 20);
            this.txt_para.TabIndex = 1;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(21, 301);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(135, 37);
            this.btn_enviar.TabIndex = 2;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Asunto:";
            // 
            // txt_asunto
            // 
            this.txt_asunto.Location = new System.Drawing.Point(75, 40);
            this.txt_asunto.Name = "txt_asunto";
            this.txt_asunto.Size = new System.Drawing.Size(450, 20);
            this.txt_asunto.TabIndex = 4;
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.Location = new System.Drawing.Point(12, 75);
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.Size = new System.Drawing.Size(513, 211);
            this.txt_mensaje.TabIndex = 5;
            this.txt_mensaje.Text = "";
            // 
            // FrmMail_Envio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 344);
            this.Controls.Add(this.txt_mensaje);
            this.Controls.Add(this.txt_asunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_para);
            this.Controls.Add(this.label1);
            this.Name = "FrmMail_Envio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail";
            ((System.ComponentModel.ISupportInitialize)(this.txt_para.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_asunto.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_para;
        private DevExpress.XtraEditors.SimpleButton btn_enviar;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_asunto;
        private System.Windows.Forms.RichTextBox txt_mensaje;
    }
}