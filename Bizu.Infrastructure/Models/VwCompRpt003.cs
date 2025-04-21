using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCompRpt003
{
    [Precision(21, 0)]
    public decimal IdRow { get; set; }

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int? IdBodega { get; set; }

    [Column("IdMovi_inven_tipo")]
    public int IdMoviInvenTipo { get; set; }

    [Precision(18, 0)]
    public decimal IdNumMovi { get; set; }

    [Column("cm_tipo")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CmTipo { get; set; }

    [Column("cm_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmObservacion { get; set; } = null!;

    [Column("cm_fecha")]
    [MaxLength(6)]
    public DateTime CmFecha { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BoDescripcion { get; set; } = null!;

    [Column("tm_descripcion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TmDescripcion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("pr_codigo")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrCodigo { get; set; } = null!;

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    [Column("dm_cantidad")]
    public double DmCantidad { get; set; }

    [Column("mv_costo")]
    public double MvCosto { get; set; }

    public double SubTotal { get; set; }

    [Column("dm_precio")]
    public double DmPrecio { get; set; }

    [Column("dm_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DmObservacion { get; set; } = null!;

    [Column("dm_peso")]
    public double? DmPeso { get; set; }

    [Column("em_nombre")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmNombre { get; set; } = null!;

    [Column("em_ruc")]
    [StringLength(13)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmRuc { get; set; } = null!;

    [Column("em_telefonos")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? EmTelefonos { get; set; }

    [Column("em_direccion")]
    [StringLength(300)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmDireccion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("pr_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrNombre { get; set; }

    [Column("do_ManejaIva")]
    public bool DoManejaIva { get; set; }

    [Precision(18, 0)]
    public decimal IdOrdenCompra { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedida { get; set; } = null!;

    [Column("nom_unidad")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomUnidad { get; set; } = null!;

    [Column("IdMotivo_Inv")]
    public int? IdMotivoInv { get; set; }

    [Column("Desc_mov_inv")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DescMovInv { get; set; }

    [Column("dm_cantidad_sinConversion")]
    public double DmCantidadSinConversion { get; set; }

    [Column("IdUnidadMedida_sinConversion")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUnidadMedidaSinConversion { get; set; } = null!;

    [Column("nom_unidad_sinConversion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomUnidadSinConversion { get; set; } = null!;

    [Column("mv_costo_sinConversion")]
    public double? MvCostoSinConversion { get; set; }

    [Column("SubTotal_sinConversion")]
    public double? SubTotalSinConversion { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodMoviInven { get; set; } = null!;

    public bool? EsDocumentoAutorizado { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumGuia { get; set; }

    [Column("numDocumento")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumDocumento { get; set; }

    [Column("Fecha_registro")]
    [MaxLength(6)]
    public DateTime? FechaRegistro { get; set; }

    [Column("IdUsuario_registro")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioRegistro { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }
}
