using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt038_Data
    {
        public List<XCXP_Rpt038_Info> consultar_data(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, int IdProveedorIni, int IdProveedorFin, ref string mensaje)
        {
            try
            {
                List<XCXP_Rpt038_Info> listadedatos = new List<XCXP_Rpt038_Info>();

                DateTime FechaInicial = Convert.ToDateTime(FechaIni.ToShortDateString());
                DateTime FechaFinal = Convert.ToDateTime(FechaFin.ToShortDateString());

                IdProveedorIni = (IdProveedorIni != 0) ? IdProveedorIni : 0;
                IdProveedorFin = (IdProveedorFin != 0) ? IdProveedorFin : 99999999;

                using (EntitiesCXP_General retencion = new EntitiesCXP_General()) 
                {
                    var select = from h in retencion.spCXP_Rpt038(IdEmpresa, FechaIni, FechaFin, IdProveedorIni, IdProveedorFin)
                                 select h;

                    foreach (var item in select)
                    {
                        XCXP_Rpt038_Info itemInfo = new XCXP_Rpt038_Info();
                        itemInfo.TipoDoc = item.TipoDoc;
                        itemInfo.Impuesto = item.Impuesto;
                        itemInfo.IdCodigo_SRI = item.IdCodigo_SRI;
                        itemInfo.Base_IVA = item.Base_IVA;
                        itemInfo.Base_IVA0 = item.Base_IVA0;
                        itemInfo.Base = item.Base;
                        itemInfo.NumeroDocumento = item.NumeroDocumento;
                        itemInfo.fecha = item.fecha;
                        itemInfo.pr_nombre = item.pr_nombre;
                        itemInfo.pe_cedulaRuc = item.pe_cedulaRuc;
                        itemInfo.detalle = item.detalle;
                        itemInfo.IdCbteCble = item.IdCbteCble;
                        itemInfo.IdTipoCbte = item.IdTipoCbte;

                        listadedatos.Add(itemInfo);
                    }
                }
                return listadedatos;
            }
            catch (Exception ex)
            {
                return new List<XCXP_Rpt038_Info>();
            }
        }
    }
}