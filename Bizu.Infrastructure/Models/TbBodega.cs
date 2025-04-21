using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[PrimaryKey("IdEmpresa", "IdSucursal", "IdBodega")]
[Table("tb_bodega")]
[Index("IdEmpresa", "IdCtaCtbleInve", Name = "FK_tb_bodega_ct_plancta")]
[Index("IdEmpresa", "IdCtaCtbleCosto", Name = "FK_tb_bodega_ct_plancta1")]
[Index("IdBodega", Name = "IX_tb_bodega_IdBodega")]
[Index("IdEmpresa", Name = "IX_tb_bodega_IdEmpresa")]
[Index("IdSucursal", Name = "IX_tb_bodega_IdSucursal")]
[Index("BoDescripcion", Name = "IX_tb_bodega_bo_Descripcion")]
[MySqlCollation("utf8mb4_unicode_ci")]
public partial class TbBodega
{
    [Key]
    public int IdEmpresa { get; set; }

    [Key]
    public int IdSucursal { get; set; }

    [Key]
    public int IdBodega { get; set; }

    [Column("cod_bodega")]
    [StringLength(50)]
    public string? CodBodega { get; set; }

    [Column("bo_Descripcion")]
    [StringLength(100)]
    public string BoDescripcion { get; set; } = null!;

    [Column("cod_punto_emision")]
    [StringLength(3)]
    public string? CodPuntoEmision { get; set; }

    [Column("bo_manejaFacturacion")]
    [StringLength(1)]
    public string? BoManejaFacturacion { get; set; }

    [Column("bo_EsBodega")]
    [StringLength(1)]
    public string? BoEsBodega { get; set; }

    [StringLength(20)]
    public string? IdUsuario { get; set; }

    [Column("Fecha_Transac")]
    [MaxLength(6)]
    public DateTime FechaTransac { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltMod { get; set; }

    [Column("Fecha_UltMod")]
    [MaxLength(6)]
    public DateTime? FechaUltMod { get; set; }

    [StringLength(20)]
    public string? IdUsuarioUltAnu { get; set; }

    [Column("Fecha_UltAnu")]
    [MaxLength(6)]
    public DateTime? FechaUltAnu { get; set; }

    [Column("nom_pc")]
    [StringLength(50)]
    public string? NomPc { get; set; }

    [Column("ip")]
    [StringLength(25)]
    public string? Ip { get; set; }

    [StringLength(1)]
    public string Estado { get; set; } = null!;

    [Column("IdEstadoAproba_x_Ing_Egr_Inven")]
    [StringLength(15)]
    public string? IdEstadoAprobaXIngEgrInven { get; set; }

    [StringLength(20)]
    public string? IdCentroCosto { get; set; }

    [Column("IdCtaCtble_Inve")]
    [StringLength(20)]
    public string? IdCtaCtbleInve { get; set; }

    [Column("IdCtaCtble_Costo")]
    [StringLength(20)]
    public string? IdCtaCtbleCosto { get; set; }

    [InverseProperty("TbBodega")]
    public virtual ICollection<ComDevCompra> ComDevCompra { get; set; } = new List<ComDevCompra>();

    [ForeignKey("IdEmpresa, IdCtaCtbleCosto")]
    [InverseProperty("TbBodegaCtPlancta")]
    public virtual CtPlancta? CtPlancta { get; set; }

    [ForeignKey("IdEmpresa, IdCtaCtbleInve")]
    [InverseProperty("TbBodegaCtPlanctaNavigation")]
    public virtual CtPlancta? CtPlanctaNavigation { get; set; }

    [InverseProperty("TbBodega")]
    public virtual ICollection<CxcParametrosXCheqProtesto> CxcParametrosXCheqProtesto { get; set; } = new List<CxcParametrosXCheqProtesto>();

    [InverseProperty("TbBodega")]
    public virtual ICollection<FaCotizacion> FaCotizacion { get; set; } = new List<FaCotizacion>();

    [InverseProperty("TbBodega")]
    public virtual ICollection<FaDevolVenta> FaDevolVenta { get; set; } = new List<FaDevolVenta>();

    [InverseProperty("TbBodega")]
    public virtual ICollection<FaFactura> FaFactura { get; set; } = new List<FaFactura>();

    [InverseProperty("TbBodega")]
    public virtual ICollection<FaGuiaRemision> FaGuiaRemision { get; set; } = new List<FaGuiaRemision>();

    [InverseProperty("TbBodega")]
    public virtual ICollection<FaNotaCreDeb> FaNotaCreDeb { get; set; } = new List<FaNotaCreDeb>();

    [InverseProperty("TbBodega")]
    public virtual ICollection<FaOrdenDesp> FaOrdenDesp { get; set; } = new List<FaOrdenDesp>();

    [InverseProperty("TbBodega")]
    public virtual ICollection<FaPedido> FaPedido { get; set; } = new List<FaPedido>();

    [InverseProperty("TbBodega")]
    public virtual ICollection<InAjusteFisico> InAjusteFisico { get; set; } = new List<InAjusteFisico>();

    [InverseProperty("TbBodega")]
    public virtual ICollection<InGuiaRemision> InGuiaRemision { get; set; } = new List<InGuiaRemision>();

    [InverseProperty("TbBodega")]
    public virtual ICollection<InIngEgrInvenDet> InIngEgrInvenDet { get; set; } = new List<InIngEgrInvenDet>();

    [InverseProperty("TbBodega")]
    public virtual ICollection<InIngEgrInvenXInRequerimientoMaterial> InIngEgrInvenXInRequerimientoMaterial { get; set; } = new List<InIngEgrInvenXInRequerimientoMaterial>();

    [InverseProperty("TbBodega")]
    public virtual ICollection<InKardex> InKardex { get; set; } = new List<InKardex>();

    [InverseProperty("TbBodega")]
    public virtual ICollection<InMoviInve> InMoviInve { get; set; } = new List<InMoviInve>();

    [InverseProperty("TbBodega")]
    public virtual ICollection<InMoviInvenTipoXTbBodega> InMoviInvenTipoXTbBodega { get; set; } = new List<InMoviInvenTipoXTbBodega>();

    [InverseProperty("TbBodega")]
    public virtual ICollection<InProductoXTbBodega> InProductoXTbBodega { get; set; } = new List<InProductoXTbBodega>();

    [InverseProperty("TbBodega")]
    public virtual ICollection<InTransferencia> InTransferencia { get; set; } = new List<InTransferencia>();

    [ForeignKey("IdEmpresa, IdSucursal")]
    [InverseProperty("TbBodega")]
    public virtual TbSucursal TbSucursal { get; set; } = null!;
}
