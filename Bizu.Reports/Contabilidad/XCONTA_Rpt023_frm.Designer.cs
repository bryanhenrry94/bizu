namespace Bizu.Reports.Contabilidad
{
    partial class XCONTA_Rpt023_frm
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
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.col_TipoGasto = new DevExpress.XtraPivotGrid.PivotGridField();
            this.printControl1 = new DevExpress.XtraPrinting.Control.PrintControl();
            this.pivotGridControlDocumento = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource();
            this.col_TipoCosto = new DevExpress.XtraPivotGrid.PivotGridField();
            this.col_CentroCosto = new DevExpress.XtraPivotGrid.PivotGridField();
            this.col_SaldoAcumulado = new DevExpress.XtraPivotGrid.PivotGridField();
            this.col_Cuenta = new DevExpress.XtraPivotGrid.PivotGridField();
            this.uCct_Menu_Reportes = new Bizu.Reports.Controles.UCct_Menu_Reportes();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // col_TipoGasto
            // 
            this.col_TipoGasto.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.col_TipoGasto.AreaIndex = 0;
            this.col_TipoGasto.Caption = "Tip. Gasto";
            this.col_TipoGasto.FieldName = "nom_tipo_Gasto";
            this.col_TipoGasto.Name = "col_TipoGasto";
            this.col_TipoGasto.UnboundFieldName = "col_TipoGasto";
            // 
            // printControl1
            // 
            this.printControl1.BackColor = System.Drawing.Color.Empty;
            this.printControl1.ForeColor = System.Drawing.Color.Empty;
            this.printControl1.IsMetric = true;
            this.printControl1.Location = new System.Drawing.Point(0, 220);
            this.printControl1.Name = "printControl1";
            this.printControl1.Size = new System.Drawing.Size(831, 175);
            this.printControl1.TabIndex = 5;
            this.printControl1.TooltipFont = new System.Drawing.Font("Tahoma", 8.25F);
            // 
            // pivotGridControlDocumento
            // 
            this.pivotGridControlDocumento.DataSource = this.bindingSource1;
            this.pivotGridControlDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControlDocumento.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.col_TipoGasto,
            this.col_TipoCosto,
            this.col_CentroCosto,
            this.col_SaldoAcumulado,
            this.col_Cuenta});
            pivotGridGroup1.Fields.Add(this.col_TipoGasto);
            pivotGridGroup1.Hierarchy = null;
            pivotGridGroup1.ShowNewValues = true;
            this.pivotGridControlDocumento.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.pivotGridControlDocumento.Location = new System.Drawing.Point(0, 98);
            this.pivotGridControlDocumento.Name = "pivotGridControlDocumento";
            this.pivotGridControlDocumento.Size = new System.Drawing.Size(831, 325);
            this.pivotGridControlDocumento.TabIndex = 10;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Bizu.Reports.Contabilidad.XCONTA_Rpt023_Info);
            // 
            // col_TipoCosto
            // 
            this.col_TipoCosto.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.col_TipoCosto.AreaIndex = 2;
            this.col_TipoCosto.Caption = "Tip. Costo";
            this.col_TipoCosto.FieldName = "nom_tipo_Costo";
            this.col_TipoCosto.Name = "col_TipoCosto";
            // 
            // col_CentroCosto
            // 
            this.col_CentroCosto.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.col_CentroCosto.AreaIndex = 0;
            this.col_CentroCosto.Caption = "Centro Costo";
            this.col_CentroCosto.FieldName = "CodCentroCosto";
            this.col_CentroCosto.Name = "col_CentroCosto";
            // 
            // col_SaldoAcumulado
            // 
            this.col_SaldoAcumulado.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.col_SaldoAcumulado.AreaIndex = 0;
            this.col_SaldoAcumulado.CellFormat.FormatString = "N2";
            this.col_SaldoAcumulado.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_SaldoAcumulado.FieldName = "Saldo_Acumulado";
            this.col_SaldoAcumulado.GrandTotalCellFormat.FormatString = "N2";
            this.col_SaldoAcumulado.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_SaldoAcumulado.Name = "col_SaldoAcumulado";
            this.col_SaldoAcumulado.UnboundFieldName = "col_SaldoAcumulado";
            // 
            // col_Cuenta
            // 
            this.col_Cuenta.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.col_Cuenta.AreaIndex = 1;
            this.col_Cuenta.Caption = "Cuenta";
            this.col_Cuenta.ExpandedInFieldsGroup = false;
            this.col_Cuenta.FieldName = "nom_cuenta";
            this.col_Cuenta.Name = "col_Cuenta";
            this.col_Cuenta.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.col_Cuenta.Width = 350;
            // 
            // uCct_Menu_Reportes
            // 
            this.uCct_Menu_Reportes.caption_bei_Check = "Considerar Asiento Cierre";
            this.uCct_Menu_Reportes.caption_bei_Check2 = "Mostrar Registros con Cero";
            this.uCct_Menu_Reportes.caption_bei_Check3 = "Check";
            this.uCct_Menu_Reportes.caption_bei_Check4 = "Check";
            this.uCct_Menu_Reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.uCct_Menu_Reportes.Location = new System.Drawing.Point(0, 0);
            this.uCct_Menu_Reportes.Name = "uCct_Menu_Reportes";
            this.uCct_Menu_Reportes.Size = new System.Drawing.Size(831, 98);
            this.uCct_Menu_Reportes.TabIndex = 0;
            this.uCct_Menu_Reportes.Visible_bei_Check2 = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uCct_Menu_Reportes.Visible_bei_Check3 = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes.Visible_bei_Check4 = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes.Visible_bei_CtaCble = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes.Visible_bei_Desde = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uCct_Menu_Reportes.Visible_bei_GrupoCble = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes.Visible_bei_GrupoCble_chk = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes.Visible_bei_Hasta = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uCct_Menu_Reportes.Visible_bei_Nivel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes.Visible_bei_punto_cargo = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes.Visible_btn_Mostrar_en_tabla = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uCct_Menu_Reportes.Visible_btnImprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uCct_Menu_Reportes.Visible_Grupo_centro_costo = true;
            this.uCct_Menu_Reportes.Visible_Grupo_Check = true;
            this.uCct_Menu_Reportes.Visible_Grupo_cuentas = false;
            this.uCct_Menu_Reportes.Visible_Grupo_Punto_cargo = false;
            this.uCct_Menu_Reportes.event_btnConsultar_ItemClick += new Bizu.Reports.Controles.UCct_Menu_Reportes.delegate_btnConsultar_ItemClick(this.uCct_Menu_Reportes1_event_btnConsultar_ItemClick);
            this.uCct_Menu_Reportes.event_btnSalir_ItemClick += new Bizu.Reports.Controles.UCct_Menu_Reportes.delegate_btnSalir_ItemClick(this.uCct_Menu_Reportes_event_btnSalir_ItemClick);
            this.uCct_Menu_Reportes.event_btnImprimir_ItemClick += new Bizu.Reports.Controles.UCct_Menu_Reportes.delegate_btnImprimir_ItemClick(this.uCct_Menu_Reportes_event_btnImprimir_ItemClick);
            this.uCct_Menu_Reportes.Load += new System.EventHandler(this.uCct_Menu_Reportes_Load);
            // 
            // XCONTA_Rpt023_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 423);
            this.Controls.Add(this.pivotGridControlDocumento);
            this.Controls.Add(this.printControl1);
            this.Controls.Add(this.uCct_Menu_Reportes);
            this.Name = "XCONTA_Rpt023_frm";
            this.Text = "XCONTA_Rpt023_frm";
            this.Load += new System.EventHandler(this.XCONTA_Rpt023_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControlDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCct_Menu_Reportes uCct_Menu_Reportes;
        private DevExpress.XtraPrinting.Control.PrintControl printControl1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControlDocumento;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraPivotGrid.PivotGridField col_TipoGasto;
        private DevExpress.XtraPivotGrid.PivotGridField col_TipoCosto;
        private DevExpress.XtraPivotGrid.PivotGridField col_CentroCosto;
        private DevExpress.XtraPivotGrid.PivotGridField col_SaldoAcumulado;
        private DevExpress.XtraPivotGrid.PivotGridField col_Cuenta;

    }
}