using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("cxc_rpt_tmp_Factu_ND_NC_Cobro_SP012")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcRptTmpFactuNdNcCobroSp012
{
    public int Orden { get; set; }

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int? IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    [Column("vt_tipoDoc")]
    [StringLength(20)]
    public string? VtTipoDoc { get; set; }

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    public string IdCobroTipo { get; set; } = null!;

    [Column("Su_Descripcion")]
    [StringLength(60)]
    public string SuDescripcion { get; set; } = null!;

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    public string PeNombreCompleto { get; set; } = null!;

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    public string PeCedulaRuc { get; set; } = null!;

    [Column("numDocumento")]
    [StringLength(51)]
    public string? NumDocumento { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("vt_fecha")]
    [MaxLength(6)]
    public DateTime VtFecha { get; set; }

    [Column("vt_fech_venc")]
    [MaxLength(6)]
    public DateTime? VtFechVenc { get; set; }

    public int? DiasVencidos { get; set; }

    [StringLength(5)]
    public string? IdEstadoCobro { get; set; }

    public double? Monto { get; set; }

    public double? TotalCobrado { get; set; }

    [Column("Valor_Vencido")]
    public double? ValorVencido { get; set; }

    [Column("Valor_x_Vencer")]
    public double? ValorXVencer { get; set; }

    [StringLength(10)]
    public string Tipo { get; set; } = null!;

    [Column("vt_Observacion")]
    [StringLength(500)]
    public string? VtObservacion { get; set; }

    [Column("Valor_x_Vencer_f")]
    public double? ValorXVencerF { get; set; }

    [Column("Vencer_30_Dias")]
    public double? Vencer30Dias { get; set; }

    [Column("Vencer_60_Dias")]
    public double? Vencer60Dias { get; set; }

    [Column("Vencer_90_Dias")]
    public double? Vencer90Dias { get; set; }

    [Column("Mayor_a_90Dias")]
    public double? MayorA90dias { get; set; }
}
