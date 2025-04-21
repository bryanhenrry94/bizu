using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCaja", "IdSecuencia")]
[Table("caj_cajachica_det")]
[Index("IdEmpresa", "IdRubro", Name = "caj_cajachica_det_caj_rubro_FK")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class CajCajachicaDet
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdCaja { get; set; }

    [Key]
    public int IdSecuencia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    public int? IdRubro { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [StringLength(25)]
    public string? IdTipoDocumento { get; set; }

    [StringLength(25)]
    public string? NumeroDocumento { get; set; }

    [Precision(10, 2)]
    public decimal? Subtotal { get; set; }

    [Column("IdCod_Impuesto")]
    [StringLength(25)]
    public string? IdCodImpuesto { get; set; }

    [Precision(10, 2)]
    public decimal? Iva { get; set; }

    [Precision(10, 2)]
    public decimal? TotalCompra { get; set; }

    [Precision(10, 2)]
    public decimal? TotalAprobado { get; set; }

    public bool? Check { get; set; }

    [StringLength(20)]
    public string? IdCtaCble { get; set; }

    [StringLength(250)]
    public string? Detalle { get; set; }

    [ForeignKey("IdEmpresa, IdRubro")]
    [InverseProperty("CajCajachicaDet")]
    public virtual CajRubro? CajRubro { get; set; }
}
