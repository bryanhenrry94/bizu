using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("in_Ing_Egr_Inven_estado_apro")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InIngEgrInvenEstadoApro
{
    [Key]
    [StringLength(15)]
    public string IdEstadoAproba { get; set; } = null!;

    [StringLength(25)]
    public string Descripcion { get; set; } = null!;

    [Column("estado")]
    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [InverseProperty("IdEstadoAprobaNavigation")]
    public virtual ICollection<InIngEgrInvenDet> InIngEgrInvenDet { get; set; } = new List<InIngEgrInvenDet>();

    [InverseProperty("IdEstadoAprobaXEgrNavigation")]
    public virtual ICollection<InParametro> InParametroIdEstadoAprobaXEgrNavigation { get; set; } = new List<InParametro>();

    [InverseProperty("IdEstadoAprobaXIngNavigation")]
    public virtual ICollection<InParametro> InParametroIdEstadoAprobaXIngNavigation { get; set; } = new List<InParametro>();
}
