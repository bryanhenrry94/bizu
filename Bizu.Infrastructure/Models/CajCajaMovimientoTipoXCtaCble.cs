using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdTipoMovi")]
[Table("caj_Caja_Movimiento_Tipo_x_CtaCble")]
[Index("IdTipoMovi", Name = "FK_caj_Caja_Movimiento_Tipo_x_CtaCble_caj_Caja_Movimiento_Tipo")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_caj_Caja_Movimiento_Tipo_x_CtaCble_ct_plancta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CajCajaMovimientoTipoXCtaCble
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdTipoMovi { get; set; }

    [StringLength(20)]
    public string? IdCtaCble { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("CajCajaMovimientoTipoXCtaCble")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdTipoMovi")]
    [InverseProperty("CajCajaMovimientoTipoXCtaCble")]
    public virtual CajCajaMovimientoTipo IdTipoMoviNavigation { get; set; } = null!;
}
