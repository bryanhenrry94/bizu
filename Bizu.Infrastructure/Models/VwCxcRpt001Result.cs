using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("vwCXC_Rpt001_Result")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class VwCxcRpt001Result
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

    [Column("vt_Observacion")]
    [StringLength(1000)]
    public string? VtObservacion { get; set; }

    [StringLength(20)]
    public string? CodObra { get; set; }

    public double? TotalCobrado { get; set; }

    [Column("Valor_Vencido")]
    public double? ValorVencido { get; set; }

    [Column("Valor_x_Vencer")]
    public double? ValorXVencer { get; set; }

    [StringLength(10)]
    public string Tipo { get; set; } = null!;

    [Column("Documento_Grupo")]
    [StringLength(104)]
    public string? DocumentoGrupo { get; set; }
}
