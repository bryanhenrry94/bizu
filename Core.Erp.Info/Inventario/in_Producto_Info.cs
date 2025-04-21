using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Inventario
{
    public class in_Producto_Info
    {
        public int IdEmpresa { get; set; }

        public decimal IdProducto { get; set; }

        public string pr_codigo { get; set; }

        public string CodBarra { get; set; }

        public string pr_descripcion { get; set; }

        public string pr_descripcion_2 { get; set; }

        public string pr_codigo_barra { get; set; }

        public int IdProductoTipo { get; set; }

        public string pr_observacion { get; set; }

        public string IdUnidadMedida { get; set; }

        public string IdUnidadMedida_Consumo { get; set; }

        public string pr_ManejaIva { get; set; }

        public string pr_ManejaSeries { get; set; }

        public double pr_costo_fob { get; set; }

        public double pr_costo_CIF { get; set; }

        public double? pr_costo_promedio { get; set; }

        public double? pr_peso { get; set; }

        public double? pr_pedidos { get; set; }

        public double? pr_Pedidos_fact { get; set; }

        public double? pr_Pedidos_inv { get; set; }

        public double? pr_stock { get; set; }

        public double? pr_Disponible { get; set; }

        public double? pr_precio_publico { get; set; }

        public double pr_precio_mayor { get; set; }

        public double? pr_precio_minimo { get; set; }

        public double? precio_minimo { get; set; }

        public string IdCategoria { get; set; }

        public int IdLinea { get; set; }

        public int IdGrupo { get; set; }

        public int IdSubGrupo { get; set; }

        public string IdPresentacion { get; set; }

        public int IdMarca { get; set; }

        public string IdEstadoAprobacion { get; set; }

        public string marca { get; set; }

        public int pr_DiasMaritimo { get; set; }

        public int pr_DiasAereo { get; set; }

        public int pr_DiasTerrestre { get; set; }

        public double pr_largo { get; set; }

        public double pr_alto { get; set; }

        public double pr_profundidad { get; set; }

        public string pr_partidaArancel { get; set; }

        public decimal pr_porcentajeArancel { get; set; }

        public double pr_stock_maximo { get; set; }

        public double pr_stock_minimo { get; set; }

        public double pr_stock_Bodega { get; set; }

        public int IdBodega { get; set; }

        public int IdSucursal { get; set; }

        public string Estado { get; set; }

        public byte[] pr_imagenPeque { get; set; }

        public byte[] pr_imagen_Grande { get; set; }

        public string IdUsuario { get; set; }

        public DateTime Fecha_Transac { get; set; }

        public string IdUsuarioUltMod { get; set; }

        public DateTime Fecha_UltMod { get; set; }

        public string IdUsuarioUltAnu { get; set; }

        public DateTime? Fecha_UltAnu { get; set; }

        public string nom_pc { get; set; }

        public string ip { get; set; }

        public string pr_motivoAnulacion { get; set; }

        public string RutaPadre { get; set; }

        public string nom_UnidadMedida { get; set; }

        public string nom_UnidadMedida_Consumo { get; set; }

        public string nom_Marca { get; set; }

        public string nom_Bodega { get; set; }

        public string nom_Sucursal { get; set; }

        public string nom_Tipo_Producto { get; set; }

        public string nom_Presentacion { get; set; }

        public string nom_Proveedor { get; set; }

        public string nom_Categoria { get; set; }

        public string nom_Linea { get; set; }

        public string nom_Grupo { get; set; }

        public string nom_SubGrupo { get; set; }

        public string SEstado { get; set; }

        public bool Cheked { get; set; }

        public double Porc_Descuento { get; set; }

        public double Descuento { get; set; }

        public double Subtotal { get; set; }

        public decimal? StockFisico { get; set; }

        public decimal CantidadAjustada { get; set; }

        public string ManejaKardex { get; set; }

        public string ManejaLote { get; set; }

        public double? PesoEspecifico { get; set; }

        public double? AnchoEspecifico { get; set; }

        public double pr_disponible { get; set; }

        public int IdMotivo_Vta { get; set; }

        public double pr_precio_puerta { get; set; }

        public double pr_Por_descuento { get; set; }

        public double Disponible { get; set; }

        public double do_Cantidad { get; set; }

        public string IdCod_Impuesto_Iva { get; set; }

        public string IdCod_Impuesto_Ice { get; set; }

        public bool Aparece_modu_Ventas { get; set; }

        public bool Aparece_modu_Compras { get; set; }

        public bool Aparece_modu_Inventario { get; set; }

        public bool Aparece_modu_Activo_F { get; set; }

        public string IdCtaCble_Vta { get; set; }

        public string IdCtaCble_VenIva { get; set; }

        public string IdCtaCble_Ven0 { get; set; }

        public string IdCtaCble_CosBaseIva { get; set; }

        public string IdCtaCble_CosBase0 { get; set; }

        public string IdCtaCble_DesIva { get; set; }

        public string IdCtaCble_Des0 { get; set; }

        public string IdCtaCble_DevIva { get; set; }

        public string IdCtaCble_Dev0 { get; set; }

        public string IdCtaCble_Inventario { get; set; }

        public string IdCtaCble_Costo { get; set; }

        public string IdCtaCble_Gasto_x_cxp { get; set; }

        public string IdCentroCosto { get; set; }

        public string pr_referencia { get; set; }

        public decimal IdRubro { get; set; }

        public string Rubro { get; set; }

        public string Lote { get; set; }

        public in_Producto_Info()
        {
        }
    }
}