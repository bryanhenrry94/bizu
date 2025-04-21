using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwBanRpt015
{
    [Column("mba_IdEmpresa")]
    public int MbaIdEmpresa { get; set; }

    [Column("mba_IdCbteCble")]
    [Precision(18, 0)]
    public decimal MbaIdCbteCble { get; set; }

    [Column("mba_IdTipocbte")]
    public int MbaIdTipocbte { get; set; }

    [Column("mcj_Secuencia")]
    public int McjSecuencia { get; set; }

    public int IdEmpresa { get; set; }

    [Column("nom_sucursal")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    public int IdTipocbte { get; set; }

    [Column("nom_Tipocbte")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomTipocbte { get; set; }

    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Beneficiario { get; set; } = null!;

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdCobroTipo { get; set; }

    [Column("Fecha_Cobro")]
    [MaxLength(6)]
    public DateTime FechaCobro { get; set; }

    [Column("cr_Valor")]
    public double CrValor { get; set; }

    [Column("cm_observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CmObservacion { get; set; } = null!;
}
