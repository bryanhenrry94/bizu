using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "CodDocumentoTipo", "Establecimiento", "PuntoEmision", "NumDocumento")]
[Table("tb_sis_Documento_Tipo_Talonario")]
[Index("CodDocumentoTipo", Name = "FK_tb_sis_Documento_Tipo_Talonario_tb_sis_Documento_Tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSisDocumentoTipoTalonario
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [StringLength(20)]
    public string CodDocumentoTipo { get; set; } = null!;

    [Key]
    [StringLength(3)]
    public string Establecimiento { get; set; } = null!;

    [Key]
    [StringLength(3)]
    public string PuntoEmision { get; set; } = null!;

    [Key]
    [StringLength(20)]
    public string NumDocumento { get; set; } = null!;

    [MaxLength(6)]
    public DateTime? FechaCaducidad { get; set; }

    public bool? Usado { get; set; }

    [StringLength(1)]
    public string? Estado { get; set; }

    public int IdSucursal { get; set; }

    [StringLength(150)]
    public string? NumAutorizacion { get; set; }

    [Column("es_Documento_Electronico")]
    public bool? EsDocumentoElectronico { get; set; }

    [ForeignKey("CodDocumentoTipo")]
    [InverseProperty("TbSisDocumentoTipoTalonario")]
    public virtual TbSisDocumentoTipo CodDocumentoTipoNavigation { get; set; } = null!;

    [InverseProperty("TbSisDocumentoTipoTalonario")]
    public virtual ICollection<CpLiquidacionCompra> CpLiquidacionCompra { get; set; } = new List<CpLiquidacionCompra>();

    [InverseProperty("TbSisDocumentoTipoTalonario")]
    public virtual ICollection<CpRetencion> CpRetencion { get; set; } = new List<CpRetencion>();

    [InverseProperty("TbSisDocumentoTipoTalonario")]
    public virtual ICollection<FaFactura> FaFactura { get; set; } = new List<FaFactura>();

    [InverseProperty("TbSisDocumentoTipoTalonario")]
    public virtual ICollection<FaGuiaRemision> FaGuiaRemision { get; set; } = new List<FaGuiaRemision>();

    [InverseProperty("TbSisDocumentoTipoTalonario")]
    public virtual ICollection<InGuiaXTraspasoBodega> InGuiaXTraspasoBodega { get; set; } = new List<InGuiaXTraspasoBodega>();

    [ForeignKey("IdEmpresa, CodDocumentoTipo")]
    [InverseProperty("TbSisDocumentoTipoTalonario")]
    public virtual TbSisDocumentoTipoXEmpresa TbSisDocumentoTipoXEmpresa { get; set; } = null!;
}
