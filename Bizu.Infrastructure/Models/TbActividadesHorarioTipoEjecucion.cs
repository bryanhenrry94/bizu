using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_Actividades_Horario_Tipo_Ejecucion")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbActividadesHorarioTipoEjecucion
{
    [Key]
    [StringLength(20)]
    public string IdTipoEjecucion { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    [InverseProperty("IdTipoEjecucionNavigation")]
    public virtual ICollection<TbActividadesHorario> TbActividadesHorario { get; set; } = new List<TbActividadesHorario>();
}
