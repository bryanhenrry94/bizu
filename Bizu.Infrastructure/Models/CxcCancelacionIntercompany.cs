using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCancelacion")]
[Table("cxc_cancelacion_Intercompany")]
[Index("IdCobroTipo", Name = "FK_cxc_cancelacion_Intercompany_cxc_cobro_tipo")]
[Index("IdEmpresa", "IdCliente", Name = "FK_cxc_cancelacion_Intercompany_fa_cliente")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcCancelacionIntercompany
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCancelacion { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    public string IdCobroTipo { get; set; } = null!;

    [Column("IdBanco_Deposito")]
    public int? IdBancoDeposito { get; set; }

    [StringLength(250)]
    public string? Observacion { get; set; }

    [StringLength(50)]
    public string? PapeletaDeposito { get; set; }

    [Column("cbteban_IdEmpresa")]
    public int? CbtebanIdEmpresa { get; set; }

    [Column("cbteban_IdCbteCble")]
    [Precision(18, 0)]
    public decimal? CbtebanIdCbteCble { get; set; }

    [Column("cbteban_IdTipocbte")]
    public int? CbtebanIdTipocbte { get; set; }

    [Column("cr_TotalCobro")]
    public double? CrTotalCobro { get; set; }

    [Column("cr_fecha")]
    public DateOnly? CrFecha { get; set; }

    [Column("cr_fechaDocu")]
    public DateOnly? CrFechaDocu { get; set; }

    [Column("cr_fechaCobro")]
    public DateOnly? CrFechaCobro { get; set; }

    [Column("cr_observacion")]
    [StringLength(300)]
    public string? CrObservacion { get; set; }

    [Column("cr_Banco")]
    [StringLength(50)]
    public string? CrBanco { get; set; }

    [Column("cr_cuenta")]
    [StringLength(100)]
    public string? CrCuenta { get; set; }

    [Column("cr_NumDocumento")]
    [StringLength(100)]
    public string? CrNumDocumento { get; set; }

    [Column("cr_Tarjeta")]
    [StringLength(50)]
    public string? CrTarjeta { get; set; }

    [Column("cr_propietarioCta")]
    [StringLength(100)]
    public string? CrPropietarioCta { get; set; }

    [Column("cr_estado")]
    [StringLength(1)]
    public string? CrEstado { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

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
    [StringLength(50)]
    public string? Ip { get; set; }

    public int IdSucursal { get; set; }

    [StringLength(1)]
    public string GeneraDeps { get; set; } = null!;

    public int IdCaja { get; set; }

    [StringLength(3)]
    public string? IdTipoNotaCredito { get; set; }

    [InverseProperty("CxcCancelacionIntercompany")]
    public virtual ICollection<CxcCancelacionIntercompanyDet> CxcCancelacionIntercompanyDet { get; set; } = new List<CxcCancelacionIntercompanyDet>();

    [ForeignKey("IdEmpresa, IdCliente")]
    [InverseProperty("CxcCancelacionIntercompany")]
    public virtual FaCliente FaCliente { get; set; } = null!;

    [ForeignKey("IdCobroTipo")]
    [InverseProperty("CxcCancelacionIntercompany")]
    public virtual CxcCobroTipo IdCobroTipoNavigation { get; set; } = null!;
}
