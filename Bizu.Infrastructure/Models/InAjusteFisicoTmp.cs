using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("in_AjusteFisico_tmp")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InAjusteFisicoTmp
{
    public int IdEmpresa { get; set; }

    [Column("IdAjusteFisico_Ult")]
    [Precision(18, 0)]
    public decimal? IdAjusteFisicoUlt { get; set; }
}
