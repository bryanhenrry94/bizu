using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdDescuento")]
[Table("fa_descuento")]
[Index("IdEmpresa", "DeIdCtaCble", Name = "FK_fa_descuento_ct_plancta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaDescuento
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdDescuento { get; set; }

    [Column("de_nombre")]
    [StringLength(200)]
    public string DeNombre { get; set; } = null!;

    [Column("de_IdCtaCble")]
    [StringLength(20)]
    public string DeIdCtaCble { get; set; } = null!;

    [Column("de_porcentaje")]
    public double DePorcentaje { get; set; }

    [Column("de_observacion")]
    [StringLength(200)]
    public string? DeObservacion { get; set; }

    public bool Estado { get; set; }

    [StringLength(50)]
    public string? IdUsuarioCreacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaCreacion { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(200)]
    public string? MotiAnula { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [ForeignKey("IdEmpresa, DeIdCtaCble")]
    [InverseProperty("FaDescuento")]
    public virtual CtPlancta CtPlancta { get; set; } = null!;

    [InverseProperty("FaDescuento")]
    public virtual ICollection<FaFacturaDetXFaDescuento> FaFacturaDetXFaDescuento { get; set; } = new List<FaFacturaDetXFaDescuento>();
}
