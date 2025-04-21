using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tbCXP_Rpt001")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbCxpRpt001
{
    [Key]
    [Column("secuencia")]
    [Precision(18, 0)]
    public decimal Secuencia { get; set; }

    public int IdEmpresa { get; set; }

    public int N { get; set; }

    [Column("IdOrden_giro_Tipo")]
    [StringLength(150)]
    public string IdOrdenGiroTipo { get; set; } = null!;

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal IdCbteCbleOgiro { get; set; }

    [Column("co_serie")]
    [StringLength(10)]
    public string CoSerie { get; set; } = null!;

    [Column("co_factura")]
    [StringLength(15)]
    public string CoFactura { get; set; } = null!;

    [Column("co_FechaFactura")]
    [MaxLength(6)]
    public DateTime? CoFechaFactura { get; set; }

    [Column("co_plazo")]
    public int CoPlazo { get; set; }

    [Column("co_FechaFactura_vct")]
    [MaxLength(6)]
    public DateTime? CoFechaFacturaVct { get; set; }

    [Column("co_observacion")]
    [StringLength(500)]
    public string CoObservacion { get; set; } = null!;

    [Column("tipPag")]
    [StringLength(6)]
    public string TipPag { get; set; } = null!;

    [StringLength(20)]
    public string? IdCbte { get; set; }

    [Column("NCheq")]
    [StringLength(25)]
    public string? Ncheq { get; set; }

    [StringLength(150)]
    public string? Banco { get; set; }

    public double Haber { get; set; }

    public double? Debe { get; set; }

    [Column("SaldoOG")]
    public double? SaldoOg { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("IdEmpresaOP")]
    public int? IdEmpresaOp { get; set; }

    [Precision(18, 0)]
    public decimal? IdOrdenPago { get; set; }

    [Column("SecuenciaOP")]
    public int? SecuenciaOp { get; set; }
}
