using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("caj_Caja_Movimiento_Tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CajCajaMovimientoTipo
{
    [Key]
    public int IdTipoMovi { get; set; }

    [Column("tm_descripcion")]
    [StringLength(50)]
    public string TmDescripcion { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("tm_Signo")]
    [StringLength(1)]
    public string TmSigno { get; set; } = null!;

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

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
    public string? MotivoAnulacion { get; set; }

    public bool SeDeposita { get; set; }

    public int? IdEmpresa { get; set; }

    [InverseProperty("IdTipoMoviNavigation")]
    public virtual ICollection<CajCajaMovimiento> CajCajaMovimiento { get; set; } = new List<CajCajaMovimiento>();

    [InverseProperty("IdTipoMoviNavigation")]
    public virtual ICollection<CajCajaMovimientoTipoXCtaCble> CajCajaMovimientoTipoXCtaCble { get; set; } = new List<CajCajaMovimientoTipoXCtaCble>();

    [InverseProperty("IdTipoMoviNavigation")]
    public virtual ICollection<CpOrdenGiro> CpOrdenGiro { get; set; } = new List<CpOrdenGiro>();

    [InverseProperty("IdTipoMoviCajNavigation")]
    public virtual ICollection<CpOrdenPagoFormapago> CpOrdenPagoFormapago { get; set; } = new List<CpOrdenPagoFormapago>();

    [InverseProperty("PaIdTipoMoviCajaXCobrosXClienteNavigation")]
    public virtual ICollection<CxcParametro> CxcParametro { get; set; } = new List<CxcParametro>();
}
