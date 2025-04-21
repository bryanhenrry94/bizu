using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCajRpt006
{
    [Precision(21, 0)]
    public decimal IdRow { get; set; }

    public int IdEmpresa { get; set; }

    [Column("IdConciliacion_Caja")]
    [Precision(18, 0)]
    public decimal IdConciliacionCaja { get; set; }

    public int Secuencia { get; set; }

    [Column("IdEmpresa_OGiro")]
    public int IdEmpresaOgiro { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int IdTipoCbteOgiro { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal IdCbteCbleOgiro { get; set; }

    [Column("co_fechaOg")]
    [MaxLength(6)]
    public DateTime CoFechaOg { get; set; }

    [Precision(18, 0)]
    public decimal? IdProveedor { get; set; }

    [Column("pr_codigo")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrCodigo { get; set; }

    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    [Column("pe_nombreCompleto")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNombreCompleto { get; set; } = null!;

    public int IdTipoMovi { get; set; }

    [Column("nom_tipo_movi")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomTipoMovi { get; set; } = null!;

    [Column("co_factura")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CoFactura { get; set; }

    [Column("Num_Autorizacion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumAutorizacion { get; set; }

    [Column("co_subtotal_iva")]
    public double CoSubtotalIva { get; set; }

    [Column("co_subtotal_siniva")]
    public double CoSubtotalSiniva { get; set; }

    [Column("co_valoriva")]
    public double CoValoriva { get; set; }

    [Column("co_valorpagar")]
    public double CoValorpagar { get; set; }

    [Column("Valor_a_aplicar")]
    public double ValorAAplicar { get; set; }

    public int IdCaja { get; set; }

    [Column("nom_caja")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomCaja { get; set; } = null!;

    public int IdPeriodo { get; set; }

    [Column("Fecha_ini")]
    [MaxLength(6)]
    public DateTime? FechaIni { get; set; }

    [Column("Fecha_fin")]
    [MaxLength(6)]
    public DateTime? FechaFin { get; set; }

    [Column("Fecha_conci")]
    [MaxLength(6)]
    public DateTime FechaConci { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoCierre { get; set; } = null!;

    [Column("IdOrden_giro_Tipo")]
    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdOrdenGiroTipo { get; set; }

    [Column("tipo_documento")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TipoDocumento { get; set; } = null!;

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("nom_punto_cargo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPuntoCargo { get; set; }
}
