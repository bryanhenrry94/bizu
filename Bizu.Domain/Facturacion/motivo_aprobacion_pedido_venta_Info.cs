using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.Facturacion
{
    public class motivo_aprobacion_pedido_venta_Info
    {
        public int IdEmpresa { get; set; }
        public int IdMotivo { get; set; }
        public int IdPedido { get; set; }
        public decimal IdCliente { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string MotivoAprobacion { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public string IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
    }
}
