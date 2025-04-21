using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("fa_formaPago")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaFormaPago
{
    [Key]
    [StringLength(2)]
    public string IdFormaPago { get; set; } = null!;

    [Column("nom_FormaPago")]
    [StringLength(500)]
    public string NomFormaPago { get; set; } = null!;

    [InverseProperty("IdFormaPagoNavigation")]
    public virtual ICollection<FaFacturaXFormaPago> FaFacturaXFormaPago { get; set; } = new List<FaFacturaXFormaPago>();
}
