using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdUsuario", "NomPc", "Secuencia")]
[Table("tbCXP_Rpt005")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbCxpRpt005
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [Key]
    [Column("nom_pc")]
    [StringLength(50)]
    public string NomPc { get; set; } = null!;

    [Key]
    [Column("secuencia")]
    [Precision(18, 0)]
    public decimal Secuencia { get; set; }

    public DateOnly? FechaDoc { get; set; }

    public DateOnly? FechaDocVence { get; set; }

    [Column("NDocumento")]
    [StringLength(100)]
    public string? Ndocumento { get; set; }

    [StringLength(150)]
    public string? Documento { get; set; }

    [StringLength(250)]
    public string? Proveedor { get; set; }

    [StringLength(500)]
    public string? Observacion { get; set; }

    public double? Valor { get; set; }

    [Precision(18, 0)]
    public decimal? IdProveedor { get; set; }

    [Column("orden")]
    [StringLength(50)]
    public string? Orden { get; set; }

    [Column("orden2")]
    [StringLength(50)]
    public string? Orden2 { get; set; }

    [Column("IdCbteCble_OG")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleOg { get; set; }

    [Column("Fecha_OG")]
    public DateOnly? FechaOg { get; set; }
}
