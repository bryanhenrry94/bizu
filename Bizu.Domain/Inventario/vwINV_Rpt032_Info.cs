using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
    public class vwINV_Rpt032_Info
    {
        public Nullable<long> id { get; set; }
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
        public string IdCategoria { get; set; }
        public string nom_Categoria { get; set; }
        public int IdLinea { get; set; }
        public string nom_linea { get; set; }
        public double pr_precio_publico { get; set; }
        public double pr_precio_mayor { get; set; }
        public double pr_precio_minimo { get; set; }
        public Nullable<double> pr_precio_publico_anterior { get; set; }
        public Nullable<double> pr_precio_mayor_anterior { get; set; }
        public Nullable<double> pr_precio_minimo_anterior { get; set; }
        public System.DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
        public int Secuencia { get; set; }
    }
}
