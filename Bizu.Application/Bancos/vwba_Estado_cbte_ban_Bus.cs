using Bizu.Infrastructure.Bancos;
using Bizu.Domain.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Application.Bancos
{
    public class vwba_Estado_cbte_ban_Bus
    {
        vwba_Estado_cbte_ban_Data oData = new vwba_Estado_cbte_ban_Data();

        public List<vwba_Estado_cbte_ban_Info> Get_Lista_Estado_cbte_ban()
        {
            try
            {
                return oData.Get_Lista_Estado_cbte_ban();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Lista_Estado_cbte_ban", ex.Message), ex) { EntityType = typeof(vwba_Estado_cbte_ban_Bus) };
            }
        }

        public List<vwba_Estado_cbte_ban_Info> Get_Lista_Estado_cbte_ban_Todos()
        {
            try
            {
                return oData.Get_Lista_Estado_cbte_ban_Todos();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Lista_Estado_cbte_ban", ex.Message), ex) { EntityType = typeof(vwba_Estado_cbte_ban_Bus) };
            }
        }

    }
}
