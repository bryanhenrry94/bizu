using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.SRI;

namespace Bizu.Application.SRI
{
    public class sri_impuesto_Bus
    {
        public List<sri_impuesto_Info> GetList()
        {
            try
            {
                List<sri_impuesto_Info> ListaImpuesto = new List<sri_impuesto_Info>();

                ListaImpuesto.Add(new sri_impuesto_Info("0", "0%", 0, true));
                ListaImpuesto.Add(new sri_impuesto_Info("2", "12%", 12, false));
                ListaImpuesto.Add(new sri_impuesto_Info("3", "14%", 14, false));
                ListaImpuesto.Add(new sri_impuesto_Info("4", "15%", 15, true));
                ListaImpuesto.Add(new sri_impuesto_Info("5", "5%", 5, true));
                ListaImpuesto.Add(new sri_impuesto_Info("6", "No Objeto de Impuesto", 0, true));
                ListaImpuesto.Add(new sri_impuesto_Info("7", "Exento de IVA", 0, true));
                ListaImpuesto.Add(new sri_impuesto_Info("8", "IVA diferenciado", 0, true));
                ListaImpuesto.Add(new sri_impuesto_Info("10", "13%", 13, true));

                return ListaImpuesto;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
