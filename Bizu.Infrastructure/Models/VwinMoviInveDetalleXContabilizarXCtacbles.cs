using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinMoviInveDetalleXContabilizarXCtacbles
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    public int Secuencia { get; set; }

    [Column("mv_tipo_movi")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string MvTipoMovi { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("cod_producto")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodProducto { get; set; } = null!;

    [Column("nom_producto")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomProducto { get; set; } = null!;

    [Column("dm_cantidad")]
    public double DmCantidad { get; set; }

    [Column("dm_stock_ante")]
    public double DmStockAnte { get; set; }

    [Column("dm_stock_actu")]
    public double DmStockActu { get; set; }

    [Column("dm_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DmObservacion { get; set; } = null!;

    [Column("mv_costo")]
    public double MvCosto { get; set; }

    [Column("dm_peso")]
    public double? DmPeso { get; set; }

    [Column("cm_fecha")]
    [MaxLength(6)]
    public DateTime CmFecha { get; set; }

    public int? IdTipoCbte { get; set; }

    [Column("nom_tipo_mov_inv")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomTipoMovInv { get; set; } = null!;

    [Column("nom_TipoCbte")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomTipoCbte { get; set; }

    [Column("nom_bodega")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomBodega { get; set; } = null!;

    [Column("nom_sucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomSucursal { get; set; } = null!;

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("IdMotivo_Inv_det")]
    public int? IdMotivoInvDet { get; set; }

    [Column("IdCentro_Costo_x_MoviInv")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCostoXMoviInv { get; set; }

    [Column("IdSubCentro_Costo_x_MoviInv")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdSubCentroCostoXMoviInv { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCategoria { get; set; } = null!;

    public int IdLinea { get; set; }

    public int IdGrupo { get; set; }

    public int IdSubGrupo { get; set; }

    [Column("IdCtaCtble_Inve_x_Bod")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCtbleInveXBod { get; set; }

    [Column("IdCtaCtble_Costo_x_Bod")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCtbleCostoXBod { get; set; }

    [Column("IdCtaCble_Inven_x_Motivo_det")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleInvenXMotivoDet { get; set; }

    [Column("IdCtaCble_Costo_x_Motivo_det")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleCostoXMotivoDet { get; set; }

    [Column("IdCtaCble_Inven_x_Prod")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleInvenXProd { get; set; }

    [Column("IdCtaCble_Costo_x_Prod")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleCostoXProd { get; set; }

    [Column("IdCtaCtble_Inve_x_SubGrupo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCtbleInveXSubGrupo { get; set; }

    [Column("IdCtaCtble_Costo_x_SubGrupo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCtbleCostoXSubGrupo { get; set; }

    [Column("IdMotivo_Inv")]
    public int? IdMotivoInv { get; set; }

    [Column("IdCtaCble_Inven_x_Motivo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleInvenXMotivo { get; set; }

    [Column("IdCtaCble_Costo_x_Motivo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCbleCostoXMotivo { get; set; }

    [Column("es_Inven_o_Consumo")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? EsInvenOConsumo { get; set; }

    [Column("es_Inven_o_Consumo_det")]
    [StringLength(15)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? EsInvenOConsumoDet { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }
}
