using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("Af_Catalogo")]
[Index("IdTipoCatalogo", Name = "FK_Af_Catalogo_Af_CatalogoTipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfCatalogo
{
    [Key]
    [StringLength(35)]
    public string IdCatalogo { get; set; } = null!;

    [StringLength(25)]
    public string IdTipoCatalogo { get; set; } = null!;

    [StringLength(250)]
    public string Descripcion { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    public int Orden { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    public DateOnly? FechaUltMod { get; set; }

    [StringLength(25)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    public DateOnly? FechaUltAnu { get; set; }

    [StringLength(100)]
    public string? MotiAnula { get; set; }

    [InverseProperty("EstadoProcesoNavigation")]
    public virtual ICollection<AfActivoFijo> AfActivoFijoEstadoProcesoNavigation { get; set; } = new List<AfActivoFijo>();

    [InverseProperty("IdCatalogoColorNavigation")]
    public virtual ICollection<AfActivoFijo> AfActivoFijoIdCatalogoColorNavigation { get; set; } = new List<AfActivoFijo>();

    [InverseProperty("IdCatalogoMarcaNavigation")]
    public virtual ICollection<AfActivoFijo> AfActivoFijoIdCatalogoMarcaNavigation { get; set; } = new List<AfActivoFijo>();

    [InverseProperty("IdCatalogoModeloNavigation")]
    public virtual ICollection<AfActivoFijo> AfActivoFijoIdCatalogoModeloNavigation { get; set; } = new List<AfActivoFijo>();

    [InverseProperty("IdTipoCatalogoUbicacionNavigation")]
    public virtual ICollection<AfActivoFijo> AfActivoFijoIdTipoCatalogoUbicacionNavigation { get; set; } = new List<AfActivoFijo>();

    [InverseProperty("IdTipoCatalogoUbicacionActuNavigation")]
    public virtual ICollection<AfCambioUbicacionActivo> AfCambioUbicacionActivoIdTipoCatalogoUbicacionActuNavigation { get; set; } = new List<AfCambioUbicacionActivo>();

    [InverseProperty("IdTipoCatalogoUbicacionAntNavigation")]
    public virtual ICollection<AfCambioUbicacionActivo> AfCambioUbicacionActivoIdTipoCatalogoUbicacionAntNavigation { get; set; } = new List<AfCambioUbicacionActivo>();

    [InverseProperty("IdCatalogoNavigation")]
    public virtual ICollection<AfTipoTransacXCtaCbteCble> AfTipoTransacXCtaCbteCble { get; set; } = new List<AfTipoTransacXCtaCbteCble>();

    [ForeignKey("IdTipoCatalogo")]
    [InverseProperty("AfCatalogo")]
    public virtual AfCatalogoTipo IdTipoCatalogoNavigation { get; set; } = null!;
}
