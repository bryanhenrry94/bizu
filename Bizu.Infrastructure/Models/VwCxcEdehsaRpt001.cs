using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxcEdehsaRpt001
{
    [Precision(21, 0)]
    public decimal IdRow { get; set; }

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int? IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    [Column("vt_tipoDoc")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtTipoDoc { get; set; }

    [Column("numDocumento")]
    [StringLength(125)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumDocumento { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("vt_fecha")]
    [MaxLength(6)]
    public DateTime VtFecha { get; set; }

    [Column("vt_plazo")]
    [Precision(18, 0)]
    public decimal? VtPlazo { get; set; }

    [Column("vt_fech_venc")]
    [MaxLength(6)]
    public DateTime? VtFechVenc { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("vt_total")]
    public double? VtTotal { get; set; }

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeCedulaRuc { get; set; } = null!;

    [StringLength(10)]
    public string Tipo { get; set; } = null!;

    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoCobro { get; set; }

    [Precision(18, 0)]
    public decimal? IdCobro { get; set; }

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCobroTipo { get; set; } = null!;

    [Column("dc_TipoDocumento")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DcTipoDocumento { get; set; }

    [Column("Idtipo_cliente")]
    public int IdtipoCliente { get; set; }

    [Column("Descripcion_tip_cliente")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DescripcionTipCliente { get; set; } = null!;

    [Column("vt_Observacion", TypeName = "text")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string VtObservacion { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("vt_referencia")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtReferencia { get; set; }

    [Column("NIVEL")]
    public long Nivel { get; set; }
}
