using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinDevolucionInvenDetCantidadDevuelta
{
    public int IdEmpresa { get; set; }

    [Column("IdEmpresa_movi_inv")]
    public int IdEmpresaMoviInv { get; set; }

    [Column("IdSucursal_movi_inv")]
    public int IdSucursalMoviInv { get; set; }

    [Column("IdBodega_movi_inv")]
    public int IdBodegaMoviInv { get; set; }

    [Column("IdMovi_inven_tipo_movi_inv")]
    public int IdMoviInvenTipoMoviInv { get; set; }

    [Column("IdNumMovi_movi_inv")]
    [Precision(18, 0)]
    public decimal IdNumMoviMoviInv { get; set; }

    [Column("Secuencia_movi_inv")]
    public int SecuenciaMoviInv { get; set; }

    [Column("cantidad_devuelta")]
    public double? CantidadDevuelta { get; set; }
}
