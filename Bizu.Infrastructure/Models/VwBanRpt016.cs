using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwBanRpt016
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    public int IdTipocbte { get; set; }

    [Column("Cod_Cbtecble")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodCbtecble { get; set; } = null!;

    public int IdPeriodo { get; set; }

    public int IdBanco { get; set; }

    [Precision(18, 0)]
    public decimal? IdProveedor { get; set; }

    [Column("cb_Fecha")]
    public DateOnly CbFecha { get; set; }

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

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdUsuario { get; set; } = null!;

    [Column("IdUsuario_Anu")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioAnu { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAnulacion { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioUltMod { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoAnulacion { get; set; }

    [Column("ip")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Ip { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomPc { get; set; }

    [Column("IdPersona_Girado_a")]
    [Precision(18, 0)]
    public decimal IdPersonaGiradoA { get; set; }

    [Column("cb_giradoA")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CbGiradoA { get; set; }

    [Column("cb_ciudadChq")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CbCiudadChq { get; set; }

    [Column("IdCbteCble_Anulacion")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleAnulacion { get; set; }

    [Column("IdTipoCbte_Anulacion")]
    public int? IdTipoCbteAnulacion { get; set; }

    [Precision(18, 0)]
    public decimal? IdTipoFlujo { get; set; }

    public int? IdTipoNota { get; set; }

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdTransaccion { get; set; }

    [Column("Por_Anticipo")]
    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PorAnticipo { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PosFechado { get; set; }

    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? ValorEnLetras { get; set; }

    public int? IdSucursal { get; set; }

    [Column("Tipo_Conciliacion")]
    [StringLength(13)]
    public string? TipoConciliacion { get; set; }

    [Column("ba_descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? BaDescripcion { get; set; }
}
