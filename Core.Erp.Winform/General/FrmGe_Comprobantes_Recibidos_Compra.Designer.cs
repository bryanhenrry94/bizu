namespace Core.Erp.Winform.General
{
    partial class FrmGe_Comprobantes_Recibidos_Compra
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGe_Comprobantes_Recibidos_Compra));
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Comprobantes_Recibidos();
            this.gridControl_ComprobantesRecibidos = new DevExpress.XtraGrid.GridControl();
            this.gridView_ComprobantesRecibidos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaEmision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAutorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroAutorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXML = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCedulaRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveAcceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSecuencial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdentificacionReceptor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorSinIpuestos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporteTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCbteCble_Ogiro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroDocumentoModificado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollectionCbtesFirma = new DevExpress.Utils.ImageCollection(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ComprobantesRecibidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ComprobantesRecibidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCbtesFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(1437, 191);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_btnAceptar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnEliminar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_FechaFin = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_FechaInicio = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_Grupo_Acciones = true;
            this.ucGe_Menu.Visible_Grupo_CxP = false;
            this.ucGe_Menu.Visible_Grupo_Filtro = true;
            this.ucGe_Menu.Visible_TipoComprobante = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Load += new System.EventHandler(this.ucGe_Menu_Load);
            // 
            // gridControl_ComprobantesRecibidos
            // 
            this.gridControl_ComprobantesRecibidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_ComprobantesRecibidos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl_ComprobantesRecibidos.Location = new System.Drawing.Point(0, 0);
            this.gridControl_ComprobantesRecibidos.MainView = this.gridView_ComprobantesRecibidos;
            this.gridControl_ComprobantesRecibidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl_ComprobantesRecibidos.Name = "gridControl_ComprobantesRecibidos";
            this.gridControl_ComprobantesRecibidos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.gridControl_ComprobantesRecibidos.Size = new System.Drawing.Size(1435, 450);
            this.gridControl_ComprobantesRecibidos.TabIndex = 1;
            this.gridControl_ComprobantesRecibidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_ComprobantesRecibidos});
            // 
            // gridView_ComprobantesRecibidos
            // 
            this.gridView_ComprobantesRecibidos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCheck,
            this.colFechaEmision,
            this.colFechaAutorizacion,
            this.colNumeroAutorizacion,
            this.colTipoComprobante,
            this.colXML,
            this.colCedulaRuc,
            this.colEstado,
            this.colRazonSocial,
            this.colClaveAcceso,
            this.colSecuencial,
            this.colId,
            this.colIdentificacionReceptor,
            this.colValorSinIpuestos,
            this.colIva,
            this.colImporteTotal,
            this.colIdCbteCble_Ogiro,
            this.colMotivo,
            this.colNumeroDocumentoModificado,
            this.gridColumn1});
            this.gridView_ComprobantesRecibidos.CustomizationFormBounds = new System.Drawing.Rectangle(0, 318, 347, 286);
            this.gridView_ComprobantesRecibidos.DetailHeight = 431;
            this.gridView_ComprobantesRecibidos.FixedLineWidth = 1;
            this.gridView_ComprobantesRecibidos.GridControl = this.gridControl_ComprobantesRecibidos;
            this.gridView_ComprobantesRecibidos.Name = "gridView_ComprobantesRecibidos";
            this.gridView_ComprobantesRecibidos.OptionsBehavior.Editable = false;
            this.gridView_ComprobantesRecibidos.OptionsView.ColumnAutoWidth = false;
            this.gridView_ComprobantesRecibidos.OptionsView.ShowAutoFilterRow = true;
            this.gridView_ComprobantesRecibidos.OptionsView.ShowGroupPanel = false;
            this.gridView_ComprobantesRecibidos.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_ComprobantesRecibidos_RowCellClick);
            this.gridView_ComprobantesRecibidos.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_ComprobantesRecibidos_RowCellStyle);
            this.gridView_ComprobantesRecibidos.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_ComprobantesRecibidos_FocusedRowChanged);
            // 
            // colCheck
            // 
            this.colCheck.Caption = "*";
            this.colCheck.FieldName = "Checked";
            this.colCheck.MinWidth = 27;
            this.colCheck.Name = "colCheck";
            this.colCheck.OptionsColumn.AllowEdit = false;
            this.colCheck.Visible = true;
            this.colCheck.VisibleIndex = 0;
            this.colCheck.Width = 57;
            // 
            // colFechaEmision
            // 
            this.colFechaEmision.Caption = "Fecha Emision";
            this.colFechaEmision.DisplayFormat.FormatString = "d";
            this.colFechaEmision.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaEmision.FieldName = "FechaEmision";
            this.colFechaEmision.MinWidth = 27;
            this.colFechaEmision.Name = "colFechaEmision";
            this.colFechaEmision.Visible = true;
            this.colFechaEmision.VisibleIndex = 3;
            this.colFechaEmision.Width = 143;
            // 
            // colFechaAutorizacion
            // 
            this.colFechaAutorizacion.Caption = "Fecha Aut.";
            this.colFechaAutorizacion.FieldName = "FechaAutorizacion";
            this.colFechaAutorizacion.MinWidth = 27;
            this.colFechaAutorizacion.Name = "colFechaAutorizacion";
            this.colFechaAutorizacion.Visible = true;
            this.colFechaAutorizacion.VisibleIndex = 8;
            this.colFechaAutorizacion.Width = 115;
            // 
            // colNumeroAutorizacion
            // 
            this.colNumeroAutorizacion.Caption = "N° Autorizacion";
            this.colNumeroAutorizacion.FieldName = "NumeroAutorizacion";
            this.colNumeroAutorizacion.MinWidth = 27;
            this.colNumeroAutorizacion.Name = "colNumeroAutorizacion";
            this.colNumeroAutorizacion.Visible = true;
            this.colNumeroAutorizacion.VisibleIndex = 9;
            this.colNumeroAutorizacion.Width = 121;
            // 
            // colTipoComprobante
            // 
            this.colTipoComprobante.Caption = "Tipo Comprobante";
            this.colTipoComprobante.FieldName = "TipoComprobante";
            this.colTipoComprobante.MinWidth = 27;
            this.colTipoComprobante.Name = "colTipoComprobante";
            this.colTipoComprobante.Visible = true;
            this.colTipoComprobante.VisibleIndex = 2;
            this.colTipoComprobante.Width = 129;
            // 
            // colXML
            // 
            this.colXML.Caption = "XML";
            this.colXML.FieldName = "XML";
            this.colXML.MinWidth = 27;
            this.colXML.Name = "colXML";
            this.colXML.Visible = true;
            this.colXML.VisibleIndex = 10;
            this.colXML.Width = 85;
            // 
            // colCedulaRuc
            // 
            this.colCedulaRuc.Caption = "Cedula/Ruc";
            this.colCedulaRuc.FieldName = "RucEmisor";
            this.colCedulaRuc.MinWidth = 27;
            this.colCedulaRuc.Name = "colCedulaRuc";
            this.colCedulaRuc.Visible = true;
            this.colCedulaRuc.VisibleIndex = 4;
            this.colCedulaRuc.Width = 184;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.MinWidth = 27;
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 15;
            this.colEstado.Width = 117;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.Caption = "Razon Social";
            this.colRazonSocial.FieldName = "RazonSocialEmisor";
            this.colRazonSocial.MinWidth = 27;
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.Visible = true;
            this.colRazonSocial.VisibleIndex = 5;
            this.colRazonSocial.Width = 236;
            // 
            // colClaveAcceso
            // 
            this.colClaveAcceso.Caption = "Clave Acceso";
            this.colClaveAcceso.FieldName = "ClaveAcceso";
            this.colClaveAcceso.MinWidth = 27;
            this.colClaveAcceso.Name = "colClaveAcceso";
            this.colClaveAcceso.Visible = true;
            this.colClaveAcceso.VisibleIndex = 7;
            this.colClaveAcceso.Width = 112;
            // 
            // colSecuencial
            // 
            this.colSecuencial.Caption = "Serie Comprobante";
            this.colSecuencial.FieldName = "SerieComprobante";
            this.colSecuencial.MinWidth = 27;
            this.colSecuencial.Name = "colSecuencial";
            this.colSecuencial.Visible = true;
            this.colSecuencial.VisibleIndex = 6;
            this.colSecuencial.Width = 159;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 1;
            this.colId.Width = 100;
            // 
            // colIdentificacionReceptor
            // 
            this.colIdentificacionReceptor.Caption = "Identificacion Receptor";
            this.colIdentificacionReceptor.FieldName = "IdentificacionReceptor";
            this.colIdentificacionReceptor.MinWidth = 25;
            this.colIdentificacionReceptor.Name = "colIdentificacionReceptor";
            this.colIdentificacionReceptor.Width = 100;
            // 
            // colValorSinIpuestos
            // 
            this.colValorSinIpuestos.Caption = "Valor Sin Ipuestos";
            this.colValorSinIpuestos.DisplayFormat.FormatString = "{0:n2}";
            this.colValorSinIpuestos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorSinIpuestos.FieldName = "ValorSinImpuestos";
            this.colValorSinIpuestos.MinWidth = 25;
            this.colValorSinIpuestos.Name = "colValorSinIpuestos";
            this.colValorSinIpuestos.Visible = true;
            this.colValorSinIpuestos.VisibleIndex = 11;
            this.colValorSinIpuestos.Width = 100;
            // 
            // colIva
            // 
            this.colIva.Caption = "IVA";
            this.colIva.DisplayFormat.FormatString = "{0:n2}";
            this.colIva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIva.FieldName = "Iva";
            this.colIva.MinWidth = 25;
            this.colIva.Name = "colIva";
            this.colIva.Visible = true;
            this.colIva.VisibleIndex = 12;
            this.colIva.Width = 100;
            // 
            // colImporteTotal
            // 
            this.colImporteTotal.Caption = "Importe Total";
            this.colImporteTotal.DisplayFormat.FormatString = "{0:n2}";
            this.colImporteTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImporteTotal.FieldName = "ImporteTotal";
            this.colImporteTotal.MinWidth = 25;
            this.colImporteTotal.Name = "colImporteTotal";
            this.colImporteTotal.Visible = true;
            this.colImporteTotal.VisibleIndex = 13;
            this.colImporteTotal.Width = 100;
            // 
            // colIdCbteCble_Ogiro
            // 
            this.colIdCbteCble_Ogiro.Caption = "# Cbte Fact.";
            this.colIdCbteCble_Ogiro.FieldName = "IdCbteCble_Ogiro";
            this.colIdCbteCble_Ogiro.MinWidth = 25;
            this.colIdCbteCble_Ogiro.Name = "colIdCbteCble_Ogiro";
            this.colIdCbteCble_Ogiro.Visible = true;
            this.colIdCbteCble_Ogiro.VisibleIndex = 14;
            this.colIdCbteCble_Ogiro.Width = 128;
            // 
            // colMotivo
            // 
            this.colMotivo.Caption = "Motivo";
            this.colMotivo.FieldName = "Motivo";
            this.colMotivo.MinWidth = 25;
            this.colMotivo.Name = "colMotivo";
            this.colMotivo.Width = 100;
            // 
            // colNumeroDocumentoModificado
            // 
            this.colNumeroDocumentoModificado.Caption = "Doc. Modificado";
            this.colNumeroDocumentoModificado.FieldName = "NumeroDocumentoModificado";
            this.colNumeroDocumentoModificado.MinWidth = 25;
            this.colNumeroDocumentoModificado.Name = "colNumeroDocumentoModificado";
            this.colNumeroDocumentoModificado.Width = 100;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.MinWidth = 27;
            this.gridColumn1.Name = "gridColumn1";
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 5)});
            this.repositoryItemImageComboBox1.LargeImages = this.imageCollectionCbtesFirma;
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageCollectionCbtesFirma;
            // 
            // imageCollectionCbtesFirma
            // 
            this.imageCollectionCbtesFirma.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionCbtesFirma.ImageStream")));
            this.imageCollectionCbtesFirma.Images.SetKeyName(0, "xml_firmado_32x32.png");
            this.imageCollectionCbtesFirma.Images.SetKeyName(1, "imprimir_32x32.png");
            this.imageCollectionCbtesFirma.Images.SetKeyName(2, "1417488454_pdf.png");
            this.imageCollectionCbtesFirma.Images.SetKeyName(3, "application-xml.png");
            this.imageCollectionCbtesFirma.Images.SetKeyName(4, "anular2_32.x32png.png");
            this.imageCollectionCbtesFirma.Images.SetKeyName(5, "check_16x16.png");
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 191);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1437, 480);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl_ComprobantesRecibidos);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1435, 450);
            this.xtraTabPage1.Text = "Comprobantes Recibidos";
            // 
            // FrmGe_Comprobantes_Recibidos_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 671);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmGe_Comprobantes_Recibidos_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprobantes Recibidos Compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGe_Comprobantes_Recibidos_Cons_FormClosing);
            this.Load += new System.EventHandler(this.FrmGe_Comprobantes_Recibidos_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ComprobantesRecibidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ComprobantesRecibidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionCbtesFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Comprobantes_Recibidos ucGe_Menu;
        private DevExpress.XtraGrid.GridControl gridControl_ComprobantesRecibidos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_ComprobantesRecibidos;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaEmision;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAutorizacion;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroAutorizacion;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn colXML;
        private DevExpress.XtraGrid.Columns.GridColumn colCedulaRuc;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.Utils.ImageCollection imageCollectionCbtesFirma;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveAcceso;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencial;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentificacionReceptor;
        private DevExpress.XtraGrid.Columns.GridColumn colValorSinIpuestos;
        private DevExpress.XtraGrid.Columns.GridColumn colIva;
        private DevExpress.XtraGrid.Columns.GridColumn colImporteTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbteCble_Ogiro;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivo;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroDocumentoModificado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}