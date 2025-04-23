namespace Bizu.Presentation.Controles
{
    partial class UCFa_NivelPrecio
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
            this.cmbListadoPrecio = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView16 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_IdCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_IdCatalogo_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_CatalogoNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmbListadoPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView16)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbListadoPrecio
            // 
            this.cmbListadoPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbListadoPrecio.Location = new System.Drawing.Point(0, 0);
            this.cmbListadoPrecio.Name = "cmbListadoPrecio";
            this.cmbListadoPrecio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbListadoPrecio.Properties.DisplayMember = "Nombre";
            this.cmbListadoPrecio.Properties.NullText = "";
            this.cmbListadoPrecio.Properties.ValueMember = "IdCatalogo";
            this.cmbListadoPrecio.Properties.View = this.gridView16;
            this.cmbListadoPrecio.Size = new System.Drawing.Size(243, 20);
            this.cmbListadoPrecio.TabIndex = 82;
            this.cmbListadoPrecio.EditValueChanged += new System.EventHandler(this.cmbListadoPrecio_EditValueChanged);
            // 
            // gridView16
            // 
            this.gridView16.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_IdCatalogo,
            this.Col_IdCatalogo_tipo,
            this.Col_CatalogoNombre});
            this.gridView16.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView16.Name = "gridView16";
            this.gridView16.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView16.OptionsView.ShowGroupPanel = false;
            // 
            // Col_IdCatalogo
            // 
            this.Col_IdCatalogo.Caption = "Catalogo";
            this.Col_IdCatalogo.FieldName = "IdCatalogo";
            this.Col_IdCatalogo.Name = "Col_IdCatalogo";
            this.Col_IdCatalogo.Visible = true;
            this.Col_IdCatalogo.VisibleIndex = 0;
            this.Col_IdCatalogo.Width = 736;
            // 
            // Col_IdCatalogo_tipo
            // 
            this.Col_IdCatalogo_tipo.Caption = "Catalogo Tipo";
            this.Col_IdCatalogo_tipo.FieldName = "IdCatalogo_tipo";
            this.Col_IdCatalogo_tipo.Name = "Col_IdCatalogo_tipo";
            this.Col_IdCatalogo_tipo.Visible = true;
            this.Col_IdCatalogo_tipo.VisibleIndex = 1;
            this.Col_IdCatalogo_tipo.Width = 151;
            // 
            // Col_CatalogoNombre
            // 
            this.Col_CatalogoNombre.Caption = "Nombre";
            this.Col_CatalogoNombre.FieldName = "Nombre";
            this.Col_CatalogoNombre.Name = "Col_CatalogoNombre";
            this.Col_CatalogoNombre.Visible = true;
            this.Col_CatalogoNombre.VisibleIndex = 2;
            this.Col_CatalogoNombre.Width = 149;
            // 
            // UCFa_NivelPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbListadoPrecio);
            this.Name = "UCFa_NivelPrecio";
            this.Size = new System.Drawing.Size(243, 27);
            this.Load += new System.EventHandler(this.UCFa_NivelPrecio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbListadoPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView16)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView16;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdCatalogo_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn Col_CatalogoNombre;
        public DevExpress.XtraEditors.SearchLookUpEdit cmbListadoPrecio;
    }
}
