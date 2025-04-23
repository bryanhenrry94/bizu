using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.CuentasxPagar;

namespace Bizu.Infrastructure.CuentasxPagar
{
    public class cp_nota_DebCre_x_com_ordencompra_local_Data
    {
        public bool GrabarBD(cp_nota_DebCre_x_com_ordencompra_local_Info Info)
        {
            try
            {
                EntitiesCuentasxPagar dbContext = new EntitiesCuentasxPagar();

                cp_nota_DebCre_x_com_ordencompra_local _objNotaxOC = new cp_nota_DebCre_x_com_ordencompra_local();
                _objNotaxOC.ndc_IdEmpresa = Info.ndc_IdEmpresa;
                _objNotaxOC.ndc_IdCbteCble_Nota = Info.ndc_IdCbteCble_Nota;
                _objNotaxOC.ndc_IdTipoCbte_Nota = Info.ndc_IdTipoCbte_Nota;
                _objNotaxOC.com_IdEmpresa = Info.com_IdEmpresa;
                _objNotaxOC.com_IdSucursal = Info.com_IdSucursal;
                _objNotaxOC.com_IdOrdenCompraLocal = Info.com_IdOrdenCompraLocal;
                _objNotaxOC.og_Observacion = Info.og_Observacion;

                dbContext.cp_nota_DebCre_x_com_ordencompra_local.Add(_objNotaxOC);
                dbContext.SaveChanges();

                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
