namespace Core.Erp.Winform.General_Edehsa
{
    partial class frmGe_MantPersona
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.lb_Anulado = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lb_Anulado);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 29);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(668, 202);
            this.panelMain.TabIndex = 2;
            // 
            // lb_Anulado
            // 
            this.lb_Anulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Anulado.ForeColor = System.Drawing.Color.Red;
            this.lb_Anulado.Location = new System.Drawing.Point(241, 47);
            this.lb_Anulado.Name = "lb_Anulado";
            this.lb_Anulado.Size = new System.Drawing.Size(172, 18);
            this.lb_Anulado.TabIndex = 135;
            this.lb_Anulado.Text = "**ANULADO**";
            this.lb_Anulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Anulado.Visible = false;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(668, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = DevExpress.XtraBars.BarItemVisibility.Always;
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
            // ucGe_BarraEstado
            // 
            this.ucGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstado.Location = new System.Drawing.Point(0, 231);
            this.ucGe_BarraEstado.Name = "ucGe_BarraEstado";
            this.ucGe_BarraEstado.Size = new System.Drawing.Size(668, 26);
            this.ucGe_BarraEstado.TabIndex = 0;            
            // 
            // frmGe_MantPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 257);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucGe_BarraEstado);
            this.Name = "frmGe_MantPersona";
            this.Text = "FrmGe_MantPersona";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGe_MantPersona_FormClosing);
            this.Load += new System.EventHandler(this.FrmGe_MantPersona_Load);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstado;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lb_Anulado;
    }
}