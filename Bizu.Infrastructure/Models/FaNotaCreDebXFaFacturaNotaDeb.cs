using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresaNt", "IdSucursalNt", "IdBodegaNt", "IdNotaNt", "Secuencia")]
[Table("fa_notaCreDeb_x_fa_factura_NotaDeb")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaNotaCreDebXFaFacturaNotaDeb
{
    [Key]
    [Column("IdEmpresa_nt")]
    public int IdEmpresaNt { get; set; }

    [Key]
    [Column("IdSucursal_nt")]
    public int IdSucursalNt { get; set; }

    [Key]
    [Column("IdBodega_nt")]
    public int IdBodegaNt { get; set; }

    [Key]
    [Column("IdNota_nt")]
    [Precision(18, 0)]
    public decimal IdNotaNt { get; set; }

    [Key]
    [Column("secuencia")]
    public int Secuencia { get; set; }

    [Column("IdEmpresa_fac_nd_doc_mod")]
    public int IdEmpresaFacNdDocMod { get; set; }

    [Column("IdSucursal_fac_nd_doc_mod")]
    public int IdSucursalFacNdDocMod { get; set; }

    [Column("IdBodega_fac_nd_doc_mod")]
    public int IdBodegaFacNdDocMod { get; set; }

    [Column("IdCbteVta_fac_nd_doc_mod")]
    [Precision(18, 0)]
    public decimal IdCbteVtaFacNdDocMod { get; set; }

    [Column("vt_tipoDoc")]
    [StringLength(20)]
    public string VtTipoDoc { get; set; } = null!;

    [Column("Valor_Aplicado")]
    public double ValorAplicado { get; set; }

    [Column("fecha_cruce")]
    public DateOnly FechaCruce { get; set; }
}
