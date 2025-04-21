using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcxcCancelacionIntercompanyXCxcCobroDet
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdCancelacion { get; set; }

    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdCobro { get; set; }

    [Column("cr_fecha")]
    [MaxLength(6)]
    public DateTime CrFecha { get; set; }

    [Column("cr_fechaDocu")]
    [MaxLength(6)]
    public DateTime CrFechaDocu { get; set; }

    [Column("cr_fechaCobro")]
    [MaxLength(6)]
    public DateTime CrFechaCobro { get; set; }

    [Column("cr_observacion")]
    [StringLength(700)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CrObservacion { get; set; } = null!;

    [Column("cr_Banco")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrBanco { get; set; }

    [Column("cr_cuenta")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrCuenta { get; set; }

    [Column("cr_NumDocumento")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrNumDocumento { get; set; }

    [Column("cr_Tarjeta")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrTarjeta { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [StringLength(404)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCliente { get; set; }

    [Column("Valor_Aplicado")]
    public double ValorAplicado { get; set; }

    [StringLength(68)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Referencia { get; set; }

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCobroTipo { get; set; } = null!;
}
