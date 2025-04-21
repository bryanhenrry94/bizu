using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwFacRpt004Detalle
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdNota { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdTipoDocumento { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("no_fecha")]
    [MaxLength(6)]
    public DateTime NoFecha { get; set; }

    public double? Saldo { get; set; }

    public double? TotalCobrado { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NaturalezaNota { get; set; }

    [Column("sc_subtotal")]
    public double? ScSubtotal { get; set; }

    [Column("sc_iva")]
    public double? ScIva { get; set; }

    [Column("sc_total")]
    public double? ScTotal { get; set; }

    [Column("IdCod_Impuesto_Iva")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCodImpuestoIva { get; set; } = null!;

    public int IdTipoNota { get; set; }
}
