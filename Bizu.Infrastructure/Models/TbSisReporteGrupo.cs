using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_sis_reporte_Grupo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSisReporteGrupo
{
    [Key]
    [Column("IdGrupo_Reporte")]
    public int IdGrupoReporte { get; set; }

    [Column("Cod_Grupo_Reporte")]
    [StringLength(20)]
    public string CodGrupoReporte { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    [Column("estado")]
    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [InverseProperty("IdGrupoReporteNavigation")]
    public virtual ICollection<TbSisReporte> TbSisReporte { get; set; } = new List<TbSisReporte>();
}
