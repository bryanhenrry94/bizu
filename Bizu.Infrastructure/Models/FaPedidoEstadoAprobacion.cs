using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("fa_pedido_estadoAprobacion")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaPedidoEstadoAprobacion
{
    [Key]
    [StringLength(1)]
    public string IdEstadoAprobacion { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("posicion")]
    public int Posicion { get; set; }

    [InverseProperty("IdEstadoAprobacionNavigation")]
    public virtual ICollection<FaParametro> FaParametro { get; set; } = new List<FaParametro>();

    [InverseProperty("IdEstadoAprobacionNavigation")]
    public virtual ICollection<FaPedido> FaPedido { get; set; } = new List<FaPedido>();
}
