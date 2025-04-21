using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaMotivoAprobacionPedidoVenta
{
    public int IdEmpresa { get; set; }

    public int IdMotivo { get; set; }

    public int IdPedido { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string MotivoAprobacion { get; set; } = null!;

    [Column("vt_fecha")]
    [MaxLength(6)]
    public DateTime VtFecha { get; set; }

    [StringLength(30)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NombreUsuario { get; set; }
}
