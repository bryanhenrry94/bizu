using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdNivel")]
[Table("ct_centro_costo_nivel")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtCentroCostoNivel
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdNivel { get; set; }

    [Column("ni_descripcion")]
    [StringLength(20)]
    public string NiDescripcion { get; set; } = null!;

    [Column("ni_digitos")]
    public byte NiDigitos { get; set; }

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

    [InverseProperty("CtCentroCostoNivel")]
    public virtual ICollection<CtCentroCosto> CtCentroCosto { get; set; } = new List<CtCentroCosto>();

    [ForeignKey("IdEmpresa")]
    [InverseProperty("CtCentroCostoNivel")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;
}
