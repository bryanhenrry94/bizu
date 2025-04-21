using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxpRpt012
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

    [StringLength(93)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Documento { get; set; } = null!;

    [Column("nom_tipo_doc")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomTipoDoc { get; set; }

    [Column("cod_tipo_doc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodTipoDoc { get; set; } = null!;

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("nom_proveedor")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProveedor { get; set; }

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [Column("ValorAPagar")]
    public double ValorApagar { get; set; }

    public double TotalPagado { get; set; }

    public double Saldo { get; set; }

    [StringLength(12)]
    public string TipoRegistro { get; set; } = null!;

    public int IdCalendario { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NombreCortoFecha { get; set; } = null!;

    [StringLength(30)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NombreMes { get; set; }

    public int? IdMes { get; set; }

    public int? AnioFiscal { get; set; }

    [Column("co_FechaFactura_vct")]
    [MaxLength(6)]
    public DateTime CoFechaFacturaVct { get; set; }
}
