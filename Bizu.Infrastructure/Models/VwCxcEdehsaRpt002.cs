using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxcEdehsaRpt002
{
    [Column("fila")]
    [Precision(21, 0)]
    public decimal Fila { get; set; }

    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdCobro { get; set; }

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCobroTipo { get; set; } = null!;

    [Column("tc_descripcion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TcDescripcion { get; set; } = null!;

    [Column("cr_Banco")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrBanco { get; set; }

    [Column("cr_cuenta")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrCuenta { get; set; }

    [Column("cr_NumDocumento")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrNumDocumento { get; set; }

    [Column("cr_Tarjeta")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrTarjeta { get; set; }

    [Column("cr_propietarioCta")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrPropietarioCta { get; set; }

    [Column("cr_TotalCobro")]
    public double CrTotalCobro { get; set; }

    [Column("cr_fecha")]
    [MaxLength(6)]
    public DateTime CrFecha { get; set; }

    [Column("cr_fechaDocu")]
    [MaxLength(6)]
    public DateTime CrFechaDocu { get; set; }

    [Column("cr_fechaCobro")]
    [MaxLength(6)]
    public DateTime CrFechaCobro { get; set; }

    [Column("cr_observacion")]
    [StringLength(700)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CrObservacion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [Column("dc_TipoDocumento")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DcTipoDocumento { get; set; }

    [Column("IdBodega_Cbte")]
    public int? IdBodegaCbte { get; set; }

    [Column("IdCbte_vta_nota")]
    [Precision(18, 0)]
    public decimal? IdCbteVtaNota { get; set; }

    [Column("dc_ValorPago")]
    public double DcValorPago { get; set; }

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeCedulaRuc { get; set; } = null!;

    [Column("pe_telefonoCasa")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeTelefonoCasa { get; set; }

    [Column("pe_direccion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeDireccion { get; set; } = null!;

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    public int? IdBanco { get; set; }

    public int IdCaja { get; set; }

    [Column("Documento_Cobrado")]
    [StringLength(69)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DocumentoCobrado { get; set; }

    [Column("secuencial")]
    public int? Secuencial { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCentroCosto { get; set; }
}
