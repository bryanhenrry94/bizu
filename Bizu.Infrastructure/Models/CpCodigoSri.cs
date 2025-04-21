using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("cp_codigo_SRI")]
[Index("IdTipoSri", Name = "FK_cp_codigo_SRI_cp_codigo_SRI_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpCodigoSri
{
    [Key]
    [Column("IdCodigo_SRI")]
    public int IdCodigoSri { get; set; }

    [Column("codigoSRI")]
    [StringLength(50)]
    public string CodigoSri { get; set; } = null!;

    [Column("co_codigoBase")]
    [StringLength(50)]
    public string CoCodigoBase { get; set; } = null!;

    [Column("co_descripcion")]
    [StringLength(350)]
    public string CoDescripcion { get; set; } = null!;

    [Column("co_porRetencion")]
    public double CoPorRetencion { get; set; }

    [Column("co_f_valides_desde")]
    public DateOnly CoFValidesDesde { get; set; }

    [Column("co_f_valides_hasta")]
    public DateOnly CoFValidesHasta { get; set; }

    [Column("co_estado")]
    [StringLength(1)]
    public string CoEstado { get; set; } = null!;

    [Column("IdTipoSRI")]
    [StringLength(20)]
    public string IdTipoSri { get; set; } = null!;

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
    [StringLength(50)]
    public string? Ip { get; set; }

    [StringLength(200)]
    public string? MotivoAnulacion { get; set; }

    [InverseProperty("IdCodigoSriNavigation")]
    public virtual ICollection<CpCodigoSriXCtaCble> CpCodigoSriXCtaCble { get; set; } = new List<CpCodigoSriXCtaCble>();

    [InverseProperty("IdCodIceNavigation")]
    public virtual ICollection<CpNotaDebCre> CpNotaDebCreIdCodIceNavigation { get; set; } = new List<CpNotaDebCre>();

    [InverseProperty("IdIdenCreditoNavigation")]
    public virtual ICollection<CpNotaDebCre> CpNotaDebCreIdIdenCreditoNavigation { get; set; } = new List<CpNotaDebCre>();

    [InverseProperty("IdCod101Navigation")]
    public virtual ICollection<CpOrdenGiro> CpOrdenGiroIdCod101Navigation { get; set; } = new List<CpOrdenGiro>();

    [InverseProperty("IdCodIceNavigation")]
    public virtual ICollection<CpOrdenGiro> CpOrdenGiroIdCodIceNavigation { get; set; } = new List<CpOrdenGiro>();

    [InverseProperty("IdIdenCreditoNavigation")]
    public virtual ICollection<CpOrdenGiro> CpOrdenGiroIdIdenCreditoNavigation { get; set; } = new List<CpOrdenGiro>();

    [InverseProperty("IdCodigoSriNavigation")]
    public virtual ICollection<CpProveedorCodigoSri> CpProveedorCodigoSri { get; set; } = new List<CpProveedorCodigoSri>();

    [InverseProperty("CodigoSri101PredeterNavigation")]
    public virtual ICollection<CpProveedor> CpProveedorCodigoSri101PredeterNavigation { get; set; } = new List<CpProveedor>();

    [InverseProperty("CodigoSriIcePredeterNavigation")]
    public virtual ICollection<CpProveedor> CpProveedorCodigoSriIcePredeterNavigation { get; set; } = new List<CpProveedor>();

    [InverseProperty("IdCreditoPredeterNavigation")]
    public virtual ICollection<CpProveedor> CpProveedorIdCreditoPredeterNavigation { get; set; } = new List<CpProveedor>();

    [InverseProperty("IdCodigoSriNavigation")]
    public virtual ICollection<CpRetencionDet> CpRetencionDet { get; set; } = new List<CpRetencionDet>();

    [ForeignKey("IdTipoSri")]
    [InverseProperty("CpCodigoSri")]
    public virtual CpCodigoSriTipo IdTipoSriNavigation { get; set; } = null!;

    [InverseProperty("IdCodigoSriNavigation")]
    public virtual ICollection<TbSisImpuesto> TbSisImpuesto { get; set; } = new List<TbSisImpuesto>();
}
