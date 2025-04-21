using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_persona_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbPersonaTipo
{
    [Key]
    [Column("IdTipo_Persona")]
    [StringLength(20)]
    public string IdTipoPersona { get; set; } = null!;

    [StringLength(50)]
    public string? Descricpion { get; set; }

    [InverseProperty("IdTipoPersonaNavigation")]
    public virtual ICollection<CajCajaMovimiento> CajCajaMovimiento { get; set; } = new List<CajCajaMovimiento>();
}
