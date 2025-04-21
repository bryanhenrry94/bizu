using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("in_Catalogo")]
[Index("IdCatalogoTipo", Name = "FK_in_Catalogo_in_CatalogoTipo")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InCatalogo
{
    [Key]
    [StringLength(15)]
    public string IdCatalogo { get; set; } = null!;

    [Column("IdCatalogo_tipo")]
    public int IdCatalogoTipo { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(10)]
    public string? Abrebiatura { get; set; }

    [StringLength(50)]
    public string? NombreIngles { get; set; }

    public int? Orden { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [ForeignKey("IdCatalogoTipo")]
    [InverseProperty("InCatalogo")]
    public virtual InCatalogoTipo IdCatalogoTipoNavigation { get; set; } = null!;

    [InverseProperty("IdEstadoAprobacionNavigation")]
    public virtual ICollection<InAjusteFisico> InAjusteFisico { get; set; } = new List<InAjusteFisico>();

    [InverseProperty("IdMotivoTrasladoNavigation")]
    public virtual ICollection<InGuiaXTraspasoBodega> InGuiaXTraspasoBodega { get; set; } = new List<InGuiaXTraspasoBodega>();

    [InverseProperty("EsInvenOConsumoNavigation")]
    public virtual ICollection<InMotivoInven> InMotivoInvenEsInvenOConsumoNavigation { get; set; } = new List<InMotivoInven>();

    [InverseProperty("TipoIngEgrNavigation")]
    public virtual ICollection<InMotivoInven> InMotivoInvenTipoIngEgrNavigation { get; set; } = new List<InMotivoInven>();

    [InverseProperty("IdEstadoDespachoCatNavigation")]
    public virtual ICollection<InMoviInve> InMoviInve { get; set; } = new List<InMoviInve>();

    [InverseProperty("PAlContaCtaCostoBuscarEnNavigation")]
    public virtual ICollection<InParametro> InParametroPAlContaCtaCostoBuscarEnNavigation { get; set; } = new List<InParametro>();

    [InverseProperty("PAlContaCtaInvenBuscarEnNavigation")]
    public virtual ICollection<InParametro> InParametroPAlContaCtaInvenBuscarEnNavigation { get; set; } = new List<InParametro>();

    [InverseProperty("IdEstadoAprobacionCatNavigation")]
    public virtual ICollection<InTransferencia> InTransferencia { get; set; } = new List<InTransferencia>();
}
