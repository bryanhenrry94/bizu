using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("ba_Catalogo")]
[Index("IdTipoCatalogo", Name = "FK_ba_Catalogo_ba_CatalogoTipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaCatalogo
{
    [Key]
    [StringLength(50)]
    public string IdCatalogo { get; set; } = null!;

    [StringLength(10)]
    public string IdTipoCatalogo { get; set; } = null!;

    [Column("ca_descripcion")]
    [StringLength(250)]
    public string CaDescripcion { get; set; } = null!;

    [Column("ca_estado")]
    [StringLength(1)]
    public string CaEstado { get; set; } = null!;

    [Column("ca_orden")]
    public int CaOrden { get; set; }

    [StringLength(50)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(200)]
    public string? MotiAnula { get; set; }

    [InverseProperty("IdEstadoRegistroCatNavigation")]
    public virtual ICollection<BaArchivoTransferenciaDet> BaArchivoTransferenciaDet { get; set; } = new List<BaArchivoTransferenciaDet>();

    [InverseProperty("IdEstadoArchivoCatNavigation")]
    public virtual ICollection<BaArchivoTransferencia> BaArchivoTransferenciaIdEstadoArchivoCatNavigation { get; set; } = new List<BaArchivoTransferencia>();

    [InverseProperty("IdMotivoArchivoCatNavigation")]
    public virtual ICollection<BaArchivoTransferencia> BaArchivoTransferenciaIdMotivoArchivoCatNavigation { get; set; } = new List<BaArchivoTransferencia>();

    [InverseProperty("IdEstadoCbteBanCatNavigation")]
    public virtual ICollection<BaCbteBan> BaCbteBanIdEstadoCbteBanCatNavigation { get; set; } = new List<BaCbteBan>();

    [InverseProperty("IdEstadoChequeCatNavigation")]
    public virtual ICollection<BaCbteBan> BaCbteBanIdEstadoChequeCatNavigation { get; set; } = new List<BaCbteBan>();

    [InverseProperty("IdEstadoConcilCatNavigation")]
    public virtual ICollection<BaConciliacion> BaConciliacion { get; set; } = new List<BaConciliacion>();

    [InverseProperty("EstadoPagoNavigation")]
    public virtual ICollection<BaPrestamoDetalle> BaPrestamoDetalle { get; set; } = new List<BaPrestamoDetalle>();

    [InverseProperty("IdMetCalcNavigation")]
    public virtual ICollection<BaPrestamo> BaPrestamoIdMetCalcNavigation { get; set; } = new List<BaPrestamo>();

    [InverseProperty("IdMotivoPrestamoNavigation")]
    public virtual ICollection<BaPrestamo> BaPrestamoIdMotivoPrestamoNavigation { get; set; } = new List<BaPrestamo>();

    [InverseProperty("IdTipoPagoNavigation")]
    public virtual ICollection<BaPrestamo> BaPrestamoIdTipoPagoNavigation { get; set; } = new List<BaPrestamo>();

    [ForeignKey("IdTipoCatalogo")]
    [InverseProperty("BaCatalogo")]
    public virtual BaCatalogoTipo IdTipoCatalogoNavigation { get; set; } = null!;
}
