using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCotizacion")]
[Table("com_cotizacion_compra")]
[Index("IdEmpresa", "IdProveedor", Name = "FK_com_cotizacion_compra_cp_proveedor")]
[Index("IdEmpresa", "IdSucursal", Name = "FK_com_cotizacion_compra_tb_sucursal")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComCotizacionCompra
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCotizacion { get; set; }

    [Precision(18, 0)]
    public decimal? IdProveedor { get; set; }

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    public int IdSucursal { get; set; }

    [StringLength(250)]
    public string Observacion { get; set; } = null!;

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

    [StringLength(500)]
    public string? MotivoAnulacion { get; set; }

    public int? IdSolicidud { get; set; }

    [StringLength(25)]
    public string IdteminoPago { get; set; } = null!;

    [InverseProperty("ComCotizacionCompra")]
    public virtual ICollection<ComCotizacionCompraDet> ComCotizacionCompraDet { get; set; } = new List<ComCotizacionCompraDet>();

    [ForeignKey("IdEmpresa, IdProveedor")]
    [InverseProperty("ComCotizacionCompra")]
    public virtual CpProveedor? CpProveedor { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal")]
    [InverseProperty("ComCotizacionCompra")]
    public virtual TbSucursal TbSucursal { get; set; } = null!;
}
