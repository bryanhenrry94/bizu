namespace Bizu.Presentation.CuentasxPagar
{
    partial class frmCP_OrdenGiro_Pendiente_ING_x_OC_Cons
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Seleccionar = new System.Windows.Forms.ToolStripButton();
            this.btn_Salir = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Buscar = new DevExpress.XtraEditors.SimpleButton();
            this.dtp_Hasta = new DevExpress.XtraEditors.DateEdit();
            this.dtp_Desde = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControlOG = new DevExpress.XtraGrid.GridControl();
            this.UltraGrid_OrdenGiro = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCbteCble_Ogiro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_TipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_fechaOg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_FechaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_subtotal_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_subtotal_siniva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_baseImponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_CXP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa_ret = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdRetencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colre_serie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colre_NumRetencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado_Cancelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_valorpagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_valoriva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_Retencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_NumRetencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_serie2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_serie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Num_Autorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_tipo_flujo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_tiene_ingresos = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Hasta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Hasta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Desde.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Desde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_OrdenGiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_flujo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tiene_ingresos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Seleccionar,
            this.btn_Salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(813, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(71, 22);
            this.btn_Seleccionar.Text = "Seleccionar";
            this.btn_Seleccionar.Click += new System.EventHandler(this.btn_Seleccionar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Image = global::Bizu.Presentation.Properties.Resources.erp_256;
            this.btn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(49, 22);
            this.btn_Salir.Text = "Salir";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Buscar);
            this.panelControl1.Controls.Add(this.dtp_Hasta);
            this.panelControl1.Controls.Add(this.dtp_Desde);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 25);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(813, 58);
            this.panelControl1.TabIndex = 1;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(232, 6);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 4;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // dtp_Hasta
            // 
            this.dtp_Hasta.EditValue = null;
            this.dtp_Hasta.Location = new System.Drawing.Point(76, 31);
            this.dtp_Hasta.Name = "dtp_Hasta";
            this.dtp_Hasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_Hasta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_Hasta.Size = new System.Drawing.Size(100, 20);
            this.dtp_Hasta.TabIndex = 3;
            // 
            // dtp_Desde
            // 
            this.dtp_Desde.EditValue = null;
            this.dtp_Desde.Location = new System.Drawing.Point(76, 7);
            this.dtp_Desde.Name = "dtp_Desde";
            this.dtp_Desde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_Desde.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_Desde.Size = new System.Drawing.Size(100, 20);
            this.dtp_Desde.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde:";
            // 
            // gridControlOG
            // 
            this.gridControlOG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOG.Location = new System.Drawing.Point(0, 83);
            this.gridControlOG.MainView = this.UltraGrid_OrdenGiro;
            this.gridControlOG.Name = "gridControlOG";
            this.gridControlOG.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_tipo_flujo,
            this.cmb_tiene_ingresos});
            this.gridControlOG.Size = new System.Drawing.Size(813, 324);
            this.gridControlOG.TabIndex = 15;
            this.gridControlOG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UltraGrid_OrdenGiro});
            // 
            // UltraGrid_OrdenGiro
            // 
            this.UltraGrid_OrdenGiro.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCbteCble_Ogiro,
            this.coltc_TipoCbte,
            this.colco_fechaOg,
            this.colco_factura,
            this.colco_FechaFactura,
            this.colNomProveedor,
            this.colco_observacion,
            this.colco_subtotal_iva,
            this.colco_subtotal_siniva,
            this.colco_baseImponible,
            this.colEstado,
            this.colIdCtaCble_CXP,
            this.colIdEmpresa_ret,
            this.colIdRetencion,
            this.colre_serie,
            this.colre_NumRetencion,
            this.colEstado_Cancelacion,
            this.colTotal,
            this.colSaldo,
            this.colco_valorpagar,
            this.colco_valoriva,
            this.colTotal_Retencion,
            this.gridColumn5,
            this.Col_NumRetencion,
            this.Col_serie2,
            this.Col_serie1,
            this.Col_Num_Autorizacion});
            this.UltraGrid_OrdenGiro.CustomizationFormBounds = new System.Drawing.Rectangle(519, 397, 216, 178);
            this.UltraGrid_OrdenGiro.GridControl = this.gridControlOG;
            this.UltraGrid_OrdenGiro.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "co_total", this.colTotal, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "saldo", this.colSaldo, "{0:c2}")});
            this.UltraGrid_OrdenGiro.Name = "UltraGrid_OrdenGiro";
            this.UltraGrid_OrdenGiro.OptionsView.ShowAutoFilterRow = true;
            this.UltraGrid_OrdenGiro.OptionsView.ShowGroupPanel = false;
            this.UltraGrid_OrdenGiro.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdCbteCble_Ogiro, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colIdCbteCble_Ogiro
            // 
            this.colIdCbteCble_Ogiro.Caption = "#Cbte";
            this.colIdCbteCble_Ogiro.FieldName = "IdCbteCble_Ogiro";
            this.colIdCbteCble_Ogiro.Name = "colIdCbteCble_Ogiro";
            this.colIdCbteCble_Ogiro.OptionsColumn.AllowEdit = false;
            this.colIdCbteCble_Ogiro.OptionsColumn.ReadOnly = true;
            this.colIdCbteCble_Ogiro.OptionsFilter.AllowFilter = false;
            this.colIdCbteCble_Ogiro.Visible = true;
            this.colIdCbteCble_Ogiro.VisibleIndex = 0;
            this.colIdCbteCble_Ogiro.Width = 81;
            // 
            // coltc_TipoCbte
            // 
            this.coltc_TipoCbte.Caption = "Tipo Comp. CxP";
            this.coltc_TipoCbte.FieldName = "tc_TipoCbte";
            this.coltc_TipoCbte.Name = "coltc_TipoCbte";
            this.coltc_TipoCbte.OptionsColumn.AllowEdit = false;
            this.coltc_TipoCbte.OptionsColumn.ReadOnly = true;
            this.coltc_TipoCbte.Width = 87;
            // 
            // colco_fechaOg
            // 
            this.colco_fechaOg.Caption = "Fecha Comp. CxP";
            this.colco_fechaOg.FieldName = "co_fechaOg";
            this.colco_fechaOg.Name = "colco_fechaOg";
            this.colco_fechaOg.OptionsColumn.AllowEdit = false;
            this.colco_fechaOg.OptionsColumn.ReadOnly = true;
            this.colco_fechaOg.Width = 110;
            // 
            // colco_factura
            // 
            this.colco_factura.Caption = "# Documento";
            this.colco_factura.FieldName = "co_factura";
            this.colco_factura.Name = "colco_factura";
            this.colco_factura.OptionsColumn.AllowEdit = false;
            this.colco_factura.OptionsColumn.ReadOnly = true;
            this.colco_factura.Visible = true;
            this.colco_factura.VisibleIndex = 1;
            this.colco_factura.Width = 100;
            // 
            // colco_FechaFactura
            // 
            this.colco_FechaFactura.Caption = "Fecha Documento";
            this.colco_FechaFactura.FieldName = "co_FechaFactura";
            this.colco_FechaFactura.Name = "colco_FechaFactura";
            this.colco_FechaFactura.OptionsColumn.AllowEdit = false;
            this.colco_FechaFactura.OptionsColumn.ReadOnly = true;
            this.colco_FechaFactura.Visible = true;
            this.colco_FechaFactura.VisibleIndex = 2;
            this.colco_FechaFactura.Width = 100;
            // 
            // colNomProveedor
            // 
            this.colNomProveedor.Caption = "Proveedor";
            this.colNomProveedor.FieldName = "InfoProveedor.pr_nombre";
            this.colNomProveedor.Name = "colNomProveedor";
            this.colNomProveedor.OptionsColumn.AllowEdit = false;
            this.colNomProveedor.OptionsColumn.ReadOnly = true;
            this.colNomProveedor.Visible = true;
            this.colNomProveedor.VisibleIndex = 3;
            this.colNomProveedor.Width = 151;
            // 
            // colco_observacion
            // 
            this.colco_observacion.Caption = "Observación";
            this.colco_observacion.FieldName = "co_observacion";
            this.colco_observacion.Name = "colco_observacion";
            this.colco_observacion.OptionsColumn.AllowEdit = false;
            this.colco_observacion.OptionsColumn.ReadOnly = true;
            this.colco_observacion.Visible = true;
            this.colco_observacion.VisibleIndex = 4;
            this.colco_observacion.Width = 84;
            // 
            // colco_subtotal_iva
            // 
            this.colco_subtotal_iva.Caption = "Subtotal IVA";
            this.colco_subtotal_iva.DisplayFormat.FormatString = "n2";
            this.colco_subtotal_iva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colco_subtotal_iva.FieldName = "co_subtotal_iva";
            this.colco_subtotal_iva.Name = "colco_subtotal_iva";
            this.colco_subtotal_iva.OptionsColumn.AllowEdit = false;
            this.colco_subtotal_iva.OptionsColumn.ReadOnly = true;
            this.colco_subtotal_iva.Width = 81;
            // 
            // colco_subtotal_siniva
            // 
            this.colco_subtotal_siniva.Caption = "Subtotal sin IVA";
            this.colco_subtotal_siniva.DisplayFormat.FormatString = "n2";
            this.colco_subtotal_siniva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colco_subtotal_siniva.FieldName = "co_subtotal_siniva";
            this.colco_subtotal_siniva.Name = "colco_subtotal_siniva";
            this.colco_subtotal_siniva.OptionsColumn.AllowEdit = false;
            this.colco_subtotal_siniva.OptionsColumn.ReadOnly = true;
            this.colco_subtotal_siniva.Width = 101;
            // 
            // colco_baseImponible
            // 
            this.colco_baseImponible.Caption = "Base Imponible";
            this.colco_baseImponible.DisplayFormat.FormatString = "n2";
            this.colco_baseImponible.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colco_baseImponible.FieldName = "co_baseImponible";
            this.colco_baseImponible.Name = "colco_baseImponible";
            this.colco_baseImponible.OptionsColumn.AllowEdit = false;
            this.colco_baseImponible.OptionsColumn.ReadOnly = true;
            this.colco_baseImponible.Width = 91;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.ReadOnly = true;
            this.colEstado.Width = 84;
            // 
            // colIdCtaCble_CXP
            // 
            this.colIdCtaCble_CXP.FieldName = "IdCtaCble_CXP";
            this.colIdCtaCble_CXP.Name = "colIdCtaCble_CXP";
            this.colIdCtaCble_CXP.OptionsColumn.ReadOnly = true;
            // 
            // colIdEmpresa_ret
            // 
            this.colIdEmpresa_ret.FieldName = "IdEmpresa_ret";
            this.colIdEmpresa_ret.Name = "colIdEmpresa_ret";
            this.colIdEmpresa_ret.OptionsColumn.ReadOnly = true;
            // 
            // colIdRetencion
            // 
            this.colIdRetencion.FieldName = "IdRetencion";
            this.colIdRetencion.Name = "colIdRetencion";
            this.colIdRetencion.OptionsColumn.ReadOnly = true;
            // 
            // colre_serie
            // 
            this.colre_serie.FieldName = "re_serie";
            this.colre_serie.Name = "colre_serie";
            this.colre_serie.OptionsColumn.ReadOnly = true;
            // 
            // colre_NumRetencion
            // 
            this.colre_NumRetencion.FieldName = "re_NumRetencion";
            this.colre_NumRetencion.Name = "colre_NumRetencion";
            this.colre_NumRetencion.OptionsColumn.ReadOnly = true;
            // 
            // colEstado_Cancelacion
            // 
            this.colEstado_Cancelacion.Caption = "Estado de Cancelacion";
            this.colEstado_Cancelacion.FieldName = "Estado_Cancelacion";
            this.colEstado_Cancelacion.Name = "colEstado_Cancelacion";
            this.colEstado_Cancelacion.OptionsColumn.ReadOnly = true;
            this.colEstado_Cancelacion.Visible = true;
            this.colEstado_Cancelacion.VisibleIndex = 8;
            this.colEstado_Cancelacion.Width = 64;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.DisplayFormat.FormatString = "n2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "co_total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.ReadOnly = true;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            this.colTotal.Width = 76;
            // 
            // colSaldo
            // 
            this.colSaldo.Caption = "Saldo";
            this.colSaldo.DisplayFormat.FormatString = "n2";
            this.colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaldo.FieldName = "saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.OptionsColumn.ReadOnly = true;
            this.colSaldo.Visible = true;
            this.colSaldo.VisibleIndex = 6;
            this.colSaldo.Width = 84;
            // 
            // colco_valorpagar
            // 
            this.colco_valorpagar.Caption = "Valor a pagar";
            this.colco_valorpagar.DisplayFormat.FormatString = "n2";
            this.colco_valorpagar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colco_valorpagar.FieldName = "co_valorpagar";
            this.colco_valorpagar.Name = "colco_valorpagar";
            this.colco_valorpagar.OptionsColumn.ReadOnly = true;
            this.colco_valorpagar.Width = 113;
            // 
            // colco_valoriva
            // 
            this.colco_valoriva.Caption = "IVA";
            this.colco_valoriva.DisplayFormat.FormatString = "n2";
            this.colco_valoriva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colco_valoriva.FieldName = "co_valoriva";
            this.colco_valoriva.Name = "colco_valoriva";
            // 
            // colTotal_Retencion
            // 
            this.colTotal_Retencion.Caption = "Total Reten.";
            this.colTotal_Retencion.DisplayFormat.FormatString = "n2";
            this.colTotal_Retencion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal_Retencion.FieldName = "Total_Retencion";
            this.colTotal_Retencion.Name = "colTotal_Retencion";
            this.colTotal_Retencion.Visible = true;
            this.colTotal_Retencion.VisibleIndex = 7;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Clase proveedor";
            this.gridColumn5.FieldName = "InfoProveedor.descripcion_clas_prove";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // Col_NumRetencion
            // 
            this.Col_NumRetencion.Caption = "Num Retencion";
            this.Col_NumRetencion.FieldName = "NumRetencion";
            this.Col_NumRetencion.Name = "Col_NumRetencion";
            // 
            // Col_serie2
            // 
            this.Col_serie2.Caption = "Serie2";
            this.Col_serie2.FieldName = "serie2";
            this.Col_serie2.Name = "Col_serie2";
            // 
            // Col_serie1
            // 
            this.Col_serie1.Caption = "Seri1";
            this.Col_serie1.FieldName = "serie1";
            this.Col_serie1.Name = "Col_serie1";
            // 
            // Col_Num_Autorizacion
            // 
            this.Col_Num_Autorizacion.Caption = "Num. Autorizacion";
            this.Col_Num_Autorizacion.FieldName = "Num_Autorizacion";
            this.Col_Num_Autorizacion.Name = "Col_Num_Autorizacion";
            // 
            // cmb_tipo_flujo
            // 
            this.cmb_tipo_flujo.AutoHeight = false;
            this.cmb_tipo_flujo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_tipo_flujo.DisplayMember = "Descricion2";
            this.cmb_tipo_flujo.Name = "cmb_tipo_flujo";
            this.cmb_tipo_flujo.PopupView = this.repositoryItemSearchLookUpEdit1View;
            this.cmb_tipo_flujo.ValueMember = "IdTipoFlujo";
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IdTipoFlujo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 93;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Flujo";
            this.gridColumn2.FieldName = "Descricion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 798;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tipo";
            this.gridColumn3.FieldName = "Tipo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 170;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Código";
            this.gridColumn4.FieldName = "cod_flujo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 119;
            // 
            // cmb_tiene_ingresos
            // 
            this.cmb_tiene_ingresos.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_tiene_ingresos.AutoHeight = false;
            this.cmb_tiene_ingresos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_tiene_ingresos.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmb_tiene_ingresos.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0)});
            this.cmb_tiene_ingresos.Name = "cmb_tiene_ingresos";
            this.cmb_tiene_ingresos.ReadOnly = true;
            // 
            // frmCP_OrdenGiro_Pendiente_ING_x_OC_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 407);
            this.Controls.Add(this.gridControlOG);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCP_OrdenGiro_Pendiente_ING_x_OC_Cons";
            this.Text = "Facturas de Proveedor Pendientes de Ingreso x Orden de Compra";
            this.Load += new System.EventHandler(this.frmCP_OrdenGiro_Pendiente_ING_x_OC_Cons_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Hasta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Hasta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Desde.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Desde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_OrdenGiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_flujo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tiene_ingresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Seleccionar;
        private System.Windows.Forms.ToolStripButton btn_Salir;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit dtp_Hasta;
        private DevExpress.XtraEditors.DateEdit dtp_Desde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_Buscar;
        private DevExpress.XtraGrid.GridControl gridControlOG;
        private DevExpress.XtraGrid.Views.Grid.GridView UltraGrid_OrdenGiro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbteCble_Ogiro;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_TipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn colco_fechaOg;
        private DevExpress.XtraGrid.Columns.GridColumn colco_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colco_FechaFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colNomProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colco_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colco_subtotal_iva;
        private DevExpress.XtraGrid.Columns.GridColumn colco_subtotal_siniva;
        private DevExpress.XtraGrid.Columns.GridColumn colco_baseImponible;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_CXP;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa_ret;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRetencion;
        private DevExpress.XtraGrid.Columns.GridColumn colre_serie;
        private DevExpress.XtraGrid.Columns.GridColumn colre_NumRetencion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado_Cancelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colco_valorpagar;
        private DevExpress.XtraGrid.Columns.GridColumn colco_valoriva;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_Retencion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn Col_NumRetencion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_serie2;
        private DevExpress.XtraGrid.Columns.GridColumn Col_serie1;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Num_Autorizacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_tipo_flujo;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_tiene_ingresos;
    }
}