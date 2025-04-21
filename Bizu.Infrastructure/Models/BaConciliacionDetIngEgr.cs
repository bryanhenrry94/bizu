using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdConciliacion", "Secuencia")]
[Table("ba_Conciliacion_det_IngEgr")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaConciliacionDetIngEgr
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdConciliacion { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Column("tipo_IngEgr")]
    [StringLength(1)]
    public string TipoIngEgr { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    public int IdTipocbte { get; set; }

    public int SecuenciaCbteCble { get; set; }

    [Column("checked")]
    public bool Checked { get; set; }

    [StringLength(1)]
    public string? Estado { get; set; }

    [StringLength(50)]
    public string? IdUsuario { get; set; }

    [Column("IdUsuario_Anu")]
    [StringLength(50)]
    public string? IdUsuarioAnu { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAnulacion { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [StringLength(250)]
    public string? MotivoAnulacion { get; set; }

    [ForeignKey("IdEmpresa, IdConciliacion")]
    [InverseProperty("BaConciliacionDetIngEgr")]
    public virtual BaConciliacion BaConciliacion { get; set; } = null!;
}
