using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_parametro_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbParametroTipo
{
    [Key]
    [StringLength(50)]
    public string IdTipoParam { get; set; } = null!;

    [Column("nom_TipoParam")]
    [StringLength(50)]
    public string NomTipoParam { get; set; } = null!;

    [InverseProperty("IdTipoParamNavigation")]
    public virtual ICollection<TbParametro> TbParametro { get; set; } = new List<TbParametro>();
}
