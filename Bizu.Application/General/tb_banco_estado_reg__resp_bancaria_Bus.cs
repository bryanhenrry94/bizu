using Bizu.Infrastructure.General;
using Bizu.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Application.General
{
    public class tb_banco_estado_reg__resp_bancaria_Bus
    {
        tb_banco_estado_reg__resp_bancaria_Data oData = new tb_banco_estado_reg__resp_bancaria_Data();

        public List<tb_banco_estado_reg__resp_bancaria_Info> Get_Lista_Estados()
        {
            try
            {
                return oData.Get_Lista_Estados();
            }
            catch (Exception ex)
            {
                Bizu.Domain.Log_Exception.LoggingManager.Logger.Log(Bizu.Domain.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Bizu.Domain.Log_Exception.DalException(string.Format("", "Get_Lista_Estados", ex.Message), ex) { EntityType = typeof(tb_banco_estado_reg__resp_bancaria_Bus) };

            }
        }
    }
}
