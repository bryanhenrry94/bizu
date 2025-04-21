using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcxcCobrosXChequeDeposito
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Sucursal { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdCobro { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCobroTipo { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TipoCobro { get; set; } = null!;

    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoCobro { get; set; } = null!;

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [MaxLength(6)]
    public DateTime FechaCobro { get; set; }

    [Column("Banco_del_cheq")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? BancoDelCheq { get; set; }

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Cuenta { get; set; }

    [Column("Num_Cheq")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumCheq { get; set; }

    public double TotalCobro { get; set; }

    [Column("mcj_IdCbteCble")]
    [Precision(18, 0)]
    public decimal? McjIdCbteCble { get; set; }

    [Column("mcj_IdTipocbte")]
    public int? McjIdTipocbte { get; set; }

    public int? IdCaja { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodCaja { get; set; }

    [Column("ba_IdCbteCble")]
    [Precision(18, 0)]
    public decimal? BaIdCbteCble { get; set; }

    [Column("ba_IdTipocbte")]
    public int? BaIdTipocbte { get; set; }

    [Column("Fecha_dep")]
    public DateOnly? FechaDep { get; set; }

    [Column("IdBanco_dep")]
    public int? IdBancoDep { get; set; }

    [Column("Banco_deposito")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? BancoDeposito { get; set; }

    [StringLength(352)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Cliente { get; set; }

    [StringLength(0)]
    public string Referencia { get; set; } = null!;
}
