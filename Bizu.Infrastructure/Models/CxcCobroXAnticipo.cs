using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdAnticipo")]
[Table("cxc_cobro_x_Anticipo")]
[Index("IdEmpresa", "IdCaja", Name = "FK_cxc_cobro_x_Anticipo_caj_Caja")]
[Index("IdEmpresa", "IdCliente", Name = "FK_cxc_cobro_x_Anticipo_fa_cliente")]
[Index("IdEmpresa", "IdSucursal", Name = "FK_cxc_cobro_x_Anticipo_tb_sucursal")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcCobroXAnticipo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdAnticipo { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [StringLength(250)]
    public string? Observacion { get; set; }

    [MaxLength(6)]
    public DateTime? Fecha { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

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

    [StringLength(1)]
    public string? Estado { get; set; }

    [StringLength(50)]
    public string? MotiAnula { get; set; }

    public int? IdCaja { get; set; }

    [ForeignKey("IdEmpresa, IdCaja")]
    [InverseProperty("CxcCobroXAnticipo")]
    public virtual CajCaja? CajCaja { get; set; }

    [InverseProperty("CxcCobroXAnticipo")]
    public virtual ICollection<CxcCobroXAnticipoDet> CxcCobroXAnticipoDet { get; set; } = new List<CxcCobroXAnticipoDet>();

    [ForeignKey("IdEmpresa, IdCliente")]
    [InverseProperty("CxcCobroXAnticipo")]
    public virtual FaCliente FaCliente { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal")]
    [InverseProperty("CxcCobroXAnticipo")]
    public virtual TbSucursal TbSucursal { get; set; } = null!;
}
