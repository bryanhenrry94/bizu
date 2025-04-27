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
                                     where C.idempresa == IdEmpresa
                                     && C.idtipocbte == IdTipoCbte
                                     && C.idcbtecble == IdCbteCble
                                     select C;

                foreach (var item in selectCbtecble)
                {
                    Info.IdEmpresa = item.idempresa;
                    Info.IdTipoCbte = item.idtipocbte;
                    Info.IdCbteCble = item.idcbtecble;
                    Info.IdCtaCble_Acreedora = item.idctacble_acreedora;
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
