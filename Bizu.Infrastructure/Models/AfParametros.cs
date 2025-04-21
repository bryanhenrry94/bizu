using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("Af_Parametros")]
[Index("IdEmpresa", "IdTipoCbte", Name = "FK_Af_Parametros_ct_cbtecble_tipo")]
[Index("IdEmpresa", "IdTipoCbteMejora", Name = "FK_Af_Parametros_ct_cbtecble_tipo1")]
[Index("IdEmpresa", "IdTipoCbteBaja", Name = "FK_Af_Parametros_ct_cbtecble_tipo2")]
[Index("IdEmpresa", "IdTipoCbteVenta", Name = "FK_Af_Parametros_ct_cbtecble_tipo3")]
[Index("IdEmpresa", "IdTipoCbteRetiro", Name = "FK_Af_Parametros_ct_cbtecble_tipo4")]
[Index("IdEmpresa", "IdTipoCbteMejoraAnulacion", Name = "FK_Af_Parametros_ct_cbtecble_tipo5")]
[Index("IdEmpresa", "IdTipoCbteBajaAnulacion", Name = "FK_Af_Parametros_ct_cbtecble_tipo6")]
[Index("IdEmpresa", "IdTipoCbteVentaAnulacion", Name = "FK_Af_Parametros_ct_cbtecble_tipo7")]
[Index("IdEmpresa", "IdTipoCbteRetiroAnulacion", Name = "FK_Af_Parametros_ct_cbtecble_tipo8")]
[Index("IdEmpresa", "IdTipoCbteDepAcumAnulacion", Name = "FK_Af_Parametros_ct_cbtecble_tipo9")]
[Index("IdEmpresa", "IdCtaCbleActivo", Name = "FK_Af_Parametros_ct_plancta")]
[Index("IdEmpresa", "IdCtaCbleDepAcum", Name = "FK_Af_Parametros_ct_plancta1")]
[Index("IdEmpresa", "IdCtaCbleGastosDepre", Name = "FK_Af_Parametros_ct_plancta2")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfParametros
{
    [Key]
    public int IdEmpresa { get; set; }

    public int IdTipoCbte { get; set; }

    public int IdTipoCbteMejora { get; set; }

    public int IdTipoCbteBaja { get; set; }

    public int IdTipoCbteVenta { get; set; }

    public int IdTipoCbteRetiro { get; set; }

    [Column("IdCtaCble_Activo")]
    [StringLength(20)]
    public string? IdCtaCbleActivo { get; set; }

    [Column("IdCtaCble_Dep_Acum")]
    [StringLength(20)]
    public string? IdCtaCbleDepAcum { get; set; }

    [Column("IdCtaCble_Gastos_Depre")]
    [StringLength(20)]
    public string? IdCtaCbleGastosDepre { get; set; }

    [StringLength(20)]
    public string FormaContabiliza { get; set; } = null!;

    [Column("IdTipoCbteMejora_Anulacion")]
    public int IdTipoCbteMejoraAnulacion { get; set; }

    [Column("IdTipoCbteBaja_Anulacion")]
    public int IdTipoCbteBajaAnulacion { get; set; }

    [Column("IdTipoCbteVenta_Anulacion")]
    public int IdTipoCbteVentaAnulacion { get; set; }

    [Column("IdTipoCbteRetiro_Anulacion")]
    public int IdTipoCbteRetiroAnulacion { get; set; }

    [Column("IdTipoCbteDep_Acum_Anulacion")]
    public int IdTipoCbteDepAcumAnulacion { get; set; }

    [ForeignKey("IdEmpresa, IdTipoCbte")]
    [InverseProperty("AfParametrosCtCbtecbleTipo")]
    public virtual CtCbtecbleTipo CtCbtecbleTipo { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdTipoCbteBajaAnulacion")]
    [InverseProperty("AfParametrosCtCbtecbleTipo1")]
    public virtual CtCbtecbleTipo CtCbtecbleTipo1 { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdTipoCbteDepAcumAnulacion")]
    [InverseProperty("AfParametrosCtCbtecbleTipo2")]
    public virtual CtCbtecbleTipo CtCbtecbleTipo2 { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdTipoCbteMejora")]
    [InverseProperty("AfParametrosCtCbtecbleTipo3")]
    public virtual CtCbtecbleTipo CtCbtecbleTipo3 { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdTipoCbteMejoraAnulacion")]
    [InverseProperty("AfParametrosCtCbtecbleTipo4")]
    public virtual CtCbtecbleTipo CtCbtecbleTipo4 { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdTipoCbteRetiro")]
    [InverseProperty("AfParametrosCtCbtecbleTipo5")]
    public virtual CtCbtecbleTipo CtCbtecbleTipo5 { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdTipoCbteRetiroAnulacion")]
    [InverseProperty("AfParametrosCtCbtecbleTipo6")]
    public virtual CtCbtecbleTipo CtCbtecbleTipo6 { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdTipoCbteVenta")]
    [InverseProperty("AfParametrosCtCbtecbleTipo7")]
    public virtual CtCbtecbleTipo CtCbtecbleTipo7 { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdTipoCbteVentaAnulacion")]
    [InverseProperty("AfParametrosCtCbtecbleTipo8")]
    public virtual CtCbtecbleTipo CtCbtecbleTipo8 { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdTipoCbteBaja")]
    [InverseProperty("AfParametrosCtCbtecbleTipoNavigation")]
    public virtual CtCbtecbleTipo CtCbtecbleTipoNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCtaCbleActivo")]
    [InverseProperty("AfParametrosCtPlancta")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleGastosDepre")]
    [InverseProperty("AfParametrosCtPlancta1")]
    public virtual CtPlancta? CtPlancta1 { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleDepAcum")]
    [InverseProperty("AfParametrosCtPlanctaNavigation")]
    public virtual CtPlancta? CtPlanctaNavigation { get; set; }

    [ForeignKey("IdEmpresa")]
    [InverseProperty("AfParametros")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;
}
