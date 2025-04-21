using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdTransferencia", "IdEmpresaOrigen")]
[Table("ba_transferencia")]
[Index("IdEmpresaOrigen", "IdBancoOrigen", Name = "FK_ba_transferencia_ba_Banco_Cuenta")]
[Index("IdEmpresaDestino", "IdBancoDestino", Name = "FK_ba_transferencia_ba_Banco_Cuenta1")]
[Index("IdEmpresaOrigen", "IdCbteCbleOrigen", "IdTipocbteOrigen", Name = "FK_ba_transferencia_ba_Cbte_Ban")]
[Index("IdEmpresaDestino", "IdCbteCbleDestino", "IdTipocbteDestino", Name = "FK_ba_transferencia_ba_Cbte_Ban1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaTransferencia
{
    [Key]
    [Precision(18, 0)]
    public decimal IdTransferencia { get; set; }

    [Key]
    [Column("IdEmpresa_origen")]
    public int IdEmpresaOrigen { get; set; }

    [Column("IdCbteCble_origen")]
    [Precision(18, 0)]
    public decimal IdCbteCbleOrigen { get; set; }

    [Column("IdTipocbte_origen")]
    public int IdTipocbteOrigen { get; set; }

    [Column("IdEmpresa_destino")]
    public int IdEmpresaDestino { get; set; }

    [Column("IdCbteCble_destino")]
    [Precision(18, 0)]
    public decimal IdCbteCbleDestino { get; set; }

    [Column("IdTipocbte_destino")]
    public int IdTipocbteDestino { get; set; }

    [Column("IdBanco_origen")]
    public int IdBancoOrigen { get; set; }

    [Column("IdBanco_destino")]
    public int IdBancoDestino { get; set; }

    [Column("tr_observacion")]
    [StringLength(700)]
    public string TrObservacion { get; set; } = null!;

    [Column("tr_valor")]
    public double TrValor { get; set; }

    [Column("tr_fecha")]
    public DateOnly TrFecha { get; set; }

    [Column("tr_estado")]
    [StringLength(1)]
    public string? TrEstado { get; set; }

    [StringLength(50)]
    public string? IdUsuario { get; set; }

    [Column("IdUsuario_Anu")]
    [StringLength(10)]
    public string? IdUsuarioAnu { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAnulacion { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(50)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("tr_MotivoAnulacion")]
    [StringLength(250)]
    public string? TrMotivoAnulacion { get; set; }

    [ForeignKey("IdEmpresaDestino, IdBancoDestino")]
    [InverseProperty("BaTransferenciaBaBancoCuenta")]
    public virtual BaBancoCuenta BaBancoCuenta { get; set; } = null!;

    [ForeignKey("IdEmpresaOrigen, IdBancoOrigen")]
    [InverseProperty("BaTransferenciaBaBancoCuentaNavigation")]
    public virtual BaBancoCuenta BaBancoCuentaNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresaDestino, IdCbteCbleDestino, IdTipocbteDestino")]
    [InverseProperty("BaTransferenciaBaCbteBan")]
    public virtual BaCbteBan BaCbteBan { get; set; } = null!;

    [ForeignKey("IdEmpresaOrigen, IdCbteCbleOrigen, IdTipocbteOrigen")]
    [InverseProperty("BaTransferenciaBaCbteBanNavigation")]
    public virtual BaCbteBan BaCbteBanNavigation { get; set; } = null!;
}
