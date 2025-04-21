using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdCbteVta")]
[Table("fa_factura")]
[Index("IdEmpresa", "IdCaja", Name = "FK_fa_factura_caj_Caja")]
[Index("IdEmpresa", "IdPeriodo", Name = "FK_fa_factura_ct_periodo")]
[Index("IdEmpresa", "IdSucursal", "IdPuntoVta", Name = "FK_fa_factura_fa_PuntoVta")]
[Index("IdEmpresa", "IdVendedor", Name = "FK_fa_factura_fa_Vendedor")]
[Index("IdEmpresa", "IdCliente", Name = "FK_fa_factura_fa_cliente")]
[Index("IdEmpresaNcAnu", "IdSucursalNcAnu", "IdBodegaNcAnu", "IdNotaNcAnu", Name = "FK_fa_factura_fa_notaCreDeb")]
[Index("VtMes", Name = "FK_fa_factura_tb_mes")]
[Index("IdEmpresa", "VtTipoDoc", "VtSerie1", "VtSerie2", "VtNumFactura", Name = "IX_fa_factura")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaFactura
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCbteVta { get; set; }

    [StringLength(20)]
    public string CodCbteVta { get; set; } = null!;

    [Column("vt_tipoDoc")]
    [StringLength(20)]
    public string VtTipoDoc { get; set; } = null!;

    [Column("vt_serie1")]
    [StringLength(3)]
    public string? VtSerie1 { get; set; }

    [Column("vt_serie2")]
    [StringLength(3)]
    public string? VtSerie2 { get; set; }

    [Column("vt_NumFactura")]
    [StringLength(20)]
    public string? VtNumFactura { get; set; }

    [Column("Fecha_Autorizacion")]
    [MaxLength(6)]
    public DateTime? FechaAutorizacion { get; set; }

    [Column("vt_autorizacion")]
    [StringLength(50)]
    public string? VtAutorizacion { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public int IdVendedor { get; set; }

    [Column("vt_fecha")]
    [MaxLength(6)]
    public DateTime VtFecha { get; set; }

    [Column("vt_plazo")]
    [Precision(18, 0)]
    public decimal VtPlazo { get; set; }

    [Column("vt_fech_venc")]
    [MaxLength(6)]
    public DateTime VtFechVenc { get; set; }

    [Column("vt_tipo_venta")]
    [StringLength(20)]
    public string VtTipoVenta { get; set; } = null!;

    [Column("vt_Observacion")]
    [StringLength(500)]
    public string VtObservacion { get; set; } = null!;

    public int IdPeriodo { get; set; }

    [Column("vt_anio")]
    public int VtAnio { get; set; }

    [Column("vt_mes")]
    public int VtMes { get; set; }

    [Column("vt_flete")]
    public double VtFlete { get; set; }

    [Column("vt_interes")]
    public double VtInteres { get; set; }

    [Column("vt_seguro")]
    public double VtSeguro { get; set; }

    [Column("vt_OtroValor1")]
    public double VtOtroValor1 { get; set; }

    [Column("vt_OtroValor2")]
    public double VtOtroValor2 { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    public int IdCaja { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transaccion")]
    [MaxLength(6)]
    public DateTime? FechaTransaccion { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltModi { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [StringLength(100)]
    public string? MotivoAnulacion { get; set; }

    [Column("nom_pc")]
    [StringLength(25)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(10)]
    public string? Id { get; set; }

    [Column("IdEmpresa_nc_anu")]
    public int? IdEmpresaNcAnu { get; set; }

    [Column("IdSucursal_nc_anu")]
    public int? IdSucursalNcAnu { get; set; }

    [Column("IdBodega_nc_anu")]
    public int? IdBodegaNcAnu { get; set; }

    [Column("IdNota_nc_anu")]
    [Precision(18, 0)]
    public decimal? IdNotaNcAnu { get; set; }

    public int? IdPuntoVta { get; set; }

    [ForeignKey("IdEmpresa, IdCaja")]
    [InverseProperty("FaFactura")]
    public virtual CajCaja CajCaja { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdPeriodo")]
    [InverseProperty("FaFactura")]
    public virtual CtPeriodo CtPeriodo { get; set; } = null!;

    [InverseProperty("FaFactura")]
    public virtual ICollection<CxcAnticipoFacturado> CxcAnticipoFacturado { get; set; } = new List<CxcAnticipoFacturado>();

    [InverseProperty("FaFactura")]
    public virtual ICollection<CxcConciliacionDet> CxcConciliacionDet { get; set; } = new List<CxcConciliacionDet>();

    [ForeignKey("IdEmpresa, IdCliente")]
    [InverseProperty("FaFactura")]
    public virtual FaCliente FaCliente { get; set; } = null!;

    [InverseProperty("FaFactura")]
    public virtual ICollection<FaDevolVenta> FaDevolVenta { get; set; } = new List<FaDevolVenta>();

    [InverseProperty("FaFactura")]
    public virtual ICollection<FaFacturaDet> FaFacturaDet { get; set; } = new List<FaFacturaDet>();

    [InverseProperty("FaFactura")]
    public virtual ICollection<FaFacturaDetOtrosCampos> FaFacturaDetOtrosCampos { get; set; } = new List<FaFacturaDetOtrosCampos>();

    [InverseProperty("FaFactura")]
    public virtual FaFacturaEdehsa? FaFacturaEdehsa { get; set; }

    [InverseProperty("FaFactura")]
    public virtual ICollection<FaFacturaXCtCbtecble> FaFacturaXCtCbtecble { get; set; } = new List<FaFacturaXCtCbtecble>();

    [InverseProperty("FaFactura")]
    public virtual ICollection<FaFacturaXFaCotizacion> FaFacturaXFaCotizacion { get; set; } = new List<FaFacturaXFaCotizacion>();

    [InverseProperty("FaFactura")]
    public virtual ICollection<FaFacturaXFaGuiaRemision> FaFacturaXFaGuiaRemision { get; set; } = new List<FaFacturaXFaGuiaRemision>();

    [InverseProperty("FaFactura")]
    public virtual ICollection<FaFacturaXFormaPago> FaFacturaXFormaPago { get; set; } = new List<FaFacturaXFormaPago>();

    [InverseProperty("FaFactura")]
    public virtual ICollection<FaFacturaXInIngEgrInven> FaFacturaXInIngEgrInven { get; set; } = new List<FaFacturaXInIngEgrInven>();

    [InverseProperty("FaFactura")]
    public virtual ICollection<FaFacturaXInMoviInve> FaFacturaXInMoviInve { get; set; } = new List<FaFacturaXInMoviInve>();

    [InverseProperty("FaFactura")]
    public virtual ICollection<FaFacturaXInMoviInveXAnulacion> FaFacturaXInMoviInveXAnulacion { get; set; } = new List<FaFacturaXInMoviInveXAnulacion>();

    [ForeignKey("IdEmpresaNcAnu, IdSucursalNcAnu, IdBodegaNcAnu, IdNotaNcAnu")]
    [InverseProperty("FaFactura")]
    public virtual FaNotaCreDeb? FaNotaCreDeb { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdPuntoVta")]
    [InverseProperty("FaFactura")]
    public virtual FaPuntoVta? FaPuntoVta { get; set; }

    [ForeignKey("IdEmpresa, IdVendedor")]
    [InverseProperty("FaFactura")]
    public virtual FaVendedor FaVendedor { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega")]
    [InverseProperty("FaFactura")]
    public virtual TbBodega TbBodega { get; set; } = null!;

    [ForeignKey("IdEmpresa, VtTipoDoc, VtSerie1, VtSerie2, VtNumFactura")]
    [InverseProperty("FaFactura")]
    public virtual TbSisDocumentoTipoTalonario? TbSisDocumentoTipoTalonario { get; set; }

    [ForeignKey("VtMes")]
    [InverseProperty("FaFactura")]
    public virtual TbMes VtMesNavigation { get; set; } = null!;
}
