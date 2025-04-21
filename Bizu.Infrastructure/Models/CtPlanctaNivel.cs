using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdNivelCta")]
[Table("ct_plancta_nivel")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtPlanctaNivel
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdNivelCta { get; set; }

    [Column("nv_NumDigitos")]
    public int NvNumDigitos { get; set; }

    [Column("nv_Descripcion")]
    [StringLength(50)]
    public string NvDescripcion { get; set; } = null!;

    [StringLength(1)]
    public string? Estado { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transaccion")]
    [MaxLength(6)]
    public DateTime? FechaTransaccion { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltModi { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(100)]
    public string? MotivoAnulacion { get; set; }

    [InverseProperty("CtPlanctaNivel")]
    public virtual ICollection<CtPlancta> CtPlancta { get; set; } = new List<CtPlancta>();
}
