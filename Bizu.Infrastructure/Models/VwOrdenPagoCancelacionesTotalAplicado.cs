using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwOrdenPagoCancelacionesTotalAplicado
{
    [Column("IdEmpresa_op")]
    public int IdEmpresaOp { get; set; }

    [Column("IdOrdenPago_op")]
    [Precision(18, 0)]
    public decimal IdOrdenPagoOp { get; set; }

    [Column("Secuencia_op")]
    public int SecuenciaOp { get; set; }

    public double? MontoAplicado { get; set; }
}
