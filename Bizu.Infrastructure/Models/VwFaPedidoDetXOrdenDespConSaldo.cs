using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwFaPedidoDetXOrdenDespConSaldo
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdPedido { get; set; }

    public int Secuencial { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("dp_cantidad")]
    public double? DpCantidad { get; set; }

    [Column("od_cantidad")]
    public double? OdCantidad { get; set; }

    [Column("pd_saldo")]
    public double? PdSaldo { get; set; }

    [Column("detelleSys")]
    [StringLength(29)]
    public string DetelleSys { get; set; } = null!;
}
