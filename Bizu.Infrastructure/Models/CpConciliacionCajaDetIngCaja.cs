using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdConciliacionCaja", "Secuencia")]
[Table("cp_conciliacion_Caja_det_Ing_Caja")]
[Index("IdEmpresaMovcaj", "IdCbteCbleMovcaj", "IdTipocbteMovcaj", Name = "FK_cp_conciliacion_Caja_det_Ing_Caja_caj_Caja_Movimiento")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpConciliacionCajaDetIngCaja
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("IdConciliacion_Caja")]
    [Precision(18, 0)]
    public decimal IdConciliacionCaja { get; set; }

    [Key]
    [Column("secuencia")]
    public int Secuencia { get; set; }

    [Column("IdEmpresa_movcaj")]
    public int IdEmpresaMovcaj { get; set; }

    [Column("IdCbteCble_movcaj")]
    [Precision(18, 0)]
    public decimal IdCbteCbleMovcaj { get; set; }

    [Column("IdTipocbte_movcaj")]
    public int IdTipocbteMovcaj { get; set; }

    [Column("valor_aplicado")]
    public double ValorAplicado { get; set; }

    [ForeignKey("IdEmpresaMovcaj, IdCbteCbleMovcaj, IdTipocbteMovcaj")]
    [InverseProperty("CpConciliacionCajaDetIngCaja")]
    public virtual CajCajaMovimiento CajCajaMovimiento { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdConciliacionCaja")]
    [InverseProperty("CpConciliacionCajaDetIngCaja")]
    public virtual CpConciliacionCaja CpConciliacionCaja { get; set; } = null!;
}
