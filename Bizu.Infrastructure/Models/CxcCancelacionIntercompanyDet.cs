using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCancelacion", "Secuencia")]
[Table("cxc_cancelacion_Intercompany_det")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcCancelacionIntercompanyDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCancelacion { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Column("cbteVta_IdEmpresa")]
    public int CbteVtaIdEmpresa { get; set; }

    [Column("cbteVta_IdSucursal")]
    public int CbteVtaIdSucursal { get; set; }

    [Column("cbteVta_IdBodega")]
    public int CbteVtaIdBodega { get; set; }

    [Column("cbteVta_TipoDoc")]
    [StringLength(20)]
    public string CbteVtaTipoDoc { get; set; } = null!;

    [Column("cbteVta_IdCbteVta")]
    [Precision(18, 0)]
    public decimal CbteVtaIdCbteVta { get; set; }

    [Column("cbr_IdEmpresa")]
    public int? CbrIdEmpresa { get; set; }

    [Column("cbr_IdSucursal")]
    public int? CbrIdSucursal { get; set; }

    [Column("cbr_IdCobro")]
    [Precision(18, 0)]
    public decimal? CbrIdCobro { get; set; }

    [Column("Valor_Aplicado")]
    public double ValorAplicado { get; set; }

    [ForeignKey("IdEmpresa, IdCancelacion")]
    [InverseProperty("CxcCancelacionIntercompanyDet")]
    public virtual CxcCancelacionIntercompany CxcCancelacionIntercompany { get; set; } = null!;
}
