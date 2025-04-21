using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_modulo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbModulo
{
    [Key]
    [StringLength(20)]
    public string CodModulo { get; set; } = null!;

    [StringLength(50)]
    public string Descripcion { get; set; } = null!;

    [Column("Nom_Carpeta")]
    [StringLength(50)]
    public string? NomCarpeta { get; set; }

    [Column("Se_Cierra")]
    public bool? SeCierra { get; set; }

    [InverseProperty("CodModuloNavigation")]
    public virtual ICollection<CpOrdenPagoFormapago> CpOrdenPagoFormapago { get; set; } = new List<CpOrdenPagoFormapago>();

    [InverseProperty("IdModuloNavigation")]
    public virtual ICollection<CtPeriodoXTbModulo> CtPeriodoXTbModulo { get; set; } = new List<CtPeriodoXTbModulo>();

    [InverseProperty("CodModuloNavigation")]
    public virtual ICollection<TbSisFormulario> TbSisFormulario { get; set; } = new List<TbSisFormulario>();

    [InverseProperty("ModuloNavigation")]
    public virtual ICollection<TbSisReporte> TbSisReporte { get; set; } = new List<TbSisReporte>();
}
