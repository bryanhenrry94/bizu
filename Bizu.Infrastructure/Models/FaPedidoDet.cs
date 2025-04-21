using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdPedido", "Secuencial")]
[Table("fa_pedido_det")]
[Index("IdEmpresa", "IdProducto", Name = "FK_fa_pedido_det_in_Producto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaPedidoDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdPedido { get; set; }

    [Key]
    public int Secuencial { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("dp_cantidad")]
    public double DpCantidad { get; set; }

    [Column("dp_precio")]
    public double DpPrecio { get; set; }

    [Column("dp_PorDescuento")]
    public double DpPorDescuento { get; set; }

    [Column("cp_desUni")]
    public double CpDesUni { get; set; }

    [Column("cp_PrecioFinal")]
    public double CpPrecioFinal { get; set; }

    [Column("dp_subtotal")]
    public double DpSubtotal { get; set; }

    [Column("dp_iva")]
    public double DpIva { get; set; }

    [Column("dp_total")]
    public double DpTotal { get; set; }

    [Column("dp_pagaIva")]
    [StringLength(1)]
    public string DpPagaIva { get; set; } = null!;

    [Column("dp_detallexItems")]
    public string? DpDetallexItems { get; set; }

    [Column("dp_peso")]
    public double? DpPeso { get; set; }

    [Column("IdCod_Impuesto_Iva")]
    [StringLength(25)]
    public string? IdCodImpuestoIva { get; set; }

    [Column("dp_estado")]
    [StringLength(1)]
    public string? DpEstado { get; set; }

    [Column("idPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("idPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("dp_por_iva")]
    public double? DpPorIva { get; set; }

    [Column("idCod_Impuesto_Ice")]
    [StringLength(25)]
    public string? IdCodImpuestoIce { get; set; }

    [InverseProperty("FaPedidoDet")]
    public virtual ICollection<FaOrdenDespDetXFaPedidoDet> FaOrdenDespDetXFaPedidoDet { get; set; } = new List<FaOrdenDespDetXFaPedidoDet>();

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega, IdPedido")]
    [InverseProperty("FaPedidoDet")]
    public virtual FaPedido FaPedido { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("FaPedidoDet")]
    public virtual InProducto InProducto { get; set; } = null!;
}
