using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_parroquia")]
[Index("IdCiudadCanton", Name = "FK_tb_parroquia_tb_ciudad")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbParroquia
{
    [Key]
    [StringLength(25)]
    public string IdParroquia { get; set; } = null!;

    [Column("cod_parroquia")]
    [StringLength(50)]
    public string CodParroquia { get; set; } = null!;

    [Column("nom_parroquia")]
    [StringLength(150)]
    public string NomParroquia { get; set; } = null!;

    [Column("estado")]
    public bool Estado { get; set; }

    [Column("IdCiudad_Canton")]
    [StringLength(25)]
    public string IdCiudadCanton { get; set; } = null!;

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

    [StringLength(50)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(150)]
    public string? MotivoAnula { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [ForeignKey("IdCiudadCanton")]
    [InverseProperty("TbParroquia")]
    public virtual TbCiudad IdCiudadCantonNavigation { get; set; } = null!;
}
