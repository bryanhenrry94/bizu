using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion
{
    public class fa_cliente_Obra_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCliente { get; set; }
        public string IdCentroCosto { get; set; }
        public Nullable<System.DateTime> FechaIni { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public string DireccionObra { get; set; }
        public string CorreoObra { get; set; }
        public string IdEstadoObra { get; set; }

        public fa_catalogo_Info fa_catalogo { get; set; }
        public fa_Cliente_Info fa_cliente { get; set; }
    }
}
