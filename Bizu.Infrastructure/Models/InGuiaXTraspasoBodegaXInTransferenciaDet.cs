using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdGuia", "IdEmpresaTras", "IdSucursalOrigen", "IdBodegaOrigen", "IdTransferencia", "DtSecuencia")]
[Table("in_Guia_x_traspaso_bodega_x_in_transferencia_det")]
[Index("IdEmpresaTras", "IdSucursalOrigen", "IdBodegaOrigen", "IdTransferencia", "DtSecuencia", Name = "FK_in_Guia_x_traspaso_bodega_x_in_transferencia_det_in_transfe14")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InGuiaXTraspasoBodegaXInTransferenciaDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdGuia { get; set; }

    [Key]
    [Column("IdEmpresa_tras")]
    public int IdEmpresaTras { get; set; }

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

    [Column("cantidad")]
    [Precision(18, 2)]
    public decimal Cantidad { get; set; }

    [Column("observacion")]
    [StringLength(1000)]
    public string Observacion { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdGuia")]
    [InverseProperty("InGuiaXTraspasoBodegaXInTransferenciaDet")]
    public virtual InGuiaXTraspasoBodega InGuiaXTraspasoBodega { get; set; } = null!;

    [ForeignKey("IdEmpresaTras, IdSucursalOrigen, IdBodegaOrigen, IdTransferencia, DtSecuencia")]
    [InverseProperty("InGuiaXTraspasoBodegaXInTransferenciaDet")]
    public virtual InTransferenciaDet InTransferenciaDet { get; set; } = null!;
}
