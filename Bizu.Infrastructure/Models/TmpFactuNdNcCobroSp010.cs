using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
[Table("tmp_Factu_ND_NC_Cobro_SP010")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class TmpFactuNdNcCobroSp010
{
    public long Orden { get; set; }

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    public int? IdBodega { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    [Column("vt_tipoDoc")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? VtTipoDoc { get; set; }

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCobroTipo { get; set; } = null!;

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeCedulaRuc { get; set; } = null!;

    [Column("numDocumento")]
    [StringLength(125)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumDocumento { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("vt_fecha")]
    [MaxLength(6)]
    public DateTime VtFecha { get; set; }

    [Column("vt_fech_venc")]
    [MaxLength(6)]
    public DateTime? VtFechVenc { get; set; }

    public long? DiasVencidos { get; set; }

    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdEstadoCobro { get; set; }

    public double? Monto { get; set; }

    public double? TotalCobrado { get; set; }

    [Column("Valor_Vencido")]
    public double? ValorVencido { get; set; }

    [Column("Valor_x_Vencer")]
    public double? ValorXVencer { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_0900_ai_ci")]
    public string Tipo { get; set; } = null!;
}
