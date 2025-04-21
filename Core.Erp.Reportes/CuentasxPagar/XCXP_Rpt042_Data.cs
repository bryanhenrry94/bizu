using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxPagar;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt042_Data
    {
        public List<XCXP_Rpt042_Info> GetData(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<XCXP_Rpt042_Info> lista = new List<XCXP_Rpt042_Info>();

                EntitiesCXP_General dbContext = new EntitiesCXP_General();

                var query = dbContext.spCXP_Rpt042(IdEmpresa, FechaIni, FechaFin).ToList();

                foreach (var item in query)
                {
                    XCXP_Rpt042_Info Info = new XCXP_Rpt042_Info();

                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                    Info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                    Info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                    Info.TipoDoc = item.TipoDoc;
                    Info.FechaDoc = item.FechaDoc;
                    Info.num_documento = item.num_documento;
                    Info.Codigo = item.Codigo;
                    Info.CodigoPorcentaje = item.CodigoPorcentaje;
                    Info.BaseImponible = item.BaseImponible;
                    Info.Tarifa = item.Tarifa;
                    Info.Valor = item.Valor;

                    lista.Add(Info);
                }

                return lista;
            }catch(Exception ex){
                throw ex;
            }
        }
    }
}
