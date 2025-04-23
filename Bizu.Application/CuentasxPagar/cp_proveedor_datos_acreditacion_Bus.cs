using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Domain.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Application.CuentasxPagar
{
    public class cp_proveedor_datos_acreditacion_Bus
    {
        cp_proveedor_datos_acreditacion_Data miData = new cp_proveedor_datos_acreditacion_Data();

        public List<cp_proveedor_datos_acreditacion_Info> GetList(int IdEmpresa, decimal IdProveedor)
        {
            return miData.GetList(IdEmpresa, IdProveedor);
        }

        public bool EliminarBD(int IdEmpresa, decimal IdProveedor, int Secuencia)
        {
            return miData.EliminarBD(IdEmpresa, IdProveedor, Secuencia);
        }

        public bool GrabarBD(cp_proveedor_datos_acreditacion_Info Info)
        {
            return miData.GrabarBD(Info);
        }

        public bool ModificarBD(cp_proveedor_datos_acreditacion_Info Info)
        {
            return miData.ModificarBD(Info);
        }
    }
}
