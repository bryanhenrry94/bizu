using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bizu.Domain.Facturacion
{
    public class fa_factura_det_info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double vt_cantidad { get; set; }
        public double vt_Precio { get; set; }
        public double vt_PorDescUnitario { get; set; }
        public double vt_DescUnitario { get; set; }
        public double vt_PrecioFinal { get; set; }
        public double vt_Subtotal { get; set; }
        public double vt_iva { get; set; }
        public double ? vt_por_iva { get; set; }
        public double vt_total { get; set; }
        public string vt_estado { get; set; }

        //validadion de stock 
        public bool graba { get; set; }

        public string vt_detallexItems { get; set; }
        public double vt_Peso { get; set; }
        //efecto visual del subtotal sin iva
        public double SubTotal_sin_desc { get; set; }

        public double stock { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public double? Precio_Iva { get; set; }

        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public string pr_descripcion_2 { get; set; }

        public string IdCtaCble_Ven0 { get; set; }
        public string IdCtaCble_VenIva { get; set; }


        public double Cant_Dev { get; set; }
        public double Cant_Venta { get; set; }

        public string IdCod_Impuesto_Iva { get; set; }
        public string IdCod_Impuesto_Ice { get; set; }
        public int IdRubro { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string pr_referencia { get; set; }
        public string IdUnidadMedida { get; set; }
        public string UnidadMedida { get; set; }

        /*SUNCHODESA GM*/
        public int  IdPedido { get; set; }

        public List<fa_factura_det_x_fa_descuento_Info> lst_descuento_x_factura_det { get; set; }

        public fa_factura_det_info() {
            lst_descuento_x_factura_det = new List<fa_factura_det_x_fa_descuento_Info>();
        }
    }
}
