using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwBanRpt005
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    public int IdTipocbte { get; set; }

    [Column("Cod_Cbtecble")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodCbtecble { get; set; } = null!;

    [Column("cb_Observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CbObservacion { get; set; } = null!;

    [Column("cb_secuencia")]
    [Precision(18, 0)]
    public decimal CbSecuencia { get; set; }

    [Column("cb_Valor")]
    public double CbValor { get; set; }

    [Column("cb_Cheque")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CbCheque { get; set; }

    [Column("cb_ChequeImpreso")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CbChequeImpreso { get; set; } = null!;

    [Column("cb_FechaCheque")]
    public DateOnly? CbFechaCheque { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("cb_giradoA")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CbGiradoA { get; set; }

    [Column("cb_ciudadChq")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CbCiudadChq { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodTipoCbteBan { get; set; } = null!;

    [Column("cb_Fecha")]
    public DateOnly CbFecha { get; set; }

    [Column("con_Fecha")]
    [MaxLength(6)]
    public DateTime ConFecha { get; set; }

    [Column("con_Valor")]
    public double ConValor { get; set; }

    [Column("con_Observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string ConObservacion { get; set; } = null!;

    [Column("con_IdCbteCble")]
    [Precision(18, 0)]
    public decimal ConIdCbteCble { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    [Column("pc_Cuenta")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PcCuenta { get; set; } = null!;

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ValorEnLetras { get; set; }

    [Column("dc_Valor")]
    public double DcValor { get; set; }

    [Column("nom_ciudad")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomCiudad { get; set; }

    [Column("ba_Num_Cuenta")]
    [StringLength(0)]
    public string BaNumCuenta { get; set; } = null!;

    [Column("ba_descripcion")]
    [StringLength(0)]
    public string BaDescripcion { get; set; } = null!;
}
