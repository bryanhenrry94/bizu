namespace Core.Erp.Winform.Controles
{
    partial class UCFa_TerminoPago
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
            this.cmbTerminoPago = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView15 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDias_Vct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNum_Cuotas = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTerminoPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView15)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTerminoPago
            // 
            this.cmbTerminoPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTerminoPago.Location = new System.Drawing.Point(0, 0);
            this.cmbTerminoPago.Name = "cmbTerminoPago";
            this.cmbTerminoPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTerminoPago.Properties.DisplayMember = "nom_TerminoPago";
            this.cmbTerminoPago.Properties.NullText = "";
            this.cmbTerminoPago.Properties.ValueMember = "IdTerminoPago";
            this.cmbTerminoPago.Properties.View = this.gridView15;
            this.cmbTerminoPago.Size = new System.Drawing.Size(243, 20);
            this.cmbTerminoPago.TabIndex = 81;
            this.cmbTerminoPago.EditValueChanged += new System.EventHandler(this.cmbTerminoPago_EditValueChanged);
            // 
            // gridView15
            // 
            this.gridView15.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion1,
            this.colDias_Vct,
            this.colIdTipoFormaPago,
            this.colNum_Cuotas});
            this.gridView15.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView15.Name = "gridView15";
            this.gridView15.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView15.OptionsView.ShowGroupPanel = false;
            // 
            // colDescripcion1
            // 
            this.colDescripcion1.Caption = "Descripción";
            this.colDescripcion1.FieldName = "nom_TerminoPago";
            this.colDescripcion1.Name = "colDescripcion1";
            this.colDescripcion1.Visible = true;
            this.colDescripcion1.VisibleIndex = 0;
            this.colDescripcion1.Width = 736;
            // 
            // colDias_Vct
            // 
            this.colDias_Vct.FieldName = "Dias_Vct";
            this.colDias_Vct.Name = "colDias_Vct";
            this.colDias_Vct.Visible = true;
            this.colDias_Vct.VisibleIndex = 1;
            this.colDias_Vct.Width = 151;
            // 
            // colIdTipoFormaPago
            // 
            this.colIdTipoFormaPago.FieldName = "IdTerminoPago";
            this.colIdTipoFormaPago.Name = "colIdTipoFormaPago";
            this.colIdTipoFormaPago.Visible = true;
            this.colIdTipoFormaPago.VisibleIndex = 3;
            this.colIdTipoFormaPago.Width = 149;
            // 
            // colNum_Cuotas
            // 
            this.colNum_Cuotas.FieldName = "Num_Cuotas";
            this.colNum_Cuotas.Name = "colNum_Cuotas";
            this.colNum_Cuotas.Visible = true;
            this.colNum_Cuotas.VisibleIndex = 2;
            this.colNum_Cuotas.Width = 144;
            // 
            // UCFa_TerminoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbTerminoPago);
            this.Name = "UCFa_TerminoPago";
            this.Size = new System.Drawing.Size(243, 27);
            this.Load += new System.EventHandler(this.UCFa_TerminoPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTerminoPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView15)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView15;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colDias_Vct;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_Cuotas;
        public DevExpress.XtraEditors.SearchLookUpEdit cmbTerminoPago;
    }
}
