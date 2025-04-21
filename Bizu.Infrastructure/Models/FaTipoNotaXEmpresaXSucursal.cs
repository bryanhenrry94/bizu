using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdTipoNota")]
[Table("fa_TipoNota_x_Empresa_x_Sucursal")]
[Index("IdEmpresa", "IdCtaCble", Name = "FK_fa_TipoNota_x_Empresa_x_Sucursal_ct_plancta")]
[Index("IdTipoNota", Name = "FK_fa_TipoNota_x_Empresa_x_Sucursal_fa_TipoNota")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaTipoNotaXEmpresaXSucursal
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdTipoNota { get; set; }

    [StringLength(20)]
    public string? IdCtaCble { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCble")]
    [InverseProperty("FaTipoNotaXEmpresaXSucursal")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdTipoNota")]
    [InverseProperty("FaTipoNotaXEmpresaXSucursal")]
    public virtual FaTipoNota IdTipoNotaNavigation { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdSucursal")]
    [InverseProperty("FaTipoNotaXEmpresaXSucursal")]
    public virtual TbSucursal TbSucursal { get; set; } = null!;
}
