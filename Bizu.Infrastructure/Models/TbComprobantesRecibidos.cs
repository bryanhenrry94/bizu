using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_ComprobantesRecibidos")]
[Index("IdEmpresaOgiro", "IdCbteCbleOgiro", "IdTipoCbteOgiro", Name = "tb_ComprobantesRecibidos_FK")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbComprobantesRecibidos
{
    [Key]
    public int Id { get; set; }

    [StringLength(13)]
    public string RucEmisor { get; set; } = null!;

    [StringLength(100)]
    public string RazonSocialEmisor { get; set; } = null!;

    [StringLength(100)]
    public string TipoComprobante { get; set; } = null!;

    [StringLength(25)]
    public string SerieComprobante { get; set; } = null!;

    public DateOnly FechaEmision { get; set; }

    [StringLength(49)]
    public string ClaveAcceso { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FechaAutorizacion { get; set; }

    [StringLength(13)]
    public string IdentificacionReceptor { get; set; } = null!;

    [Precision(18, 2)]
    public decimal? ValorSinImpuestos { get; set; }

    [Precision(18, 2)]
    public decimal? Iva { get; set; }

    [Precision(18, 2)]
    public decimal? ImporteTotal { get; set; }

    [StringLength(25)]
    public string? NumeroDocumentoModificado { get; set; }

    [StringLength(50)]
    public string Estado { get; set; } = null!;

    [StringLength(250)]
    public string? Motivo { get; set; }

    [Column("XML")]
    [MySqlCollation("utf8mb4_general_ci")]
    public string? Xml { get; set; }

    [Column("IdEmpresa_Ogiro")]
    public int? IdEmpresaOgiro { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleOgiro { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int? IdTipoCbteOgiro { get; set; }

    [StringLength(49)]
    public string? NumeroAutorizacion { get; set; }

    [ForeignKey("IdEmpresaOgiro, IdCbteCbleOgiro, IdTipoCbteOgiro")]
    [InverseProperty("TbComprobantesRecibidos")]
    public virtual CpOrdenGiro? CpOrdenGiro { get; set; }
}
