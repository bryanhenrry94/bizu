namespace Bizu.Presentation.Inventario
{
    partial class FrmIn_Producto_Busqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIn_Producto_Busqueda));
            this.pnlSucBod = new System.Windows.Forms.Panel();
            this.UCIn_Sucursal_Bodega = new Bizu.Presentation.Controles.UCIn_Sucursal_Bodega();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.BtnSeleccionar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.gridControlProductos = new DevExpress.XtraGrid.GridControl();
            this.gridViewProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pr_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pr_descripcion_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pr_peso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pr_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_UnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nom_Bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nom_Categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nom_Linea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nom_Tipo_Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chk_mostrar_con_stock = new DevExpress.XtraEditors.CheckEdit();
            this.pnlSucBod.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_mostrar_con_stock.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSucBod
            // 
            this.pnlSucBod.Controls.Add(this.chk_mostrar_con_stock);
            this.pnlSucBod.Controls.Add(this.UCIn_Sucursal_Bodega);
            this.pnlSucBod.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSucBod.Location = new System.Drawing.Point(0, 25);
            this.pnlSucBod.Name = "pnlSucBod";
            this.pnlSucBod.Size = new System.Drawing.Size(963, 58);
            this.pnlSucBod.TabIndex = 3;
            // 
            // UCIn_Sucursal_Bodega
            // 
            this.UCIn_Sucursal_Bodega.Enabled = false;
            this.UCIn_Sucursal_Bodega.Location = new System.Drawing.Point(3, 3);
            this.UCIn_Sucursal_Bodega.Name = "UCIn_Sucursal_Bodega";
            this.UCIn_Sucursal_Bodega.Size = new System.Drawing.Size(459, 47);
            this.UCIn_Sucursal_Bodega.TabIndex = 0;
            this.UCIn_Sucursal_Bodega.TipoCarga = Bizu.Domain.General.Cl_Enumeradores.eTipoFiltro.todos;
            this.UCIn_Sucursal_Bodega.Visible_cmb_bodega = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscar,
            this.BtnSeleccionar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(963, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Bizu.Presentation.Properties.Resources.erp_256;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 22);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSeleccionar.Image")));
            this.BtnSeleccionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(87, 22);
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = null;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gridControlProductos
            // 
            this.gridControlProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProductos.Location = new System.Drawing.Point(0, 83);
            this.gridControlProductos.MainView = this.gridViewProductos;
            this.gridControlProductos.Name = "gridControlProductos";
            this.gridControlProductos.Size = new System.Drawing.Size(963, 378);
            this.gridControlProductos.TabIndex = 5;
            this.gridControlProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductos});
            // 
            // gridViewProductos
            // 
            this.gridViewProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IdProducto,
            this.col_pr_codigo,
            this.col_pr_descripcion,
            this.col_pr_descripcion_2,
            this.col_pr_peso,
            this.col_pr_stock,
            this.col_IdUnidadMedida,
            this.col_UnidadMedida,
            this.col_nom_Bodega,
            this.col_nom_Categoria,
            this.col_nom_Linea,
            this.col_nom_Tipo_Producto});
            this.gridViewProductos.GridControl = this.gridControlProductos;
            this.gridViewProductos.Name = "gridViewProductos";
            this.gridViewProductos.OptionsBehavior.Editable = false;
            this.gridViewProductos.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProductos.OptionsView.ShowGroupPanel = false;
            this.gridViewProductos.DoubleClick += new System.EventHandler(this.gridViewProductos_DoubleClick);
            // 
            // col_IdProducto
            // 
            this.col_IdProducto.Caption = "IdProducto";
            this.col_IdProducto.FieldName = "IdProducto";
            this.col_IdProducto.Name = "col_IdProducto";
            this.col_IdProducto.Visible = true;
            this.col_IdProducto.VisibleIndex = 0;
            this.col_IdProducto.Width = 72;
            // 
            // col_pr_codigo
            // 
            this.col_pr_codigo.Caption = "Codigo";
            this.col_pr_codigo.FieldName = "pr_codigo";
            this.col_pr_codigo.Name = "col_pr_codigo";
            this.col_pr_codigo.Visible = true;
            this.col_pr_codigo.VisibleIndex = 1;
            this.col_pr_codigo.Width = 74;
            // 
            // col_pr_descripcion
            // 
            this.col_pr_descripcion.Caption = "Descripción";
            this.col_pr_descripcion.FieldName = "pr_descripcion";
            this.col_pr_descripcion.Name = "col_pr_descripcion";
            this.col_pr_descripcion.Visible = true;
            this.col_pr_descripcion.VisibleIndex = 2;
            this.col_pr_descripcion.Width = 213;
            // 
            // col_pr_descripcion_2
            // 
            this.col_pr_descripcion_2.Caption = "Descripción";
            this.col_pr_descripcion_2.FieldName = "pr_descripcion_2";
            this.col_pr_descripcion_2.Name = "col_pr_descripcion_2";
            // 
            // col_pr_peso
            // 
            this.col_pr_peso.Caption = "Peso";
            this.col_pr_peso.FieldName = "pr_peso";
            this.col_pr_peso.Name = "col_pr_peso";
            this.col_pr_peso.Visible = true;
            this.col_pr_peso.VisibleIndex = 3;
            this.col_pr_peso.Width = 98;
            // 
            // col_pr_stock
            // 
            this.col_pr_stock.Caption = "Stock";
            this.col_pr_stock.FieldName = "pr_stock";
            this.col_pr_stock.Name = "col_pr_stock";
            this.col_pr_stock.Visible = true;
            this.col_pr_stock.VisibleIndex = 4;
            this.col_pr_stock.Width = 98;
            // 
            // col_IdUnidadMedida
            // 
            this.col_IdUnidadMedida.Caption = "IdUnidadMedida";
            this.col_IdUnidadMedida.FieldName = "IdUnidadMedida";
            this.col_IdUnidadMedida.Name = "col_IdUnidadMedida";
            // 
            // col_UnidadMedida
            // 
            this.col_UnidadMedida.Caption = "Unid. Medida";
            this.col_UnidadMedida.FieldName = "nom_UnidadMedida";
            this.col_UnidadMedida.Name = "col_UnidadMedida";
            this.col_UnidadMedida.Visible = true;
            this.col_UnidadMedida.VisibleIndex = 5;
            this.col_UnidadMedida.Width = 98;
            // 
            // col_nom_Bodega
            // 
            this.col_nom_Bodega.Caption = "Bodega";
            this.col_nom_Bodega.FieldName = "nom_Bodega";
            this.col_nom_Bodega.Name = "col_nom_Bodega";
            this.col_nom_Bodega.Visible = true;
            this.col_nom_Bodega.VisibleIndex = 6;
            this.col_nom_Bodega.Width = 98;
            // 
            // col_nom_Categoria
            // 
            this.col_nom_Categoria.Caption = "Categoria";
            this.col_nom_Categoria.FieldName = "nom_Categoria";
            this.col_nom_Categoria.Name = "col_nom_Categoria";
            this.col_nom_Categoria.Visible = true;
            this.col_nom_Categoria.VisibleIndex = 7;
            this.col_nom_Categoria.Width = 98;
            // 
            // col_nom_Linea
            // 
            this.col_nom_Linea.Caption = "Linea";
            this.col_nom_Linea.FieldName = "nom_Linea";
            this.col_nom_Linea.Name = "col_nom_Linea";
            this.col_nom_Linea.Visible = true;
            this.col_nom_Linea.VisibleIndex = 8;
            this.col_nom_Linea.Width = 98;
            // 
            // col_nom_Tipo_Producto
            // 
            this.col_nom_Tipo_Producto.Caption = "Tipo Producto";
            this.col_nom_Tipo_Producto.FieldName = "nom_Tipo_Producto";
            this.col_nom_Tipo_Producto.Name = "col_nom_Tipo_Producto";
            this.col_nom_Tipo_Producto.Visible = true;
            this.col_nom_Tipo_Producto.VisibleIndex = 9;
            this.col_nom_Tipo_Producto.Width = 114;
            // 
            // chk_mostrar_con_stock
            // 
            this.chk_mostrar_con_stock.EditValue = true;
            this.chk_mostrar_con_stock.Location = new System.Drawing.Point(482, 29);
            this.chk_mostrar_con_stock.Name = "chk_mostrar_con_stock";
            this.chk_mostrar_con_stock.Properties.Caption = "Mostrar Stock > 0";
            this.chk_mostrar_con_stock.Size = new System.Drawing.Size(146, 20);
            this.chk_mostrar_con_stock.TabIndex = 1;
            // 
            // FrmIn_Producto_Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 461);
            this.Controls.Add(this.gridControlProductos);
            this.Controls.Add(this.pnlSucBod);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmIn_Producto_Busqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda Producto";
            this.Load += new System.EventHandler(this.frmIn_Producto_Busqueda_Load);
            this.pnlSucBod.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_mostrar_con_stock.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // private Infragistics.Win.UltraWinGrid.UltraGrid ultrGriProductos;
        private System.Windows.Forms.Panel pnlSucBod;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton BtnSeleccionar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraGrid.GridControl gridControlProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductos;
        private Controles.UCIn_Sucursal_Bodega UCIn_Sucursal_Bodega;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn col_pr_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn col_pr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn col_pr_descripcion_2;
        private DevExpress.XtraGrid.Columns.GridColumn col_pr_peso;
        private DevExpress.XtraGrid.Columns.GridColumn col_pr_stock;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn col_UnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn col_nom_Bodega;
        private DevExpress.XtraGrid.Columns.GridColumn col_nom_Categoria;
        private DevExpress.XtraGrid.Columns.GridColumn col_nom_Linea;
        private DevExpress.XtraGrid.Columns.GridColumn col_nom_Tipo_Producto;
        private DevExpress.XtraEditors.CheckEdit chk_mostrar_con_stock;
        // private Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider ultraGridFilterUIProvider1;
    }
}