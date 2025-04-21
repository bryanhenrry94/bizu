using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("caj_parametro")]
[Index("IdEmpresa", "IdTipoCbteCbleMoviCajaIng", Name = "FK_caj_parametro_ct_cbtecble_tipo")]
[Index("IdEmpresa", "IdTipoCbteCbleMoviCajaEgr", Name = "FK_caj_parametro_ct_cbtecble_tipo1")]
[Index("IdEmpresa", "IdTipoCbteCbleMoviCajaIngAnu", Name = "FK_caj_parametro_ct_cbtecble_tipo2")]
[Index("IdEmpresa", "IdTipoCbteCbleMoviCajaEgrAnu", Name = "FK_caj_parametro_ct_cbtecble_tipo3")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CajParametro
{
    [Key]
    public int IdEmpresa { get; set; }

    [Column("IdTipoCbteCble_MoviCaja_Ing")]
    public int IdTipoCbteCbleMoviCajaIng { get; set; }

    [Column("IdTipoCbteCble_MoviCaja_Egr")]
    public int IdTipoCbteCbleMoviCajaEgr { get; set; }

    [Column("IdTipoCbteCble_MoviCaja_Ing_Anu")]
    public int IdTipoCbteCbleMoviCajaIngAnu { get; set; }

    [Column("IdTipoCbteCble_MoviCaja_Egr_Anu")]
    public int IdTipoCbteCbleMoviCajaEgrAnu { get; set; }

    [Column("IdTipo_movi_ing_x_reposicion")]
    public int? IdTipoMoviIngXReposicion { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [ForeignKey("IdEmpresa, IdTipoCbteCbleMoviCajaEgr")]
    [InverseProperty("CajParametroCtCbtecbleTipo")]
    public virtual CtCbtecbleTipo CtCbtecbleTipo { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdTipoCbteCbleMoviCajaIng")]
    [InverseProperty("CajParametroCtCbtecbleTipo1")]
    public virtual CtCbtecbleTipo CtCbtecbleTipo1 { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdTipoCbteCbleMoviCajaIngAnu")]
    [InverseProperty("CajParametroCtCbtecbleTipo2")]
    public virtual CtCbtecbleTipo CtCbtecbleTipo2 { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdTipoCbteCbleMoviCajaEgrAnu")]
    [InverseProperty("CajParametroCtCbtecbleTipoNavigation")]
    public virtual CtCbtecbleTipo CtCbtecbleTipoNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa")]
    [InverseProperty("CajParametro")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;
}
