using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.Inventario
{
    public class XINV_Rpt037_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public string IdCentroCosto { get; set; }
        public string Centro_costo { get; set; }
        public string TipoDocumento { get; set; }
        public string numDocumento { get; set; }
        public Nullable<decimal> IdOrdenCompra { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string Proveedor { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public string cm_observacion { get; set; }
        public string pr_codigo_barra { get; set; }
    }
}
