namespace Bizu.Presentation.CuentasxPagar
{
    partial class frmCP_anticipo_Proveedores_Cons
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
            this.gridControlAnticipo = new DevExpress.XtraGrid.GridControl();
            this.cxccobroxAnticipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewAnticipo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tc_TipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Beneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Referencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor_cbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.valor_cancelado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cxccobroInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Bizu.Presentation.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAnticipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobroxAnticipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAnticipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobroInfoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlAnticipo
            // 
            this.gridControlAnticipo.DataSource = this.cxccobroxAnticipoInfoBindingSource;
            this.gridControlAnticipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAnticipo.Location = new System.Drawing.Point(0, 0);
            this.gridControlAnticipo.MainView = this.gridViewAnticipo;
            this.gridControlAnticipo.Name = "gridControlAnticipo";
            this.gridControlAnticipo.Size = new System.Drawing.Size(783, 169);
            this.gridControlAnticipo.TabIndex = 9;
            this.gridControlAnticipo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAnticipo});
            // 
            // cxccobroxAnticipoInfoBindingSource
            // 
            this.cxccobroxAnticipoInfoBindingSource.DataSource = typeof(Bizu.Domain.CuentasxCobrar.cxc_cobro_x_Anticipo_Info);
            // 
            // gridViewAnticipo
            // 
            this.gridViewAnticipo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NC,
            this.Tipo,
            this.Fecha,
            this.tc_TipoCbte,
            this.Beneficiario,
            this.Referencia,
            this.Valor_cbte,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.valor_cancelado});
            this.gridViewAnticipo.GridControl = this.gridControlAnticipo;
            this.gridViewAnticipo.Name = "gridViewAnticipo";
            this.gridViewAnticipo.OptionsBehavior.Editable = false;
            this.gridViewAnticipo.OptionsView.ShowAutoFilterRow = true;
            this.gridViewAnticipo.OptionsView.ShowGroupPanel = false;
            this.gridViewAnticipo.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewAnticipo_RowCellStyle);
            this.gridViewAnticipo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewAnticipo_FocusedRowChanged);
            // 
            // NC
            // 
            this.NC.Caption = "Id #";
            this.NC.FieldName = "IdOrdenPago";
            this.NC.Name = "NC";
            this.NC.Visible = true;
            this.NC.VisibleIndex = 0;
            this.NC.Width = 70;
            // 
            // Tipo
            // 
            this.Tipo.Caption = "Tipo";
            this.Tipo.FieldName = "IdTipo_op";
            this.Tipo.Name = "Tipo";
            this.Tipo.Visible = true;
            this.Tipo.VisibleIndex = 1;
            this.Tipo.Width = 90;
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.FieldName = "Fecha_Pago";
            this.Fecha.Name = "Fecha";
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 2;
            this.Fecha.Width = 76;
            // 
            // tc_TipoCbte
            // 
            this.tc_TipoCbte.Caption = "TipobCbte";
            this.tc_TipoCbte.FieldName = "tc_TipoCbte";
            this.tc_TipoCbte.Name = "tc_TipoCbte";
            this.tc_TipoCbte.Width = 55;
            // 
            // Beneficiario
            // 
            this.Beneficiario.Caption = "Beneficiario";
            this.Beneficiario.FieldName = "pr_nombre";
            this.Beneficiario.Name = "Beneficiario";
            this.Beneficiario.Visible = true;
            this.Beneficiario.VisibleIndex = 3;
            this.Beneficiario.Width = 263;
            // 
            // Referencia
            // 
            this.Referencia.Caption = "Referencia";
            this.Referencia.FieldName = "Observacion";
            this.Referencia.Name = "Referencia";
            this.Referencia.Visible = true;
            this.Referencia.VisibleIndex = 4;
            this.Referencia.Width = 189;
            // 
            // Valor_cbte
            // 
            this.Valor_cbte.Caption = "Valor OP";
            this.Valor_cbte.FieldName = "Valor_a_pagar";
            this.Valor_cbte.Name = "Valor_cbte";
            this.Valor_cbte.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Valor_cbte.Visible = true;
            this.Valor_cbte.VisibleIndex = 5;
            this.Valor_cbte.Width = 70;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Estado";
            this.gridColumn1.FieldName = "Estado";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 50;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Id Factura";
            this.gridColumn2.FieldName = "IdCbteCble_cxp";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            this.gridColumn2.Width = 83;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "# Documento";
            this.gridColumn3.FieldName = "Factura";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 8;
            this.gridColumn3.Width = 137;
            // 
            // valor_cancelado
            // 
            this.valor_cancelado.Caption = "valor Aplicado Factura";
            this.valor_cancelado.FieldName = "Total_Pagado_Fact";
            this.valor_cancelado.Name = "valor_cancelado";
            this.valor_cancelado.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.valor_cancelado.Visible = true;
            this.valor_cancelado.VisibleIndex = 9;
            this.valor_cancelado.Width = 128;
            // 
            // cxccobroInfoBindingSource
            // 
            this.cxccobroInfoBindingSource.DataSource = typeof(Bizu.Domain.CuentasxCobrar.cxc_cobro_Info);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 299);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(783, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 130);
            this.panel1.TabIndex = 11;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasSucursales = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Importar_XML = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2023, 12, 13, 12, 37, 33, 40);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2024, 2, 13, 12, 37, 33, 40);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(783, 129);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnNotificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnRevision = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_FormaPago = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Load += new System.EventHandler(this.ucGe_Menu_Mantenimiento_x_usuario_Load);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlAnticipo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 169);
            this.panel2.TabIndex = 12;
            // 
            // frmCP_anticipo_Proveedores_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 321);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmCP_anticipo_Proveedores_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Anticipo de Clientes";
            this.Load += new System.EventHandler(this.frmcp_anticipo_clientes_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAnticipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobroxAnticipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAnticipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobroInfoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlAnticipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAnticipo;
        private System.Windows.Forms.BindingSource cxccobroInfoBindingSource;
        private System.Windows.Forms.BindingSource cxccobroxAnticipoInfoBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn NC;
        private DevExpress.XtraGrid.Columns.GridColumn Tipo;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn tc_TipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn Beneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn Referencia;
        private DevExpress.XtraGrid.Columns.GridColumn Valor_cbte;
        private DevExpress.XtraGrid.Columns.GridColumn valor_cancelado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}