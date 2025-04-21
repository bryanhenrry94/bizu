using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("fa_TerminoPago")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaTerminoPago
{
    [Key]
    [StringLength(20)]
    public string IdTerminoPago { get; set; } = null!;

    [Column("nom_TerminoPago")]
    [StringLength(50)]
    public string NomTerminoPago { get; set; } = null!;

    [Column("Num_Coutas")]
    public int NumCoutas { get; set; }

    [Column("Dias_Vct")]
    public int DiasVct { get; set; }

    [InverseProperty("IdTipoFormaPagoNavigation")]
    public virtual ICollection<FaPedidoXFormaPago> FaPedidoXFormaPago { get; set; } = new List<FaPedidoXFormaPago>();

    [InverseProperty("IdTerminoPagoNavigation")]
    public virtual ICollection<FaTerminoPagoDistribucion> FaTerminoPagoDistribucion { get; set; } = new List<FaTerminoPagoDistribucion>();
}
