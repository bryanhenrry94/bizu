using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bizu.Domain.Inventario
{
    public class in_Ing_Egr_Inven_det_Info
    {
        public in_Ing_Egr_Inven_det_Info()
        {
            this.Info_Guia_x_traspaso_bodega_det = new in_Guia_x_traspaso_bodega_det_Info();
        }

        public int IdEmpresa { get; set; }

        public int IdSucursal { get; set; }

        public int IdMovi_inven_tipo { get; set; }

        public decimal IdNumMovi { get; set; }

        public int Secuencia { get; set; }

        public int? IdBodega { get; set; }

        public decimal IdProducto { get; set; }

        public double dm_cantidad { get; set; }

        public double dm_stock_ante { get; set; }

        public double dm_stock_actu { get; set; }

        public string dm_observacion { get; set; }

        public double dm_precio { get; set; }

        public double mv_costo { get; set; }

        public double dm_peso { get; set; }

        public string IdCentroCosto { get; set; }

        public string IdCentroCosto_sub_centro_costo { get; set; }

        public string IdRegistro { get; set; }

        public string IdEstadoAproba { get; set; }

        public string IdUnidadMedida { get; set; }

        public string Centro_costo2 { get; set; }

        public string NomSubCentroCosto { get; set; }

        public int? IdEmpresa_oc { get; set; }

        public int? IdSucursal_oc { get; set; }

        public decimal? IdOrdenCompra { get; set; }

        public int? Secuencia_oc { get; set; }

        public int? IdEmpresa_ot { get; set; }

        public int? IdSucursal_ot { get; set; }

        public decimal? IdOrdenTrabajo { get; set; }

        public int? Secuencia_ot { get; set; }

        public int? IdEmpresa_gr { get; set; }

        public int? IdSucursal_gr { get; set; }

        public decimal? IdGuiaRemision { get; set; }

        public int? Secuencia_gr { get; set; }

        public int? IdEmpresa_inv { get; set; }

        public int? IdSucursal_inv { get; set; }

        public int? IdBodega_inv { get; set; }

        public int? IdMovi_inven_tipo_inv { get; set; }

        public decimal? IdNumMovi_inv { get; set; }

        public int? secuencia_inv { get; set; }

        public decimal? IdOrdenTaller { get; set; }

        public int? IdPunto_cargo { get; set; }

        public int? IdPunto_cargo_grupo { get; set; }

        public int? IdMotivo_Inv { get; set; }

        public int? IdEmpresa_dev { get; set; }

        public int? IdSucursal_dev { get; set; }

        public int? IdBodega_dev { get; set; }

        public int? IdMovi_inven_tipo_dev { get; set; }

        public decimal? IdNumMovi_dev { get; set; }

        public int? Secuencia_dev { get; set; }

        public string Centro_costo { get; set; }

        public bool Checked { get; set; }

        public string pr_codigo { get; set; }

        public string pr_descripcion { get; set; }

        public string cod_producto { get; set; }

        public string nom_producto { get; set; }

        public int? IdProductoTipo { get; set; }

        public double dm_cantidad_sinConversion { get; set; }

        public string IdUnidadMedida_sinConversion { get; set; }

        public double mv_costo_sinConversion { get; set; }

        public string IdBodegaSIIS { get; set; }

        public string detalle_x_tiem { get; set; }

        public decimal cantidad_siis { get; set; }

        public string IdCtaCble { get; set; }

        public string pc_Cuenta2 { get; set; }

        public double dc_Valor_D { get; set; }

        public string fecha_vencimiento { get; set; }

        public string Lote { get; set; }

        public string nom_sucu { get; set; }

        public decimal? IdProveedor { get; set; }

        public string nom_proveedor { get; set; }

        public string oc_observacion { get; set; }

        public double cantidad_pedida_OC { get; set; }

        public double Saldo_x_Ing_OC { get; set; }

        public double Saldo_x_Ing_OC_AUX { get; set; }

        public int IdMotivo_OC { get; set; }

        public string Nom_Motivo { get; set; }

        public DateTime oc_fecha { get; set; }

        public double cantidad_ingresada { get; set; }

        public string IdEstado_cierre { get; set; }

        public string nom_estado_cierre { get; set; }

        public string Nomsub_centro_costo { get; set; }

        public string Motivo_Aprobacion { get; set; }

        public string Ref_OC { get; set; }

        public double do_descuento { get; set; }

        public double do_subtotal { get; set; }

        public double do_iva { get; set; }

        public double do_total { get; set; }

        public string nom_UnidadMedida { get; set; }

        public string IdUnidadMedida_Consumo { get; set; }

        public string oc_NumDocumento { get; set; }

        public string NumDocumento { get; set; }

        public string NumGuia { get; set; }

        public string IdTipo_Persona { get; set; }

        public decimal IdEntidad { get; set; }

        public string pe_nombreCompleto { get; set; }

        public string NomProyecto { get; set; }

        public double cantidad_sinConversion_GR { get; set; }

        public double cantidad_GR { get; set; }

        public double cantidad_ing_a_Inven { get; set; }

        public double Saldo_GR_x_Ing { get; set; }

        public double Saldo_GR_x_Ing_AUX { get; set; }

        public string signo { get; set; }

        public string nom_tipo_inv { get; set; }

        public string nom_bodega { get; set; }

        public string nom_medida { get; set; }

        public string nom_punto_cargo { get; set; }

        public DateTime? Fecha_registro { get; set; }

        public string IdUsuario { get; set; }

        public string IdCategoria { get; set; }

        public int? IdLinea { get; set; }

        public int? IdGrupo { get; set; }

        public int? IdSubgrupo { get; set; }

        public string ca_Categoria { get; set; }

        public string nom_linea { get; set; }

        public string nom_grupo { get; set; }

        public string nom_subgrupo { get; set; }

        public int IdOrdenProd { get; set; }

        public int? IdProyecto { get; set; }

        public int? IdBloque { get; set; }

        public int? IdNivel { get; set; }

        public in_Guia_x_traspaso_bodega_det_Info Info_Guia_x_traspaso_bodega_det { get; set; }

        public decimal IdOrdenTaller_OT { get; set; }

        public double PesoUnitario_OT { get; set; }

        public double CantidadPlanificada_OT { get; set; }

        public double CantidadLiberada_OT { get; set; }

        public double SaldoPendiente_OT { get; set; }

        public decimal IdRequerimiento { get; set; }

        public int Sec_Requerimiento { get; set; }

        public int Sec_Corte { get; set; }

        public decimal? IdResponsable { get; set; }
        public Nullable<decimal> IdContratista { get; set; }

    }
}