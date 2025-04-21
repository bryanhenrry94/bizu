using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwcomOrdencompraLocalVsInGuiaXTraspasoBodegaTotalReg
{
    public int IdEmpresa { get; set; }

    public int IdSucursal { get; set; }

    [Precision(18, 0)]
    public decimal IdOrdenCompra { get; set; }

    [Column("Total_reg_x_OC")]
    public long TotalRegXOc { get; set; }

    [Column("Total_reg_x_Guia")]
    public long TotalRegXGuia { get; set; }
}
