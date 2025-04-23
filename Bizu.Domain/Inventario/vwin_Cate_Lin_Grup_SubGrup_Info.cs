using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Domain.Inventario
{
    public class vwin_Cate_Lin_Grup_SubGrup_Info
    {
        public int IdEmpresa { get; set; }
        public string IdCategoria { get; set; }
        public int IdLinea { get; set; }
        public int IdGrupo { get; set; }
        public int IdSubgrupo { get; set; }
        public string ca_Categoria { get; set; }
        public string nom_linea { get; set; }
        public string nom_grupo { get; set; }
        public string nom_subgrupo { get; set; }

        public string IdElemento { get; set; }
    }
}