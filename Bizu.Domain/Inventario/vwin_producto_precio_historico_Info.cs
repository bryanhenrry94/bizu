using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.Inventario
{
    public class vwin_producto_precio_historico_Info
    {
        public Nullable<long> Id { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdProducto { get; set; }
        public int IdBodega { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public double pr_peso { get; set; }
        public string pr_ManejaIva { get; set; }
        public string pr_ManejaSeries { get; set; }
        public string bo_Descripcion { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public int IdMarca { get; set; }
        public int IdProductoTipo { get; set; }
        public string IdPresentacion { get; set; }
        public string IdCtaCble_Inven { get; set; }
        public string IdCtaCble_Costo { get; set; }
        public string ManejaKardex { get; set; }
        public string IdNaturaleza { get; set; }
        public string IdCtaCble_Inventario { get; set; }
        public string IdCentro_Costo_Inventario { get; set; }
        public string IdCentro_Costo_Costo { get; set; }
        public string IdCtaCble_Gasto_x_cxp { get; set; }
        public string IdCentroCosto_x_Gasto_x_cxp { get; set; }
        public string IdCentroCosto_sub_centro_costo_inv { get; set; }
        public string IdCentroCosto_sub_centro_costo_cost { get; set; }
        public string IdCentroCosto_sub_centro_costo_cxp { get; set; }
        public string IdCtaCble_CosBaseIva { get; set; }
        public string IdCtaCble_CosBase0 { get; set; }
        public string IdCtaCble_VenIva { get; set; }
        public string IdCtaCble_Ven0 { get; set; }
        public string IdCtaCble_DesIva { get; set; }
        public string IdCtaCble_Des0 { get; set; }
        public string IdCtaCble_DevIva { get; set; }
        public string IdCtaCble_Dev0 { get; set; }
        public string IdCtaCble_Vta { get; set; }
        public double pr_stock_minimo { get; set; }
        public string IdCod_Impuesto_Iva { get; set; }
        public string IdCod_Impuesto_Ice { get; set; }
        public bool Aparece_modu_Ventas { get; set; }
        public bool Aparece_modu_Compras { get; set; }
        public bool Aparece_modu_Inventario { get; set; }
        public bool Aparece_modu_Activo_F { get; set; }
        public string IdCategoria { get; set; }
        public string nom_Categoria { get; set; }
        public int IdLinea { get; set; }
        public string nom_linea { get; set; }
        public string pr_codigo_barra { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public double pr_precio_publico { get; set; }
        public double pr_precio_mayor { get; set; }
        public double pr_precio_minimo { get; set; }
        public Nullable<double> pr_precio_publico_nuevo { get; set; }
        public Nullable<double> pr_precio_mayor_nuevo { get; set; }
        public Nullable<double> pr_precio_minimo_nuevo { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<int> Secuencia { get; set; }

        public bool Checked { get; set; }
    }
}
