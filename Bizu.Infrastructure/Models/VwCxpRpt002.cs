using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxpRpt002
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
    public string NomTipoDoc { get; set; } = null!;

    [Column("cod_tipo_doc")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodTipoDoc { get; set; } = null!;

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("nom_proveedor")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProveedor { get; set; }

    [Column("Valor_a_pagar")]
    public double ValorAPagar { get; set; }

    [Column("Valor_debe")]
    public int ValorDebe { get; set; }

    [Column("Valor_Haber")]
    public double ValorHaber { get; set; }

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

    public int IdClaseProveedor { get; set; }

    [Column("nom_clase_proveedor")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomClaseProveedor { get; set; } = null!;
}
