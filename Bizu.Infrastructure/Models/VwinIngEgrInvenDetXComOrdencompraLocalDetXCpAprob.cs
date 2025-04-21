using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinIngEgrInvenDetXComOrdencompraLocalDetXCpAprob
{
    [Precision(21, 0)]
    public decimal IdRow { get; set; }

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    public int Secuencia { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("nom_producto")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomProducto { get; set; } = null!;

    [Column("dm_cantidad")]
    public double DmCantidad { get; set; }

    [Column("mv_costo")]
    public double? MvCosto { get; set; }

    [Column("do_porc_des")]
    public double DoPorcDes { get; set; }

    [Column("do_ManejaIva")]
    public bool DoManejaIva { get; set; }

    [Column("dm_stock_ante")]
    public double DmStockAnte { get; set; }

    [Column("dm_stock_actu")]
    public double DmStockActu { get; set; }

    [Column("dm_peso")]
    public double? DmPeso { get; set; }

    [Column("dm_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DmObservacion { get; set; } = null!;

    [Column("dm_precio")]
    public double DmPrecio { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedida { get; set; } = null!;

    [Column("nom_medida")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomMedida { get; set; }

    [Column("nom_sucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomSucursal { get; set; } = null!;

    [Column("nom_bodega")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomBodega { get; set; } = null!;

    [Column("IdEmpresa_oc")]
    public int? IdEmpresaOc { get; set; }

    [Column("IdSucursal_oc")]
    public int? IdSucursalOc { get; set; }

    [Precision(18, 0)]
    public decimal? IdOrdenCompra { get; set; }

    [Column("Secuencia_oc")]
    public int? SecuenciaOc { get; set; }

    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoAproba { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("nom_punto_cargo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPuntoCargo { get; set; }

    [Column("signo")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Signo { get; set; } = null!;

    [Column("nom_tipo_inv")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomTipoInv { get; set; } = null!;

    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [Column("nom_motivo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomMotivo { get; set; }

    [Column("IdEmpresa_inv")]
    public int? IdEmpresaInv { get; set; }

    [Column("IdSucursal_inv")]
    public int? IdSucursalInv { get; set; }

    [Column("IdBodega_inv")]
    public int? IdBodegaInv { get; set; }

    [Column("IdMovi_inven_tipo_inv")]
    public int? IdMoviInvenTipoInv { get; set; }

    [Column("IdNumMovi_inv")]
    [Precision(18, 0)]
    public decimal? IdNumMoviInv { get; set; }

    [Column("secuencia_inv")]
    public int? SecuenciaInv { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("nom_proveedor")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProveedor { get; set; }

    [Column("cm_fecha")]
    [MaxLength(6)]
    public DateTime CmFecha { get; set; }

    [Column("Por_Iva")]
    public double PorIva { get; set; }

    public int Dias { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTerminoPago { get; set; } = null!;

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Descripcion { get; set; } = null!;

    [Column("es_Inven_o_Consumo")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? EsInvenOConsumo { get; set; }

    [Column("IdCtaCtble_Gasto_x_cxp_x_Produc")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCtbleGastoXCxpXProduc { get; set; }

    [Column("IdCtaCble_Inven_x_Produc")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleInvenXProduc { get; set; }

    [Column("IdCtaCtble_Inve_x_Bodega")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCtbleInveXBodega { get; set; }

    [Column("IdCtaCble_Inven_x_Motivo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleInvenXMotivo { get; set; }

    [Column("IdCtaCble_Costo_x_Motivo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleCostoXMotivo { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCategoria { get; set; } = null!;

    public int IdLinea { get; set; }

    public int IdGrupo { get; set; }

    public int IdSubGrupo { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("oc_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string OcObservacion { get; set; } = null!;

    public int TieneDiario { get; set; }
}
