using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdMultir", "Secuencia")]
[Table("cxc_retencion_Multiple_Documento")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcRetencionMultipleDocumento
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdMultir { get; set; }

    [Key]
    public int Secuencia { get; set; }

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

    [ForeignKey("IdEmpresa, IdMultir")]
    [InverseProperty("CxcRetencionMultipleDocumento")]
    public virtual CxcRetencionMultiple CxcRetencionMultiple { get; set; } = null!;
}
