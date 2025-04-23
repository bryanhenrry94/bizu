using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.CuentasxPagar;

namespace Bizu.Infrastructure.CuentasxPagar
{
    public class cp_pais_sri_Data
    {

        public List<cp_pais_sri_Info> Get_List_Pais_SRI(ref string mensajeError)
        {
            List<cp_pais_sri_Info> List = new List<cp_pais_sri_Info>();

            try {
                using(EntitiesCuentasxPagar Entities = new EntitiesCuentasxPagar())
                {
                    var query = from q in Entities.cp_pais_sri
                                select q;

                    foreach (var item in query) 
                    {
                        cp_pais_sri_Info Info = new cp_pais_sri_Info();
                        Info.Pais = item.Pais;
                        Info.Codigo = item.Codigo;

                        List.Add(Info);
                    }
                }
            }
            catch (Exception e) {
                mensajeError = e.Message;
            }

            return List;
        }

    }
}
