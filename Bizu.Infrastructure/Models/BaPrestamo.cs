using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdPrestamo")]
[Table("ba_prestamo")]
[Index("IdMetCalc", Name = "FK_ba_prestamo_ba_Catalogo")]
[Index("IdMotivoPrestamo", Name = "FK_ba_prestamo_ba_Catalogo1")]
[Index("IdTipoPago", Name = "FK_ba_prestamo_ba_Catalogo2")]
[Index("IdEmpresa", "IdTipoFlujo", Name = "FK_ba_prestamo_ba_TipoFlujo")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_ba_prestamo_ct_plancta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaPrestamo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdPrestamo { get; set; }

    [StringLength(50)]
    public string CodPrestamo { get; set; } = null!;

    public int IdBanco { get; set; }

    [StringLength(50)]
    public string? IdMetCalc { get; set; }

    [Column("IdMotivo_Prestamo")]
    [StringLength(50)]
    public string IdMotivoPrestamo { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    public double MontoSol { get; set; }

    public double TasaInteres { get; set; }

    public double TotalPrestamo { get; set; }

    public int NumCuotas { get; set; }

    [Column("IdTipo_Pago")]
    [StringLength(50)]
    public string IdTipoPago { get; set; } = null!;

    [Column("Fecha_PriPago")]
    [MaxLength(6)]
    public DateTime FechaPriPago { get; set; }

    [StringLength(250)]
    public string Observacion { get; set; } = null!;

    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(200)]
    public string? MotiAnula { get; set; }

    [Precision(18, 0)]
    public decimal? IdTipoFlujo { get; set; }

    [StringLength(20)]
    public string? IdCtaCble { get; set; }

    [Column("Pago_contado")]
    public double? PagoContado { get; set; }

    [Precision(18, 0)]
    public decimal? IdCliente { get; set; }

    [InverseProperty("BaPrestamo")]
    public virtual ICollection<BaPrestamoDetalle> BaPrestamoDetalle { get; set; } = new List<BaPrestamoDetalle>();

    [ForeignKey("IdEmpresa, IdTipoFlujo")]
    [InverseProperty("BaPrestamo")]
    public virtual BaTipoFlujo? BaTipoFlujo { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("BaPrestamo")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdMetCalc")]
    [InverseProperty("BaPrestamoIdMetCalcNavigation")]
    public virtual BaCatalogo? IdMetCalcNavigation { get; set; }

    [ForeignKey("IdMotivoPrestamo")]
    [InverseProperty("BaPrestamoIdMotivoPrestamoNavigation")]
    public virtual BaCatalogo IdMotivoPrestamoNavigation { get; set; } = null!;

    [ForeignKey("IdTipoPago")]
    [InverseProperty("BaPrestamoIdTipoPagoNavigation")]
    public virtual BaCatalogo IdTipoPagoNavigation { get; set; } = null!;
}
