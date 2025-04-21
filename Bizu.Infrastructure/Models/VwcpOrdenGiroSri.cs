using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcpOrdenGiroSri
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

    [Column("co_serie")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoSerie { get; set; } = null!;

    [Column("co_factura")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoFactura { get; set; } = null!;

    [Column("co_FechaFactura")]
    [MaxLength(6)]
    public DateTime CoFechaFactura { get; set; }

    [Column("co_FechaContabilizacion")]
    [MaxLength(6)]
    public DateTime? CoFechaContabilizacion { get; set; }

    [Column("co_FechaFactura_vct")]
    [MaxLength(6)]
    public DateTime CoFechaFacturaVct { get; set; }

    [Column("co_observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoObservacion { get; set; } = null!;

    [Column("co_total")]
    public double CoTotal { get; set; }

    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoDocumento { get; set; } = null!;

    [Column("pe_cedulaRuc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeCedulaRuc { get; set; } = null!;

    [Column("pe_razonSocial")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PeRazonSocial { get; set; }

    [Column("pe_Naturaleza")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PeNaturaleza { get; set; } = null!;

    [Column("co_vaCoa")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CoVaCoa { get; set; } = null!;

    [Column("IdIden_credito")]
    public int? IdIdenCredito { get; set; }

    [Column("IdCod_101")]
    public int? IdCod101 { get; set; }

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

    [Column("IdCod_ICE")]
    public int? IdCodIce { get; set; }

    [Column("co_Ice_base")]
    public double CoIceBase { get; set; }

    [Column("co_Ice_por")]
    public double CoIcePor { get; set; }

    [Column("co_Ice_valor")]
    public double CoIceValor { get; set; }

    [Column("co_Serv_por")]
    public double CoServPor { get; set; }

    [Column("co_Serv_valor")]
    public double CoServValor { get; set; }

    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PagoLocExt { get; set; }

    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PaisPago { get; set; }

    [Column("Num_Autorizacion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumAutorizacion { get; set; }

    [Column("cp_es_comprobante_electronico")]
    public bool? CpEsComprobanteElectronico { get; set; }

    [Column("es_empresa_relacionada")]
    public bool? EsEmpresaRelacionada { get; set; }

    [Column("Tipodoc_a_Modificar")]
    [StringLength(2)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TipodocAModificar { get; set; }

    [Column("estable_a_Modificar")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? EstableAModificar { get; set; }

    [Column("ptoEmi_a_Modificar")]
    [StringLength(3)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PtoEmiAModificar { get; set; }

    [Column("num_docu_Modificar")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumDocuModificar { get; set; }

    [Column("aut_doc_Modificar")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? AutDocModificar { get; set; }
}
