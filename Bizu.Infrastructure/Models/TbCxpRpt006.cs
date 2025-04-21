using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdUsuario", "NomPc", "NDoc", "Nautorizacion", "Documento", "IdProveedor", "IdCbte", "Secuencia")]
[Table("tbCXP_Rpt006")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbCxpRpt006
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Key]
    [Column("nom_pc")]
    [StringLength(50)]
    public string NomPc { get; set; } = null!;

    [Key]
    [Column("nDoc")]
    [StringLength(150)]
    public string NDoc { get; set; } = null!;

    [Key]
    [Column("NAutorizacion")]
    [StringLength(50)]
    public string Nautorizacion { get; set; } = null!;

    [Key]
    [StringLength(150)]
    public string Documento { get; set; } = null!;

    [Key]
    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCbte { get; set; }

    [Key]
    [Column("secuencia")]
    public int Secuencia { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    public DateOnly? Fecha { get; set; }

    public DateOnly? FechaVence { get; set; }

    [Column("pr_CedulaRuc")]
    [StringLength(50)]
    public string? PrCedulaRuc { get; set; }

    [StringLength(250)]
    public string? Proveedor { get; set; }

    [StringLength(500)]
    public string? Observacion { get; set; }

    public double? SubtotalIva { get; set; }

    public double? SubtotalSinIva { get; set; }

    [Column("baseImponible")]
    public double? BaseImponible { get; set; }

    public double? Total { get; set; }

    public DateOnly? FechaCbte { get; set; }
}
