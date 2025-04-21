using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega", "IdCbteVtaNota", "DcTipoDocumento")]
[Table("cxc_CXC_Rpt017")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CxcCxcRpt017
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Key]
    [Column("IdCbte_vta_nota")]
    [Precision(18, 0)]
    public decimal IdCbteVtaNota { get; set; }

    [Key]
    [Column("dc_TipoDocumento")]
    [StringLength(20)]
    public string DcTipoDocumento { get; set; } = null!;

    [Column("vt_total")]
    public double VtTotal { get; set; }

    [Column("dc_ValorPago")]
    public double DcValorPago { get; set; }

    public double Saldo { get; set; }

    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Precision(18, 0)]
    public decimal IdPersona { get; set; }

    [Column("nom_Cliente")]
    [StringLength(200)]
    public string NomCliente { get; set; } = null!;

    [Column("pe_cedulaRuc")]
    [StringLength(13)]
    public string PeCedulaRuc { get; set; } = null!;

    [StringLength(4)]
    public string? IdProvincia { get; set; }

    [StringLength(4)]
    public string? IdCiudad { get; set; }

    [StringLength(4)]
    public string? IdParroquia { get; set; }

    [Column("pe_Naturaleza")]
    [StringLength(2)]
    public string PeNaturaleza { get; set; } = null!;

    [Column("vt_NumFactura")]
    [StringLength(50)]
    public string VtNumFactura { get; set; } = null!;

    [Column("vt_fecha")]
    [MaxLength(6)]
    public DateTime VtFecha { get; set; }

    [Column("vt_fech_venc")]
    [MaxLength(6)]
    public DateTime VtFechVenc { get; set; }

    [Column("ValorPago_mes")]
    public double ValorPagoMes { get; set; }
}
