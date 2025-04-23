using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.Factuarcion_CAH
{
    public class fa_notaCredDeb_aca_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdNotaCredDeb { get; set; }
        public Nullable<int> IdInstitucion { get; set; }
        public decimal IdEstudiante { get; set; }
        public int IdTipoNota { get; set; }
        public string Observaciones { get; set; }
        public Nullable<bool> estado { get; set; }

        public fa_notaCredDeb_aca_Info()
        {

        }
    }
}