using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "CodDocumentoTipo", "Secuencia")]
[Table("tb_sis_Documento_Tipo_x_Secuencia_Talonario")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbSisDocumentoTipoXSecuenciaTalonario
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [StringLength(20)]
    public string CodDocumentoTipo { get; set; } = null!;

    [Key]
    public int Secuencia { get; set; }

    [StringLength(5)]
    public string Serie1 { get; set; } = null!;

    [StringLength(5)]
    public string Serie2 { get; set; } = null!;

    [MaxLength(6)]
    public DateTime FechaCaducidad { get; set; }

    [Column("NAutorizacion")]
    [StringLength(50)]
    public string Nautorizacion { get; set; } = null!;

    [StringLength(50)]
    public string DocInicial { get; set; } = null!;

    [StringLength(50)]
    public string DocFinal { get; set; } = null!;

    [StringLength(50)]
    public string DocActual { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;
}
