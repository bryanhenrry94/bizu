namespace Bizu.Presentation.CuentasxPagar
{
    partial class frmCP_ProveedorConsulta
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
            this.gridControlProveedor = new DevExpress.XtraGrid.GridControl();
            this.UltraGridProveedor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNomProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColGirar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdCtaCble_cxp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCedulaRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorreoPrincipal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_telefonoOfic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTelefonoCasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefonoContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCelular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTipoDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColRazon_Social = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoContribuyente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegimen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContribuyenteEspecial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGranContribyente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Bizu.Presentation.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colCorreoSecundario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorreoAlterno = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGridProveedor)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlProveedor
            // 
            this.gridControlProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProveedor.Location = new System.Drawing.Point(0, 0);
            this.gridControlProveedor.MainView = this.UltraGridProveedor;
            this.gridControlProveedor.Name = "gridControlProveedor";
            this.gridControlProveedor.Size = new System.Drawing.Size(1129, 330);
            this.gridControlProveedor.TabIndex = 15;
            this.gridControlProveedor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UltraGridProveedor});
            // 
            // UltraGridProveedor
            // 
            this.UltraGridProveedor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdProveedor,
            this.ColNomProveedor,
            this.ColGirar,
            this.ColIdCtaCble_cxp,
            this.ColCedulaRuc,
            this.colEstado,
            this.ColDireccion,
            this.colpe_telefonoOfic,
            this.ColTelefonoCasa,
            this.colTelefonoContacto,
            this.ColCodigo,
            this.ColCelular,
            this.ColTipoDoc,
            this.ColRazon_Social,
            this.colTipoContribuyente,
            this.colRegimen,
            this.colContribuyenteEspecial,
            this.colGranContribyente,
            this.colCorreoPrincipal,
            this.colCorreoSecundario,
            this.colCorreoAlterno});
            this.UltraGridProveedor.CustomizationFormBounds = new System.Drawing.Rectangle(519, 397, 216, 178);
            this.UltraGridProveedor.GridControl = this.gridControlProveedor;
            this.UltraGridProveedor.Name = "UltraGridProveedor";
            this.UltraGridProveedor.OptionsView.ColumnAutoWidth = false;
            this.UltraGridProveedor.OptionsView.ShowAutoFilterRow = true;
            this.UltraGridProveedor.OptionsView.ShowGroupPanel = false;
            this.UltraGridProveedor.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.UltraGridProveedor_RowCellStyle);
            this.UltraGridProveedor.DoubleClick += new System.EventHandler(this.UltraGridProveedor_DoubleClick);
            // 
            // ColIdProveedor
            // 
            this.ColIdProveedor.Caption = "IdProveedor";
            this.ColIdProveedor.FieldName = "IdProveedor";
            this.ColIdProveedor.Name = "ColIdProveedor";
            this.ColIdProveedor.OptionsColumn.AllowEdit = false;
            this.ColIdProveedor.OptionsColumn.ReadOnly = true;
            this.ColIdProveedor.Visible = true;
            this.ColIdProveedor.VisibleIndex = 0;
            this.ColIdProveedor.Width = 73;
            // 
            // ColNomProveedor
            // 
            this.ColNomProveedor.Caption = "Nombre";
            this.ColNomProveedor.FieldName = "pr_nombre";
            this.ColNomProveedor.Name = "ColNomProveedor";
            this.ColNomProveedor.OptionsColumn.AllowEdit = false;
            this.ColNomProveedor.OptionsColumn.ReadOnly = true;
            this.ColNomProveedor.Visible = true;
            this.ColNomProveedor.VisibleIndex = 1;
            this.ColNomProveedor.Width = 273;
            // 
            // ColGirar
            // 
            this.ColGirar.Caption = "Gira Cheque";
            this.ColGirar.FieldName = "pr_girar_cheque_a";
            this.ColGirar.Name = "ColGirar";
            this.ColGirar.OptionsColumn.AllowEdit = false;
            this.ColGirar.OptionsColumn.ReadOnly = true;
            this.ColGirar.Width = 119;
            // 
            // ColIdCtaCble_cxp
            // 
            this.ColIdCtaCble_cxp.Caption = "IdCtaCble_CXP";
            this.ColIdCtaCble_cxp.FieldName = "IdCtaCble_CXP";
            this.ColIdCtaCble_cxp.Name = "ColIdCtaCble_cxp";
            this.ColIdCtaCble_cxp.OptionsColumn.AllowEdit = false;
            this.ColIdCtaCble_cxp.OptionsColumn.ReadOnly = true;
            this.ColIdCtaCble_cxp.Width = 90;
            // 
            // ColCedulaRuc
            // 
            this.ColCedulaRuc.Caption = "Cedula/Ruc";
            this.ColCedulaRuc.FieldName = "Persona_Info.pe_cedulaRuc";
            this.ColCedulaRuc.Name = "ColCedulaRuc";
            this.ColCedulaRuc.OptionsColumn.ReadOnly = true;
            this.ColCedulaRuc.Visible = true;
            this.ColCedulaRuc.VisibleIndex = 4;
            this.ColCedulaRuc.Width = 85;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "pr_estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.OptionsColumn.ReadOnly = true;
            this.colEstado.Width = 50;
            // 
            // ColDireccion
            // 
            this.ColDireccion.Caption = "Direccion";
            this.ColDireccion.FieldName = "Persona_Info.pe_direccion";
            this.ColDireccion.Name = "ColDireccion";
            this.ColDireccion.OptionsColumn.ReadOnly = true;
            this.ColDireccion.Visible = true;
            this.ColDireccion.VisibleIndex = 5;
            this.ColDireccion.Width = 99;
            // 
            // colCorreoPrincipal
            // 
            this.colCorreoPrincipal.Caption = "Correo Principal";
            this.colCorreoPrincipal.FieldName = "CorreoPrincipal";
            this.colCorreoPrincipal.Name = "colCorreoPrincipal";
            this.colCorreoPrincipal.OptionsColumn.ReadOnly = true;
            this.colCorreoPrincipal.Visible = true;
            this.colCorreoPrincipal.VisibleIndex = 6;
            this.colCorreoPrincipal.Width = 93;
            // 
            // colpe_telefonoOfic
            // 
            this.colpe_telefonoOfic.Caption = "Telf. Oficina";
            this.colpe_telefonoOfic.FieldName = "Persona_Info.pe_telefonoOfic";
            this.colpe_telefonoOfic.Name = "colpe_telefonoOfic";
            this.colpe_telefonoOfic.OptionsColumn.ReadOnly = true;
            this.colpe_telefonoOfic.Visible = true;
            this.colpe_telefonoOfic.VisibleIndex = 7;
            this.colpe_telefonoOfic.Width = 101;
            // 
            // ColTelefonoCasa
            // 
            this.ColTelefonoCasa.Caption = "Telf. Casa";
            this.ColTelefonoCasa.FieldName = "Persona_Info.pe_telefonoCasa";
            this.ColTelefonoCasa.Name = "ColTelefonoCasa";
            this.ColTelefonoCasa.OptionsColumn.ReadOnly = true;
            this.ColTelefonoCasa.Visible = true;
            this.ColTelefonoCasa.VisibleIndex = 9;
            this.ColTelefonoCasa.Width = 66;
            // 
            // colTelefonoContacto
            // 
            this.colTelefonoContacto.Caption = "Tel.Contacto";
            this.colTelefonoContacto.FieldName = "Persona_Info.pe_telfono_Contacto";
            this.colTelefonoContacto.Name = "colTelefonoContacto";
            this.colTelefonoContacto.OptionsColumn.ReadOnly = true;
            this.colTelefonoContacto.Visible = true;
            this.colTelefonoContacto.VisibleIndex = 8;
            this.colTelefonoContacto.Width = 113;
            // 
            // ColCodigo
            // 
            this.ColCodigo.Caption = "Codigo";
            this.ColCodigo.FieldName = "pr_codigo";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.OptionsColumn.ReadOnly = true;
            this.ColCodigo.Width = 82;
            // 
            // ColCelular
            // 
            this.ColCelular.Caption = "Celular";
            this.ColCelular.FieldName = "Persona_Info.pe_celular";
            this.ColCelular.Name = "ColCelular";
            this.ColCelular.OptionsColumn.ReadOnly = true;
            this.ColCelular.Visible = true;
            this.ColCelular.VisibleIndex = 10;
            this.ColCelular.Width = 83;
            // 
            // ColTipoDoc
            // 
            this.ColTipoDoc.Caption = "Tipo Doc.";
            this.ColTipoDoc.FieldName = "Persona_Info.IdTipoDocumento";
            this.ColTipoDoc.Name = "ColTipoDoc";
            this.ColTipoDoc.OptionsColumn.ReadOnly = true;
            this.ColTipoDoc.Visible = true;
            this.ColTipoDoc.VisibleIndex = 3;
            this.ColTipoDoc.Width = 88;
            // 
            // ColRazon_Social
            // 
            this.ColRazon_Social.Caption = "Razon/Social";
            this.ColRazon_Social.FieldName = "Persona_Info.pe_razonSocial";
            this.ColRazon_Social.Name = "ColRazon_Social";
            this.ColRazon_Social.OptionsColumn.ReadOnly = true;
            this.ColRazon_Social.Visible = true;
            this.ColRazon_Social.VisibleIndex = 2;
            this.ColRazon_Social.Width = 245;
            // 
            // colTipoContribuyente
            // 
            this.colTipoContribuyente.Caption = "Tipo Contribuyente";
            this.colTipoContribuyente.FieldName = "nomNaturaleza";
            this.colTipoContribuyente.Name = "colTipoContribuyente";
            this.colTipoContribuyente.OptionsColumn.ReadOnly = true;
            this.colTipoContribuyente.Visible = true;
            this.colTipoContribuyente.VisibleIndex = 11;
            this.colTipoContribuyente.Width = 106;
            // 
            // colRegimen
            // 
            this.colRegimen.Caption = "Regimen";
            this.colRegimen.FieldName = "nomRegimen";
            this.colRegimen.Name = "colRegimen";
            this.colRegimen.OptionsColumn.ReadOnly = true;
            this.colRegimen.Visible = true;
            this.colRegimen.VisibleIndex = 12;
            this.colRegimen.Width = 96;
            // 
            // colContribuyenteEspecial
            // 
            this.colContribuyenteEspecial.Caption = "Contribyente Especial ";
            this.colContribuyenteEspecial.FieldName = "pr_contribuyenteEspecial";
            this.colContribuyenteEspecial.Name = "colContribuyenteEspecial";
            this.colContribuyenteEspecial.OptionsColumn.ReadOnly = true;
            this.colContribuyenteEspecial.Visible = true;
            this.colContribuyenteEspecial.VisibleIndex = 13;
            this.colContribuyenteEspecial.Width = 103;
            // 
            // colGranContribyente
            // 
            this.colGranContribyente.Caption = "Gran Contribyente";
            this.colGranContribyente.FieldName = "pr_GranContribuyente";
            this.colGranContribyente.Name = "colGranContribyente";
            this.colGranContribyente.OptionsColumn.ReadOnly = true;
            this.colGranContribyente.Visible = true;
            this.colGranContribyente.VisibleIndex = 14;
            this.colGranContribyente.Width = 100;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1129, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 188);
            this.panel1.TabIndex = 17;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2024, 8, 1, 0, 0, 0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2024, 8, 26, 20, 24, 50, 326);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1129, 186);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnNotificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnRevision = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_FormaPago = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += new Bizu.Presentation.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            this.ucGe_Menu_Mantenimiento_x_usuario.Load += new System.EventHandler(this.ucGe_Menu_Mantenimiento_x_usuario_Load);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlProveedor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1129, 330);
            this.panel2.TabIndex = 18;
            // 
            // colCorreoSecundario
            // 
            this.colCorreoSecundario.Caption = "Correo Secundario";
            this.colCorreoSecundario.FieldName = "CorreoSecundario";
            this.colCorreoSecundario.Name = "colCorreoSecundario";
            this.colCorreoSecundario.Visible = true;
            this.colCorreoSecundario.VisibleIndex = 15;
            // 
            // colCorreoAlterno
            // 
            this.colCorreoAlterno.Caption = "Correo Alterno";
            this.colCorreoAlterno.FieldName = "CorreoAlterno";
            this.colCorreoAlterno.Name = "colCorreoAlterno";
            this.colCorreoAlterno.Visible = true;
            this.colCorreoAlterno.VisibleIndex = 16;
            // 
            // frmCP_ProveedorConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmCP_ProveedorConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Proveedor";
            this.Load += new System.EventHandler(this.frmCP_ProveedorConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGridProveedor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView UltraGridProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn ColNomProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn ColGirar;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdCtaCble_cxp;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn ColCedulaRuc;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn ColDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colCorreoPrincipal;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_telefonoOfic;
        private DevExpress.XtraGrid.Columns.GridColumn ColCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn ColTelefonoCasa;
        private DevExpress.XtraGrid.Columns.GridColumn ColCelular;
        private DevExpress.XtraGrid.Columns.GridColumn ColTipoDoc;
        private DevExpress.XtraGrid.Columns.GridColumn ColRazon_Social;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonoContacto;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoContribuyente;
        private DevExpress.XtraGrid.Columns.GridColumn colRegimen;
        private DevExpress.XtraGrid.Columns.GridColumn colGranContribyente;
        private DevExpress.XtraGrid.Columns.GridColumn colContribuyenteEspecial;
        private DevExpress.XtraGrid.Columns.GridColumn colCorreoSecundario;
        private DevExpress.XtraGrid.Columns.GridColumn colCorreoAlterno;
    }
}