using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxcRpt003
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdConciliacion { get; set; }

    public DateOnly Fecha { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoConciliacion { get; set; } = null!;

    [Column("numDocumento")]
    [StringLength(48)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NumDocumento { get; set; }

    [Column("Saldo_por_aplicar")]
    public double SaldoPorAplicar { get; set; }

    [Column("Valor_Aplicado")]
    public double ValorAplicado { get; set; }

    [Column("TipoDoc_vta")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? TipoDocVta { get; set; }

    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal? IdCliente { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUsuario { get; set; } = null!;

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

    [Column("IdEmpresa_cbte_cble")]
    public int? IdEmpresaCbteCble { get; set; }

    [Column("IdTipoCbte_cbte_cble")]
    public int? IdTipoCbteCbteCble { get; set; }

    [Column("IdCbteCble_cbte_cble")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleCbteCble { get; set; }
}
