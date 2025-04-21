using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdCobro", "IdCobroTipo", "IdCobroAplicado", "IdCobroTipoAplicado", "IdCbteVtaAplicado")]
[Table("cxc_cobro_x_tarjeta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcCobroXTarjeta
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCobro { get; set; }

    [Key]
    [Column("IdCobro_tipo")]
    [StringLength(15)]
    public string IdCobroTipo { get; set; } = null!;

    [Key]
    [Column("IdCobro_Aplicado")]
    [Precision(18, 0)]
    public decimal IdCobroAplicado { get; set; }

    [Key]
    [Column("IdCobro_tipo_Aplicado")]
    [StringLength(15)]
    public string IdCobroTipoAplicado { get; set; } = null!;

    [Key]
    [Column("IdCbte_vta_aplicado")]
    [Precision(18, 0)]
    public decimal IdCbteVtaAplicado { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdCobro")]
    [InverseProperty("CxcCobroXTarjeta")]
    public virtual CxcCobro CxcCobro { get; set; } = null!;
}
