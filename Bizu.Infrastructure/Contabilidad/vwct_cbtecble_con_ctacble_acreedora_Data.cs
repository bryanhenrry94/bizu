using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.Contabilidad;

namespace Bizu.Infrastructure.Contabilidad
{
    public class vwct_cbtecble_con_ctacble_acreedora_Data
    {
        public vwct_cbtecble_con_ctacble_acreedora_Info Get_Info(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble)
        {
            try
            {
                vwct_cbtecble_con_ctacble_acreedora_Info Info = new vwct_cbtecble_con_ctacble_acreedora_Info();
                EntitiesDBConta OECbtecble_Info = new EntitiesDBConta();

                var selectCbtecble = from C in OECbtecble_Info.vwct_cbtecble_con_ctacble_acreedora
                                     where C.IdEmpresa == IdEmpresa
                                     && C.IdTipoCbte == IdTipoCbte
                                     && C.IdCbteCble == IdCbteCble
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdTipoCbte = item.IdTipoCbte;
                    Info.IdCbteCble = item.IdCbteCble;
                    Info.IdCtaCble_Acreedora = item.IdCtaCble_Acreedora;
                }

                return Info;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
