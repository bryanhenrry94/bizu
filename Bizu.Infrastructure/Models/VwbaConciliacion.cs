using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwbaConciliacion
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdConciliacion { get; set; }

    public int IdBanco { get; set; }

    public int IdPeriodo { get; set; }

    [Column("co_Fecha")]
    [MaxLength(6)]
    public DateTime CoFecha { get; set; }

    [Column("co_SaldoContable_MesAnt")]
    public double CoSaldoContableMesAnt { get; set; }

    [Column("co_totalIng")]
    public double CoTotalIng { get; set; }

    [Column("co_totalEgr")]
    public double CoTotalEgr { get; set; }

    [Column("co_SaldoContable_MesAct")]
    public double CoSaldoContableMesAct { get; set; }

    [Column("co_SaldoBanco_EstCta")]
    public double CoSaldoBancoEstCta { get; set; }

    [Column("co_Cant_Cheque")]
    public int CoCantCheque { get; set; }

    [Column("co_Cant_Deposito")]
    public int CoCantDeposito { get; set; }

    [Column("co_Cant_NC")]
    public int CoCantNc { get; set; }

    [Column("co_Cant_ND")]
    public int CoCantNd { get; set; }

    [Column("co_TotalCheque")]
    public double CoTotalCheque { get; set; }

    [Column("co_TotalDepositos")]
    public double CoTotalDepositos { get; set; }

    [Column("co_totalNC")]
    public double CoTotalNc { get; set; }

    [Column("co_TotalND")]
    public double CoTotalNd { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [Column("IdUsuario_Anu")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioAnu { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAnulacion { get; set; }

    [Column("ip")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Ip { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPc { get; set; }

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoAnulacion { get; set; }

    [Column("co_Cant_OtrosIng")]
    public int? CoCantOtrosIng { get; set; }

    [Column("co_TotalOtrosIng")]
    public double? CoTotalOtrosIng { get; set; }

    [Column("co_Cant_OtrosEgr")]
    public int? CoCantOtrosEgr { get; set; }

    [Column("co_TotalOtrosEgr")]
    public double? CoTotalOtrosEgr { get; set; }

    [Column("co_Observacion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CoObservacion { get; set; }

    [Column("ba_descripcion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BaDescripcion { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    [StringLength(38)]
    [MySqlCollation("utf8mb4_bin")]
    public string Periodo { get; set; } = null!;

    [Column("co_SaldoBanco_anterior")]
    public double CoSaldoBancoAnterior { get; set; }
}
