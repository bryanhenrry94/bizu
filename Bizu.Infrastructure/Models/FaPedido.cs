using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdPedido")]
[Table("fa_pedido")]
[Index("IdEmpresa", "IdVendedor", Name = "FK_fa_pedido_fa_Vendedor")]
[Index("IdEmpresa", "IdCliente", Name = "FK_fa_pedido_fa_cliente")]
[Index("IdEstadoAprobacion", Name = "FK_fa_pedido_fa_pedido_estadoAprobacion")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaPedido
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdPedido { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public int IdVendedor { get; set; }

    [Column("cp_fecha")]
    [MaxLength(6)]
    public DateTime CpFecha { get; set; }

    [Column("cp_diasPlazo")]
    public int CpDiasPlazo { get; set; }

    [Column("cp_fechaVencimiento")]
    [MaxLength(6)]
    public DateTime CpFechaVencimiento { get; set; }

    [Column("cp_observacion")]
    [StringLength(1000)]
    public string CpObservacion { get; set; } = null!;

    [Column("cp_tipopago")]
    [StringLength(20)]
    public string CpTipopago { get; set; } = null!;

    [StringLength(1)]
    public string IdEstadoAprobacion { get; set; } = null!;

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

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("interes")]
    public double Interes { get; set; }

    [Column("transporte")]
    public double Transporte { get; set; }

    [Column("otro1")]
    public double Otro1 { get; set; }

    [Column("otro2")]
    public double Otro2 { get; set; }

    [StringLength(500)]
    public string? MotivoAnulacion { get; set; }

    [StringLength(20)]
    public string? CodPedido { get; set; }

    [StringLength(1)]
    public string? Entregado { get; set; }

    [StringLength(15)]
    public string? IdEstadoProduccion { get; set; }

    [ForeignKey("IdEmpresa, IdCliente")]
    [InverseProperty("FaPedido")]
    public virtual FaCliente FaCliente { get; set; } = null!;

    [InverseProperty("FaPedido")]
    public virtual ICollection<FaPedidoDet> FaPedidoDet { get; set; } = new List<FaPedidoDet>();

    [ForeignKey("IdEmpresa, IdVendedor")]
    [InverseProperty("FaPedido")]
    public virtual FaVendedor FaVendedor { get; set; } = null!;

    [ForeignKey("IdEstadoAprobacion")]
    [InverseProperty("FaPedido")]
    public virtual FaPedidoEstadoAprobacion IdEstadoAprobacionNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega")]
    [InverseProperty("FaPedido")]
    public virtual TbBodega TbBodega { get; set; } = null!;
}
