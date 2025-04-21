using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_Bus
    {
        private cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_Data data;

        public cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_Bus()
        {
            this.data = new cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_Data();

        }

        public bool GrabarBD(cp_nota_DebCre_Aprobacion_Ing_Bod_x_OC_Info Info)
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
