using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdPedido", "IdTipoFormaPago", "Secuencia")]
[Table("fa_pedido_x_formaPago")]
[Index("IdTipoFormaPago", Name = "FK_fa_pedido_x_formaPago_fa_TerminoPago")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaPedidoXFormaPago
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdPedido { get; set; }

    [Key]
    [StringLength(20)]
    public string IdTipoFormaPago { get; set; } = null!;

    [Key]
    public int Secuencia { get; set; }

    public DateOnly Fecha { get; set; }

    [Column("Fecha_vct")]
    public DateOnly FechaVct { get; set; }

    [Column("Dias_Plazo")]
    public int DiasPlazo { get; set; }

    [Column("Por_Distribucion")]
    public double PorDistribucion { get; set; }

    public double Valor { get; set; }

    [ForeignKey("IdTipoFormaPago")]
    [InverseProperty("FaPedidoXFormaPago")]
    public virtual FaTerminoPago IdTipoFormaPagoNavigation { get; set; } = null!;
}
