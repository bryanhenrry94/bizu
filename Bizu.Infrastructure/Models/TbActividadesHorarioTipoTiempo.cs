using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_Actividades_Horario_Tipo_Tiempo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbActividadesHorarioTipoTiempo
{
    [Key]
    [StringLength(20)]
    public string IdTipoTiempo { get; set; } = null!;

    [Column("descripcion")]
    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    [InverseProperty("IdTipoTiempoNavigation")]
    public virtual ICollection<TbActividadesHorario> TbActividadesHorario { get; set; } = new List<TbActividadesHorario>();
}
