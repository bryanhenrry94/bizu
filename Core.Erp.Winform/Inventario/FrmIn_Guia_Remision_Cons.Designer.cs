namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Guia_Remision_Cons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIn_Guia_Remision_Cons));
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ultrGuiaRemision1 = new DevExpress.XtraGrid.GridControl();
            this.gridViewGuiaRemision = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdGuiaRemision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_FechaEmision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_FechaTrasladoIni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_FechaTrasladoFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NumDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_CentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Origen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Destino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NumAutorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_FechaAutorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Transportista = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Placa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pdf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.col_xml = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nom_bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Proyecto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ultrGuiaRemision1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGuiaRemision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasSucursales = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2023, 12, 13, 13, 13, 44, 155);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2024, 2, 13, 13, 13, 44, 158);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1094, 194);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 6;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnNotificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnRevision = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
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
            // 
            // ultrGuiaRemision1
            // 
            this.ultrGuiaRemision1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultrGuiaRemision1.Location = new System.Drawing.Point(0, 0);
            this.ultrGuiaRemision1.MainView = this.gridViewGuiaRemision;
            this.ultrGuiaRemision1.Name = "ultrGuiaRemision1";
            this.ultrGuiaRemision1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.ultrGuiaRemision1.Size = new System.Drawing.Size(1094, 258);
            this.ultrGuiaRemision1.TabIndex = 1;
            this.ultrGuiaRemision1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGuiaRemision});
            // 
            // gridViewGuiaRemision
            // 
            this.gridViewGuiaRemision.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Sucursal,
            this.col_IdGuiaRemision,
            this.col_IdCliente,
            this.col_Cliente,
            this.col_Observacion,
            this.col_FechaEmision,
            this.col_FechaTrasladoIni,
            this.col_FechaTrasladoFin,
            this.col_NumDocumento,
            this.col_CentroCosto,
            this.col_Origen,
            this.col_Destino,
            this.col_NumAutorizacion,
            this.col_FechaAutorizacion,
            this.col_Transportista,
            this.col_Placa,
            this.col_Estado,
            this.col_pdf,
            this.col_xml,
            this.col_IdBodega,
            this.col_nom_bodega,
            this.col_Proyecto});
            this.gridViewGuiaRemision.GridControl = this.ultrGuiaRemision1;
            this.gridViewGuiaRemision.Name = "gridViewGuiaRemision";
            this.gridViewGuiaRemision.OptionsBehavior.Editable = false;
            this.gridViewGuiaRemision.OptionsView.ShowAutoFilterRow = true;
            this.gridViewGuiaRemision.OptionsView.ShowGroupPanel = false;
            this.gridViewGuiaRemision.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewGuiaRemision_RowClick);
            this.gridViewGuiaRemision.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewGuiaRemision_RowCellClick);
            this.gridViewGuiaRemision.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewGuiaRemision_RowCellStyle);
            // 
            // col_Sucursal
            // 
            this.col_Sucursal.Caption = "Sucursal";
            this.col_Sucursal.FieldName = "Su_Descripcion";
            this.col_Sucursal.Name = "col_Sucursal";
            this.col_Sucursal.OptionsColumn.AllowEdit = false;
            this.col_Sucursal.Visible = true;
            this.col_Sucursal.VisibleIndex = 0;
            this.col_Sucursal.Width = 69;
            // 
            // col_IdGuiaRemision
            // 
            this.col_IdGuiaRemision.Caption = "Id Guia Remision";
            this.col_IdGuiaRemision.FieldName = "IdGuiaRemision";
            this.col_IdGuiaRemision.Name = "col_IdGuiaRemision";
            this.col_IdGuiaRemision.OptionsColumn.AllowEdit = false;
            this.col_IdGuiaRemision.Visible = true;
            this.col_IdGuiaRemision.VisibleIndex = 2;
            this.col_IdGuiaRemision.Width = 65;
            // 
            // col_IdCliente
            // 
            this.col_IdCliente.Caption = "IdCliente";
            this.col_IdCliente.FieldName = "IdCliente";
            this.col_IdCliente.Name = "col_IdCliente";
            this.col_IdCliente.OptionsColumn.AllowEdit = false;
            this.col_IdCliente.Width = 69;
            // 
            // col_Cliente
            // 
            this.col_Cliente.Caption = "Cliente";
            this.col_Cliente.FieldName = "pe_nombreCompleto";
            this.col_Cliente.Name = "col_Cliente";
            this.col_Cliente.OptionsColumn.AllowEdit = false;
            this.col_Cliente.Width = 150;
            // 
            // col_Observacion
            // 
            this.col_Observacion.Caption = "Observacion";
            this.col_Observacion.FieldName = "Observacion";
            this.col_Observacion.Name = "col_Observacion";
            this.col_Observacion.OptionsColumn.AllowEdit = false;
            this.col_Observacion.Visible = true;
            this.col_Observacion.VisibleIndex = 3;
            this.col_Observacion.Width = 59;
            // 
            // col_FechaEmision
            // 
            this.col_FechaEmision.Caption = "Fecha Emision";
            this.col_FechaEmision.FieldName = "FechaEmision";
            this.col_FechaEmision.Name = "col_FechaEmision";
            this.col_FechaEmision.OptionsColumn.AllowEdit = false;
            this.col_FechaEmision.Visible = true;
            this.col_FechaEmision.VisibleIndex = 4;
            this.col_FechaEmision.Width = 65;
            // 
            // col_FechaTrasladoIni
            // 
            this.col_FechaTrasladoIni.Caption = "Fecha Inicio Traslado";
            this.col_FechaTrasladoIni.FieldName = "FechaTrasladoIni";
            this.col_FechaTrasladoIni.Name = "col_FechaTrasladoIni";
            this.col_FechaTrasladoIni.OptionsColumn.AllowEdit = false;
            this.col_FechaTrasladoIni.Width = 68;
            // 
            // col_FechaTrasladoFin
            // 
            this.col_FechaTrasladoFin.Caption = "Fecha Fin Traslado";
            this.col_FechaTrasladoFin.FieldName = "FechaTrasladoFin";
            this.col_FechaTrasladoFin.Name = "col_FechaTrasladoFin";
            this.col_FechaTrasladoFin.OptionsColumn.AllowEdit = false;
            this.col_FechaTrasladoFin.Width = 61;
            // 
            // col_NumDocumento
            // 
            this.col_NumDocumento.Caption = "# Documento";
            this.col_NumDocumento.FieldName = "NumDocumento";
            this.col_NumDocumento.Name = "col_NumDocumento";
            this.col_NumDocumento.OptionsColumn.AllowEdit = false;
            this.col_NumDocumento.Visible = true;
            this.col_NumDocumento.VisibleIndex = 5;
            this.col_NumDocumento.Width = 81;
            // 
            // col_CentroCosto
            // 
            this.col_CentroCosto.Caption = "Centro Costo";
            this.col_CentroCosto.FieldName = "Centro_costo";
            this.col_CentroCosto.Name = "col_CentroCosto";
            this.col_CentroCosto.OptionsColumn.AllowEdit = false;
            this.col_CentroCosto.Visible = true;
            this.col_CentroCosto.VisibleIndex = 7;
            this.col_CentroCosto.Width = 96;
            // 
            // col_Origen
            // 
            this.col_Origen.Caption = "Origen";
            this.col_Origen.FieldName = "Origen";
            this.col_Origen.Name = "col_Origen";
            this.col_Origen.OptionsColumn.AllowEdit = false;
            this.col_Origen.Width = 45;
            // 
            // col_Destino
            // 
            this.col_Destino.Caption = "Destino";
            this.col_Destino.FieldName = "Destino";
            this.col_Destino.Name = "col_Destino";
            this.col_Destino.OptionsColumn.AllowEdit = false;
            this.col_Destino.Width = 45;
            // 
            // col_NumAutorizacion
            // 
            this.col_NumAutorizacion.Caption = "Autorizacion";
            this.col_NumAutorizacion.FieldName = "NumAutorizacion";
            this.col_NumAutorizacion.Name = "col_NumAutorizacion";
            this.col_NumAutorizacion.OptionsColumn.AllowEdit = false;
            this.col_NumAutorizacion.Visible = true;
            this.col_NumAutorizacion.VisibleIndex = 10;
            this.col_NumAutorizacion.Width = 35;
            // 
            // col_FechaAutorizacion
            // 
            this.col_FechaAutorizacion.Caption = "Fecha Autorizacion";
            this.col_FechaAutorizacion.FieldName = "FechaAutorizacion";
            this.col_FechaAutorizacion.Name = "col_FechaAutorizacion";
            this.col_FechaAutorizacion.OptionsColumn.AllowEdit = false;
            this.col_FechaAutorizacion.Visible = true;
            this.col_FechaAutorizacion.VisibleIndex = 9;
            this.col_FechaAutorizacion.Width = 42;
            // 
            // col_Transportista
            // 
            this.col_Transportista.Caption = "Transportista";
            this.col_Transportista.FieldName = "NombreTransportista";
            this.col_Transportista.Name = "col_Transportista";
            this.col_Transportista.OptionsColumn.AllowEdit = false;
            this.col_Transportista.Width = 45;
            // 
            // col_Placa
            // 
            this.col_Placa.Caption = "Placa";
            this.col_Placa.FieldName = "Placa";
            this.col_Placa.Name = "col_Placa";
            this.col_Placa.OptionsColumn.AllowEdit = false;
            this.col_Placa.Visible = true;
            this.col_Placa.VisibleIndex = 8;
            this.col_Placa.Width = 49;
            // 
            // col_Estado
            // 
            this.col_Estado.Caption = "Estado";
            this.col_Estado.FieldName = "Estado";
            this.col_Estado.Name = "col_Estado";
            this.col_Estado.OptionsColumn.AllowEdit = false;
            this.col_Estado.Visible = true;
            this.col_Estado.VisibleIndex = 11;
            this.col_Estado.Width = 26;
            // 
            // col_pdf
            // 
            this.col_pdf.Caption = "pdf";
            this.col_pdf.ColumnEdit = this.repositoryItemPictureEdit1;
            this.col_pdf.FieldName = "Icono_pdf";
            this.col_pdf.Name = "col_pdf";
            this.col_pdf.OptionsColumn.AllowEdit = false;
            this.col_pdf.Visible = true;
            this.col_pdf.VisibleIndex = 12;
            this.col_pdf.Width = 64;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // col_xml
            // 
            this.col_xml.Caption = "xml";
            this.col_xml.ColumnEdit = this.repositoryItemPictureEdit1;
            this.col_xml.FieldName = "Icono_xml";
            this.col_xml.Name = "col_xml";
            this.col_xml.OptionsColumn.AllowEdit = false;
            this.col_xml.Visible = true;
            this.col_xml.VisibleIndex = 13;
            this.col_xml.Width = 69;
            // 
            // col_IdBodega
            // 
            this.col_IdBodega.Caption = "IdBodega";
            this.col_IdBodega.FieldName = "IdBodega";
            this.col_IdBodega.Name = "col_IdBodega";
            // 
            // col_nom_bodega
            // 
            this.col_nom_bodega.Caption = "Bodega";
            this.col_nom_bodega.FieldName = "nom_bodega";
            this.col_nom_bodega.Name = "col_nom_bodega";
            this.col_nom_bodega.Visible = true;
            this.col_nom_bodega.VisibleIndex = 1;
            this.col_nom_bodega.Width = 123;
            // 
            // col_Proyecto
            // 
            this.col_Proyecto.Caption = "Proyecto";
            this.col_Proyecto.FieldName = "NomProyecto";
            this.col_Proyecto.Name = "col_Proyecto";
            this.col_Proyecto.Visible = true;
            this.col_Proyecto.VisibleIndex = 6;
            this.col_Proyecto.Width = 183;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 452);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1094, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 194);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ultrGuiaRemision1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1094, 258);
            this.panel2.TabIndex = 12;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "exporttopdf_32x32.png");
            this.imageCollection1.Images.SetKeyName(1, "exporttoxml_32x32.png");
            // 
            // FrmIn_Guia_Remision_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmIn_Guia_Remision_Cons";
            this.Text = "Guia Remision";
            this.Load += new System.EventHandler(this.frmFA_Guia_Remision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultrGuiaRemision1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGuiaRemision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraGrid.GridControl ultrGuiaRemision1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGuiaRemision;
        private DevExpress.XtraGrid.Columns.GridColumn col_Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn col_Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn col_FechaEmision;
        private DevExpress.XtraGrid.Columns.GridColumn col_NumDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn col_CentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn col_Sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdGuiaRemision;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn col_FechaTrasladoIni;
        private DevExpress.XtraGrid.Columns.GridColumn col_FechaTrasladoFin;
        private DevExpress.XtraGrid.Columns.GridColumn col_Origen;
        private DevExpress.XtraGrid.Columns.GridColumn col_Destino;
        private DevExpress.XtraGrid.Columns.GridColumn col_NumAutorizacion;
        private DevExpress.XtraGrid.Columns.GridColumn col_FechaAutorizacion;
        private DevExpress.XtraGrid.Columns.GridColumn col_Transportista;
        private DevExpress.XtraGrid.Columns.GridColumn col_Placa;
        private DevExpress.XtraGrid.Columns.GridColumn col_Estado;
        private DevExpress.XtraGrid.Columns.GridColumn col_pdf;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn col_xml;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn col_nom_bodega;
        private DevExpress.XtraGrid.Columns.GridColumn col_Proyecto;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}