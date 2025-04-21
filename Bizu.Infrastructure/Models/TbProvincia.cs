using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_provincia")]
[Index("IdPais", Name = "FK_tb_provincia_tb_pais")]
[Index("CodRegion", Name = "FK_tb_provincia_tb_region")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbProvincia
{
    [Key]
    [StringLength(25)]
    public string IdProvincia { get; set; } = null!;

    [Column("Cod_Provincia")]
    [StringLength(25)]
    public string CodProvincia { get; set; } = null!;

    [Column("Descripcion_Prov")]
    [StringLength(50)]
    public string DescripcionProv { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(10)]
    public string IdPais { get; set; } = null!;

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

    [StringLength(100)]
    public string? MotivoAnula { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [Column("Cod_Region")]
    [StringLength(10)]
    public string? CodRegion { get; set; }

    [ForeignKey("CodRegion")]
    [InverseProperty("TbProvincia")]
    public virtual TbRegion? CodRegionNavigation { get; set; }

    [ForeignKey("IdPais")]
    [InverseProperty("TbProvincia")]
    public virtual TbPais IdPaisNavigation { get; set; } = null!;

    [InverseProperty("IdProvinciaNavigation")]
    public virtual ICollection<TbCiudad> TbCiudad { get; set; } = new List<TbCiudad>();

    [InverseProperty("IdProvinciaNavigation")]
    public virtual ICollection<TbContacto> TbContacto { get; set; } = new List<TbContacto>();
}
