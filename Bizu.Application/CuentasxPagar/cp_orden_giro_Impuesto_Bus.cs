using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Infrastructure.CuentasxPagar;
using Bizu.Domain.CuentasxPagar;

namespace Bizu.Application.CuentasxPagar
{
    public class cp_orden_giro_Impuesto_Bus
    {
        private cp_orden_giro_Impuesto_Data Data;

        public cp_orden_giro_Impuesto_Bus()
        {
            this.Data = new cp_orden_giro_Impuesto_Data();
        }

        public bool Eliminar(int IdEmpresa, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
        {
            try
            {
                return Data.Eliminar(IdEmpresa, IdCbteCble_Ogiro, IdTipoCbte_Ogiro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GrabarBD(cp_orden_giro_Impuesto_Info Info)
        {
            try
            {
                return Data.GrabarBD(Info);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<cp_orden_giro_Impuesto_Info> GetList(int IdEmpresa, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro)
        {
            try
            {
                return Data.GetList(IdEmpresa, IdCbteCble_Ogiro, IdTipoCbte_Ogiro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
