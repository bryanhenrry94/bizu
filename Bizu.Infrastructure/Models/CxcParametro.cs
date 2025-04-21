using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cxc_Parametro")]
[Index("IdEmpresa", "PaIdCajaXCobrosXCxc", Name = "FK_cxc_Parametro_caj_Caja")]
[Index("IdEmpresa", "PaIdCajaXDefault", Name = "FK_cxc_Parametro_caj_Caja1")]
[Index("PaIdTipoMoviCajaXCobrosXCliente", Name = "FK_cxc_Parametro_caj_Caja_Movimiento_Tipo")]
[Index("IdEmpresa", "PaIdTipoCbteCbleCxC", Name = "FK_cxc_Parametro_ct_cbtecble_tipo")]
[Index("IdEmpresa", "PaIdTipoCbteCbleCxCAnu", Name = "FK_cxc_Parametro_ct_cbtecble_tipo1")]
[Index("IdEmpresa", "PaIdTipoCbteXConciliacion", Name = "FK_cxc_Parametro_ct_cbtecble_tipo2")]
[Index("PaIdCobroTipoComisionTc", Name = "FK_cxc_Parametro_cxc_cobro_tipo")]
[Index("PaIdCobroTipoDefault", Name = "FK_cxc_Parametro_cxc_cobro_tipo1")]
[Index("PaTipoNdXCheqProtestado", Name = "FK_cxc_Parametro_fa_TipoNota")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcParametro
{
    [Key]
    public int IdEmpresa { get; set; }

    [Column("pa_tipoND_x_CheqProtestado")]
    public int PaTipoNdXCheqProtestado { get; set; }

    [Column("pa_IdCaja_x_cobros_x_CXC")]
    public int? PaIdCajaXCobrosXCxc { get; set; }

    [Column("pa_IdTipoMoviCaja_x_Cobros_x_cliente")]
    public int? PaIdTipoMoviCajaXCobrosXCliente { get; set; }

    [Column("pa_IdTipoCbteCble_CxC")]
    public int? PaIdTipoCbteCbleCxC { get; set; }

    [Column("pa_IdTipoCbteCble_CxC_ANU")]
    public int? PaIdTipoCbteCbleCxCAnu { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [Column("pa_IdCaja_x_Default")]
    public int? PaIdCajaXDefault { get; set; }

    [Column("pa_IdTipoCbte_x_conciliacion")]
    public int? PaIdTipoCbteXConciliacion { get; set; }

    [Column("pa_IdCobro_tipo_Comision_TC")]
    [StringLength(20)]
    public string? PaIdCobroTipoComisionTc { get; set; }

    [Column("pa_IdCobro_tipo_default")]
    [StringLength(20)]
    public string? PaIdCobroTipoDefault { get; set; }

    [Column("IdCtaCble_x_anticipo")]
    [StringLength(20)]
    public string? IdCtaCbleXAnticipo { get; set; }

    [ForeignKey("IdEmpresa, PaIdCajaXCobrosXCxc")]
    [InverseProperty("CxcParametroCajCaja")]
    public virtual CajCaja? CajCaja { get; set; }

    [ForeignKey("IdEmpresa, PaIdCajaXDefault")]
    [InverseProperty("CxcParametroCajCajaNavigation")]
    public virtual CajCaja? CajCajaNavigation { get; set; }

    [ForeignKey("IdEmpresa, PaIdTipoCbteCbleCxC")]
    [InverseProperty("CxcParametroCtCbtecbleTipo")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipo { get; set; }

    [ForeignKey("IdEmpresa, PaIdTipoCbteXConciliacion")]
    [InverseProperty("CxcParametroCtCbtecbleTipo1")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipo1 { get; set; }

    [ForeignKey("IdEmpresa, PaIdTipoCbteCbleCxCAnu")]
    [InverseProperty("CxcParametroCtCbtecbleTipoNavigation")]
    public virtual CtCbtecbleTipo? CtCbtecbleTipoNavigation { get; set; }

    [ForeignKey("IdEmpresa")]
    [InverseProperty("CxcParametro")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("PaIdCobroTipoComisionTc")]
    [InverseProperty("CxcParametroPaIdCobroTipoComisionTcNavigation")]
    public virtual CxcCobroTipo? PaIdCobroTipoComisionTcNavigation { get; set; }

    [ForeignKey("PaIdCobroTipoDefault")]
    [InverseProperty("CxcParametroPaIdCobroTipoDefaultNavigation")]
    public virtual CxcCobroTipo? PaIdCobroTipoDefaultNavigation { get; set; }

    [ForeignKey("PaIdTipoMoviCajaXCobrosXCliente")]
    [InverseProperty("CxcParametro")]
    public virtual CajCajaMovimientoTipo? PaIdTipoMoviCajaXCobrosXClienteNavigation { get; set; }

    [ForeignKey("PaTipoNdXCheqProtestado")]
    [InverseProperty("CxcParametro")]
    public virtual FaTipoNota PaTipoNdXCheqProtestadoNavigation { get; set; } = null!;
}
