using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdCustodio", "IdRubro")]
[Table("caj_custodio_x_caj_rubro")]
[Index("IdEmpresa", "IdRubro", Name = "caj_custodio_x_caj_rubro_FK_1")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CajCustodioXCajRubro
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdCustodio { get; set; }

    [Key]
    public int IdRubro { get; set; }

    [StringLength(20)]
    public string? IdCtaCble { get; set; }

    [ForeignKey("IdEmpresa, IdCustodio")]
    [InverseProperty("CajCustodioXCajRubro")]
    public virtual CajCustodio CajCustodio { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdRubro")]
    [InverseProperty("CajCustodioXCajRubro")]
    public virtual CajRubro CajRubro { get; set; } = null!;
}
