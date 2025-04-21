using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxpRpt001
{
    [Precision(21, 0)]
    public decimal IdRow { get; set; }

    public int IdEmpresa { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleOgiro { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int? IdTipoCbteOgiro { get; set; }

    [Column("IdOrden_giro_Tipo")]
    [StringLength(5)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdOrdenGiroTipo { get; set; }

    [StringLength(93)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Documento { get; set; } = null!;

    [Column("nom_tipo_doc")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomTipoDoc { get; set; }

    [Column("cod_tipo_doc")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodTipoDoc { get; set; }

    [Column("co_fechaOg")]
    [MaxLength(6)]
    public DateTime? CoFechaOg { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("nom_proveedor")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProveedor { get; set; }

    [Column("Valor_a_pagar")]
    public double ValorAPagar { get; set; }

    [Column("Valor_debe")]
    public double? ValorDebe { get; set; }

    [Column("Valor_Haber")]
    public double ValorHaber { get; set; }

    public double? Saldo { get; set; }

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [Column("Ruc_Proveedor")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string RucProveedor { get; set; } = null!;

    [Column("representante_legal")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? RepresentanteLegal { get; set; }

    [Column("Tipo_cbte")]
    [StringLength(9)]
    public string TipoCbte { get; set; } = null!;

    [Column("IdEmpresa_pago")]
    public int? IdEmpresaPago { get; set; }

    [Column("IdTipoCbte_pago")]
    public int? IdTipoCbtePago { get; set; }

    [Column("IdCbteCble_pago")]
    [Precision(18, 0)]
    public decimal? IdCbteCblePago { get; set; }

    [Column("cb_Observacion_pago")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CbObservacionPago { get; set; }

    [Column("tc_TipoCbte_pago")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TcTipoCbtePago { get; set; }

    [Column("cb_Cheque_pago")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CbChequePago { get; set; }

    public int IdClaseProveedor { get; set; }

    [Column("descripcion_clas_prove")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DescripcionClasProve { get; set; } = null!;

    [Column("NUM_QUERRY")]
    public long NumQuerry { get; set; }
}
