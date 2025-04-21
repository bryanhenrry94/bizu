using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresaGuia", "IdSucursalGuia", "IdBodegaGuia", "IdGuiaRemisionGuia", "SecuenciaGuia", "IdEmpresaFact", "IdSucursalFact", "IdBodegaFact", "IdCbteVtaFact", "SecuenciaFact")]
[Table("fa_guia_remision_det_x_fa_factura_det")]
[Index("IdEmpresaFact", "IdSucursalFact", "IdBodegaFact", "IdCbteVtaFact", "SecuenciaFact", Name = "FK_fa_guia_remision_det_x_fa_factura_det_fa_factura_det")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaGuiaRemisionDetXFaFacturaDet
{
    [Key]
    [Column("IdEmpresa_guia")]
    public int IdEmpresaGuia { get; set; }

    [Key]
    [Column("IdSucursal_guia")]
    public int IdSucursalGuia { get; set; }

    [Key]
    [Column("IdBodega_guia")]
    public int IdBodegaGuia { get; set; }

    [Key]
    [Column("IdGuiaRemision_guia")]
    [Precision(18, 0)]
    public decimal IdGuiaRemisionGuia { get; set; }

    [Key]
    [Column("Secuencia_guia")]
    public int SecuenciaGuia { get; set; }

    [Key]
    [Column("IdEmpresa_fact")]
    public int IdEmpresaFact { get; set; }

    [Key]
    [Column("IdSucursal_fact")]
    public int IdSucursalFact { get; set; }

    [Key]
    [Column("IdBodega_fact")]
    public int IdBodegaFact { get; set; }

    [Key]
    [Column("IdCbteVta_fact")]
    [Precision(18, 0)]
    public decimal IdCbteVtaFact { get; set; }

    [Key]
    [Column("Secuencia_fact")]
    public int SecuenciaFact { get; set; }

    [Column("observacion")]
    [StringLength(50)]
    public string? Observacion { get; set; }

    [ForeignKey("IdEmpresaFact, IdSucursalFact, IdBodegaFact, IdCbteVtaFact, SecuenciaFact")]
    [InverseProperty("FaGuiaRemisionDetXFaFacturaDet")]
    public virtual FaFacturaDet FaFacturaDet { get; set; } = null!;

    [ForeignKey("IdEmpresaGuia, IdSucursalGuia, IdBodegaGuia, IdGuiaRemisionGuia, SecuenciaGuia")]
    [InverseProperty("FaGuiaRemisionDetXFaFacturaDet")]
    public virtual FaGuiaRemisionDet FaGuiaRemisionDet { get; set; } = null!;
}
