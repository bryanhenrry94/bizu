using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcomOrdencompraLocalDetConCantEnviadasXGuiaXTraspaso
{
    [Column("IdEmpresa_OC")]
    public int? IdEmpresaOc { get; set; }

    [Column("IdSucursal_OC")]
    public int? IdSucursalOc { get; set; }

    [Column("IdOrdenCompra_OC")]
    [Precision(18, 0)]
    public decimal? IdOrdenCompraOc { get; set; }

    [Column("Secuencia_OC")]
    public int? SecuenciaOc { get; set; }

    [Column("Cantidad_enviar")]
    public double? CantidadEnviar { get; set; }
}
