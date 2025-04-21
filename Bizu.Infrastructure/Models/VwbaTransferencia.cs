using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwbaTransferencia
{
    [Precision(18, 0)]
    public decimal IdTransferencia { get; set; }

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

    [Column("IdBanco_destino")]
    public int IdBancoDestino { get; set; }

    [Column("IdBanco_origen")]
    public int IdBancoOrigen { get; set; }

    [Column("tr_observacion")]
    [StringLength(700)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TrObservacion { get; set; } = null!;

    [Column("tr_valor")]
    public double TrValor { get; set; }

    [Column("tr_fecha")]
    public DateOnly TrFecha { get; set; }

    [Column("tr_estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TrEstado { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [Column("IdUsuario_Anu")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioAnu { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAnulacion { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltMod { get; set; }

    [Column("ip")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Ip { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPc { get; set; }

    [Column("tr_MotivoAnulacion")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TrMotivoAnulacion { get; set; }

    [Column("NEmpresaOrigen")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NempresaOrigen { get; set; } = null!;

    [Column("NEmpresaDestino")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NempresaDestino { get; set; } = null!;

    [Column("NBancoOrigen")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NbancoOrigen { get; set; } = null!;

    [Column("NBancoDestino")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NbancoDestino { get; set; } = null!;
}
