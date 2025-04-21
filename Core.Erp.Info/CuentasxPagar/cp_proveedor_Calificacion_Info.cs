using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_proveedor_Calificacion_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdProveedor { get; set; }
        public int IdCalificacion { get; set; }
        public double Calificacion { get; set; }
        public string Estado { get; set; }
        public System.DateTime FechaTransaccion { get; set; }
        public string IdUsuario { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string IdUsuarioModificacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string IdUsuarioAnulacion { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }
        public bool Liberado { get; set; }
        public string IdUsuarioAprobacion { get; set; }
        public string MotivoAprobacion { get; set; }
        public Nullable<System.DateTime> FechaAprobacion { get; set; }

        public Boolean Modificado { get; set; }
    }
}
