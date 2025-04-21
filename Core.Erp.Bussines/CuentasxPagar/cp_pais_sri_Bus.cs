using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_pais_sri_Bus
    {
        cp_pais_sri_Data Data = new cp_pais_sri_Data();
        
        public List<cp_pais_sri_Info> Get_List_Pais_SRI(ref string mensajeError) 
        {
            return Data.Get_List_Pais_SRI(ref mensajeError);
        }
    }
}
