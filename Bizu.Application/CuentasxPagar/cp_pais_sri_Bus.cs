using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.CuentasxPagar;
using Bizu.Infrastructure.CuentasxPagar;

namespace Bizu.Application.CuentasxPagar
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
