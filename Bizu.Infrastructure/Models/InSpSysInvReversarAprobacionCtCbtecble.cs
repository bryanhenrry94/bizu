using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTipoCbte", "IdCbteCble")]
[Table("in_spSys_inv_Reversar_aprobacion_ct_cbtecble")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InSpSysInvReversarAprobacionCtCbtecble
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdTipoCbte { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }
}
