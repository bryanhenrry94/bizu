using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaOrdenDespDetXFaPedidoDetXPedido
{
    [Column("pe_IdEmpresa")]
    public int PeIdEmpresa { get; set; }

    [Column("pe_IdSucursal")]
    public int PeIdSucursal { get; set; }

    [Column("pe_IdBodega")]
    public int PeIdBodega { get; set; }

    [Column("pe_IdPedido")]
    [Precision(18, 0)]
    public decimal PeIdPedido { get; set; }

    [Column("pe_Secuencia")]
    public int PeSecuencia { get; set; }

    [Column("pe_IdProducto")]
    [Precision(18, 0)]
    public decimal PeIdProducto { get; set; }
}
