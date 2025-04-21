using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdOrdenDespacho")]
[Table("fa_orden_Desp")]
[Index("IdEmpresa", "IdVendedor", Name = "FK_fa_orden_Desp_fa_Vendedor")]
[Index("IdEmpresa", "IdCliente", Name = "FK_fa_orden_Desp_fa_cliente")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaOrdenDesp
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdOrdenDespacho { get; set; }

    [StringLength(20)]
    public string CodOrdenDespacho { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public int IdVendedor { get; set; }

    [Precision(18, 0)]
    public decimal IdTransportista { get; set; }

    [Column("od_fecha")]
    [MaxLength(6)]
    public DateTime OdFecha { get; set; }

    [Column("od_plazo")]
    public int OdPlazo { get; set; }

    [Column("od_fech_venc")]
    [MaxLength(6)]
    public DateTime OdFechVenc { get; set; }

    [Column("od_Observacion")]
    [StringLength(1000)]
    public string OdObservacion { get; set; } = null!;

    [Column("od_TotalKilos")]
    public double OdTotalKilos { get; set; }

    [Column("od_TotalQuintales")]
    public double OdTotalQuintales { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime? FechaTransac { get; set; }

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

    [StringLength(200)]
    public string? MotivoAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("od_DespAbierto")]
    [StringLength(1)]
    public string? OdDespAbierto { get; set; }

    [ForeignKey("IdEmpresa, IdCliente")]
    [InverseProperty("FaOrdenDesp")]
    public virtual FaCliente FaCliente { get; set; } = null!;

    [InverseProperty("FaOrdenDesp")]
    public virtual ICollection<FaOrdenDespDet> FaOrdenDespDet { get; set; } = new List<FaOrdenDespDet>();

    [ForeignKey("IdEmpresa, IdVendedor")]
    [InverseProperty("FaOrdenDesp")]
    public virtual FaVendedor FaVendedor { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega")]
    [InverseProperty("FaOrdenDesp")]
    public virtual TbBodega TbBodega { get; set; } = null!;
}
