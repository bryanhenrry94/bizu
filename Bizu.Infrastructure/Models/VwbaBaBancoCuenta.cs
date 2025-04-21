using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwbaBaBancoCuenta
{
    public int IdEmpresa { get; set; }

    public int IdBanco { get; set; }

    [Column("ba_descripcion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BaDescripcion { get; set; } = null!;

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

    [Column("IdBanco_Financiero")]
    public int? IdBancoFinanciero { get; set; }

    [Column("Imprimir_Solo_el_cheque")]
    public bool? ImprimirSoloElCheque { get; set; }

    public bool? MostrarVistaPreviaCheque { get; set; }

    [Column("ReporteSolo_Cheque")]
    public byte[]? ReporteSoloCheque { get; set; }

    public byte[]? Reporte { get; set; }

    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotiAnula { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltAnu { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("ip")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Ip { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPc { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Expr1 { get; set; } = null!;

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodigoLegal { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltMod { get; set; }
}
