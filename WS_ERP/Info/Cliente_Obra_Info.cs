using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_ERP.Info
{
    public class Cliente_Obra_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCliente { get; set; }
        public string IdCentroCosto { get; set; }
        public Nullable<System.DateTime> FechaIni { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public string DireccionObra { get; set; }
        public string CorreoObra { get; set; }
        public string IdEstadoObra { get; set; }
    }
}