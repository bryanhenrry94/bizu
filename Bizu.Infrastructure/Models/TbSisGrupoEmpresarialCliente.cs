using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_sis_Grupo_empresarial_Cliente")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSisGrupoEmpresarialCliente
{
    [Key]
    [Column("IdGrupo_Empresarial_cliente")]
    [StringLength(50)]
    public string IdGrupoEmpresarialCliente { get; set; } = null!;

    [Column("descripcion")]
    [StringLength(500)]
    public string Descripcion { get; set; } = null!;
}
