using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dazzsoft.ERP.Infrastructure.Model.Inventario;

namespace Dazzsoft.ERP.Infrastructure.Persistence
{
    public class InventarioContext : DbContext
    {
        public InventarioContext() : base("name=DefaultConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Esta línea evita que use el esquema dbo
            modelBuilder.HasDefaultSchema("public"); // Usa "public", o cambia según el esquema real

            base.OnModelCreating(modelBuilder);
        }

        public void SetCommandTimeOut(int TimeOut)
        {
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = TimeOut;
        }

        public DbSet<in_ajusteFisico> in_ajusteFisico { get; set; }
        public DbSet<in_AjusteFisico_Detalle> in_AjusteFisico_Detalle { get; set; }
        public DbSet<in_Catalogo> in_Catalogo { get; set; }
        public DbSet<in_CatalogoTipo> in_CatalogoTipo { get; set; }
        public DbSet<in_Categoria_x_Formula> in_Categoria_x_Formula { get; set; }
        public DbSet<in_categorias> in_categorias { get; set; }
        public DbSet<in_devolucion_inven> in_devolucion_inven { get; set; }
        public DbSet<in_devolucion_inven_det> in_devolucion_inven_det { get; set; }
        public DbSet<in_egreso_d_Suministro> in_egreso_d_Suministro { get; set; }
        public DbSet<in_grupo> in_grupo { get; set; }
        public DbSet<in_Guia_x_traspaso_bodega> in_Guia_x_traspaso_bodega { get; set; }
        public DbSet<in_Guia_x_traspaso_bodega_det> in_Guia_x_traspaso_bodega_det { get; set; }
        public DbSet<in_Guia_x_traspaso_bodega_det_sin_oc> in_Guia_x_traspaso_bodega_det_sin_oc { get; set; }
        public DbSet<in_Guia_x_traspaso_bodega_x_in_transferencia_det> in_Guia_x_traspaso_bodega_x_in_transferencia_det { get; set; }
        public DbSet<in_GuiaRemision> in_GuiaRemision { get; set; }
        public DbSet<in_GuiaRemision_Det> in_GuiaRemision_Det { get; set; }
        public DbSet<in_GuiaRemision_Exportacion> in_GuiaRemision_Exportacion { get; set; }
        public DbSet<in_GuiaRemision_Motivo> in_GuiaRemision_Motivo { get; set; }
        public DbSet<in_Ing_Egr_Inven> in_Ing_Egr_Inven { get; set; }
        public DbSet<in_Ing_Egr_Inven_det> in_Ing_Egr_Inven_det { get; set; }
        public DbSet<in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det> in_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det { get; set; }
        public DbSet<in_Ing_Egr_Inven_estado_apro> in_Ing_Egr_Inven_estado_apro { get; set; }
        public DbSet<in_Ing_Egr_Inven_x_in_GuiaRemision> in_Ing_Egr_Inven_x_in_GuiaRemision { get; set; }
        public DbSet<in_Ing_Egr_Inven_x_in_RequerimientoMaterial> in_Ing_Egr_Inven_x_in_RequerimientoMaterial { get; set; }
        public DbSet<in_kardex> in_kardex { get; set; }
        public DbSet<in_kardex_det> in_kardex_det { get; set; }
        public DbSet<in_linea> in_linea { get; set; }
        public DbSet<in_Marca> in_Marca { get; set; }
        public DbSet<in_Marca_filtro> in_Marca_filtro { get; set; }
        public DbSet<in_Motivo_Inven> in_Motivo_Inven { get; set; }
        public DbSet<in_movi_inve> in_movi_inve { get; set; }
        public DbSet<in_movi_inve_detalle> in_movi_inve_detalle { get; set; }
        public DbSet<in_movi_inve_detalle_x_com_ordencompra_local_det> in_movi_inve_detalle_x_com_ordencompra_local_det { get; set; }
        public DbSet<in_movi_inve_detalle_x_ct_cbtecble_det> in_movi_inve_detalle_x_ct_cbtecble_det { get; set; }
        public DbSet<in_movi_inve_detalle_x_item> in_movi_inve_detalle_x_item { get; set; }
        public DbSet<in_movi_inve_x_ct_cbteCble> in_movi_inve_x_ct_cbteCble { get; set; }
        public DbSet<in_movi_inve_x_in_ordencompra_local> in_movi_inve_x_in_ordencompra_local { get; set; }
        public DbSet<in_movi_inven_para_recosteo_ct_CbteCble> in_movi_inven_para_recosteo_ct_CbteCble { get; set; }
        public DbSet<in_movi_inven_tipo> in_movi_inven_tipo { get; set; }
        public DbSet<in_movi_inven_tipo_x_tb_bodega> in_movi_inven_tipo_x_tb_bodega { get; set; }
        public DbSet<in_movi_inven_X_imp_OrdCompraExterna> in_movi_inven_X_imp_OrdCompraExterna { get; set; }
        public DbSet<in_parametro> in_parametro { get; set; }
        public DbSet<in_parametro_Impuesto_Iva_Ice> in_parametro_Impuesto_Iva_Ice { get; set; }
        public DbSet<in_PrecargaItemsOrdenCompra> in_PrecargaItemsOrdenCompra { get; set; }
        public DbSet<in_PrecargaItemsOrdenCompra_det> in_PrecargaItemsOrdenCompra_det { get; set; }
        public DbSet<in_presentacion> in_presentacion { get; set; }
        public DbSet<in_presupuesto> in_presupuesto { get; set; }
        public DbSet<in_presupuesto_det> in_presupuesto_det { get; set; }
        public DbSet<in_Producto> in_Producto { get; set; }
        public DbSet<in_Producto_Composicion> in_Producto_Composicion { get; set; }
        public DbSet<in_Producto_Dimensiones> in_Producto_Dimensiones { get; set; }
        public DbSet<in_producto_precio_historico> in_producto_precio_historico { get; set; }
        public DbSet<in_producto_x_cp_proveedor> in_producto_x_cp_proveedor { get; set; }
        public DbSet<in_producto_x_in_producto> in_producto_x_in_producto { get; set; }
        public DbSet<in_producto_x_tb_bodega> in_producto_x_tb_bodega { get; set; }
        public DbSet<in_producto_x_tb_bodega_Costo_Historico> in_producto_x_tb_bodega_Costo_Historico { get; set; }
        public DbSet<in_ProductoTipo> in_ProductoTipo { get; set; }
        public DbSet<in_Recosteo_Productos_x_movi_inve_detalle> in_Recosteo_Productos_x_movi_inve_detalle { get; set; }
        public DbSet<in_responsable> in_responsable { get; set; }
        public DbSet<in_rptDispInve> in_rptDispInve { get; set; }
        public DbSet<in_rptMovi_Inv_x_prod_resumido> in_rptMovi_Inv_x_prod_resumido { get; set; }
        public DbSet<in_spSys_inv_Reversar_aprobacion_ct_cbtecble> in_spSys_inv_Reversar_aprobacion_ct_cbtecble { get; set; }
        public DbSet<in_spSys_inv_Reversar_aprobacion_in_movi_inven> in_spSys_inv_Reversar_aprobacion_in_movi_inven { get; set; }
        public DbSet<in_subgrupo> in_subgrupo { get; set; }
        public DbSet<in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble> in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble { get; set; }
        public DbSet<in_transferencia> in_transferencia { get; set; }
        public DbSet<in_transferencia_det> in_transferencia_det { get; set; }
        public DbSet<in_transferencia_det_x_in_Guia_x_traspaso_bodega_det> in_transferencia_det_x_in_Guia_x_traspaso_bodega_det { get; set; }
        public DbSet<in_transferencia_x_fa_guia_remision> in_transferencia_x_fa_guia_remision { get; set; }
        public DbSet<in_transferencia_x_in_Guia_x_traspaso_bodega> in_transferencia_x_in_Guia_x_traspaso_bodega { get; set; }
        public DbSet<in_UnidadMedida> in_UnidadMedida { get; set; }
        public DbSet<in_UnidadMedida_Equiv_conversion> in_UnidadMedida_Equiv_conversion { get; set; }
        public DbSet<in_Zona> in_Zona { get; set; }
        public DbSet<in_Zona_vs_CentroDeCosto> in_Zona_vs_CentroDeCosto { get; set; }
        public DbSet<in_AjusteFisico_tmp> in_AjusteFisico_tmp { get; set; }
        public DbSet<vwin_Ajuste_fisico_x_relacion_inven_x_cbteCble> vwin_Ajuste_fisico_x_relacion_inven_x_cbteCble { get; set; }
        public DbSet<vwin_ajusteFisico> vwin_ajusteFisico { get; set; }
        public DbSet<vwin_Cate_Lin_Grup_SubGrup> vwin_Cate_Lin_Grup_SubGrup { get; set; }
        public DbSet<vwin_categoria_lin_gr_subgr> vwin_categoria_lin_gr_subgr { get; set; }
        public DbSet<vwIn_Dashboard_GuiaRemision> vwIn_Dashboard_GuiaRemision { get; set; }
        public DbSet<vwin_devolucion_inven> vwin_devolucion_inven { get; set; }
        public DbSet<vwin_devolucion_inven_det> vwin_devolucion_inven_det { get; set; }
        public DbSet<vwin_devolucion_inven_det_cantidad_devuelta> vwin_devolucion_inven_det_cantidad_devuelta { get; set; }
        public DbSet<vwin_GeneracionCompraCidersus> vwin_GeneracionCompraCidersus { get; set; }
        public DbSet<vwin_guia_x_traspaso_bodega> vwin_guia_x_traspaso_bodega { get; set; }
        public DbSet<vwin_Guia_x_traspaso_bodega_det_sin_Transferencia> vwin_Guia_x_traspaso_bodega_det_sin_Transferencia { get; set; }
        public DbSet<vwin_Guia_x_traspaso_bodega_x_ordencompra_local_det> vwin_Guia_x_traspaso_bodega_x_ordencompra_local_det { get; set; }
        public DbSet<vwin_GuiaRemision> vwin_GuiaRemision { get; set; }
        public DbSet<vwin_GuiaRemision_det_con_saldo_x_ing_a_inven> vwin_GuiaRemision_det_con_saldo_x_ing_a_inven { get; set; }
        public DbSet<vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo> vwin_GuiaRemision_det_con_saldo_x_ing_a_inven_con_saldo { get; set; }
        public DbSet<vwin_GuiaRemision_Lite> vwin_GuiaRemision_Lite { get; set; }
        public DbSet<vwin_in_Guia_x_traspaso_bodega_x_in_transferencia_det> vwin_in_Guia_x_traspaso_bodega_x_in_transferencia_det { get; set; }
        public DbSet<vwin_in_Producto_x_tb_bodega_x_UnidadMedida> vwin_in_Producto_x_tb_bodega_x_UnidadMedida { get; set; }
        public DbSet<vwin_Ing_Egr_Inven> vwin_Ing_Egr_Inven { get; set; }
        public DbSet<vwin_Ing_Egr_Inven_det> vwin_Ing_Egr_Inven_det { get; set; }
        public DbSet<vwIn_Ing_Egr_Inven_det_x_Cbte_Cble> vwIn_Ing_Egr_Inven_det_x_Cbte_Cble { get; set; }
        public DbSet<vwin_Ing_Egr_Inven_det_x_com_ordencompra_local_det> vwin_Ing_Egr_Inven_det_x_com_ordencompra_local_det { get; set; }
        public DbSet<vwin_Ing_Egr_Inven_det_x_com_ordencompra_local_det_2> vwin_Ing_Egr_Inven_det_x_com_ordencompra_local_det_2 { get; set; }
        public DbSet<vwin_Ing_Egr_Inven_det_x_com_ordencompra_local_det_x_cp_Aprob> vwin_Ing_Egr_Inven_det_x_com_ordencompra_local_det_x_cp_Aprob { get; set; }
        public DbSet<vwin_Ing_Egr_Inven_det_x_estado_aprob> vwin_Ing_Egr_Inven_det_x_estado_aprob { get; set; }
        public DbSet<vwin_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det> vwin_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det { get; set; }
        public DbSet<vwin_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det_x_cp_Aprob> vwin_Ing_Egr_Inven_det_x_prd_OrdenTrabajo_Det_x_cp_Aprob { get; set; }
        public DbSet<vwin_Ing_Egr_Inven_det_x_Producto> vwin_Ing_Egr_Inven_det_x_Producto { get; set; }
        public DbSet<vwin_Ing_Egr_Inven_para_devolucion> vwin_Ing_Egr_Inven_para_devolucion { get; set; }
        public DbSet<vwin_Ing_Egr_Inven_x_in_movi_inve> vwin_Ing_Egr_Inven_x_in_movi_inve { get; set; }
        public DbSet<vwin_Ing_Egr_Inven_x_prd_OrdenTaller_x_Ing_Egr_Inven_Det> vwin_Ing_Egr_Inven_x_prd_OrdenTaller_x_Ing_Egr_Inven_Det { get; set; }
        public DbSet<vwin_Motivo_traslado_bodega> vwin_Motivo_traslado_bodega { get; set; }
        public DbSet<vwin_movi_inve> vwin_movi_inve { get; set; }
        public DbSet<vwin_movi_inve_detalle> vwin_movi_inve_detalle { get; set; }
        public DbSet<vwin_movi_inve_detalle_para_stock_a_la_fecha> vwin_movi_inve_detalle_para_stock_a_la_fecha { get; set; }
        public DbSet<vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles> vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles { get; set; }
        public DbSet<vwin_movi_inve_detalle_x_item_disponibles> vwin_movi_inve_detalle_x_item_disponibles { get; set; }
        public DbSet<vwin_movi_inve_detalle_x_item_ingresos> vwin_movi_inve_detalle_x_item_ingresos { get; set; }
        public DbSet<vwin_movi_inve_fecha_costeo_recomendada_x_sucursal> vwin_movi_inve_fecha_costeo_recomendada_x_sucursal { get; set; }
        public DbSet<vwin_movi_inve_x_cbteCble_Datos> vwin_movi_inve_x_cbteCble_Datos { get; set; }
        public DbSet<vwin_movi_inve_x_com_ordencompra_local> vwin_movi_inve_x_com_ordencompra_local { get; set; }
        public DbSet<vwin_movi_inve_x_despachar> vwin_movi_inve_x_despachar { get; set; }
        public DbSet<vwin_movi_inve_x_estado_contabilizacion> vwin_movi_inve_x_estado_contabilizacion { get; set; }
        public DbSet<vwin_movi_inve_x_Ing_Ordencompra_local> vwin_movi_inve_x_Ing_Ordencompra_local { get; set; }
        public DbSet<vwin_Movi_Inven_x_Ing_x_OC> vwin_Movi_Inven_x_Ing_x_OC { get; set; }
        public DbSet<vwin_MoviemientoInvetarioXImportacion> vwin_MoviemientoInvetarioXImportacion { get; set; }
        public DbSet<vwin_producto> vwin_producto { get; set; }
        public DbSet<vwin_producto_despachado> vwin_producto_despachado { get; set; }
        public DbSet<vwin_producto_despachado_x_guiaRemision> vwin_producto_despachado_x_guiaRemision { get; set; }
        public DbSet<vwin_producto_despachado_x_guiaRemision_Acumulada> vwin_producto_despachado_x_guiaRemision_Acumulada { get; set; }
        public DbSet<vwin_Producto_Marca_Tipo_Categoria> vwin_Producto_Marca_Tipo_Categoria { get; set; }
        public DbSet<vwin_Producto_Pedidos_Egresos_x_Bodega> vwin_Producto_Pedidos_Egresos_x_Bodega { get; set; }
        public DbSet<vwin_producto_precio_historico> vwin_producto_precio_historico { get; set; }
        public DbSet<vwin_Producto_Stock> vwin_Producto_Stock { get; set; }
        public DbSet<vwin_Producto_Stock_Lote> vwin_Producto_Stock_Lote { get; set; }
        public DbSet<vwin_Producto_Stock_x_Bodega> vwin_Producto_Stock_x_Bodega { get; set; }
        public DbSet<vwin_Producto_Stock_x_producto> vwin_Producto_Stock_x_producto { get; set; }
        public DbSet<vwin_Producto_Stock_x_Sucursal> vwin_Producto_Stock_x_Sucursal { get; set; }
        public DbSet<vwin_producto_Ult_Costo_Hist_x_Bod> vwin_producto_Ult_Costo_Hist_x_Bod { get; set; }
        public DbSet<vwin_producto_Ult_Costo_Hist_x_Sucu> vwin_producto_Ult_Costo_Hist_x_Sucu { get; set; }
        public DbSet<vwin_producto_x_modulo> vwin_producto_x_modulo { get; set; }
        public DbSet<vwin_producto_x_modulo_lite> vwin_producto_x_modulo_lite { get; set; }
        public DbSet<vwin_producto_x_modulo_sin_Stock> vwin_producto_x_modulo_sin_Stock { get; set; }
        public DbSet<vwin_Producto_x_Proveedor> vwin_Producto_x_Proveedor { get; set; }
        public DbSet<vwin_producto_x_sucursal> vwin_producto_x_sucursal { get; set; }
        public DbSet<vwin_producto_x_tb_bodega> vwin_producto_x_tb_bodega { get; set; }
        public DbSet<vwin_producto_x_tb_bodega_Costo_Historico> vwin_producto_x_tb_bodega_Costo_Historico { get; set; }
        public DbSet<vwin_producto_x_tb_bodega_lite> vwin_producto_x_tb_bodega_lite { get; set; }
        public DbSet<vwin_producto_x_tb_bodega_Lote> vwin_producto_x_tb_bodega_Lote { get; set; }
        public DbSet<vwin_producto_x_tb_bodega_Precios> vwin_producto_x_tb_bodega_Precios { get; set; }
        public DbSet<vwin_producto_x_tb_bodega_sin_Stock> vwin_producto_x_tb_bodega_sin_Stock { get; set; }
        public DbSet<vwin_producto_x_tb_bodega_x_Ctas_cbles> vwin_producto_x_tb_bodega_x_Ctas_cbles { get; set; }
        public DbSet<vwin_prt_transferencia> vwin_prt_transferencia { get; set; }
        public DbSet<vwin_subgrupo_x_CentroCosto_x_SubCentroCosto_sin_CtaCble> vwin_subgrupo_x_CentroCosto_x_SubCentroCosto_sin_CtaCble { get; set; }
        public DbSet<vwin_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble> vwin_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble { get; set; }
        public DbSet<vwin_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_no_param> vwin_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_no_param { get; set; }
        public DbSet<vwin_transferencia_det_x_in_Guia_x_traspaso_bodega_det> vwin_transferencia_det_x_in_Guia_x_traspaso_bodega_det { get; set; }
        public DbSet<vwin_Transferencia_Detalle> vwin_Transferencia_Detalle { get; set; }
        public DbSet<vwin_Transferencia_sin_guia> vwin_Transferencia_sin_guia { get; set; }
        public DbSet<vwin_transferencia_x_in_movi_inve_agrupada_para_recosteo> vwin_transferencia_x_in_movi_inve_agrupada_para_recosteo { get; set; }
        public DbSet<vwin_Transferencia_x_Ing_Egr_Inven> vwin_Transferencia_x_Ing_Egr_Inven { get; set; }
        public DbSet<vwin_Transferencias> vwin_Transferencias { get; set; }
        public DbSet<vwin_UnidadMedida> vwin_UnidadMedida { get; set; }
        public DbSet<vwin_UnidadMedida_Equivalencia> vwin_UnidadMedida_Equivalencia { get; set; }
        public DbSet<vwin_VistaParaContabilizarInventario> vwin_VistaParaContabilizarInventario { get; set; }
        public DbSet<vwin_Zona_vs_ct_Centro_Costo> vwin_Zona_vs_ct_Centro_Costo { get; set; }

        public virtual ObjectResult<spIn_CuerpoDelCardex_Result> spIn_CuerpoDelCardex(Nullable<int> p_IdEmpresa, Nullable<int> p_IdBodega, Nullable<int> p_IdSucursal, Nullable<decimal> p_IdProducto, Nullable<System.DateTime> p_FechaInicial, Nullable<System.DateTime> p_FechaFinal)
        {
            var p_IdEmpresaParameter = p_IdEmpresa.HasValue ?
                new ObjectParameter("p_IdEmpresa", p_IdEmpresa) :
                new ObjectParameter("p_IdEmpresa", typeof(int));

            var p_IdBodegaParameter = p_IdBodega.HasValue ?
                new ObjectParameter("p_IdBodega", p_IdBodega) :
                new ObjectParameter("p_IdBodega", typeof(int));

            var p_IdSucursalParameter = p_IdSucursal.HasValue ?
                new ObjectParameter("p_IdSucursal", p_IdSucursal) :
                new ObjectParameter("p_IdSucursal", typeof(int));

            var p_IdProductoParameter = p_IdProducto.HasValue ?
                new ObjectParameter("p_IdProducto", p_IdProducto) :
                new ObjectParameter("p_IdProducto", typeof(decimal));

            var p_FechaInicialParameter = p_FechaInicial.HasValue ?
                new ObjectParameter("p_FechaInicial", p_FechaInicial) :
                new ObjectParameter("p_FechaInicial", typeof(System.DateTime));

            var p_FechaFinalParameter = p_FechaFinal.HasValue ?
                new ObjectParameter("p_FechaFinal", p_FechaFinal) :
                new ObjectParameter("p_FechaFinal", typeof(System.DateTime));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spIn_CuerpoDelCardex_Result>("spIn_CuerpoDelCardex", p_IdEmpresaParameter, p_IdBodegaParameter, p_IdSucursalParameter, p_IdProductoParameter, p_FechaInicialParameter, p_FechaFinalParameter);
        }

        public virtual ObjectResult<spIn_DisponibilidadDEInventario_Result> spIn_DisponibilidadDEInventario(Nullable<System.DateTime> p_fecha, Nullable<int> p_IdEmpresa, Nullable<int> p_IdSucursal, Nullable<int> p_IdBodega, string p_Categorias, string p_IdUsuario)
        {
            var p_fechaParameter = p_fecha.HasValue ?
                new ObjectParameter("p_fecha", p_fecha) :
                new ObjectParameter("p_fecha", typeof(System.DateTime));

            var p_IdEmpresaParameter = p_IdEmpresa.HasValue ?
                new ObjectParameter("p_IdEmpresa", p_IdEmpresa) :
                new ObjectParameter("p_IdEmpresa", typeof(int));

            var p_IdSucursalParameter = p_IdSucursal.HasValue ?
                new ObjectParameter("p_IdSucursal", p_IdSucursal) :
                new ObjectParameter("p_IdSucursal", typeof(int));

            var p_IdBodegaParameter = p_IdBodega.HasValue ?
                new ObjectParameter("p_IdBodega", p_IdBodega) :
                new ObjectParameter("p_IdBodega", typeof(int));

            var p_CategoriasParameter = p_Categorias != null ?
                new ObjectParameter("p_Categorias", p_Categorias) :
                new ObjectParameter("p_Categorias", typeof(string));

            var p_IdUsuarioParameter = p_IdUsuario != null ?
                new ObjectParameter("p_IdUsuario", p_IdUsuario) :
                new ObjectParameter("p_IdUsuario", typeof(string));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spIn_DisponibilidadDEInventario_Result>("spIn_DisponibilidadDEInventario", p_fechaParameter, p_IdEmpresaParameter, p_IdSucursalParameter, p_IdBodegaParameter, p_CategoriasParameter, p_IdUsuarioParameter);
        }

        public virtual ObjectResult<spIn_Inventario_Obtener_Stock_A_Fecha_Result> spIn_Inventario_Obtener_Stock_A_Fecha(Nullable<System.DateTime> p_Fecha, Nullable<int> p_IdEmpresa, Nullable<int> p_IdSucursal, Nullable<int> p_IdBodega)
        {
            var p_FechaParameter = p_Fecha.HasValue ?
                new ObjectParameter("p_Fecha", p_Fecha) :
                new ObjectParameter("p_Fecha", typeof(System.DateTime));

            var p_IdEmpresaParameter = p_IdEmpresa.HasValue ?
                new ObjectParameter("p_IdEmpresa", p_IdEmpresa) :
                new ObjectParameter("p_IdEmpresa", typeof(int));

            var p_IdSucursalParameter = p_IdSucursal.HasValue ?
                new ObjectParameter("p_IdSucursal", p_IdSucursal) :
                new ObjectParameter("p_IdSucursal", typeof(int));

            var p_IdBodegaParameter = p_IdBodega.HasValue ?
                new ObjectParameter("p_IdBodega", p_IdBodega) :
                new ObjectParameter("p_IdBodega", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spIn_Inventario_Obtener_Stock_A_Fecha_Result>("spIn_Inventario_Obtener_Stock_A_Fecha", p_FechaParameter, p_IdEmpresaParameter, p_IdSucursalParameter, p_IdBodegaParameter);
        }

        public virtual ObjectResult<spIn_ObtenerStockAFechaPorProducto_Result> spIn_ObtenerStockAFechaPorProducto(Nullable<int> p_IdEmpresa, Nullable<int> p_IdBodega, Nullable<int> p_IdSucursal, Nullable<decimal> p_IdProducto, Nullable<System.DateTime> p_Fecha)
        {
            var p_IdEmpresaParameter = p_IdEmpresa.HasValue ?
                new ObjectParameter("p_IdEmpresa", p_IdEmpresa) :
                new ObjectParameter("p_IdEmpresa", typeof(int));

            var p_IdBodegaParameter = p_IdBodega.HasValue ?
                new ObjectParameter("p_IdBodega", p_IdBodega) :
                new ObjectParameter("p_IdBodega", typeof(int));

            var p_IdSucursalParameter = p_IdSucursal.HasValue ?
                new ObjectParameter("p_IdSucursal", p_IdSucursal) :
                new ObjectParameter("p_IdSucursal", typeof(int));

            var p_IdProductoParameter = p_IdProducto.HasValue ?
                new ObjectParameter("p_IdProducto", p_IdProducto) :
                new ObjectParameter("p_IdProducto", typeof(decimal));

            var p_FechaParameter = p_Fecha.HasValue ?
                new ObjectParameter("p_Fecha", p_Fecha) :
                new ObjectParameter("p_Fecha", typeof(System.DateTime));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spIn_ObtenerStockAFechaPorProducto_Result>("spIn_ObtenerStockAFechaPorProducto", p_IdEmpresaParameter, p_IdBodegaParameter, p_IdSucursalParameter, p_IdProductoParameter, p_FechaParameter);
        }

        public virtual int spIn_Carga_en_lote_Productos_a_Producto_x_Bodega(Nullable<int> p_IdEmpresa)
        {
            var p_IdEmpresaParameter = p_IdEmpresa.HasValue ?
                new ObjectParameter("p_IdEmpresa", p_IdEmpresa) :
                new ObjectParameter("p_IdEmpresa", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spIn_Carga_en_lote_Productos_a_Producto_x_Bodega", p_IdEmpresaParameter);
        }

        public virtual int spSys_Inv_Recosteo_Inventario_x_rango_fechas(Nullable<int> p_IdEmpresa, Nullable<int> p_IdSucursal, Nullable<int> p_IdBodega, Nullable<System.DateTime> p_Fecha_ini, Nullable<System.DateTime> p_Fecha_fin, Nullable<int> p_cant_Decimales)
        {
            var p_IdEmpresaParameter = p_IdEmpresa.HasValue ?
                new ObjectParameter("p_IdEmpresa", p_IdEmpresa) :
                new ObjectParameter("p_IdEmpresa", typeof(int));

            var p_IdSucursalParameter = p_IdSucursal.HasValue ?
                new ObjectParameter("p_IdSucursal", p_IdSucursal) :
                new ObjectParameter("p_IdSucursal", typeof(int));

            var p_IdBodegaParameter = p_IdBodega.HasValue ?
                new ObjectParameter("p_IdBodega", p_IdBodega) :
                new ObjectParameter("p_IdBodega", typeof(int));

            var p_Fecha_iniParameter = p_Fecha_ini.HasValue ?
                new ObjectParameter("p_Fecha_ini", p_Fecha_ini) :
                new ObjectParameter("p_Fecha_ini", typeof(System.DateTime));

            var p_Fecha_finParameter = p_Fecha_fin.HasValue ?
                new ObjectParameter("p_Fecha_fin", p_Fecha_fin) :
                new ObjectParameter("p_Fecha_fin", typeof(System.DateTime));

            var p_cant_DecimalesParameter = p_cant_Decimales.HasValue ?
                new ObjectParameter("p_cant_Decimales", p_cant_Decimales) :
                new ObjectParameter("p_cant_Decimales", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSys_Inv_Recosteo_Inventario_x_rango_fechas", p_IdEmpresaParameter, p_IdSucursalParameter, p_IdBodegaParameter, p_Fecha_iniParameter, p_Fecha_finParameter, p_cant_DecimalesParameter);
        }

        public virtual int spSys_Inv_Recosteo_Inventario(Nullable<int> p_IdEmpresa, Nullable<int> p_IdSucursal, Nullable<int> p_IdBodega, Nullable<System.DateTime> p_Fecha_ini, Nullable<int> p_cant_Decimales)
        {
            var p_IdEmpresaParameter = p_IdEmpresa.HasValue ?
                new ObjectParameter("p_IdEmpresa", p_IdEmpresa) :
                new ObjectParameter("p_IdEmpresa", typeof(int));

            var p_IdSucursalParameter = p_IdSucursal.HasValue ?
                new ObjectParameter("p_IdSucursal", p_IdSucursal) :
                new ObjectParameter("p_IdSucursal", typeof(int));

            var p_IdBodegaParameter = p_IdBodega.HasValue ?
                new ObjectParameter("p_IdBodega", p_IdBodega) :
                new ObjectParameter("p_IdBodega", typeof(int));

            var p_Fecha_iniParameter = p_Fecha_ini.HasValue ?
                new ObjectParameter("p_Fecha_ini", p_Fecha_ini) :
                new ObjectParameter("p_Fecha_ini", typeof(System.DateTime));

            var p_cant_DecimalesParameter = p_cant_Decimales.HasValue ?
                new ObjectParameter("p_cant_Decimales", p_cant_Decimales) :
                new ObjectParameter("p_cant_Decimales", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSys_Inv_Recosteo_Inventario", p_IdEmpresaParameter, p_IdSucursalParameter, p_IdBodegaParameter, p_Fecha_iniParameter, p_cant_DecimalesParameter);
        }

        public virtual ObjectResult<spSys_inv_Reversar_aprobacion_Result> spSys_inv_Reversar_aprobacion(Nullable<int> p_IdEmpresa, Nullable<int> p_IdSucursal, Nullable<int> p_IdMovi_inven_tipo, Nullable<decimal> p_IdNumMovi, Nullable<bool> p_Borar)
        {
            var p_IdEmpresaParameter = p_IdEmpresa.HasValue ?
                new ObjectParameter("p_IdEmpresa", p_IdEmpresa) :
                new ObjectParameter("p_IdEmpresa", typeof(int));

            var p_IdSucursalParameter = p_IdSucursal.HasValue ?
                new ObjectParameter("p_IdSucursal", p_IdSucursal) :
                new ObjectParameter("p_IdSucursal", typeof(int));

            var p_IdMovi_inven_tipoParameter = p_IdMovi_inven_tipo.HasValue ?
                new ObjectParameter("p_IdMovi_inven_tipo", p_IdMovi_inven_tipo) :
                new ObjectParameter("p_IdMovi_inven_tipo", typeof(int));

            var p_IdNumMoviParameter = p_IdNumMovi.HasValue ?
                new ObjectParameter("p_IdNumMovi", p_IdNumMovi) :
                new ObjectParameter("p_IdNumMovi", typeof(decimal));

            var p_BorarParameter = p_Borar.HasValue ?
                new ObjectParameter("p_Borar", p_Borar) :
                new ObjectParameter("p_Borar", typeof(bool));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSys_inv_Reversar_aprobacion_Result>("spSys_inv_Reversar_aprobacion", p_IdEmpresaParameter, p_IdSucursalParameter, p_IdMovi_inven_tipoParameter, p_IdNumMoviParameter, p_BorarParameter);
        }

        public virtual ObjectResult<spin_Producto_Stock_x_Fecha_Result> spin_Producto_Stock_x_Fecha(Nullable<int> p_IdEmpresa, Nullable<int> p_IdSucursal, Nullable<int> p_IdBodega, Nullable<decimal> p_IdProducto, Nullable<System.DateTime> p_Fecha_corte)
        {
            var p_IdEmpresaParameter = p_IdEmpresa.HasValue ?
                new ObjectParameter("p_IdEmpresa", p_IdEmpresa) :
                new ObjectParameter("p_IdEmpresa", typeof(int));

            var p_IdSucursalParameter = p_IdSucursal.HasValue ?
                new ObjectParameter("p_IdSucursal", p_IdSucursal) :
                new ObjectParameter("p_IdSucursal", typeof(int));

            var p_IdBodegaParameter = p_IdBodega.HasValue ?
                new ObjectParameter("p_IdBodega", p_IdBodega) :
                new ObjectParameter("p_IdBodega", typeof(int));

            var p_IdProductoParameter = p_IdProducto.HasValue ?
                new ObjectParameter("p_IdProducto", p_IdProducto) :
                new ObjectParameter("p_IdProducto", typeof(decimal));

            var p_Fecha_corteParameter = p_Fecha_corte.HasValue ?
                new ObjectParameter("p_Fecha_corte", p_Fecha_corte) :
                new ObjectParameter("p_Fecha_corte", typeof(System.DateTime));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spin_Producto_Stock_x_Fecha_Result>("spin_Producto_Stock_x_Fecha", p_IdEmpresaParameter, p_IdSucursalParameter, p_IdBodegaParameter, p_IdProductoParameter, p_Fecha_corteParameter);
        }

        public virtual int spSys_Inv_Recosteo_Inventario_x_Producto(Nullable<int> p_IdEmpresa, Nullable<int> p_IdSucursal, Nullable<int> p_IdBodega, Nullable<decimal> p_IdProducto, Nullable<System.DateTime> p_Fecha_ini, Nullable<int> p_cant_Decimales)
        {
            var p_IdEmpresaParameter = p_IdEmpresa.HasValue ?
                new ObjectParameter("p_IdEmpresa", p_IdEmpresa) :
                new ObjectParameter("p_IdEmpresa", typeof(int));

            var p_IdSucursalParameter = p_IdSucursal.HasValue ?
                new ObjectParameter("p_IdSucursal", p_IdSucursal) :
                new ObjectParameter("p_IdSucursal", typeof(int));

            var p_IdBodegaParameter = p_IdBodega.HasValue ?
                new ObjectParameter("p_IdBodega", p_IdBodega) :
                new ObjectParameter("p_IdBodega", typeof(int));

            var p_IdProductoParameter = p_IdProducto.HasValue ?
                new ObjectParameter("p_IdProducto", p_IdProducto) :
                new ObjectParameter("p_IdProducto", typeof(decimal));

            var p_Fecha_iniParameter = p_Fecha_ini.HasValue ?
                new ObjectParameter("p_Fecha_ini", p_Fecha_ini) :
                new ObjectParameter("p_Fecha_ini", typeof(System.DateTime));

            var p_cant_DecimalesParameter = p_cant_Decimales.HasValue ?
                new ObjectParameter("p_cant_Decimales", p_cant_Decimales) :
                new ObjectParameter("p_cant_Decimales", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSys_Inv_Recosteo_Inventario_x_Producto", p_IdEmpresaParameter, p_IdSucursalParameter, p_IdBodegaParameter, p_IdProductoParameter, p_Fecha_iniParameter, p_cant_DecimalesParameter);
        }
    }
}
