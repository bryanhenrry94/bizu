using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdMotivo")]
[Table("fa_motivo_aprobacion_Pedido_Venta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaMotivoAprobacionPedidoVenta
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdMotivo { get; set; }

    public int IdPedido { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public string MotivoAprobacion { get; set; } = null!;

    [Column("vt_fecha")]
    [MaxLength(6)]
    public DateTime VtFecha { get; set; }

    [StringLength(30)]
    public string? IdUsuario { get; set; }

    [StringLength(200)]
    public string? UsuarioNombre { get; set; }
}
