using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdDevolucion")]
[Table("fa_devol_venta")]
[Index("IdEmpresa", "IdVendedor", Name = "FK_fa_devol_venta_fa_Vendedor")]
[Index("IdEmpresa", "IdCliente", Name = "FK_fa_devol_venta_fa_cliente")]
[Index("IdEmpresa", "IdSucursal", "IdBodega", "IdCbteVta", Name = "FK_fa_devol_venta_fa_factura")]
[Index("IdEmpresa", "IdSucursal", "IdBodega", "IdNota", Name = "FK_fa_devol_venta_fa_notaCreDeb")]
[Index("MvInvIdEmpresa", "MvInvIdSucursal", "MvInvIdBodega", "MvInvIdMoviInvenTipo", "MvInvIdNumMovi", Name = "FK_fa_devol_venta_in_movi_inve")]
[Index("MvInvIdEmpresaXAnu", "MvInvIdSucursalXAnu", "MvInvIdBodegaXAnu", "MvInvIdMoviInvenTipoXAnu", "MvInvIdNumMoviXAnu", Name = "FK_fa_devol_venta_in_movi_inve1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaDevolVenta
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdDevolucion { get; set; }

    [StringLength(20)]
    public string CodDevolucion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdNota { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public int IdVendedor { get; set; }

    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    [Column("dv_fecha")]
    [MaxLength(6)]
    public DateTime DvFecha { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("dv_Observacion")]
    [StringLength(300)]
    public string DvObservacion { get; set; } = null!;

    [Column("dv_seguro")]
    public double DvSeguro { get; set; }

    [Column("dv_flete")]
    public double DvFlete { get; set; }

    [Column("dv_interes")]
    public double DvInteres { get; set; }

    [Column("dv_OtroValor1")]
    public double DvOtroValor1 { get; set; }

    [Column("dv_OtroValor2")]
    public double DvOtroValor2 { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [StringLength(50)]
    public string? MotivoAnulacion { get; set; }

    [Column("mvInv_IdEmpresa")]
    public int? MvInvIdEmpresa { get; set; }

    [Column("mvInv_IdSucursal")]
    public int? MvInvIdSucursal { get; set; }

    [Column("mvInv_IdBodega")]
    public int? MvInvIdBodega { get; set; }

    [Column("mvInv_IdMovi_inven_tipo")]
    public int? MvInvIdMoviInvenTipo { get; set; }

    [Column("mvInv_IdNumMovi")]
    [Precision(18, 0)]
    public decimal? MvInvIdNumMovi { get; set; }

    [Column("mvInv_IdEmpresa_x_Anu")]
    public int? MvInvIdEmpresaXAnu { get; set; }

    [Column("mvInv_IdSucursal_x_Anu")]
    public int? MvInvIdSucursalXAnu { get; set; }

    [Column("mvInv_IdBodega_x_Anu")]
    public int? MvInvIdBodegaXAnu { get; set; }

    [Column("mvInv_IdMovi_inven_tipo_x_Anu")]
    public int? MvInvIdMoviInvenTipoXAnu { get; set; }

    [Column("mvInv_IdNumMovi_x_Anu")]
    [Precision(18, 0)]
    public decimal? MvInvIdNumMoviXAnu { get; set; }

    [ForeignKey("IdEmpresa, IdCliente")]
    [InverseProperty("FaDevolVenta")]
    public virtual FaCliente FaCliente { get; set; } = null!;

    [InverseProperty("FaDevolVenta")]
    public virtual ICollection<FaDevolVentaDet> FaDevolVentaDet { get; set; } = new List<FaDevolVentaDet>();

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega, IdCbteVta")]
    [InverseProperty("FaDevolVenta")]
    public virtual FaFactura FaFactura { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega, IdNota")]
    [InverseProperty("FaDevolVenta")]
    public virtual FaNotaCreDeb FaNotaCreDeb { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdVendedor")]
    [InverseProperty("FaDevolVenta")]
    public virtual FaVendedor FaVendedor { get; set; } = null!;

    [ForeignKey("MvInvIdEmpresa, MvInvIdSucursal, MvInvIdBodega, MvInvIdMoviInvenTipo, MvInvIdNumMovi")]
    [InverseProperty("FaDevolVentaInMoviInve")]
    public virtual InMoviInve? InMoviInve { get; set; }

    [ForeignKey("MvInvIdEmpresaXAnu, MvInvIdSucursalXAnu, MvInvIdBodegaXAnu, MvInvIdMoviInvenTipoXAnu, MvInvIdNumMoviXAnu")]
    [InverseProperty("FaDevolVentaInMoviInveNavigation")]
    public virtual InMoviInve? InMoviInveNavigation { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega")]
    [InverseProperty("FaDevolVenta")]
    public virtual TbBodega TbBodega { get; set; } = null!;
}
