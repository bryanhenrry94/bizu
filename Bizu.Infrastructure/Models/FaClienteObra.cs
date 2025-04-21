using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCliente", "IdCentroCosto")]
[Table("fa_cliente_obra")]
[Index("IdEmpresa", "IdCentroCosto", Name = "FK_fa_cliente_obra_ct_centro_costo")]
[Index("IdEstadoObra", Name = "FK_fa_cliente_obra_fa_catalogo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaClienteObra
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Key]
    [StringLength(20)]
    public string IdCentroCosto { get; set; } = null!;

    public DateOnly? FechaIni { get; set; }

    public DateOnly? FechaFin { get; set; }

    [StringLength(250)]
    public string? DireccionObra { get; set; }

    [StringLength(50)]
    public string? CorreoObra { get; set; }

    [StringLength(15)]
    public string IdEstadoObra { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("FaClienteObra")]
    public virtual CtCentroCosto CtCentroCosto { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCliente")]
    [InverseProperty("FaClienteObra")]
    public virtual FaCliente FaCliente { get; set; } = null!;

    [ForeignKey("IdEstadoObra")]
    [InverseProperty("FaClienteObra")]
    public virtual FaCatalogo IdEstadoObraNavigation { get; set; } = null!;
}
