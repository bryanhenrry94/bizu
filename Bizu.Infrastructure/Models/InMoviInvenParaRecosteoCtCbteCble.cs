using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTipoCbte", "IdCbteCble", "Secuencia")]
[Table("in_movi_inven_para_recosteo_ct_CbteCble")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InMoviInvenParaRecosteoCtCbteCble
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdTipoCbte { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [Key]
    public int Secuencia { get; set; }
}
