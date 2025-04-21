using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTarjeta")]
[Table("tb_tarjeta_parametro")]
[Index("IdEmpresa", "IdCtaCbleTarj", Name = "FK_tb_tarjeta_parametro_ct_plancta")]
[Index("IdEmpresa", "IdCtaCbleComision", Name = "FK_tb_tarjeta_parametro_ct_plancta1")]
[Index("IdCobroTipoXTarj", Name = "FK_tb_tarjeta_parametro_cxc_cobro_tipo")]
[Index("IdCobroTipoXRetFu", Name = "FK_tb_tarjeta_parametro_cxc_cobro_tipo1")]
[Index("IdCobroTipoXRetIva", Name = "FK_tb_tarjeta_parametro_cxc_cobro_tipo2")]
[Index("IdTarjeta", Name = "FK_tb_tarjeta_parametro_tb_tarjeta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbTarjetaParametro
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdTarjeta { get; set; }

    [Column("IdCtaCble_Comision")]
    [StringLength(20)]
    public string? IdCtaCbleComision { get; set; }

    [Column("Porcetaje_Comision")]
    public double? PorcetajeComision { get; set; }

    [Column("IdCobro_tipo_x_Tarj")]
    [StringLength(20)]
    public string? IdCobroTipoXTarj { get; set; }

    [Column("IdCobro_tipo_x_RetFu")]
    [StringLength(20)]
    public string? IdCobroTipoXRetFu { get; set; }

    [Column("IdCobro_tipo_x_RetIva")]
    [StringLength(20)]
    public string? IdCobroTipoXRetIva { get; set; }

    [Column("IdCtaCble_Tarj")]
    [StringLength(20)]
    public string? IdCtaCbleTarj { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleComision")]
    [InverseProperty("TbTarjetaParametroCtPlancta")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCbleTarj")]
    [InverseProperty("TbTarjetaParametroCtPlanctaNavigation")]
    public virtual CtPlancta? CtPlanctaNavigation { get; set; }

    [ForeignKey("IdCobroTipoXRetFu")]
    [InverseProperty("TbTarjetaParametroIdCobroTipoXRetFuNavigation")]
    public virtual CxcCobroTipo? IdCobroTipoXRetFuNavigation { get; set; }

    [ForeignKey("IdCobroTipoXRetIva")]
    [InverseProperty("TbTarjetaParametroIdCobroTipoXRetIvaNavigation")]
    public virtual CxcCobroTipo? IdCobroTipoXRetIvaNavigation { get; set; }

    [ForeignKey("IdCobroTipoXTarj")]
    [InverseProperty("TbTarjetaParametroIdCobroTipoXTarjNavigation")]
    public virtual CxcCobroTipo? IdCobroTipoXTarjNavigation { get; set; }

    [ForeignKey("IdEmpresa")]
    [InverseProperty("TbTarjetaParametro")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdTarjeta")]
    [InverseProperty("TbTarjetaParametro")]
    public virtual TbTarjeta IdTarjetaNavigation { get; set; } = null!;
}
