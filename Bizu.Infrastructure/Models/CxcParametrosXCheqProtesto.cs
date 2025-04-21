using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "Secuencia")]
[Table("cxc_Parametros_x_cheqProtesto")]
[Index("IdEmpresa", "PaIdProductoXNdXCheqProtes", Name = "FK_cxc_Parametros_x_cheqProtesto_in_Producto")]
[Index("IdEmpresa", "PaIdProductoXNcXCobro", Name = "FK_cxc_Parametros_x_cheqProtesto_in_Producto1")]
[Index("IdEmpresa", "PaIdSucursalXDefaultXCheqProtes", "PaIdBodegaXDefaultXCheqProtes", Name = "FK_cxc_Parametros_x_cheqProtesto_tb_bodega")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcParametrosXCheqProtesto
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("secuencia")]
    public int Secuencia { get; set; }

    [Column("pa_IdSucursal_x_default_x_cheqProtes")]
    public int? PaIdSucursalXDefaultXCheqProtes { get; set; }

    [Column("pa_IdBodega_x_default_x_cheqProtes")]
    public int? PaIdBodegaXDefaultXCheqProtes { get; set; }

    [Column("pa_IdProducto_x_ND_x_CheqProtes")]
    [Precision(18, 0)]
    public decimal? PaIdProductoXNdXCheqProtes { get; set; }

    [Column("pa_IdProducto_x_NC_x_Cobro")]
    [Precision(18, 0)]
    public decimal? PaIdProductoXNcXCobro { get; set; }

    [ForeignKey("IdEmpresa")]
    [InverseProperty("CxcParametrosXCheqProtesto")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, PaIdProductoXNcXCobro")]
    [InverseProperty("CxcParametrosXCheqProtestoInProducto")]
    public virtual InProducto? InProducto { get; set; }

    [ForeignKey("IdEmpresa, PaIdProductoXNdXCheqProtes")]
    [InverseProperty("CxcParametrosXCheqProtestoInProductoNavigation")]
    public virtual InProducto? InProductoNavigation { get; set; }

    [ForeignKey("IdEmpresa, PaIdSucursalXDefaultXCheqProtes, PaIdBodegaXDefaultXCheqProtes")]
    [InverseProperty("CxcParametrosXCheqProtesto")]
    public virtual TbBodega? TbBodega { get; set; }
}
