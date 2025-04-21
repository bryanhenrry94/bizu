using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_sis_formulario")]
[Index("CodModulo", Name = "FK_tb_sis_formulario_tb_modulo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSisFormulario
{
    [Key]
    [StringLength(250)]
    public string IdFormulario { get; set; } = null!;

    [Column("cod_Formulario")]
    [StringLength(250)]
    public string CodFormulario { get; set; } = null!;

    [Column("nom_Formulario")]
    [StringLength(250)]
    public string NomFormulario { get; set; } = null!;

    [StringLength(20)]
    public string CodModulo { get; set; } = null!;

    [StringLength(50)]
    public string Text { get; set; } = null!;

    [Column("observacion")]
    [StringLength(550)]
    public string Observacion { get; set; } = null!;

    [Column("estado")]
    public bool Estado { get; set; }

    [Column("nom_Asembly")]
    [StringLength(250)]
    public string NomAsembly { get; set; } = null!;

    [ForeignKey("CodModulo")]
    [InverseProperty("TbSisFormulario")]
    public virtual TbModulo CodModuloNavigation { get; set; } = null!;

    [InverseProperty("IdFormularioNavigation")]
    public virtual ICollection<TbSisReporteXFormulario> TbSisReporteXFormulario { get; set; } = new List<TbSisReporteXFormulario>();
}
