using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.Compras
{
    public class XCOMP_Rpt001_Bus
    {
       XCOMP_Rpt001_Data data = new XCOMP_Rpt001_Data();

       public List<XCOMP_Rpt001_Info> Get_Data(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
       {
           try
           {
               return data.Get_Data(IdEmpresa, IdSucursal, IdOrdenCompra);
           }
           catch (Exception)
           {
               return new List<XCOMP_Rpt001_Info>();
           }
       }
    }
}
