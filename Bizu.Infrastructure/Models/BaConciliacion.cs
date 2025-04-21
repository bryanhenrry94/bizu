using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdConciliacion")]
[Table("ba_Conciliacion")]
[Index("IdEmpresa", "IdBanco", Name = "FK_ba_Conciliacion_ba_Banco_Cuenta")]
[Index("IdEstadoConcilCat", Name = "FK_ba_Conciliacion_ba_Catalogo")]
[Index("IdEmpresa", "IdPeriodo", Name = "FK_ba_Conciliacion_ct_periodo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaConciliacion
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdConciliacion { get; set; }

    public int IdBanco { get; set; }

    public int IdPeriodo { get; set; }

    [Column("co_Fecha")]
    [MaxLength(6)]
    public DateTime CoFecha { get; set; }

    [Column("IdEstado_Concil_Cat")]
    [StringLength(50)]
    public string IdEstadoConcilCat { get; set; } = null!;

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
    public string Estado { get; set; } = null!;

    [StringLength(50)]
    public string? IdUsuario { get; set; }

    [Column("IdUsuario_Anu")]
    [StringLength(50)]
    public string? IdUsuarioAnu { get; set; }

    [StringLength(50)]
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
    public string? Ip { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [StringLength(250)]
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
    public string? CoObservacion { get; set; }

    [Column("co_SaldoBanco_anterior")]
    public double CoSaldoBancoAnterior { get; set; }

    [ForeignKey("IdEmpresa, IdBanco")]
    [InverseProperty("BaConciliacion")]
    public virtual BaBancoCuenta BaBancoCuenta { get; set; } = null!;

    [InverseProperty("BaConciliacion")]
    public virtual ICollection<BaConciliacionDetIngEgr> BaConciliacionDetIngEgr { get; set; } = new List<BaConciliacionDetIngEgr>();

    [ForeignKey("IdEmpresa, IdPeriodo")]
    [InverseProperty("BaConciliacion")]
    public virtual CtPeriodo CtPeriodo { get; set; } = null!;

    [ForeignKey("IdEstadoConcilCat")]
    [InverseProperty("BaConciliacion")]
    public virtual BaCatalogo IdEstadoConcilCatNavigation { get; set; } = null!;
}
