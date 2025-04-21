using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cp_trans_a_generar_x_FormaPago_OP")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpTransAGenerarXFormaPagoOp
{
    [Key]
    [StringLength(20)]
    public string IdTipoTransaccion { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    [InverseProperty("IdTipoTransaccionNavigation")]
    public virtual ICollection<CpOrdenPagoFormapago> CpOrdenPagoFormapago { get; set; } = new List<CpOrdenPagoFormapago>();
}
