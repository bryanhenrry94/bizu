using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcomOrdencompraLocalXInGuiaXTraspasoBodega
{
    public int IdEmpresa { get; set; }

    [Precision(18, 0)]
    public decimal IdGuia { get; set; }

    [Column("IdSucursal_Partida")]
    public int? IdSucursalPartida { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("IdSucursal_Llegada")]
    public int? IdSucursalLlegada { get; set; }

    [Column("Su_Descripcion_Llegada")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcionLlegada { get; set; } = null!;

    [Column("IdEmpresa_OC")]
    public int? IdEmpresaOc { get; set; }

    [Column("IdSucursal_OC")]
    public int? IdSucursalOc { get; set; }

    [Column("IdOrdenCompra_OC")]
    [Precision(18, 0)]
    public decimal? IdOrdenCompraOc { get; set; }

    [MaxLength(6)]
    public DateTime? Fecha { get; set; }
}
