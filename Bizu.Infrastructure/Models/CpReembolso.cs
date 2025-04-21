using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCbteCbleOgiro", "IdTipoCbteOgiro", "IdReembolso")]
[Table("cp_reembolso")]
[Index("IdEmpresa", "IdProveedor", Name = "FK_cp_reembolso_cp_proveedor")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpReembolso
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal IdCbteCbleOgiro { get; set; }

    [Key]
    [Column("IdTipoCbte_Ogiro")]
    public int IdTipoCbteOgiro { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdReembolso { get; set; }

    [Precision(18, 0)]
    public decimal? IdProveedor { get; set; }

    [StringLength(50)]
    public string? TipoIdProveedor { get; set; }

    [StringLength(50)]
    public string? IdentificacionProveedor { get; set; }

    [Column("TipoDoc_CodSRI")]
    [StringLength(5)]
    public string? TipoDocCodSri { get; set; }

    [StringLength(25)]
    public string? Establecimiento { get; set; }

    [Column("Punto_Emision")]
    [StringLength(25)]
    public string? PuntoEmision { get; set; }

    [StringLength(25)]
    public string? Secuencial { get; set; }

    [StringLength(25)]
    public string? Autorizacion { get; set; }

    [Column("Fecha_Emision")]
    public DateOnly? FechaEmision { get; set; }

    [Column("TarifaIVAcero")]
    public double? TarifaIvacero { get; set; }

    [Column("TarifaIVADiferentecero")]
    public double? TarifaIvadiferentecero { get; set; }

    [Column("TarifaNoObjetoIVA")]
    public double? TarifaNoObjetoIva { get; set; }

    [Column("MontoICE")]
    public double? MontoIce { get; set; }

    [Column("MontoIVA")]
    public double? MontoIva { get; set; }

    [Column("baseImponible")]
    public double? BaseImponible { get; set; }

    public double? Total { get; set; }

    [ForeignKey("IdEmpresa, IdCbteCbleOgiro, IdTipoCbteOgiro")]
    [InverseProperty("CpReembolso")]
    public virtual CpOrdenGiro CpOrdenGiro { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdProveedor")]
    [InverseProperty("CpReembolso")]
    public virtual CpProveedor? CpProveedor { get; set; }
}
