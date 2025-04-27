
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bizu.Domain.General
{
    public class tb_banco_Info
    {
        public int IdBanco { get; set; }
        public string ba_descripcion { get; set; }
        public string Estado { get; set; }
        public string CodigoLegal { get; set; }
        public Boolean? TieneFormatoTransferencia { get; set; }

        public tb_banco_Info()
        {
        }
    }
}
