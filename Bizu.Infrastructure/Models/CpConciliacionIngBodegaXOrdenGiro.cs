using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdConciliacion")]
[Table("cp_Conciliacion_Ing_Bodega_x_Orden_Giro")]
[Index("IdEmpresaAproIng", "IdAprobacionAproIng", Name = "FK_cp_Conciliacion_Ing_Bodega_x_Orden_Giro_cp_Aprobacion_Ing_B37")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpConciliacionIngBodegaXOrdenGiro
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdConciliacion { get; set; }

    [Column("Fecha_Conciliacion")]
    [MaxLength(6)]
    public DateTime FechaConciliacion { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [StringLength(200)]
    public string Observacion { get; set; } = null!;

    [Column("IdEmpresa_Apro_Ing")]
    public int IdEmpresaAproIng { get; set; }

    [Column("IdAprobacion_Apro_Ing")]
    [Precision(18, 0)]
    public decimal IdAprobacionAproIng { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [StringLength(100)]
    public string? MotiAnula { get; set; }

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

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [ForeignKey("IdEmpresaAproIng, IdAprobacionAproIng")]
    [InverseProperty("CpConciliacionIngBodegaXOrdenGiro")]
    public virtual CpAprobacionIngBodXOc CpAprobacionIngBodXOc { get; set; } = null!;
}
