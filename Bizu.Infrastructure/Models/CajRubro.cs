using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdRubro")]
[Table("caj_rubro")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CajRubro
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdRubro { get; set; }

    [StringLength(50)]
    public string? Codigo { get; set; }

    [StringLength(150)]
    public string? Nombre { get; set; }

    [StringLength(1)]
    public string? Estado { get; set; }

    [InverseProperty("CajRubro")]
    public virtual ICollection<CajCajachicaDet> CajCajachicaDet { get; set; } = new List<CajCajachicaDet>();

    [InverseProperty("CajRubro")]
    public virtual ICollection<CajCustodioXCajRubro> CajCustodioXCajRubro { get; set; } = new List<CajCustodioXCajRubro>();
}
