using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdCobroTipo")]
[Table("cxc_cobro_tipo_Param_conta_x_sucursal")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_cxc_cobro_tipo_Param_conta_x_sucursal_ct_plancta")]
[Index("IdEmpresa", "IdCtaCbleAnticipo", Name = "FK_cxc_cobro_tipo_Param_conta_x_sucursal_ct_plancta1")]
[Index("IdCobroTipo", Name = "FK_cxc_cobro_tipo_Param_conta_x_sucursal_cxc_cobro_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcCobroTipoParamContaXSucursal
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Column("IdCobro_tipo")]
    [StringLength(20)]
    public string IdCobroTipo { get; set; } = null!;

    [StringLength(20)]
    public string? IdCtaCble { get; set; }

    [Column("IdCtaCble_Anticipo")]
    [StringLength(20)]
    public string? IdCtaCbleAnticipo { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("CxcCobroTipoParamContaXSucursalCtPlancta")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleAnticipo")]
    [InverseProperty("CxcCobroTipoParamContaXSucursalCtPlanctaNavigation")]
    public virtual CtPlancta? CtPlanctaNavigation { get; set; }

    [ForeignKey("IdCobroTipo")]
    [InverseProperty("CxcCobroTipoParamContaXSucursal")]
    public virtual CxcCobroTipo IdCobroTipoNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal")]
    [InverseProperty("CxcCobroTipoParamContaXSucursal")]
    public virtual TbSucursal TbSucursal { get; set; } = null!;
}
