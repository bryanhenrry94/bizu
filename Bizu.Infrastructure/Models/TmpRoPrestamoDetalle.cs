using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("tmp_ro_prestamo_detalle")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TmpRoPrestamoDetalle
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdPrestamo { get; set; }

    public int NumCuota { get; set; }

    public double SaldoInicial { get; set; }

    public double Interes { get; set; }

    public double AbonoCapital { get; set; }

    public double TotalCuota { get; set; }

    public double Saldo { get; set; }

    [MaxLength(6)]
    public DateTime FechaPago { get; set; }

    [StringLength(10)]
    public string EstadoPago { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("Observacion_det")]
    [StringLength(250)]
    public string ObservacionDet { get; set; } = null!;

    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(200)]
    public string? MotiAnula { get; set; }

    public int? IdNominaTipoLiqui { get; set; }
}
