using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_ciudad")]
[Index("IdProvincia", Name = "FK_tb_ciudad_tb_provincia")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbCiudad
{
    [Key]
    [StringLength(25)]
    public string IdCiudad { get; set; } = null!;

    [Column("Cod_Ciudad")]
    [StringLength(25)]
    public string CodCiudad { get; set; } = null!;

    [Column("Descripcion_Ciudad")]
    [StringLength(50)]
    public string DescripcionCiudad { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(25)]
    public string IdProvincia { get; set; } = null!;

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

    [InverseProperty("CbCiudadChqNavigation")]
    public virtual ICollection<BaCbteBan> BaCbteBan { get; set; } = new List<BaCbteBan>();

    [InverseProperty("CiudadDefaultParaCrearChequesNavigation")]
    public virtual ICollection<BaParametros> BaParametros { get; set; } = new List<BaParametros>();

    [InverseProperty("IdCiudadNavigation")]
    public virtual ICollection<CpProveedor> CpProveedor { get; set; } = new List<CpProveedor>();

    [InverseProperty("IdCiudadNavigation")]
    public virtual ICollection<FaCliente> FaCliente { get; set; } = new List<FaCliente>();

    [ForeignKey("IdProvincia")]
    [InverseProperty("TbCiudad")]
    public virtual TbProvincia IdProvinciaNavigation { get; set; } = null!;

    [InverseProperty("IdCiudadNavigation")]
    public virtual ICollection<TbContacto> TbContacto { get; set; } = new List<TbContacto>();

    [InverseProperty("IdCiudadCantonNavigation")]
    public virtual ICollection<TbParroquia> TbParroquia { get; set; } = new List<TbParroquia>();
}
