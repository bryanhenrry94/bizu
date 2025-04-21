using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_sis_Impuesto")]
[Index("IdCodigoSri", Name = "FK_tb_sis_Impuesto_cp_codigo_SRI")]
[Index("IdTipoImpuesto", Name = "FK_tb_sis_Impuesto_tb_sis_Impuesto_Tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSisImpuesto
{
    [Key]
    [Column("IdCod_Impuesto")]
    [StringLength(25)]
    public string IdCodImpuesto { get; set; } = null!;

    [Column("nom_impuesto")]
    [StringLength(50)]
    public string NomImpuesto { get; set; } = null!;

    [Column("Usado_en_Ventas")]
    public bool UsadoEnVentas { get; set; }

    [Column("Usado_en_Compras")]
    public bool UsadoEnCompras { get; set; }

    [Column("porcentaje")]
    public double Porcentaje { get; set; }

    [Column("IdCodigo_SRI")]
    public int? IdCodigoSri { get; set; }

    [Column("estado")]
    public bool Estado { get; set; }

    [StringLength(50)]
    public string IdTipoImpuesto { get; set; } = null!;

    [InverseProperty("IdCodImpuestoNavigation")]
    public virtual ICollection<ComOrdencompraLocalDet> ComOrdencompraLocalDet { get; set; } = new List<ComOrdencompraLocalDet>();

    [InverseProperty("IdCodImpuestoIvaNavigation")]
    public virtual ICollection<ComSolicitudCompraDetAprobacion> ComSolicitudCompraDetAprobacion { get; set; } = new List<ComSolicitudCompraDetAprobacion>();

    [InverseProperty("IdCodImpuestoIvaNavigation")]
    public virtual ICollection<CpLiquidacionCompraDet> CpLiquidacionCompraDet { get; set; } = new List<CpLiquidacionCompraDet>();

    [InverseProperty("IdCodImpuestoIceNavigation")]
    public virtual ICollection<FaFacturaDet> FaFacturaDetIdCodImpuestoIceNavigation { get; set; } = new List<FaFacturaDet>();

    [InverseProperty("IdCodImpuestoIvaNavigation")]
    public virtual ICollection<FaFacturaDet> FaFacturaDetIdCodImpuestoIvaNavigation { get; set; } = new List<FaFacturaDet>();

    [InverseProperty("IdCodImpuestoIceNavigation")]
    public virtual ICollection<FaNotaCreDebDet> FaNotaCreDebDetIdCodImpuestoIceNavigation { get; set; } = new List<FaNotaCreDebDet>();

    [InverseProperty("IdCodImpuestoIvaNavigation")]
    public virtual ICollection<FaNotaCreDebDet> FaNotaCreDebDetIdCodImpuestoIvaNavigation { get; set; } = new List<FaNotaCreDebDet>();

    [ForeignKey("IdCodigoSri")]
    [InverseProperty("TbSisImpuesto")]
    public virtual CpCodigoSri? IdCodigoSriNavigation { get; set; }

    [ForeignKey("IdTipoImpuesto")]
    [InverseProperty("TbSisImpuesto")]
    public virtual TbSisImpuestoTipo IdTipoImpuestoNavigation { get; set; } = null!;

    [InverseProperty("IdCodImpuestoNavigation")]
    public virtual ICollection<TbSisImpuestoXCtacble> TbSisImpuestoXCtacble { get; set; } = new List<TbSisImpuestoXCtacble>();
}
