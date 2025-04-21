using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdDevCompra")]
[Table("com_dev_compra")]
[Index("IdEmpresa", "IdProveedor", Name = "FK_com_dev_compra_cp_proveedor")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComDevCompra
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdDevCompra { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [StringLength(5)]
    public string Tipo { get; set; } = null!;

    [Column("dv_fecha")]
    [MaxLength(6)]
    public DateTime DvFecha { get; set; }

    [Column("dv_flete")]
    public double DvFlete { get; set; }

    [Column("dv_observacion")]
    [StringLength(1000)]
    public string DvObservacion { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaHoraAnul { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [StringLength(1)]
    public string? AfectaCosto { get; set; }

    [StringLength(500)]
    public string? MotivoAnulacion { get; set; }

    [InverseProperty("ComDevCompra")]
    public virtual ICollection<ComDevCompraDet> ComDevCompraDet { get; set; } = new List<ComDevCompraDet>();

    [ForeignKey("IdEmpresa, IdProveedor")]
    [InverseProperty("ComDevCompra")]
    public virtual CpProveedor CpProveedor { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega")]
    [InverseProperty("ComDevCompra")]
    public virtual TbBodega TbBodega { get; set; } = null!;
}
