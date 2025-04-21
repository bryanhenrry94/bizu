using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Table("ba_parametros")]
[Index("CiudadDefaultParaCrearCheques", Name = "FK_ba_parametros_tb_ciudad")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class BaParametros
{
    [Key]
    public int IdEmpresa { get; set; }

    [Column("El_Diario_Contable_es_modificable")]
    public bool ElDiarioContableEsModificable { get; set; }

    [StringLength(25)]
    public string? CiudadDefaultParaCrearCheques { get; set; }

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

    [Column("IdTipoCbte_x_Prestamo")]
    public int? IdTipoCbteXPrestamo { get; set; }

    [Column("IdTipoNota_ND_Can_Cuotas")]
    public int? IdTipoNotaNdCanCuotas { get; set; }

    [Column("Ruta_descarga_fila_x_PreAviso_cheq")]
    [StringLength(200)]
    public string? RutaDescargaFilaXPreAvisoCheq { get; set; }

    [Column("IdCtaCble_Interes")]
    [StringLength(20)]
    public string? IdCtaCbleInteres { get; set; }

    [Column("IdCtaCble_prestamos")]
    [StringLength(20)]
    public string? IdCtaCblePrestamos { get; set; }

    [Column("pa_notificacion_cheque")]
    public bool? PaNotificacionCheque { get; set; }

    [Column("pa_notificacion_cheque_auto")]
    public bool? PaNotificacionChequeAuto { get; set; }

    [ForeignKey("CiudadDefaultParaCrearCheques")]
    [InverseProperty("BaParametros")]
    public virtual TbCiudad? CiudadDefaultParaCrearChequesNavigation { get; set; }

    [ForeignKey("IdEmpresa")]
    [InverseProperty("BaParametros")]
    public virtual TbEmpresa IdEmpresaNavigation { get; set; } = null!;
}
