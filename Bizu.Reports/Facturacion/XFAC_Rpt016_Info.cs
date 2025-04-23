using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.Facturacion
{
    public class XFAC_Rpt016_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public string TipoDoc { get; set; }
        public int IdCbteVta { get; set; }
        public int IdCliente { get; set; }
        public string nom_cliente { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<double> vt_cantidad { get; set; }
        public Nullable<double> vt_Precio { get; set; }
        public Nullable<double> vt_Peso { get; set; }
        public Nullable<double> vt_peso_total { get; set; }
        public Nullable<double> mv_costo { get; set; }
        public Nullable<double> vt_costo_total { get; set; }
        public Nullable<double> vt_venta_bruta { get; set; }
        public Nullable<double> vt_venta_neta { get; set; }
        public Nullable<double> vt_DescUnitario { get; set; }
        public Nullable<double> vt_PorDescUnitario { get; set; }
        public Nullable<double> vt_Subtotal { get; set; }
        public Nullable<double> vt_iva { get; set; }
        public Nullable<double> vt_por_iva { get; set; }
        public Nullable<double> vt_total { get; set; }
        public Nullable<System.DateTime> vt_fecha { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_descripcion { get; set; }
        public int IdMarca { get; set; }
        public string marca { get; set; }
        public int IdGrupo { get; set; }
        public string nom_grupo { get; set; }
    }
}
