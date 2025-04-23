using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.Inventario
{
    public class in_producto_precio_historico_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdProducto { get; set; }
        public string IdUsuario { get; set; }
        public int Secuencia { get; set; }
        public System.DateTime Fecha { get; set; }
        public System.DateTime FechaTrans { get; set; }
        public Nullable<double> pr_precio_publico { get; set; }
        public Nullable<double> pr_precio_mayor { get; set; }
        public Nullable<double> pr_precio_minimo { get; set; }
        public in_Producto_Info producto_info { get; set; }

        public in_producto_precio_historico_Info() 
        {
            producto_info = new in_Producto_Info();
        }

    }
}
