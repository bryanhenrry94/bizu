using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Infrastructure.Facturacion;
using Bizu.Domain.Facturacion;

namespace Bizu.Application.Facturacion
{    
    public class vwfa_Nota_Credito_x_Devolver_Bus
    {
        vwfa_Nota_Credito_x_Devolver_Data data = new vwfa_Nota_Credito_x_Devolver_Data();

        public List<vwfa_Nota_Credito_x_Devolver_Info> Get_list_docs_x_cruzar_SinSaldo(int IdEmpresa, decimal IdCliente)
        {
            try
            {
                return data.Get_list_docs_x_cruzar_SinSaldo(IdEmpresa, IdCliente);
            }
            catch (Exception ex)
            {                
                throw new Exception(ex.ToString());
            }
        }
    }
}
