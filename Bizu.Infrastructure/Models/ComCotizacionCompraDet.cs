using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCotizacion", "Secuencia")]
[Table("com_cotizacion_compra_det")]
[Index("IdEmpresaLq", "IdListadoMaterialesLq", "IdDetalleLq", Name = "FK_com_cotizacion_compra_det_com_ListadoMateriales_Det")]
[Index("IdEmpresa", "Idproducto", Name = "FK_com_cotizacion_compra_det_in_Producto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComCotizacionCompraDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCotizacion { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal? Idproducto { get; set; }

    [Column("Cant_soli")]
    public double? CantSoli { get; set; }

    [Column("Cant_a_cotizar")]
    public double? CantACotizar { get; set; }

    [StringLength(250)]
    public string? Observacion { get; set; }

    [Column("IdEmpresa_lq")]
    public int? IdEmpresaLq { get; set; }

    [Column("IdListadoMateriales_lq")]
    [Precision(18, 0)]
    public decimal? IdListadoMaterialesLq { get; set; }

    [Column("IdDetalle_lq")]
    public int? IdDetalleLq { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(100)]
    public string? MotiAnula { get; set; }

    [ForeignKey("IdEmpresa, IdCotizacion")]
    [InverseProperty("ComCotizacionCompraDet")]
    public virtual ComCotizacionCompra ComCotizacionCompra { get; set; } = null!;

    [ForeignKey("IdEmpresaLq, IdListadoMaterialesLq, IdDetalleLq")]
    [InverseProperty("ComCotizacionCompraDet")]
    public virtual ComListadoMaterialesDet? ComListadoMaterialesDet { get; set; }

    [ForeignKey("IdEmpresa, Idproducto")]
    [InverseProperty("ComCotizacionCompraDet")]
    public virtual InProducto? InProducto { get; set; }
}
