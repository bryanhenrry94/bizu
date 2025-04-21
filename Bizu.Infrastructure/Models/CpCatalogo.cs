using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cp_catalogo")]
[Index("IdCatalogoTipo", Name = "FK_cp_catalogo_cp_catalogo_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpCatalogo
{
    [Key]
    [StringLength(25)]
    public string IdCatalogo { get; set; } = null!;

    [Column("IdCatalogo_tipo")]
    [StringLength(15)]
    public string IdCatalogoTipo { get; set; } = null!;

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

    [InverseProperty("IdEstadoCierreNavigation")]
    public virtual ICollection<CpConciliacionCaja> CpConciliacionCaja { get; set; } = new List<CpConciliacionCaja>();

    [InverseProperty("IdTipoNotaNavigation")]
    public virtual ICollection<CpNotaDebCre> CpNotaDebCre { get; set; } = new List<CpNotaDebCre>();

    [InverseProperty("IdTipoCtaAcreditacionCatNavigation")]
    public virtual ICollection<CpProveedor> CpProveedorIdTipoCtaAcreditacionCatNavigation { get; set; } = new List<CpProveedor>();

    [InverseProperty("IdTipoGastoNavigation")]
    public virtual ICollection<CpProveedor> CpProveedorIdTipoGastoNavigation { get; set; } = new List<CpProveedor>();

    [InverseProperty("IdTipoServicioNavigation")]
    public virtual ICollection<CpProveedor> CpProveedorIdTipoServicioNavigation { get; set; } = new List<CpProveedor>();

    [ForeignKey("IdCatalogoTipo")]
    [InverseProperty("CpCatalogo")]
    public virtual CpCatalogoTipo IdCatalogoTipoNavigation { get; set; } = null!;
}
