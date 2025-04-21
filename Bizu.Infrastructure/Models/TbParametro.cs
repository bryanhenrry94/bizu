using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_parametro")]
[Index("IdTipoParam", Name = "FK_tb_parametro_tb_parametro_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbParametro
{
    [Key]
    [StringLength(50)]
    public string IdParametro { get; set; } = null!;

    [StringLength(50)]
    public string IdTipoParam { get; set; } = null!;

    [StringLength(50)]
    public string Valor { get; set; } = null!;

    [Column("descripcion")]
    [StringLength(400)]
    public string? Descripcion { get; set; }

    [ForeignKey("IdTipoParam")]
    [InverseProperty("TbParametro")]
    public virtual TbParametroTipo IdTipoParamNavigation { get; set; } = null!;
}
