using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdPuntoCargoGrupo", "IdPuntoCargo", "IdCtaCble")]
[Table("tbCONTA_Rpt010")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbContaRpt010
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdPunto_cargo_grupo")]
    public int IdPuntoCargoGrupo { get; set; }

    [Key]
    [Column("IdPunto_cargo")]
    public int IdPuntoCargo { get; set; }

    [Key]
    [StringLength(20)]
    public string IdCtaCble { get; set; } = null!;

    [Column("nom_Punto_cargo")]
    [StringLength(550)]
    public string NomPuntoCargo { get; set; } = null!;

    [Column("Saldo_Anterior")]
    public double SaldoAnterior { get; set; }

    public double Debito { get; set; }

    public double Credito { get; set; }

    [Column("Saldo_Total")]
    public double SaldoTotal { get; set; }
}
