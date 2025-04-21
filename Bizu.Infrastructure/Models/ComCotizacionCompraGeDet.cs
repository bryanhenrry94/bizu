using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCotizacion", "Secuencia")]
[Table("com_cotizacion_compra_GE_det")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComCotizacionCompraGeDet
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

    [Column("IdCod_Impuesto")]
    [StringLength(20)]
    public string? IdCodImpuesto { get; set; }

    [Column("Porce_Iva")]
    [Precision(18, 0)]
    public decimal? PorceIva { get; set; }

    [Column("IVA")]
    [Precision(18, 0)]
    public decimal? Iva { get; set; }

    [Column("do_precioCompra")]
    [Precision(18, 0)]
    public decimal? DoPrecioCompra { get; set; }

    [Column("do_porc_des")]
    [Precision(18, 0)]
    public decimal? DoPorcDes { get; set; }

    [Column("do_descuento")]
    [Precision(18, 0)]
    public decimal? DoDescuento { get; set; }

    [Column("do_subtotal")]
    [Precision(18, 0)]
    public decimal? DoSubtotal { get; set; }

    [Column("do_total")]
    [Precision(18, 0)]
    public decimal? DoTotal { get; set; }

    [Column("do_observacion")]
    [StringLength(250)]
    public string? DoObservacion { get; set; }
}
