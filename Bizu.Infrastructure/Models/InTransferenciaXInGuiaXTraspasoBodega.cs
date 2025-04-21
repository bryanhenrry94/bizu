using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursalOrgen", "IdBodegaOrigen", "IdTransferencia", "IdEmpresaGuia", "IdGuia")]
[Table("in_transferencia_x_in_Guia_x_traspaso_bodega")]
[Index("IdEmpresaGuia", "IdGuia", Name = "FK_in_transferencia_x_in_Guia_x_traspaso_bodega_in_Guia_x_tras36")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InTransferenciaXInGuiaXTraspasoBodega
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursalOrgen { get; set; }

    [Key]
    public int IdBodegaOrigen { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdTransferencia { get; set; }

    [Key]
    [Column("IdEmpresa_Guia")]
    public int IdEmpresaGuia { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdGuia { get; set; }

    [StringLength(500)]
    public string Observacion { get; set; } = null!;

    [ForeignKey("IdEmpresaGuia, IdGuia")]
    [InverseProperty("InTransferenciaXInGuiaXTraspasoBodega")]
    public virtual InGuiaXTraspasoBodega InGuiaXTraspasoBodega { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursalOrgen, IdBodegaOrigen, IdTransferencia")]
    [InverseProperty("InTransferenciaXInGuiaXTraspasoBodega")]
    public virtual InTransferencia InTransferencia { get; set; } = null!;
}
