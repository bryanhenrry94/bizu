using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdConciliacion")]
[Table("cxc_conciliacion")]
[Index("IdEmpresaCbteCble", "IdTipoCbteCbteCble", "IdCbteCbleCbteCble", Name = "FK_cxc_conciliacion_ct_cbtecble")]
[Index("IdEmpresa", "IdCliente", Name = "FK_cxc_conciliacion_fa_cliente")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcConciliacion
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdConciliacion { get; set; }

    public DateOnly Fecha { get; set; }

    [StringLength(250)]
    public string Observacion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal? IdCliente { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [Column("Fecha_Transaccion")]
    [MaxLength(6)]
    public DateTime FechaTransaccion { get; set; }

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

    [Column("nom_pc")]
    [StringLength(25)]
    public string NomPc { get; set; } = null!;

    [Column("ip")]
    [StringLength(25)]
    public string Ip { get; set; } = null!;

    [Column("IdEmpresa_cbte_cble")]
    public int? IdEmpresaCbteCble { get; set; }

    [Column("IdTipoCbte_cbte_cble")]
    public int? IdTipoCbteCbteCble { get; set; }

    [Column("IdCbteCble_cbte_cble")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCbteCble { get; set; }

    [ForeignKey("IdEmpresaCbteCble, IdTipoCbteCbteCble, IdCbteCbleCbteCble")]
    [InverseProperty("CxcConciliacion")]
    public virtual CtCbtecble? CtCbtecble { get; set; }

    [InverseProperty("CxcConciliacion")]
    public virtual ICollection<CxcConciliacionDet> CxcConciliacionDet { get; set; } = new List<CxcConciliacionDet>();

    [ForeignKey("IdEmpresa, IdCliente")]
    [InverseProperty("CxcConciliacion")]
    public virtual FaCliente? FaCliente { get; set; }
}
