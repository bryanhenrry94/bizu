using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdRecibo")]
[Table("Caj_Talonario_Recibo")]
[Index("IdEmpresa", "IdSucursal", "IdPuntoVta", "NumRecibo", "IdTipoDocuCat", Name = "IX_Caj_Talonario_Recibo", IsUnique = true)]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CajTalonarioRecibo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdRecibo { get; set; }

    public int IdSucursal { get; set; }

    public int IdPuntoVta { get; set; }

    [Column("IdTipo_Docu_cat")]
    [StringLength(25)]
    public string IdTipoDocuCat { get; set; } = null!;

    [Column("Num_Recibo")]
    [StringLength(50)]
    public string NumRecibo { get; set; } = null!;

    public bool Usado { get; set; }

    public bool Estado { get; set; }

    [StringLength(50)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [Column("IdUsuario_Responsable")]
    [StringLength(50)]
    public string? IdUsuarioResponsable { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(300)]
    public string? MotivoAnu { get; set; }
}
