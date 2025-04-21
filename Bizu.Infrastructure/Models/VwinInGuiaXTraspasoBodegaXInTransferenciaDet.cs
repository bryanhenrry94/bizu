using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinInGuiaXTraspasoBodegaXInTransferenciaDet
{
    [Column("IdEmpresa_tras")]
    public int IdEmpresaTras { get; set; }

    [Precision(18, 0)]
    public decimal IdGuia { get; set; }

    public int IdEmpresa { get; set; }

    public int IdSucursalOrigen { get; set; }

    public int IdBodegaOrigen { get; set; }

    [Precision(18, 0)]
    public decimal IdTransferencia { get; set; }

    [Column("dt_secuencia")]
    public int DtSecuencia { get; set; }

    [Column("cantidad")]
    [Precision(18, 2)]
    public decimal Cantidad { get; set; }

    [Column("observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Observacion { get; set; } = null!;

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    [Column("pr_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrObservacion { get; set; } = null!;

    [Column("bo_Descripcion")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string BoDescripcion { get; set; } = null!;

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("dt_cantidad")]
    public double DtCantidad { get; set; }
}
