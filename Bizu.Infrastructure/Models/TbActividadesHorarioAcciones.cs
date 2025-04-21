using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdTransaccion", "IdAccion")]
[Table("tb_Actividades_Horario_Acciones")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbActividadesHorarioAcciones
{
    [Key]
    [StringLength(20)]
    public string IdTransaccion { get; set; } = null!;

    [Key]
    [StringLength(20)]
    public string IdAccion { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    public int TiempoEspera { get; set; }

    [Column("Secuencia_ejecucion")]
    public int SecuenciaEjecucion { get; set; }

    [ForeignKey("IdTransaccion")]
    [InverseProperty("TbActividadesHorarioAcciones")]
    public virtual TbActividadesHorario IdTransaccionNavigation { get; set; } = null!;
}
