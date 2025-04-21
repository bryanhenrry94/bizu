using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Compras
{
    public class com_ordencompra_local_x_com_solicitud_compra_Info
    {
        public int IdEmpresa_oc { get; set; }

        public int IdSucursal_oc { get; set; }

        public decimal IdOrdenCompra_oc { get; set; }

        public int IdEmpresa_sc { get; set; }

        public int IdSucursal_sc { get; set; }

        public decimal IdSolicitudCompra_sc { get; set; }

        public int Secuencia_sc { get; set; }

        public decimal? IdProducto { get; set; }

        public double Cantidad { get; set; }

        public double Cantidad_Aux { get; set; }
    }
}
