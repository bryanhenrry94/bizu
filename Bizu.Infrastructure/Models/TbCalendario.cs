using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_Calendario")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbCalendario
{
    [Key]
    public int IdCalendario { get; set; }

    [Column("fecha")]
    public DateOnly Fecha { get; set; }

    [StringLength(30)]
    public string NombreFecha { get; set; } = null!;

    [StringLength(10)]
    public string NombreCortoFecha { get; set; } = null!;

    [Column("dia_x_semana")]
    public int? DiaXSemana { get; set; }

    [Column("dia_x_mes")]
    public int? DiaXMes { get; set; }

    [Column("Inicial_del_Dia")]
    [StringLength(2)]
    public string? InicialDelDia { get; set; }

    [StringLength(20)]
    public string? NombreDia { get; set; }

    [Column("Mes_x_anio")]
    public int? MesXAnio { get; set; }

    [StringLength(30)]
    public string? NombreMes { get; set; }

    public int? IdMes { get; set; }

    [StringLength(15)]
    public string? NombreCortoMes { get; set; }

    public int? AnioFiscal { get; set; }

    [Column("Semana_x_anio")]
    public int? SemanaXAnio { get; set; }

    [StringLength(25)]
    public string? NombreSemana { get; set; }

    public int? IdSemana { get; set; }

    [Column("Trimestre_x_Anio")]
    public int? TrimestreXAnio { get; set; }

    [StringLength(20)]
    public string? NombreTrimestre { get; set; }

    public int? IdTrimestre { get; set; }

    [StringLength(20)]
    public string? IdPeriodo { get; set; }

    [StringLength(1)]
    public string? EsFeriado { get; set; }

    [StringLength(200)]
    public string? Descripcion { get; set; }
}
