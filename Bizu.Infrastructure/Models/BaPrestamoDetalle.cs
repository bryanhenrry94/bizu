using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdPrestamo", "NumCuota")]
[Table("ba_prestamo_detalle")]
[Index("EstadoPago", Name = "FK_ba_prestamo_detalle_ba_Catalogo1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaPrestamoDetalle
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdPrestamo { get; set; }

    [Key]
    public int NumCuota { get; set; }

    public double SaldoInicial { get; set; }

    public double Interes { get; set; }

    public double AbonoCapital { get; set; }

    public double TotalCuota { get; set; }

    public double Saldo { get; set; }

    [MaxLength(6)]
    public DateTime FechaPago { get; set; }

    [StringLength(50)]
    public string EstadoPago { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("Observacion_det")]
    [StringLength(250)]
    public string ObservacionDet { get; set; } = null!;

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

    [ForeignKey("IdEmpresa, IdPrestamo")]
    [InverseProperty("BaPrestamoDetalle")]
    public virtual BaPrestamo BaPrestamo { get; set; } = null!;

    [InverseProperty("BaPrestamoDetalle")]
    public virtual ICollection<BaPrestamoDetalleCancelacion> BaPrestamoDetalleCancelacion { get; set; } = new List<BaPrestamoDetalleCancelacion>();

    [ForeignKey("EstadoPago")]
    [InverseProperty("BaPrestamoDetalle")]
    public virtual BaCatalogo EstadoPagoNavigation { get; set; } = null!;
}
