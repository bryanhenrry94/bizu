using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bizu.Domain.Contabilidad;
using Bizu.Domain.Bancos;
namespace Bizu.Domain.Bancos
{
    public class ba_Banco_Parametros_Info
    {
        public int IdEmpresa { get; set; }

        public string CodTipoCbteBan { get; set; }
        public int IdTipoCbteCble { get; set; }
        public int IdTipoCbteCble_Anu { get; set; }
        public string IdCtaCble { get; set; }
        public string Tipo_DebCred { get; set; }

        public string IdUsuario { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime FechaUltMod { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }


        public ba_Banco_Parametros_Info() { }
    }
}
