using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
    public class vwin_producto_x_tb_bodega_Precios_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdProducto { get; set; }
        public int IdBodega { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public int IdMarca { get; set; }
        public int IdProductoTipo { get; set; }
        public string IdPresentacion { get; set; }
        public string IdUnidadMedida { get; set; }
        public double pr_precio_publico { get; set; }
        public double pr_precio_mayor { get; set; }
        public double pr_precio_puerta { get; set; }
        public double pr_precio_minimo { get; set; }
        public string IdCategoria { get; set; }
        public string nom_Categoria { get; set; }
        public int IdLinea { get; set; }
        public string nom_linea { get; set; }

        public double pr_precio_publico_nuevo { get; set; }
        public double pr_precio_mayor_nuevo { get; set; }
        public double pr_precio_minimo_nuevo { get; set; }
        public bool Checked { get; set; }
    }
}
