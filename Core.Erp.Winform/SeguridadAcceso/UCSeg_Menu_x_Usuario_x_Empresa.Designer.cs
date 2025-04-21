namespace Core.Erp.Winform.SeguridadAcceso
{
    partial class UCSeg_Menu_x_Usuario_x_Empresa
    {
        public DevExpress.XtraTreeList.TreeList treeListMenu_x_Usuario_x_Empresa;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSeg_Menu_x_Usuario_x_Empresa));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeListMenu_x_Usuario_x_Empresa = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Tiene_FormularioAsociado = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnTree = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu_x_Usuario_x_Empresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 24);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(396, 454);
            this.panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.treeListMenu_x_Usuario_x_Empresa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 454);
            this.panel2.TabIndex = 4;
            // 
            // treeListMenu_x_Usuario_x_Empresa
            // 
            this.treeListMenu_x_Usuario_x_Empresa.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.Tiene_FormularioAsociado,
            this.treeListColumn3});
            this.treeListMenu_x_Usuario_x_Empresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListMenu_x_Usuario_x_Empresa.ImageIndexFieldName = "icono";
            this.treeListMenu_x_Usuario_x_Empresa.KeyFieldName = "IdMenu";
            this.treeListMenu_x_Usuario_x_Empresa.Location = new System.Drawing.Point(0, 0);
            this.treeListMenu_x_Usuario_x_Empresa.Name = "treeListMenu_x_Usuario_x_Empresa";
            this.treeListMenu_x_Usuario_x_Empresa.OptionsBehavior.Editable = false;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Matches;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsPrint.PrintAllNodes = true;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsPrint.PrintFilledTreeIndent = true;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsSelection.UseIndicatorForSelection = true;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsView.ShowAutoFilterRow = true;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsView.ShowColumns = false;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsView.ShowFilterPanelMode = DevExpress.XtraTreeList.ShowFilterPanelMode.ShowAlways;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsView.ShowHorzLines = false;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsView.ShowIndicator = false;
            this.treeListMenu_x_Usuario_x_Empresa.OptionsView.ShowPreview = true;
            this.treeListMenu_x_Usuario_x_Empresa.ParentFieldName = "IdMenuPadre";
            this.treeListMenu_x_Usuario_x_Empresa.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowForFocusedRow;
            this.treeListMenu_x_Usuario_x_Empresa.Size = new System.Drawing.Size(396, 454);
            this.treeListMenu_x_Usuario_x_Empresa.TabIndex = 0;
            this.treeListMenu_x_Usuario_x_Empresa.SelectImageClick += new DevExpress.XtraTreeList.NodeClickEventHandler(this.treeListMenu_x_Usuario_x_Empresa_SelectImageClick);
            this.treeListMenu_x_Usuario_x_Empresa.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.treeListMenu_x_Usuario_x_Empresa_NodeCellStyle);
            this.treeListMenu_x_Usuario_x_Empresa.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListMenu_x_Usuario_x_Empresa_FocusedNodeChanged);
            this.treeListMenu_x_Usuario_x_Empresa.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.treeListMenu_x_Usuario_x_Empresa_CustomDrawNodeCell);
            this.treeListMenu_x_Usuario_x_Empresa.TreeListMenuItemClick += new DevExpress.XtraTreeList.TreeListMenuItemClickEventHandler(this.treeListMenu_x_Usuario_x_Empresa_TreeListMenuItemClick);
            this.treeListMenu_x_Usuario_x_Empresa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.treeListMenu_x_Usuario_x_Empresa_KeyUp);
            this.treeListMenu_x_Usuario_x_Empresa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeListMenu_x_Usuario_x_Empresa_MouseDown);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Descripcion";
            this.treeListColumn1.FieldName = "DescripcionMenu";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "id";
            this.treeListColumn2.FieldName = "IdMenu";
            this.treeListColumn2.Name = "treeListColumn2";
            // 
            // Tiene_FormularioAsociado
            // 
            this.Tiene_FormularioAsociado.Caption = "treeListColumn3";
            this.Tiene_FormularioAsociado.FieldName = "Tiene_FormularioAsociado";
            this.Tiene_FormularioAsociado.Name = "Tiene_FormularioAsociado";
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "PosicionMenu";
            this.treeListColumn3.FieldName = "PosicionMenu";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "open_32x32.png");
            this.imageCollection1.Images.SetKeyName(1, "technology_32x32.png");
            this.imageCollection1.Images.SetKeyName(2, "window_32x32.png");
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnRefresh,
            this.btnTree});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTree)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 0;
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnTree
            // 
            this.btnTree.Caption = "Expands";
            this.btnTree.Id = 1;
            this.btnTree.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTree.ImageOptions.SvgImage")));
            this.btnTree.Name = "btnTree";
            this.btnTree.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTree_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(396, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 478);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(396, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 454);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(396, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 454);
            // 
            // UCSeg_Menu_x_Usuario_x_Empresa
            // 
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UCSeg_Menu_x_Usuario_x_Empresa";
            this.Size = new System.Drawing.Size(396, 478);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListMenu_x_Usuario_x_Empresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private DevExpress.XtraTreeList.TreeList treeListMenu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Tiene_FormularioAsociado;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        public DevExpress.Utils.ImageCollection imageCollection1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnTree;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}
