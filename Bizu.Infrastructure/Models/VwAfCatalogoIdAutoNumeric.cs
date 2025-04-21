using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwAfCatalogoIdAutoNumeric
{
    [StringLength(4)]
    public string IdCatalogo { get; set; } = null!;

    [Column("observacion")]
    [StringLength(0)]
    public string Observacion { get; set; } = null!;
}
