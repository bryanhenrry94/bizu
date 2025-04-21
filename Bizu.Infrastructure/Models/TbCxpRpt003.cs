using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdUsuario", "NomPc", "IdProveedor")]
[Table("tbCXP_Rpt003")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbCxpRpt003
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Key]
    [Column("nom_pc")]
    [StringLength(50)]
    public string NomPc { get; set; } = null!;

    [Column("saldoProveedor")]
    public double? SaldoProveedor { get; set; }

    [Column("nombreProveedor")]
    [StringLength(150)]
    public string? NombreProveedor { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }
}
