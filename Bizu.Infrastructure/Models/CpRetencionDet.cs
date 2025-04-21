using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdRetencion", "Idsecuencia")]
[Table("cp_retencion_det")]
[Index("IdCodigoSri", Name = "FK_cp_retencion_det_cp_codigo_SRI")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpRetencionDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdRetencion { get; set; }

    [Key]
    public int Idsecuencia { get; set; }

    [Column("re_tipoRet")]
    [StringLength(3)]
    public string ReTipoRet { get; set; } = null!;

    [Column("re_baseRetencion")]
    public double ReBaseRetencion { get; set; }

    [Column("IdCodigo_SRI")]
    public int IdCodigoSri { get; set; }

    [Column("re_Codigo_impuesto")]
    [StringLength(50)]
    public string ReCodigoImpuesto { get; set; } = null!;

    [Column("re_Porcen_retencion")]
    public double RePorcenRetencion { get; set; }

    [Column("re_valor_retencion")]
    public double ReValorRetencion { get; set; }

    [Column("re_esBaseCero")]
    public bool? ReEsBaseCero { get; set; }

    [Column("re_estado")]
    [StringLength(1)]
    public string ReEstado { get; set; } = null!;

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [ForeignKey("IdEmpresa, IdRetencion")]
    [InverseProperty("CpRetencionDet")]
    public virtual CpRetencion CpRetencion { get; set; } = null!;

    [ForeignKey("IdCodigoSri")]
    [InverseProperty("CpRetencionDet")]
    public virtual CpCodigoSri IdCodigoSriNavigation { get; set; } = null!;
}
