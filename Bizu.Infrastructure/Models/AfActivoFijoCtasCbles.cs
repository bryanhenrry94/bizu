using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdActivoFijo", "IdTipoCuenta", "Secuencia")]
[Table("Af_Activo_fijo_CtasCbles")]
[Index("IdTipoCuenta", Name = "FK_Af_Activo_fijo_CtasCbles_Af_Activo_fijo_CtasCbles_Tipo")]
[Index("IdEmpresa", "IdCentroCosto", Name = "FK_Af_Activo_fijo_CtasCbles_ct_centro_costo")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_Af_Activo_fijo_CtasCbles_ct_plancta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfActivoFijoCtasCbles
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdActivoFijo { get; set; }

    [Key]
    [StringLength(20)]
    public string IdTipoCuenta { get; set; } = null!;

    [Key]
    public int Secuencia { get; set; }

    [Column("porc_distribucion")]
    public double PorcDistribucion { get; set; }

    [StringLength(20)]
    public string IdCtaCble { get; set; } = null!;

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [StringLength(250)]
    public string Observacion { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdActivoFijo")]
    [InverseProperty("AfActivoFijoCtasCbles")]
    public virtual AfActivoFijo AfActivoFijo { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("AfActivoFijoCtasCbles")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("AfActivoFijoCtasCbles")]
    public virtual CtPlancta CtPlancta { get; set; } = null!;

    [ForeignKey("IdTipoCuenta")]
    [InverseProperty("AfActivoFijoCtasCbles")]
    public virtual AfActivoFijoCtasCblesTipo IdTipoCuentaNavigation { get; set; } = null!;
}
