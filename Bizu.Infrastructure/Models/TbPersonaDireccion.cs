using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdPersona", "IdDireccion")]
[Table("tb_persona_direccion")]
[Index("IdTipoDireccion", Name = "FK_tb_persona_direccion_tb_persona_direccion_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbPersonaDireccion
{
    [Key]
    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    [Key]
    public int IdDireccion { get; set; }

    [Column("prioridad")]
    public int Prioridad { get; set; }

    [StringLength(1500)]
    public string Direccion { get; set; } = null!;

    [Column("referencia")]
    [StringLength(50)]
    public string? Referencia { get; set; }

    [Column("calle")]
    [StringLength(50)]
    public string? Calle { get; set; }

    [Column("cod_postal")]
    [StringLength(50)]
    public string? CodPostal { get; set; }

    [StringLength(10)]
    public string? IdPais { get; set; }

    [StringLength(50)]
    public string? Provincia { get; set; }

    [StringLength(50)]
    public string? Ciudad { get; set; }

    [Column("estado")]
    public bool Estado { get; set; }

    public int IdTipoDireccion { get; set; }

    [ForeignKey("IdPersona")]
    [InverseProperty("TbPersonaDireccion")]
    public virtual TbPersona IdPersonaNavigation { get; set; } = null!;

    [ForeignKey("IdTipoDireccion")]
    [InverseProperty("TbPersonaDireccion")]
    public virtual TbPersonaDireccionTipo IdTipoDireccionNavigation { get; set; } = null!;
}
