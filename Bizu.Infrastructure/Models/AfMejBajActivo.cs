using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdMejoraBajaActivo", "IdTipo")]
[Table("Af_Mej_Baj_Activo")]
[Index("IdEmpresa", "IdActivoFijo", Name = "FK_Af_Mej_Baj_Activo_Af_Activo_fijo")]
[Index("IdEmpresa", "IdProveedor", Name = "FK_Af_Mej_Baj_Activo_cp_proveedor")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class AfMejBajActivo
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    [Column("Id_Mejora_Baja_Activo")]
    [Precision(18, 0)]
    public decimal IdMejoraBajaActivo { get; set; }

    [Key]
    [Column("Id_Tipo")]
    [StringLength(20)]
    public string IdTipo { get; set; } = null!;

    public int IdActivoFijo { get; set; }

    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Column("Cod_Mej_Baj_Activo")]
    [StringLength(20)]
    public string CodMejBajActivo { get; set; } = null!;

    public double? ValorActivo { get; set; }

    [Column("Valor_Mej_Baj_Activo")]
    public double? ValorMejBajActivo { get; set; }

    [Column("Compr_Mej_Baj")]
    [StringLength(50)]
    public string? ComprMejBaj { get; set; }

    [StringLength(500)]
    public string? DescripcionTecnica { get; set; }

    [StringLength(500)]
    public string? Motivo { get; set; }

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

    [StringLength(1)]
    public string? Estado { get; set; }

    [Column("IdPeriodo_Inicio_Depr")]
    public int? IdPeriodoInicioDepr { get; set; }

    [MaxLength(6)]
    public DateTime? FechaPeriodo { get; set; }

    [Column("NumIniDep_IniMej")]
    public int? NumIniDepIniMej { get; set; }

    [ForeignKey("IdEmpresa, IdActivoFijo")]
    [InverseProperty("AfMejBajActivo")]
    public virtual AfActivoFijo AfActivoFijo { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdProveedor")]
    [InverseProperty("AfMejBajActivo")]
    public virtual CpProveedor CpProveedor { get; set; } = null!;
}
