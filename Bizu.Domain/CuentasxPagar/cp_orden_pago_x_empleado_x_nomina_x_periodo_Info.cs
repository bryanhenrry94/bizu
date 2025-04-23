using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.CuentasxPagar
{
    public class cp_orden_pago_x_empleado_x_nomina_x_periodo_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdOrdenPago { get; set; }
        public decimal IdPersona { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdNomina_Tipo { get; set; }
        public int IdNomina_TipoLiqui { get; set; }
        public int IdPeriodo { get; set; }
        public Nullable<decimal> IdTipoFlujo { get; set; }
        public string IdTipo_op { get; set; }
        public Nullable<double> Valor { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Trasanc { get; set; }
        public string MotivoAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
    
    }
}
