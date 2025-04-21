using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaPedidoXFaOrdenDespDetXFaGuiaRemisionDet
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdPedido { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("dp_cantidad")]
    public double DpCantidad { get; set; }

    [Column("gi_cantidad_guia")]
    public double GiCantidadGuia { get; set; }

    [Column("saldo_cantidad_pedido")]
    public double SaldoCantidadPedido { get; set; }
}
