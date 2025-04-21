using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdTerminoPago", "Secuencia")]
[Table("fa_TerminoPago_Distribucion")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaTerminoPagoDistribucion
{
    [Key]
    [StringLength(20)]
    public string IdTerminoPago { get; set; } = null!;

    [Key]
    public int Secuencia { get; set; }

    [Column("Num_Dias_Vcto")]
    public int NumDiasVcto { get; set; }

    [Column("Por_distribucion")]
    public double PorDistribucion { get; set; }

    [ForeignKey("IdTerminoPago")]
    [InverseProperty("FaTerminoPagoDistribucion")]
    public virtual FaTerminoPago IdTerminoPagoNavigation { get; set; } = null!;
}
