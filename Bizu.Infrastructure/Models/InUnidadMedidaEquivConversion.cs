using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdUnidadMedida", "IdUnidadMedidaEquiva")]
[Table("in_UnidadMedida_Equiv_conversion")]
[Index("IdUnidadMedidaEquiva", Name = "FK_in_UnidadMedida_Equiv_conversion_in_UnidadMedida1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InUnidadMedidaEquivConversion
{
    [Key]
    [StringLength(25)]
    public string IdUnidadMedida { get; set; } = null!;

    [Key]
    [Column("IdUnidadMedida_equiva")]
    [StringLength(25)]
    public string IdUnidadMedidaEquiva { get; set; } = null!;

    [Column("valor_equiv")]
    public double ValorEquiv { get; set; }

    [Column("interpretacion")]
    [StringLength(500)]
    public string? Interpretacion { get; set; }

    [ForeignKey("IdUnidadMedidaEquiva")]
    [InverseProperty("InUnidadMedidaEquivConversionIdUnidadMedidaEquivaNavigation")]
    public virtual InUnidadMedida IdUnidadMedidaEquivaNavigation { get; set; } = null!;

    [ForeignKey("IdUnidadMedida")]
    [InverseProperty("InUnidadMedidaEquivConversionIdUnidadMedidaNavigation")]
    public virtual InUnidadMedida IdUnidadMedidaNavigation { get; set; } = null!;
}
