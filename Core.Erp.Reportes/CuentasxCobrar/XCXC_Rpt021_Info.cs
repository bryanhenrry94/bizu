using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt021_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdCliente { get; set; }
        public int IdProyecto { get; set; }
        public Nullable<int> IdOferta { get; set; }
        public string NomCliente { get; set; }
        public string NomProyecto { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public string Descripcion { get; set; }
        public double Parcial { get; set; }
        public double Retencion { get; set; }
        public double Valor_a_Pagar { get; set; }
        public string Factura { get; set; }
        public double MontoTotal { get; set; }
        public int Nivel { get; set; }

        public double Saldo { get; set; }
    }
}
