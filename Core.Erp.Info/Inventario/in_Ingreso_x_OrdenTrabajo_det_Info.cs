using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Inventario
{
    public class in_Ingreso_x_OrdenTrabajo_det_Info
    {
        public int IdEmpresa { get; set; }

        public decimal IdIngreso_x_ot { get; set; }

        public int Secuencia { get; set; }

        public decimal IdProducto { get; set; }

        public int? IdBodegaProducto { get; set; }

        public double Cant { get; set; }

        public double Cant_a_recibir { get; set; }

        public double Cant_recibida { get; set; }

        public decimal IdOrdenTrabajo { get; set; }

        public string IdUnidadMedida { get; set; }

        public double do_descuento { get; set; }

        public double do_subtotal { get; set; }

        public double do_iva { get; set; }

        public double do_total { get; set; }

        public string Descripcion { get; set; }

        public string IdUnidadMedida_Consumo { get; set; }

        public string detalle_x_tiem { get; set; }

        public bool Checked { get; set; }

        public int IdSucursal { get; set; }

        public int Secuencia_Det { get; set; }

        public string nom_sucu { get; set; }

        public decimal IdProveedor { get; set; }

        public string nom_proveedor { get; set; }

        public int? IdProductoTipo { get; set; }

        public DateTime Fecha { get; set; }

        public string Observacion { get; set; }

        public string cod_producto { get; set; }

        public string nom_producto { get; set; }

        public double ot_precio { get; set; }

        public double oc_preciofinal { get; set; }

        public int secuencia_inv_det { get; set; }

        public double cantidad_pedida_OT { get; set; }

        public double cantidad_ing_a_Inven { get; set; }

        public double Saldo_x_Ing_OT { get; set; }

        public double pr_stock { get; set; }

        public double pr_peso { get; set; }

        public double CostoProducto { get; set; }

        public string Estado { get; set; }

        public string IdCentroCosto { get; set; }

        public string IdEstadoAprobacion { get; set; }

        public double Saldo_x_Ing_OT_AUX { get; set; }

        public string IdEstadoRecepcion { get; set; }

        public double cantidad_ingresada { get; set; }

        public string IdEstadoCierre { get; set; }

        public string nom_estado_cierre { get; set; }

        public string Ref_OC { get; set; }
    }
}
