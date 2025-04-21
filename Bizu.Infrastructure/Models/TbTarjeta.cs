using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_tarjeta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbTarjeta
{
    [Key]
    public int IdTarjeta { get; set; }

    [Column("tr_Descripcion")]
    [StringLength(100)]
    public string TrDescripcion { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    public int IdBanco { get; set; }

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

    [InverseProperty("IdTarjetaNavigation")]
    public virtual ICollection<TbTarjetaParametro> TbTarjetaParametro { get; set; } = new List<TbTarjetaParametro>();
}
