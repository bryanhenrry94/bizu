using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwbaTransaccionesAconciliar
{
    [Precision(21, 0)]
    public decimal IdRow { get; set; }

    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdConciliacion { get; set; }

    public int IdBanco { get; set; }

    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdCtaCble { get; set; } = null!;

    [Column("ba_descripcion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BaDescripcion { get; set; } = null!;

    [Column("dc_Observacion")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string DcObservacion { get; set; } = null!;

    [Column("cb_Fecha")]
    [MaxLength(6)]
    public DateTime CbFecha { get; set; }

    [Column("nom_IdTipoCbte")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string NomIdTipoCbte { get; set; } = null!;

    [Column("dc_Valor")]
    public double DcValor { get; set; }

    [Column("fechaConciliacion")]
    [MaxLength(6)]
    public DateTime? FechaConciliacion { get; set; }

    [Column("IdEstado_Concil_Cat")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoConcilCat { get; set; } = null!;

    [Column("checked")]
    public long Checked { get; set; }

    public int IdTipoCbte { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteCble { get; set; }

    [Column("secuencia")]
    public int Secuencia { get; set; }

    [Column("cb_Cheque")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CbCheque { get; set; }

    [Column("co_SaldoBanco_anterior")]
    public double CoSaldoBancoAnterior { get; set; }
}
