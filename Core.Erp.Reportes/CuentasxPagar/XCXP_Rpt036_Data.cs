using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt036_Data
    {
        public List<XCXP_Rpt036_Info> consultar_data(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
        {
            try
            {
                List<XCXP_Rpt036_Info> listadedatos = new List<XCXP_Rpt036_Info>();

                //DateTime FechaInicial = Convert.ToDateTime(FechaIni.ToShortDateString());
                //DateTime FechaFinal = Convert.ToDateTime(FechaFin.ToShortDateString());

                using (EntitiesCXP_General retencion = new EntitiesCXP_General())
                {
                    var select = from h in retencion.spXCXP_Rpt036(IdEmpresa, FechaIni.Date, FechaFin.Date)
                                 select h;

                    foreach (var item in select)
                    {
                        XCXP_Rpt036_Info itemInfo = new XCXP_Rpt036_Info();
                        itemInfo.re_tipoRet = item.re_tipoRet;
                        itemInfo.IdCodigo_SRI = item.IdCodigo_SRI;
                        itemInfo.cod_Impuesto_SRI = item.cod_Impuesto_SRI;
                        itemInfo.Impuesto = item.Impuesto;
                        itemInfo.Base_IVA = item.Base_IVA;
                        itemInfo.Base_IVA0 = item.Base_IVA0;
                        itemInfo.Base = item.Base;
                        itemInfo.Valor_Retencion = item.Valor_Retencion;

                        listadedatos.Add(itemInfo);
                    }
                }
                return listadedatos;
            }
            catch (Exception ex)
            {
                return new List<XCXP_Rpt036_Info>();
            }
        }
    }
}