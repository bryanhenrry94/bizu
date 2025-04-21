using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_rango_fecha_busqueda_x_periodo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbRangoFechaBusquedaXPeriodo
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    [Column("valor_ini")]
    public int ValorIni { get; set; }

    [Column("valor_fin")]
    public int ValorFin { get; set; }

    [Column("uni_medida")]
    [StringLength(20)]
    public string UniMedida { get; set; } = null!;
}
