using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Application.SRI
{
    public class sri_autorizacion
    {
        public string estado { get; set; }
        public string numeroAutorizacion { get; set; }
        public DateTime fechaAutorizacion { get; set; }
        public string ambiente { get; set; }
        public string comprobante { get; set; }
    }
}
