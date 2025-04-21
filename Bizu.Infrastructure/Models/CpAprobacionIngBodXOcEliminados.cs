using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdAprobacion")]
[Table("cp_Aprobacion_Ing_Bod_x_OC_Eliminados")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpAprobacionIngBodXOcEliminados
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdAprobacion { get; set; }

    [Column("Fecha_aprobacion")]
    [MaxLength(6)]
    public DateTime FechaAprobacion { get; set; }

    [Column("IdEmpresa_Ogiro")]
    public int? IdEmpresaOgiro { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleOgiro { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int? IdTipoCbteOgiro { get; set; }

    [Column("IdOrden_giro_Tipo")]
    [StringLength(5)]
    public string IdOrdenGiroTipo { get; set; } = null!;

    [Column("IdIden_credito")]
    public int IdIdenCredito { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [StringLength(350)]
    public string Observacion { get; set; } = null!;

    [StringLength(3)]
    public string Serie { get; set; } = null!;

    [StringLength(3)]
    public string Serie2 { get; set; } = null!;

    [Column("num_documento")]
    [StringLength(50)]
    public string NumDocumento { get; set; } = null!;

    [Column("num_auto_Proveedor")]
    [StringLength(50)]
    public string NumAutoProveedor { get; set; } = null!;

    [Column("num_auto_Imprenta")]
    [StringLength(50)]
    public string NumAutoImprenta { get; set; } = null!;

    [Column("Fecha_Factura")]
    [MaxLength(6)]
    public DateTime FechaFactura { get; set; }

    [Column("co_subtotal_iva")]
    public double CoSubtotalIva { get; set; }

    [Column("co_subtotal_siniva")]
    public double CoSubtotalSiniva { get; set; }

    public double Descuento { get; set; }

    [Column("co_baseImponible")]
    public double CoBaseImponible { get; set; }

    [Column("co_Por_iva")]
    public double CoPorIva { get; set; }

    [Column("co_valoriva")]
    public double CoValoriva { get; set; }

    [Column("co_total")]
    public double CoTotal { get; set; }

    [Column("co_plazo")]
    public int CoPlazo { get; set; }

    [Column("Fecha_Anulacion")]
    [MaxLength(6)]
    public DateTime? FechaAnulacion { get; set; }

    [Column("IdUsuario_Anu")]
    [StringLength(25)]
    public string? IdUsuarioAnu { get; set; }

    [Column("Motivo_Anu")]
    [StringLength(500)]
    public string? MotivoAnu { get; set; }
}
