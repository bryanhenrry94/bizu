namespace Core.Erp.Winform
{
    partial class Form1
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
            this.btnServicioREST = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.RichTextBox();
            this.txtUrlRest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrlSOAP = new System.Windows.Forms.TextBox();
            this.txtResponseSOAP = new System.Windows.Forms.RichTextBox();
            this.btnServicioSOAP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnServicioREST
            // 
            this.btnServicioREST.Location = new System.Drawing.Point(30, 12);
            this.btnServicioREST.Name = "btnServicioREST";
            this.btnServicioREST.Size = new System.Drawing.Size(113, 36);
            this.btnServicioREST.TabIndex = 0;
            this.btnServicioREST.Text = "Consumir Servicio Rest";
            this.btnServicioREST.UseVisualStyleBackColor = true;
            this.btnServicioREST.Click += new System.EventHandler(this.btnConsumirServicio_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(30, 54);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(587, 99);
            this.txtResponse.TabIndex = 1;
            this.txtResponse.Text = "";
            // 
            // txtUrlRest
            // 
            this.txtUrlRest.Location = new System.Drawing.Point(189, 16);
            this.txtUrlRest.Name = "txtUrlRest";
            this.txtUrlRest.Size = new System.Drawing.Size(428, 20);
            this.txtUrlRest.TabIndex = 2;
            this.txtUrlRest.Text = "http://proxy.edehsa.local/efirm_ws/comprobanteService.php";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "url:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "url:";
            // 
            // txtUrlSOAP
            // 
            this.txtUrlSOAP.Location = new System.Drawing.Point(189, 169);
            this.txtUrlSOAP.Name = "txtUrlSOAP";
            this.txtUrlSOAP.Size = new System.Drawing.Size(428, 20);
            this.txtUrlSOAP.TabIndex = 6;
            this.txtUrlSOAP.Text = "http://proxy.edehsa.local/efirm_ws/comprobanteService.php";
            // 
            // txtResponseSOAP
            // 
            this.txtResponseSOAP.Location = new System.Drawing.Point(30, 207);
            this.txtResponseSOAP.Name = "txtResponseSOAP";
            this.txtResponseSOAP.Size = new System.Drawing.Size(587, 99);
            this.txtResponseSOAP.TabIndex = 5;
            this.txtResponseSOAP.Text = "";
            // 
            // btnServicioSOAP
            // 
            this.btnServicioSOAP.Location = new System.Drawing.Point(30, 165);
            this.btnServicioSOAP.Name = "btnServicioSOAP";
            this.btnServicioSOAP.Size = new System.Drawing.Size(113, 36);
            this.btnServicioSOAP.TabIndex = 4;
            this.btnServicioSOAP.Text = "Consumir Servicio SOAP";
            this.btnServicioSOAP.UseVisualStyleBackColor = true;
            this.btnServicioSOAP.Click += new System.EventHandler(this.btnServicioSOAP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 334);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrlSOAP);
            this.Controls.Add(this.txtResponseSOAP);
            this.Controls.Add(this.btnServicioSOAP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrlRest);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.btnServicioREST);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnServicioREST;
        private System.Windows.Forms.RichTextBox txtResponse;
        private System.Windows.Forms.TextBox txtUrlRest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrlSOAP;
        private System.Windows.Forms.RichTextBox txtResponseSOAP;
        private System.Windows.Forms.Button btnServicioSOAP;

        #endregion





        //private Controles.UCGe_Persona_x_Direcciones_Grid ucGe_Persona_x_Direcciones_Grid1;








    }
}