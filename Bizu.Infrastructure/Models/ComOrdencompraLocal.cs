using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdOrdenCompra")]
[Table("com_ordencompra_local")]
[Index("IdEmpresa", "IdMotivo", Name = "FK_com_ordencompra_local_com_Motivo_Orden_Compra")]
[Index("IdTerminoPago", Name = "FK_com_ordencompra_local_com_TerminoPago")]
[Index("IdEstadoAprobacionCat", Name = "FK_com_ordencompra_local_com_catalogo")]
[Index("IdEstadoRecepcionCat", Name = "FK_com_ordencompra_local_com_catalogo1")]
[Index("IdEmpresa", "IdComprador", Name = "FK_com_ordencompra_local_com_comprador")]
[Index("IdEmpresa", "IdDepartamento", Name = "FK_com_ordencompra_local_com_departamento")]
[Index("IdEstadoCierre", Name = "FK_com_ordencompra_local_com_estado_cierre")]
[Index("IdEmpresa", "IdSolicitante", Name = "FK_com_ordencompra_local_com_solicitante")]
[Index("IdEmpresa", "IdProveedor", Name = "FK_com_ordencompra_local_cp_proveedor")]
[Index("IdEmpresa", "IdSucursal", "IdProyecto", Name = "FK_com_ordencompra_local_obr_Proyecto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComOrdencompraLocal
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdOrdenCompra { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("oc_NumDocumento")]
    [StringLength(50)]
    public string OcNumDocumento { get; set; } = null!;

    [StringLength(5)]
    public string Tipo { get; set; } = null!;

    [StringLength(25)]
    public string IdTerminoPago { get; set; } = null!;

    [Column("oc_plazo")]
    public int OcPlazo { get; set; }

    [Column("oc_fecha")]
    [MaxLength(6)]
    public DateTime OcFecha { get; set; }

    [Column("oc_flete")]
    public double OcFlete { get; set; }

    [Column("oc_observacion")]
    [StringLength(1000)]
    public string OcObservacion { get; set; } = null!;

    public int? IdProyecto { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("IdEstadoAprobacion_cat")]
    [StringLength(25)]
    public string IdEstadoAprobacionCat { get; set; } = null!;

    [Column("co_fecha_aprobacion")]
    [MaxLength(6)]
    public DateTime? CoFechaAprobacion { get; set; }

    [Column("IdUsuario_Aprueba")]
    [StringLength(20)]
    public string? IdUsuarioAprueba { get; set; }

    [Column("IdUsuario_Reprue")]
    [StringLength(20)]
    public string? IdUsuarioReprue { get; set; }

    [Column("co_fechaReproba")]
    [MaxLength(6)]
    public DateTime? CoFechaReproba { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaHoraAnul { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("IdEstadoRecepcion_cat")]
    [StringLength(25)]
    public string IdEstadoRecepcionCat { get; set; } = null!;

    [StringLength(1)]
    public string? AfectaCosto { get; set; }

    [StringLength(500)]
    public string? MotivoAnulacion { get; set; }

    [StringLength(500)]
    public string? MotivoReprobacion { get; set; }

    [StringLength(200)]
    public string? Solicitante { get; set; }

    [Precision(18, 0)]
    public decimal? IdSolicitante { get; set; }

    [Precision(18, 0)]
    public decimal? IdDepartamento { get; set; }

    [StringLength(25)]
    public string? IdUsuario { get; set; }

    public int? IdMotivo { get; set; }

    [Column("oc_fechaVencimiento")]
    [MaxLength(6)]
    public DateTime? OcFechaVencimiento { get; set; }

    [Column("IdEstado_cierre")]
    [StringLength(25)]
    public string? IdEstadoCierre { get; set; }

    [Precision(18, 0)]
    public decimal IdComprador { get; set; }

    public int? IdSolicitud { get; set; }

    [ForeignKey("IdEmpresa, IdComprador")]
    [InverseProperty("ComOrdencompraLocal")]
    public virtual ComComprador ComComprador { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdDepartamento")]
    [InverseProperty("ComOrdencompraLocal")]
    public virtual ComDepartamento? ComDepartamento { get; set; }

    [ForeignKey("IdEmpresa, IdMotivo")]
    [InverseProperty("ComOrdencompraLocal")]
    public virtual ComMotivoOrdenCompra? ComMotivoOrdenCompra { get; set; }

    [InverseProperty("ComOrdencompraLocal")]
    public virtual ICollection<ComOrdencompraLocalDet> ComOrdencompraLocalDet { get; set; } = new List<ComOrdencompraLocalDet>();

    [InverseProperty("ComOrdencompraLocal")]
    public virtual ICollection<ComOrdencompraLocalXComSolicitudCompra> ComOrdencompraLocalXComSolicitudCompra { get; set; } = new List<ComOrdencompraLocalXComSolicitudCompra>();

    [ForeignKey("IdEmpresa, IdSolicitante")]
    [InverseProperty("ComOrdencompraLocal")]
    public virtual ComSolicitante? ComSolicitante { get; set; }

    [InverseProperty("ComOrdencompraLocal")]
    public virtual ICollection<CpNotaDebCreXComOrdencompraLocal> CpNotaDebCreXComOrdencompraLocal { get; set; } = new List<CpNotaDebCreXComOrdencompraLocal>();

    [InverseProperty("ComOrdencompraLocal")]
    public virtual ICollection<CpOrdenGiroXComOrdencompraLocal> CpOrdenGiroXComOrdencompraLocal { get; set; } = new List<CpOrdenGiroXComOrdencompraLocal>();

    [ForeignKey("IdEmpresa, IdProveedor")]
    [InverseProperty("ComOrdencompraLocal")]
    public virtual CpProveedor CpProveedor { get; set; } = null!;

    [ForeignKey("IdEstadoAprobacionCat")]
    [InverseProperty("ComOrdencompraLocalIdEstadoAprobacionCatNavigation")]
    public virtual ComCatalogo IdEstadoAprobacionCatNavigation { get; set; } = null!;

    [ForeignKey("IdEstadoCierre")]
    [InverseProperty("ComOrdencompraLocal")]
    public virtual ComEstadoCierre? IdEstadoCierreNavigation { get; set; }

    [ForeignKey("IdEstadoRecepcionCat")]
    [InverseProperty("ComOrdencompraLocalIdEstadoRecepcionCatNavigation")]
    public virtual ComCatalogo IdEstadoRecepcionCatNavigation { get; set; } = null!;

    [ForeignKey("IdTerminoPago")]
    [InverseProperty("ComOrdencompraLocal")]
    public virtual ComTerminoPago IdTerminoPagoNavigation { get; set; } = null!;

    [InverseProperty("ComOrdencompraLocal")]
    public virtual ICollection<InMoviInveXInOrdencompraLocal> InMoviInveXInOrdencompraLocal { get; set; } = new List<InMoviInveXInOrdencompraLocal>();

    [ForeignKey("IdEmpresa, IdSucursal")]
    [InverseProperty("ComOrdencompraLocal")]
    public virtual TbSucursal TbSucursal { get; set; } = null!;
}
