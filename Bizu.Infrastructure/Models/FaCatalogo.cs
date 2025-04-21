using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("fa_catalogo")]
[Index("IdCatalogoTipo", Name = "FK_fa_catalogo_fa_catalogo_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaCatalogo
{
    [Key]
    [StringLength(15)]
    public string IdCatalogo { get; set; } = null!;

    [Column("IdCatalogo_tipo")]
    public int IdCatalogoTipo { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(10)]
    public string? Abrebiatura { get; set; }

    [StringLength(50)]
    public string? NombreIngles { get; set; }

    public int? Orden { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(200)]
    public string? MotiAnula { get; set; }

    [InverseProperty("IdActividadComercialNavigation")]
    public virtual ICollection<FaCliente> FaCliente { get; set; } = new List<FaCliente>();

    [InverseProperty("IdEstadoObraNavigation")]
    public virtual ICollection<FaClienteObra> FaClienteObra { get; set; } = new List<FaClienteObra>();

    [ForeignKey("IdCatalogoTipo")]
    [InverseProperty("FaCatalogo")]
    public virtual FaCatalogoTipo IdCatalogoTipoNavigation { get; set; } = null!;
}
