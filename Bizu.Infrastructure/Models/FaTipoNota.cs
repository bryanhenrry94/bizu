using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("fa_TipoNota")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaTipoNota
{
    [Key]
    public int IdTipoNota { get; set; }

    [StringLength(20)]
    public string CodTipoNota { get; set; } = null!;

    [StringLength(1)]
    public string Tipo { get; set; } = null!;

    [Column("No_Descripcion")]
    [StringLength(150)]
    public string NoDescripcion { get; set; } = null!;

    [StringLength(20)]
    public string Nemonico { get; set; } = null!;

    [StringLength(1)]
    public string InternoSis { get; set; } = null!;

    [Column("SeDeclaraSRI")]
    [StringLength(1)]
    public string SeDeclaraSri { get; set; } = null!;

    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

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

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(200)]
    public string? MotiAnula { get; set; }

    [InverseProperty("IdTipoNotaCreditoNavigation")]
    public virtual ICollection<CxcCobro> CxcCobro { get; set; } = new List<CxcCobro>();

    [InverseProperty("PaTipoNdXCheqProtestadoNavigation")]
    public virtual ICollection<CxcParametro> CxcParametro { get; set; } = new List<CxcParametro>();

    [InverseProperty("IdTipoNotaNavigation")]
    public virtual ICollection<FaNotaCreDeb> FaNotaCreDeb { get; set; } = new List<FaNotaCreDeb>();

    [InverseProperty("PaIdTipoNotaNcXAnulacionNavigation")]
    public virtual ICollection<FaParametro> FaParametro { get; set; } = new List<FaParametro>();

    [InverseProperty("IdTipoNotaNavigation")]
    public virtual ICollection<FaTipoNotaXEmpresaXSucursal> FaTipoNotaXEmpresaXSucursal { get; set; } = new List<FaTipoNotaXEmpresaXSucursal>();
}
