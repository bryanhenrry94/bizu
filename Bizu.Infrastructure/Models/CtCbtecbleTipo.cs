using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTipoCbte")]
[Table("ct_cbtecble_tipo")]
[Index("IdEmpresa", "IdTipoCbte", Name = "IX_ct_cbtecble_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtCbtecbleTipo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdTipoCbte { get; set; }

    [StringLength(10)]
    public string CodTipoCbte { get; set; } = null!;

    [Column("tc_TipoCbte")]
    [StringLength(50)]
    public string TcTipoCbte { get; set; } = null!;

    [Column("tc_Estado")]
    [StringLength(1)]
    public string TcEstado { get; set; } = null!;

    [Column("tc_Interno")]
    [StringLength(1)]
    public string TcInterno { get; set; } = null!;

    [Column("tc_Nemonico")]
    [StringLength(10)]
    public string? TcNemonico { get; set; }

    [Column("IdTipoCbte_Anul")]
    public int? IdTipoCbteAnul { get; set; }

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
    public string? MotiAnula { get; set; }

    [InverseProperty("CtCbtecbleTipo")]
    public virtual ICollection<AfParametros> AfParametrosCtCbtecbleTipo { get; set; } = new List<AfParametros>();

    [InverseProperty("CtCbtecbleTipo1")]
    public virtual ICollection<AfParametros> AfParametrosCtCbtecbleTipo1 { get; set; } = new List<AfParametros>();

    [InverseProperty("CtCbtecbleTipo2")]
    public virtual ICollection<AfParametros> AfParametrosCtCbtecbleTipo2 { get; set; } = new List<AfParametros>();

    [InverseProperty("CtCbtecbleTipo3")]
    public virtual ICollection<AfParametros> AfParametrosCtCbtecbleTipo3 { get; set; } = new List<AfParametros>();

    [InverseProperty("CtCbtecbleTipo4")]
    public virtual ICollection<AfParametros> AfParametrosCtCbtecbleTipo4 { get; set; } = new List<AfParametros>();

    [InverseProperty("CtCbtecbleTipo5")]
    public virtual ICollection<AfParametros> AfParametrosCtCbtecbleTipo5 { get; set; } = new List<AfParametros>();

    [InverseProperty("CtCbtecbleTipo6")]
    public virtual ICollection<AfParametros> AfParametrosCtCbtecbleTipo6 { get; set; } = new List<AfParametros>();

    [InverseProperty("CtCbtecbleTipo7")]
    public virtual ICollection<AfParametros> AfParametrosCtCbtecbleTipo7 { get; set; } = new List<AfParametros>();

    [InverseProperty("CtCbtecbleTipo8")]
    public virtual ICollection<AfParametros> AfParametrosCtCbtecbleTipo8 { get; set; } = new List<AfParametros>();

    [InverseProperty("CtCbtecbleTipoNavigation")]
    public virtual ICollection<AfParametros> AfParametrosCtCbtecbleTipoNavigation { get; set; } = new List<AfParametros>();

    [InverseProperty("CtCbtecbleTipo")]
    public virtual ICollection<CajParametro> CajParametroCtCbtecbleTipo { get; set; } = new List<CajParametro>();

    [InverseProperty("CtCbtecbleTipo1")]
    public virtual ICollection<CajParametro> CajParametroCtCbtecbleTipo1 { get; set; } = new List<CajParametro>();

    [InverseProperty("CtCbtecbleTipo2")]
    public virtual ICollection<CajParametro> CajParametroCtCbtecbleTipo2 { get; set; } = new List<CajParametro>();

    [InverseProperty("CtCbtecbleTipoNavigation")]
    public virtual ICollection<CajParametro> CajParametroCtCbtecbleTipoNavigation { get; set; } = new List<CajParametro>();

    [InverseProperty("CtCbtecbleTipo")]
    public virtual ICollection<CpParametros> CpParametrosCtCbtecbleTipo { get; set; } = new List<CpParametros>();

    [InverseProperty("CtCbtecbleTipo1")]
    public virtual ICollection<CpParametros> CpParametrosCtCbtecbleTipo1 { get; set; } = new List<CpParametros>();

    [InverseProperty("CtCbtecbleTipo2")]
    public virtual ICollection<CpParametros> CpParametrosCtCbtecbleTipo2 { get; set; } = new List<CpParametros>();

    [InverseProperty("CtCbtecbleTipo3")]
    public virtual ICollection<CpParametros> CpParametrosCtCbtecbleTipo3 { get; set; } = new List<CpParametros>();

    [InverseProperty("CtCbtecbleTipo4")]
    public virtual ICollection<CpParametros> CpParametrosCtCbtecbleTipo4 { get; set; } = new List<CpParametros>();

    [InverseProperty("CtCbtecbleTipo5")]
    public virtual ICollection<CpParametros> CpParametrosCtCbtecbleTipo5 { get; set; } = new List<CpParametros>();

    [InverseProperty("CtCbtecbleTipo6")]
    public virtual ICollection<CpParametros> CpParametrosCtCbtecbleTipo6 { get; set; } = new List<CpParametros>();

    [InverseProperty("CtCbtecbleTipo7")]
    public virtual ICollection<CpParametros> CpParametrosCtCbtecbleTipo7 { get; set; } = new List<CpParametros>();

    [InverseProperty("CtCbtecbleTipoNavigation")]
    public virtual ICollection<CpParametros> CpParametrosCtCbtecbleTipoNavigation { get; set; } = new List<CpParametros>();

    [InverseProperty("CtCbtecbleTipo")]
    public virtual ICollection<CtCbtecble> CtCbtecble { get; set; } = new List<CtCbtecble>();

    [InverseProperty("CtCbtecbleTipo")]
    public virtual ICollection<CtCbtecblePlantilla> CtCbtecblePlantilla { get; set; } = new List<CtCbtecblePlantilla>();

    [InverseProperty("CtCbtecbleTipo")]
    public virtual ICollection<CtParametro> CtParametroCtCbtecbleTipo { get; set; } = new List<CtParametro>();

    [InverseProperty("CtCbtecbleTipoNavigation")]
    public virtual ICollection<CtParametro> CtParametroCtCbtecbleTipoNavigation { get; set; } = new List<CtParametro>();

    [InverseProperty("CtCbtecbleTipo")]
    public virtual ICollection<CxcParametro> CxcParametroCtCbtecbleTipo { get; set; } = new List<CxcParametro>();

    [InverseProperty("CtCbtecbleTipo1")]
    public virtual ICollection<CxcParametro> CxcParametroCtCbtecbleTipo1 { get; set; } = new List<CxcParametro>();

    [InverseProperty("CtCbtecbleTipoNavigation")]
    public virtual ICollection<CxcParametro> CxcParametroCtCbtecbleTipoNavigation { get; set; } = new List<CxcParametro>();

    [InverseProperty("CtCbtecbleTipo")]
    public virtual ICollection<FaParametro> FaParametroCtCbtecbleTipo { get; set; } = new List<FaParametro>();

    [InverseProperty("CtCbtecbleTipo1")]
    public virtual ICollection<FaParametro> FaParametroCtCbtecbleTipo1 { get; set; } = new List<FaParametro>();

    [InverseProperty("CtCbtecbleTipo2")]
    public virtual ICollection<FaParametro> FaParametroCtCbtecbleTipo2 { get; set; } = new List<FaParametro>();

    [InverseProperty("CtCbtecbleTipo3")]
    public virtual ICollection<FaParametro> FaParametroCtCbtecbleTipo3 { get; set; } = new List<FaParametro>();

    [InverseProperty("CtCbtecbleTipo4")]
    public virtual ICollection<FaParametro> FaParametroCtCbtecbleTipo4 { get; set; } = new List<FaParametro>();

    [InverseProperty("CtCbtecbleTipo5")]
    public virtual ICollection<FaParametro> FaParametroCtCbtecbleTipo5 { get; set; } = new List<FaParametro>();

    [InverseProperty("CtCbtecbleTipo6")]
    public virtual ICollection<FaParametro> FaParametroCtCbtecbleTipo6 { get; set; } = new List<FaParametro>();

    [InverseProperty("CtCbtecbleTipoNavigation")]
    public virtual ICollection<FaParametro> FaParametroCtCbtecbleTipoNavigation { get; set; } = new List<FaParametro>();
}
