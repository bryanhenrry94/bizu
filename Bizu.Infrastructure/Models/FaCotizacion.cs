using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdCotizacion")]
[Table("fa_cotizacion")]
[Index("IdEmpresa", "IdVendedor", Name = "FK_fa_cotizacion_fa_Vendedor")]
[Index("IdEmpresa", "IdCliente", Name = "FK_fa_cotizacion_fa_cliente")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaCotizacion
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCotizacion { get; set; }

    [StringLength(20)]
    public string CodCotizacion { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    public int IdVendedor { get; set; }

    [Column("cc_fecha")]
    [MaxLength(6)]
    public DateTime CcFecha { get; set; }

    [Column("cc_diasPlazo")]
    public short CcDiasPlazo { get; set; }

    [Column("cc_fechaVencimiento")]
    [MaxLength(6)]
    public DateTime CcFechaVencimiento { get; set; }

    [Column("cc_observacion")]
    [StringLength(1000)]
    public string CcObservacion { get; set; } = null!;

    [Column("cc_tipopago")]
    [StringLength(3)]
    public string CcTipopago { get; set; } = null!;

    [Column("cc_estado")]
    [StringLength(1)]
    public string CcEstado { get; set; } = null!;

    [Column("cc_dirigidoA")]
    [StringLength(200)]
    public string CcDirigidoA { get; set; } = null!;

    [Column("cc_transporte")]
    public double CcTransporte { get; set; }

    [Column("cc_interes")]
    public double CcInteres { get; set; }

    [Column("cc_otroValor1")]
    public double CcOtroValor1 { get; set; }

    [Column("cc_otroValor2")]
    public double CcOtroValor2 { get; set; }

    [StringLength(50)]
    public string IdUsuario { get; set; } = null!;

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

    [StringLength(150)]
    public string? MotivoAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string NomPc { get; set; } = null!;

    [Column("ip")]
    [StringLength(25)]
    public string Ip { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCliente")]
    [InverseProperty("FaCotizacion")]
    public virtual FaCliente FaCliente { get; set; } = null!;

    [InverseProperty("FaCotizacion")]
    public virtual ICollection<FaCotizacionDet> FaCotizacionDet { get; set; } = new List<FaCotizacionDet>();

    [InverseProperty("FaCotizacion")]
    public virtual ICollection<FaFacturaXFaCotizacion> FaFacturaXFaCotizacion { get; set; } = new List<FaFacturaXFaCotizacion>();

    [ForeignKey("IdEmpresa, IdVendedor")]
    [InverseProperty("FaCotizacion")]
    public virtual FaVendedor FaVendedor { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega")]
    [InverseProperty("FaCotizacion")]
    public virtual TbBodega TbBodega { get; set; } = null!;
}
