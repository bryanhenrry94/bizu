using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwbaPrestamo
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdPrestamo { get; set; }

    public int IdBanco { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodPrestamo { get; set; } = null!;

    [Column("IdMotivo_Prestamo")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdMotivoPrestamo { get; set; } = null!;

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    public double MontoSol { get; set; }

    public double TasaInteres { get; set; }

    public double TotalPrestamo { get; set; }

    public int NumCuotas { get; set; }

    [Column("Fecha_PriPago")]
    [MaxLength(6)]
    public DateTime FechaPriPago { get; set; }

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Ip { get; set; }

    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotiAnula { get; set; }

    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomBanco { get; set; } = null!;

    [Column("ba_Tipo")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BaTipo { get; set; } = null!;

    [Column("ba_Num_Cuenta")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BaNumCuenta { get; set; } = null!;

    [Column("ba_Moneda")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BaMoneda { get; set; } = null!;

    [Column("ba_Ultimo_Cheque")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BaUltimoCheque { get; set; } = null!;

    [Column("ba_num_digito_cheq")]
    public int BaNumDigitoCheq { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdPeriPago { get; set; } = null!;

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoCatalogo { get; set; } = null!;

    [Column("ca_descripcion")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CaDescripcion { get; set; } = null!;

    [Column("ca_estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CaEstado { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdMetCalc { get; set; }

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string MetodoCalculo { get; set; } = null!;

    [Column("IdMotivoPrestamo")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdMotivoPrestamo1 { get; set; } = null!;

    [Column("NomMotivo_Prestamo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomMotivoPrestamo { get; set; } = null!;

    [Precision(18, 0)]
    public decimal? IdTipoFlujo { get; set; }

    [Column("nom_tipoFlujo")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomTipoFlujo { get; set; }

    [Column("IdCtaCble_Prestamo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCtaCblePrestamo { get; set; }

    [Column("nom_CtaCble_Prestamo")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCtaCblePrestamo { get; set; }

    [Column("Pago_contado")]
    public double? PagoContado { get; set; }

    [Precision(18, 0)]
    public decimal? IdCliente { get; set; }
}
