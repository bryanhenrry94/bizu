using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdPeriodo", "Secuencia", "TipoIngEgr", "IdCbteCble", "IdTipocbte", "SecuenciaCbteCble")]
[Table("ba_cbte_ban_verificado")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaCbteBanVerificado
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdPeriodo { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Key]
    [Column("tipo_IngEgr")]
    [StringLength(1)]
    public string TipoIngEgr { get; set; } = null!;

    [Key]
    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [Key]
    public int IdTipocbte { get; set; }

    [Key]
    public int SecuenciaCbteCble { get; set; }

    [Column("observacion")]
    [StringLength(50)]
    public string? Observacion { get; set; }
}
