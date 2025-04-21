using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdNota", "Secuencia")]
[Table("fa_notaCreDeb_det")]
[Index("IdCodImpuestoIva", Name = "FK_fa_notaCreDeb_det_tb_sis_Impuesto")]
[Index("IdCodImpuestoIce", Name = "FK_fa_notaCreDeb_det_tb_sis_Impuesto1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaNotaCreDebDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdNota { get; set; }

    [Key]
    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("sc_cantidad")]
    public double ScCantidad { get; set; }

    [Column("sc_Precio")]
    public double ScPrecio { get; set; }

    [Column("sc_descUni")]
    public double ScDescUni { get; set; }

    [Column("sc_PordescUni")]
    public double ScPordescUni { get; set; }

    [Column("sc_precioFinal")]
    public double ScPrecioFinal { get; set; }

    [Column("sc_subtotal")]
    public double ScSubtotal { get; set; }

    [Column("sc_iva")]
    public double ScIva { get; set; }

    [Column("sc_total")]
    public double ScTotal { get; set; }

    [Column("sc_costo")]
    public double ScCosto { get; set; }

    [Column("sc_observacion")]
    [StringLength(1000)]
    public string ScObservacion { get; set; } = null!;

    [Column("sc_estado")]
    [StringLength(1)]
    public string ScEstado { get; set; } = null!;

    [Column("sc_Peso")]
    public double? ScPeso { get; set; }

    [Column("vt_por_iva")]
    public double VtPorIva { get; set; }

    [Column("IdPunto_Cargo")]
    public int? IdPuntoCargo { get; set; }

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("IdCod_Impuesto_Iva")]
    [StringLength(25)]
    public string IdCodImpuestoIva { get; set; } = null!;

    [Column("IdCod_Impuesto_Ice")]
    [StringLength(25)]
    public string? IdCodImpuestoIce { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega, IdNota")]
    [InverseProperty("FaNotaCreDebDet")]
    public virtual FaNotaCreDeb FaNotaCreDeb { get; set; } = null!;

    [ForeignKey("IdCodImpuestoIce")]
    [InverseProperty("FaNotaCreDebDetIdCodImpuestoIceNavigation")]
    public virtual TbSisImpuesto? IdCodImpuestoIceNavigation { get; set; }

    [ForeignKey("IdCodImpuestoIva")]
    [InverseProperty("FaNotaCreDebDetIdCodImpuestoIvaNavigation")]
    public virtual TbSisImpuesto IdCodImpuestoIvaNavigation { get; set; } = null!;

    [ForeignKey("NoIdEmpresa, NoIdSucursal, NoIdBodega, NoIdNota, NoSecuencia")]
    [InverseProperty("FaNotaCreDebDet")]
    public virtual ICollection<InIngEgrInvenDet> InIngEgrInvenDet { get; set; } = new List<InIngEgrInvenDet>();

    [ForeignKey("NoIdEmpresa, NoIdSucursal, NoIdBodega, NoIdNota, NoSecuencia")]
    [InverseProperty("FaNotaCreDebDetNavigation")]
    public virtual ICollection<InIngEgrInvenDet> InIngEgrInvenDetNavigation { get; set; } = new List<InIngEgrInvenDet>();
}
