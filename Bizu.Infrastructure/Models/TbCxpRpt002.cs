using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "Secuencia")]
[Table("tbCXP_Rpt002")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbCxpRpt002
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("secuencia")]
    [Precision(18, 0)]
    public decimal Secuencia { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("IdOrden_giro_Tipo")]
    [StringLength(6)]
    public string? IdOrdenGiroTipo { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleOgiro { get; set; }

    [Column("co_serie")]
    [StringLength(10)]
    public string? CoSerie { get; set; }

    [Column("co_factura")]
    [StringLength(50)]
    public string? CoFactura { get; set; }

    [Column("co_FechaFactura")]
    [MaxLength(6)]
    public DateTime? CoFechaFactura { get; set; }

    [Column("co_FechaFactura_vct")]
    [MaxLength(6)]
    public DateTime? CoFechaFacturaVct { get; set; }

    [Column("co_plazo")]
    public int? CoPlazo { get; set; }

    [Column("xvencer")]
    public double? Xvencer { get; set; }

    [Column("1-30")]
    public double? _130 { get; set; }

    [Column("31-60")]
    public double? _3160 { get; set; }

    [Column("61-90")]
    public double? _6190 { get; set; }

    [Column(">90")]
    public double? _90 { get; set; }

    [Column("total")]
    public double? Total { get; set; }

    [Column("saldo")]
    public double? Saldo { get; set; }

    [Column("detalle")]
    [StringLength(1000)]
    public string? Detalle { get; set; }

    [StringLength(500)]
    public string? NomProveedor { get; set; }

    [Precision(18, 0)]
    public decimal? IdProveedor { get; set; }
}
