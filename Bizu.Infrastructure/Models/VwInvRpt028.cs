using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwInvRpt028
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdOrdenCompra { get; set; }

    public int Secuencia { get; set; }

    [Precision(18, 0)]
    public decimal IdProducto { get; set; }

    [Column("cod_prod")]
    [StringLength(40)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodProd { get; set; } = null!;

    [Column("pr_descripcion")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string PrDescripcion { get; set; } = null!;

    [Column("oc_fecha")]
    [MaxLength(6)]
    public DateTime OcFecha { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("cod_provee")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string CodProvee { get; set; } = null!;

    [Column("nom_provee")]
    [StringLength(100)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomProvee { get; set; }

    [Column("IdEstadoAprobacion_cat")]
    [StringLength(25)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string IdEstadoAprobacionCat { get; set; } = null!;

    [Column("do_Cantidad")]
    public double DoCantidad { get; set; }

    [Column("dm_cantidad")]
    public double? DmCantidad { get; set; }
}
