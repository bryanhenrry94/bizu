using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdProducto")]
[Table("in_INV_Rpt026")]
[Index("IdEmpresa", "IdProducto", Name = "FK_in_INV_Rpt026_in_Producto")]
[Index("IdUnidadMedida", Name = "FK_in_INV_Rpt026_in_UnidadMedida")]
[Index("IdEmpresa", "IdCategoria", "IdLinea", Name = "FK_in_INV_Rpt026_in_linea")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InInvRpt026
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("Fecha_ini")]
    [MaxLength(6)]
    public DateTime FechaIni { get; set; }

    [Column("Fecha_fin")]
    [MaxLength(6)]
    public DateTime FechaFin { get; set; }

    [Column("pr_codigo")]
    [StringLength(80)]
    public string PrCodigo { get; set; } = null!;

    [Column("nom_producto")]
    [StringLength(1000)]
    public string NomProducto { get; set; } = null!;

    [StringLength(25)]
    public string IdCategoria { get; set; } = null!;

    [Column("nom_categoria")]
    [StringLength(200)]
    public string NomCategoria { get; set; } = null!;

    public int IdLinea { get; set; }

    [Column("nom_linea")]
    [StringLength(200)]
    public string NomLinea { get; set; } = null!;

    [Column("Saldo_inicial")]
    public double SaldoInicial { get; set; }

    public double Ingresos { get; set; }

    public double Egresos { get; set; }

    [Column("Saldo_final")]
    public double SaldoFinal { get; set; }

    [StringLength(25)]
    public string IdUnidadMedida { get; set; } = null!;

    [Column("nom_unidad_medida")]
    [StringLength(200)]
    public string NomUnidadMedida { get; set; } = null!;

    [Column("nom_Bodega")]
    [StringLength(150)]
    public string NomBodega { get; set; } = null!;

    [Column("nom_Sucursal")]
    [StringLength(150)]
    public string NomSucursal { get; set; } = null!;

    [Column("costo_inicial")]
    public double CostoInicial { get; set; }

    [Column("costo_ingresos")]
    public double CostoIngresos { get; set; }

    [Column("costo_egresos")]
    public double CostoEgresos { get; set; }

    [Column("costo_final")]
    public double CostoFinal { get; set; }

    [ForeignKey("IdUnidadMedida")]
    [InverseProperty("InInvRpt026")]
    public virtual InUnidadMedida IdUnidadMedidaNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCategoria, IdLinea")]
    [InverseProperty("InInvRpt026")]
    public virtual InLinea InLinea { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("InInvRpt026")]
    public virtual InProducto InProducto { get; set; } = null!;
}
