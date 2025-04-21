using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdPeriodo", "IdModulo")]
[Table("ct_periodo_x_tb_modulo")]
[Index("IdModulo", Name = "FK_ct_periodo_x_tb_modulo_tb_modulo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CtPeriodoXTbModulo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdPeriodo { get; set; }

    [Key]
    [StringLength(20)]
    public string IdModulo { get; set; } = null!;

    public bool Cerrado { get; set; }

    [StringLength(50)]
    public string? IdUsuario { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltModi { get; set; }

    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [MaxLength(6)]
    public DateTime? FechaUltModi { get; set; }

    [ForeignKey("IdEmpresa, IdPeriodo")]
    [InverseProperty("CtPeriodoXTbModulo")]
    public virtual CtPeriodo CtPeriodo { get; set; } = null!;

    [ForeignKey("IdModulo")]
    [InverseProperty("CtPeriodoXTbModulo")]
    public virtual TbModulo IdModuloNavigation { get; set; } = null!;
}
