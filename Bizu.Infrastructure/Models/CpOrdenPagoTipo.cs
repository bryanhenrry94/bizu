using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cp_orden_pago_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpOrdenPagoTipo
{
    [Key]
    [Column("IdTipo_op")]
    [StringLength(20)]
    public string IdTipoOp { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(1)]
    public string GeneraDiario { get; set; } = null!;

    [InverseProperty("IdTipoOpNavigation")]
    public virtual ICollection<CpOrdenPago> CpOrdenPago { get; set; } = new List<CpOrdenPago>();

    [InverseProperty("IdTipoOpNavigation")]
    public virtual ICollection<CpOrdenPagoTipoXEmpresa> CpOrdenPagoTipoXEmpresa { get; set; } = new List<CpOrdenPagoTipoXEmpresa>();
}
