using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdBanco", "IdUsuario")]
[Table("ba_BAN_Rpt007")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaBanRpt007
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdBanco { get; set; }

    [Key]
    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("nom_cuenta_banco")]
    [StringLength(200)]
    public string NomCuentaBanco { get; set; } = null!;

    [Column("Saldo_inicial")]
    public double SaldoInicial { get; set; }

    [Column("Saldo_final")]
    public double SaldoFinal { get; set; }
}
