using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursalOrigen", "IdBodegaOrigen", "IdTransferencia", "DtSecuencia")]
[Table("in_transferencia_det")]
[Index("IdEmpresa", "IdCentroCosto", "IdCentroCostoSubCentroCosto", Name = "FK_in_transferencia_det_ct_centro_costo_sub_centro_costo")]
[Index("IdEmpresa", "IdPuntoCargo", Name = "FK_in_transferencia_det_ct_punto_cargo")]
[Index("IdEmpresa", "IdPuntoCargoGrupo", Name = "FK_in_transferencia_det_ct_punto_cargo_grupo")]
[Index("IdEmpresa", "IdProducto", Name = "FK_in_transferencia_det_in_Producto")]
[Index("IdUnidadMedida", Name = "FK_in_transferencia_det_in_UnidadMedida")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InTransferenciaDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursalOrigen { get; set; }

    [Key]
    public int IdBodegaOrigen { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdTransferencia { get; set; }

    [Key]
    [Column("dt_secuencia")]
    public int DtSecuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("dt_cantidad")]
    public double DtCantidad { get; set; }

    [Column("tr_Observacion")]
    [StringLength(1000)]
    public string? TrObservacion { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("IdCentroCosto_sub_centro_costo")]
    [StringLength(20)]
    public string? IdCentroCostoSubCentroCosto { get; set; }

    [StringLength(25)]
    public string IdUnidadMedida { get; set; } = null!;

    [Column("IdPunto_cargo_grupo")]
    public int? IdPuntoCargoGrupo { get; set; }

    [Column("IdPunto_cargo")]
    public int? IdPuntoCargo { get; set; }

    [StringLength(50)]
    public string? Lote { get; set; }

    [ForeignKey("IdEmpresa, IdCentroCosto, IdCentroCostoSubCentroCosto")]
    [InverseProperty("InTransferenciaDet")]
    public virtual CtCentroCostoSubCentroCosto? CtCentroCostoSubCentroCosto { get; set; }

    [ForeignKey("IdEmpresa, IdPuntoCargo")]
    [InverseProperty("InTransferenciaDet")]
    public virtual CtPuntoCargo? CtPuntoCargo { get; set; }

    [ForeignKey("IdEmpresa, IdPuntoCargoGrupo")]
    [InverseProperty("InTransferenciaDet")]
    public virtual CtPuntoCargoGrupo? CtPuntoCargoGrupo { get; set; }

    [ForeignKey("IdUnidadMedida")]
    [InverseProperty("InTransferenciaDet")]
    public virtual InUnidadMedida IdUnidadMedidaNavigation { get; set; } = null!;

    [InverseProperty("InTransferenciaDet")]
    public virtual ICollection<InGuiaXTraspasoBodegaXInTransferenciaDet> InGuiaXTraspasoBodegaXInTransferenciaDet { get; set; } = new List<InGuiaXTraspasoBodegaXInTransferenciaDet>();

    [ForeignKey("IdEmpresa, IdProducto")]
    [InverseProperty("InTransferenciaDet")]
    public virtual InProducto InProducto { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursalOrigen, IdBodegaOrigen, IdTransferencia")]
    [InverseProperty("InTransferenciaDet")]
    public virtual InTransferencia InTransferencia { get; set; } = null!;

    [InverseProperty("InTransferenciaDet")]
    public virtual ICollection<InTransferenciaDetXInGuiaXTraspasoBodegaDet> InTransferenciaDetXInGuiaXTraspasoBodegaDet { get; set; } = new List<InTransferenciaDetXInGuiaXTraspasoBodegaDet>();
}
