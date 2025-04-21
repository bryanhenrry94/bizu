using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("com_parametro")]
[Index("IdEstadoAprobacionOc", Name = "FK_com_parametro_com_catalogo")]
[Index("IdEstadoAnulacionOc", Name = "FK_com_parametro_com_catalogo1")]
[Index("IdEstadoAprobacionSolCompra", Name = "FK_com_parametro_com_catalogo2")]
[Index("IdEstadoCierre", Name = "FK_com_parametro_com_estado_cierre")]
[Index("IdEmpresa", "IdMoviInvenTipoOc", Name = "FK_com_parametro_in_movi_inven_tipo")]
[Index("IdEmpresa", "IdMoviInvenTipoDevCompra", Name = "FK_com_parametro_in_movi_inven_tipo1")]
[Index("IdEmpresa", "IdSucursalXAprobXSolComp", Name = "FK_com_parametro_tb_sucursal")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComParametro
{
    [Key]
    public int IdEmpresa { get; set; }

    [Column("IdEstadoAprobacion_OC")]
    [StringLength(25)]
    public string IdEstadoAprobacionOc { get; set; } = null!;

    [Column("IdMovi_inven_tipo_OC")]
    public int IdMoviInvenTipoOc { get; set; }

    [Column("IdEstadoAnulacion_OC")]
    [StringLength(25)]
    public string IdEstadoAnulacionOc { get; set; } = null!;

    [Column("IdMovi_inven_tipo_dev_compra")]
    public int IdMoviInvenTipoDevCompra { get; set; }

    [Column("IdEstadoAprobacion_SolCompra")]
    [StringLength(25)]
    public string IdEstadoAprobacionSolCompra { get; set; } = null!;

    [Column("IdSucursal_x_Aprob_x_SolComp")]
    public int IdSucursalXAprobXSolComp { get; set; }

    [Column("IdEstado_cierre")]
    [StringLength(25)]
    public string IdEstadoCierre { get; set; } = null!;

    [Column("default_dias_plazo")]
    public int? DefaultDiasPlazo { get; set; }

    [Column("default_dias_vencidos")]
    public int? DefaultDiasVencidos { get; set; }

    [Column("NotificaAprobacionOC")]
    public bool? NotificaAprobacionOc { get; set; }

    [Column("NotificaAprobacionOCAuto")]
    public bool? NotificaAprobacionOcauto { get; set; }

    [ForeignKey("IdEmpresa")]
    [InverseProperty("ComParametro")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdEstadoAnulacionOc")]
    [InverseProperty("ComParametroIdEstadoAnulacionOcNavigation")]
    public virtual ComCatalogo IdEstadoAnulacionOcNavigation { get; set; } = null!;

    [ForeignKey("IdEstadoAprobacionOc")]
    [InverseProperty("ComParametroIdEstadoAprobacionOcNavigation")]
    public virtual ComCatalogo IdEstadoAprobacionOcNavigation { get; set; } = null!;

    [ForeignKey("IdEstadoAprobacionSolCompra")]
    [InverseProperty("ComParametroIdEstadoAprobacionSolCompraNavigation")]
    public virtual ComCatalogo IdEstadoAprobacionSolCompraNavigation { get; set; } = null!;

    [ForeignKey("IdEstadoCierre")]
    [InverseProperty("ComParametro")]
    public virtual ComEstadoCierre IdEstadoCierreNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdMoviInvenTipoDevCompra")]
    [InverseProperty("ComParametroInMoviInvenTipo")]
    public virtual InMoviInvenTipo InMoviInvenTipo { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdMoviInvenTipoOc")]
    [InverseProperty("ComParametroInMoviInvenTipoNavigation")]
    public virtual InMoviInvenTipo InMoviInvenTipoNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursalXAprobXSolComp")]
    [InverseProperty("ComParametro")]
    public virtual TbSucursal TbSucursal { get; set; } = null!;
}
