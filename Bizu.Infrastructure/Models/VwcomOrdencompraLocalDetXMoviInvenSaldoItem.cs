using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcomOrdencompraLocalDetXMoviInvenSaldoItem
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdOrdenCompra { get; set; }

    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("do_CantidadOC")]
    public double DoCantidadOc { get; set; }

    [Column("dm_cantidad_Inv")]
    public double DmCantidadInv { get; set; }

    public double? SaldoxRecibir { get; set; }

    [Column("pr_nombre")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? PrNombre { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [StringLength(1)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Estado { get; set; } = null!;

    [Column("oc_fecha")]
    [MaxLength(6)]
    public DateTime OcFecha { get; set; }

    [Column("oc_NumDocumento")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string OcNumDocumento { get; set; } = null!;

    [Column("oc_observacion")]
    [StringLength(1000)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string OcObservacion { get; set; } = null!;

    [StringLength(200)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? Solicitante { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoAnulacion { get; set; }

    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? MotivoReprobacion { get; set; }

    [Column("co_fechaReproba")]
    [MaxLength(6)]
    public DateTime? CoFechaReproba { get; set; }

    [Column("IdUsuario_Reprue")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioReprue { get; set; }

    [Column("IdUsuario_Aprueba")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? IdUsuarioAprueba { get; set; }

    [Column("co_fecha_aprobacion")]
    [MaxLength(6)]
    public DateTime? CoFechaAprobacion { get; set; }
}
