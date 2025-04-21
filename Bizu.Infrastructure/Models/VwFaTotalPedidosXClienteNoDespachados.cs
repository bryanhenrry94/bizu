using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwFaTotalPedidosXClienteNoDespachados
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("dp_total")]
    public double? DpTotal { get; set; }
}
