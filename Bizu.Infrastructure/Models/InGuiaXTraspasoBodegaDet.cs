using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdGuia", "Secuencia")]
[Table("in_Guia_x_traspaso_bodega_det")]
[Index("IdEmpresaOc", "IdSucursalOc", "IdOrdenCompraOc", "SecuenciaOc", Name = "FK_in_Guia_x_traspaso_bodega_det_com_ordencompra_local_det")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InGuiaXTraspasoBodegaDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdGuia { get; set; }

    [Key]
    [Column("secuencia")]
    public int Secuencia { get; set; }

    [Column("IdEmpresa_OC")]
    public int? IdEmpresaOc { get; set; }

    [Column("IdSucursal_OC")]
    public int? IdSucursalOc { get; set; }

    [Column("IdOrdenCompra_OC")]
    [Precision(18, 0)]
    public decimal? IdOrdenCompraOc { get; set; }

    [Column("Secuencia_OC")]
    public int? SecuenciaOc { get; set; }

    [Column("observacion")]
    [StringLength(1000)]
    public string? Observacion { get; set; }

    [Column("Cantidad_enviar")]
    public double? CantidadEnviar { get; set; }

    [StringLength(50)]
    public string? Referencia { get; set; }

    [ForeignKey("IdEmpresaOc, IdSucursalOc, IdOrdenCompraOc, SecuenciaOc")]
    [InverseProperty("InGuiaXTraspasoBodegaDet")]
    public virtual ComOrdencompraLocalDet? ComOrdencompraLocalDet { get; set; }

    [ForeignKey("IdEmpresa, IdGuia")]
    [InverseProperty("InGuiaXTraspasoBodegaDet")]
    public virtual InGuiaXTraspasoBodega InGuiaXTraspasoBodega { get; set; } = null!;

    [InverseProperty("InGuiaXTraspasoBodegaDet")]
    public virtual ICollection<InTransferenciaDetXInGuiaXTraspasoBodegaDet> InTransferenciaDetXInGuiaXTraspasoBodegaDet { get; set; } = new List<InTransferenciaDetXInGuiaXTraspasoBodegaDet>();
}
