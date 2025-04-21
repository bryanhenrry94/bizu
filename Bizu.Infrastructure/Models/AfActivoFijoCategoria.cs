using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCategoriaAf")]
[Table("Af_Activo_fijo_Categoria")]
[Index("IdEmpresa", "IdActivoFijoTipo", Name = "FK_Af_Activo_fijo_Categoria_Af_Activo_fijo_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfActivoFijoCategoria
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdCategoriaAF")]
    public int IdCategoriaAf { get; set; }

    public int IdActivoFijoTipo { get; set; }

    [Column("CodCategoriaAF")]
    [StringLength(50)]
    public string? CodCategoriaAf { get; set; }

    [StringLength(500)]
    public string Descripcion { get; set; } = null!;

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(100)]
    public string? MotiAnula { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("cod_tipo")]
    [StringLength(20)]
    public string? CodTipo { get; set; }

    [InverseProperty("AfActivoFijoCategoria")]
    public virtual ICollection<AfActivoFijo> AfActivoFijo { get; set; } = new List<AfActivoFijo>();

    [ForeignKey("IdEmpresa, IdActivoFijoTipo")]
    [InverseProperty("AfActivoFijoCategoria")]
    public virtual AfActivoFijoTipo AfActivoFijoTipo { get; set; } = null!;
}
