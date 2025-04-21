using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdBanco")]
[Table("ba_Config_Diseno_Cheque")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaConfigDisenoCheque
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdBanco { get; set; }

    [Column("Tama_Cheque_X")]
    public int TamaChequeX { get; set; }

    [Column("Tama_Cheque_Y")]
    public int TamaChequeY { get; set; }

    [Column("Area_Imprimir_X")]
    public int AreaImprimirX { get; set; }

    [Column("Area_Imprimir_Y")]
    public int AreaImprimirY { get; set; }

    [Column("PagueseA_X")]
    public int PagueseAX { get; set; }

    [Column("PagueseA_Y")]
    public int PagueseAY { get; set; }

    [Column("ValorCheque_X")]
    public int ValorChequeX { get; set; }

    [Column("ValorCheque_Y")]
    public int ValorChequeY { get; set; }

    [Column("ValorLetra_Cheque_X")]
    public int ValorLetraChequeX { get; set; }

    [Column("ValorLetra_Cheque_Y")]
    public int ValorLetraChequeY { get; set; }

    [Column("Fecha_X")]
    public int FechaX { get; set; }

    [Column("Fecha_Y")]
    public int FechaY { get; set; }

    [Column("Nom_Impresora")]
    [StringLength(50)]
    public string? NomImpresora { get; set; }

    [Column("Pto_Impresora")]
    [StringLength(50)]
    public string? PtoImpresora { get; set; }

    [ForeignKey("IdEmpresa, IdBanco")]
    [InverseProperty("BaConfigDisenoCheque")]
    public virtual BaBancoCuenta BaBancoCuenta { get; set; } = null!;
}
