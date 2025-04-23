using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bizu.Domain.CuentasxPagar;

namespace Bizu.Reports.CuentasxPagar
{
    public class XCXP_Rpt043_Data
    {

        public List<XCXP_Rpt043_Info> GetData(int IdEmpresa, decimal IdProveedorIni, decimal IdProveedorFin, DateTime FechaIni, DateTime FechaFin, string IdUsuario)
        {
            try
            {
                List<XCXP_Rpt043_Info> lista = new List<XCXP_Rpt043_Info>();

                EntitiesCXP_General dbContext = new EntitiesCXP_General();

                var query = dbContext.spCXP_Rpt043(IdEmpresa, IdProveedorIni, IdProveedorFin, FechaIni, FechaFin, IdUsuario);

                foreach (var item in query)
                {
                    XCXP_Rpt043_Info Info = new XCXP_Rpt043_Info();

                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdProveedor = item.IdProveedor;
                    Info.Nombre = item.Nombre;
                    Info.Tipo = item.Tipo;
                    Info.IdEmpresa_cxp = item.IdEmpresa_cxp;
                    Info.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                    Info.IdCbteCble_cxp = item.IdCbteCble_cxp;
                    Info.IdEmpresa_pago = item.IdEmpresa_pago;
                    Info.IdTipoCbte_pago = item.IdTipoCbte_pago;
                    Info.IdCbteCble_pago = item.IdCbteCble_pago;
                    Info.IdEmpresaOP = item.IdEmpresaOP;
                    Info.IdOrdenPago = item.IdOrdenPago;
                    Info.Documento = item.Documento;
                    Info.Fecha = item.Fecha;
                    Info.SaldoInicial = item.SaldoInicial;
                    Info.Debe = item.Debe;
                    Info.Haber = item.Haber;
                    Info.Saldo = item.Saldo;
                    Info.SaldoFinal = item.SaldoFinal;
                    Info.Observacion = item.Observacion;
                    Info.Orden = item.Orden;
                    Info.IdUsuario = item.IdUsuario;

                    lista.Add(Info);
                }

                return lista;
            }catch(Exception ex){
                throw ex;
            }
        }
    }
}
