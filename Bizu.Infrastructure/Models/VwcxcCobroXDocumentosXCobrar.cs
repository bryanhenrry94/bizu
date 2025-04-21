using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcxcCobroXDocumentosXCobrar
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdCobro { get; set; }

    [Column("cr_TotalCobro")]
    public double CrTotalCobro { get; set; }

    [Column("cr_fecha")]
    [MaxLength(6)]
    public DateTime CrFecha { get; set; }

    [Column("cr_fechaCobro")]
    [MaxLength(6)]
    public DateTime CrFechaCobro { get; set; }

    [Column("cr_estado")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CrEstado { get; set; }

    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoCobro { get; set; } = null!;

    [Column("cr_observacion")]
    [StringLength(700)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CrObservacion { get; set; } = null!;

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumDocumento { get; set; }

    [Column("secuencial")]
    public int Secuencial { get; set; }

    [Column("TipoDoc_aplicado")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TipoDocAplicado { get; set; }

    [Column("IdBodega_Cbte_doc_aplica")]
    public int? IdBodegaCbteDocAplica { get; set; }

    [Column("IdCbte_vta_nota")]
    [Precision(18, 0)]
    public decimal IdCbteVtaNota { get; set; }

    [Column("Documento_Aplicado")]
    [StringLength(68)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? DocumentoAplicado { get; set; }

    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Cliente { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCobroTipo { get; set; } = null!;

    public int Saldo { get; set; }

    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Sucursal { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TipoCobro { get; set; } = null!;

    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Bodega { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? EstadoCobro { get; set; }

    [Column("Fecha_vta")]
    [MaxLength(6)]
    public DateTime FechaVta { get; set; }

    [Column("SubTotal_Doc_vta")]
    public double? SubTotalDocVta { get; set; }

    [Column("Iva_Doc_vta")]
    public double? IvaDocVta { get; set; }

    [Column("Total_Doc_vta")]
    public double? TotalDocVta { get; set; }
}
