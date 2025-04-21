using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("tb_Actividades_Horario")]
[Index("IdTipoEjecucion", Name = "FK_tb_Actividades_Horario_tb_Actividades_Horario_Tipo_Ejecucion")]
[Index("IdTipoTiempo", Name = "FK_tb_Actividades_Horario_tb_Actividades_Horario_Tipo_Tiempo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbActividadesHorario
{
    [Key]
    [StringLength(20)]
    public string IdTransaccion { get; set; } = null!;

    [StringLength(20)]
    public string IdTipoEjecucion { get; set; } = null!;

    [Column("Num_cbtes_x_pagina")]
    public int NumCbtesXPagina { get; set; }

    [Column("lunes")]
    public bool Lunes { get; set; }

    [Column("martes")]
    public bool Martes { get; set; }

    [Column("miercoles")]
    public bool Miercoles { get; set; }

    [Column("jueves")]
    public bool Jueves { get; set; }

    [Column("viernes")]
    public bool Viernes { get; set; }

    [Column("sabado")]
    public bool Sabado { get; set; }

    [Column("domingo")]
    public bool Domingo { get; set; }

    [Column("ocurre_1_vez")]
    public bool Ocurre1Vez { get; set; }

    [Column("valor_ocurre_1_vez")]
    [MaxLength(6)]
    public TimeOnly ValorOcurre1Vez { get; set; }

    [Column("ocurre_cada")]
    public bool OcurreCada { get; set; }

    [Column("valor_ocurre_cada")]
    public int ValorOcurreCada { get; set; }

    [StringLength(20)]
    public string IdTipoTiempo { get; set; } = null!;

    [Column("hora_inicia_a_las")]
    [MaxLength(6)]
    public TimeOnly HoraIniciaALas { get; set; }

    [Column("hora_finaliza_a_las")]
    [MaxLength(6)]
    public TimeOnly HoraFinalizaALas { get; set; }

    [ForeignKey("IdTipoEjecucion")]
    [InverseProperty("TbActividadesHorario")]
    public virtual TbActividadesHorarioTipoEjecucion IdTipoEjecucionNavigation { get; set; } = null!;

    [ForeignKey("IdTipoTiempo")]
    [InverseProperty("TbActividadesHorario")]
    public virtual TbActividadesHorarioTipoTiempo IdTipoTiempoNavigation { get; set; } = null!;

    [InverseProperty("IdTransaccionNavigation")]
    public virtual ICollection<TbActividadesHorarioAcciones> TbActividadesHorarioAcciones { get; set; } = new List<TbActividadesHorarioAcciones>();
}
