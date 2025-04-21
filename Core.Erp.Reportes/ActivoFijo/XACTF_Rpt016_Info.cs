using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt016_Info
    {
        public int IdEmpresa { get; set; }
        public int IdActivoFijo { get; set; }
        public string CodActivoFijo { get; set; }
        public string Af_Codigo_Barra { get; set; }
        public string Af_Nombre { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string nom_proveedor { get; set; }
        public Nullable<int> IdDepartamento { get; set; }
        public string nom_departamento { get; set; }
        public Nullable<decimal> IdEncargado { get; set; }
        public string nom_encargado { get; set; }
        public Nullable<decimal> IdOrdenCompra { get; set; }
        public System.DateTime Af_fecha_compra { get; set; }
        public string num_factura { get; set; }

        public XACTF_Rpt016_Info ()
	    {

	    }
    }
}
