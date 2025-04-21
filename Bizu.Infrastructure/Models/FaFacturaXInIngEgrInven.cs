using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresaFa", "IdSucursalFa", "IdBodegaFa", "IdCbteVtaFa", "IdEmpresaInEgXInv", "IdSucursalInEgXInv", "IdMoviInvenTipoInEgXInv", "IdNumMoviInEgXInv")]
[Table("fa_factura_x_in_Ing_Egr_Inven")]
[Index("IdEmpresaInEgXInv", "IdSucursalInEgXInv", "IdMoviInvenTipoInEgXInv", "IdNumMoviInEgXInv", Name = "FK_fa_factura_x_in_Ing_Egr_Inven_in_Ing_Egr_Inven")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaFacturaXInIngEgrInven
{
    [Key]
    [Column("IdEmpresa_fa")]
    public int IdEmpresaFa { get; set; }

    [Key]
    [Column("IdSucursal_fa")]
    public int IdSucursalFa { get; set; }

    [Key]
    [Column("IdBodega_fa")]
    public int IdBodegaFa { get; set; }

    [Key]
    [Column("IdCbteVta_fa")]
    [Precision(18, 0)]
    public decimal IdCbteVtaFa { get; set; }

    [Key]
    [Column("IdEmpresa_in_eg_x_inv")]
    public int IdEmpresaInEgXInv { get; set; }

    [Key]
    [Column("IdSucursal_in_eg_x_inv")]
    public int IdSucursalInEgXInv { get; set; }

    [Key]
    [Column("IdMovi_inven_tipo_in_eg_x_inv")]
    public int IdMoviInvenTipoInEgXInv { get; set; }

    [Key]
    [Column("IdNumMovi_in_eg_x_inv")]
    [Precision(18, 0)]
    public decimal IdNumMoviInEgXInv { get; set; }

    [Column("observacion")]
    [StringLength(50)]
    public string? Observacion { get; set; }

    [ForeignKey("IdEmpresaFa, IdSucursalFa, IdBodegaFa, IdCbteVtaFa")]
    [InverseProperty("FaFacturaXInIngEgrInven")]
    public virtual FaFactura FaFactura { get; set; } = null!;

    [ForeignKey("IdEmpresaInEgXInv, IdSucursalInEgXInv, IdMoviInvenTipoInEgXInv, IdNumMoviInEgXInv")]
    [InverseProperty("FaFacturaXInIngEgrInven")]
    public virtual InIngEgrInven InIngEgrInven { get; set; } = null!;
}
