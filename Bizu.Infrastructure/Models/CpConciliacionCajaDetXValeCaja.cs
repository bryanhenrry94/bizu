using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdConciliacionCaja", "Secuencia")]
[Table("cp_conciliacion_Caja_det_x_ValeCaja")]
[Index("IdEmpresaMovcaja", "IdCbteCbleMovcaja", "IdTipocbteMovcaja", Name = "FK_cp_conciliacion_Caja_det_x_ValeCaja_caj_Caja_Movimiento")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpConciliacionCajaDetXValeCaja
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdConciliacion_Caja")]
    [Precision(18, 0)]
    public decimal IdConciliacionCaja { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Column("IdEmpresa_movcaja")]
    public int IdEmpresaMovcaja { get; set; }

    [Column("IdCbteCble_movcaja")]
    [Precision(18, 0)]
    public decimal IdCbteCbleMovcaja { get; set; }

    [Column("IdTipocbte_movcaja")]
    public int IdTipocbteMovcaja { get; set; }

    [StringLength(20)]
    public string IdCtaCble { get; set; } = null!;

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [ForeignKey("IdEmpresaMovcaja, IdCbteCbleMovcaja, IdTipocbteMovcaja")]
    [InverseProperty("CpConciliacionCajaDetXValeCaja")]
    public virtual CajCajaMovimiento CajCajaMovimiento { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdConciliacionCaja")]
    [InverseProperty("CpConciliacionCajaDetXValeCaja")]
    public virtual CpConciliacionCaja CpConciliacionCaja { get; set; } = null!;
}
