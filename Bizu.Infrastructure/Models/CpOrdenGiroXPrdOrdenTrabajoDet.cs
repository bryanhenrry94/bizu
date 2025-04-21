using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresaOgiro", "IdCbteCbleOgiro", "IdTipoCbteOgiro", "IdEmpresaOt", "IdSucursalOt", "IdOrdenTrabajo", "SecuenciaOt", "SecuenciaReg")]
[Table("cp_orden_giro_x_prd_OrdenTrabajo_Det")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpOrdenGiroXPrdOrdenTrabajoDet
{
    [Key]
    [Column("IdEmpresa_Ogiro")]
    public int IdEmpresaOgiro { get; set; }

    [Key]
    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal IdCbteCbleOgiro { get; set; }

    [Key]
    [Column("IdTipoCbte_Ogiro")]
    public int IdTipoCbteOgiro { get; set; }

    [Key]
    [Column("IdEmpresa_OT")]
    public int IdEmpresaOt { get; set; }

    [Key]
    [Column("IdSucursal_OT")]
    public int IdSucursalOt { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdOrdenTrabajo { get; set; }

    [Key]
    [Column("Secuencia_OT")]
    public int SecuenciaOt { get; set; }

    [Key]
    [Column("Secuencia_reg")]
    public int SecuenciaReg { get; set; }

    [StringLength(250)]
    public string Observacion { get; set; } = null!;
}
