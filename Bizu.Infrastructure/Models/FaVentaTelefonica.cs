using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdVentaTel")]
[Table("fa_venta_telefonica")]
[Index("IdEmpresa", "IdCliente", Name = "FK_fa_venta_telefonica_fa_cliente")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaVentaTelefonica
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Column("IdVenta_tel")]
    [Precision(18, 0)]
    public decimal IdVentaTel { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public DateOnly Fecha { get; set; }

    [StringLength(250)]
    public string Observacion { get; set; } = null!;

    [StringLength(15)]
    public string IdMotivo { get; set; } = null!;

    [Column("Contactar_futuro")]
    [StringLength(1)]
    public string ContactarFuturo { get; set; } = null!;

    [StringLength(20)]
    public string IdUsuario { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [ForeignKey("IdEmpresa, IdCliente")]
    [InverseProperty("FaVentaTelefonica")]
    public virtual FaCliente FaCliente { get; set; } = null!;

    [InverseProperty("FaVentaTelefonica")]
    public virtual ICollection<FaVentaTelefonicaDet> FaVentaTelefonicaDet { get; set; } = new List<FaVentaTelefonicaDet>();

    [ForeignKey("IdEmpresa, IdSucursal")]
    [InverseProperty("FaVentaTelefonica")]
    public virtual TbSucursal TbSucursal { get; set; } = null!;
}
