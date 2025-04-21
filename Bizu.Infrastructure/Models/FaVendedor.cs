using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdVendedor")]
[Table("fa_Vendedor")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaVendedor
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdVendedor { get; set; }

    [Precision(18, 0)]
    public decimal? IdEmpleado { get; set; }

    [StringLength(50)]
    public string? Codigo { get; set; }

    [Column("Ve_Vendedor")]
    [StringLength(200)]
    public string? VeVendedor { get; set; }

    [Column("ve_cedula")]
    [StringLength(20)]
    public string? VeCedula { get; set; }

    [Column("Ve_Comision")]
    public double VeComision { get; set; }

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

    [StringLength(200)]
    public string? MotivoAnula { get; set; }

    [InverseProperty("FaVendedor")]
    public virtual ICollection<FaCotizacion> FaCotizacion { get; set; } = new List<FaCotizacion>();

    [InverseProperty("FaVendedor")]
    public virtual ICollection<FaDevolVenta> FaDevolVenta { get; set; } = new List<FaDevolVenta>();

    [InverseProperty("FaVendedor")]
    public virtual ICollection<FaFactura> FaFactura { get; set; } = new List<FaFactura>();

    [InverseProperty("FaVendedor")]
    public virtual ICollection<FaGuiaRemision> FaGuiaRemision { get; set; } = new List<FaGuiaRemision>();

    [InverseProperty("FaVendedor")]
    public virtual ICollection<FaNotaCreDeb> FaNotaCreDeb { get; set; } = new List<FaNotaCreDeb>();

    [InverseProperty("FaVendedor")]
    public virtual ICollection<FaOrdenDesp> FaOrdenDesp { get; set; } = new List<FaOrdenDesp>();

    [InverseProperty("FaVendedor")]
    public virtual ICollection<FaPedido> FaPedido { get; set; } = new List<FaPedido>();

    [InverseProperty("FaVendedor")]
    public virtual ICollection<FaVendedorXRoEmpleado> FaVendedorXRoEmpleado { get; set; } = new List<FaVendedorXRoEmpleado>();

    [InverseProperty("FaVendedor")]
    public virtual ICollection<FaVendedorxSucursal> FaVendedorxSucursal { get; set; } = new List<FaVendedorxSucursal>();

    [ForeignKey("IdEmpresa")]
    [InverseProperty("FaVendedor")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;
}
