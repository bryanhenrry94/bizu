using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.CuentasxCobrar
{
    public class cxc_retencion_Multiple_Documentos_ValorAplicado_Info
    {
        public int IdEmpresa { get; set; }
        public int IdMultir { get; set; }
        public int Secuencia { get; set; }
        public Nullable<decimal> IdCobro { get; set; }
        public int IdEmpresa_cbteVta { get; set; }
        public int IdSucursal_cbteVta { get; set; }
        public int IdBodega_cbteVta { get; set; }
        public decimal IdCbteVta_cbteVta { get; set; }
        public string IdTipoDoc_cbteVta { get; set; }
        public string IdCobro_tipo { get; set; }
        public double Base { get; set; }
        public double PorcentajeRetenc { get; set; }
        public double ValorRetenc { get; set; }
    }
}
