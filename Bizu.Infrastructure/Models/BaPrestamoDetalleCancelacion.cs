using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdPrestamo", "NumCuota", "Secuencia")]
[Table("ba_prestamo_detalle_cancelacion")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaPrestamoDetalleCancelacion
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdPrestamo { get; set; }

    [Key]
    public int NumCuota { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Column("Monto_Canc")]
    public double MontoCanc { get; set; }

    public double Saldo { get; set; }

    [MaxLength(6)]
    public DateTime FechaPago { get; set; }

    [Column("Observacion_canc")]
    [StringLength(250)]
    public string? ObservacionCanc { get; set; }

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

    [ForeignKey("IdEmpresa, IdPrestamo, NumCuota")]
    [InverseProperty("BaPrestamoDetalleCancelacion")]
    public virtual BaPrestamoDetalle BaPrestamoDetalle { get; set; } = null!;
}
