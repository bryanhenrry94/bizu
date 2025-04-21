using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("st_Catalogo")]
[Index("IdTipoCatalogo", Name = "FK_st_Catalogo_st_CatalogoTipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class StCatalogo
{
    [Key]
    [StringLength(25)]
    public string CodCatalogo { get; set; } = null!;

    public int IdTipoCatalogo { get; set; }

    public int IdCatalogo { get; set; }

    [Column("ca_descripcion")]
    [StringLength(250)]
    public string CaDescripcion { get; set; } = null!;

    [Column("ca_estado")]
    [StringLength(1)]
    public string CaEstado { get; set; } = null!;

    [Column("ca_orden")]
    public int CaOrden { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transaccion")]
    [MaxLength(6)]
    public DateTime? FechaTransaccion { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltModi { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(100)]
    public string? MotivoAnulacion { get; set; }

    [ForeignKey("IdTipoCatalogo")]
    [InverseProperty("StCatalogo")]
    public virtual StCatalogoTipo IdTipoCatalogoNavigation { get; set; } = null!;

    [InverseProperty("IdEstadoRequerimientoNavigation")]
    public virtual ICollection<StRequerimiento> StRequerimientoIdEstadoRequerimientoNavigation { get; set; } = new List<StRequerimiento>();

    [InverseProperty("IdPrioridadNavigation")]
    public virtual ICollection<StRequerimiento> StRequerimientoIdPrioridadNavigation { get; set; } = new List<StRequerimiento>();
}
