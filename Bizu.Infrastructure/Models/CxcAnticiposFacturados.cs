using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdAnticipo")]
[Table("cxc_anticipos_facturados")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcAnticiposFacturados
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdAnticipo { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    public int? IdCaja { get; set; }

    public double Valor { get; set; }

    [MaxLength(6)]
    public DateTime? Fecha { get; set; }

    [StringLength(250)]
    public string? Observacion { get; set; }

    [Column("IdEmpresa_cb")]
    public int? IdEmpresaCb { get; set; }

    [Column("IdSucursal_cb")]
    public int? IdSucursalCb { get; set; }

    [Column("IdCobro_cb")]
    [Precision(18, 0)]
    public decimal? IdCobroCb { get; set; }

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

    [StringLength(50)]
    public string? MotiAnula { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [StringLength(1)]
    public string? Estado { get; set; }
}
