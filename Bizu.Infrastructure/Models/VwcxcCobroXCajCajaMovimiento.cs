using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcxcCobroXCajCajaMovimiento
{
    [Column("cbr_IdEmpresa")]
    public int CbrIdEmpresa { get; set; }

    [Column("em_nombre")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string EmNombre { get; set; } = null!;

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("cbr_IdSucursal")]
    public int CbrIdSucursal { get; set; }

    [Column("cbr_IdCobro")]
    [Precision(18, 0)]
    public decimal CbrIdCobro { get; set; }

    [Column("mcj_IdEmpresa")]
    public int McjIdEmpresa { get; set; }

    [Column("mcj_IdCbteCble")]
    [Precision(18, 0)]
    public decimal McjIdCbteCble { get; set; }

    [Column("mcj_IdTipocbte")]
    public int McjIdTipocbte { get; set; }

    [Column("tc_descripcion")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TcDescripcion { get; set; } = null!;

    [Column("tc_TipoCbte")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string TcTipoCbte { get; set; } = null!;
}
