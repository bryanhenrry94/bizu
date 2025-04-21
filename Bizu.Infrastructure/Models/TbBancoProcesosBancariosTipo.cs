using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_banco_procesos_bancarios_tipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbBancoProcesosBancariosTipo
{
    [Key]
    [Column("IdProceso_bancario_tipo")]
    [StringLength(25)]
    public string IdProcesoBancarioTipo { get; set; } = null!;

    [Column("Iniciales_Archivo")]
    [StringLength(50)]
    public string InicialesArchivo { get; set; } = null!;

    [Column("nom_proceso_bancario")]
    [StringLength(150)]
    public string NomProcesoBancario { get; set; } = null!;

    [Column("Tipo_Proc")]
    [StringLength(10)]
    public string? TipoProc { get; set; }

    [InverseProperty("IdProcesoBancarioNavigation")]
    public virtual ICollection<BaArchivoTransferencia> BaArchivoTransferencia { get; set; } = new List<BaArchivoTransferencia>();

    [InverseProperty("IdProcesoBancarioNavigation")]
    public virtual ICollection<BaCbteBanDatosTransferencia> BaCbteBanDatosTransferencia { get; set; } = new List<BaCbteBanDatosTransferencia>();
}
