using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursalOrigen", "IdBodegaOrigen", "IdTransferencia", "IdEmpresaGuia", "IdSucursalGuia", "IdBodegaGuia", "IdGuiaRemision")]
[Table("in_transferencia_x_fa_guia_remision")]
[Index("IdEmpresaGuia", "IdSucursalGuia", "IdBodegaGuia", "IdGuiaRemision", Name = "FK_in_transferencia_x_fa_guia_remision_fa_guia_remision")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InTransferenciaXFaGuiaRemision
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
    [Column("IdEmpresa_Guia")]
    public int IdEmpresaGuia { get; set; }

    [Key]
    [Column("IdSucursal_Guia")]
    public int IdSucursalGuia { get; set; }

    [Key]
    [Column("IdBodega_Guia")]
    public int IdBodegaGuia { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdGuiaRemision { get; set; }

    [StringLength(10)]
    public string? Obser { get; set; }

    [ForeignKey("IdEmpresaGuia, IdSucursalGuia, IdBodegaGuia, IdGuiaRemision")]
    [InverseProperty("InTransferenciaXFaGuiaRemision")]
    public virtual FaGuiaRemision FaGuiaRemision { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursalOrigen, IdBodegaOrigen, IdTransferencia")]
    [InverseProperty("InTransferenciaXFaGuiaRemision")]
    public virtual InTransferencia InTransferencia { get; set; } = null!;
}
