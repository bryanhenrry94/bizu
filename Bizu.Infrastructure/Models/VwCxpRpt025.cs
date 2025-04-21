using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwCxpRpt025
{
    [Column("nom_Centro_costo")]
    [StringLength(250)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCentroCosto { get; set; }

    [Column("nom_subCentro_costo")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomSubCentroCosto { get; set; }

    public int IdEmpresa { get; set; }

    [Column("IdTipo_op")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdTipoOp { get; set; } = null!;

    [Column(TypeName = "text")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Referencia { get; set; } = null!;

    [StringLength(54)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Referencia2 { get; set; }

    [Precision(18, 0)]
    public decimal? IdOrdenPago { get; set; }

    [Column("Secuencia_OP")]
    public int? SecuenciaOp { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdTipoPersona { get; set; }

    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    [Column("Nom_Beneficiario")]
    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomBeneficiario { get; set; }

    [Column("Fecha_Fa_Prov")]
    [MaxLength(6)]
    public DateTime FechaFaProv { get; set; }

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [Column("Valor_a_pagar")]
    public double ValorAPagar { get; set; }

    [Column("Saldo_x_Pagar_OP")]
    public double SaldoXPagarOp { get; set; }

    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoAprobacion { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCentroCosto { get; set; } = null!;

    [Column("IdSubCentro_Costo")]
    [StringLength(0)]
    public string IdSubCentroCosto { get; set; } = null!;

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdFormaPago { get; set; } = null!;
}
