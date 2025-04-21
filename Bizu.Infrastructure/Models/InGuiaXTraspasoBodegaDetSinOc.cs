using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdGuia", "Secuencia")]
[Table("in_Guia_x_traspaso_bodega_det_sin_oc")]
[Index("IdEmpresa", "IdProveedor", Name = "FK_in_Guia_x_traspaso_bodega_det_sin_oc_cp_proveedor")]
[Index("IdEmpresa", "IdProducto", Name = "FK_in_Guia_x_traspaso_bodega_det_sin_oc_in_Producto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InGuiaXTraspasoBodegaDetSinOc
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdGuia { get; set; }

    [Key]
    [Column("secuencia")]
    public int Secuencia { get; set; }

    [Column("Num_Fact")]
    [StringLength(50)]
    public string? NumFact { get; set; }

    [Precision(18, 0)]
    public decimal? IdProveedor { get; set; }

    [Column("nom_proveedor")]
    [StringLength(250)]
    public string? NomProveedor { get; set; }

    [Precision(18, 0)]
    public decimal? IdProducto { get; set; }

    [Column("nom_producto")]
    [StringLength(250)]
    public string? NomProducto { get; set; }

    [Column("Cantidad_enviar")]
    public double CantidadEnviar { get; set; }

    [Column("observacion")]
    [StringLength(1000)]
    public string Observacion { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdProveedor")]
    [InverseProperty("InGuiaXTraspasoBodegaDetSinOc")]
    public virtual CpProveedor? CpProveedor { get; set; }

    [ForeignKey("IdEmpresa, IdGuia")]
    [InverseProperty("InGuiaXTraspasoBodegaDetSinOc")]
    public virtual InGuiaXTraspasoBodega InGuiaXTraspasoBodega { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("InGuiaXTraspasoBodegaDetSinOc")]
    public virtual InProducto? InProducto { get; set; }
}
