using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.CuentasxPagar;
using Bizu.Infrastructure.CuentasxPagar;

namespace Bizu.Application.CuentasxPagar
{
    public class cp_nota_DebCre_x_com_ordencompra_local_Bus
    {
        private cp_nota_DebCre_x_com_ordencompra_local_Data data;

        public cp_nota_DebCre_x_com_ordencompra_local_Bus()
        {
            this.data = new cp_nota_DebCre_x_com_ordencompra_local_Data();
        }

        public bool GrabarBD(cp_nota_DebCre_x_com_ordencompra_local_Info Info)
        {
            try
            {
                return this.data.GrabarBD(Info);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
