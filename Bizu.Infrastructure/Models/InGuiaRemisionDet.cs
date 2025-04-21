using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdGuiaRemision", "Secuencia")]
[Table("in_GuiaRemision_Det")]
[Index("IdEmpresa", "IdCentroCosto", Name = "FK_in_GuiaRemision_Det_ct_centro_costo")]
[Index("IdEmpresa", "IdProducto", Name = "FK_in_GuiaRemision_Det_in_Producto")]
[Index("IdUnidadMedida", Name = "FK_in_GuiaRemision_Det_in_UnidadMedida1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InGuiaRemisionDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdGuiaRemision { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal? IdProducto { get; set; }

    [StringLength(50)]
    public string Codigo { get; set; } = null!;

    [StringLength(250)]
    public string Descripcion { get; set; } = null!;

    [Column("Detalle_x_Item")]
    [StringLength(250)]
    public string? DetalleXItem { get; set; }

    public double Cantidad { get; set; }

    [StringLength(25)]
    public string? IdUnidadMedida { get; set; }

    public double? Peso { get; set; }

    [Column("Cantidad_sinConversion")]
    public double? CantidadSinConversion { get; set; }

    [Column("IdUnidadMedida_sinConversion")]
    [StringLength(25)]
    public string? IdUnidadMedidaSinConversion { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("InGuiaRemisionDet")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [ForeignKey("IdUnidadMedida")]
    [InverseProperty("InGuiaRemisionDet")]
    public virtual InUnidadMedida? IdUnidadMedidaNavigation { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdGuiaRemision")]
    [InverseProperty("InGuiaRemisionDet")]
    public virtual InGuiaRemision InGuiaRemision { get; set; } = null!;

    [InverseProperty("InGuiaRemisionDet")]
    public virtual ICollection<InIngEgrInvenDet> InIngEgrInvenDet { get; set; } = new List<InIngEgrInvenDet>();

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("InGuiaRemisionDet")]
    public virtual InProducto? InProducto { get; set; }
}
