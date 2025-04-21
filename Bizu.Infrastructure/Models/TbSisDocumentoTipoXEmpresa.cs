using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "CodDocumentoTipo")]
[Table("tb_sis_Documento_Tipo_x_Empresa")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSisDocumentoTipoXEmpresa
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("codDocumentoTipo")]
    [StringLength(20)]
    public string CodDocumentoTipo { get; set; } = null!;

    [Column("ApareceComboFac_TipoFact")]
    [StringLength(1)]
    public string ApareceComboFacTipoFact { get; set; } = null!;

    [Column("ApareceComboFac_Import")]
    [StringLength(1)]
    public string ApareceComboFacImport { get; set; } = null!;

    [StringLength(1)]
    public string ApareceTalonario { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    public int Posicion { get; set; }

    [Column("ApareceCombo_FileReporte")]
    [StringLength(1)]
    public string ApareceComboFileReporte { get; set; } = null!;

    [ForeignKey("IdEmpresa")]
    [InverseProperty("TbSisDocumentoTipoXEmpresa")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;

    [InverseProperty("TbSisDocumentoTipoXEmpresa")]
    public virtual ICollection<TbSisDocumentoTipoTalonario> TbSisDocumentoTipoTalonario { get; set; } = new List<TbSisDocumentoTipoTalonario>();
}
