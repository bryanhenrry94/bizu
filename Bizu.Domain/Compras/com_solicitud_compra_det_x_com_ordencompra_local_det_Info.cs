using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.Compras
{
    public class com_solicitud_compra_det_x_com_ordencompra_local_det_Info
    {
        public int IdEmpresa_oc { get; set; }
        public int IdSucursal_oc { get; set; }
        public decimal IdOrdenCompra_oc { get; set; }
        public int Secuencia_oc { get; set; }
        public int IdEmpresa_sc { get; set; }
        public int IdSucursal_sc { get; set; }
        public decimal IdSolicitudCompra_sc { get; set; }
        public int Secuencia_sc { get; set; }
        public double Cantidad { get; set; }

        public com_ordencompra_local_det_Info com_ordencompra_local_det { get; set; }
        public com_solicitud_compra_det_Info com_solicitud_compra_det { get; set; }
    }
}
