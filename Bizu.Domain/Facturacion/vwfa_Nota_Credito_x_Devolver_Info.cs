using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.Facturacion
{
    public class vwfa_Nota_Credito_x_Devolver_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public string CreDeb { get; set; }
        public string Serie1 { get; set; }
        public string Serie2 { get; set; }
        public string NumDoc { get; set; }
        public string Documento { get; set; }
        public string sc_observacion { get; set; }
        public decimal IdNota { get; set; }
        public string CodNota { get; set; }
        public string Su_Descripcion { get; set; }
        public decimal IdCliente { get; set; }
        public System.DateTime no_fecha { get; set; }
        public Nullable<double> sc_total { get; set; }
        public Nullable<double> Saldo { get; set; }
        public double totalCobrado { get; set; }
        public string bo_Descripcion { get; set; }
        public Nullable<double> sc_subtotal { get; set; }
        public Nullable<double> sc_iva { get; set; }
        public Nullable<System.DateTime> no_fecha_venc { get; set; }
        public double RtFT { get; set; }
        public double RtIVA { get; set; }
        public string CodCliente { get; set; }
        public string NomCliente { get; set; }
        public string em_nombre { get; set; }
        public string Estado { get; set; }
    }
}
