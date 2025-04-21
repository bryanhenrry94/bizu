using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdPuntoVta")]
[Table("fa_PuntoVta")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaPuntoVta
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdPuntoVta { get; set; }

    [Column("cod_PuntoVta")]
    [StringLength(50)]
    public string CodPuntoVta { get; set; } = null!;

    [Column("nom_PuntoVta")]
    [StringLength(150)]
    public string NomPuntoVta { get; set; } = null!;

    [Column("estado")]
    public bool Estado { get; set; }

    public int? IdBodega { get; set; }

    [InverseProperty("FaPuntoVta")]
    public virtual ICollection<FaFactura> FaFactura { get; set; } = new List<FaFactura>();

    [InverseProperty("FaPuntoVta")]
    public virtual ICollection<FaNotaCreDeb> FaNotaCreDeb { get; set; } = new List<FaNotaCreDeb>();

    [ForeignKey("IdEmpresa, IdSucursal")]
    [InverseProperty("FaPuntoVta")]
    public virtual TbSucursal TbSucursal { get; set; } = null!;
}
