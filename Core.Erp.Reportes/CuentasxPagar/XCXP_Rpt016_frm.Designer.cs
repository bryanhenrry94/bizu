namespace Core.Erp.Reportes.CuentasxPagar
{
    partial class XCXP_Rpt016_frm
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
            this.PVGrid_Factura_x_Pagar = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldIdCbteCble_Ogiro = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnom_Estado_Aproba = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnum_factura = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldco_FechaFactura = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldco_baseImponible = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldco_valoriva = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldco_total = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldco_valorpagar = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnom_proveedor = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldnom_tipo_Documento = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSu_Descripcion = new DevExpress.XtraPivotGrid.PivotGridField();
            this.ucGe_Menu = new Core.Erp.Reportes.Controles.UCCom_Menu_Reportes();
            ((System.ComponentModel.ISupportInitialize)(this.PVGrid_Factura_x_Pagar)).BeginInit();
            this.SuspendLayout();
            // 
            // PVGrid_Factura_x_Pagar
            // 
            this.PVGrid_Factura_x_Pagar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PVGrid_Factura_x_Pagar.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldIdCbteCble_Ogiro,
            this.fieldnom_Estado_Aproba,
            this.fieldnum_factura,
            this.fieldco_FechaFactura,
            this.fieldco_baseImponible,
            this.fieldco_valoriva,
            this.fieldco_total,
            this.fieldco_valorpagar,
            this.pivotGridField1,
            this.pivotGridField2,
            this.pivotGridField3,
            this.fieldnom_proveedor,
            this.fieldnom_tipo_Documento,
            this.fieldSu_Descripcion});
            this.PVGrid_Factura_x_Pagar.Location = new System.Drawing.Point(0, 222);
            this.PVGrid_Factura_x_Pagar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PVGrid_Factura_x_Pagar.Name = "PVGrid_Factura_x_Pagar";
            this.PVGrid_Factura_x_Pagar.OptionsView.FilterSeparatorBarPadding = 2;
            this.PVGrid_Factura_x_Pagar.Size = new System.Drawing.Size(2274, 978);
            this.PVGrid_Factura_x_Pagar.TabIndex = 0;
            // 
            // fieldIdCbteCble_Ogiro
            // 
            this.fieldIdCbteCble_Ogiro.AreaIndex = 1;
            this.fieldIdCbteCble_Ogiro.Caption = "ID Fact. x Pagar";
            this.fieldIdCbteCble_Ogiro.FieldName = "IdCbteCble_Ogiro";
            this.fieldIdCbteCble_Ogiro.MinWidth = 40;
            this.fieldIdCbteCble_Ogiro.Name = "fieldIdCbteCble_Ogiro";
            this.fieldIdCbteCble_Ogiro.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.fieldIdCbteCble_Ogiro.Width = 200;
            // 
            // fieldnom_Estado_Aproba
            // 
            this.fieldnom_Estado_Aproba.AreaIndex = 0;
            this.fieldnom_Estado_Aproba.Caption = "Estado Aprobación";
            this.fieldnom_Estado_Aproba.FieldName = "nom_Estado_Aproba";
            this.fieldnom_Estado_Aproba.MinWidth = 40;
            this.fieldnom_Estado_Aproba.Name = "fieldnom_Estado_Aproba";
            this.fieldnom_Estado_Aproba.Width = 200;
            // 
            // fieldnum_factura
            // 
            this.fieldnum_factura.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldnum_factura.AreaIndex = 1;
            this.fieldnum_factura.Caption = "# Factura";
            this.fieldnum_factura.FieldName = "num_factura";
            this.fieldnum_factura.MinWidth = 40;
            this.fieldnum_factura.Name = "fieldnum_factura";
            this.fieldnum_factura.Width = 200;
            // 
            // fieldco_FechaFactura
            // 
            this.fieldco_FechaFactura.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldco_FechaFactura.AreaIndex = 2;
            this.fieldco_FechaFactura.Caption = "Fec.Factura";
            this.fieldco_FechaFactura.FieldName = "co_FechaFactura";
            this.fieldco_FechaFactura.MinWidth = 40;
            this.fieldco_FechaFactura.Name = "fieldco_FechaFactura";
            this.fieldco_FechaFactura.Width = 200;
            // 
            // fieldco_baseImponible
            // 
            this.fieldco_baseImponible.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldco_baseImponible.AreaIndex = 0;
            this.fieldco_baseImponible.Caption = "Base Imponible";
            this.fieldco_baseImponible.CellFormat.FormatString = "{0:n2}";
            this.fieldco_baseImponible.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldco_baseImponible.FieldName = "co_baseImponible";
            this.fieldco_baseImponible.MinWidth = 40;
            this.fieldco_baseImponible.Name = "fieldco_baseImponible";
            this.fieldco_baseImponible.Width = 200;
            // 
            // fieldco_valoriva
            // 
            this.fieldco_valoriva.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldco_valoriva.AreaIndex = 1;
            this.fieldco_valoriva.Caption = "IVA";
            this.fieldco_valoriva.CellFormat.FormatString = "{0:n2}";
            this.fieldco_valoriva.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldco_valoriva.FieldName = "co_valoriva";
            this.fieldco_valoriva.MinWidth = 40;
            this.fieldco_valoriva.Name = "fieldco_valoriva";
            this.fieldco_valoriva.Width = 200;
            // 
            // fieldco_total
            // 
            this.fieldco_total.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldco_total.AreaIndex = 2;
            this.fieldco_total.Caption = "Total";
            this.fieldco_total.CellFormat.FormatString = "{0:n2}";
            this.fieldco_total.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldco_total.FieldName = "co_total";
            this.fieldco_total.MinWidth = 40;
            this.fieldco_total.Name = "fieldco_total";
            this.fieldco_total.Width = 200;
            // 
            // fieldco_valorpagar
            // 
            this.fieldco_valorpagar.AreaIndex = 4;
            this.fieldco_valorpagar.Caption = "Total a Pagar";
            this.fieldco_valorpagar.FieldName = "co_valorpagar";
            this.fieldco_valorpagar.MinWidth = 40;
            this.fieldco_valorpagar.Name = "fieldco_valorpagar";
            this.fieldco_valorpagar.Width = 200;
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField1.AreaIndex = 3;
            this.pivotGridField1.Caption = "Total Retencion";
            this.pivotGridField1.CellFormat.FormatString = "{0:n2}";
            this.pivotGridField1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridField1.FieldName = "Total_Retencion";
            this.pivotGridField1.MinWidth = 40;
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.Width = 200;
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField2.AreaIndex = 4;
            this.pivotGridField2.Caption = "Valor a Pagar";
            this.pivotGridField2.CellFormat.FormatString = "{0:n2}";
            this.pivotGridField2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridField2.FieldName = "co_valorpagar";
            this.pivotGridField2.MinWidth = 40;
            this.pivotGridField2.Name = "pivotGridField2";
            this.pivotGridField2.Width = 200;
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField3.AreaIndex = 5;
            this.pivotGridField3.Caption = "Saldo";
            this.pivotGridField3.CellFormat.FormatString = "{0:n2}";
            this.pivotGridField3.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.pivotGridField3.FieldName = "SaldoOG";
            this.pivotGridField3.MinWidth = 40;
            this.pivotGridField3.Name = "pivotGridField3";
            this.pivotGridField3.Width = 200;
            // 
            // fieldnom_proveedor
            // 
            this.fieldnom_proveedor.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldnom_proveedor.AreaIndex = 0;
            this.fieldnom_proveedor.Caption = "Proveedor";
            this.fieldnom_proveedor.FieldName = "nom_proveedor";
            this.fieldnom_proveedor.MinWidth = 40;
            this.fieldnom_proveedor.Name = "fieldnom_proveedor";
            this.fieldnom_proveedor.Width = 200;
            // 
            // fieldnom_tipo_Documento
            // 
            this.fieldnom_tipo_Documento.AreaIndex = 2;
            this.fieldnom_tipo_Documento.Caption = "Documento";
            this.fieldnom_tipo_Documento.FieldName = "nom_tipo_Documento";
            this.fieldnom_tipo_Documento.MinWidth = 40;
            this.fieldnom_tipo_Documento.Name = "fieldnom_tipo_Documento";
            this.fieldnom_tipo_Documento.Width = 200;
            // 
            // fieldSu_Descripcion
            // 
            this.fieldSu_Descripcion.AreaIndex = 3;
            this.fieldSu_Descripcion.Caption = "Sucursal";
            this.fieldSu_Descripcion.FieldName = "Su_Descripcion";
            this.fieldSu_Descripcion.MinWidth = 40;
            this.fieldSu_Descripcion.Name = "fieldSu_Descripcion";
            this.fieldSu_Descripcion.Width = 200;
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enable_boton_Imprimir = true;
            this.ucGe_Menu.Enable_boton_Refrescar = true;
            this.ucGe_Menu.Enable_boton_Salir = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(2274, 222);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Text_bei_check1 = "Mostrar anuladas";
            this.ucGe_Menu.Text_bei_check2 = "Solo sin Factura";
            this.ucGe_Menu.Visible_bei_bodega = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_bei_check1 = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_bei_check2 = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_bei_EstadoAprobacion_OC = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_bei_Fecha_Fin = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_bei_Fecha_Ini = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_bei_grupo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_bei_producto = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_Imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_Refrescar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_Salir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_Grupo_acciones = true;
            this.ucGe_Menu.Visible_Grupo_Categoria = true;
            this.ucGe_Menu.Visible_Grupo_filtro = true;
            this.ucGe_Menu.Visible_GrupoCentroCosto = true;
            this.ucGe_Menu.Visible_GrupoProveedor = true;
            this.ucGe_Menu.Visible_GrupoPuntoCargo = false;
            this.ucGe_Menu.Visible_GrupoSucursal_producto = false;
            this.ucGe_Menu.event_btnImprimir_ItemClick += new Core.Erp.Reportes.Controles.UCCom_Menu_Reportes.delegate_btnImprimir_ItemClick(this.ucGe_Menu_event_btnImprimir_ItemClick);
            this.ucGe_Menu.event_btnRefrescar_ItemClick += new Core.Erp.Reportes.Controles.UCCom_Menu_Reportes.delegate_btnRefrescar_ItemClick(this.ucGe_Menu_event_btnRefrescar_ItemClick);
            this.ucGe_Menu.event_btnsalir_ItemClick += new Core.Erp.Reportes.Controles.UCCom_Menu_Reportes.delegate_btnsalir_ItemClick(this.ucGe_Menu_event_btnsalir_ItemClick);
            // 
            // XCXP_Rpt016_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2274, 1200);
            this.Controls.Add(this.PVGrid_Factura_x_Pagar);
            this.Controls.Add(this.ucGe_Menu);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "XCXP_Rpt016_frm";
            this.Text = "MATRIZ CUENTAS POR PAGAR";
            this.Load += new System.EventHandler(this.XCXP_Rpt016_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PVGrid_Factura_x_Pagar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCCom_Menu_Reportes ucGe_Menu;
        private DevExpress.XtraPivotGrid.PivotGridControl PVGrid_Factura_x_Pagar;
        private DevExpress.XtraPivotGrid.PivotGridField fieldIdCbteCble_Ogiro;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnom_Estado_Aproba;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnum_factura;
        private DevExpress.XtraPivotGrid.PivotGridField fieldco_FechaFactura;
        private DevExpress.XtraPivotGrid.PivotGridField fieldco_baseImponible;
        private DevExpress.XtraPivotGrid.PivotGridField fieldco_valoriva;
        private DevExpress.XtraPivotGrid.PivotGridField fieldco_total;
        private DevExpress.XtraPivotGrid.PivotGridField fieldco_valorpagar;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnom_proveedor;
        private DevExpress.XtraPivotGrid.PivotGridField fieldnom_tipo_Documento;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSu_Descripcion;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
    }
}