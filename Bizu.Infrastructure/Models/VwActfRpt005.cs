using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bizu.Infrastructure.Models;

[Keyless]
public partial class VwActfRpt005
{
    public int IdEmpresa { get; set; }

    public int IdActivoFijo { get; set; }

    [Column("Af_Codigo_Barra")]
    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? AfCodigoBarra { get; set; }

    public int IdTipoDepreciacion { get; set; }

    [Column("cod_tipo_depreciacion")]
    [StringLength(20)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? CodTipoDepreciacion { get; set; }

    [Column("nom_tipo_depreciacion")]
    [StringLength(150)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? NomTipoDepreciacion { get; set; }

    [Column("Af_Nombre")]
    [StringLength(500)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string AfNombre { get; set; } = null!;

    public int? IdDepartamento { get; set; }

    public int IdSucursal { get; set; }

    [Column("Su_Descripcion")]
    [StringLength(60)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string SuDescripcion { get; set; } = null!;

    [Column("Af_fecha_compra")]
    [MaxLength(6)]
    public DateTime AfFechaCompra { get; set; }

    [Column("Af_costo_compra")]
    public double AfCostoCompra { get; set; }

    [Column("Estado_Proceso")]
    [StringLength(35)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string? EstadoProceso { get; set; }

    [Precision(18, 0)]
    public decimal IdDepreciacion { get; set; }

    public int Secuencia { get; set; }

    public int Ciclo { get; set; }

    [Column("Valor_Compra")]
    public double ValorCompra { get; set; }

    [Column("Valor_Salvamento")]
    public double ValorSalvamento { get; set; }

    [Column("Vida_Util")]
    public int VidaUtil { get; set; }

    [Column("Valor_Depreciacion")]
    public double ValorDepreciacion { get; set; }

    [Column("Valor_Depre_Acum")]
    public double ValorDepreAcum { get; set; }

    [Column("Valor_Importe")]
    public double ValorImporte { get; set; }

    public int IdPeriodo { get; set; }

    public int IdanioFiscal { get; set; }

    [Column("pe_mes")]
    public int PeMes { get; set; }

    [Column("smes")]
    [StringLength(10)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Smes { get; set; } = null!;

    [StringLength(50)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public string Nemonico { get; set; } = null!;
}
