using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdActivoFijo")]
[Table("Af_Activo_fijo")]
[Index("IdEmpresa", "IdCategoriaAf", Name = "FK_Af_Activo_fijo_Af_Activo_fijo_Categoria")]
[Index("IdEmpresa", "IdActijoFijoTipo", Name = "FK_Af_Activo_fijo_Af_Activo_fijo_tipo")]
[Index("IdTipoCatalogoUbicacion", Name = "FK_Af_Activo_fijo_Af_Catalogo")]
[Index("IdCatalogoMarca", Name = "FK_Af_Activo_fijo_Af_Catalogo1")]
[Index("IdCatalogoModelo", Name = "FK_Af_Activo_fijo_Af_Catalogo2")]
[Index("IdCatalogoColor", Name = "FK_Af_Activo_fijo_Af_Catalogo3")]
[Index("EstadoProceso", Name = "FK_Af_Activo_fijo_Af_Catalogo4")]
[Index("IdEmpresa", "IdDepartamento", Name = "FK_Af_Activo_fijo_Af_Departamento")]
[Index("IdEmpresa", "IdEncargado", Name = "FK_Af_Activo_fijo_Af_Encargado")]
[Index("IdPeriodoDeprec", Name = "FK_Af_Activo_fijo_Af_PeriodoDepreciacion")]
[Index("IdTipoDepreciacion", Name = "FK_Af_Activo_fijo_Af_Tipo_Depreciacion")]
[Index("IdEmpresa", "IdProveedor", Name = "FK_Af_Activo_fijo_cp_proveedor")]
[Index("IdEmpresa", "IdProducto", Name = "FK_Af_Activo_fijo_in_Producto")]
[Index("IdEmpresa", "IdSucursal", Name = "FK_Af_Activo_fijo_tb_sucursal")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfActivoFijo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdActivoFijo { get; set; }

    [StringLength(50)]
    public string CodActivoFijo { get; set; } = null!;

    public int IdTipoDepreciacion { get; set; }

    [Column("Af_Nombre")]
    [StringLength(500)]
    public string AfNombre { get; set; } = null!;

    public int IdActijoFijoTipo { get; set; }

    public int IdSucursal { get; set; }

    [Column("IdCatalogo_Marca")]
    [StringLength(35)]
    public string IdCatalogoMarca { get; set; } = null!;

    [Column("IdCatalogo_Modelo")]
    [StringLength(35)]
    public string IdCatalogoModelo { get; set; } = null!;

    [Column("Af_NumSerie")]
    [StringLength(50)]
    public string? AfNumSerie { get; set; }

    [Column("IdCatalogo_Color")]
    [StringLength(35)]
    public string IdCatalogoColor { get; set; } = null!;

    [Column("IdTipoCatalogo_Ubicacion")]
    [StringLength(35)]
    public string? IdTipoCatalogoUbicacion { get; set; }

    [Column("Af_fecha_compra")]
    [MaxLength(6)]
    public DateTime AfFechaCompra { get; set; }

    [Column("Af_fecha_ini_depre")]
    [MaxLength(6)]
    public DateTime AfFechaIniDepre { get; set; }

    [Column("Af_fecha_fin_depre")]
    [MaxLength(6)]
    public DateTime AfFechaFinDepre { get; set; }

    [Column("Af_Costo_historico")]
    public double AfCostoHistorico { get; set; }

    [Column("Af_costo_compra")]
    public double AfCostoCompra { get; set; }

    [Column("Af_Depreciacion_acum")]
    public double? AfDepreciacionAcum { get; set; }

    [Column("Af_Vida_Util")]
    public int AfVidaUtil { get; set; }

    [Column("Af_Meses_depreciar")]
    public int AfMesesDepreciar { get; set; }

    [Column("Af_porcentaje_deprec")]
    public double AfPorcentajeDeprec { get; set; }

    [Column("Af_observacion")]
    [StringLength(1000)]
    public string AfObservacion { get; set; } = null!;

    [Column("Af_NumPlaca")]
    [StringLength(20)]
    public string? AfNumPlaca { get; set; }

    [Column("Af_Anio_fabrica")]
    public int? AfAnioFabrica { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(100)]
    public string? MotiAnula { get; set; }

    [Column("Af_foto")]
    public byte[]? AfFoto { get; set; }

    [Column("Af_DescripcionCorta")]
    [StringLength(50)]
    public string? AfDescripcionCorta { get; set; }

    [StringLength(20)]
    public string? IdPeriodoDeprec { get; set; }

    [Column("Af_Codigo_Parte")]
    [StringLength(50)]
    public string? AfCodigoParte { get; set; }

    [Column("Af_Codigo_Barra")]
    [StringLength(50)]
    public string? AfCodigoBarra { get; set; }

    [Column("Af_DescripcionTecnica")]
    [StringLength(200)]
    public string? AfDescripcionTecnica { get; set; }

    [Precision(18, 0)]
    public decimal? IdProveedor { get; set; }

    [Column("Af_FechaPoliza")]
    [MaxLength(6)]
    public DateTime? AfFechaPoliza { get; set; }

    [Column("Af_ValorPoliza")]
    public double? AfValorPoliza { get; set; }

    [Column("Af_ValorVenta")]
    public double? AfValorVenta { get; set; }

    [Column("Af_NumPoliza")]
    [StringLength(50)]
    public string? AfNumPoliza { get; set; }

    [Column("Af_Fecha_Venta")]
    [MaxLength(6)]
    public DateTime? AfFechaVenta { get; set; }

    [Column("Af_Fecha_Vencimiento")]
    [MaxLength(6)]
    public DateTime? AfFechaVencimiento { get; set; }

    [Column("Af_Fecha_Retiro")]
    [MaxLength(6)]
    public DateTime? AfFechaRetiro { get; set; }

    [Column("Estado_Proceso")]
    [StringLength(35)]
    public string? EstadoProceso { get; set; }

    [Column("Af_ValorSalvamento")]
    public double? AfValorSalvamento { get; set; }

    [Column("Af_ValorResidual")]
    public double? AfValorResidual { get; set; }

    [Column("IdEmpresa_oc")]
    public int? IdEmpresaOc { get; set; }

    [Column("IdSucursal_oc")]
    public int? IdSucursalOc { get; set; }

    [Precision(18, 0)]
    public decimal? IdOrdenCompra { get; set; }

    [Column("Secuencia_oc")]
    public int? SecuenciaOc { get; set; }

    [Precision(18, 0)]
    public decimal? IdProducto { get; set; }

    [Column("numDocumento")]
    [StringLength(50)]
    public string? NumDocumento { get; set; }

    public double? Cantidad { get; set; }

    [Column("Costo_uni")]
    public double? CostoUni { get; set; }

    public double? SubTotal { get; set; }

    [Column("valor_Iva")]
    public double? ValorIva { get; set; }

    public double? Total { get; set; }

    [Column("IdEmpresa_Ogiro")]
    public int? IdEmpresaOgiro { get; set; }

    [Column("IdCbteCble_Ogiro")]
    [Precision(18, 0)]
    public decimal? IdCbteCbleOgiro { get; set; }

    [Column("IdTipoCbte_Ogiro")]
    public int? IdTipoCbteOgiro { get; set; }

    [Column("IdOrden_giro_Tipo")]
    [StringLength(5)]
    public string? IdOrdenGiroTipo { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [Column("Af_NumSerie_Motor")]
    [StringLength(50)]
    public string? AfNumSerieMotor { get; set; }

    [Column("Af_NumSerie_Chasis")]
    [StringLength(50)]
    public string? AfNumSerieChasis { get; set; }

    [Column("IdCategoriaAF")]
    public int? IdCategoriaAf { get; set; }

    public int? IdDepartamento { get; set; }

    [Precision(18, 0)]
    public decimal? IdEncargado { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("IdUnidadFact_cat")]
    [StringLength(50)]
    public string? IdUnidadFactCat { get; set; }

    [Column("Af_ValorUnidad_Actu")]
    public double? AfValorUnidadActu { get; set; }

    [Column("Af_fecha_vigencia_desde")]
    [MaxLength(6)]
    public DateTime? AfFechaVigenciaDesde { get; set; }

    [Column("Subtotal_Prima")]
    public double? SubtotalPrima { get; set; }

    [Column("Iva_Prima")]
    public double? IvaPrima { get; set; }

    public double? Prima { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [Column("Af_Capacidad")]
    [StringLength(50)]
    public string? AfCapacidad { get; set; }

    [Column("Es_carroceria")]
    public bool? EsCarroceria { get; set; }

    [ForeignKey("IdEmpresa, IdCategoriaAf")]
    [InverseProperty("AfActivoFijo")]
    public virtual AfActivoFijoCategoria? AfActivoFijoCategoria { get; set; }

    [InverseProperty("AfActivoFijo")]
    public virtual ICollection<AfActivoFijoCtasCbles> AfActivoFijoCtasCbles { get; set; } = new List<AfActivoFijoCtasCbles>();

    [ForeignKey("IdEmpresa, IdActijoFijoTipo")]
    [InverseProperty("AfActivoFijo")]
    public virtual AfActivoFijoTipo AfActivoFijoTipo { get; set; } = null!;

    [InverseProperty("AfActivoFijo")]
    public virtual ICollection<AfCambioUbicacionActivo> AfCambioUbicacionActivo { get; set; } = new List<AfCambioUbicacionActivo>();

    [ForeignKey("IdEmpresa, IdDepartamento")]
    [InverseProperty("AfActivoFijo")]
    public virtual AfDepartamento? AfDepartamento { get; set; }

    [InverseProperty("AfActivoFijo")]
    public virtual ICollection<AfDepreciacionDet> AfDepreciacionDet { get; set; } = new List<AfDepreciacionDet>();

    [InverseProperty("AfActivoFijo")]
    public virtual ICollection<AfDepreciacionDetHisAnulacion> AfDepreciacionDetHisAnulacion { get; set; } = new List<AfDepreciacionDetHisAnulacion>();

    [ForeignKey("IdEmpresa, IdEncargado")]
    [InverseProperty("AfActivoFijo")]
    public virtual AfEncargado? AfEncargado { get; set; }

    [InverseProperty("AfActivoFijo")]
    public virtual ICollection<AfMejBajActivo> AfMejBajActivo { get; set; } = new List<AfMejBajActivo>();

    [InverseProperty("AfActivoFijo")]
    public virtual ICollection<AfProcesoDepreciacion> AfProcesoDepreciacion { get; set; } = new List<AfProcesoDepreciacion>();

    [InverseProperty("AfActivoFijo")]
    public virtual ICollection<AfRetiroActivo> AfRetiroActivo { get; set; } = new List<AfRetiroActivo>();

    [InverseProperty("AfActivoFijo")]
    public virtual ICollection<AfVentaActivo> AfVentaActivo { get; set; } = new List<AfVentaActivo>();

    [ForeignKey("IdEmpresa, IdProveedor")]
    [InverseProperty("AfActivoFijo")]
    public virtual CpProveedor? CpProveedor { get; set; }

    [ForeignKey("EstadoProceso")]
    [InverseProperty("AfActivoFijoEstadoProcesoNavigation")]
    public virtual AfCatalogo? EstadoProcesoNavigation { get; set; }

    [ForeignKey("IdCatalogoColor")]
    [InverseProperty("AfActivoFijoIdCatalogoColorNavigation")]
    public virtual AfCatalogo IdCatalogoColorNavigation { get; set; } = null!;

    [ForeignKey("IdCatalogoMarca")]
    [InverseProperty("AfActivoFijoIdCatalogoMarcaNavigation")]
    public virtual AfCatalogo IdCatalogoMarcaNavigation { get; set; } = null!;

    [ForeignKey("IdCatalogoModelo")]
    [InverseProperty("AfActivoFijoIdCatalogoModeloNavigation")]
    public virtual AfCatalogo IdCatalogoModeloNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa")]
    [InverseProperty("AfActivoFijo")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [ForeignKey("IdPeriodoDeprec")]
    [InverseProperty("AfActivoFijo")]
    public virtual AfPeriodoDepreciacion? IdPeriodoDeprecNavigation { get; set; }

    [ForeignKey("IdTipoCatalogoUbicacion")]
    [InverseProperty("AfActivoFijoIdTipoCatalogoUbicacionNavigation")]
    public virtual AfCatalogo? IdTipoCatalogoUbicacionNavigation { get; set; }

    [ForeignKey("IdTipoDepreciacion")]
    [InverseProperty("AfActivoFijo")]
    public virtual AfTipoDepreciacion IdTipoDepreciacionNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("AfActivoFijo")]
    public virtual InProducto? InProducto { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal")]
    [InverseProperty("AfActivoFijo")]
    public virtual TbSucursal TbSucursal { get; set; } = null!;
}
