namespace Core.Erp.Winform.General
{
    partial class FrmGe_Tarea_Board
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
            this.ucScrum_Board_Final1 = new Core.Erp.Winform.Controles.UCScrum_Board();
            this.SuspendLayout();
            // 
            // ucScrum_Board_Final1
            // 
            this.ucScrum_Board_Final1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucScrum_Board_Final1.Location = new System.Drawing.Point(0, 0);
            this.ucScrum_Board_Final1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucScrum_Board_Final1.Name = "ucScrum_Board_Final1";
            this.ucScrum_Board_Final1.Size = new System.Drawing.Size(1067, 554);
            this.ucScrum_Board_Final1.TabIndex = 0;
            // 
            // FrmGe_Tarea_Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.ucScrum_Board_Final1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmGe_Tarea_Board";
            this.Text = "Tablero Scrum";
            this.Load += new System.EventHandler(this.FrmGe_Tablero_Board_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Controles.UCScrum_Board ucScrum_Board_Final1;
    }
}