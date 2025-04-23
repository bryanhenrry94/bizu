using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bizu.Domain.CuentasxPagar.xmlATS
{
   public class detalleExportaciones
    {

        private string tpIdClienteEx { get; set; }
        private string idClienteEx { get; set; }
        private string parteRelExp { get; set; }
        private string tipoCli { get; set; }
        private string denoExpCli { get; set; }
        private string tipoRegi { get; set; }
        private string paisEfecPagoGen { get; set; }
        private string paisEfecExp { get; set; }
        private string exportacionDe { get; set; }
        private string tipoComprobante { get; set; }
        private string distAduanero { get; set; }
        private string anio { get; set; }
        private string regimen { get; set; }
        private string correlativo { get; set; }
        private string docTransp { get; set; }
        private string fechaEmbarque { get; set; }
        private decimal valorFOB { get; set; }
        private decimal valorFOBComprobante { get; set; }
        private string establecimiento { get; set; }
        private string puntoEmision { get; set; }
        private string secuencial { get; set; }
        private string autorizacion { get; set; }
        private string fechaEmision { get; set; }

        public detalleExportaciones() { }
    }
}
