using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt041_Data
    {
        public List<XCXP_Rpt041_Info> Get_Lista_Reporte(int IdEmpresa, string IdTipo_Persona, int IdEntidad, DateTime Fecha_Desde, DateTime Fecha_Hasta)
        {
            try
            {
                List<XCXP_Rpt041_Info> Lista = new List<XCXP_Rpt041_Info>();

                using (EntitiesCXP_General Conexion = new EntitiesCXP_General())
                {
                    var query = from q in Conexion.spCXP_Rpt041(IdEmpresa, IdTipo_Persona, IdEntidad, Fecha_Desde, Fecha_Hasta)
                                select q;

                    foreach (var item in query)
                    {
                        XCXP_Rpt041_Info Info = new XCXP_Rpt041_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdOrdenPago = item.IdOrdenPago;
                        Info.IdTipo_op = item.IdTipo_op;
                        Info.IdTipo_Persona = item.IdTipo_Persona;
                        Info.IdPersona = item.IdPersona;
                        Info.IdEntidad = item.IdEntidad;
                        Info.Fecha = item.Fecha;
                        Info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                        Info.IdFormaPago = item.IdFormaPago;
                        Info.Fecha_Pago = item.Fecha_Pago;
                        Info.IdBanco = item.IdBanco;
                        Info.Estado = item.Estado;
                        Info.pe_nombreCompleto = item.pe_nombreCompleto;
                        Info.Total_OP = item.Total_OP;
                        Info.Total_cancelado = item.Total_cancelado;
                        Info.Saldo = item.Saldo;
                        Info.Observacion = item.Observacion;
                        Info.IdTipoFlujo = item.IdTipoFlujo;
                        Info.nom_tipoFlujo = item.nom_tipoFlujo;
                        Info.EstadoCancelacion = item.EstadoCancelacion;
                        Info.Descripcion = item.Descripcion;
                        Info.Idcancelacion = item.Idcancelacion;
                        Info.IdOrdenPago_op = item.IdOrdenPago_op;
                        Info.IdEmpresa_cxp = item.IdEmpresa_cxp;
                        Info.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                        Info.TipoCbte_cxp = item.TipoCbte_cxp;
                        Info.IdCbteCble_cxp = item.IdCbteCble_cxp;
                        Info.Num_Documento = item.Num_Documento;
                        Info.IdEmpresa_pago = item.IdEmpresa_pago;
                        Info.IdTipoCbte_pago = item.IdTipoCbte_pago;
                        Info.TipoCbte_pago = item.TipoCbte_pago;
                        Info.IdCbteCble_pago = item.IdCbteCble_pago;
                        Info.MontoAplicado = item.MontoAplicado;
                        Info.SaldoActual = item.SaldoActual;
                        Info.SaldoAnterior = item.SaldoAnterior;
                        Info.Referencia = item.Referencia;
                        Info.fechaTransaccion = item.fechaTransaccion;

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