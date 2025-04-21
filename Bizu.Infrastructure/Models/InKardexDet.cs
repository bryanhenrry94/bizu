using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdProducto", "Secuencia")]
[Table("in_kardex_det")]
[Index("IdEmpresa", "IdProducto", Name = "FK_in_kardex_det_in_Producto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InKardexDet
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

    [Key]
    [Precision(18, 0)]
    public decimal Secuencia { get; set; }

    [Column("kr_Motivo")]
    [StringLength(30)]
    public string KrMotivo { get; set; } = null!;

    [Column("kt_Transaccion")]
    [StringLength(50)]
    public string KtTransaccion { get; set; } = null!;

    [Column("kr_Tipo")]
    [StringLength(1)]
    public string KrTipo { get; set; } = null!;

    [Column("kr_fecha")]
    [MaxLength(6)]
    public DateTime KrFecha { get; set; }

    [Column("kr_Observacion")]
    [StringLength(150)]
    public string KrObservacion { get; set; } = null!;

    [Column("kr_CostoUni")]
    public double KrCostoUni { get; set; }

    [Column("kr_Ent_Cantidad")]
    public double KrEntCantidad { get; set; }

    [Column("kr_Ent_valor")]
    public double KrEntValor { get; set; }

    [Column("kr_Sali_Cantidad")]
    public double KrSaliCantidad { get; set; }

    [Column("kr_Sali_valor")]
    public double KrSaliValor { get; set; }

    [Column("kr_Saldo_Cant")]
    public double KrSaldoCant { get; set; }

    [Column("kr_Saldo_CostoUni")]
    public double KrSaldoCostoUni { get; set; }

    [Column("kr_Saldo_valor")]
    public double KrSaldoValor { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega, IdProducto")]
    [InverseProperty("InKardexDet")]
    public virtual InKardex InKardex { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("InKardexDet")]
    public virtual InProducto InProducto { get; set; } = null!;
}
