using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt014_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdMarca { get; set; }
        public string marca { get; set; }
        public int IdGrupo { get; set; }
        public string nom_grupo { get; set; }
        public Nullable<double> vt_cantidad { get; set; }
        public Nullable<double> vt_Precio { get; set; }
        public Nullable<double> vt_Peso { get; set; }
        public Nullable<double> mv_costo { get; set; }
        public Nullable<double> vt_peso_total { get; set; }
        public Nullable<double> vt_costo_total { get; set; }
        public Nullable<double> vt_venta_bruta { get; set; }
        public Nullable<double> vt_venta_neta { get; set; }
        public Nullable<double> vt_DescUnitario { get; set; }
        public Nullable<double> vt_PorDescUnitario { get; set; }
        public Nullable<double> vt_Subtotal { get; set; }
        public Nullable<double> vt_iva { get; set; }
        public Nullable<double> vt_por_iva { get; set; }
        public Nullable<double> vt_total { get; set; }

        public double por_costoVenta { get; set; }
        public double por_utilidad_bruta { get; set; }
        public double vt_utilidad_bruta { get; set; }        
        public double precio_Unit_KG { get; set; }
        public double costo_Unit_KG { get; set; }
    }
}
