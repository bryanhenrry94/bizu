using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdBanco", "NumCheque")]
[Table("ba_Talonario_cheques_x_banco")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaTalonarioChequesXBanco
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdBanco { get; set; }

    [Key]
    [Column("Num_cheque")]
    [StringLength(20)]
    public string NumCheque { get; set; } = null!;

    [Column("secuencia")]
    [Precision(18, 0)]
    public decimal? Secuencia { get; set; }

    public bool Usado { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("IdEmpresa_cbtecble_Usado")]
    public int? IdEmpresaCbtecbleUsado { get; set; }

    [Column("IdCbteCble_cbtecble_Usado")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCbtecbleUsado { get; set; }

    [Column("IdTipoCbte_cbtecble_Usado")]
    public int? IdTipoCbteCbtecbleUsado { get; set; }

    [Column("Fecha_uso")]
    [MaxLength(6)]
    public DateTime? FechaUso { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAnulacion { get; set; }

    [StringLength(150)]
    public string? MotivoAnulacion { get; set; }

    [Column("IdUsuario_Anu")]
    [StringLength(20)]
    public string? IdUsuarioAnu { get; set; }

    [ForeignKey("IdEmpresa, IdBanco")]
    [InverseProperty("BaTalonarioChequesXBanco")]
    public virtual BaBancoCuenta BaBancoCuenta { get; set; } = null!;
}
