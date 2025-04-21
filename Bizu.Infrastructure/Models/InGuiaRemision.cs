using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdGuiaRemision")]
[Table("in_GuiaRemision")]
[Index("IdEmpresa", "IdCentroCosto", Name = "FK_in_GuiaRemision_ct_centro_costo")]
[Index("IdEmpresa", "IdMotivo", Name = "FK_in_GuiaRemision_in_GuiaRemision_Motivo")]
[Index("IdEmpresa", "IdSucursal", "IdProyecto", Name = "FK_in_GuiaRemision_obr_Proyecto")]
[Index("IdEmpresa", "IdSucursal", "IdBodega", Name = "FK_in_GuiaRemision_tb_bodega")]
[Index("IdEmpresa", "IdSucursal", "IdGuiaRemision", "IdBodega", Name = "idx_IdEmpresa_IdSucursal_IdGuiaRemision_IdBodega")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class InGuiaRemision
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    [Precision(18, 0)]
    public decimal IdGuiaRemision { get; set; }

    public int? IdBodega { get; set; }

    public DateOnly FechaEmision { get; set; }

    public DateOnly FechaTrasladoIni { get; set; }

    public DateOnly FechaTrasladoFin { get; set; }

    [StringLength(3)]
    public string? Serie1 { get; set; }

    [StringLength(3)]
    public string? Serie2 { get; set; }

    [StringLength(10)]
    public string? NumDocumento { get; set; }

    [Column("IdTipo_Persona")]
    [StringLength(20)]
    public string IdTipoPersona { get; set; } = null!;

    [Precision(18, 0)]
    public decimal IdEntidad { get; set; }

    public int? IdProyecto { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [StringLength(300)]
    public string Origen { get; set; } = null!;

    [StringLength(300)]
    public string Destino { get; set; } = null!;

    [StringLength(300)]
    public string? Observacion { get; set; }

    public int IdMotivo { get; set; }

    [Column("IdEstado_cierre")]
    [StringLength(25)]
    public string? IdEstadoCierre { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [StringLength(20)]
    public string? IdUsuarioCreacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaCreacion { get; set; }

    [StringLength(20)]
    public string? IdUsuarioModificacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaModificacion { get; set; }

    [StringLength(20)]
    public string? IdUsuarioAnulacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAnulacion { get; set; }

    [StringLength(50)]
    public string? MotivoAnulacion { get; set; }

    [MaxLength(6)]
    public DateTime? FechaAutorizacion { get; set; }

    [StringLength(50)]
    public string? NumAutorizacion { get; set; }

    public int IdTransportista { get; set; }

    [StringLength(10)]
    public string? Placa { get; set; }

    [StringLength(50)]
    public string? Ruta { get; set; }

    [StringLength(100)]
    public string Correo { get; set; } = null!;

    [ForeignKey("IdEmpresa, IdCentroCosto")]
    [InverseProperty("InGuiaRemision")]
    public virtual CtCentroCosto? CtCentroCosto { get; set; }

    [InverseProperty("InGuiaRemision")]
    public virtual ICollection<InGuiaRemisionDet> InGuiaRemisionDet { get; set; } = new List<InGuiaRemisionDet>();

    [InverseProperty("InGuiaRemision")]
    public virtual InGuiaRemisionExportacion? InGuiaRemisionExportacion { get; set; }

    [ForeignKey("IdEmpresa, IdMotivo")]
    [InverseProperty("InGuiaRemision")]
    public virtual InGuiaRemisionMotivo InGuiaRemisionMotivo { get; set; } = null!;

    [InverseProperty("InGuiaRemision")]
    public virtual ICollection<InIngEgrInvenXInGuiaRemision> InIngEgrInvenXInGuiaRemision { get; set; } = new List<InIngEgrInvenXInGuiaRemision>();

    [ForeignKey("IdEmpresa, IdSucursal, IdBodega")]
    [InverseProperty("InGuiaRemision")]
    public virtual TbBodega? TbBodega { get; set; }
}
