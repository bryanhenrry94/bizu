namespace Core.Erp.Winform.Controles
{
    partial class UCIn_GuiaRemision_Recepcion
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
            this.txt_numGuia = new DevExpress.XtraEditors.TextEdit();
            this.chk_NEDV = new DevExpress.XtraEditors.CheckEdit();
            this.txt_numero_nedv = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_numGuia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_NEDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_numero_nedv.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_numGuia
            // 
            this.txt_numGuia.Location = new System.Drawing.Point(0, 1);
            this.txt_numGuia.Name = "txt_numGuia";
            this.txt_numGuia.Properties.Mask.EditMask = "\\d\\d\\d\\-\\d\\d\\d\\-\\d\\d\\d\\d\\d\\d\\d\\d\\d";
            this.txt_numGuia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txt_numGuia.Size = new System.Drawing.Size(140, 20);
            this.txt_numGuia.TabIndex = 22;
            this.txt_numGuia.Leave += new System.EventHandler(this.txt_numGuia_Leave);
            // 
            // chk_NEDV
            // 
            this.chk_NEDV.Location = new System.Drawing.Point(143, 1);
            this.chk_NEDV.Name = "chk_NEDV";
            this.chk_NEDV.Properties.Caption = "(NEDV)";
            this.chk_NEDV.Size = new System.Drawing.Size(61, 19);
            this.chk_NEDV.TabIndex = 23;
            this.chk_NEDV.CheckedChanged += new System.EventHandler(this.chk_NDEV_CheckedChanged);
            // 
            // txt_numero_nedv
            // 
            this.txt_numero_nedv.Location = new System.Drawing.Point(204, 1);
            this.txt_numero_nedv.Name = "txt_numero_nedv";
            this.txt_numero_nedv.Size = new System.Drawing.Size(100, 20);
            this.txt_numero_nedv.TabIndex = 24;
            this.txt_numero_nedv.Visible = false;
            // 
            // UCIn_GuiaRemision_Recepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_numero_nedv);
            this.Controls.Add(this.chk_NEDV);
            this.Controls.Add(this.txt_numGuia);
            this.Name = "UCIn_GuiaRemision_Recepcion";
            this.Size = new System.Drawing.Size(310, 22);
            this.Load += new System.EventHandler(this.UCIn_GuiaRemision_Recepcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_numGuia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_NEDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_numero_nedv.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.TextEdit txt_numGuia;
        public DevExpress.XtraEditors.CheckEdit chk_NEDV;
        public DevExpress.XtraEditors.TextEdit txt_numero_nedv;

    }
}
