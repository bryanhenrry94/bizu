using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresaCli", "IdCliente", "IdEmpresaCont", "IdContacto")]
[Table("fa_cliente_contactos")]
[Index("IdEmpresaCont", "IdContacto", Name = "FK_fa_cliente_contactos_tb_contacto")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class FaClienteContactos
{
    [Key]
    [Column("IdEmpresa_cli")]
    public int IdEmpresaCli { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdCliente { get; set; }

    [Key]
    [Column("IdEmpresa_cont")]
    public int IdEmpresaCont { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdContacto { get; set; }

    [Column("observacion")]
    [StringLength(150)]
    public string Observacion { get; set; } = null!;

    [ForeignKey("IdEmpresaCli, IdCliente")]
    [InverseProperty("FaClienteContactos")]
    public virtual FaCliente FaCliente { get; set; } = null!;

    [ForeignKey("IdEmpresaCont, IdContacto")]
    [InverseProperty("FaClienteContactos")]
    public virtual TbContacto TbContacto { get; set; } = null!;
}
