using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdProveedor", "IdAutorizacion")]
[Table("cp_proveedor_Autorizacion")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpProveedorAutorizacion
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdAutorizacion { get; set; }

    [StringLength(5)]
    public string Serie1 { get; set; } = null!;

    [StringLength(5)]
    public string Serie2 { get; set; } = null!;

    [Column("nAutorizacion")]
    [StringLength(50)]
    public string NAutorizacion { get; set; } = null!;

    [Column("Valido_Hasta")]
    public DateOnly ValidoHasta { get; set; }

    [Column("factura_inicial")]
    [StringLength(50)]
    public string FacturaInicial { get; set; } = null!;

    [Column("factura_final")]
    [StringLength(50)]
    public string FacturaFinal { get; set; } = null!;

    [StringLength(50)]
    public string? NumAutorizacionImprenta { get; set; }

    public bool? Estado { get; set; }

    [ForeignKey("IdEmpresa, IdProveedor")]
    [InverseProperty("CpProveedorAutorizacion")]
    public virtual CpProveedor CpProveedor { get; set; } = null!;
}
