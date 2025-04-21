using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxpRpt018
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

    [Column("co_fechaOg")]
    [MaxLength(6)]
    public DateTime CoFechaOg { get; set; }

    [StringLength(72)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Documento { get; set; } = null!;

    [Column("co_FechaFactura")]
    [MaxLength(6)]
    public DateTime CoFechaFactura { get; set; }

    [Column("co_observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoObservacion { get; set; } = null!;

    [Column("co_subtotal_iva")]
    public double CoSubtotalIva { get; set; }

    [Column("co_subtotal_siniva")]
    public double CoSubtotalSiniva { get; set; }

    [Column("co_baseImponible")]
    public double CoBaseImponible { get; set; }

    [Column("co_Por_iva")]
    public double CoPorIva { get; set; }

    [Column("co_valoriva")]
    public double CoValoriva { get; set; }

    [Column("co_total")]
    public double CoTotal { get; set; }

    [Column("co_valorpagar")]
    public double CoValorpagar { get; set; }

    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    public int? IdSucursal { get; set; }

    [Column("Num_Autorizacion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumAutorizacion { get; set; }

    [Precision(18, 0)]
    public decimal IdRetencion { get; set; }

    [Column("serie")]
    [StringLength(7)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Serie { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumRetencion { get; set; }

    [Column("re_tipoRet")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ReTipoRet { get; set; } = null!;

    [Column("re_baseRetencion")]
    public double ReBaseRetencion { get; set; }

    [Column("IdCodigo_SRI")]
    public int IdCodigoSri { get; set; }

    [Column("re_Codigo_impuesto")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ReCodigoImpuesto { get; set; } = null!;

    [Column("re_Porcen_retencion")]
    public double RePorcenRetencion { get; set; }

    [Column("re_valor_retencion")]
    public double ReValorRetencion { get; set; }

    [Column("co_descripcion")]
    [StringLength(350)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoDescripcion { get; set; } = null!;

    [Column("IdTipoSRI")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoSri { get; set; } = null!;

    [Column("nom_proveedor")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProveedor { get; set; }

    [Column("nom_sucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomSucursal { get; set; } = null!;

    [Column("nom_TipoDocumento")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomTipoDocumento { get; set; } = null!;

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeCedulaRuc { get; set; } = null!;
}
