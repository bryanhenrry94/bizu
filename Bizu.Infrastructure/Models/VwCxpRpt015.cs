using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxpRpt015
{
    public int IdEmpresa { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal IdCbteCbleOgiro { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int IdTipoCbteOgiro { get; set; }

    [Column("IdOrden_giro_Tipo")]
    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdOrdenGiroTipo { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("nom_proveedor")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProveedor { get; set; }

    [Column("ced_proveedor")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CedProveedor { get; set; } = null!;

    [Column("dir_proveedor")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DirProveedor { get; set; } = null!;

    [Column("co_fechaOg")]
    [MaxLength(6)]
    public DateTime CoFechaOg { get; set; }

    [Column("co_serie")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoSerie { get; set; } = null!;

    [Column("num_factura")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NumFactura { get; set; } = null!;

    [Column("co_FechaFactura")]
    [MaxLength(6)]
    public DateTime CoFechaFactura { get; set; }

    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TipoDocumento { get; set; } = null!;

    [Column("fecha_retencion")]
    public DateOnly FechaRetencion { get; set; }

    [Column("ejercicio_fiscal")]
    public int? EjercicioFiscal { get; set; }

    [Precision(18, 0)]
    public decimal IdRetencion { get; set; }

    public int Idsecuencia { get; set; }

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Impuesto { get; set; } = null!;

    [Column("base_retencion")]
    public double BaseRetencion { get; set; }

    [Column("IdCodigo_SRI")]
    public int IdCodigoSri { get; set; }

    [Column("cod_Impuesto_SRI")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodImpuestoSri { get; set; } = null!;

    [Column("por_Retencion_SRI")]
    public double PorRetencionSri { get; set; }

    [Column("valor_Retenido")]
    public double ValorRetenido { get; set; }

    [Column("IdEmpresa_Ogiro")]
    public int? IdEmpresaOgiro { get; set; }

    [Column("serie")]
    [StringLength(7)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumRetencion { get; set; }

    [Column("co_descripcion")]
    [StringLength(350)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoDescripcion { get; set; } = null!;
}
