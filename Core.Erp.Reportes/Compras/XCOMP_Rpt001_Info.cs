using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Compras
{
    public class XCOMP_Rpt001_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public decimal IdProveedor { get; set; }
        public decimal IdProducto { get; set; }
        public string em_nombre { get; set; }
        public string pr_nombre { get; set; }
        public int oc_plazo { get; set; }
        public System.DateTime oc_fecha { get; set; }
        public string pr_codigo { get; set; }
        public double do_Cantidad { get; set; }
        public double pr_peso { get; set; }
        public double do_CantidadConversion { get; set; }
        public string IdUnidadMedida { get; set; }
        public string pr_descripcion { get; set; }
        public double do_precioCompra { get; set; }
        public double do_subtotal { get; set; }
        public double do_Subtotal_SinDescuento { get; set; }
        public double do_iva { get; set; }
        public double do_iva2 { get; set; } // 12 %
        public double do_iva3 { get; set; } // 14 %
        public double do_iva4 { get; set; } // 15 %
        public double do_iva5 { get; set; } // 5 %
        public double do_total { get; set; }
        public double do_descuento { get; set; }
        public double do_porc_des { get; set; }
        public int Secuencia { get; set; }
        public string IdCentroCosto { get; set; }
        public string Centro_costo { get; set; }
        public string oc_NumDocumento { get; set; }
        public bool pr_contribuyenteEspecial { get; set; }
        public string proveedor_es_contribuyente_especial { get; set; }
        public string proveedor_no_es_contribuyente_especial { get; set; }
        public string Usuario_Solicitante { get; set; }
        public string Usuario_Procesa { get; set; }
        public string Usuario_Aprueba { get; set; }
        public string TerminoPago { get; set; }
        public int DiasTerminoPago { get; set; }
        public string escontado { get; set; }
        public string escredito { get; set; }
        public string detalle_x_item { get; set; }
        public string oc_observacion { get; set; }
        public string IdCod_Impuesto { get; set; }
        public double Por_Iva { get; set; }
        public string UnidadMedidaConsumo { get; set; }
        public string correo_notificacion { get; set; }
        public double SubtotalIva2 { get; set; } // 12%
        public double SubtotalIva3 { get; set; } // 14%
        public double SubtotalIva4 { get; set; } // 15%
        public double SubtotalIva5 { get; set; } // 5%
    }
}