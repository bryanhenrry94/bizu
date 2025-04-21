using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("st_CatalogoTipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class StCatalogoTipo
{
    [Key]
    public int IdTipoCatalogo { get; set; }

    [StringLength(10)]
    public string Codigo { get; set; } = null!;

    [Column("tc_Descripcion")]
    [StringLength(50)]
    public string? TcDescripcion { get; set; }

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

    [InverseProperty("IdTipoCatalogoNavigation")]
    public virtual ICollection<StCatalogo> StCatalogo { get; set; } = new List<StCatalogo>();
}
