using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("tbBAN_Rpt007")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbBanRpt007
{
    public int IdEmpresa { get; set; }

    [Column("idTipoFlujo")]
    [Precision(18, 0)]
    public decimal? IdTipoFlujo { get; set; }

    [Column("descripcion_flujo")]
    [StringLength(200)]
    public string? DescripcionFlujo { get; set; }

    [Column("observacion")]
    [StringLength(200)]
    public string? Observacion { get; set; }

    [Column("fecha")]
    [MaxLength(6)]
    public DateTime? Fecha { get; set; }

    [Column("Des_tipo_cbte")]
    [StringLength(100)]
    public string? DesTipoCbte { get; set; }

    [Precision(18, 0)]
    public decimal? IdCbte { get; set; }

    [Column("dc_Valor")]
    public double? DcValor { get; set; }

    [Column("ba_descripcion")]
    [StringLength(100)]
    public string? BaDescripcion { get; set; }

    [Column("tipo")]
    [StringLength(50)]
    public string? Tipo { get; set; }

    [Column("ba_Num_Cuenta")]
    [StringLength(100)]
    public string? BaNumCuenta { get; set; }

    public int? Orden { get; set; }
}
