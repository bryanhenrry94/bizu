using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_persona_direccion_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbPersonaDireccionTipo
{
    [Key]
    public int IdTipoDireccion { get; set; }

    [Column("nom_TipoDireccion")]
    [StringLength(50)]
    public string NomTipoDireccion { get; set; } = null!;

    [InverseProperty("IdTipoDireccionNavigation")]
    public virtual ICollection<TbPersonaDireccion> TbPersonaDireccion { get; set; } = new List<TbPersonaDireccion>();
}
