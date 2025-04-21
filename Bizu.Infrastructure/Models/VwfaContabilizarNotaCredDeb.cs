using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwfaContabilizarNotaCredDeb
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdNota { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCategoria { get; set; } = null!;

    [Column("IVA")]
    public double? Iva { get; set; }

    [Column("SUBTOTAL")]
    public double? Subtotal { get; set; }

    [Column("tOTAL")]
    public double? TOtal { get; set; }

    [Column("descuentototal")]
    public double? Descuentototal { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("IdPunto_Cargo")]
    public int? IdPuntoCargo { get; set; }
}
