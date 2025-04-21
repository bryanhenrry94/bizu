using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_sis_reporte")]
[Index("Modulo", Name = "FK_tb_sis_reporte_tb_modulo")]
[Index("IdGrupoReporte", Name = "FK_tb_sis_reporte_tb_sis_reporte_Grupo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSisReporte
{
    [Key]
    [StringLength(50)]
    public string CodReporte { get; set; } = null!;

    [StringLength(150)]
    public string Nombre { get; set; } = null!;

    [StringLength(150)]
    public string NombreCorto { get; set; } = null!;

    [StringLength(20)]
    public string Modulo { get; set; } = null!;

    [StringLength(50)]
    public string VistaRpt { get; set; } = null!;

    [StringLength(50)]
    public string Formulario { get; set; } = null!;

    [Column("Class_NomReporte")]
    [StringLength(50)]
    public string? ClassNomReporte { get; set; }

    [Column("nom_Asembly")]
    [StringLength(50)]
    public string? NomAsembly { get; set; }

    public int Orden { get; set; }

    public string? Observacion { get; set; }

    [Column("imagen")]
    public byte[]? Imagen { get; set; }

    public int? VersionActual { get; set; }

    [Column("Tipo_Balance")]
    [StringLength(10)]
    public string? TipoBalance { get; set; }

    [Column("SQuery")]
    public string? Squery { get; set; }

    [Column("Class_Info")]
    [StringLength(50)]
    public string? ClassInfo { get; set; }

    [Column("Class_Bus")]
    [StringLength(50)]
    public string? ClassBus { get; set; }

    [Column("Class_Data")]
    [StringLength(50)]
    public string ClassData { get; set; } = null!;

    [Column("IdGrupo_Reporte")]
    public int? IdGrupoReporte { get; set; }

    [Column("se_Muestra_Admin_Reporte")]
    public bool? SeMuestraAdminReporte { get; set; }

    [StringLength(1)]
    public string? Estado { get; set; }

    [Column("Store_proce_rpt")]
    [StringLength(50)]
    public string? StoreProceRpt { get; set; }

    [Column("Disenio_reporte")]
    public byte[]? DisenioReporte { get; set; }

    [ForeignKey("IdGrupoReporte")]
    [InverseProperty("TbSisReporte")]
    public virtual TbSisReporteGrupo? IdGrupoReporteNavigation { get; set; }

    [ForeignKey("Modulo")]
    [InverseProperty("TbSisReporte")]
    public virtual TbModulo ModuloNavigation { get; set; } = null!;

    [InverseProperty("CodReporteNavigation")]
    public virtual ICollection<SegUsuarioXTbSisReporte> SegUsuarioXTbSisReporte { get; set; } = new List<SegUsuarioXTbSisReporte>();

    [InverseProperty("CodReporteNavigation")]
    public virtual ICollection<TbSisReporteXFormulario> TbSisReporteXFormulario { get; set; } = new List<TbSisReporteXFormulario>();
}
