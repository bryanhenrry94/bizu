using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTipoFlujo")]
[Table("ba_TipoFlujo")]
[Index("IdEmpresa", "IdTipoFlujoPadre", Name = "FK_ba_TipoFlujo_ba_TipoFlujo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaTipoFlujo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdTipoFlujo { get; set; }

    [Precision(18, 0)]
    public decimal? IdTipoFlujoPadre { get; set; }

    [StringLength(50)]
    public string Descricion { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

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

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(200)]
    public string? MotiAnula { get; set; }

    [StringLength(3)]
    public string? Tipo { get; set; }

    [Column("cod_flujo")]
    [StringLength(50)]
    public string? CodFlujo { get; set; }

    [InverseProperty("BaTipoFlujo")]
    public virtual ICollection<BaCbteBan> BaCbteBan { get; set; } = new List<BaCbteBan>();

    [InverseProperty("BaTipoFlujo")]
    public virtual ICollection<BaPrestamo> BaPrestamo { get; set; } = new List<BaPrestamo>();

    [ForeignKey("IdEmpresa, IdTipoFlujoPadre")]
    [InverseProperty("InverseBaTipoFlujoNavigation")]
    public virtual BaTipoFlujo? BaTipoFlujoNavigation { get; set; }

    [InverseProperty("BaTipoFlujo")]
    public virtual ICollection<CajCajaMovimiento> CajCajaMovimiento { get; set; } = new List<CajCajaMovimiento>();

    [InverseProperty("BaTipoFlujo")]
    public virtual ICollection<CajCajaMovimientoDet> CajCajaMovimientoDet { get; set; } = new List<CajCajaMovimientoDet>();

    [InverseProperty("BaTipoFlujo")]
    public virtual ICollection<CpConciliacionCaja> CpConciliacionCaja { get; set; } = new List<CpConciliacionCaja>();

    [InverseProperty("BaTipoFlujo")]
    public virtual ICollection<CpNotaDebCre> CpNotaDebCre { get; set; } = new List<CpNotaDebCre>();

    [InverseProperty("BaTipoFlujo")]
    public virtual ICollection<CpOrdenGiro> CpOrdenGiro { get; set; } = new List<CpOrdenGiro>();

    [ForeignKey("IdEmpresa")]
    [InverseProperty("BaTipoFlujo")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [InverseProperty("BaTipoFlujoNavigation")]
    public virtual ICollection<BaTipoFlujo> InverseBaTipoFlujoNavigation { get; set; } = new List<BaTipoFlujo>();
}
