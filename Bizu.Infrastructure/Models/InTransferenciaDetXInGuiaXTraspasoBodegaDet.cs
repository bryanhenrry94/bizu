using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresaTrans", "IdSucursalOrigenTrans", "IdBodegaOrigenTrans", "IdTransferenciaTrans", "SecuenciaTrans", "IdEmpresaGuia", "IdGuiaGuia", "SecuenciaGuia")]
[Table("in_transferencia_det_x_in_Guia_x_traspaso_bodega_det")]
[Index("IdEmpresaGuia", "IdGuiaGuia", "SecuenciaGuia", Name = "FK_in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_in_Gui11")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InTransferenciaDetXInGuiaXTraspasoBodegaDet
{
    [Key]
    [Column("IdEmpresa_trans")]
    public int IdEmpresaTrans { get; set; }

    [Key]
    [Column("IdSucursalOrigen_trans")]
    public int IdSucursalOrigenTrans { get; set; }

    [Key]
    [Column("IdBodegaOrigen_trans")]
    public int IdBodegaOrigenTrans { get; set; }

    [Key]
    [Column("IdTransferencia_trans")]
    [Precision(18, 0)]
    public decimal IdTransferenciaTrans { get; set; }

    [Key]
    [Column("Secuencia_trans")]
    public int SecuenciaTrans { get; set; }

    [Key]
    [Column("IdEmpresa_guia")]
    public int IdEmpresaGuia { get; set; }

    [Key]
    [Column("IdGuia_guia")]
    [Precision(18, 0)]
    public decimal IdGuiaGuia { get; set; }

    [Key]
    [Column("Secuencia_guia")]
    public int SecuenciaGuia { get; set; }

    [StringLength(20)]
    public string? Observacion { get; set; }

    [ForeignKey("IdEmpresaGuia, IdGuiaGuia, SecuenciaGuia")]
    [InverseProperty("InTransferenciaDetXInGuiaXTraspasoBodegaDet")]
    public virtual InGuiaXTraspasoBodegaDet InGuiaXTraspasoBodegaDet { get; set; } = null!;

    [ForeignKey("IdEmpresaTrans, IdSucursalOrigenTrans, IdBodegaOrigenTrans, IdTransferenciaTrans, SecuenciaTrans")]
    [InverseProperty("InTransferenciaDetXInGuiaXTraspasoBodegaDet")]
    public virtual InTransferenciaDet InTransferenciaDet { get; set; } = null!;
}
