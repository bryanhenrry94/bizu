using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdMultir")]
[Table("cxc_retencion_Multiple")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcRetencionMultiple
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdMultir { get; set; }

    public int IdSucursal { get; set; }

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [MaxLength(6)]
    public DateTime FechaIngreso { get; set; }

    [MaxLength(6)]
    public DateTime FechaCobro { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public int IdCaja { get; set; }

    [StringLength(30)]
    public string NumRetencion { get; set; } = null!;

    [MaxLength(6)]
    public DateTime FechaRetencion { get; set; }

    public double TotalRetencion { get; set; }

    [StringLength(2)]
    public string? Estado { get; set; }

    [InverseProperty("CxcRetencionMultiple")]
    public virtual ICollection<CxcRetencionMultipleDocumento> CxcRetencionMultipleDocumento { get; set; } = new List<CxcRetencionMultipleDocumento>();

    [InverseProperty("CxcRetencionMultiple")]
    public virtual ICollection<CxcRetencionMultipleDocumentosValorAplicado> CxcRetencionMultipleDocumentosValorAplicado { get; set; } = new List<CxcRetencionMultipleDocumentosValorAplicado>();
}
