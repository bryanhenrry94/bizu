using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdProveedor", "IdCodigoSri")]
[Table("cp_proveedor_codigo_SRI")]
[Index("IdCodigoSri", Name = "FK_cp_proveedor_codigo_SRI_cp_codigo_SRI")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpProveedorCodigoSri
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Key]
    [Column("IdCodigo_SRI")]
    public int IdCodigoSri { get; set; }

    [Column("observacion")]
    [StringLength(50)]
    public string? Observacion { get; set; }

    [ForeignKey("IdEmpresa, IdProveedor")]
    [InverseProperty("CpProveedorCodigoSri")]
    public virtual CpProveedor CpProveedor { get; set; } = null!;

    [ForeignKey("IdCodigoSri")]
    [InverseProperty("CpProveedorCodigoSri")]
    public virtual CpCodigoSri IdCodigoSriNavigation { get; set; } = null!;
}
