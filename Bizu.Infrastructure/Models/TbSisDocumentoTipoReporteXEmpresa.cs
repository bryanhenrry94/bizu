using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "CodDocumentoTipo")]
[Table("tb_sis_Documento_Tipo_Reporte_x_Empresa")]
[Index("CodDocumentoTipo", Name = "FK_tb_sis_Documento_Tipo_Reporte_x_Empresa_tb_sis_Documento_Tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSisDocumentoTipoReporteXEmpresa
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("codDocumentoTipo")]
    [StringLength(20)]
    public string CodDocumentoTipo { get; set; } = null!;

    [Column("File_Disenio_Reporte")]
    public byte[]? FileDisenioReporte { get; set; }

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

    [StringLength(100)]
    public string? MotivoAnula { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [ForeignKey("CodDocumentoTipo")]
    [InverseProperty("TbSisDocumentoTipoReporteXEmpresa")]
    public virtual TbSisDocumentoTipo CodDocumentoTipoNavigation { get; set; } = null!;
}
