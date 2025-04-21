using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresaProv", "IdProveedor", "IdEmpresaCont", "IdContacto")]
[Table("cp_proveedor_contactos")]
[Index("IdEmpresaCont", "IdContacto", Name = "FK_cp_proveedor_contactos_tb_contacto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class CpProveedorContactos
{
    [Key]
    [Column("IdEmpresa_prov")]
    public int IdEmpresaProv { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdProveedor { get; set; }

    [Key]
    [Column("IdEmpresa_cont")]
    public int IdEmpresaCont { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdContacto { get; set; }

    [Column("observacion")]
    [StringLength(50)]
    public string Observacion { get; set; } = null!;

    [ForeignKey("IdEmpresaProv, IdProveedor")]
    [InverseProperty("CpProveedorContactos")]
    public virtual CpProveedor CpProveedor { get; set; } = null!;

    [ForeignKey("IdEmpresaCont, IdContacto")]
    [InverseProperty("CpProveedorContactos")]
    public virtual TbContacto TbContacto { get; set; } = null!;
}
