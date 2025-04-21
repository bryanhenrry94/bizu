using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdUsuario", "CodReporte")]
[Table("seg_usuario_x_tb_sis_reporte")]
[Index("CodReporte", Name = "FK_seg_usuario_x_tb_sis_reporte_tb_sis_reporte")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class SegUsuarioXTbSisReporte
{
    [Key]
    [StringLength(50)]
    public string IdUsuario { get; set; } = null!;

    [Key]
    [StringLength(50)]
    public string CodReporte { get; set; } = null!;

    [Column("observacion")]
    [StringLength(50)]
    public string Observacion { get; set; } = null!;

    [ForeignKey("CodReporte")]
    [InverseProperty("SegUsuarioXTbSisReporte")]
    public virtual TbSisReporte CodReporteNavigation { get; set; } = null!;

    [ForeignKey("IdUsuario")]
    [InverseProperty("SegUsuarioXTbSisReporte")]
    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;
}
