using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.General
{
    public class tb_ciiu_Info
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> nivel { get; set; }
    }
}
