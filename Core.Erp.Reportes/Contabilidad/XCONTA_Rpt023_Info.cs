using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Contabilidad
{
   public class XCONTA_Rpt023_Info
    {
       public XCONTA_Rpt023_Info()
       {

       }


       public long IdRow { get; set; }
       public int IdEmpresa { get; set; }
       public string IdCtaCble { get; set; }
       public string IdCtaCble_Padre { get; set; }
       public string IdCentroCosto { get; set; }
       public string IdUsuario { get; set; }
       public double Saldo_Inicial { get; set; }
       public double Saldo_Deudor { get; set; }
       public double Saldo_Acreedor { get; set; }
       public double Saldo_Acumulado { get; set; }
       public string nom_cuenta { get; set; }
       public string CodCentroCosto { get; set; }
       public string nom_centrocosto { get; set; }
       public int IdNivelCta { get; set; }
       public string IdGrupoCble { get; set; }
       public string nom_grupoCble { get; set; }
       public string nom_empresa { get; set; }
       public string TipoBalance { get; set; }
       public Nullable<int> IdTipo_Gasto { get; set; }
       public string nom_tipo_Gasto { get; set; }
       public string nom_tipo_Costo { get; set; }


       public Nullable<int> IdTipo_Costo { get; set; }



    }
}
