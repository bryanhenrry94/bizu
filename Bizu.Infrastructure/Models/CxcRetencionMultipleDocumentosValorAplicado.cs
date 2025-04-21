using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdMultir", "Secuencia")]
[Table("cxc_retencion_Multiple_Documentos_ValorAplicado")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcRetencionMultipleDocumentosValorAplicado
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdMultir { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal? IdCobro { get; set; }

    [Column("IdEmpresa_cbteVta")]
    public int IdEmpresaCbteVta { get; set; }

    [Column("IdSucursal_cbteVta")]
    public int IdSucursalCbteVta { get; set; }

    [Column("IdBodega_cbteVta")]
    public int IdBodegaCbteVta { get; set; }

    [Column("IdCbteVta_cbteVta")]
    [Precision(18, 0)]
    public decimal IdCbteVtaCbteVta { get; set; }

    [Column("IdTipoDoc_cbteVta")]
    [StringLength(30)]
    public string IdTipoDocCbteVta { get; set; } = null!;

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    public string IdCobroTipo { get; set; } = null!;

    public double Base { get; set; }

    public double PorcentajeRetenc { get; set; }

    public double ValorRetenc { get; set; }

    [ForeignKey("IdEmpresa, IdMultir")]
    [InverseProperty("CxcRetencionMultipleDocumentosValorAplicado")]
    public virtual CxcRetencionMultiple CxcRetencionMultiple { get; set; } = null!;
}
