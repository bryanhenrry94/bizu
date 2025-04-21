using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdDevCompra", "Secuencia")]
[Table("com_dev_compra_det")]
[Index("OcdetIdEmpresa", "OcdetIdSucursal", "OcdetIdOrdenCompra", "OcdetSecuencia", Name = "FK_com_dev_compra_det_com_ordencompra_local_det")]
[Index("IdEmpresa", "IdProducto", Name = "FK_com_dev_compra_det_in_Producto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComDevCompraDet
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

    [Key]
    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("dv_Cantidad")]
    public double DvCantidad { get; set; }

    [Column("dv_precioCompra")]
    public double DvPrecioCompra { get; set; }

    [Column("dv_porc_des")]
    public double DvPorcDes { get; set; }

    [Column("dv_descuento")]
    public double DvDescuento { get; set; }

    [Column("dv_subtotal")]
    public double DvSubtotal { get; set; }

    [Column("dv_iva")]
    public double DvIva { get; set; }

    [Column("dv_total")]
    public double DvTotal { get; set; }

    [Column("dv_ManejaIva")]
    public bool DvManejaIva { get; set; }

    [Column("dv_Costeado")]
    [StringLength(1)]
    public string DvCosteado { get; set; } = null!;

    [Column("dv_peso")]
    public double DvPeso { get; set; }

    [Column("dv_observacion")]
    [StringLength(1000)]
    public string DvObservacion { get; set; } = null!;

    [Column("ocdet_IdEmpresa")]
    public int? OcdetIdEmpresa { get; set; }

    [Column("ocdet_IdSucursal")]
    public int? OcdetIdSucursal { get; set; }

    [Column("ocdet_IdOrdenCompra")]
    [Precision(18, 0)]
    public decimal? OcdetIdOrdenCompra { get; set; }

    [Column("ocdet_Secuencia")]
    public int? OcdetSecuencia { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega, IdDevCompra")]
    [InverseProperty("ComDevCompraDet")]
    public virtual ComDevCompra ComDevCompra { get; set; } = null!;

    [ForeignKey("OcdetIdEmpresa, OcdetIdSucursal, OcdetIdOrdenCompra, OcdetSecuencia")]
    [InverseProperty("ComDevCompraDet")]
    public virtual ComOrdencompraLocalDet? ComOrdencompraLocalDet { get; set; }

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("ComDevCompraDet")]
    public virtual InProducto InProducto { get; set; } = null!;
}
