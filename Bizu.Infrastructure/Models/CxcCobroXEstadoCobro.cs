using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdCobro", "IdEstadoCobro", "Secuencia")]
[Table("cxc_cobro_x_EstadoCobro")]
[Index("IdEstadoCobro", Name = "FK_cxc_cobro_x_EstadoCobro_cxc_EstadoCobro")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcCobroXEstadoCobro
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCobro { get; set; }

    [Key]
    [StringLength(5)]
    public string IdEstadoCobro { get; set; } = null!;

    [Key]
    public int Secuencia { get; set; }

    [Column("IdCobro_tipo")]
    [StringLength(20)]
    public string? IdCobroTipo { get; set; }

    [Column("observacion")]
    [StringLength(200)]
    public string? Observacion { get; set; }

    [MaxLength(6)]
    public DateTime Fecha { get; set; }

    [Column("nt_IdSucursal")]
    public int? NtIdSucursal { get; set; }

    [Column("nt_IdBodega")]
    public int? NtIdBodega { get; set; }

    [Column("nt_IdNota")]
    [Precision(18, 0)]
    public decimal? NtIdNota { get; set; }

    public int? IdBanco { get; set; }

    [Column("IdCbte_vta_nota")]
    [Precision(18, 0)]
    public decimal? IdCbteVtaNota { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [ForeignKey("IdEmpresa, IdSucursal, IdCobro")]
    [InverseProperty("CxcCobroXEstadoCobro")]
    public virtual CxcCobro CxcCobro { get; set; } = null!;

    [ForeignKey("IdEstadoCobro")]
    [InverseProperty("CxcCobroXEstadoCobro")]
    public virtual CxcEstadoCobro IdEstadoCobroNavigation { get; set; } = null!;
}
