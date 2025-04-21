using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;

namespace Core.Erp.Business.Contabilidad
{
    public class vwct_cbtecble_con_ctacble_acreedora_Bus
    {
        vwct_cbtecble_con_ctacble_acreedora_Data Data = new vwct_cbtecble_con_ctacble_acreedora_Data();

        public vwct_cbtecble_con_ctacble_acreedora_Info Get_Info(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
        {
            try
            {
                return Data.Get_Info(IdEmpresa, IdTipoCbte, IdCbteCble);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
