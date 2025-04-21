using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxcEdehsaRpt003
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdCobro { get; set; }

    [Column("secuencial")]
    public int Secuencial { get; set; }

    [Column("IdBodega_Cbte")]
    public int? IdBodegaCbte { get; set; }

    [Column("IdCbte_vta_nota")]
    [Precision(18, 0)]
    public decimal IdCbteVtaNota { get; set; }

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCobroTipo { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodDocumentoTipo { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie1 { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie2 { get; set; }

    [Column("NumNota_Impresa")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumNotaImpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("nom_cliente")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomCliente { get; set; } = null!;

    [Column("sc_observacion", TypeName = "text")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ScObservacion { get; set; } = null!;

    [Column("cr_fecha")]
    [MaxLength(6)]
    public DateTime CrFecha { get; set; }

    [Column("tc_descripcion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TcDescripcion { get; set; } = null!;

    public double? PorcentajeRet { get; set; }

    [Column("dc_ValorPago")]
    public double DcValorPago { get; set; }

    [Column("cr_NumDocumento")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrNumDocumento { get; set; }

    public double? Base { get; set; }

    [Column("num_documento")]
    [StringLength(69)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumDocumento { get; set; }

    [Column("sc_subtotal")]
    public double? ScSubtotal { get; set; }

    [Column("sc_iva")]
    public double? ScIva { get; set; }

    [Column("sc_total")]
    public double? ScTotal { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }

    [Column("cr_observacion", TypeName = "text")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CrObservacion { get; set; } = null!;
}
