using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCentroCosto")]
[Table("ct_centro_costo_EstadoCierre")]
[Index("IdEmpresa", "IdCliente", Name = "FK_ct_centro_costo_EstadoCierre_fa_cliente")]
[Index("IdEstadoCierre", Name = "FK_ct_centro_costo_EstadoCierre_obr_Catalogo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtCentroCostoEstadoCierre
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(20)]
    public string IdCentroCosto { get; set; } = null!;

    [Precision(18, 0)]
    public decimal? IdCliente { get; set; }

    [StringLength(15)]
    public string IdEstadoCierre { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("CtCentroCostoEstadoCierre")]
    public virtual CtCentroCosto CtCentroCosto { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCliente")]
    [InverseProperty("CtCentroCostoEstadoCierre")]
    public virtual FaCliente? FaCliente { get; set; }
}
