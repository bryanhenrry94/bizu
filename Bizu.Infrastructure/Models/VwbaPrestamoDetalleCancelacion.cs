using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwbaPrestamoDetalleCancelacion
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdPrestamo { get; set; }

    [Column("IdMotivo_Prestamo")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdMotivoPrestamo { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdMetCalc { get; set; }

    public int NumCuota { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EstadoPago { get; set; } = null!;

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomEstadoPago { get; set; } = null!;

    [Column("Monto_Canc")]
    public double MontoCanc { get; set; }

    [Column("Saldo_Canc")]
    public double SaldoCanc { get; set; }

    public double TotalCuota { get; set; }

    [MaxLength(6)]
    public DateTime FechaPago { get; set; }

    [Column("Observacion_canc")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ObservacionCanc { get; set; }

    public int IdBanco { get; set; }

    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomBanco { get; set; } = null!;

    [Column("IdCtaCble_Prestamo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCblePrestamo { get; set; }

    [Column("IdCtaCble_Banco")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCbleBanco { get; set; } = null!;

    public double Interes { get; set; }

    public double SaldoInicial { get; set; }

    public double AbonoCapital { get; set; }

    public double Saldo { get; set; }
}
