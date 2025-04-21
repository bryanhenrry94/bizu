using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwAfDepreciacion
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdDepreciacion { get; set; }

    public int IdTipoDepreciacion { get; set; }

    [Column("Cod_Depreciacion")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodDepreciacion { get; set; } = null!;

    public int IdPeriodo { get; set; }

    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Descripcion { get; set; }

    [Column("Fecha_Depreciacion")]
    [MaxLength(6)]
    public DateTime FechaDepreciacion { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuario { get; set; }

    [Column("nom_tipo_depreciacion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomTipoDepreciacion { get; set; }

    [Column("cod_tipo_depreciacion")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodTipoDepreciacion { get; set; }

    [Column("Valor_Depreciacion")]
    public double? ValorDepreciacion { get; set; }

    [Column("Valor_Depre_Acum")]
    public double? ValorDepreAcum { get; set; }

    [Column("Valor_Importe")]
    public double? ValorImporte { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Estado { get; set; }
}
