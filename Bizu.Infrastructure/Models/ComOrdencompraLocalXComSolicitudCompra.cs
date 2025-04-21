using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresaOc", "IdSucursalOc", "IdOrdenCompraOc", "IdEmpresaSc", "IdSucursalSc", "IdSolicitudCompraSc", "SecuenciaSc")]
[Table("com_ordencompra_local_x_com_solicitud_compra")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class ComOrdencompraLocalXComSolicitudCompra
{
    [Key]
    [Column("IdEmpresa_oc")]
    public int IdEmpresaOc { get; set; }

    [Key]
    [Column("IdSucursal_oc")]
    public int IdSucursalOc { get; set; }

    [Key]
    [Column("IdOrdenCompra_oc")]
    [Precision(18, 0)]
    public decimal IdOrdenCompraOc { get; set; }

    [Key]
    [Column("IdEmpresa_sc")]
    public int IdEmpresaSc { get; set; }

    [Key]
    [Column("IdSucursal_sc")]
    public int IdSucursalSc { get; set; }

    [Key]
    [Column("IdSolicitudCompra_sc")]
    [Precision(18, 0)]
    public decimal IdSolicitudCompraSc { get; set; }

    [Key]
    [Column("Secuencia_sc")]
    public int SecuenciaSc { get; set; }

    public double Cantidad { get; set; }

    [ForeignKey("IdEmpresaOc, IdSucursalOc, IdOrdenCompraOc")]
    [InverseProperty("ComOrdencompraLocalXComSolicitudCompra")]
    public virtual ComOrdencompraLocal ComOrdencompraLocal { get; set; } = null!;
}
