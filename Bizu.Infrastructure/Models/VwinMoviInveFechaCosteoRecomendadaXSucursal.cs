using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwinMoviInveFechaCosteoRecomendadaXSucursal
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Column("fecha_sin_costear")]
    [MaxLength(6)]
    public DateTime? FechaSinCostear { get; set; }

    public long Costeado { get; set; }
}
