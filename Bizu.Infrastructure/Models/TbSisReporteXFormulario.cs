using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdFormulario", "CodReporte")]
[Table("tb_sis_reporte_x_formulario")]
[Index("CodReporte", Name = "FK_tb_sis_reporte_x_formulario_tb_sis_reporte")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSisReporteXFormulario
{
    [Key]
    [StringLength(250)]
    public string IdFormulario { get; set; } = null!;

    [Key]
    [StringLength(50)]
    public string CodReporte { get; set; } = null!;

    [Column("observacion")]
    [StringLength(50)]
    public string Observacion { get; set; } = null!;

    [ForeignKey("CodReporte")]
    [InverseProperty("TbSisReporteXFormulario")]
    public virtual TbSisReporte CodReporteNavigation { get; set; } = null!;

    [ForeignKey("IdFormulario")]
    [InverseProperty("TbSisReporteXFormulario")]
    public virtual TbSisFormulario IdFormularioNavigation { get; set; } = null!;
}
