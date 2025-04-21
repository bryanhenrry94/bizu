using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("NdcIdEmpresa", "NdcIdCbteCbleNota", "NdcIdTipoCbteNota", "ComIdEmpresa", "ComIdSucursal", "ComIdOrdenCompraLocal")]
[Table("cp_nota_DebCre_x_com_ordencompra_local")]
[Index("ComIdEmpresa", "ComIdSucursal", "ComIdOrdenCompraLocal", Name = "FK_cp_nota_DebCre_x_com_ordencompra_local")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpNotaDebCreXComOrdencompraLocal
{
    [Key]
    [Column("ndc_IdEmpresa")]
    public int NdcIdEmpresa { get; set; }

    [Key]
    [Column("ndc_IdCbteCble_Nota")]
    [Precision(18, 0)]
    public decimal NdcIdCbteCbleNota { get; set; }

    [Key]
    [Column("ndc_IdTipoCbte_Nota")]
    public int NdcIdTipoCbteNota { get; set; }

    [Key]
    [Column("com_IdEmpresa")]
    public int ComIdEmpresa { get; set; }

    [Key]
    [Column("com_IdSucursal")]
    public int ComIdSucursal { get; set; }

    [Key]
    [Column("com_IdOrdenCompraLocal")]
    [Precision(18, 0)]
    public decimal ComIdOrdenCompraLocal { get; set; }

    [Column("og_Observacion")]
    [StringLength(500)]
    public string? OgObservacion { get; set; }

    [ForeignKey("ComIdEmpresa, ComIdSucursal, ComIdOrdenCompraLocal")]
    [InverseProperty("CpNotaDebCreXComOrdencompraLocal")]
    public virtual ComOrdencompraLocal ComOrdencompraLocal { get; set; } = null!;

    [ForeignKey("NdcIdEmpresa, NdcIdCbteCbleNota, NdcIdTipoCbteNota")]
    [InverseProperty("CpNotaDebCreXComOrdencompraLocal")]
    public virtual CpNotaDebCre CpNotaDebCre { get; set; } = null!;
}
