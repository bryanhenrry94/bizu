using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdPrecarga")]
[Table("in_PrecargaItemsOrdenCompra")]
[Index("IdEmpresa", "IdProveedor", Name = "FK_in_PrecargaItemsOrdenCompra_cp_proveedor")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InPrecargaItemsOrdenCompra
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdPrecarga { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    public int IdOrdenTaller { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("pre_fecha")]
    [MaxLength(6)]
    public DateTime PreFecha { get; set; }

    [Column("pre_subtotal")]
    public double PreSubtotal { get; set; }

    [Column("pre_iva")]
    public double PreIva { get; set; }

    [Column("pre_descuento")]
    public double PreDescuento { get; set; }

    [Column("pre_pordesc")]
    public short PrePordesc { get; set; }

    [Column("pre_total")]
    public double PreTotal { get; set; }

    [Column("pre_Base_conIva")]
    public double PreBaseConIva { get; set; }

    [Column("pre_Base_sinIva")]
    public double PreBaseSinIva { get; set; }

    [Column("pre_observacion")]
    [StringLength(1000)]
    public string PreObservacion { get; set; } = null!;

    [MaxLength(6)]
    public DateTime Fechreg { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("pre_NumDocumento")]
    [StringLength(50)]
    public string? PreNumDocumento { get; set; }

    [Column("pre_PesoTotal")]
    public double? PrePesoTotal { get; set; }

    [Column("pre_fecha_emision")]
    [MaxLength(6)]
    public DateTime? PreFechaEmision { get; set; }

    [ForeignKey("IdEmpresa, IdProveedor")]
    [InverseProperty("InPrecargaItemsOrdenCompra")]
    public virtual CpProveedor CpProveedor { get; set; } = null!;

    [InverseProperty("InPrecargaItemsOrdenCompra")]
    public virtual ICollection<InPrecargaItemsOrdenCompraDet> InPrecargaItemsOrdenCompraDet { get; set; } = new List<InPrecargaItemsOrdenCompraDet>();

    [ForeignKey("IdEmpresa, IdSucursal")]
    [InverseProperty("InPrecargaItemsOrdenCompra")]
    public virtual TbSucursal TbSucursal { get; set; } = null!;
}
