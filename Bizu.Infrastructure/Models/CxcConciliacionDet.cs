using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdConciliacion", "Secuencia")]
[Table("cxc_conciliacion_det")]
[Index("IdEmpresaCbr", "IdSucursalCbr", "IdCobro", "SecuenciaCbr", Name = "FK_cxc_conciliacion_det_cxc_cobro_det")]
[Index("IdTipoConciliacion", Name = "FK_cxc_conciliacion_det_cxc_conciliacion_tipo")]
[Index("IdEmpresaFa", "IdSucursalFa", "IdBodegaFa", "IdCbteVtaFa", Name = "FK_cxc_conciliacion_det_fa_factura")]
[Index("IdEmpresaNt", "IdSucursalNt", "IdBodegaNt", "IdNotaNt", Name = "FK_cxc_conciliacion_det_fa_notaCreDeb")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcConciliacionDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdConciliacion { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [StringLength(20)]
    public string IdTipoConciliacion { get; set; } = null!;

    [Column("IdEmpresa_cbr")]
    public int? IdEmpresaCbr { get; set; }

    [Column("IdSucursal_cbr")]
    public int? IdSucursalCbr { get; set; }

    [Precision(18, 0)]
    public decimal? IdCobro { get; set; }

    [Column("secuencia_cbr")]
    public int? SecuenciaCbr { get; set; }

    [Column("IdEmpresa_nt")]
    public int? IdEmpresaNt { get; set; }

    [Column("IdSucursal_nt")]
    public int? IdSucursalNt { get; set; }

    [Column("IdBodega_nt")]
    public int? IdBodegaNt { get; set; }

    [Column("IdNota_nt")]
    [Precision(18, 0)]
    public decimal? IdNotaNt { get; set; }

    [Column("IdEmpresa_fa")]
    public int? IdEmpresaFa { get; set; }

    [Column("IdSucursal_fa")]
    public int? IdSucursalFa { get; set; }

    [Column("IdBodega_fa")]
    public int? IdBodegaFa { get; set; }

    [Column("TipoDoc_vta")]
    [StringLength(20)]
    public string? TipoDocVta { get; set; }

    [Column("IdCbteVta_fa")]
    [Precision(18, 0)]
    public decimal? IdCbteVtaFa { get; set; }

    [Column("Saldo_por_aplicar")]
    public double SaldoPorAplicar { get; set; }

    [Column("Valor_Aplicado")]
    public double ValorAplicado { get; set; }

    [ForeignKey("IdEmpresaCbr, IdSucursalCbr, IdCobro, SecuenciaCbr")]
    [InverseProperty("CxcConciliacionDet")]
    public virtual CxcCobroDet? CxcCobroDet { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdConciliacion")]
    [InverseProperty("CxcConciliacionDet")]
    public virtual CxcConciliacion CxcConciliacion { get; set; } = null!;

    [ForeignKey("IdEmpresaFa, IdSucursalFa, IdBodegaFa, IdCbteVtaFa")]
    [InverseProperty("CxcConciliacionDet")]
    public virtual FaFactura? FaFactura { get; set; }

    [ForeignKey("IdEmpresaNt, IdSucursalNt, IdBodegaNt, IdNotaNt")]
    [InverseProperty("CxcConciliacionDet")]
    public virtual FaNotaCreDeb? FaNotaCreDeb { get; set; }

    [ForeignKey("IdTipoConciliacion")]
    [InverseProperty("CxcConciliacionDet")]
    public virtual CxcConciliacionTipo IdTipoConciliacionNavigation { get; set; } = null!;
}
