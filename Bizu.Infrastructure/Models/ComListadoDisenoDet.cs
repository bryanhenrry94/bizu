using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdListadoDiseno", "IdDetalle")]
[Table("com_ListadoDiseno_Det")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComListadoDisenoDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdListadoDiseno { get; set; }

    [Key]
    public int IdDetalle { get; set; }

    [StringLength(20)]
    public string CodObra { get; set; } = null!;

    [Precision(18, 0)]
    public decimal? IdOrdenTaller { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    public double Unidades { get; set; }

    [Column("Det_Kg")]
    public double DetKg { get; set; }

    [StringLength(25)]
    public string IdEstadoAprob { get; set; } = null!;
}
