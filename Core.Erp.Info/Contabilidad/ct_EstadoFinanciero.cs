using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_EstadoFinanciero
    {
        public ct_EstadoFinanciero(string _IdEstadoFinanciero, string _EstadoFinanciero)
        {
            IdEstadoFinanciero = _IdEstadoFinanciero;
            EstadoFinanciero = _EstadoFinanciero;
        }

        public string IdEstadoFinanciero { set; get; }
        public string EstadoFinanciero { set; get; }
    }
}
