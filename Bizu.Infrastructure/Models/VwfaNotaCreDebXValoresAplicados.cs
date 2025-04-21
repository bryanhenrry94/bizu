using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaNotaCreDebXValoresAplicados
{
    [Column("IdEmpresa_nt")]
    public int IdEmpresaNt { get; set; }

    [Column("IdSucursal_nt")]
    public int IdSucursalNt { get; set; }

    [Column("IdBodega_nt")]
    public int IdBodegaNt { get; set; }

    [Column("IdNota_nt")]
    [Precision(18, 0)]
    public decimal IdNotaNt { get; set; }

    [Column("secuencia")]
    public int Secuencia { get; set; }

    [Column("Valor_Aplicado")]
    public double? ValorAplicado { get; set; }
}
