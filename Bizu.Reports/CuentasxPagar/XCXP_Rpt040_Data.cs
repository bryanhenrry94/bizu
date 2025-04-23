using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bizu.Reports.CuentasxPagar
{
    public class XCXP_Rpt040_Data
    {
        public List<XCXP_Rpt040_Info> Get_Lista_Reporte(int idEmpresa, string idCentroCosto, string idSubcentroCosto, DateTime fechaIni, DateTime FechaFin, Int32 IdProveedorIni, Int32 IdProveedorFin)
        {
            try
            {
                List<XCXP_Rpt040_Info> Lista = new List<XCXP_Rpt040_Info>();

                using (EntitiesCXP_General Conexion = new EntitiesCXP_General())
                {
                    var query = from q in Conexion.vwCXP_Rpt040
                             where q.IdEmpresa == idEmpresa                             
                             && fechaIni<= q.Fecha_Fa_Prov && q.Fecha_Fa_Prov <= FechaFin
                             && q.IdProveedor >= IdProveedorIni && q.IdProveedor <= IdProveedorFin
                             select q;

                    if(idCentroCosto != "")
                    {
                        query = query.Where(q => q.IdCentroCosto.Contains(idCentroCosto));
                    }

                    
                    if(idSubcentroCosto != "")
                    {
                        query = query.Where(q => q.IdSubCentro_Costo.Contains(idSubcentroCosto));
                    }

                    foreach (var item in query)
                    {
                        XCXP_Rpt040_Info Info = new XCXP_Rpt040_Info();
                        Info.nom_Centro_costo = item.nom_Centro_costo;
                        Info.nom_subCentro_costo = item.nom_subCentro_costo;
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdTipo_op = item.IdTipo_op;
                        Info.Referencia = item.Referencia;
                        Info.Referencia2 = item.Referencia2;
                        Info.IdOrdenPago = item.IdOrdenPago;
                        Info.Secuencia_OP = item.Secuencia_OP;
                        Info.IdTipoPersona = item.IdTipoPersona;
                        Info.IdPersona = item.IdPersona;
                        Info.Nom_Beneficiario = item.Nom_Beneficiario;
                        Info.Fecha_Fa_Prov = item.Fecha_Fa_Prov;
                        Info.Observacion = item.Observacion;
                        Info.Valor_a_pagar = item.Valor_a_pagar;
                        Info.Saldo_x_Pagar_OP = item.Saldo_x_Pagar_OP;
                        Info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                        Info.IdCentroCosto = item.IdCentroCosto;
                        Info.IdSubCentro_Costo = item.IdSubCentro_Costo;
                        Info.IdFormaPago = item.IdFormaPago;
                        Info.co_baseImponible = item.BaseImponible;
                        Info.co_valoriva = item.co_valoriva;
                        Info.co_total = item.co_total;
                        Info.IdProveedor = item.IdProveedor;

                        Lista.Add(Info);
                    }
                }

                return Lista;
            }
            catch (Exception e)
            {                
                throw e;
            }
        }
    }
}
