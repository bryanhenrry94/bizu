using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dazzsoft.ERP.Infrastructure.Model.Compra;

namespace Dazzsoft.ERP.Infrastructure.Persistence
{
    class CompraContext : DbContext
    {
        public CompraContext() : base("name=DefaultConnection") { }

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

        public DbSet<com_catalogo> com_catalogo { get; set; }
        public DbSet<com_catalogo_tipo> com_catalogo_tipo { get; set; }
        public DbSet<com_comprador> com_comprador { get; set; }
        public DbSet<com_cotizacion_compra> com_cotizacion_compra { get; set; }
        public DbSet<com_cotizacion_compra_det> com_cotizacion_compra_det { get; set; }
        public DbSet<com_cotizacion_compra_Edehsa> com_cotizacion_compra_Edehsa { get; set; }
        public DbSet<com_cotizacion_compra_GE> com_cotizacion_compra_GE { get; set; }
        public DbSet<com_cotizacion_compra_GE_det> com_cotizacion_compra_GE_det { get; set; }
        public DbSet<com_departamento> com_departamento { get; set; }
        public DbSet<com_dev_compra> com_dev_compra { get; set; }
        public DbSet<com_dev_compra_det> com_dev_compra_det { get; set; }
        public DbSet<com_estado_cierre> com_estado_cierre { get; set; }
        public DbSet<com_ListadoDiseno> com_ListadoDiseno { get; set; }
        public DbSet<com_ListadoDiseno_Det> com_ListadoDiseno_Det { get; set; }
        public DbSet<com_ListadoDisenoTipo> com_ListadoDisenoTipo { get; set; }
        public DbSet<com_ListadoElementos_x_OT> com_ListadoElementos_x_OT { get; set; }
        public DbSet<com_ListadoElementos_x_OT_Det> com_ListadoElementos_x_OT_Det { get; set; }
        public DbSet<com_ListadoMateriales_Det> com_ListadoMateriales_Det { get; set; }
        public DbSet<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra> com_ListadoMaterialesDisponibles_PreAsignado_a_Obra { get; set; }
        public DbSet<com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det> com_ListadoMaterialesDisponibles_PreAsignado_a_Obra_Det { get; set; }
        public DbSet<com_Motivo_Orden_Compra> com_Motivo_Orden_Compra { get; set; }
        public DbSet<com_ordencompra_local> com_ordencompra_local { get; set; }
        public DbSet<com_ordencompra_local_det> com_ordencompra_local_det { get; set; }
        public DbSet<com_ordencompra_local_det_x_com_solicitud_compra_det> com_ordencompra_local_det_x_com_solicitud_compra_det { get; set; }
        public DbSet<com_ordencompra_local_x_com_solicitud_compra> com_ordencompra_local_x_com_solicitud_compra { get; set; }
        public DbSet<com_ordencompraGE_local> com_ordencompraGE_local { get; set; }
        public DbSet<com_ordencompralocal> com_ordencompralocal { get; set; }
        public DbSet<com_parametro> com_parametro { get; set; }
        public DbSet<com_Registro_OrdenCompra_x_Cotizacion> com_Registro_OrdenCompra_x_Cotizacion { get; set; }
        public DbSet<com_Registro_OrdenCompra_x_Solicitud> com_Registro_OrdenCompra_x_Solicitud { get; set; }
        public DbSet<com_Registro_OrdenCompraG_x_Cotizacion> com_Registro_OrdenCompraG_x_Cotizacion { get; set; }
        public DbSet<com_Registro_OrdenCompraGE_x_Cotizacion> com_Registro_OrdenCompraGE_x_Cotizacion { get; set; }
        public DbSet<com_Registro_OrdenComprax_Cotizacion> com_Registro_OrdenComprax_Cotizacion { get; set; }
        public DbSet<com_solicitante> com_solicitante { get; set; }
        public DbSet<com_solicitud_compra> com_solicitud_compra { get; set; }
        public DbSet<com_solicitud_compra_det_aprobacion> com_solicitud_compra_det_aprobacion { get; set; }
        public DbSet<com_solicitud_compra_det_pre_aprobacion> com_solicitud_compra_det_pre_aprobacion { get; set; }
        public DbSet<com_TerminoPago> com_TerminoPago { get; set; }
        public DbSet<com_tarjeta_orden_compra> com_tarjeta_orden_compra { get; set; }
        public DbSet<vwcom_Catalogo_IdAuto_numeric> vwcom_Catalogo_IdAuto_numeric { get; set; }
        public DbSet<vwcom_cotizacion_compra_Edehsa> vwcom_cotizacion_compra_Edehsa { get; set; }
        public DbSet<vwcom_dev_compra> vwcom_dev_compra { get; set; }
        public DbSet<vwcom_dev_compra_con_det> vwcom_dev_compra_con_det { get; set; }
        public DbSet<vwcom_dev_compra_det_cant_devuelta_x_prod> vwcom_dev_compra_det_cant_devuelta_x_prod { get; set; }
        public DbSet<vwcom_EstadoAnulacion> vwcom_EstadoAnulacion { get; set; }
        public DbSet<vwcom_EstadoAprob_List_Req> vwcom_EstadoAprob_List_Req { get; set; }
        public DbSet<vwcom_EstadoAprobacion> vwcom_EstadoAprobacion { get; set; }
        public DbSet<vwcom_EstadoAprobacion_sol_compra> vwcom_EstadoAprobacion_sol_compra { get; set; }
        public DbSet<vwcom_EstadoRecibido> vwcom_EstadoRecibido { get; set; }
        public DbSet<vwcom_MotivoRequerimiento> vwcom_MotivoRequerimiento { get; set; }
        public DbSet<vwcom_ordencompra_local> vwcom_ordencompra_local { get; set; }
        public DbSet<vwcom_ordencompra_local_con_cant_devolver> vwcom_ordencompra_local_con_cant_devolver { get; set; }
        public DbSet<vwcom_ordencompra_local_det> vwcom_ordencompra_local_det { get; set; }
        public DbSet<vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven> vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven { get; set; }
        public DbSet<vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven_con_saldo> vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven_con_saldo { get; set; }
        public DbSet<vwcom_ordencompra_local_det_GE> vwcom_ordencompra_local_det_GE { get; set; }
        public DbSet<vwcom_ordencompra_local_det_x_cant_pedida_solic_compra> vwcom_ordencompra_local_det_x_cant_pedida_solic_compra { get; set; }
        public DbSet<vwcom_ordencompra_local_det_x_com_solicitud_compra_det> vwcom_ordencompra_local_det_x_com_solicitud_compra_det { get; set; }
        public DbSet<vwcom_ordencompra_local_det_x_MoviInven_SaldoItem> vwcom_ordencompra_local_det_x_MoviInven_SaldoItem { get; set; }
        public DbSet<vwcom_ordencompra_local_GE> vwcom_ordencompra_local_GE { get; set; }
        public DbSet<vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega> vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega { get; set; }
        public DbSet<vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega_consul> vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega_consul { get; set; }
        public DbSet<vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega_det> vwcom_ordencompra_local_sin_Guia_x_traspaso_bodega_det { get; set; }
        public DbSet<vwcom_ordencompra_local_vs_in_Guia_x_traspaso_bodega_Total_Reg> vwcom_ordencompra_local_vs_in_Guia_x_traspaso_bodega_Total_Reg { get; set; }
        public DbSet<vwcom_ordencompra_local_x_com_solicitud_compra> vwcom_ordencompra_local_x_com_solicitud_compra { get; set; }
        public DbSet<vwcom_ordencompra_local_x_in_guia_x_traspaso_bodega> vwcom_ordencompra_local_x_in_guia_x_traspaso_bodega { get; set; }
        public DbSet<vwcom_solicitud_compra> vwcom_solicitud_compra { get; set; }
        public DbSet<vwcom_solicitud_compra_det_aprobacion> vwcom_solicitud_compra_det_aprobacion { get; set; }
        public DbSet<vwcom_solicitud_compra_det_x_Orden_Compra> vwcom_solicitud_compra_det_x_Orden_Compra { get; set; }
        public DbSet<vwcom_solicitud_compra_x_items_con_saldos> vwcom_solicitud_compra_x_items_con_saldos { get; set; }
        public DbSet<vwcom_solicitud_compra_X_Orden_Compra> vwcom_solicitud_compra_X_Orden_Compra { get; set; }
        public DbSet<vwcom_SolicitudCompra_Det_CantidadPedida_Compra> vwcom_SolicitudCompra_Det_CantidadPedida_Compra { get; set; }
        public DbSet<vwcom_TerminoPago> vwcom_TerminoPago { get; set; }
        public DbSet<com_solicitud_compra_det> com_solicitud_compra_det { get; set; }
        public DbSet<vwcom_solicitud_compra_det> vwcom_solicitud_compra_det { get; set; }
        public DbSet<vwcom_SolicitudCompra_Det_SaldoPendiente> vwcom_SolicitudCompra_Det_SaldoPendiente { get; set; }
    }
}
