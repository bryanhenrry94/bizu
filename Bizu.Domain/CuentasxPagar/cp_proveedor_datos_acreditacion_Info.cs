using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.CuentasxPagar
{
    public class cp_proveedor_datos_acreditacion_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdProveedor { get; set; }
        public int Secuencia { get; set; }
        public Nullable<int> IdBanco { get; set; }
        public string IdTipoCuenta { get; set; }
        public string NumeroCuenta { get; set; }
        public string IdTipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public string Beneficiario { get; set; }
        public string Correo { get; set; }
        public Nullable<bool> Predefinida { get; set; }
        public bool Modificado { get; set; }
    }
}
